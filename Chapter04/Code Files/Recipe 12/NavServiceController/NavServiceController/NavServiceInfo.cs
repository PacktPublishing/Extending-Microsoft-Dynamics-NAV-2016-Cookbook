using System.Xml;
using System.ServiceProcess;

namespace NavServiceController
{
    public static class NavServiceInfo
    {
        public static XmlDocument GetNavServices()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootNode = xmlDoc.CreateElement("Controllers");
            xmlDoc.AppendChild(rootNode);

            ServiceController[] controllers = ServiceController.GetServices();
            foreach (ServiceController controller in controllers)
                if (controller.ServiceName.StartsWith("MicrosoftDynamicsNavServer"))
                    rootNode.AppendChild(CreateControllerNode(xmlDoc, controller));

            return xmlDoc;
        }

        private static XmlElement CreateControllerNode(XmlDocument xmlDoc, ServiceController controller)
        {
            XmlElement controllerNode = xmlDoc.CreateElement("Controller");
            AppendXmlChildNode(xmlDoc, controllerNode, "DisplayName", controller.DisplayName);
            AppendXmlChildNode(xmlDoc, controllerNode, "ServiceName", controller.ServiceName);
            AppendXmlChildNode(xmlDoc, controllerNode, "Status", controller.Status.ToString());

            return controllerNode;
        }

        private static void AppendXmlChildNode(XmlDocument xmlDoc, XmlNode parentNode, string nodeName, string nodeValue)
        {
            XmlElement node = xmlDoc.CreateElement(nodeName);
            node.InnerText = nodeValue;
            parentNode.AppendChild(node);
        }
    }
}
