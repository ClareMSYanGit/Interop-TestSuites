![alt tag](/Doc-Images/ExLogo.png)

Exchange EWS Test Suite Deployment Guide

Overview
======================================================================================================

The Exchange Server EWS Protocol Test Suites are implemented as
synthetic clients running against a server-side implementation of a
given Exchange protocol. They are designed in a client-to-server
relationship and were originally developed for the in-house testing of
the Microsoft Open Specifications. Test Suites have been used
extensively in Plugfests and Interoperability Labs to test partner
implementations.

The Exchange EWS Test Suite Deployment Guide introduces the hardware and
software requirements of the test suite client, and the requirements of
the system under test (SUT) if the test suites run against Exchange
Server. The guide also introduces how to deploy, configure and run the
test suites, and view test suite reports.

Prerequisites
=========================================================================================================================================================================================================

This section describes the hardware and software requirements for the
test suites. In an Exchange server environment, the test suite
installation takes place on both the client and server side. The
following information will help test suite users to plan their
deployment.

<span id="_Toc308770202" class="anchor"><span id="_Toc397328552" class="anchor"><span id="_Toc404089093" class="anchor"></span></span></span>Hardware requirements
------------------------------------------------------------------------------------------------------------------------------------------------------------------

### <span id="_Toc397328553" class="anchor"><span id="_Toc404089094" class="anchor"><span id="_Toc308770203" class="anchor"></span></span></span>System under test

The SUT is the server side of the test suite environment. Exchange
server(s) and Active Directory have defined system requirements which
should be taken into account during deployment. The Exchange Server EWS
Protocol test suites do not have any additional SUT resource
requirements.

### <span id="_Toc397328554" class="anchor"><span id="_Toc404089095" class="anchor"></span></span>Test suite client

The test suite client is the client side of the test suite environment.
The following table shows the minimum resource requirements for the test
suite client.

Test suite client resource requirements

  Component   Test suite client minimum requirement
  ----------- ---------------------------------------
  RAM         2GB
  Hard Disk   3G of free space
  Processor   &gt;= 1GHz

<span id="_Toc397328555" class="anchor"><span id="_Toc404089096" class="anchor"></span></span>Software requirements
-------------------------------------------------------------------------------------------------------------------

### <span id="_Toc308770208" class="anchor"><span id="_Toc397328556" class="anchor"><span id="_Toc404089097" class="anchor"><span id="_Toc308770207" class="anchor"></span></span></span></span>System under test 

This section is only relevant when running the test suites against the
following versions of Exchange Server:

-   Microsoft Exchange Server 2007 Service Pack 3 (SP3)

-   Microsoft Exchange Server 2010 Service Pack 3 (SP3)

-   Microsoft Exchange Server 2013 Service Pack 1 (SP1)

The following table describes the necessary server roles required for a
test suite deployment with a Microsoft implementation. Installing
Exchange Server on a domain controller (DC) is not recommended.

Required SUT roles

  Role                                             Description
  ------------------------------------------------ ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  **Active Directory Domain Controller (AD DC)**   Active Directory Domain Controller provides secure data for users and computers. An AD DC can coexist with an Exchange server. A typical test configuration has an AD DC and Exchange Server installed on separate machines.
  **Exchange Server (SUT)**                        The Exchange server in the topology.

<span id="_SUT_resource_requirements" class="anchor"></span>The
following diagram is an example of what a typical Exchange test suite
environment may look like. This example uses an IPv4, but IPv6 is also
supported by the test suites.

### <span id="_Toc397328557" class="anchor"><span id="_Toc404089098" class="anchor"></span></span>Test suite client

This section describes the prerequisite software for installing the
Exchange Server EWS Protocol test suites on the test suite client.<span
id="_Pre-requisites/Dependencies" class="anchor"></span> The following
table outlines the software dependencies for the test suite client.

Test suite client software dependencies

  --------------------------------------------------------------------------------
  **Operating systems**   Windows 7 x64 Service Pack 1 and above
                          
                          Windows 8 x64 and above
                          
                          Windows 2008 R2 x64 Service Pack 1 and above
  ----------------------- --------------------------------------------------------
  **Software**            Microsoft Visual Studio 2013 Professional
                          
                          Microsoft Protocol Test Framework 1.0.2220.0 and above
  --------------------------------------------------------------------------------

<span id="_Toc397328558" class="anchor"><span id="_Toc404089099" class="anchor"></span></span>Deploying the test suites
=======================================================================================================================

