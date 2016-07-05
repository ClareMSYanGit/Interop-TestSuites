![alt tag](/Doc-Images/SPLogo.png)

SharePoint File Sync and WOPI Protocol Test Suite Deployment Guide

Overview
=====================================================================================================================================================

The SharePoint File Sync and WOPI Protocol Test Suites are implemented
as synthetic clients running against a server-side implementation of a
given SharePoint protocol. They are designed in a client-to-server
relationship and were originally developed for the in-house testing of
the Microsoft Open Specifications. Test Suites have been used
extensively in Plugfests and Interoperability Labs to test partner
implementations.

The SharePoint File Sync and WOPI Protocol Test Suite Deployment Guide
introduces the hardware and software requirements of the test suite
client and the requirements of the system under test (SUT) if the test
suites run against SharePoint Server. The guide also introduces how to
deploy, configure and run the test suites, and view test suite reports.

Prerequisites
======================================================================================================================================

This section describes the hardware and software requirements for the
test suites. In a SharePoint server environment, the test suite
deployment takes place on both the client and server side. The following
information will help test suite users to plan their deployment.

1.  <span id="_Toc403125494" class="anchor"><span id="_Toc403400499"
    class="anchor"><span id="_Toc403405989" class="anchor"><span
    id="_Toc403484959" class="anchor"><span id="_Toc403557755"
    class="anchor"><span id="_Toc403558183" class="anchor"><span
    id="_Toc403125495" class="anchor"><span id="_Toc403400500"
    class="anchor"><span id="_Toc403405990" class="anchor"><span
    id="_Toc403484960" class="anchor"><span id="_Toc403557756"
    class="anchor"><span id="_Toc403558184" class="anchor"><span
    id="_Toc401152784" class="anchor"><span id="_Toc397328552"
    class="anchor"><span id="_Toc401840189" class="anchor"><span
    id="_Toc402365816" class="anchor"><span id="_Toc403485553"
    class="anchor"><span id="_Toc405368965" class="anchor"><span
    id="_Toc344286925"
    class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Hardware
    requirements

    1.  <span id="_Toc401840190" class="anchor"><span id="_Toc402365817"
        class="anchor"><span id="_Toc403485554" class="anchor"><span
        id="_Toc405368966" class="anchor"><span id="_Toc401152785"
        class="anchor"><span id="_Toc397328553"
        class="anchor"></span></span></span></span></span></span>System
        under test

The SUT is the server side of the test suite environment. SharePoint
server(s) and Active Directory have defined system requirements which
should be taken into account during deployment. The SharePoint File Sync
and WOPI Protocol test suites do not have any additional SUT resource
requirements.

1.  <span id="_Toc403485555" class="anchor"><span id="_Toc405368967"
    class="anchor"></span></span>Test suite client

The test suite client is the client side of the test suite environment.
The following table shows the minimum resource requirements for the test
suite client.

Test suite client resource requirements

  Component   Test suite client minimum requirement
  ----------- ---------------------------------------
  RAM         2GB
  Hard Disk   3GB of free space
  Processor   &gt;= 1GHz

<span id="_Toc403125499" class="anchor"><span id="_Toc403400504" class="anchor"><span id="_Toc403405994" class="anchor"><span id="_Toc403484964" class="anchor"><span id="_Toc403485737" class="anchor"><span id="_Toc403557760" class="anchor"><span id="_Toc403558188" class="anchor"><span id="_Toc403125500" class="anchor"><span id="_Toc403400505" class="anchor"><span id="_Toc403405995" class="anchor"><span id="_Toc403484965" class="anchor"><span id="_Toc403557761" class="anchor"><span id="_Toc403558189" class="anchor"><span id="_Toc403485557" class="anchor"><span id="_Toc405368968" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Software requirements
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

1.  <span id="_Toc401840193" class="anchor"><span id="_Toc402365820"
    class="anchor"><span id="_Toc403485558" class="anchor"><span
    id="_Toc405368969" class="anchor"><span id="_Toc401152788"
    class="anchor"><span id="_Toc397328556"
    class="anchor"></span></span></span></span></span></span>System
    under test

This section is only relevant when running the test suites against
following versions of SharePoint Server:

-   Microsoft SharePoint Foundation 2010 Service Pack 2 (SP2)

-   Microsoft SharePoint Foundation 2013 Service Pack 1 (SP1)

-   Microsoft SharePoint Server 2010 Service Pack 2 (SP2)

-   Microsoft SharePoint Server 2013 Service Pack 1 (SP1)

The following table describes the necessary server roles required for a
test suite deployment with a Microsoft implementation.

Required SUT roles

  Role                                         Description
  -------------------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Active Directory Domain Controller (AD DC)   Active Directory Domain Controller provides secure data for users and computers. An AD DC can coexist with a SharePoint server. A typical test configuration has an AD DC and SharePoint Server installed on separate machines.
  SharePoint Server (SUT)                      The SharePoint server in the topology.

The following diagram is an example of what a typical SharePoint File
Sync and WOPI Protocol Test Suite environment may look like. This
example uses an IPv4, but IPv6 is also supported by the test suites.

1.  <span id="_Toc403485559" class="anchor"><span id="_Toc405368970"
    class="anchor"></span></span>Test suite client

This section describes the prerequisite software for installing the
SharePoint File Sync and WOPI Protocol test suites on the test suite
client. The following table outlines the software dependencies for the
test suite client.

Test suite client software dependencies

  ----------------------------------------------------------------------------
  Operating systems   Windows 7 x64 Service Pack 1 and above
                      
                      Windows 8 x64 and above
                      
                      Windows 2008 R2 x64 Service Pack 1 and above
  ------------------- --------------------------------------------------------
  Software            Microsoft Visual Studio 2013 Professional
                      
                      Microsoft Protocol Test Framework 1.0.2220.0 and above
  ----------------------------------------------------------------------------

