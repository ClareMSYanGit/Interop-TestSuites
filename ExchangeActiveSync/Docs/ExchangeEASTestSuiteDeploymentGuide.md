![alt tag](/Doc-Images/ExLogo.png)

Exchange EAS Test Suite Deployment Guide
======================================================================================================
Overview
======================================================================================================

The Exchange Server EAS Protocol Test Suites are implemented as
synthetic clients running against a server-side implementation of a
given Exchange protocol. They are designed in a client-to-server
relationship and were originally developed for the in-house testing of
the Microsoft Open Specifications. Test Suites have been used
extensively in Plugfests and Interoperability Labs to test partner
implementations.

The Exchange EAS Test Suite Deployment Guide introduces the hardware and
software requirements of the test suite client, and the requirements of
the system under test (SUT) if the test suites run against Exchange
Server. The guide also introduces how to deploy, configure and run the
test suites, and view test suite reports.

Prerequisites
=========================================================================================================================================================================================================

This section describes the hardware and software requirements for the
test suites. In an Exchange server environment, the test suite
deployment takes place on both the client and server side. The following
information will help test suite users to plan their deployment.

Hardware requirements
------------------------------------------------------------------------------------------------------------------------------------------------------------------

### System under test

The SUT is the server side of the test suite environment. Exchange
server(s) and Active Directory have defined system requirements which
should be taken into account during deployment. The Exchange Server EAS
Protocol test suites do not have any additional SUT resource
requirements.

### Test suite client

The test suite client is the client side of the test suite environment.
The following table shows the minimum resource requirements for the test
suite client.

Test suite client resource requirements

  Component   Test suite client minimum requirement
  ----------- ---------------------------------------
  RAM         2GB
  Hard Disk   3G of free space
  Processor   &gt;= 1GHz

Software requirements
-------------------------------------------------------------------------------------------------------------------

### System under test 

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
  ------------------------------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  **Active Directory Domain Controller (AD DC)**   Active Directory Domain Controller is used to provide secure data for users and computers. An AD DC can coexist with an Exchange server. A typical test configuration has an AD DC and Exchange Server installed on separate machines.
  Domain Name System Server (DNS)                  Domain Name System (DNS) Server provides a name resolution for TCP/IP networks. A DNS Server is easier to manage when it is installed on the server as Active Directory Domain Services.
  **Exchange Server (SUT)**                        The Exchange server in the topology.

<span id="_SUT_resource_requirements" class="anchor"></span>The
following diagram is an example of what a typical Exchange test suite
environment may look like. This example uses an IPv4, but IPv6 is also
supported by the test suites.

**Note** AD DC and SUT are in the same machine, test cases for MS-ASRM
will be failed.

### <span id="_Toc397328557" class="anchor"><span id="_Toc404161761" class="anchor"></span></span>Test suite client

This section describes the prerequisite software for installing the
Exchange Server EAS Protocol test suites on the test suite client.<span
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

<span id="_Toc397328558" class="anchor"><span id="_Toc404161762" class="anchor"></span></span>Deploying the test suites
=======================================================================================================================

