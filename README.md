# Extending-Microsoft-Dynamics-NAV-2016-Cookbook
Code bundle for Extending Microsoft Dynamics NAV 2016 Cookbook

This is the code repository for [Extending Microsoft Dynamics NAV 2016 Cookbook](hhttps://www.packtpub.com/application-development/extending-microsoft-dynamics-nav-2016-cookbook?utm_source=github&utm_medium=repository&utm_content=9781786460608), published by Packt. It contains all the supporting project files necessary to work through the book from start to finish.

There are no code files for chapter 6 and chapter 10. Most of the code in chapter 6 are generated automatically by Visual Studio with small manual modifications. Chapter 10 is all about PowerShell command-line interface, hence no code files too.

##Instructions and Navigation
All of the code is organized into folders. Each folder starts with number followed by the application name. For example, Chapter02.

You will see code something similar to the following:

```
WITH ItemCertificateAction DO BEGIN
 SETRANGE("Item No.",ItemNo);
 SETFILTER("Expiration Date",'>=%1',CertificateDate);
 FINDLAST;
 EXIT("Certificate No.");
 END;
```

Software and Hardware List

| Chapter  | Software required         | OS required      | Free/Proprietary    | Download links to the software           |
| -------- | ------------------------  | -----------------|---------------------|------------------------------------------|
 All        Microsoft Dynamics Nav 2016
|          | with Developer license    | Windows          |  Proprietary        |                                          |          
|          |                           |                                        |
| All      |MS SQL Server 2012 Express | Windows          |  Free               |https://www.microsoft.com/enus/download/details.aspx?id=29062   
|          |                           |                  |                     |                                | 
| 3        |  Visual Studio 2012       | Windows          |Proprietary, can be  | https://www.microsoft.com/net/core        |
|          |   Professional            |                  |  replaced with free |                                           |
|          |                           |                  | Microsoft SQL Server|                                           |
|          |                           |                  |                     |                                | 
|          |                           |                  |  2012 Report Builder|                                           |
|3, 4, 5   | Microsoft Office  2016    | Windows          | Proprietary         |
|          |                           |                  |                     |                                | 
|   3      |  Power BI                 |                  |  Free               | https://powerbi.microsoft.com/en-us/      |
|          |                           |                  |                     |                                | 
|   3      |   R                       |                  |  Free               |  https://cran.r-project.org               |
|          |                           |                  |                     |                                | 
|4, 5, 7, 8| Visual Studio 2012        |                  | Proprietary, can be |
             Professional                                   replaced with free   https://code.visualstudio.com/            |
                                                            Visual Studio Code  
|          |                           |                  |                     |                                | 
|    6     | SharePoint Server 2016 Or |                  |  Proprietary        |                                           |   
|          |  SharePoint Online        |                  |
|          |                           |                  |                     |                                | 
|    8     | Java SE Development Kit   |                  | Free                |http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html
|          |                           |                  |                       
|    8     | IDE Eclipse               |                  | Free                |https://www.eclipse.org/downloads/download.php?file=/oomph/epp/neon/R1/eclipse-inst-win64.exe
|          |                           |                  |                        
|   10     |Windows Management         |                  | Free                |https://www.microsoft.com/enus/download/details.aspx?id=34595
|          | Framework 3.0             | Windows 7        |                     |      
|          |                           | Integrated in    |                     |                          
|          |                           | Windows 8 and    |                     |
|          |                           | higher           |                     |

##Related IBM topics:

* [Programming Microsoft Dynamics™ NAV 2015](https://www.packtpub.com/big-data-and-business-intelligence/programming-microsoft-dynamics%E2%84%A2-nav-2015?utm_source=github&utm_medium=repository&utm_content=9781784394202)

* [Microsoft Dynamics CRM 2016 Customization - Second Edition](https://www.packtpub.com/application-development/microsoft-dynamics-crm-2016-customization-second-edition?utm_source=github&utm_medium=repository&utm_content=9781785881510)

* [Microsoft Dynamics NAV 2015 Professional Reporting](https://www.packtpub.com/big-data-and-business-intelligence/microsoft-dynamics-nav-2015-professional-reporting?utm_source=github&utm_medium=repository&utm_content=9781785284731)

### Suggestions and Feedback
[Click here] (https://docs.google.com/forms/d/e/1FAIpQLSe5qwunkGf6PUvzPirPDtuy1Du5Rlzew23UBp2S-P3wB-GcwQ/viewform) if you have any feedback or suggestions.