<span id="_Installation_instructions_2" class="anchor"></span>This
section describes the deployment of the Exchange Server EWS Protocol
test suites on the test suite client and the SUT. The Exchange Server
EWS Protocol test suites are packaged in a .zip file which is available
on [Microsoft Connect](http://go.microsoft.com/fwlink/?LinkId=516921).
Once you download the test suites, you need to perform the following
steps in order to be able to successfully configure the test suites.

1.  Extract the **Exchange Server EWS Protocol Test Suites** folder to a
    directory of your choice on the test suite client.

2.  Copy the **SUT** folder under **…\\Exchange Server EWS Protocol Test
    Suites\\Setup** to a directory of your choice on the SUT. The SUT
    configuration scripts are the only requirement for the SUT. The
    scripts facilitate the SUT configuration process and are contained
    within the **ExchangeServerEWSProtocolTestSuites.zip** file.

<span id="_Toc402445911" class="anchor"><span id="_Toc402541983" class="anchor"><span id="_Toc402863725" class="anchor"><span id="_Toc402864874" class="anchor"><span id="_Test_suite_client" class="anchor"><span id="_Test_suite_directories" class="anchor"><span id="_Test_suite_client_1" class="anchor"><span id="_Installation_Instructions_1" class="anchor"><span id="_Installation_Instructions" class="anchor"><span id="_Toc387851232" class="anchor"><span id="_Toc404089100" class="anchor"><span id="_Toc308770209" class="anchor"><span id="_Toc397328559" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span>Test suite directories
===========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

In this section you will find a list of the folder structures that are
contained within the **ExchangeServerEWSProtocolTestSuites.zip** file.

ExchangeServerEWSProtocolTestSuites.zip file contents

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Directory/file                                       Description
  ---------------------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  EULA.rtf                                             The End-User License Agreement

  ReadMe.txt                                           A file that contains information about the deployment guide and prerequisite software.

  Exchange Server EWS Protocol Test Suites             

  - Docs                                               A directory that contains documents of all protocol test suites.

  - ExchangeEWSTestSuiteDeploymentGuide.docx           A file relevant to the protocol test suite deployment guidance

  -                                                    Contains test suite-specific configuration details, architecture, and test case details.
                                                       
  ExchangeEWSTestSuiteSpecification.docx               

  + MS-XXXX                                            MS-XXXX Help documentation

  - \[MS-XXXX\].pdf                                    The technical specification for the protocol.

  - MS-XXXX \_SUTControlAdapter.chm                    Contains information about the SUT control adapter class library such as declaration syntaxes and their description.

  - MS-XXXX \_RequirementSpecification.xlsx            A spreadsheet that outlines all requirements associated with the technical specification.

  - Setup                                              A directory that contains configuration scripts.

  - Test Suite Client                                  A directory that contains the configuration script to configure the test suite client.

  - ExchangeClientConfiguration.cmd                    A command file that runs the ExchangeClientConfiguration.ps1 file to configure the properties for the protocol test suites.

  - ExchangeClientConfiguration.ps1                    A configuration script that will be triggered by the ExchangeClientConfiguration.cmd.

  - SUT                                                A folder that contains the configuration script to configure the Exchange Server

  - ExchangeSUTConfiguration.cmd                       A command file that runs the ExchangeSUTConfiguration.ps1 file to create resources and configure settings on the SUT.

  - ExchangeSUTConfiguration.ps1                       A configuration script that will be triggered by ExchangeSUTConfiguration.cmd.

  - Common                                             A directory that contains common configuration scripts.

  - CommonConfiguration.ps1                            A configuration script to configure the common information of the server and the test suite client.

  - ExchangeCommonConfiguration.ps1                    A configuration script to configure the common information of Exchange server.

  - ExchangeTestSuite.config                           A configuration file that contains primary SUT configuration resources of all protocol test suites.

  - Source                                             A folder with Microsoft Visual Studio solutions that contain source code for the test suites.

  - Common                                             A folder with Microsoft Visual Studio projects that contains source code that are common to the test suites.

  - ExchangeCommonConfiguration.deployment.ptfconfig   The common configuration file.

  - ExchangeEWSProtocolTestSuites.sln                  A Visual Studio solution that contains projects of the protocol test suites source code.

  - ExchangeServerEWSProtocolTestSuites.runsettings    A configuration file used for unit test.

  - ExchangeServerEWSProtocolTestSuites.testsettings   A configuration file used for running test cases.

  - MS-XXXX                                            MS-XXXX test suite code directory.

  - MS-XXXX.sln                                        A Microsoft Visual Studio solution that contains projects of the MS-XXXX test suite.

  - MS-XXXX.runsettings                                A configuration file used for MS-XXXX unit test.

  - MS-XXXX.testsettings                               A configuration file used for running MS-XXXX test cases.

  + Adapter                                            Adapter test suite code.

  + TestSuite                                          Test suite code.

  - Scripts                                            Exchange Server EWS test suites can be run using Visual Studio or through batch scripts. The Scripts directory contains a collection of command files that allows users to run specific test cases in the test suite, or the entire test suite.

  - RunAllExchangeEWSTestCases.cmd                     A script that can be used to run all test cases in the package.

  - MS-XXXX                                            A folder containing scripts that belong to the MS-XXXX test suite.

  - RunAllMSXXXXTestCases.cmd                          A script that can be used to run all test cases of MS-XXXX.

  - RunMSXXXX\_SXX\_TCXX\_Name.cmd                     A script that can be used to run a single test case of MS-XXXX.
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Toc402446010" class="anchor"><span id="_Toc402542082" class="anchor"><span id="_Toc402863824" class="anchor"><span id="_Toc402864973" class="anchor"><span id="_Toc402446179" class="anchor"><span id="_Toc402542251" class="anchor"><span id="_Toc402863993" class="anchor"><span id="_Toc402865142" class="anchor"><span id="_Toc404089101" class="anchor"></span></span></span></span></span></span></span></span></span>Configuring the test suites
==================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section provides the necessary guidance to configure the Exchange
Server EWS Protocol test suites on the SUT and the test suite client.
The configuration should be done in this order: configure the SUT, and
then configure the test suite client.

For the configuration script, the exit code definition is as follows:

1.  A normal termination will set the exit code to 0.

2.  An uncaught THROW will set the exit code to 1.

3.  Script execution warning and issues will set the exit code to 2.

4.  Exit code is set to the actual error code for other issues.

<span id="_Toc402446372" class="anchor"><span id="_Toc402542444" class="anchor"><span id="_Toc402864186" class="anchor"><span id="_Toc402865335" class="anchor"><span id="_Toc402446373" class="anchor"><span id="_Toc402542445" class="anchor"><span id="_Toc402864187" class="anchor"><span id="_Toc402865336" class="anchor"><span id="_Toc402446374" class="anchor"><span id="_Toc402542446" class="anchor"><span id="_Toc402864188" class="anchor"><span id="_Toc402865337" class="anchor"><span id="_Toc402446375" class="anchor"><span id="_Toc402542447" class="anchor"><span id="_Toc402864189" class="anchor"><span id="_Toc402865338" class="anchor"><span id="_Toc402446376" class="anchor"><span id="_Toc402542448" class="anchor"><span id="_Toc402864190" class="anchor"><span id="_Toc402865339" class="anchor"><span id="_Toc397328560" class="anchor"><span id="_Toc404089102" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the SUT
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

You can configure the SUT using automated scripts, as described in
sections [5.1.2](#_Configuring_the_SUT1_2); or configure the SUT
manually, as described in section [5.1.3](#_Configuring_the_SUT1).

**Note**   The scripts should be run by a user who has domain
administrator rights with a mailbox on the SUT.

### <span id="_Configuring_the_SUT1_1" class="anchor"><span id="_Toc397328561" class="anchor"><span id="_Toc404089103" class="anchor"></span></span></span>SUT resource requirements 

Each test suite contained within the Exchange Server EWS Protocol test
suites package may require/ varying levels of resources on the SUT. The
following table outlines these resources for each test suite. The SUT
configuration scripts will automatically create all the required
resources for the Microsoft server implementation. To configure the SUT
manually, see section [5.1.3](#_Configuring_the_SUT1).

The client configuration script follows the naming convention shown in
the following table. If a change to the resource name is required, the
corresponding change to the resource name defined in the client
configuration script will be required.

Exchange server resources

  Test suite    Resource type            Resource name                     Note
  ------------- ------------------------ --------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------
  All           --                       --                                
  MS-OXWSATT    Mailbox                  MSOXWSATT\_User01                 Mailbox type user
  MS-OXWSBTRF   Mailbox                  MSOXWSBTRF\_User01                Mailbox type user
  MS-OXWSCONT   Mailbox                  MSOXWSCONT\_User01                Mailbox type user
  MS-OXWSCORE   Mailbox                  MSOXWSCORE\_User01                Mailbox type user
                Mailbox                  MSOXWSCORE\_User02                Mailbox type user
                Public Folder Mailbox    MSOXWSCORE\_PublicFolderMailbox   Public Folder Mailbox created for the public folder of the organization configuration of Exchange 2013.
                Public Folder            MSOXWSCORE\_PublicFolder          
  MS-OXWSFOLD   Mailbox                  MSOXWSFOLD\_User01                Mailbox type user
                Mailbox                  MSOXWSFOLD\_User02                Mailbox type user
                ManagedFolder            MSOXWSFOLD\_ManagedFolder1        Managed folder created directly in the root path of Outlook
                ManagedFolder            MSOXWSFOLD\_ManagedFolder2        Managed folder created directly in the root path of Outlook
                Public Folder Database   PublicFolderDatabase              Public Folder Database created for the mailbox of the organization configuration of Exchange 2010 and for the server configuration of Exchange 2007.
  MS-OXWSMSG    Mailbox                  MSOXWSMSG\_User01                 Mailbox type user
                Mailbox                  MSOXWSMSG\_User02                 Mailbox type user
                Mailbox                  MSOXWSMSG\_User03                 Mailbox type user
                Mailbox                  MSOXWSMSG\_Room01                 Mailbox type room
  MS-OXWSMTGS   Mailbox                  MSOXWSMTGS\_User01                Mailbox type user
                Mailbox                  MSOXWSMTGS\_User02                Mailbox type user
                Mailbox                  MSOXWSMTGS\_Room01                Mailbox type room
  MS-OXWSSYNC   Mailbox                  MSOXWSSYNC\_User01                Mailbox type user
                Mailbox                  MSOXWSSYNC\_User02                Mailbox type user
  MS-OXWSTASK   Mailbox                  MSOXWSTASK\_User01                Mailbox type user

### <span id="_Toc402441356" class="anchor"><span id="_Toc402446409" class="anchor"><span id="_Toc402542481" class="anchor"><span id="_Toc402864223" class="anchor"><span id="_Toc402865372" class="anchor"><span id="_Toc402441366" class="anchor"><span id="_Toc402446419" class="anchor"><span id="_Toc402542491" class="anchor"><span id="_Toc402864233" class="anchor"><span id="_Toc402865382" class="anchor"><span id="_Toc402441371" class="anchor"><span id="_Toc402446424" class="anchor"><span id="_Toc402542496" class="anchor"><span id="_Toc402864238" class="anchor"><span id="_Toc402865387" class="anchor"><span id="_Toc402441376" class="anchor"><span id="_Toc402446429" class="anchor"><span id="_Toc402542501" class="anchor"><span id="_Toc402864243" class="anchor"><span id="_Toc402865392" class="anchor"><span id="_Toc402441381" class="anchor"><span id="_Toc402446434" class="anchor"><span id="_Toc402542506" class="anchor"><span id="_Toc402864248" class="anchor"><span id="_Toc402865397" class="anchor"><span id="_Toc402441391" class="anchor"><span id="_Toc402446444" class="anchor"><span id="_Toc402542516" class="anchor"><span id="_Toc402864258" class="anchor"><span id="_Toc402865407" class="anchor"><span id="_Toc402441396" class="anchor"><span id="_Toc402446449" class="anchor"><span id="_Toc402542521" class="anchor"><span id="_Toc402864263" class="anchor"><span id="_Toc402865412" class="anchor"><span id="_Toc402441401" class="anchor"><span id="_Toc402446454" class="anchor"><span id="_Toc402542526" class="anchor"><span id="_Toc402864268" class="anchor"><span id="_Toc402865417" class="anchor"><span id="_Toc402441411" class="anchor"><span id="_Toc402446464" class="anchor"><span id="_Toc402542536" class="anchor"><span id="_Toc402864278" class="anchor"><span id="_Toc402865427" class="anchor"><span id="_Toc402441416" class="anchor"><span id="_Toc402446469" class="anchor"><span id="_Toc402542541" class="anchor"><span id="_Toc402864283" class="anchor"><span id="_Toc402865432" class="anchor"><span id="_Toc402441426" class="anchor"><span id="_Toc402446479" class="anchor"><span id="_Toc402542551" class="anchor"><span id="_Toc402864293" class="anchor"><span id="_Toc402865442" class="anchor"><span id="_Toc402441446" class="anchor"><span id="_Toc402446499" class="anchor"><span id="_Toc402542571" class="anchor"><span id="_Toc402864313" class="anchor"><span id="_Toc402865462" class="anchor"><span id="_Toc402441451" class="anchor"><span id="_Toc402446504" class="anchor"><span id="_Toc402542576" class="anchor"><span id="_Toc402864318" class="anchor"><span id="_Toc402865467" class="anchor"><span id="_Toc402441456" class="anchor"><span id="_Toc402446509" class="anchor"><span id="_Toc402542581" class="anchor"><span id="_Toc402864323" class="anchor"><span id="_Toc402865472" class="anchor"><span id="_Toc402441466" class="anchor"><span id="_Toc402446519" class="anchor"><span id="_Toc402542591" class="anchor"><span id="_Toc402864333" class="anchor"><span id="_Toc402865482" class="anchor"><span id="_Toc402441471" class="anchor"><span id="_Toc402446524" class="anchor"><span id="_Toc402542596" class="anchor"><span id="_Toc402864338" class="anchor"><span id="_Toc402865487" class="anchor"><span id="_Toc402441476" class="anchor"><span id="_Toc402446529" class="anchor"><span id="_Toc402542601" class="anchor"><span id="_Toc402864343" class="anchor"><span id="_Toc402865492" class="anchor"><span id="_Toc402441486" class="anchor"><span id="_Toc402446539" class="anchor"><span id="_Toc402542611" class="anchor"><span id="_Toc402864353" class="anchor"><span id="_Toc402865502" class="anchor"><span id="_Toc402441491" class="anchor"><span id="_Toc402446544" class="anchor"><span id="_Toc402542616" class="anchor"><span id="_Toc402864358" class="anchor"><span id="_Toc402865507" class="anchor"><span id="_Toc402441496" class="anchor"><span id="_Toc402446549" class="anchor"><span id="_Toc402542621" class="anchor"><span id="_Toc402864363" class="anchor"><span id="_Toc402865512" class="anchor"><span id="_Toc402441506" class="anchor"><span id="_Toc402446559" class="anchor"><span id="_Toc402542631" class="anchor"><span id="_Toc402864373" class="anchor"><span id="_Toc402865522" class="anchor"><span id="_Toc402441511" class="anchor"><span id="_Toc402446564" class="anchor"><span id="_Toc402542636" class="anchor"><span id="_Toc402864378" class="anchor"><span id="_Toc402865527" class="anchor"><span id="_Toc402441521" class="anchor"><span id="_Toc402446574" class="anchor"><span id="_Toc402542646" class="anchor"><span id="_Toc402864388" class="anchor"><span id="_Toc402865537" class="anchor"><span id="_Toc402441536" class="anchor"><span id="_Toc402446589" class="anchor"><span id="_Toc402542661" class="anchor"><span id="_Toc402864403" class="anchor"><span id="_Toc402865552" class="anchor"><span id="_Toc402441546" class="anchor"><span id="_Toc402446599" class="anchor"><span id="_Toc402542671" class="anchor"><span id="_Toc402864413" class="anchor"><span id="_Toc402865562" class="anchor"><span id="_Toc402441556" class="anchor"><span id="_Toc402446609" class="anchor"><span id="_Toc402542681" class="anchor"><span id="_Toc402864423" class="anchor"><span id="_Toc402865572" class="anchor"><span id="_Toc402441561" class="anchor"><span id="_Toc402446614" class="anchor"><span id="_Toc402542686" class="anchor"><span id="_Toc402864428" class="anchor"><span id="_Toc402865577" class="anchor"><span id="_Toc402441571" class="anchor"><span id="_Toc402446624" class="anchor"><span id="_Toc402542696" class="anchor"><span id="_Toc402864438" class="anchor"><span id="_Toc402865587" class="anchor"><span id="_Toc402441581" class="anchor"><span id="_Toc402446634" class="anchor"><span id="_Toc402542706" class="anchor"><span id="_Toc402864448" class="anchor"><span id="_Toc402865597" class="anchor"><span id="_Toc402441586" class="anchor"><span id="_Toc402446639" class="anchor"><span id="_Toc402542711" class="anchor"><span id="_Toc402864453" class="anchor"><span id="_Toc402865602" class="anchor"><span id="_Toc402441591" class="anchor"><span id="_Toc402446644" class="anchor"><span id="_Toc402542716" class="anchor"><span id="_Toc402864458" class="anchor"><span id="_Toc402865607" class="anchor"><span id="_Toc402441601" class="anchor"><span id="_Toc402446654" class="anchor"><span id="_Toc402542726" class="anchor"><span id="_Toc402864468" class="anchor"><span id="_Toc402865617" class="anchor"><span id="_Toc402441611" class="anchor"><span id="_Toc402446664" class="anchor"><span id="_Toc402542736" class="anchor"><span id="_Toc402864478" class="anchor"><span id="_Toc402865627" class="anchor"><span id="_Toc402441616" class="anchor"><span id="_Toc402446669" class="anchor"><span id="_Toc402542741" class="anchor"><span id="_Toc402864483" class="anchor"><span id="_Toc402865632" class="anchor"><span id="_Toc402441621" class="anchor"><span id="_Toc402446674" class="anchor"><span id="_Toc402542746" class="anchor"><span id="_Toc402864488" class="anchor"><span id="_Toc402865637" class="anchor"><span id="_Toc402441626" class="anchor"><span id="_Toc402446679" class="anchor"><span id="_Toc402542751" class="anchor"><span id="_Toc402864493" class="anchor"><span id="_Toc402865642" class="anchor"><span id="_Toc402441631" class="anchor"><span id="_Toc402446684" class="anchor"><span id="_Toc402542756" class="anchor"><span id="_Toc402864498" class="anchor"><span id="_Toc402865647" class="anchor"><span id="_Toc402441636" class="anchor"><span id="_Toc402446689" class="anchor"><span id="_Toc402542761" class="anchor"><span id="_Toc402864503" class="anchor"><span id="_Toc402865652" class="anchor"><span id="_Toc402441646" class="anchor"><span id="_Toc402446699" class="anchor"><span id="_Toc402542771" class="anchor"><span id="_Toc402864513" class="anchor"><span id="_Toc402865662" class="anchor"><span id="_Configuring_the_SUT1_2" class="anchor"><span id="_Toc397328562" class="anchor"><span id="_Toc404089104" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring SUT using the setup configuration script

The setup configuration script is only used for configuring the SUT on
the Windows platform.

To configure SUT using the setup configuration script, navigate to the
**SUT** folder, right-click **ExchangeSUTConfiguration.cmd** and select
**Run as administrator**.

### <span id="_Configuring_the_SUT1" class="anchor"><span id="_Toc397328563" class="anchor"><span id="_Toc404089105" class="anchor"></span></span></span>Configuring SUT manually

If the SUT is a non-Microsoft implementation of Exchange Server, you
will not be able to run the setup configuration script. The following
steps explain what needs to be created or configured on the SUT in order
to run the test suites.

1.  Create the following mailbox users:

MSOXWSATT\_User01, MSOXWSBTRF\_User01, MSOXWSCONT\_User01,
MSOXWSCORE\_User01, MSOXWSCORE\_User02, MSOXWSFOLD\_User01,
MSOXWSFOLD\_User02, MSOXWSMSG\_User01, MSOXWSMSG\_User02,
MSOXWSMSG\_User03, MSOXWSMSG\_Room01, MSOXWSMTGS\_User01,
MSOXWSMTGS\_User02, MSOXWSMTGS\_Room01, MSOXWSSYNC\_User01,
MSOXWSSYNC\_User02, MSOXWSTASK\_User01

1.  Configure Secure Sockets Layer (SSL) as not required and set to
    ignore client certificates on the website which contains the
    application that implements the EWS protocols.

2.  Assign the **ApplicationImpersonation** role to the following
    mailbox users.

> **Note** This role enables applications to impersonate users in an
> organization in order to perform a task on behalf of them.

MS-OXWSATT\_User01, MS-OXWSBTRF\_User01, MSOXWSCORE\_User01,
MSOXWSFOLD\_User01, and MSOXWSSYNC\_User01

1.  Create the following managed folders in Active Directory:

MSOXWSFOLD\_ManagedFolder1 and MSOXWSFOLD\_ManagedFolder2

1.  Create a public folder database.

2.  Grant permissions to the mailbox user MSOXWSFOLD\_User01 to manage
    the public folders.

3.  Create a public folder MSOXWSCORE\_PublicFolderMailbox.

4.  Grant permissions to the mailbox user MSOXWSCORE\_User01 to manager
    the public folder MSOXWSCORE\_PublicFolder.

<span id="_Toc402446706" class="anchor"><span id="_Toc402542778" class="anchor"><span id="_Toc402864520" class="anchor"><span id="_Toc402865669" class="anchor"><span id="_Toc402441653" class="anchor"><span id="_Toc402446707" class="anchor"><span id="_Toc402542779" class="anchor"><span id="_Toc402864521" class="anchor"><span id="_Toc402865670" class="anchor"><span id="_Toc402441654" class="anchor"><span id="_Toc402446708" class="anchor"><span id="_Toc402542780" class="anchor"><span id="_Toc402864522" class="anchor"><span id="_Toc402865671" class="anchor"><span id="_Toc402441655" class="anchor"><span id="_Toc402446709" class="anchor"><span id="_Toc402542781" class="anchor"><span id="_Toc402864523" class="anchor"><span id="_Toc402865672" class="anchor"><span id="_Toc402441656" class="anchor"><span id="_Toc402446710" class="anchor"><span id="_Toc402542782" class="anchor"><span id="_Toc402864524" class="anchor"><span id="_Toc402865673" class="anchor"><span id="_Toc402441657" class="anchor"><span id="_Toc402446711" class="anchor"><span id="_Toc402542783" class="anchor"><span id="_Toc402864525" class="anchor"><span id="_Toc402865674" class="anchor"><span id="_Toc402441658" class="anchor"><span id="_Toc402446712" class="anchor"><span id="_Toc402542784" class="anchor"><span id="_Toc402864526" class="anchor"><span id="_Toc402865675" class="anchor"><span id="_Toc402441659" class="anchor"><span id="_Toc402446713" class="anchor"><span id="_Toc402542785" class="anchor"><span id="_Toc402864527" class="anchor"><span id="_Toc402865676" class="anchor"><span id="_Toc402441660" class="anchor"><span id="_Toc402446714" class="anchor"><span id="_Toc402542786" class="anchor"><span id="_Toc402864528" class="anchor"><span id="_Toc402865677" class="anchor"><span id="_Toc402441661" class="anchor"><span id="_Toc402446715" class="anchor"><span id="_Toc402542787" class="anchor"><span id="_Toc402864529" class="anchor"><span id="_Toc402865678" class="anchor"><span id="_Toc402441662" class="anchor"><span id="_Toc402446716" class="anchor"><span id="_Toc402542788" class="anchor"><span id="_Toc402864530" class="anchor"><span id="_Toc402865679" class="anchor"><span id="_Toc402441663" class="anchor"><span id="_Toc402446717" class="anchor"><span id="_Toc402542789" class="anchor"><span id="_Toc402864531" class="anchor"><span id="_Toc402865680" class="anchor"><span id="_Toc402441664" class="anchor"><span id="_Toc402446718" class="anchor"><span id="_Toc402542790" class="anchor"><span id="_Toc402864532" class="anchor"><span id="_Toc402865681" class="anchor"><span id="_Toc402441665" class="anchor"><span id="_Toc402446719" class="anchor"><span id="_Toc402542791" class="anchor"><span id="_Toc402864533" class="anchor"><span id="_Toc402865682" class="anchor"><span id="_Toc402441666" class="anchor"><span id="_Toc402446720" class="anchor"><span id="_Toc402542792" class="anchor"><span id="_Toc402864534" class="anchor"><span id="_Toc402865683" class="anchor"><span id="_Toc402441667" class="anchor"><span id="_Toc402446721" class="anchor"><span id="_Toc402542793" class="anchor"><span id="_Toc402864535" class="anchor"><span id="_Toc402865684" class="anchor"><span id="_Toc402441668" class="anchor"><span id="_Toc402446722" class="anchor"><span id="_Toc402542794" class="anchor"><span id="_Toc402864536" class="anchor"><span id="_Toc402865685" class="anchor"><span id="_Toc402441669" class="anchor"><span id="_Toc402446723" class="anchor"><span id="_Toc402542795" class="anchor"><span id="_Toc402864537" class="anchor"><span id="_Toc402865686" class="anchor"><span id="_Toc402441670" class="anchor"><span id="_Toc402446724" class="anchor"><span id="_Toc402542796" class="anchor"><span id="_Toc402864538" class="anchor"><span id="_Toc402865687" class="anchor"><span id="_Toc402441671" class="anchor"><span id="_Toc402446725" class="anchor"><span id="_Toc402542797" class="anchor"><span id="_Toc402864539" class="anchor"><span id="_Toc402865688" class="anchor"><span id="_Toc402441672" class="anchor"><span id="_Toc402446726" class="anchor"><span id="_Toc402542798" class="anchor"><span id="_Toc402864540" class="anchor"><span id="_Toc402865689" class="anchor"><span id="_Toc402441673" class="anchor"><span id="_Toc402446727" class="anchor"><span id="_Toc402542799" class="anchor"><span id="_Toc402864541" class="anchor"><span id="_Toc402865690" class="anchor"><span id="_Toc402441674" class="anchor"><span id="_Toc402446728" class="anchor"><span id="_Toc402542800" class="anchor"><span id="_Toc402864542" class="anchor"><span id="_Toc402865691" class="anchor"><span id="_Toc402441675" class="anchor"><span id="_Toc402446729" class="anchor"><span id="_Toc402542801" class="anchor"><span id="_Toc402864543" class="anchor"><span id="_Toc402865692" class="anchor"><span id="_Toc402441676" class="anchor"><span id="_Toc402446730" class="anchor"><span id="_Toc402542802" class="anchor"><span id="_Toc402864544" class="anchor"><span id="_Toc402865693" class="anchor"><span id="_Toc402441677" class="anchor"><span id="_Toc402446731" class="anchor"><span id="_Toc402542803" class="anchor"><span id="_Toc402864545" class="anchor"><span id="_Toc402865694" class="anchor"><span id="_Toc402441678" class="anchor"><span id="_Toc402446732" class="anchor"><span id="_Toc402542804" class="anchor"><span id="_Toc402864546" class="anchor"><span id="_Toc402865695" class="anchor"><span id="_Toc402441679" class="anchor"><span id="_Toc402446733" class="anchor"><span id="_Toc402542805" class="anchor"><span id="_Toc402864547" class="anchor"><span id="_Toc402865696" class="anchor"><span id="_Toc402441680" class="anchor"><span id="_Toc402446734" class="anchor"><span id="_Toc402542806" class="anchor"><span id="_Toc402864548" class="anchor"><span id="_Toc402865697" class="anchor"><span id="_Toc402441681" class="anchor"><span id="_Toc402446735" class="anchor"><span id="_Toc402542807" class="anchor"><span id="_Toc402864549" class="anchor"><span id="_Toc402865698" class="anchor"><span id="_Toc402441682" class="anchor"><span id="_Toc402446736" class="anchor"><span id="_Toc402542808" class="anchor"><span id="_Toc402864550" class="anchor"><span id="_Toc402865699" class="anchor"><span id="_Toc402441683" class="anchor"><span id="_Toc402446737" class="anchor"><span id="_Toc402542809" class="anchor"><span id="_Toc402864551" class="anchor"><span id="_Toc402865700" class="anchor"><span id="_Toc402441684" class="anchor"><span id="_Toc402446738" class="anchor"><span id="_Toc402542810" class="anchor"><span id="_Toc402864552" class="anchor"><span id="_Toc402865701" class="anchor"><span id="_Toc402441685" class="anchor"><span id="_Toc402446739" class="anchor"><span id="_Toc402542811" class="anchor"><span id="_Toc402864553" class="anchor"><span id="_Toc402865702" class="anchor"><span id="_Toc402441686" class="anchor"><span id="_Toc402446740" class="anchor"><span id="_Toc402542812" class="anchor"><span id="_Toc402864554" class="anchor"><span id="_Toc402865703" class="anchor"><span id="_Toc402441687" class="anchor"><span id="_Toc402446741" class="anchor"><span id="_Toc402542813" class="anchor"><span id="_Toc402864555" class="anchor"><span id="_Toc402865704" class="anchor"><span id="_Toc402441688" class="anchor"><span id="_Toc402446742" class="anchor"><span id="_Toc402542814" class="anchor"><span id="_Toc402864556" class="anchor"><span id="_Toc402865705" class="anchor"><span id="_Configuring_the_SUT2_1" class="anchor"><span id="_Toc402441689" class="anchor"><span id="_Toc402446743" class="anchor"><span id="_Toc402542815" class="anchor"><span id="_Toc402864557" class="anchor"><span id="_Toc402865706" class="anchor"><span id="_Configure_the_SUT2" class="anchor"><span id="_Configure_the_SUT2_1" class="anchor"><span id="_Toc402441690" class="anchor"><span id="_Toc402446744" class="anchor"><span id="_Toc402542816" class="anchor"><span id="_Toc402864558" class="anchor"><span id="_Toc402865707" class="anchor"><span id="_Toc402441691" class="anchor"><span id="_Toc402446745" class="anchor"><span id="_Toc402542817" class="anchor"><span id="_Toc402864559" class="anchor"><span id="_Toc402865708" class="anchor"><span id="_Configuring_test_suite" class="anchor"><span id="_Configuring_the_SUT2" class="anchor"><span id="_Toc402441692" class="anchor"><span id="_Toc402446746" class="anchor"><span id="_Toc402542818" class="anchor"><span id="_Toc402864560" class="anchor"><span id="_Toc402865709" class="anchor"><span id="_Toc402441693" class="anchor"><span id="_Toc402446747" class="anchor"><span id="_Toc402542819" class="anchor"><span id="_Toc402864561" class="anchor"><span id="_Toc402865710" class="anchor"><span id="_Toc402441694" class="anchor"><span id="_Toc402446748" class="anchor"><span id="_Toc402542820" class="anchor"><span id="_Toc402864562" class="anchor"><span id="_Toc402865711" class="anchor"><span id="_Toc402441695" class="anchor"><span id="_Toc402446749" class="anchor"><span id="_Toc402542821" class="anchor"><span id="_Toc402864563" class="anchor"><span id="_Toc402865712" class="anchor"><span id="_Toc402441696" class="anchor"><span id="_Toc402446750" class="anchor"><span id="_Toc402542822" class="anchor"><span id="_Toc402864564" class="anchor"><span id="_Toc402865713" class="anchor"><span id="_Toc402441697" class="anchor"><span id="_Toc402446751" class="anchor"><span id="_Toc402542823" class="anchor"><span id="_Toc402864565" class="anchor"><span id="_Toc402865714" class="anchor"><span id="_Toc402441698" class="anchor"><span id="_Toc402446752" class="anchor"><span id="_Toc402542824" class="anchor"><span id="_Toc402864566" class="anchor"><span id="_Toc402865715" class="anchor"><span id="_Toc402441699" class="anchor"><span id="_Toc402446753" class="anchor"><span id="_Toc402542825" class="anchor"><span id="_Toc402864567" class="anchor"><span id="_Toc402865716" class="anchor"><span id="_Toc402441700" class="anchor"><span id="_Toc402446754" class="anchor"><span id="_Toc402542826" class="anchor"><span id="_Toc402864568" class="anchor"><span id="_Toc402865717" class="anchor"><span id="_Toc402441701" class="anchor"><span id="_Toc402446755" class="anchor"><span id="_Toc402542827" class="anchor"><span id="_Toc402864569" class="anchor"><span id="_Toc402865718" class="anchor"><span id="_Configuring_the_test_1" class="anchor"><span id="_Toc397328566" class="anchor"><span id="_Toc404089106" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the test suite client
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

The test suite client is managed through a common configuration file,
two test suite-specific configuration files, and three SHOULD/MAY
configuration files that all have a “.ptfconfig” extension. These
configuration files can be modified directly. The common configuration
file and the test suite-specific configuration files can also be
modified through a script.

### <span id="_Test_Suite_Specific" class="anchor"><span id="Text10" class="anchor"><span id="ControlAdapterConfig" class="anchor"><span id="_Configuring_the_test" class="anchor"><span id="_Toc397328567" class="anchor"><span id="_Toc404089107" class="anchor"></span></span></span></span></span></span>Common configuration file

The common configuration file contains configurable properties common to
all Exchange Server EWS Protocol test suites. This file must be modified
to match the characteristics of the environment where the test suites
are installed.

  **Configuration file**                             **Description**
  -------------------------------------------------- ----------------------------------------------------------------------------------------------------------
  ExchangeCommonConfiguration.deployment.ptfconfig   The deployment configuration file provides the environmental details that are common to the test suites.

### <span id="_Toc397328568" class="anchor"><span id="_Toc404089108" class="anchor"></span></span>Test-suite specific configuration files

In addition to the common configuration file, each individual test suite
has the following two configuration files for test suite-specific
modification.

Test-suite specific configuration files

  Configuration file                        Description
  ----------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_TestSuite.deployment.ptfconfig   The deployment configuration file provides the environmental details that are specific to the test suite. The configuration file allows for the test suite-specific customization.
  MS-XXXX\_TestSuite.ptfconfig              The test suite configuration file contains details that specify the behavior of the test suite operation.

Both files are present in the TestSuite folder inside each test suite
directory.

If you need to modify the common configuration values for a specific
test suite, you must copy the common properties to the
**MS-XXXX\_TestSuite.deployment.ptfconfig** file and change the values
of the properties. The specific configuration file will take precedence
over the common configuration file when the same property exists in both
places.

#### Set the test suite to interactive mode

If the SUT is a non-Microsoft implementation of Exchange Server, it is
recommended that you further configure the test suite by setting the
test suite to interactive mode. Interactive mode enables the test suite
to function in a manual way, enabling you to perform setup, teardown,
and other tasks in a step-by-step approach. To enable interactive mode
for a specific test suite, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.ptfconfig** configuration file
    within the **\\Source\\MS-XXXX\\TestSuite\\**.

<!-- -->

1.  Set the type value of Adapter property to **interactive** for the
    SUT control adapter\*\*.

Interactive mode values

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property name   Default value\*         Optional value    Description
  --------------- ----------------------- ----------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Adapter         managed or powershell   interactive\*\*   **managed**:
                                                            
                                                            The SUT control adapter is implemented in C\# managed code.
                                                            
                                                            **powershell**:
                                                            
                                                            The SUT control adapter is implemented through Windows PowerShell.
                                                            
                                                            **interactive**:
                                                            
                                                            Interactive adapters are used for manually configuring the server. Interactive adapter displays a dialog box to perform a manual test each time one of its methods is called. The dialog box will show the method name, parameter names, and values\*\*\*
  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

\**The Adapter property value is set to either managed or powershell
depending on whether the SUT control adapter was implemented in managed
C\# code or through PowerShell.\
*

\*\* *When changing to interactive mode from managed mode, the
“adaptertype” attribute must be deleted to avoid a runtime error. When
changing to interactive mode from powershell mode, an additional step is
required—delete the “scriptdir” attribute to avoid a runtime error.\
*

\*\*\**When the manual operation completes successfully, enter the
return values (if any) in **Action Results** and click **Succeed** in
the dialog box. When the manual operation is unable to complete, enter
the error messages in the **Failure Message** text box and click
**Fail** to terminate the test. In this case, the test will be treated
as “Inconclusive”.*

Further customization can be done by creating your own SUT control
adapter that matches the server implementation. For more information
about how to create a SUT control adapter, see the Protocol Test
Framework (PTF) user documentation.

#### Configure TSAP broadcast

Test Session Announcement Protocol (TSAP) is used by PTF to broadcast
test information when the test suite is running. TSAP broadcasts helps
in mapping test cases to captured frames.

By default, TSAP packets are broadcasted in the network. Users can
change a TSAP broadcast by adding an entry “BeaconLogTargetServer” to
TestSuite.deployment.ptfconfig to target the TSAP only to the specified
machine.

To change the TSAP packet broadcast, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.deployment.ptfconfig**
    configuration file in the **\\Source\\MS-XXXX\\TestSuite\\** folder.

2.  Add a property “BeaconLogTargetServer” along with the value of the
    specified machine name.

For example: &lt;Property name="BeaconLogTargetServer" value="dc01"
/&gt;

### <span id="_Toc397328569" class="anchor"><span id="_Toc404089109" class="anchor"></span></span>SHOULD/MAY configuration files

The test suite has three SHOULD/MAY configuration files that are
specific to all supported versions of the SUT. Each SHOULD/MAY
requirement have an associated parameter with a value of either “true”
or “false” corresponding to the server version that is supported. “true”
represents that the requirement must be validated, whereas “false” means
that the requirement must not be validated.

If the SUT is a non-Microsoft implementation of Exchange Server,
configure the properties in the configuration file for the Exchange
Server which is the closest match to the SUT implementation.

SHOULD/MAY configuration files

  Configuration file                                            Description
  ------------------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_ExchangeServer2007\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft Exchange Server 2007 Service Pack 3 (SP3).
  MS-XXXX\_ExchangeServer2010\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft Exchange Server 2010 Service Pack 3 (SP3).
  MS-XXXX\_ExchangeServer2013\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft Exchange Server 2013 Service Pack 1 (SP1).

### <span id="_Configuring_the_test_2" class="anchor"><span id="_Toc397328570" class="anchor"><span id="_Toc404089110" class="anchor"></span></span></span>Configuring the test suite client using setup configuration script

<span id="_Configure_the_test" class="anchor"><span
id="_Configure_the_test_1" class="anchor"></span></span>**Note** The
setup configuration script is only implemented for configuring the test
suite client on the Windows platform.

To configure the test suite using the setup configuration script,
navigate to the **Setup\\Test Suite Client**\\ folder, right-click
**ExchangeClientConfiguration.cmd** and select **Run as administrator**.

### <span id="Configuringthetestsuiteclientmanual" class="anchor"><span id="_Toc397328571" class="anchor"><span id="_Toc404089111" class="anchor"><span id="_Toc335752278" class="anchor"></span></span></span></span>Configuring the test suite client manually

If you didn’t use the setup configuration script to configure the test
suite client as described in the previous section, follow the steps
below to update configuration files and configure the test suite client.

1.  Update the property value in the common configuration file and the
    test suite-specific configuration files according to the comment of
    the property.

<span id="_Toc402441708" class="anchor"><span id="_Toc402446762" class="anchor"><span id="_Toc402542834" class="anchor"><span id="_Toc402864576" class="anchor"><span id="_Toc402865725" class="anchor"><span id="_Toc402441709" class="anchor"><span id="_Toc402446763" class="anchor"><span id="_Toc402542835" class="anchor"><span id="_Toc402864577" class="anchor"><span id="_Toc402865726" class="anchor"><span id="_Toc402441710" class="anchor"><span id="_Toc402446764" class="anchor"><span id="_Toc402542836" class="anchor"><span id="_Toc402864578" class="anchor"><span id="_Toc402865727" class="anchor"><span id="_Toc402441711" class="anchor"><span id="_Toc402446765" class="anchor"><span id="_Toc402542837" class="anchor"><span id="_Toc402864579" class="anchor"><span id="_Toc402865728" class="anchor"><span id="_Toc402441712" class="anchor"><span id="_Toc402446766" class="anchor"><span id="_Toc402542838" class="anchor"><span id="_Toc402864580" class="anchor"><span id="_Toc402865729" class="anchor"><span id="_Toc397328572" class="anchor"><span id="_Toc404089112" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Running test suites
========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

<span id="_Toc306892175" class="anchor"></span>Once the required
software has been installed and both the SUT and test suite client have
been configured appropriately, the test suite is ready to run. The test
suite can run only on the test suite client and can be initiated in one
of the following two ways: Visual Studio or batch scripts.

<span id="_Toc397328573" class="anchor"><span id="_Toc404089113" class="anchor"></span></span>Microsoft Visual Studio
---------------------------------------------------------------------------------------------------------------------

A Microsoft Visual Studio solution file
**ExchangeServerEWSProtocolTestSuites.sln** is provided in the
**Source** folder. You can run a single or multiple test cases in Visual
Studio.

  -----------------------------------------------------------------------------------------------------------------------------------------------
  1.  Open **ExchangeServerEWSProtocolTestSuites.sln** in Visual Studio.                                                                       
                                                                                                                                               
                                                                                                                                               
  -------------------------------------------------------------------------------------------------------------------------------------------- --
  1.  In the **Solution Explorer** pane, right-click **Solution ‘ExchangeServerEWSProtocolTestSuites’** and then click **Rebuild Solution**.   
                                                                                                                                               
                                                                                                                                               

  1.  Open **Test Explorer**. On the ribbon click **TEST**, then click **Windows**, and finally click **Test Explorer**.                       
                                                                                                                                               
                                                                                                                                               

  1.  Select the test case to run. Right-click and then select **Run Selected Tests**.

  -----------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line" class="anchor"><span id="_Toc306892176"
class="anchor"></span></span>A Visual Studio solution file
**MS-XXXX.sln** is provided in each test suite folder.

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Select the test suite you would like to run. Let’s take MS-OXWSCORE as an example here, so browse to the **Source\\MS-OXWSCORE** directory.

  ------------------------------------------------------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------
  1.  Open **MS-OXWSCORE.sln** in Microsoft Visual Studio.

  1.  In the **Solution Explorer** pane, right-click **Solution ‘MS-OXWSCORE’**, and then click **Rebuild Solution**.

  1.  Open **Test Explorer**. On the ribbon click **TEST**, then click **Windows**, and finally click **Test Explorer**.

  1.  Select the test case to run. Right-click and then select **Run Selected Tests**.

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line_1" class="anchor"><span id="_Toc306892177" class="anchor"><span id="_Toc397328575" class="anchor"><span id="_Toc404089114" class="anchor"></span></span></span></span>Batch scripts 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Exchange Server EWS Protocol test suites are installed with a collection
of scripts that enable a user to run individual test cases
(RunMSXXXX\_SXX\_TCXX\_Name.cmd) or all test cases in a test suite
(RunAllMSXXXXTestCases.cmd), or all test cases of Exchange Server EWS
Protocol test suites at once (RunAllExchangeEWSTestCases.cmd). These
scripts can be found in the **\\Source\\Scripts** directory.

**Note**   These scripts depend on having the compiled binaries in the
bin folder.

  **Batch script**                 **Script description**
  -------------------------------- ------------------------------------------------------------------------------
  RunAllExchangeEWSTestCases.cmd   Runs all the test cases within the Exchange Server EWS Protocol test suites.
  RunAllMSXXXXTestCases.cmd        Runs all MS-XXXX test cases.
  RunMSXXXX\_SXX\_TCXX\_Name.cmd   Runs a specific test case within the test suite.

<span id="_Toc397328576" class="anchor"><span id="_Toc404089115" class="anchor"></span></span>Test suite results, logs, and reporting
=====================================================================================================================================

The test suites provide detailed reporting in a variety of formats that
will enable users to quickly debug failures.

<span id="_Toc397328577" class="anchor"><span id="_Toc404089116" class="anchor"></span></span>Test suite configuration logs
---------------------------------------------------------------------------------------------------------------------------

The configuration logs contain information about whether each
configuration step succeeds or not, and detail error information if the
configuration step fails.

### <span id="_Toc404089117" class="anchor"><span id="_Toc397328578" class="anchor"></span></span>SUT configuration logs

The SUT configuration scripts create a directory named **SetupLogs**
under **…\\Setup\\SUT\\** at runtime. The SUT configuration scripts save
the logs as “ExchangeSUTConfiguration.ps1.debug.log” and
“ExchangeSUTConfiguration.ps1.log”.

### <span id="_Toc402441719" class="anchor"><span id="_Toc402446773" class="anchor"><span id="_Toc402542845" class="anchor"><span id="_Toc402864587" class="anchor"><span id="_Toc402865736" class="anchor"><span id="_Toc404089118" class="anchor"></span></span></span></span></span></span>Test suite client configuration logs

The configuration scripts create a directory named **SetupLogs** under
**…\\Setup\\Test Suite Client\\** at runtime. The test suite client
configuration scripts save the logs as
“ExchangeClientConfiguration.ps1.debug.log” and
“ExchangeClientConfiguration.ps1.log”.

Test suite reports
------------------

### <span id="_Toc404089120" class="anchor"><span id="_Toc397328579" class="anchor"><span id="_Toc308770210" class="anchor"></span></span></span>Microsoft Visual Studio

Reports are created only after the package level solution or an
individual test suite solution has run successfully in Visual Studio.

-   Reporting information for
    **ExchangeServerEWSProtocolTestSuites.sln** is saved in
    **…\\Source\\TestResults**.

-   Reporting information for an individual test suite **MS-XXXX.sln**
    is saved in **…\\Source\\MS-XXXX\\TestResults**.

### Batch scripts

If the Exchange Server EWS Protocol test suites are run by the
RunAllExchangeEWSTestCases.cmd batch file, the reporting information is
saved in **…\\Source\\Scripts\\TestResults**.

If the test suite is run by the batch file RunAllMSXXXXTestCases.cmd or
RunMSXXXX\_SXX\_TCXX\_Name.cmd, the reporting information is saved in
**…\\Source\\Scripts\\MS-XXXX\\TestResults.**

By default, a .trx file containing the pass/fail information of the run
is created in the TestResults folder, along with an associated directory
named **user\_MACHINENAME DateTimeStamp** that contains a log file in
XML format and an HTML report.

 Appendix
=========

For more information, see the following:

  References                                                                                      Description
  ----------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------
  <dochelp@microsoft.com>                                                                         Alias for Interoperability documentation help. Provides support for the Open Specifications and protocol test suites.
  [Open Specifications Forums](http://go.microsoft.com/fwlink/?LinkId=111125)                     Microsoft Customer Support Services forums. Actively monitored forums provide support for the Open Specifications and protocol test suites.
  [Open Specifications Developer Center](http://go.microsoft.com/fwlink/?LinkId=254469)           Open Specifications home page on MSDN
  [Open Specifications](http://go.microsoft.com/fwlink/?LinkId=179743)                            Open Specifications documentation on MSDN
  [Exchange Products and Technologies Protocols](http://go.microsoft.com/fwlink/?LinkId=119904)   Exchange Server Open Specifications documentation on MSDN
  [RFC2119](http://go.microsoft.com/fwlink/?LinkId=117453)                                        Normative language reference
  [Exchange Server 2013 deployment](http://go.microsoft.com/fwlink/?LinkID=266569)                Exchange Server 2013 planning and deployment on TechNet
  [Exchange Server 2010 deployment](http://go.microsoft.com/fwlink/?LinkID=517397)                Exchange Server 2010 planning and deployment on TechNet
  [Exchange Server 2007 deployment](http://go.microsoft.com/fwlink/?LinkID=512508)                Exchange Server 2007 deployment on TechNet