<span id="_Installation_instructions_2" class="anchor"></span>This
section describes the deployment of the Exchange Server EAS Protocol
test suites on the test suite client and the SUT. The Exchange Server
EAS Protocol test suites are packaged in a .zip file which is available
on [Microsoft Connect](http://go.microsoft.com/fwlink/?LinkId=516921).
Once you download the test suites, you need to perform the following
steps in order to be able to successfully configure the test suites.

1.  Extract the **Exchange Server EAS Protocol Test Suites** folder to a
    directory of your choice on the test suite client.

2.  Copy the **SUT** folder under **…\\Exchange Server EAS Protocol Test
    Suites\\Setup** to a directory of your choice on the SUT. The SUT
    configuration scripts are the only requirement for the SUT. The
    scripts facilitate the SUT configuration process and are contained
    within the **ExchangeServerEASProtocolTestSuites.zip** file.

**Note**   If your computer blocks scripts downloaded from the Internet
for security reasons, you will need to follow these steps to unblock
PowerShell scripts and the MS\_OXWSDLGM\_ServerAdapter.dll file.

  -------------------------------------------------------------
  1.  Right-click xxxx.ps1, and then click **Properties**.   
                                                             
                                                             
  ---------------------------------------------------------- --
  1.  Click **Unblock,** and then click **OK**.              
                                                             
                                                             
  -------------------------------------------------------------

<span id="_Test_suite_client" class="anchor"><span
id="_Test_suite_directories" class="anchor"><span
id="_Test_suite_client_1" class="anchor"><span
id="_Installation_Instructions_1" class="anchor"><span
id="_Installation_Instructions" class="anchor"><span id="_Toc387851232"
class="anchor"><span id="_Toc308770209" class="anchor"><span
id="_Toc397328559"
class="anchor"></span></span></span></span></span></span></span></span>

To unblock MS\_OXWSDLGM\_ServerAdapter.dll, do the following:

1.  Browse to file **MS\_OXWSDLGM\_ServerAdapter.dll** within the
    > **\\Setup\\SUT**.

  ------------------------------------------------------------------------------------------
  1.  Right click “**MS\_OXWSDLGM\_ServerAdapter.dll”,** and then click **Properties**.   
                                                                                          
                                                                                          
  --------------------------------------------------------------------------------------- --
  1.  Click **Unblock,** and then click **OK**.                                           
                                                                                          
                                                                                          
  ------------------------------------------------------------------------------------------

<span id="_Toc402534611" class="anchor"><span id="_Toc402799302" class="anchor"><span id="_Toc402880184" class="anchor"><span id="_Toc404161763" class="anchor"></span></span></span></span>Test suite directories
==================================================================================================================================================================================================================

In this section you will find a list of the folder structures that are
contained within the **ExchangeServerEASProtocolTestSuites.zip** file.

ExchangeServerEASProtocolTestSuites.zip file contents

  Directory/file                                       Description
  ---------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  EULA.rtf                                             The End-User License Agreement
  ReadMe.txt                                           A file that contains information about the deployment guide and prerequisite software.
  Exchange Server EAS Protocol Test Suites             
  - Docs                                               A directory that contains documents of all protocol test suites.
  - ExchangeEASTestSuiteDeploymentGuide.docx           A file relevant to the protocol test suite deployment guidance
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
  - Source                                             A folder with Microsoft Visual Studio solutions that contain source code for the test suites.
  - Common                                             A folder with Microsoft Visual Studio projects that contains source code that are common to the test suites.
  - ExchangeCommonConfiguration.deployment.ptfconfig   The common configuration file.
  - ExchangeServerEASProtocolTestSuites.runsettings    A configuration file used for unit test.
  - ExchangeServerEASProtocolTestSuites.sln            A Visual Studio solution that contains projects of the test suites source code.
  - ExchangeServerEASProtocolTestSuites.testsettings   A configuration file used for running test cases.
  - MS-XXXX                                            MS-XXXX test suite code directory.
  - MS-XXXX.sln                                        A Microsoft Visual Studio solution that contains projects of the MS-XXXX test suite.
  - MS-XXXX.runsettings                                A configuration file used for MS-XXXX unit test.
  - MS-XXXX.testsettings                               A configuration file used for MS-XXXX running test cases.
  + Adapter                                            Adapter test suite code.
  + TestSuite                                          Test suite code.
  - Scripts                                            Exchange Server EWS test suites can be run using Visual Studio or through batch scripts. The Scripts directory contains a collection of command files that allows users to run specific test cases in the test suite or the entire test suite.
  - RunAllExchangeEASTestCases.cmd                     A script that can be used to run all test cases in the whole package.
  - MS-XXXX                                            A folder containing scripts that belong to the MS-XXXX test suite.
  - RunAllMSXXXXTestCases.cmd                          A script that can be used to run all test cases of MS-XXXX.
  - RunMSXXXX\_SXX\_TCXX\_Name.cmd                     A script that can be used to run a single test case of MS-XXXX.

<span id="_Toc402534740" class="anchor"><span id="_Toc402799431" class="anchor"><span id="_Toc402880313" class="anchor"><span id="_Toc404161764" class="anchor"></span></span></span></span>Configuring the test suites
=======================================================================================================================================================================================================================

This section provides the necessary guidance to configure the Exchange
Server EAS Protocol test suites on the SUT and the test suite client.
The configuration should be done in this order: configure the SUT, and
then configure the test suite client.

For the configuration script, the exit code definition is as follows:

-   A normal termination will set the exit code to 0.

-   An uncaught THROW will set the exit code to 1.

-   Script execution warning and issues will set the exit code to 2.

-   Exit code is set to the actual error code for other issues.

<span id="_Toc402534955" class="anchor"><span id="_Toc402799646" class="anchor"><span id="_Toc402880528" class="anchor"><span id="_Toc402534956" class="anchor"><span id="_Toc402799647" class="anchor"><span id="_Toc402880529" class="anchor"><span id="_Toc402534957" class="anchor"><span id="_Toc402799648" class="anchor"><span id="_Toc402880530" class="anchor"><span id="_Toc402534958" class="anchor"><span id="_Toc402799649" class="anchor"><span id="_Toc402880531" class="anchor"><span id="_Toc402534959" class="anchor"><span id="_Toc402799650" class="anchor"><span id="_Toc402880532" class="anchor"><span id="_Toc397328560" class="anchor"><span id="_Toc404161765" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the SUT
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

You can configure the SUT using automated scripts, as described in
section [5.1.2](#_Configuring_the_SUT1_2); or configure the SUT
manually, as described in section [5.1.3](#_Configuring_the_SUT1).

**Note**   The scripts should be run by a user who has domain
administrator rights with a mailbox on Exchange Server.

### <span id="_Configuring_the_SUT1_1" class="anchor"><span id="_Toc397328561" class="anchor"><span id="_Toc404161766" class="anchor"></span></span></span>SUT resource requirements 

Each test suite contained within the Exchange Server EAS Protocol test
suites package may require a varying level of resources on Exchange
Server. The following table outlines these resources for each test
suite. The SUT configuration scripts will automatically create all the
required resources for the Microsoft server implementation. To configure
the SUT manually, see section [5.1.3](#_Configuring_the_SUT1).

The client configuration script follows the naming convention shown in
the following table. If a change to the resource name is required, the
corresponding change to the resource name defined in the client
configuration script is required.

Exchange server resources

  Test suite   Resource type                       Resource name                                Note
  ------------ ----------------------------------- -------------------------------------------- -------------------------------------------------------------------------------------------------------------------------
  All          --                                  --                                           --
  MS-ASAIRS    User Mailbox                        MSASAIRS\_User01                             --
               User Mailbox                        MSASAIRS\_User02                             --
  MS-ASCAL     User Mailbox                        MSASCAL\_User01                              --
               User Mailbox                        MSASCAL\_User02                              --
  MS-ASCMD     User Mailbox                        MSASCMD\_UserY                               “Y” represents the numerate value count and the value range of Y is from 01 to 19, since 19 mailbox users will be used.
               User Mailbox                        MSASCMD\_SearchUser01                        --
               User Mailbox                        MSASCMD\_SearchUser02                        --
               DistributionGroup                   MSASCMD\_TestGroup                           --
               DistributionGroup                   MSASCMD\_LargeGroup                          --
               Folder                              MSASCMD\_SharedFolder                        The folder is shared and read permissions are granted to user MSASCMD\_User01 and denied to user MSASCMD\_User02.
               TextFile                            MSASCMD\_Non-emptyDocument.txt               The document should be created under MSASCMD\_SharedFolder be at least 4 bytes in size.
               TextFile                            MSASCMD\_EmptyDocument.txt                   The document should be created under MSASCMD\_SharedFolder and be empty.
               Picture                             MSASCMD\_User01Photo                         The file size should be bigger than 1KB.
               Picture                             MSASCMD\_User02Photo                         The file size should be smaller than 1KB.
               EMail                               MSASCMD\_SecureEmailForTest                  
  MS-ASCNT     User Mailbox                        MSASCNTC\_User01                             --
               User Mailbox                        MSASCNTC\_User02                             --
  MS-ASCON     User Mailbox                        MSASCON\_User01                              --
               User Mailbox                        MSASCON\_User02                              --
               User Mailbox                        MSASCON\_User03                              
  MS-ASDOC     User Mailbox                        MSASDOC\_User01                              --
               Folder                              MSASDOC\_SharedFolder                        The folder is shared and full control should be granted to the specified user MSASDOC\_User01.
               Folder                              MSASDOC\_VisibleFolder                       The folder should be created under MSASDOC\_SharedFolder.
               Folder                              MSASDOC\_HiddenFolder                        The folder is hidden and should be created under MSASDOC\_SharedFolder.
               TextFile                            MSASDOC\_VisibleDocument                     The document should be created under MSASDOC\_SharedFolder.
               TextFile                            MSASDOC\_HiddenDocument                      The document is hidden and should be created under MSASDOC\_SharedFolder.
  MS-ASEMAIL   User Mailbox                        MSASEMAIL\_User01                            --
               User Mailbox                        MSASEMAIL\_User02                            --
               User Mailbox                        MSASEMAIL\_User03                            --
               User Mailbox                        MSASEMAIL\_User04                            --
               User Mailbox                        MSASEMAIL\_User05                            --
  MS-ASHTTP    User Mailbox                        MSASHTTP\_User01                             --
               User Mailbox                        MSASHTTP\_User02                             --
               User Mailbox                        MSASHTTP\_User03                             --
               User Mailbox                        MSASHTTP\_User04                             --
  MS-ASNOTE    User Mailbox                        MSASNOTE\_User01                             --
  MS-ASPROV    User Mailbox                        MSASPROV\_User01                             --
               User Mailbox                        MSASPROV\_User02                             
               User Mailbox                        MSASPROV\_User03                             
               Active sync mailbox policy          MSASPROV\_UserPolicy01                       
               Active sync mailbox policy          MSASPROV\_UserPolicy02                       
  MS-ASRM      User Mailbox                        MSASRM\_User01                               --
               User Mailbox                        MSASRM\_User02                               --
               User Mailbox                        MSASRM\_User03                               --
               User Mailbox                        MSASRM\_User04                               --
               User                                MSASRM\_ADUser                               A domain user and granted AD RMS Enterprise Administrator permission.
               DistributionGroup                   MSASRM\_SuperUserGroup                       --
               Distributed Right Policy Template   MSASRM\_AllRights\_AllowedTemplate           Allowed all rights
               Distributed Right Policy Template   MSASRM\_View\_AllowedTemplate                Denied all rights except View
               Distributed Right Policy Template   MSASRM\_ViewReplyAll\_AllowedTemplate        Allowed View and ReplyAll
               Distributed Right Policy Template   MSASRM\_ViewReply\_AllowedTemplate           Allowed View and Reply
               Distributed Right Policy Template   MSASRM\_ViewReplyReplyAll\_AllowedTemplate   Allowed View, Reply, and ReplyAll
               Distributed Right Policy Template   MSASRM\_EditExport\_NotAllowedTemplate       Allowed all rights except Edit and Export
               Distributed Right Policy Template   MSASRM\_Export\_NotAllowedTemplate           Allowed all rights except Export
               Distributed Right Policy Template   MSASRMReplyAll\_NotAllowedTemplate           Allowed all rights except ReplyAll
  MS-ASTASK    User Mailbox                        MSASTASK\_User01                             --
  MS-ASWBXML   --                                  --                                           --

### <span id="_Toc402534972" class="anchor"><span id="_Toc402799663" class="anchor"><span id="_Toc402880545" class="anchor"><span id="_Toc402534977" class="anchor"><span id="_Toc402799668" class="anchor"><span id="_Toc402880550" class="anchor"><span id="_Toc402534982" class="anchor"><span id="_Toc402799673" class="anchor"><span id="_Toc402880555" class="anchor"><span id="_Toc402534992" class="anchor"><span id="_Toc402799683" class="anchor"><span id="_Toc402880565" class="anchor"><span id="_Toc402534997" class="anchor"><span id="_Toc402799688" class="anchor"><span id="_Toc402880570" class="anchor"><span id="_Toc402535002" class="anchor"><span id="_Toc402799693" class="anchor"><span id="_Toc402880575" class="anchor"><span id="_Toc402535012" class="anchor"><span id="_Toc402799703" class="anchor"><span id="_Toc402880585" class="anchor"><span id="_Toc402535017" class="anchor"><span id="_Toc402799708" class="anchor"><span id="_Toc402880590" class="anchor"><span id="_Toc402535022" class="anchor"><span id="_Toc402799713" class="anchor"><span id="_Toc402880595" class="anchor"><span id="_Toc402535032" class="anchor"><span id="_Toc402799723" class="anchor"><span id="_Toc402880605" class="anchor"><span id="_Toc402535037" class="anchor"><span id="_Toc402799728" class="anchor"><span id="_Toc402880610" class="anchor"><span id="_Toc402535047" class="anchor"><span id="_Toc402799738" class="anchor"><span id="_Toc402880620" class="anchor"><span id="_Toc402535062" class="anchor"><span id="_Toc402799753" class="anchor"><span id="_Toc402880635" class="anchor"><span id="_Toc402535072" class="anchor"><span id="_Toc402799763" class="anchor"><span id="_Toc402880645" class="anchor"><span id="_Toc402535082" class="anchor"><span id="_Toc402799773" class="anchor"><span id="_Toc402880655" class="anchor"><span id="_Toc402535087" class="anchor"><span id="_Toc402799778" class="anchor"><span id="_Toc402880660" class="anchor"><span id="_Toc402535097" class="anchor"><span id="_Toc402799788" class="anchor"><span id="_Toc402880670" class="anchor"><span id="_Toc402535107" class="anchor"><span id="_Toc402799798" class="anchor"><span id="_Toc402880680" class="anchor"><span id="_Toc402535112" class="anchor"><span id="_Toc402799803" class="anchor"><span id="_Toc402880685" class="anchor"><span id="_Toc402535117" class="anchor"><span id="_Toc402799808" class="anchor"><span id="_Toc402880690" class="anchor"><span id="_Toc402535127" class="anchor"><span id="_Toc402799818" class="anchor"><span id="_Toc402880700" class="anchor"><span id="_Toc402535137" class="anchor"><span id="_Toc402799828" class="anchor"><span id="_Toc402880710" class="anchor"><span id="_Toc402535142" class="anchor"><span id="_Toc402799833" class="anchor"><span id="_Toc402880715" class="anchor"><span id="_Toc402535147" class="anchor"><span id="_Toc402799838" class="anchor"><span id="_Toc402880720" class="anchor"><span id="_Toc402535152" class="anchor"><span id="_Toc402799843" class="anchor"><span id="_Toc402880725" class="anchor"><span id="_Toc402535157" class="anchor"><span id="_Toc402799848" class="anchor"><span id="_Toc402880730" class="anchor"><span id="_Toc402535162" class="anchor"><span id="_Toc402799853" class="anchor"><span id="_Toc402880735" class="anchor"><span id="_Toc402535172" class="anchor"><span id="_Toc402799863" class="anchor"><span id="_Toc402880745" class="anchor"><span id="_Configuring_the_SUT1_2" class="anchor"><span id="_Toc397328562" class="anchor"><span id="_Toc404161767" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring SUT using the setup configuration script

The setup configuration script is only used for configuring Exchange
Server on the Windows platform.

To configure SUT using the setup configuration script, navigate to the
**SUT** folder, right-click **ExchangeSUTConfiguration.cmd** and select
**Run as administrator**.

### <span id="_Configuring_the_SUT1" class="anchor"><span id="_Toc397328563" class="anchor"><span id="_Toc404161768" class="anchor"></span></span></span>Configuring SUT manually

If the SUT is a non-Microsoft implementation of Exchange Server, you
will not be able to run the setup configuration script. The following
steps explain what needs to be created or configured on the SUT in order
to run the test suites.

1.  Create the following mailbox users:

MSASAIRS\_User01, MSASAIRS\_User02, MSASCAL\_User01, MSASCAL\_User02,
MSASCMD\_UserY, MSASCMD\_SearchUser01, MSASCMD\_SearchUser02,
MSASCNTC\_User01, MSASCNTC\_User02, MSASCON\_User01, MSASCON\_User02,
MSASCON\_User03, MSASDOC\_User01, MSASEMAIL\_User01, MSASEMAIL\_User02,
MSASEMAIL\_User03, MSASEMAIL\_User04, MSASEMAIL\_User05,
MSASHTTP\_User01, MSASHTTP\_User02, MSASHTTP\_User03, MSASHTTP\_User04,
MSASNOTE\_User01, MSASPROV\_User01, MSASPROV\_User02, MSASPROV\_User03,
and MSASTASK\_User01

1.  Create the mailbox user MSASCMD\_UserY specified in the SUT resource
    requirements table in section 5.1.1.

2.  Add a delegate of MSASCMD\_User07 to MSASCMD\_User08, and also add a
    delegate of MSASEMAIL\_User04 to MSASEMAIL\_User05., The delegated
    user will be granted Edit permissions on Calendar, Tasks, Inbox,
    Contacts, Notes and Journal.

3.  Set the following properties for MSASCMD\_User01.

-   SamAccountName: "MSASCMD\_User01"

-   GivenName: "MSASCMD\_FirstName"

-   Surname: "MSASCMD\_LastName"

-   Office: "D1042"

-   Company: “MS”

-   Title: “Manager”

-   HomePhone: “22222286”

-   OfficePhone: “55555501”

-   MobilePhone: “8612345678910”

1.  Create the following distribution groups:\
    MSASCMD\_TestGroup, MSASCMD\_LargeGroup, MSASRM\_SuperUserGroup.

2.  Create two ActiveSync mailbox policies MSASPROV\_UserPolicy01 and
    MSASPROV\_UserPolicy02

3.  Create a shared folder MSASCMD\_SharedFolder. Also, remove read
    permissions to MSASCMD\_User02. Under the folder
    MSASCMD\_SharedFolder, create a non-empty document named
    MSASCMD\_Non-emptyDocument.txt, and an empty document
    named MSASCMD\_EmptyDocument.txt.

> **Note** The file size of MSASCMD\_Non-emptyDocument.txt should be at
> least 4 bytes.

1.  Create a shared folder named MSASDOC\_SharedFolder. Also, grant full
    control to MSASDOC\_User01. Under the folder MSASDOC\_SharedFolder,
    create a hidden folder named MSASDOC\_HiddenFolder, a visible folder
    named MSASDOC\_VisibleFolder, a hidden document named
    MSASDOC\_HiddenDocument.txt, and a visible
    document MSASDOC\_VisibleDocument.txt.

> **Note** The document MSASDOC\_HiddenDocument.txt and
> MSASDOC\_VisibleDocument.txt should not be empty.

1.  Grant local administrator permissions to the following mailbox
    users:\
    MSASCMD\_User03, MSASHTTP\_User04, MSASPROV\_User01

2.  Grant administrator permissions to the SUT for the following mailbox
    users:

    MSASCMD\_User03, MSASPROV\_User01.

3.  Grant distribute message permissions to the group
    MSASCMD\_TestGroup, and add the following mailbox users into the
    group:

    MSASCMD\_User01, MSASCMD\_User02.

4.  Grant distribute message permissions to the group
    MSASCMD\_LargerGroup, and add 19 mailbox users specified in
    MSASCMD\_UserY section 5.1.1, MSASCMD\_SerachUser01, and
    MSASCMD\_SearchUser02 into the group MSASCMD\_LargerGroup.

5.  Apply the following policy settings for the Mobile Device mailbox
    policy MSASPROV\_UserPolicy02. The value of *Allow non-provisionable
    devices* must be set to false, while the value for other properties
    listed below are not restricted.

-   Allow non-provisionable devices

-   Password expiration (days)

-   Maximum attachment size (KB)

-   Number of failed attempts allowed

-   Time without user input before password must be re-entered
    (in minutes)

-   Minimum password length

-   Blocked applications

-   Allowed applications

1.  Set the mailbox policy MSASPROV\_UserPolicy01 MSASPROV\_User01 and
    MSASPROV\_UserPolicy02 to MSASPROV\_User02.

2.  Enable the setting of moving meeting forward notification email to
    Deleted Items for MSASCMD\_User01 and MSASHTTP\_User03.

3.  Disable ActiveSync for MSASCMD\_User04.

4.  Add an SMTP email address to MSASCMD\_User01.

5.  Configure external URL of ActiveSync virtual directory on
    the server.

6.  Configure the web site which contains the application that
    implements the EAS protocols.

<!-- -->

a.  Configure Secure Sockets Layer (SSL) as not required and ignore
    client certificates on the following sites: Default Web Site, Server
    ActiveSync website, and Autodiscover website.

<!-- -->

1.  Configure Certificate Authority and Certificate Authority Web
    enrollment services.

2.  Create and export a user certificate named MSASCMD\_PfxFile to be
    able to send a secure email to MSASCMD\_User03.

3.  MSASCMD\_User03 should send an email to MSASCMD\_User09.\
    ***Note*** *The subsequent steps in this procedure are only
    necessary for Exchange Server 2010 or Exchange Server 2013.*

4.  Add the photo MSASCMD\_User01Photo.jpg to MSASCMD\_User01 and
    MSASCMD\_User02Photo.jpg to MSASMCD\_User02.

5.  Create a user named MSASRM\_ADUser.

6.  Create a local group named AD RMS Enterprise Administrators and add
    the user MSASRM\_ADUser into this group.

7.  Create mailbox users MSASRM\_User01, MSASRM\_User02, MSASRM\_User03,
    and MSASRM\_User04.

8.  Grant local administrator permission to MSASRM\_User04.

9.  Create a distribution group named MSASRM\_SuperUserGroup.

10. Install the Active Directory Right Management Service (AD RMS)
    role .

11. Configure the website which contains the application that implements
    the EAS protocols.

<!-- -->

a.  Configure Secure Sockets Layer (SSL) as not required and ignore
    client certificates on the following sites:\
    Default Web Site/\_wmcs Default Web Site/\_wmcs/admin\
    Default Web Site/\_wmcs/certification Default Web
    Site/\_wmcs/licensing

<!-- -->

1.  Add Read and Execute permission for the groups Users, Product
    Servers, and AD RMS Service Group on the
    ServerCertification.asmx file.

2.  Add Read and Execute permission for the group Product Servers on the
    license.asmx file.

3.  Add RMS shared identity user into the distribution
    group MSASRM\_SuperUserGroup.

<!-- -->

1.  Set MSASRM\_SuperUserGroup as the super user group.

<!-- -->

1.  Create the following distributed rights policy templates:

  Template Name                                Rights
  -------------------------------------------- -----------------------------------------------------------------------------------------------------------------
  MSASRM\_View\_AllowedTemplate                View and View Rights
  MSASRM\_ViewReplyAll\_AllowedTemplate        View, Reply All, and View Rights
  MSASRM\_ViewReply\_AllowedTemplate           View, Reply, and View Rights
  MSASRM\_ViewReplyReplyAll\_AllowedTemplate   View, Reply, Reply All, and View Rights
  MSASRM\_EditExport\_NotAllowedTemplate       View, Print, Forward, Reply, Reply All, Extract, Allow Macros, and View Rights
  MSASRM\_Export\_NotAllowedTemplate           View, Edit, Save, Print, Forward, Reply, Reply All, Extract, Allow Macros, View Rights, and Edit Rights
  MSASRMReplyAll\_NotAllowedTemplate           View, Edit, Save, Export, Print, Forward, Reply, Extract, Allow Macros, View Rights, and Edit Rights
  MSASRM\_AllRights\_AllowedTemplate           View, Edit, Save, Export, Print, Forward, Reply, Reply All, Extract, Allow Macros, View Rights, and Edit Rights

1.  Configure IRM features to enable licensing for internal messages.

2.  Enable IRM features to allow the client to access the SUT.

<span id="_Toc402535179" class="anchor"><span id="_Toc402799870" class="anchor"><span id="_Toc402880752" class="anchor"><span id="_Toc402535180" class="anchor"><span id="_Toc402799871" class="anchor"><span id="_Toc402880753" class="anchor"><span id="_Toc402535181" class="anchor"><span id="_Toc402799872" class="anchor"><span id="_Toc402880754" class="anchor"><span id="_Toc402535182" class="anchor"><span id="_Toc402799873" class="anchor"><span id="_Toc402880755" class="anchor"><span id="_Toc402535183" class="anchor"><span id="_Toc402799874" class="anchor"><span id="_Toc402880756" class="anchor"><span id="_Toc402535184" class="anchor"><span id="_Toc402799875" class="anchor"><span id="_Toc402880757" class="anchor"><span id="_Toc402535185" class="anchor"><span id="_Toc402799876" class="anchor"><span id="_Toc402880758" class="anchor"><span id="_Toc402535186" class="anchor"><span id="_Toc402799877" class="anchor"><span id="_Toc402880759" class="anchor"><span id="_Toc402535187" class="anchor"><span id="_Toc402799878" class="anchor"><span id="_Toc402880760" class="anchor"><span id="_Toc402535188" class="anchor"><span id="_Toc402799879" class="anchor"><span id="_Toc402880761" class="anchor"><span id="_Toc402535189" class="anchor"><span id="_Toc402799880" class="anchor"><span id="_Toc402880762" class="anchor"><span id="_Toc402535190" class="anchor"><span id="_Toc402799881" class="anchor"><span id="_Toc402880763" class="anchor"><span id="_Toc402535191" class="anchor"><span id="_Toc402799882" class="anchor"><span id="_Toc402880764" class="anchor"><span id="_Toc402535192" class="anchor"><span id="_Toc402799883" class="anchor"><span id="_Toc402880765" class="anchor"><span id="_Toc402535193" class="anchor"><span id="_Toc402799884" class="anchor"><span id="_Toc402880766" class="anchor"><span id="_Toc402535194" class="anchor"><span id="_Toc402799885" class="anchor"><span id="_Toc402880767" class="anchor"><span id="_Toc402535195" class="anchor"><span id="_Toc402799886" class="anchor"><span id="_Toc402880768" class="anchor"><span id="_Toc402535196" class="anchor"><span id="_Toc402799887" class="anchor"><span id="_Toc402880769" class="anchor"><span id="_Toc402535197" class="anchor"><span id="_Toc402799888" class="anchor"><span id="_Toc402880770" class="anchor"><span id="_Toc402535198" class="anchor"><span id="_Toc402799889" class="anchor"><span id="_Toc402880771" class="anchor"><span id="_Toc402535199" class="anchor"><span id="_Toc402799890" class="anchor"><span id="_Toc402880772" class="anchor"><span id="_Toc402535200" class="anchor"><span id="_Toc402799891" class="anchor"><span id="_Toc402880773" class="anchor"><span id="_Toc402535201" class="anchor"><span id="_Toc402799892" class="anchor"><span id="_Toc402880774" class="anchor"><span id="_Toc402535202" class="anchor"><span id="_Toc402799893" class="anchor"><span id="_Toc402880775" class="anchor"><span id="_Toc402535203" class="anchor"><span id="_Toc402799894" class="anchor"><span id="_Toc402880776" class="anchor"><span id="_Toc402535204" class="anchor"><span id="_Toc402799895" class="anchor"><span id="_Toc402880777" class="anchor"><span id="_Toc402535205" class="anchor"><span id="_Toc402799896" class="anchor"><span id="_Toc402880778" class="anchor"><span id="_Toc402535206" class="anchor"><span id="_Toc402799897" class="anchor"><span id="_Toc402880779" class="anchor"><span id="_Toc402535207" class="anchor"><span id="_Toc402799898" class="anchor"><span id="_Toc402880780" class="anchor"><span id="_Toc402535208" class="anchor"><span id="_Toc402799899" class="anchor"><span id="_Toc402880781" class="anchor"><span id="_Toc402535209" class="anchor"><span id="_Toc402799900" class="anchor"><span id="_Toc402880782" class="anchor"><span id="_Toc402535210" class="anchor"><span id="_Toc402799901" class="anchor"><span id="_Toc402880783" class="anchor"><span id="_Toc402535211" class="anchor"><span id="_Toc402799902" class="anchor"><span id="_Toc402880784" class="anchor"><span id="_Toc402535212" class="anchor"><span id="_Toc402799903" class="anchor"><span id="_Toc402880785" class="anchor"><span id="_Toc402535213" class="anchor"><span id="_Toc402799904" class="anchor"><span id="_Toc402880786" class="anchor"><span id="_Toc402535214" class="anchor"><span id="_Toc402799905" class="anchor"><span id="_Toc402880787" class="anchor"><span id="_Configuring_the_SUT2_1" class="anchor"><span id="_Toc402535215" class="anchor"><span id="_Toc402799906" class="anchor"><span id="_Toc402880788" class="anchor"><span id="_Configure_the_SUT2" class="anchor"><span id="_Configure_the_SUT2_1" class="anchor"><span id="_Toc402535216" class="anchor"><span id="_Toc402799907" class="anchor"><span id="_Toc402880789" class="anchor"><span id="_Toc402535217" class="anchor"><span id="_Toc402799908" class="anchor"><span id="_Toc402880790" class="anchor"><span id="_Configuring_test_suite" class="anchor"><span id="_Configuring_the_SUT2" class="anchor"><span id="_Toc402535218" class="anchor"><span id="_Toc402799909" class="anchor"><span id="_Toc402880791" class="anchor"><span id="_Toc402535219" class="anchor"><span id="_Toc402799910" class="anchor"><span id="_Toc402880792" class="anchor"><span id="_Toc402535220" class="anchor"><span id="_Toc402799911" class="anchor"><span id="_Toc402880793" class="anchor"><span id="_Toc402535221" class="anchor"><span id="_Toc402799912" class="anchor"><span id="_Toc402880794" class="anchor"><span id="_Toc402535222" class="anchor"><span id="_Toc402799913" class="anchor"><span id="_Toc402880795" class="anchor"><span id="_Toc402535223" class="anchor"><span id="_Toc402799914" class="anchor"><span id="_Toc402880796" class="anchor"><span id="_Toc402535224" class="anchor"><span id="_Toc402799915" class="anchor"><span id="_Toc402880797" class="anchor"><span id="_Toc402535225" class="anchor"><span id="_Toc402799916" class="anchor"><span id="_Toc402880798" class="anchor"><span id="_Toc402535226" class="anchor"><span id="_Toc402799917" class="anchor"><span id="_Toc402880799" class="anchor"><span id="_Toc402535227" class="anchor"><span id="_Toc402799918" class="anchor"><span id="_Toc402880800" class="anchor"><span id="_Configuring_the_test_1" class="anchor"><span id="_Toc397328566" class="anchor"><span id="_Toc404161769" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the test suite client
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

The test suite client is managed through a common configuration file,
two test suite-specific configuration files, and three SHOULD/MAY
configuration files that all have a “.ptfconfig” extension. These
configuration files can be modified directly. The common configuration
file and the test suite-specific configuration files can also be
modified through a script.

### <span id="_Test_Suite_Specific" class="anchor"><span id="Text10" class="anchor"><span id="ControlAdapterConfig" class="anchor"><span id="_Configuring_the_test" class="anchor"><span id="_Toc397328567" class="anchor"><span id="_Toc404161770" class="anchor"></span></span></span></span></span></span>Common configuration file

The common configuration file contains configurable properties common to
all Exchange Server EAS Protocol test suites. This file must be modified
to match the characteristics of the environment where the test suites
are installed.

  **Configuration file**                             **Description**
  -------------------------------------------------- ----------------------------------------------------------------------------------------------------------
  ExchangeCommonConfiguration.deployment.ptfconfig   The deployment configuration file provides the environmental details that are common to the test suites.

### <span id="_Toc397328568" class="anchor"><span id="_Toc404161771" class="anchor"></span></span>Test-suite specific configuration files

In addition to the common configuration file, each individual test suite
has the following two configuration files for test suite-specific
modification.

Test-suite specific configuration files

  Configuration file                        Description
  ----------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_TestSuite.deployment.ptfconfig   The deployment configuration file provides the environmental details that are specific to the test suite. The configuration file allows for test suite-specific customization.
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

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property name   Default value\*         Optional value    Description
  --------------- ----------------------- ----------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Adapter         managed or powershell   interactive\*\*   **managed**:
                                                            
                                                            The SUT control adapter is implemented in C\# managed code.
                                                            
                                                            **powershell**:
                                                            
                                                            The SUT control adapter is implemented through Windows PowerShell.
                                                            
                                                            **interactive**:
                                                            
                                                            Interactive adapters are used for manually configuring a server. Interactive adapter displays a dialog box to perform a manual test each time one of its methods is called. The dialog box will show the method name, parameter names, and values\*\*\*
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

\**The Adapter property value is set to either managed or powershell
depending on whether the SUT control adapter was implemented in managed
C\# code or through PowerShell.*

\*\* *When changing to interactive mode from managed mode, the
“adaptertype” attribute must be deleted to avoid a runtime error. When
changing to interactive mode from powershell mode, an additional step is
required—delete the “scriptdir” attribute to avoid a runtime error.*

\*\*\**When the manual operation completes successfully, enter the
return values (if any) in **Action Results** and click **Succeed** in
the dialog-box. When the manual operation is unable to complete, enter
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

By default, TSAP packets are broadcasted in the network. User can change
a TSAP broadcast by adding an entry “BeaconLogTargetServer” to
TestSuite.deployment.ptfconfig to target the TSAP only to the specified
machine.

To change the TSAP packet broadcast, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.deployment.ptfconfig**
    configuration file in the **\\Source\\MS-XXXX\\TestSuite\\** folder.

2.  Add a property “BeaconLogTargetServer” along with the value of the
    specified machine name.

For example: &lt;Property name="BeaconLogTargetServer" value="dc01"
/&gt;

### <span id="_Toc397328569" class="anchor"><span id="_Toc404161772" class="anchor"></span></span>SHOULD/MAY configuration files

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

### <span id="_Configuring_the_test_2" class="anchor"><span id="_Toc397328570" class="anchor"><span id="_Toc404161773" class="anchor"></span></span></span>Configuring the test suite client using setup configuration script

<span id="_Configure_the_test" class="anchor"><span
id="_Configure_the_test_1" class="anchor"></span></span>**Note** The
setup configuration script is only implemented for configuring the test
suite client on the Windows platform.

To configure the test suite using the setup configuration script,
navigate to the **Setup\\Test Suite Client**\\ folder, right-click
**ExchangeClientConfiguration.cmd** and select **Run as administrator.**

### <span id="Configuringthetestsuiteclientmanual" class="anchor"><span id="_Toc397328571" class="anchor"><span id="_Toc404161774" class="anchor"><span id="_Toc335752278" class="anchor"></span></span></span></span>Configuring the test suite client manually

If you didn’t use the setup configuration script to configure the test
suite client as described in the previous section, follow the steps
below to update configuration files and configure the test suite client.

1.  Update the property value in the common configuration file and the
    test suite-specific configuration files according to the comment of
    the property.

2.  By default, the test suites use PowerShell script in the SUT control
    adapter to configure the SUT. If you chose interactive mode for the
    SUT control adapter as described in section
    [5.2.2.1](#set-the-test-suite-to-interactive-mode), skip this step.

<!-- -->

a.  Set the execution policy to **RemoteSigned**.

b.  Add the SUT to TrustedHosts to ensure that the Windows Remote
    Management (WinRM) client can process remote calls against the SUT
    when the test suite client is not joined to the domain.

<span id="_Toc397328572" class="anchor"><span id="_Toc404161775" class="anchor"></span></span>Running test suites
=================================================================================================================

<span id="_Toc306892175" class="anchor"></span>Once the required
software has been installed and both the SUT and test suite client have
been configured appropriately, the test suite is ready to run. The test
suite can run only on the test suite client and can be initiated in one
of the following two ways: Visual Studio or batch scripts.

<span id="_Toc397328573" class="anchor"><span id="_Toc404161776" class="anchor"></span></span>Microsoft Visual Studio
---------------------------------------------------------------------------------------------------------------------

A Microsoft Visual Studio solution file
**ExchangeServerEASProtocolTestSuites.sln** is provided in the
**Source** folder. You can run a single or multiple test cases in Visual
Studio.

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Open **ExchangeServerEASProtocolTestSuites.sln** in Visual Studio                                                                         
                                                                                                                                                
                                                                                                                                                
  --------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------
  1.  In the **Solution Explorer** pane, right-click **Solution ‘ExchangeServerEASProtocolTestSuites’**, and then click **Rebuild Solution**.   ![](media/image8.png){width="2.6458333333333335in" height="1.84375in"}
                                                                                                                                                
                                                                                                                                                

  1.  Open **Test Explorer**. On the ribbon, click **TEST** then click **Windows**, and finally click **Test Explorer**.                        
                                                                                                                                                
                                                                                                                                                

  1.  Select the test case to run. Right-click and then select **Run Selected Tests**.

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line" class="anchor"><span id="_Toc306892176"
class="anchor"></span></span>A Visual Studio solution file
**MS-XXXX.sln** is provided in each test suite folder.

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Select the test suite you would like to run. Let’s take MS-ASDOC as an example here, so browse to the **Source\\MS-ASDOC** directory.

  ------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------------
  1.  Open **MS-ASDOC.sln** in Visual Studio.

  1.  In the **Solution Explorer** pane, right-click **Solution ‘MS-ASDOC’**, and then click **Rebuild Solution**.

  1.  Open Test Explorer. On the ribbon, click **TEST**, then click **Windows**, and finally click **Test Explorer**.

  1.  Select the test case to run. Right-click and then select **Run Selected Tests**.

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line_1" class="anchor"><span id="_Toc306892177" class="anchor"><span id="_Toc397328575" class="anchor"><span id="_Toc404161777" class="anchor"></span></span></span></span>Batch scripts 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Exchange Server EAS Protocol test suites are installed with a collection
of scripts that enable a user to run individual test cases
(RunMSXXXX\_SXX\_TCXX\_Name.cmd) or all test cases in a test suite
(RunAllMSXXXXTestCases.cmd), or all test cases of Exchange Server EAS
Protocol test suites at once (RunAllExchangeEASTestCases.cmd). These
scripts can be found in the **\\Source\\Scripts** directory.

**Note**   These scripts depend on having the compiled binaries in the
bin folder.

  **Batch script**                 **Script description**
  -------------------------------- ------------------------------------------------------------------------------
  RunAllExchangeEASTestCases.cmd   Runs all the test cases within the Exchange Server EAS Protocol test suites.
  RunAllMSXXXXTestCases.cmd        Runs all MS-XXXX test cases.
  RunMSXXXX\_SXX\_TCXX\_Name.cmd   Runs a specific test case within the test suite.

<span id="_Toc397328576" class="anchor"><span id="_Toc404161778" class="anchor"></span></span>Test suite results, logs, and reporting
=====================================================================================================================================

The test suites provide detailed reporting in a variety of formats that
will enable users to quickly debug failures.

<span id="_Toc397328577" class="anchor"><span id="_Toc404161779" class="anchor"></span></span>Test suite configuration logs
---------------------------------------------------------------------------------------------------------------------------

The configuration logs contain information about whether each
configuration step succeeds or not, and detail error information if the
configuration step fails.

### <span id="_Toc404161780" class="anchor"><span id="_Toc397328578" class="anchor"></span></span>SUT configuration logs

The SUT configuration scripts create a directory named **SetupLogs**
under **…\\Setup\\SUT\\** at runtime. The SUT configuration scripts save
the logs as “ExchangeSUTConfiguration.ps1.debug.log” and
“ExchangeSUTConfiguration.ps1.log”.

### <span id="_Toc402535257" class="anchor"><span id="_Toc402799948" class="anchor"><span id="_Toc402880830" class="anchor"><span id="_Toc404161781" class="anchor"></span></span></span></span>Test suite client configuration logs

The configuration scripts create a directory named **SetupLogs** under
**…\\Setup\\Test Suite Client\\** at runtime. The test suite client
configuration scripts save the logs as
“ExchangeClientConfiguration.ps1.debug.log” and
“ExchangeClientConfiguration.ps1.log”.

Test suite reports
------------------

### <span id="_Toc404161783" class="anchor"><span id="_Toc397328579" class="anchor"><span id="_Toc308770210" class="anchor"></span></span></span>Microsoft Visual Studio

Reports are created only after the package level solution or an
individual test suite solution has run successfully in Visual Studio.

-   Reporting information for
    **ExchangeServerEASProtocolTestSuites.sln** is saved in
    **…\\Source\\TestResults**.

-   Reporting information for an individual test suite **MS-XXXX.sln**
    is saved in **…\\Source\\MS-XXXX\\TestResults**.

### <span id="_Toc402880834" class="anchor"><span id="_Toc404161784" class="anchor"></span></span>Batch scripts

If the Exchange Server EAS Protocol test suites are run by the
RunAllExchangeEASTestCases.cmd batch file, the reporting information is
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
