using System;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace NavServiceController
{
    public class NavServiceStatusController
    {
        public event EventHandler<string> ServiceStarted;
        public event EventHandler<string> ServiceStopped;
        public event EventHandler<string> OperationFailed;

        protected virtual void OnServiceStartedEvent(string serviceName)
        {
            EventHandler<string> handler = ServiceStarted;
            handler(this, serviceName);
        }

        protected virtual void OnServiceStoppedEvent(string serviceName)
        {
            EventHandler<string> handler = ServiceStopped;
            handler(this, serviceName);
        }

        protected virtual void OnOperationFailedEvent(string serviceName)
        {
            EventHandler<string> handler = OperationFailed;
            handler(this, serviceName);
        }

        public bool StartService(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status != ServiceControllerStatus.Stopped)
                return false;

            Task awaitResponse = Task.Run(() =>
            {
                    controller.Start();
                    controller.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(30 * TimeSpan.TicksPerSecond));
            });

            awaitResponse.ContinueWith(antecedent => OnServiceStartedEvent(serviceName), TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);
            awaitResponse.ContinueWith(antecedent => OnOperationFailedEvent(serviceName), TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);

            return true;
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public bool StopService(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status != ServiceControllerStatus.Running)
                return false;

            Task awaitResponse = Task.Run(() =>
            {
                    controller.Stop();
                    controller.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(30 * TimeSpan.TicksPerSecond));
            });

            awaitResponse.ContinueWith(antecedent => OnServiceStoppedEvent(serviceName), TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);
            awaitResponse.ContinueWith(antecedent => OnOperationFailedEvent(serviceName), TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);

            return true;
        }
    }
}