<span id="_Toc403125504" class="anchor"><span id="_Toc403400509" class="anchor"><span id="_Toc403405999" class="anchor"><span id="_Toc403484969" class="anchor"><span id="_Toc403557765" class="anchor"><span id="_Toc403558193" class="anchor"><span id="_Toc403125505" class="anchor"><span id="_Toc403400510" class="anchor"><span id="_Toc403406000" class="anchor"><span id="_Toc403484970" class="anchor"><span id="_Toc403485741" class="anchor"><span id="_Toc403557766" class="anchor"><span id="_Toc403558194" class="anchor"><span id="_Toc403125506" class="anchor"><span id="_Toc403400511" class="anchor"><span id="_Toc403406001" class="anchor"><span id="_Toc403484971" class="anchor"><span id="_Toc403557767" class="anchor"><span id="_Toc403558195" class="anchor"><span id="_Toc403125507" class="anchor"><span id="_Toc403400512" class="anchor"><span id="_Toc403406002" class="anchor"><span id="_Toc403484972" class="anchor"><span id="_Toc403485742" class="anchor"><span id="_Toc403557768" class="anchor"><span id="_Toc403558196" class="anchor"><span id="_Toc403125508" class="anchor"><span id="_Toc403400513" class="anchor"><span id="_Toc403406003" class="anchor"><span id="_Toc403484973" class="anchor"><span id="_Toc403557769" class="anchor"><span id="_Toc403558197" class="anchor"><span id="_Toc403125509" class="anchor"><span id="_Toc403400514" class="anchor"><span id="_Toc403406004" class="anchor"><span id="_Toc403484974" class="anchor"><span id="_Toc403557770" class="anchor"><span id="_Toc403558198" class="anchor"><span id="_Toc403125510" class="anchor"><span id="_Toc403400515" class="anchor"><span id="_Toc403406005" class="anchor"><span id="_Toc403484975" class="anchor"><span id="_Toc403557771" class="anchor"><span id="_Toc403558199" class="anchor"><span id="_Toc403125523" class="anchor"><span id="_Toc403400528" class="anchor"><span id="_Toc403406018" class="anchor"><span id="_Toc403484988" class="anchor"><span id="_Toc403557784" class="anchor"><span id="_Toc403558212" class="anchor"><span id="_Toc403125524" class="anchor"><span id="_Toc403400529" class="anchor"><span id="_Toc403406019" class="anchor"><span id="_Toc403484989" class="anchor"><span id="_Toc403485743" class="anchor"><span id="_Toc403557785" class="anchor"><span id="_Toc403558213" class="anchor"><span id="_Toc403125525" class="anchor"><span id="_Toc403400530" class="anchor"><span id="_Toc403406020" class="anchor"><span id="_Toc403484990" class="anchor"><span id="_Toc403557786" class="anchor"><span id="_Toc403558214" class="anchor"><span id="_Toc403125526" class="anchor"><span id="_Toc403400531" class="anchor"><span id="_Toc403406021" class="anchor"><span id="_Toc403484991" class="anchor"><span id="_Toc403557787" class="anchor"><span id="_Toc403558215" class="anchor"><span id="_SharePoint_resource_requirements" class="anchor"><span id="_Toc403125536" class="anchor"><span id="_Toc403400541" class="anchor"><span id="_Toc403406031" class="anchor"><span id="_Toc403485001" class="anchor"><span id="_Toc403485744" class="anchor"><span id="_Toc403557797" class="anchor"><span id="_Toc403558225" class="anchor"><span id="_Toc403125537" class="anchor"><span id="_Toc403400542" class="anchor"><span id="_Toc403406032" class="anchor"><span id="_Toc403485002" class="anchor"><span id="_Toc403557798" class="anchor"><span id="_Toc403558226" class="anchor"><span id="_Toc403125538" class="anchor"><span id="_Toc403400543" class="anchor"><span id="_Toc403406033" class="anchor"><span id="_Toc403485003" class="anchor"><span id="_Toc403557799" class="anchor"><span id="_Toc403558227" class="anchor"><span id="_Toc403125539" class="anchor"><span id="_Toc403400544" class="anchor"><span id="_Toc403406034" class="anchor"><span id="_Toc403485004" class="anchor"><span id="_Toc403557800" class="anchor"><span id="_Toc403558228" class="anchor"><span id="_Toc403125548" class="anchor"><span id="_Toc403400553" class="anchor"><span id="_Toc403406043" class="anchor"><span id="_Toc403485013" class="anchor"><span id="_Toc403557809" class="anchor"><span id="_Toc403558237" class="anchor"><span id="_Toc403125552" class="anchor"><span id="_Toc403400557" class="anchor"><span id="_Toc403406047" class="anchor"><span id="_Toc403485017" class="anchor"><span id="_Toc403557813" class="anchor"><span id="_Toc403558241" class="anchor"><span id="_Toc403125556" class="anchor"><span id="_Toc403400561" class="anchor"><span id="_Toc403406051" class="anchor"><span id="_Toc403485021" class="anchor"><span id="_Toc403557817" class="anchor"><span id="_Toc403558245" class="anchor"><span id="_Toc403125560" class="anchor"><span id="_Toc403400565" class="anchor"><span id="_Toc403406055" class="anchor"><span id="_Toc403485025" class="anchor"><span id="_Toc403557821" class="anchor"><span id="_Toc403558249" class="anchor"><span id="_Toc403125564" class="anchor"><span id="_Toc403400569" class="anchor"><span id="_Toc403406059" class="anchor"><span id="_Toc403485029" class="anchor"><span id="_Toc403557825" class="anchor"><span id="_Toc403558253" class="anchor"><span id="_Toc403125572" class="anchor"><span id="_Toc403400577" class="anchor"><span id="_Toc403406067" class="anchor"><span id="_Toc403485037" class="anchor"><span id="_Toc403557833" class="anchor"><span id="_Toc403558261" class="anchor"><span id="_Toc403125576" class="anchor"><span id="_Toc403400581" class="anchor"><span id="_Toc403406071" class="anchor"><span id="_Toc403485041" class="anchor"><span id="_Toc403557837" class="anchor"><span id="_Toc403558265" class="anchor"><span id="_Toc403125580" class="anchor"><span id="_Toc403400585" class="anchor"><span id="_Toc403406075" class="anchor"><span id="_Toc403485045" class="anchor"><span id="_Toc403557841" class="anchor"><span id="_Toc403558269" class="anchor"><span id="_Toc403125584" class="anchor"><span id="_Toc403400589" class="anchor"><span id="_Toc403406079" class="anchor"><span id="_Toc403485049" class="anchor"><span id="_Toc403557845" class="anchor"><span id="_Toc403558273" class="anchor"><span id="_Toc403125588" class="anchor"><span id="_Toc403400593" class="anchor"><span id="_Toc403406083" class="anchor"><span id="_Toc403485053" class="anchor"><span id="_Toc403557849" class="anchor"><span id="_Toc403558277" class="anchor"><span id="_Toc403125596" class="anchor"><span id="_Toc403400601" class="anchor"><span id="_Toc403406091" class="anchor"><span id="_Toc403485061" class="anchor"><span id="_Toc403557857" class="anchor"><span id="_Toc403558285" class="anchor"><span id="_Toc403125600" class="anchor"><span id="_Toc403400605" class="anchor"><span id="_Toc403406095" class="anchor"><span id="_Toc403485065" class="anchor"><span id="_Toc403557861" class="anchor"><span id="_Toc403558289" class="anchor"><span id="_Toc403125604" class="anchor"><span id="_Toc403400609" class="anchor"><span id="_Toc403406099" class="anchor"><span id="_Toc403485069" class="anchor"><span id="_Toc403557865" class="anchor"><span id="_Toc403558293" class="anchor"><span id="_Toc403125608" class="anchor"><span id="_Toc403400613" class="anchor"><span id="_Toc403406103" class="anchor"><span id="_Toc403485073" class="anchor"><span id="_Toc403557869" class="anchor"><span id="_Toc403558297" class="anchor"><span id="_Toc403125612" class="anchor"><span id="_Toc403400617" class="anchor"><span id="_Toc403406107" class="anchor"><span id="_Toc403485077" class="anchor"><span id="_Toc403557873" class="anchor"><span id="_Toc403558301" class="anchor"><span id="_Toc403125616" class="anchor"><span id="_Toc403400621" class="anchor"><span id="_Toc403406111" class="anchor"><span id="_Toc403485081" class="anchor"><span id="_Toc403557877" class="anchor"><span id="_Toc403558305" class="anchor"><span id="_Toc403125620" class="anchor"><span id="_Toc403400625" class="anchor"><span id="_Toc403406115" class="anchor"><span id="_Toc403485085" class="anchor"><span id="_Toc403557881" class="anchor"><span id="_Toc403558309" class="anchor"><span id="_Toc403125624" class="anchor"><span id="_Toc403400629" class="anchor"><span id="_Toc403406119" class="anchor"><span id="_Toc403485089" class="anchor"><span id="_Toc403557885" class="anchor"><span id="_Toc403558313" class="anchor"><span id="_Toc403125628" class="anchor"><span id="_Toc403400633" class="anchor"><span id="_Toc403406123" class="anchor"><span id="_Toc403485093" class="anchor"><span id="_Toc403557889" class="anchor"><span id="_Toc403558317" class="anchor"><span id="_Toc403125632" class="anchor"><span id="_Toc403400637" class="anchor"><span id="_Toc403406127" class="anchor"><span id="_Toc403485097" class="anchor"><span id="_Toc403557893" class="anchor"><span id="_Toc403558321" class="anchor"><span id="_Toc403125636" class="anchor"><span id="_Toc403400641" class="anchor"><span id="_Toc403406131" class="anchor"><span id="_Toc403485101" class="anchor"><span id="_Toc403557897" class="anchor"><span id="_Toc403558325" class="anchor"><span id="_Toc403125640" class="anchor"><span id="_Toc403400645" class="anchor"><span id="_Toc403406135" class="anchor"><span id="_Toc403485105" class="anchor"><span id="_Toc403557901" class="anchor"><span id="_Toc403558329" class="anchor"><span id="_Toc403125644" class="anchor"><span id="_Toc403400649" class="anchor"><span id="_Toc403406139" class="anchor"><span id="_Toc403485109" class="anchor"><span id="_Toc403557905" class="anchor"><span id="_Toc403558333" class="anchor"><span id="_Toc403125648" class="anchor"><span id="_Toc403400653" class="anchor"><span id="_Toc403406143" class="anchor"><span id="_Toc403485113" class="anchor"><span id="_Toc403557909" class="anchor"><span id="_Toc403558337" class="anchor"><span id="_Toc403125652" class="anchor"><span id="_Toc403400657" class="anchor"><span id="_Toc403406147" class="anchor"><span id="_Toc403485117" class="anchor"><span id="_Toc403485745" class="anchor"><span id="_Toc403557913" class="anchor"><span id="_Toc403558341" class="anchor"><span id="_Toc403125653" class="anchor"><span id="_Toc403400658" class="anchor"><span id="_Toc403406148" class="anchor"><span id="_Toc403485118" class="anchor"><span id="_Toc403557914" class="anchor"><span id="_Toc403558342" class="anchor"><span id="_Toc403125654" class="anchor"><span id="_Toc403400659" class="anchor"><span id="_Toc403406149" class="anchor"><span id="_Toc403485119" class="anchor"><span id="_Toc403557915" class="anchor"><span id="_Toc403558343" class="anchor"><span id="_Toc308770206" class="anchor"><span id="_Toc344286932" class="anchor"><span id="_Toc403485565" class="anchor"><span id="_Toc405368971" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Deploying the test suites
=======================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section describes the deployment of the SharePoint File Sync and
WOPI Protocol test suites on the test suite client and the SUT. The
SharePoint Server Protocol test suites are packaged in a .zip file which
is available on [**Microsoft
Connect**](http://go.microsoft.com/fwlink/?LinkId=516921). Once you
download the test suites, you need to perform the following steps in
order to be able to successfully configure the test suites.

1.  <span id="_Installation_instructions_2" class="anchor"><span
    id="_Toc308770207" class="anchor"></span></span>Extract the
    **SharePoint File Sync and WOPI Protocol Test Suites** folder to a
    directory of your choice on the test suite client.

2.  Copy the **SUT** and **Common** folders under **…\\ SharePoint File
    Sync and WOPI Protocol Test Suites \\Setup\\** to a directory of
    your choice on the SUT. The SUT configuration scripts are the only
    requirement for the SUT. The scripts facilitate the SUT
    configuration process and are contained within the
    **SharePointFileSyncandWOPIProtocolTestSuites.zip** file.

**Notes**   

-   If you configure the SUT using the setup configuration scripts,
    remember that the path of the setup script should contain at most
    256 characters.<span id="315016-0-11" class="anchor"></span>

-   If your computer blocks scripts downloaded from the Internet for
    security reasons, you will need to follow these steps to unblock
    PowerShell scripts.

  ----------------------------------------------------------------------------------------------------------------------------------------
  1.  Right click xxx.ps1 and select **Properties**.   ![](media/image3.png){width="3.9375in" height="3.0729166666666665in"}
                                                       
                                                       
  ---------------------------------------------------- -----------------------------------------------------------------------------------
  1.  Click **Unblock** and then click **OK**.         ![](media/image4.jpeg){width="3.9479166666666665in" height="5.395833333333333in"}
                                                       
                                                       
  ----------------------------------------------------------------------------------------------------------------------------------------

<span id="_Test_suite_directories" class="anchor"><span id="_Toc344286934" class="anchor"><span id="_Toc403485567" class="anchor"><span id="_Toc405368972" class="anchor"></span></span></span></span>Test suite directories
============================================================================================================================================================================================================================

In this section you will find a list of the folder structures that are
contained within the **SharePointFileSyncAndWOPIProtocolTestSuites.zip**
file.

SharePointFileSyncAndWOPIProtocolTestSuites.zip file contents

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Directory/file                                              Description
  ----------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  EULA.rtf                                                    The End-User License Agreement

  ReadMe.txt                                                  A file that contains information about the deployment guide and prerequisite software.

  SharePoint File Sync and WOPI Protocol Test Suites          

  - Docs                                                      A directory that contains documents of all protocol test suites.

  - FssWopiTestSuiteDeploymentGuide.docx                      A file relevant to the protocol test suite deployment guidance.

  - FssWopiTestSuiteSpecification.docx                        A file that contains test suites design, including test suites architecture, adapter and test suites details.

  + MS-XXXX                                                   MS-XXXX Help documentation

  - \[MS-XXXX\].pdf                                           The technical specification for the protocol

  - MS-XXXX\_SUTControlAdapter.chm                            Contains information about the SUT control adapter class library such as declaration syntaxes and their description

  - MS-XXXX\_RequirementSpecification.xlsx                    A spreadsheet that outlines all requirements associated with the technical specification.

  - Setup                                                     A directory that contains configuration scripts.

  > - Test Suite Client                                       A directory that contains the configuration script to configure the test suite client.

  > - SharePointClientConfiguration.cmd                       A command file that runs the
                                                              
                                                              SharePointClientConfiguration.ps1 to configure the properties for the protocol test suites.

  > - SharePointClientConfiguration.ps1                       A configuration script that will be invoked by SharePointClientConfiguration.cmd.

  - SUT                                                       A folder that contains the configuration script to configure the SUT.

  > - SharePointSUTConfiguration.cmd                          A command file that runs the
                                                              
                                                              SharePointSUTConfiguration.ps1 to create resources and configure settings on the SUT.

  > - SharePointSUTConfiguration.ps1                          A configuration script that will be invoked by SharePointSUTConfiguration.cmd.

  > - Common                                                  A folder that contains common configuration scripts and resources.

  > -CommonConfiguration.ps1                                  A library that contains common functions for configuring Microsoft products and the test suite client.

  > -SharePointCommonConfiguration.ps1                        A library that contains common functions for configuring the SUT.

  > -SharePointTestSuite.config                               The configuration file to store all configuration resources

  - Source                                                    A folder with Microsoft Visual Studio solution that contains the source code for the test suites.

  - Common                                                    A folder with Visual Studio projects that contains source code that are common to the test suites

  > -FssWopiCommonConfiguration.deployment.ptfconfig          The common configuration file

  -SharePointFileSyncAndWOPIProtocolTestSuites.sln            A Visual Studio solution that contains projects of the protocol test suites source code

  - SharePointFileSyncAndWOPIProtocolTestSuites.runsettings   A configuration file used for unit test

  -SharePointFileSyncAndWOPIProtocolTestSuites.testsettings   A configuration file used for running test cases

  - MS-XXXX                                                   MS-XXXX test suite source code directory

  + Adapter                                                   Adapter test suite code

  + TestSuite                                                 Test suite code

  > - MS-XXXX.sln                                             A Visual Studio solution that contains projects of the MS-XXXX test suite

  - MS-XXXX.runsettings                                       A configuration file used for MS-XXXX unit test

  - MS-XXXX.testsettings                                      A configuration file used for MS-XXXX running test cases

  -Scripts                                                    SharePoint Server Protocol test suites can be run using Visual Studio or through batch scripts. The Scripts directory contains a collection of command files that allows users to run specific test cases in the test suite or the entire test suite

  -RunAllSharePoint\_FileSyncAndWOPI\_TestCases.cmd           A script that can be used to run all test cases in the package

  -MS-XXXX                                                    A folder containing scripts that belong to the MS-XXXX test suite

  - RunAllMSXXXXTestCases.cmd                                 A script that can be used to run all test cases of MS-XXXX

  - RunMSXXXX\_SYY\_TCZZ\_Name.cmd                            A script that can be used to run a single test case of MS-XXXX
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Test_suite_client" class="anchor"><span id="_Toc344286935"
class="anchor"></span></span>

**\
**

<span id="_Toc403125657" class="anchor"><span id="_Toc403400662" class="anchor"><span id="_Toc403406152" class="anchor"><span id="_Toc403485122" class="anchor"><span id="_Toc403485748" class="anchor"><span id="_Toc403557918" class="anchor"><span id="_Toc403558346" class="anchor"><span id="_Toc403125658" class="anchor"><span id="_Toc403400663" class="anchor"><span id="_Toc403406153" class="anchor"><span id="_Toc403485123" class="anchor"><span id="_Toc403557919" class="anchor"><span id="_Toc403558347" class="anchor"><span id="_Pre-requisites/Dependencies" class="anchor"><span id="_Toc403125659" class="anchor"><span id="_Toc403400664" class="anchor"><span id="_Toc403406154" class="anchor"><span id="_Toc403485124" class="anchor"><span id="_Toc403557920" class="anchor"><span id="_Toc403558348" class="anchor"><span id="_Toc403125660" class="anchor"><span id="_Toc403400665" class="anchor"><span id="_Toc403406155" class="anchor"><span id="_Toc403485125" class="anchor"><span id="_Toc403557921" class="anchor"><span id="_Toc403558349" class="anchor"><span id="_Installation_Instructions_1" class="anchor"><span id="_System(s)_under_test" class="anchor"><span id="_Toc403125669" class="anchor"><span id="_Toc403400674" class="anchor"><span id="_Toc403406164" class="anchor"><span id="_Toc403485134" class="anchor"><span id="_Toc403485749" class="anchor"><span id="_Toc403557930" class="anchor"><span id="_Toc403558358" class="anchor"><span id="_Toc403125670" class="anchor"><span id="_Toc403400675" class="anchor"><span id="_Toc403406165" class="anchor"><span id="_Toc403485135" class="anchor"><span id="_Toc403557931" class="anchor"><span id="_Toc403558359" class="anchor"><span id="_Toc403125671" class="anchor"><span id="_Toc403400676" class="anchor"><span id="_Toc403406166" class="anchor"><span id="_Toc403485136" class="anchor"><span id="_Toc403557932" class="anchor"><span id="_Toc403558360" class="anchor"><span id="_Toc403125672" class="anchor"><span id="_Toc403400677" class="anchor"><span id="_Toc403406167" class="anchor"><span id="_Toc403485137" class="anchor"><span id="_Toc403557933" class="anchor"><span id="_Toc403558361" class="anchor"><span id="_Toc403125673" class="anchor"><span id="_Toc403400678" class="anchor"><span id="_Toc403406168" class="anchor"><span id="_Toc403485138" class="anchor"><span id="_Toc403557934" class="anchor"><span id="_Toc403558362" class="anchor"><span id="_Toc403125674" class="anchor"><span id="_Toc403400679" class="anchor"><span id="_Toc403406169" class="anchor"><span id="_Toc403485139" class="anchor"><span id="_Toc403557935" class="anchor"><span id="_Toc403558363" class="anchor"><span id="_Toc403125675" class="anchor"><span id="_Toc403400680" class="anchor"><span id="_Toc403406170" class="anchor"><span id="_Toc403485140" class="anchor"><span id="_Toc403557936" class="anchor"><span id="_Toc403558364" class="anchor"><span id="_Installation_Instructions" class="anchor"><span id="_Toc308770209" class="anchor"><span id="_Toc344286937" class="anchor"><span id="_Toc403485570" class="anchor"><span id="_Toc405368973" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the test suites
==================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section provides the necessary guidance to configure the SharePoint
File Sync and WOPI Protocol test suites on the SUT and the test suite
client. The configuration should be done in this order: configure the
SUT, and then configure the test suite client.

For configuration script, the exit code definition is as follows:

1.  A normal termination will set the exit code to 0.

2.  An uncaught THROW will set the exit code to 1.

3.  Script execution warning and issues will set the exit code to 2.

4.  Exit code is set to the actual error code for other issues.

<span id="_Toc344286938" class="anchor"><span id="_Toc403485571" class="anchor"><span id="_Toc405368974" class="anchor"></span></span></span>Configuring the SUT
----------------------------------------------------------------------------------------------------------------------------------------------------------------

You can configure the SUT using automation scripts, as described in
section [5.1.2](#_Configuring_the_SUT_1); or configure the SUT manually,
as described in section [5.1.3](#_Configuring_the_SUT).

***Note**   The scripts should be run by a user who has domain
administrator rights on the SUT.*

### <span id="_Toc403400683" class="anchor"><span id="_Toc403406173" class="anchor"><span id="_Toc403485143" class="anchor"><span id="_Toc403557939" class="anchor"><span id="_Toc403558367" class="anchor"><span id="_SUT_resource_requirements" class="anchor"><span id="_Toc403485572" class="anchor"><span id="_Toc405368975" class="anchor"></span></span></span></span></span></span></span></span>SUT resource requirements

Each test suite contained within the SharePoint File Sync and WOPI
Protocol test suites package may require varying levels of resources on
the SUT. The following table outlines these resources for each test
suite. The SUT configuration scripts will automatically create all the
required resources for the Microsoft server implementation. To configure
the SUT manually, refer to section [5.1.3](#_Configuring_test_suite).

The client configuration script follows the naming convention shown in
the following table. If a change to the resource name is required, the
corresponding change to the resource name defined in the client
configuration script will be required.

***Note**   The MS-WOPI test suite only supports the following versions
of SharePoint:*

-   *Microsoft SharePoint Server 2013 Service Pack 1 (SP1)*

-   *Microsoft SharePoint Foundation 2013 Service Pack 1 (SP1)*

SharePoint Server resources

  Test suite            Resource type                      Resource name
  --------------------- ---------------------------------- -----------------------------------------
  All                   Domain User                        User1
                        Domain User                        User2
                        Domain User                        User3
                        Domain User                        ReadOnlyUser
                        Domain User                        NoUseRemoteUser
                        Text document                      FileSyncWOPIBigTest.txt
  MS-FSSHTTP-FSSHTTPB   Site collection                    MSFSSHTTPFSSHTTPB\_SiteCollection
                        Document library                   MSFSSHTTPFSSHTTPB\_DocumentLibrary
                        Zip file                           FileSyncWOPI\_ZipTestData.zip
                        Text document                      FileSyncWOPI\_TestData.txt
                        Note file                          FileSyncWOPI\_OneNoteWithODB.one
                        Permission level                   NoUseRemoteInterfacePermissionLevel
  MS-WOPI               Site collection                    MSWOPI\_SiteCollection
                        Document library                   MSWOPI\_SharedDocumentLibrary
                        Document library                   MSWOPI\_DocumentLibrary
                        Folder                             MSWOPI\_TestFolder
                        Zip file                           FileSyncWOPI\_ZipTestData.zip
                        Text document                      FileSyncWOPI\_TestData.txt
                        Note file                          FileSyncWOPI\_OneNoteWithODB.one
                        Text document                      MSWOPI\_TestData1.txt
                        Text document                      MSWOPI\_TestData2.txt
                        Secure Store Service Application   MSWOPI\_TargetAppWithNotGroupAndWindows
                        Secure Store Service Application   MSWOPI\_TargetAppWithGroupAndNoWindows
                        Domain User                        MSWOPIUser
                        Domain User                        FileSyncWOPIUser
                        Folder                             MSWOPI\_TestFolderCreatedByUser1
                        Permission level                   NoUseRemoteInterfacePermissionLevel

### <span id="_Toc403125679" class="anchor"><span id="_Toc403400685" class="anchor"><span id="_Toc403406175" class="anchor"><span id="_Toc403485145" class="anchor"><span id="_Toc403557941" class="anchor"><span id="_Toc403558369" class="anchor"><span id="_Configuring_the_SUT_1" class="anchor"><span id="_Toc403485573" class="anchor"><span id="_Toc405368976" class="anchor"><span id="configSUTbyScripts" class="anchor"></span></span></span></span></span></span></span></span></span></span>Configuring the SUT using the setup configuration script

> *The setup configuration script is only used for configuring the SUT
> on the Windows platform.*

To configure SUT using the setup configuration script, navigate to the
**SUT** folder, right-click the **SharePointSUTConfiguration.cmd** and
select **Run as administrator**.

### <span id="_Toc403125681" class="anchor"><span id="_Toc403400687" class="anchor"><span id="_Toc403406177" class="anchor"><span id="_Toc403485147" class="anchor"><span id="_Toc403557943" class="anchor"><span id="_Toc403558371" class="anchor"><span id="_Configuring_test_suite" class="anchor"><span id="_Configuring_the_SUT" class="anchor"><span id="_Toc403485574" class="anchor"><span id="_Toc405368977" class="anchor"><span id="ConfiguringtheSUTmanually" class="anchor"></span></span></span></span></span></span></span></span></span></span></span>Configuring the SUT manually

If the SUT is a non-Microsoft implementation of SharePoint Server, you
will not be able to run the setup configuration script. The following
steps explain what needs to be created or configured on the SUT in order
to run the test suites.

1.  In Windows Powershell, set the execution policy to **RemoteSigned**,
    enable remoting, and increase the memory allocated per shell for
    remote shell management to **1024MB** or more, if you plan to
    configure the SUT or test suite in PowerShell mode. If the user name
    has a prefix in the user policy of web application, you will need to
    add the user name without a prefix in the user policy.

2.  Configure the SUT to support HTTPS.

3.  Set the Alternate Access Mapping (AAM) value to HTTPS on the SUT.

4.  Change the web application’s authentication mode to claims-based.

5.  Create six domain users named User1, User2, User3, ReadOnlyUser,
    NoUseRemoteUser, and FileSyncWOPIUser.

6.  Grant local administrator permissions to User1, User2
    and FileSyncWOPIUser.

7.  If a database server needs to be installed, grant database server
    administrator permissions to User1, User2, User3, ReadOnlyUser
    and FileSyncWOPIUser.

***Note**   *<span id="OLE_LINK23" class="anchor"><span id="OLE_LINK24"
class="anchor"></span></span>*The following steps should be performed by
the SUT administrator.*

#### <span id="_Toc405368978" class="anchor"><span id="OLE_LINK30" class="anchor"><span id="OLE_LINK33" class="anchor"><span id="OLE_LINK35" class="anchor"><span id="OLE_LINK36" class="anchor"><span id="OLE_LINK37" class="anchor"></span></span></span></span></span></span>MS-FSSHTTP-FSSHTTPB

For the MS-FSSHTTP-FSSHTTPB test suite, the SUT configuration steps are
as follows:

1.  Create a site collection named MSFSSHTTPFSSHTTPB\_SiteCollection.

2.  Create a document library named MSFSSHTTPFSSHTTPB\_DocumentLibrary
    <span id="OLE_LINK52"
    class="anchor"></span>in MSFSSHTTPFSSHTTPB\_SiteCollection.

3.  Upload a file FileSyncWOPIBigTest.txt with size of more than 1MB to
    MSFSSHTTPFSSHTTPB\_DocumentLibrary
    under MSFSSHTTPFSSHTTPB\_SiteCollection.

4.  Upload a file FileSyncWOPI\_ZipTestData.zip to
    MSFSSHTTPFSSHTTPB\_DocumentLibrary
    under MSFSSHTTPFSSHTTPB\_SiteCollection.

5.  Upload a file FileSyncWOPI\_TestData.txt to
    MSFSSHTTPFSSHTTPB\_DocumentLibrary
    under MSFSSHTTPFSSHTTPB\_SiteCollection.

6.  Upload a file FileSyncWOPI\_OneNoteWithODB.one to
    MSFSSHTTPFSSHTTPB\_DocumentLibrary
    under MSFSSHTTPFSSHTTPB\_SiteCollection.

7.  Grant Full control permissions to User1, User2 and User3 on
    MSFSSHTTPFSSHTTPB\_SiteCollection

8.  Create a permission level named NoUseRemoteInterfacePermissionLevel
    with the following permissions: ViewListItems, EditListItems,
    DeleteListItems, OpenItems, ViewVersions, Open, and ViewPages
    on MSFSSHTTPFSSHTTPB\_SiteCollection.

9.  Grant NoUseRemoteInterfacePermissionLevel to NoUseRemoteUser
    on MSFSSHTTPFSSHTTPB\_SiteCollection.

10. Grant Read permissions to ReadOnlyUser
    on MSFSSHTTPFSSHTTPB\_SiteCollection.

11. Add the username for the user (who will configure the SUT) in the
    user policy. Please note that if the user policy of the web
    application has a username with a claim prefix (such as i:0\#.w|),
    you will need to add the username without the claim in the
    user policy.

12. Make sure the MSFSSHTTPFSSHTTPB\_SiteCollection can be accessed
    before running the test suite.

#### MS-WOPI

For the MS-WOPI test suite, the SUT configuration steps are as follows:

1.  Create a site collection named MSWOPI\_SiteCollection*.*

<!-- -->

1.  Create a document library named MSWOPI\_SharedDocumentLibrary
    in MSWOPI\_SiteCollection.

2.  Upload a file FileSyncWOPIBigTest.txt with size of more than 1MB to
    MSWOPI\_SharedDocumentLibrary under MSWOPI\_SiteCollection.

3.  Upload a file FileSyncWOPI\_ZipTestData.zip to
    MSWOPI\_SharedDocumentLibrary under MSWOPI\_SiteCollection.

4.  Upload a file FileSyncWOPI\_TestData.txt to
    MSWOPI\_SharedDocumentLibrary under MSWOPI\_SiteCollection.

5.  Upload a file FileSyncWOPI\_OneNoteWithODB.one to
    MSWOPI\_SharedDocumentLibrary under MSWOPI\_SiteCollection.

6.  Grant Full control permissions to User1, User2, User3 and
    FileSyncWOPIUser on MSWOPI\_SiteCollection.

7.  Add the username without prefix in the user policy for User1, User2,
    User3 and FileSyncWOPIUser on MSWOPI\_SiteCollection.

8.  Create a document library named MSWOPI\_DocumentLibrary
    in MSWOPI\_SiteCollection.

9.  Upload a file MSWOPI\_TestData1.txt to MSWOPI\_DocumentLibrary
    under MSWOPI\_SiteCollection.

10. Create a folder named MSWOPI\_TestFolder on MSWOPI\_DocumentLibrary,
    and upload an arbitrary content .txt file named
    MSWOPI\_TestData2.txt into this folder.

11. Create a folder named MSWOPI\_TestFolderCreatedByUser1 on
    MSWOPI\_DocumentLibrary by user User1.

12. Create a permission level named NoUseRemoteInterfacePermissionLevel
    with these permissions: ViewListItems, EditListItems,
    DeleteListItems, OpenItems, ViewVersions, Open, ViewPages
    on MSWOPI\_SiteCollection.

13. Grant NoUseRemoteInterfacePermissionLevel to NoUseRemoteUser
    on MSWOPI\_SiteCollection.

14. Grant Read permissions to ReadOnlyUser on MSWOPI\_SiteCollection.

15. Create a target application item in Secure Store
    named MSWOPI\_TargetAppWithNotGroupAndWindows. The target
    application item type is *Individual*.

16. Configure the Security Token Service to use HTTP.

17. Make sure the MSWOPI\_SiteCollection can be accessed before running
    the test suite.

<span id="_Toc403125692" class="anchor"><span id="_Toc403400698" class="anchor"><span id="_Toc403406188" class="anchor"><span id="_Toc403485158" class="anchor"><span id="_Toc403557954" class="anchor"><span id="_Toc403558382" class="anchor"><span id="_Toc386546370" class="anchor"><span id="_Toc344286939" class="anchor"><span id="_Toc403485575" class="anchor"><span id="_Toc405368980" class="anchor"></span></span></span></span></span></span></span></span></span></span>Configuring the test suite client
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

The test suite client is managed through a common configuration file,
two test suite-specific configuration files and four SHOULD/MAY
configuration files that have a “.ptfconfig” extension. These
configuration files can be modified directly. The common configuration
file and the test suite-specific configuration files can also be
modified through a script.

1.  <span id="_Toc401152800" class="anchor"><span id="_Toc397328567"
    class="anchor"><span id="_Toc401840211" class="anchor"><span
    id="_Toc402365832" class="anchor"><span id="_Toc403485576"
    class="anchor"><span id="_Toc405368981"
    class="anchor"></span></span></span></span></span></span>Common
    configuration file

<span id="CommonConfigFile" class="anchor"></span>The common
configuration file contains configurable properties common to all
SharePoint File Sync and WOPI Protocol test suites. This file must be
modified to match the characteristics of the environment where the test
suites are installed.

  **Configuration file**                            **Description**
  ------------------------------------------------- ----------------------------------------------------------------------------------------------------------
  FssWopiCommonConfiguration.deployment.ptfconfig   The deployment configuration file provides the environmental details that are common to the test suites.

1.  <span id="_Toc403125695" class="anchor"><span id="_Toc403400701"
    class="anchor"><span id="_Toc403406191" class="anchor"><span
    id="_Toc403485161" class="anchor"><span id="_Toc403557957"
    class="anchor"><span id="_Toc403558385" class="anchor"><span
    id="_Toc403125696" class="anchor"><span id="_Toc403400702"
    class="anchor"><span id="_Toc403406192" class="anchor"><span
    id="_Toc403485162" class="anchor"><span id="_Toc403557958"
    class="anchor"><span id="_Toc403558386" class="anchor"><span
    id="_Test_Suite_Specific" class="anchor"><span id="_Toc401152801"
    class="anchor"><span id="_Toc397328568" class="anchor"><span
    id="_Toc401840212" class="anchor"><span id="_Toc402365833"
    class="anchor"><span id="_Toc403485577" class="anchor"><span
    id="_Toc405368982" class="anchor"><span
    id="IndividualTestSuiteConfig"
    class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Test-suite
    specific configuration files

In addition to the common configuration file, each individual test suite
has the following two configuration files for test suite-specific
modification.

Test-suite specific configuration files

  Configuration file                        Description
  ----------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_TestSuite.deployment.ptfconfig   The deployment configuration file provides the environmental details that are specific to the test suite. The configuration file allows for the test suite-specific customization.
  MS-XXXX\_TestSuite.ptfconfig              The test suite configuration file contains details that specify the behavior of the test suite operation.

Both files are present in TestSuite folder of each test suite directory.

If you need to modify the common configuration values for a specific
test suite, you must copy the common properties to the
**MS-XXXX\_TestSuite.deployment.ptfconfig** file and change the values
of the properties. The specific configuration file will take precedence
over the common configuration file when the same property exists in both
places.

1.  <span id="_Toc405368983" class="anchor"></span>**Set the test suite
    to interactive mode**

<span id="Configure_Interactive_Mode" class="anchor"><span
id="OLE_LINK42" class="anchor"><span id="OLE_LINK43"
class="anchor"></span></span></span>If the SUT is a non-Microsoft
implementation of SharePoint Server, it is recommended that you further
configure the test suite by setting the <span id="OLE_LINK38"
class="anchor"><span id="OLE_LINK39" class="anchor"></span></span>test
suite to interactive mode. Interactive mode enables the test suite to
function in a manual way, enabling you to perform setup, teardown, and
other tasks in a step-by-step approach. To enable interactive mode for a
specific test suite, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.ptfconfig** configuration file
    within the **\\Source\\MS-XXXX\\TestSuite\\**.

<!-- -->

1.  Set the type value of Adapter property to **interactive** for SUT
    control adapter\*\*.

Interactive mode values

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property name   Default value\*         Optional value    Description
  --------------- ----------------------- ----------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Adapter         managed or powershell   interactive\*\*   **managed**:
                                                            
                                                            The SUT control adapter is implemented in C\# managed code.
                                                            
                                                            **powershell**:
                                                            
                                                            The SUT control adapter is implemented through PowerShell.
                                                            
                                                            **interactive**:
                                                            
                                                            Interactive adapters are used for manually configuring the server. The interactive adapter displays a dialog box to perform a manual test each time one of its methods is called. The dialog box will show the method name, parameter names, and values\*\*\*
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

*\*The Adapter property value is set to either **managed** or
**powershell** depending on whether the SUT control adapter was
implemented in managed C\# code or through PowerShell. *

*\*\*When changing to interactive mode from managed mode, the
“adaptertype” attribute must be deleted to avoid a runtime error. When
changing to interactive mode from powershell mode, an additional step is
required—delete the “scriptdir” attribute to avoid a runtime error.*

*\*\*\*When the manual operation completes successfully, enter the
return value (if any) in **Action Results** and click **Succeed** in the
dialog box. When manual operation is unable to complete, enter the error
messages in the **Failure Message** text box and click the **Fail** to
terminate the test. In this case, the test will be treated as
“Inconclusive”.*

Further customization can be done by creating your own SUT control
adapter that matches the server implementation. For information about
how to create a SUT control adapter, see the Protocol Test Framework
(PTF) user documentation.

1.  <span id="_Toc405368984" class="anchor"></span>**Configure TSAP
    broadcast**

Test Session Announcement Protocol (TSAP) is used by the PTF to
broadcast test information when the test suite is running. TSAP
broadcast helps in mapping test cases to captured frames.

By default, TSAP packets are broadcasted in the network. Users can
disable TSAP broadcast by adding an entry “BeaconLogTargetServer” to
TestSuite.deployment.ptfconfig to target the TSAP only to the specified
machine.

To change TSAP packet broadcast, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.deployment.ptfconfig**
    configuration file within the
    **\\Source\\MS-XXXX\\TestSuite\\** folder.

<!-- -->

1.  Add a property “BeaconLogTargetServer” along with the value of the
    specified machine name.

> For example: &lt;Property name="BeaconLogTargetServer" value="SUT01"
> /&gt;

1.  <span id="_Toc401152802" class="anchor"><span id="_Toc397328569"
    class="anchor"><span id="_Toc401840213" class="anchor"><span
    id="_Toc402365834" class="anchor"><span id="_Toc403485578"
    class="anchor"><span id="_Toc405368985"
    class="anchor"></span></span></span></span></span></span>SHOULD/MAY
    configuration files

The test suite has the following four SHOULD/MAY configuration files
that are specific to all supported versions of the SUT. Each SHOULD/MAY
requirement have an associated parameter with a value of either “true”
or “false” corresponding to the server version that they support. “true”
represents that the requirement must be validated, whereas “false” means
that the requirement must not be validated.

If the SUT is a non-Microsoft implementation of SharePoint Server,
configure the properties in the configuration file for the SharePoint
Server which is the closest match to the SUT implementation.

SHOULD/MAY configuration files

  Configuration file                                                  Description
  ------------------------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_SharePointFoundation2010\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Foundation 2010 Service Pack 2 (SP2).
  MS-XXXX\_SharePointFoundation2013\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Foundation 2013 Service Pack 1 (SP1).
  MS-XXXX\_SharePointServer2010\_SHOULDMAY.deployment.ptfconfig       Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Server 2010 Service Pack 2 (SP2).
  MS-XXXX\_SharePointServer2013\_SHOULDMAY.deployment.ptfconfig       Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Server 2013 Service Pack 1 (SP1).

### <span id="_Toc403485579" class="anchor"><span id="_Toc405368986" class="anchor"></span></span>Configuring the test suite client using setup configuration script

***Note** The setup configuration script is only implemented for
configuring the test suite client on the Windows platform. *

To configure the test suite using the setup configuration script,
navigate to the **Setup\\Test Suite Client**\\ folder, right-click
**SharePointClientConfiguration.cmd** and select **Run as
administrator.**

### <span id="_Toc403125808" class="anchor"><span id="_Toc403400814" class="anchor"><span id="_Toc403406304" class="anchor"><span id="_Toc403485274" class="anchor"><span id="_Toc403558070" class="anchor"><span id="_Toc403558498" class="anchor"><span id="_Toc403125809" class="anchor"><span id="_Toc403400815" class="anchor"><span id="_Toc403406305" class="anchor"><span id="_Toc403485275" class="anchor"><span id="_Toc403558071" class="anchor"><span id="_Toc403558499" class="anchor"><span id="_Toc403485580" class="anchor"><span id="_Toc405368987" class="anchor"><span id="_Toc335752278" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the test suite client manually

If you didn’t use the setup configuration script to configure the test
suite client as described in the previous section, follow the steps
below to update configuration files and configure the test suite client.

1.  Update the property value in the common configuration file and the
    test suite-specific configuration files according to the comment of
    the property.

2.  By default, the test suites use PowerShell script in the SUT control
    adapter to configure the SUT. If you chose interactive mode for the
    SUT control adapter as described in section
    [5.2.2.1](#Configure_Interactive_Mode), skip this step.

    a.  <span id="_Toc401569779" class="anchor"><span id="_Toc401579523"
        class="anchor"><span id="_Toc401588951" class="anchor"><span
        id="_Toc401590031" class="anchor"><span id="_Toc401598836"
        class="anchor"><span id="_Toc401599943" class="anchor"><span
        id="_Toc401600998" class="anchor"><span id="_Toc401602053"
        class="anchor"><span id="_Toc401603108" class="anchor"><span
        id="_Toc401604102" class="anchor"><span id="_Toc401605176"
        class="anchor"><span id="_Toc401606250" class="anchor"><span
        id="_Toc401758845" class="anchor"><span id="_Toc401838648"
        class="anchor"><span id="_Toc401839912" class="anchor"><span
        id="_Toc401854794" class="anchor"><span id="_Toc401855868"
        class="anchor"><span id="_Toc401935571" class="anchor"><span
        id="_Toc401936645" class="anchor"><span id="_Toc402188967"
        class="anchor"><span id="_Toc401569780" class="anchor"><span
        id="_Toc401579524" class="anchor"><span id="_Toc401588952"
        class="anchor"><span id="_Toc401590032" class="anchor"><span
        id="_Toc401598837" class="anchor"><span id="_Toc401599944"
        class="anchor"><span id="_Toc401600999" class="anchor"><span
        id="_Toc401602054" class="anchor"><span id="_Toc401603109"
        class="anchor"><span id="_Toc401604103" class="anchor"><span
        id="_Toc401605177" class="anchor"><span id="_Toc401606251"
        class="anchor"><span id="_Toc401758846" class="anchor"><span
        id="_Toc401838649" class="anchor"><span id="_Toc401839913"
        class="anchor"><span id="_Toc401854795" class="anchor"><span
        id="_Toc401855869" class="anchor"><span id="_Toc401935572"
        class="anchor"><span id="_Toc401936646" class="anchor"><span
        id="_Toc402188968" class="anchor"><span id="_Toc401569834"
        class="anchor"><span id="_Toc401579578" class="anchor"><span
        id="_Toc401589006" class="anchor"><span id="_Toc401590086"
        class="anchor"><span id="_Toc401598891" class="anchor"><span
        id="_Toc401599998" class="anchor"><span id="_Toc401601053"
        class="anchor"><span id="_Toc401602108" class="anchor"><span
        id="_Toc401603163" class="anchor"><span id="_Toc401604157"
        class="anchor"><span id="_Toc401605231" class="anchor"><span
        id="_Toc401606305" class="anchor"><span id="_Toc401758900"
        class="anchor"><span id="_Toc401838703" class="anchor"><span
        id="_Toc401839967" class="anchor"><span id="_Toc401854849"
        class="anchor"><span id="_Toc401855923" class="anchor"><span
        id="_Toc401935626" class="anchor"><span id="_Toc401936700"
        class="anchor"><span id="_Toc402189022" class="anchor"><span
        id="_Toc401569835" class="anchor"><span id="_Toc401579579"
        class="anchor"><span id="_Toc401589007" class="anchor"><span
        id="_Toc401590087" class="anchor"><span id="_Toc401598892"
        class="anchor"><span id="_Toc401599999" class="anchor"><span
        id="_Toc401601054" class="anchor"><span id="_Toc401602109"
        class="anchor"><span id="_Toc401603164" class="anchor"><span
        id="_Toc401604158" class="anchor"><span id="_Toc401605232"
        class="anchor"><span id="_Toc401606306" class="anchor"><span
        id="_Toc401758901" class="anchor"><span id="_Toc401838704"
        class="anchor"><span id="_Toc401839968" class="anchor"><span
        id="_Toc401854850" class="anchor"><span id="_Toc401855924"
        class="anchor"><span id="_Toc401935627" class="anchor"><span
        id="_Toc401936701" class="anchor"><span id="_Toc402189023"
        class="anchor"><span id="_Toc401569845" class="anchor"><span
        id="_Toc401579589" class="anchor"><span id="_Toc401589017"
        class="anchor"><span id="_Toc401590097" class="anchor"><span
        id="_Toc401598902" class="anchor"><span id="_Toc401600009"
        class="anchor"><span id="_Toc401601064" class="anchor"><span
        id="_Toc401602119" class="anchor"><span id="_Toc401603174"
        class="anchor"><span id="_Toc401604168" class="anchor"><span
        id="_Toc401605242" class="anchor"><span id="_Toc401606316"
        class="anchor"><span id="_Toc401758911" class="anchor"><span
        id="_Toc401838714" class="anchor"><span id="_Toc401839978"
        class="anchor"><span id="_Toc401854860" class="anchor"><span
        id="_Toc401855934" class="anchor"><span id="_Toc401935637"
        class="anchor"><span id="_Toc401936711" class="anchor"><span
        id="_Toc402189033" class="anchor"><span id="_Toc401569846"
        class="anchor"><span id="_Toc401579590" class="anchor"><span
        id="_Toc401589018" class="anchor"><span id="_Toc401590098"
        class="anchor"><span id="_Toc401598903" class="anchor"><span
        id="_Toc401600010" class="anchor"><span id="_Toc401601065"
        class="anchor"><span id="_Toc401602120" class="anchor"><span
        id="_Toc401603175" class="anchor"><span id="_Toc401604169"
        class="anchor"><span id="_Toc401605243" class="anchor"><span
        id="_Toc401606317" class="anchor"><span id="_Toc401758912"
        class="anchor"><span id="_Toc401838715" class="anchor"><span
        id="_Toc401839979" class="anchor"><span id="_Toc401854861"
        class="anchor"><span id="_Toc401855935" class="anchor"><span
        id="_Toc401935638" class="anchor"><span id="_Toc401936712"
        class="anchor"><span id="_Toc402189034" class="anchor"><span
        id="_Toc401569847" class="anchor"><span id="_Toc401579591"
        class="anchor"><span id="_Toc401589019" class="anchor"><span
        id="_Toc401590099" class="anchor"><span id="_Toc401598904"
        class="anchor"><span id="_Toc401600011" class="anchor"><span
        id="_Toc401601066" class="anchor"><span id="_Toc401602121"
        class="anchor"><span id="_Toc401603176" class="anchor"><span
        id="_Toc401604170" class="anchor"><span id="_Toc401605244"
        class="anchor"><span id="_Toc401606318" class="anchor"><span
        id="_Toc401758913" class="anchor"><span id="_Toc401838716"
        class="anchor"><span id="_Toc401839980" class="anchor"><span
        id="_Toc401854862" class="anchor"><span id="_Toc401855936"
        class="anchor"><span id="_Toc401935639" class="anchor"><span
        id="_Toc401936713" class="anchor"><span id="_Toc402189035"
        class="anchor"><span id="_Toc401569848" class="anchor"><span
        id="_Toc401579592" class="anchor"><span id="_Toc401589020"
        class="anchor"><span id="_Toc401590100" class="anchor"><span
        id="_Toc401598905" class="anchor"><span id="_Toc401600012"
        class="anchor"><span id="_Toc401601067" class="anchor"><span
        id="_Toc401602122" class="anchor"><span id="_Toc401603177"
        class="anchor"><span id="_Toc401604171" class="anchor"><span
        id="_Toc401605245" class="anchor"><span id="_Toc401606319"
        class="anchor"><span id="_Toc401758914" class="anchor"><span
        id="_Toc401838717" class="anchor"><span id="_Toc401839981"
        class="anchor"><span id="_Toc401854863" class="anchor"><span
        id="_Toc401855937" class="anchor"><span id="_Toc401935640"
        class="anchor"><span id="_Toc401936714" class="anchor"><span
        id="_Toc402189036" class="anchor"><span id="_Toc401569849"
        class="anchor"><span id="_Toc401579593" class="anchor"><span
        id="_Toc401589021" class="anchor"><span id="_Toc401590101"
        class="anchor"><span id="_Toc401598906" class="anchor"><span
        id="_Toc401600013" class="anchor"><span id="_Toc401601068"
        class="anchor"><span id="_Toc401602123" class="anchor"><span
        id="_Toc401603178" class="anchor"><span id="_Toc401604172"
        class="anchor"><span id="_Toc401605246" class="anchor"><span
        id="_Toc401606320" class="anchor"><span id="_Toc401758915"
        class="anchor"><span id="_Toc401838718" class="anchor"><span
        id="_Toc401839982" class="anchor"><span id="_Toc401854864"
        class="anchor"><span id="_Toc401855938" class="anchor"><span
        id="_Toc401935641" class="anchor"><span id="_Toc401936715"
        class="anchor"><span id="_Toc402189037" class="anchor"><span
        id="_Toc401569850" class="anchor"><span id="_Toc401579594"
        class="anchor"><span id="_Toc401589022" class="anchor"><span
        id="_Toc401590102" class="anchor"><span id="_Toc401598907"
        class="anchor"><span id="_Toc401600014" class="anchor"><span
        id="_Toc401601069" class="anchor"><span id="_Toc401602124"
        class="anchor"><span id="_Toc401603179" class="anchor"><span
        id="_Toc401604173" class="anchor"><span id="_Toc401605247"
        class="anchor"><span id="_Toc401606321" class="anchor"><span
        id="_Toc401758916" class="anchor"><span id="_Toc401838719"
        class="anchor"><span id="_Toc401839983" class="anchor"><span
        id="_Toc401854865" class="anchor"><span id="_Toc401855939"
        class="anchor"><span id="_Toc401935642" class="anchor"><span
        id="_Toc401936716" class="anchor"><span id="_Toc402189038"
        class="anchor"><span id="_Toc401569863" class="anchor"><span
        id="_Toc401579607" class="anchor"><span id="_Toc401589035"
        class="anchor"><span id="_Toc401590115" class="anchor"><span
        id="_Toc401598920" class="anchor"><span id="_Toc401600027"
        class="anchor"><span id="_Toc401601082" class="anchor"><span
        id="_Toc401602137" class="anchor"><span id="_Toc401603192"
        class="anchor"><span id="_Toc401604186" class="anchor"><span
        id="_Toc401605260" class="anchor"><span id="_Toc401606334"
        class="anchor"><span id="_Toc401758929" class="anchor"><span
        id="_Toc401838732" class="anchor"><span id="_Toc401839996"
        class="anchor"><span id="_Toc401854878" class="anchor"><span
        id="_Toc401855952" class="anchor"><span id="_Toc401935655"
        class="anchor"><span id="_Toc401936729" class="anchor"><span
        id="_Toc402189051" class="anchor"><span id="_Toc401569864"
        class="anchor"><span id="_Toc401579608" class="anchor"><span
        id="_Toc401589036" class="anchor"><span id="_Toc401590116"
        class="anchor"><span id="_Toc401598921" class="anchor"><span
        id="_Toc401600028" class="anchor"><span id="_Toc401601083"
        class="anchor"><span id="_Toc401602138" class="anchor"><span
        id="_Toc401603193" class="anchor"><span id="_Toc401604187"
        class="anchor"><span id="_Toc401605261" class="anchor"><span
        id="_Toc401606335" class="anchor"><span id="_Toc401758930"
        class="anchor"><span id="_Toc401838733" class="anchor"><span
        id="_Toc401839997" class="anchor"><span id="_Toc401854879"
        class="anchor"><span id="_Toc401855953" class="anchor"><span
        id="_Toc401935656" class="anchor"><span id="_Toc401936730"
        class="anchor"><span id="_Toc402189052" class="anchor"><span
        id="_Toc401569865" class="anchor"><span id="_Toc401579609"
        class="anchor"><span id="_Toc401589037" class="anchor"><span
        id="_Toc401590117" class="anchor"><span id="_Toc401598922"
        class="anchor"><span id="_Toc401600029" class="anchor"><span
        id="_Toc401601084" class="anchor"><span id="_Toc401602139"
        class="anchor"><span id="_Toc401603194" class="anchor"><span
        id="_Toc401604188" class="anchor"><span id="_Toc401605262"
        class="anchor"><span id="_Toc401606336" class="anchor"><span
        id="_Toc401758931" class="anchor"><span id="_Toc401838734"
        class="anchor"><span id="_Toc401839998" class="anchor"><span
        id="_Toc401854880" class="anchor"><span id="_Toc401855954"
        class="anchor"><span id="_Toc401935657" class="anchor"><span
        id="_Toc401936731" class="anchor"><span id="_Toc402189053"
        class="anchor"><span id="_Toc401569866" class="anchor"><span
        id="_Toc401579610" class="anchor"><span id="_Toc401589038"
        class="anchor"><span id="_Toc401590118" class="anchor"><span
        id="_Toc401598923" class="anchor"><span id="_Toc401600030"
        class="anchor"><span id="_Toc401601085" class="anchor"><span
        id="_Toc401602140" class="anchor"><span id="_Toc401603195"
        class="anchor"><span id="_Toc401604189" class="anchor"><span
        id="_Toc401605263" class="anchor"><span id="_Toc401606337"
        class="anchor"><span id="_Toc401758932" class="anchor"><span
        id="_Toc401838735" class="anchor"><span id="_Toc401839999"
        class="anchor"><span id="_Toc401854881" class="anchor"><span
        id="_Toc401855955" class="anchor"><span id="_Toc401935658"
        class="anchor"><span id="_Toc401936732" class="anchor"><span
        id="_Toc402189054" class="anchor"><span id="_Toc401569867"
        class="anchor"><span id="_Toc401579611" class="anchor"><span
        id="_Toc401589039" class="anchor"><span id="_Toc401590119"
        class="anchor"><span id="_Toc401598924" class="anchor"><span
        id="_Toc401600031" class="anchor"><span id="_Toc401601086"
        class="anchor"><span id="_Toc401602141" class="anchor"><span
        id="_Toc401603196" class="anchor"><span id="_Toc401604190"
        class="anchor"><span id="_Toc401605264" class="anchor"><span
        id="_Toc401606338" class="anchor"><span id="_Toc401758933"
        class="anchor"><span id="_Toc401838736" class="anchor"><span
        id="_Toc401840000" class="anchor"><span id="_Toc401854882"
        class="anchor"><span id="_Toc401855956" class="anchor"><span
        id="_Toc401935659" class="anchor"><span id="_Toc401936733"
        class="anchor"><span id="_Toc402189055" class="anchor"><span
        id="_Toc401569868" class="anchor"><span id="_Toc401579612"
        class="anchor"><span id="_Toc401589040" class="anchor"><span
        id="_Toc401590120" class="anchor"><span id="_Toc401598925"
        class="anchor"><span id="_Toc401600032" class="anchor"><span
        id="_Toc401601087" class="anchor"><span id="_Toc401602142"
        class="anchor"><span id="_Toc401603197" class="anchor"><span
        id="_Toc401604191" class="anchor"><span id="_Toc401605265"
        class="anchor"><span id="_Toc401606339" class="anchor"><span
        id="_Toc401758934" class="anchor"><span id="_Toc401838737"
        class="anchor"><span id="_Toc401840001" class="anchor"><span
        id="_Toc401854883" class="anchor"><span id="_Toc401855957"
        class="anchor"><span id="_Toc401935660" class="anchor"><span
        id="_Toc401936734" class="anchor"><span id="_Toc402189056"
        class="anchor"><span id="_Toc401569869" class="anchor"><span
        id="_Toc401579613" class="anchor"><span id="_Toc401589041"
        class="anchor"><span id="_Toc401590121" class="anchor"><span
        id="_Toc401598926" class="anchor"><span id="_Toc401600033"
        class="anchor"><span id="_Toc401601088" class="anchor"><span
        id="_Toc401602143" class="anchor"><span id="_Toc401603198"
        class="anchor"><span id="_Toc401604192" class="anchor"><span
        id="_Toc401605266" class="anchor"><span id="_Toc401606340"
        class="anchor"><span id="_Toc401758935" class="anchor"><span
        id="_Toc401838738" class="anchor"><span id="_Toc401840002"
        class="anchor"><span id="_Toc401854884" class="anchor"><span
        id="_Toc401855958" class="anchor"><span id="_Toc401935661"
        class="anchor"><span id="_Toc401936735" class="anchor"><span
        id="_Toc402189057" class="anchor"><span id="_Toc401569891"
        class="anchor"><span id="_Toc401579635" class="anchor"><span
        id="_Toc401589063" class="anchor"><span id="_Toc401590143"
        class="anchor"><span id="_Toc401598948" class="anchor"><span
        id="_Toc401600055" class="anchor"><span id="_Toc401601110"
        class="anchor"><span id="_Toc401602165" class="anchor"><span
        id="_Toc401603220" class="anchor"><span id="_Toc401604214"
        class="anchor"><span id="_Toc401605288" class="anchor"><span
        id="_Toc401606362" class="anchor"><span id="_Toc401758957"
        class="anchor"><span id="_Toc401838760" class="anchor"><span
        id="_Toc401840024" class="anchor"><span id="_Toc401840160"
        class="anchor"><span id="_Toc401839694" class="anchor"><span
        id="_Toc401840215" class="anchor"><span id="_Toc401840052"
        class="anchor"><span id="_Toc401854906" class="anchor"><span
        id="_Toc401855980" class="anchor"><span id="_Toc401935683"
        class="anchor"><span id="_Toc401936757" class="anchor"><span
        id="_Toc402189079" class="anchor"><span id="_Configure_the_test"
        class="anchor"><span id="_Configure_the_test_1"
        class="anchor"><span id="_Toc401569892" class="anchor"><span
        id="_Toc401579636" class="anchor"><span id="_Toc401589064"
        class="anchor"><span id="_Toc401590144" class="anchor"><span
        id="_Toc401598949" class="anchor"><span id="_Toc401600056"
        class="anchor"><span id="_Toc401601111" class="anchor"><span
        id="_Toc401602166" class="anchor"><span id="_Toc401603221"
        class="anchor"><span id="_Toc401604215" class="anchor"><span
        id="_Toc401605289" class="anchor"><span id="_Toc401606363"
        class="anchor"><span id="_Toc401758958" class="anchor"><span
        id="_Toc401838761" class="anchor"><span id="_Toc401840025"
        class="anchor"><span id="_Toc401854907" class="anchor"><span
        id="_Toc401855981" class="anchor"><span id="_Toc401935684"
        class="anchor"><span id="_Toc401936758" class="anchor"><span
        id="_Toc402189080" class="anchor"><span id="_Toc401569893"
        class="anchor"><span id="_Toc401579637" class="anchor"><span
        id="_Toc401589065" class="anchor"><span id="_Toc401590145"
        class="anchor"><span id="_Toc401598950" class="anchor"><span
        id="_Toc401600057" class="anchor"><span id="_Toc401601112"
        class="anchor"><span id="_Toc401602167" class="anchor"><span
        id="_Toc401603222" class="anchor"><span id="_Toc401604216"
        class="anchor"><span id="_Toc401605290" class="anchor"><span
        id="_Toc401606364" class="anchor"><span id="_Toc401758959"
        class="anchor"><span id="_Toc401838762" class="anchor"><span
        id="_Toc401840026" class="anchor"><span id="_Toc401854908"
        class="anchor"><span id="_Toc401855982" class="anchor"><span
        id="_Toc401935685" class="anchor"><span id="_Toc401936759"
        class="anchor"><span id="_Toc402189081"
        class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Set
        the execution policy to RemoteSigned.

    b.  Add the SUT to the TrustedHosts to ensure that the Windows
        Remote Management (WinRM) client can process remote calls
        against the SUT if the test suite client is not joined to
        the domain.

<!-- -->

1.  If client don’t join the domain and you plan to use PowerShell mode
    of SUT control adapter, add SUT machine to the TrustedHosts
    configuration setting to ensure WinRM client can process remote
    calls against SUT machine.

<!-- -->

1.  Add a firewall rule to allow the TCP protocol for port 80.

<span id="_Toc403400838" class="anchor"><span id="_Toc403406328" class="anchor"><span id="_Toc403485298" class="anchor"><span id="_Toc403558094" class="anchor"><span id="_Toc403558522" class="anchor"><span id="_Toc403485299" class="anchor"><span id="_Toc403485761" class="anchor"><span id="_Toc403558095" class="anchor"><span id="_Toc403558523" class="anchor"><span id="_Toc403125833" class="anchor"><span id="_Toc403400840" class="anchor"><span id="_Toc403406330" class="anchor"><span id="_Toc403485300" class="anchor"><span id="_Toc403558096" class="anchor"><span id="_Toc403558524" class="anchor"><span id="_Toc403125834" class="anchor"><span id="_Toc403400841" class="anchor"><span id="_Toc403406331" class="anchor"><span id="_Toc403485301" class="anchor"><span id="_Toc403558097" class="anchor"><span id="_Toc403558525" class="anchor"><span id="_Toc403125835" class="anchor"><span id="_Toc403400842" class="anchor"><span id="_Toc403406332" class="anchor"><span id="_Toc403485302" class="anchor"><span id="_Toc403558098" class="anchor"><span id="_Toc403558526" class="anchor"><span id="_Toc403125836" class="anchor"><span id="_Toc403400843" class="anchor"><span id="_Toc403406333" class="anchor"><span id="_Toc403485303" class="anchor"><span id="_Toc403558099" class="anchor"><span id="_Toc403558527" class="anchor"><span id="_Toc403125837" class="anchor"><span id="_Toc403400844" class="anchor"><span id="_Toc403406334" class="anchor"><span id="_Toc403485304" class="anchor"><span id="_Toc403558100" class="anchor"><span id="_Toc403558528" class="anchor"><span id="_Toc403125838" class="anchor"><span id="_Toc403400845" class="anchor"><span id="_Toc403406335" class="anchor"><span id="_Toc403485305" class="anchor"><span id="_Toc403558101" class="anchor"><span id="_Toc403558529" class="anchor"><span id="_Toc403125839" class="anchor"><span id="_Toc403400846" class="anchor"><span id="_Toc403406336" class="anchor"><span id="_Toc403485306" class="anchor"><span id="_Toc403558102" class="anchor"><span id="_Toc403558530" class="anchor"><span id="_Toc403125840" class="anchor"><span id="_Toc403400847" class="anchor"><span id="_Toc403406337" class="anchor"><span id="_Toc403485307" class="anchor"><span id="_Toc403558103" class="anchor"><span id="_Toc403558531" class="anchor"><span id="_Toc403125841" class="anchor"><span id="_Toc403400848" class="anchor"><span id="_Toc403406338" class="anchor"><span id="_Toc403485308" class="anchor"><span id="_Toc403485762" class="anchor"><span id="_Toc403558104" class="anchor"><span id="_Toc403558532" class="anchor"><span id="_Toc403125842" class="anchor"><span id="_Toc403400849" class="anchor"><span id="_Toc403406339" class="anchor"><span id="_Toc403485309" class="anchor"><span id="_Toc403558105" class="anchor"><span id="_Toc403558533" class="anchor"><span id="_Toc403125843" class="anchor"><span id="_Toc403400850" class="anchor"><span id="_Toc403406340" class="anchor"><span id="_Toc403485310" class="anchor"><span id="_Toc403558106" class="anchor"><span id="_Toc403558534" class="anchor"><span id="_Toc403125844" class="anchor"><span id="_Toc403400851" class="anchor"><span id="_Toc403406341" class="anchor"><span id="_Toc403485311" class="anchor"><span id="_Toc403558107" class="anchor"><span id="_Toc403558535" class="anchor"><span id="_Toc403125845" class="anchor"><span id="_Toc403400852" class="anchor"><span id="_Toc403406342" class="anchor"><span id="_Toc403485312" class="anchor"><span id="_Toc403558108" class="anchor"><span id="_Toc403558536" class="anchor"><span id="_Toc403125846" class="anchor"><span id="_Toc403400853" class="anchor"><span id="_Toc403406343" class="anchor"><span id="_Toc403485313" class="anchor"><span id="_Toc403558109" class="anchor"><span id="_Toc403558537" class="anchor"><span id="_Toc403125847" class="anchor"><span id="_Toc403400854" class="anchor"><span id="_Toc403406344" class="anchor"><span id="_Toc403485314" class="anchor"><span id="_Toc403558110" class="anchor"><span id="_Toc403558538" class="anchor"><span id="_Toc344286940" class="anchor"><span id="_Toc403485583" class="anchor"><span id="_Toc405368988" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Running test suites
============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

Once the required software has been installed and both the SUT and test
suite client have been configured appropriately, the test suite is ready
to run. The test suite can only run on the test suite client and can be
initiated in one of the following two ways: Visual Studio or batch
scripts.

***Note***   *Do not run MS-WOPI and MS-FSSHTTP-FSSHTTPB test suites
simultaneously. *

<span id="_Toc306892175" class="anchor"><span id="_Toc344286941" class="anchor"><span id="_Toc403485584" class="anchor"><span id="_Toc405368989" class="anchor"></span></span></span></span>Microsoft Visual Studio
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

A Visual Studio solution file
**SharePointFileSyncAndWOPIProtocolTestSuites.sln** is provided in the
**Source** folder.

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Open **SharePointFileSyncAndWOPIProtocolTestSuites.sln** in Visual Studio.                                                                            ![](media/image5.png){width="2.9557097550306213in" height="1.6720002187226597in"}
                                                                                                                                                            
                                                                                                                                                            
  --------------------------------------------------------------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------
  1.  In the **Solution Explorer** pane, right-click **Solution** ‘**SharePointFileSyncAndWOPIProtocolTestSuites**’, and then click **Rebuild Solution**.   ![](media/image6.png){width="2.96in" height="2.48in"}
                                                                                                                                                            
                                                                                                                                                            

  1.  Open **Test Explorer**. On the ribbon, click **TEST,** then click **Windows**, and finally click **Test Explorer**.                                   ![](media/image7.png){width="2.9519958442694665in" height="1.4079997812773404in"}
                                                                                                                                                            
                                                                                                                                                            

  1.  Select the test case to run, right-click the test case and then select **Run Selected Tests**.                                                        ![](media/image8.png){width="2.9839949693788275in" height="3.08in"}
                                                                                                                                                            
                                                                                                                                                            
  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line" class="anchor"><span id="_Toc306892176"
class="anchor"></span></span>A Visual Studio solution file
**MS-XXXX.sln** is provided in each test suite folder.

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Select the test suite you would like to run. Let’s take MS-FSSHTTP-FSSHTTPB as an example here, so browse to the **Source\\MS-FSSHTTP-FSSHTTPB** directory.

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------------
  1.  Open **MS-FSSHTTP-FSSHTTPB.sln** in Visual Studio.

  1.  In the **Solution Explorer** pane, right-click **Solution** ‘**MS-FSSHTTP-FSSHTTPB**’, and then click **Rebuild Solution**.

  1.  Open **Test Explorer**. On the ribbon, click **TEST**, then click **Windows**, and finally click **Test Explorer**.

  1.  Select the test case to run. Right-click the test case and then select **Run Selected Tests**.

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line_1" class="anchor"><span id="_Toc403125850" class="anchor"><span id="_Toc403400857" class="anchor"><span id="_Toc403406347" class="anchor"><span id="_Toc403485317" class="anchor"><span id="_Toc403485765" class="anchor"><span id="_Toc403558113" class="anchor"><span id="_Toc403558541" class="anchor"><span id="_Toc403125851" class="anchor"><span id="_Toc403400858" class="anchor"><span id="_Toc403406348" class="anchor"><span id="_Toc403485318" class="anchor"><span id="_Toc403558114" class="anchor"><span id="_Toc403558542" class="anchor"><span id="_Toc403125852" class="anchor"><span id="_Toc403400859" class="anchor"><span id="_Toc403406349" class="anchor"><span id="_Toc403485319" class="anchor"><span id="_Toc403558115" class="anchor"><span id="_Toc403558543" class="anchor"><span id="_Toc306892177" class="anchor"><span id="_Toc344286943" class="anchor"><span id="_Toc403485586" class="anchor"><span id="_Toc405368990" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Batch scripts
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

SharePoint File Sync and WOPI Protocol Test Suites are installed with a
collection of scripts that enable a user to run individual test cases
(RunMSXXXX\_SYY\_TCZZ\_Name.cmd) or all test cases of one test suite
(RunAllMSXXXXTestCases.cmd), or all test cases of SharePoint File Sync
and WOPI Protocol Test Suites at once
(RunAllSharePoint\_FileSyncAndWOPI\_TestCases.cmd). These scripts can be
found in the **\\Source\\Scripts** directory.

**Note**   These scripts depend on having the compiled binaries in the
bin folder.

  **Batch script**                                   **Script description**
  -------------------------------------------------- ----------------------------------------------------------------------------------------
  RunAllSharePoint\_FileSyncAndWOPI\_TestCases.cmd   Runs all the test cases within the SharePoint File Sync and WOPI Protocol Test Suites.
  RunAllMSXXXXTestCases.cmd                          Runs all MS-XXXX test cases.
  RunMSXXXX\_SYY\_TCZZ\_Name.cmd                     Runs a specific test case within the test suite.

<span id="_Toc344286944" class="anchor"></span>

<span id="_Toc403485587" class="anchor"><span id="_Toc405368991" class="anchor"></span></span>Test suite results, logs, and reporting
=====================================================================================================================================

The test suites provide detailed reporting in a variety of formats that
will enable users to quickly debug failures.

<span id="_Toc344286945" class="anchor"><span id="_Toc403485588" class="anchor"><span id="_Toc405368992" class="anchor"></span></span></span>Test suite configuration logs
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

The configuration logs contain information about whether each
configuration step succeeds or not, and detail error information if the
configuration step fails.

### <span id="_Toc403558131" class="anchor"><span id="_Toc403558559" class="anchor"><span id="_Toc401152810" class="anchor"><span id="_Toc401840225" class="anchor"><span id="_Toc402365842" class="anchor"><span id="_Toc403485589" class="anchor"><span id="_Toc405368993" class="anchor"></span></span></span></span></span></span></span>SUT configuration logs

The SUT configuration scripts create a directory named **SetupLogs**
under **…\\Setup\\SUT\\** at runtime. The SUT configuration scripts save
the logs as “SharePointSUTConfiguration.ps1.debug.log” and
“SharePointSUTConfiguration.ps1.log”.

### <span id="_Toc401152811" class="anchor"><span id="_Toc401840226" class="anchor"><span id="_Toc402365843" class="anchor"><span id="_Toc403485590" class="anchor"><span id="_Toc405368994" class="anchor"></span></span></span></span></span>Test suite client configuration logs

The configuration scripts create a directory named **SetupLogs** under
**…\\Setup\\Test Suite Client\\** at runtime. The test suite client
configuration scripts save the logs as
“SharePointClientConfiguration.ps1.debug.log” and
“SharePointClientConfiguration.ps1.log”.

<span id="_Toc344286946" class="anchor"><span id="_Toc403485591" class="anchor"><span id="_Toc405368995" class="anchor"></span></span></span>Test suite reports
---------------------------------------------------------------------------------------------------------------------------------------------------------------

### <span id="_Toc401152813" class="anchor"><span id="_Toc401840228" class="anchor"><span id="_Toc402365845" class="anchor"><span id="_Toc403485592" class="anchor"><span id="_Toc405368996" class="anchor"></span></span></span></span></span>Microsoft Visual Studio

Reports are created only after the package-level solution or an
individual test suite solution has run successfully in Visual Studio.

-   Reporting information for
    **SharePointFileSyncAndWOPIProtocolTestSuites.sln** is saved in
    **…\\Source\\TestResults**.

-   Reporting information for an individual test suite **MS-XXXX.sln**
    is saved in **…\\Source\\MS-XXXX\\TestResults**.

### <span id="_Toc401152814" class="anchor"><span id="_Toc401840229" class="anchor"><span id="_Toc402365846" class="anchor"><span id="_Toc403485593" class="anchor"><span id="_Toc405368997" class="anchor"></span></span></span></span></span>Batch scripts

If the SharePoint Server Protocol test suites are run by the
RunAllSharePoint\_FileSyncAndWOPI\_TestCases.cmd batch file, the
reporting information is saved in **…\\Source\\Scripts\\TestResults**.

If the test suite is run by the batch file RunAllMSXXXXTestCases.cmd or
RunMSXXXX\_SYY\_TCZZ\_Name.cmd, the reporting information is saved in
**…\\Source\\Scripts\\MS-XXXX\\TestResults.**

By default, a .trx file containing the pass/fail information of the run
is created in the TestResults folder, along with an associated directory
named **user\_MACHINENAME DateTimeStamp** that contains a log file in
XML format and an HTML report.

<span id="_Toc403125873" class="anchor"><span id="_Toc403400880" class="anchor"><span id="_Toc403406370" class="anchor"><span id="_Toc403485340" class="anchor"><span id="_Toc403558137" class="anchor"><span id="_Toc403558565" class="anchor"><span id="_Toc403125874" class="anchor"><span id="_Toc403400881" class="anchor"><span id="_Toc403406371" class="anchor"><span id="_Toc403485341" class="anchor"><span id="_Toc403558138" class="anchor"><span id="_Toc403558566" class="anchor"><span id="_UserESSDN_Configuration" class="anchor"><span id="_Toc403485594" class="anchor"><span id="_Toc405368998" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Appendix
====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

  References                                                                                                             Description
  ---------------------------------------------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------
  <dochelp@microsoft.com>                                                                                                Alias for Interoperability documentation help. Provides support for the Open Specifications and protocol test suites.
  [Open Specifications Forums](http://go.microsoft.com/fwlink/?LinkId=111125)                                            Microsoft Customer Support Services forums. Actively monitored forums that provide support for the Open Specifications and Protocol test suites.
  [Open Specifications Developer Center](http://go.microsoft.com/fwlink/?LinkId=254469)                                  Open Specifications home page on MSDN.
  [Open Specifications](http://go.microsoft.com/fwlink/?LinkId=179743)                                                   Open Specifications documentation on MSDN.
  [SharePoint Products and Technologies Protocols](http://go.microsoft.com/fwlink/?LinkId=202122)                        SharePoint Open Specifications documentation on MSDN.
  [RFC2119](http://go.microsoft.com/fwlink/?LinkId=117453)                                                               Normative language reference.
  [Microsoft SharePoint Foundation 2010 deployment](http://go.microsoft.com/fwlink/?LinkId=517503)                       Microsoft SharePoint Foundation 2010 deployment on TechNet.
  [Microsoft SharePoint Foundation 2013 installation and configuration](http://go.microsoft.com/fwlink/?LinkId=517504)   Microsoft SharePoint Foundation 2013 installation and configuration on TechNet.
  [Microsoft SharePoint Server 2010 deployment](http://go.microsoft.com/fwlink/?LinkId=517505)                           Microsoft SharePoint Server 2010 deployment on TechNet.
  [Microsoft SharePoint Server 2013 installation and configuration](http://go.microsoft.com/fwlink/?LinkId=517504)       Microsoft SharePoint Server 2013 installation and configuration on TechNet.
