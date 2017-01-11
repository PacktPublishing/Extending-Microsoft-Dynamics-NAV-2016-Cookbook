package postCodeInfoClient;

import java.net.*;
import javax.xml.namespace.*;
import schemas.dynamics.microsoft.codeunit.postcodeinfo.*;

class MyAuthenticator extends Authenticator { 
	  public PasswordAuthentication getPasswordAuthentication() {
		  String userName = "<username>";
		  String password = "<password>";
		  return (new PasswordAuthentication(userName, password.toCharArray()));
	  }
}

public class PostCode {
	public static void main(String[] args) {
		Authenticator.setDefault(new MyAuthenticator());
		
		URL wsURL;
		try {
			wsURL = new URL("http://localhost:7057/NAV2016_WebService/WS/Codeunit/PostCodeInfo");
		} catch (MalformedURLException e) {
			e.printStackTrace();
			return;
		}
		
		QName wsQName = new QName("urn:microsoft-dynamics-schemas/codeunit/PostCodeInfo", "PostCodeInfo"); 
		PostCodeInfo postCodeInfo = new PostCodeInfo(wsURL, wsQName);
		PostCodeInfoPort postCodeInfoPort = postCodeInfo.getPostCodeInfoPort();
		String city = postCodeInfoPort.getCityByPostCode("DK-2950");
		
		System.out.println("City: " + city); 
	}

}
