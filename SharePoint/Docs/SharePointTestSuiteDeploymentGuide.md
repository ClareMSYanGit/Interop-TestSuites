![](media/image1.png){width="6.145833333333333in"
height="1.7658169291338583in"}

SharePoint Test Suite Deployment Guide

<span id="_Toc344286921" class="anchor"><span id="_Toc401840182" class="anchor"><span id="_Toc405814756" class="anchor"></span></span></span>Overview
=====================================================================================================================================================

The SharePoint Server Protocol Test Suites are implemented as synthetic
clients running against a server-side implementation of a given
SharePoint protocol. They are designed in a client-to-server
relationship and were originally developed for the in-house testing of
the Microsoft Open Specifications. Test Suites have been used
extensively in Plugfests and Interoperability Labs to test partner
implementations.

The SharePoint Test Suite Deployment Guide introduces the hardware and
software requirements of the test suite client, and the requirements of
the system under test (SUT) if the test suites run against SharePoint
Server. The guide also introduces how to deploy, configure and run the
test suites, and view test suite reports.

<span id="_Toc401568921" class="anchor"><span id="_Toc401578665" class="anchor"><span id="_Toc401588093" class="anchor"><span id="_Toc401589173" class="anchor"><span id="_Toc401597978" class="anchor"><span id="_Toc401599003" class="anchor"><span id="_Toc401600140" class="anchor"><span id="_Toc401601195" class="anchor"><span id="_Toc401602250" class="anchor"><span id="_Toc401600110" class="anchor"><span id="_Toc401604318" class="anchor"><span id="_Toc401605392" class="anchor"><span id="_Toc401757987" class="anchor"><span id="_Toc401837790" class="anchor"><span id="_Toc401839054" class="anchor"><span id="_Toc401853936" class="anchor"><span id="_Toc401855010" class="anchor"><span id="_Toc401934713" class="anchor"><span id="_Toc401935787" class="anchor"><span id="_Toc402188109" class="anchor"><span id="_Toc402343498" class="anchor"><span id="_Toc401311000" class="anchor"><span id="_Toc401323062" class="anchor"><span id="_Toc401568922" class="anchor"><span id="_Toc401578666" class="anchor"><span id="_Toc401588094" class="anchor"><span id="_Toc401589174" class="anchor"><span id="_Toc401597979" class="anchor"><span id="_Toc401599004" class="anchor"><span id="_Toc401600141" class="anchor"><span id="_Toc401601196" class="anchor"><span id="_Toc401602251" class="anchor"><span id="_Toc401600111" class="anchor"><span id="_Toc401604319" class="anchor"><span id="_Toc401605393" class="anchor"><span id="_Toc401757988" class="anchor"><span id="_Toc401837791" class="anchor"><span id="_Toc401839055" class="anchor"><span id="_Toc401840128" class="anchor"><span id="_Toc401839593" class="anchor"><span id="_Toc401840183" class="anchor"><span id="_Toc401839887" class="anchor"><span id="_Toc401853937" class="anchor"><span id="_Toc401855011" class="anchor"><span id="_Toc401934714" class="anchor"><span id="_Toc401935788" class="anchor"><span id="_Toc402188110" class="anchor"><span id="_Toc402343499" class="anchor"><span id="_Toc401311001" class="anchor"><span id="_Toc401323063" class="anchor"><span id="_Toc401568923" class="anchor"><span id="_Toc401578667" class="anchor"><span id="_Toc401588095" class="anchor"><span id="_Toc401589175" class="anchor"><span id="_Toc401597980" class="anchor"><span id="_Toc401599020" class="anchor"><span id="_Toc401600142" class="anchor"><span id="_Toc401601197" class="anchor"><span id="_Toc401602252" class="anchor"><span id="_Toc401600127" class="anchor"><span id="_Toc401604320" class="anchor"><span id="_Toc401605394" class="anchor"><span id="_Toc401757989" class="anchor"><span id="_Toc401837792" class="anchor"><span id="_Toc401839056" class="anchor"><span id="_Toc401853938" class="anchor"><span id="_Toc401855012" class="anchor"><span id="_Toc401934715" class="anchor"><span id="_Toc401935789" class="anchor"><span id="_Toc402188111" class="anchor"><span id="_Toc402343500" class="anchor"><span id="_Toc401311002" class="anchor"><span id="_Toc401323064" class="anchor"><span id="_Toc401568924" class="anchor"><span id="_Toc401578668" class="anchor"><span id="_Toc401588096" class="anchor"><span id="_Toc401589176" class="anchor"><span id="_Toc401597981" class="anchor"><span id="_Toc401599040" class="anchor"><span id="_Toc401600143" class="anchor"><span id="_Toc401601198" class="anchor"><span id="_Toc401602253" class="anchor"><span id="_Toc401600128" class="anchor"><span id="_Toc401604321" class="anchor"><span id="_Toc401605395" class="anchor"><span id="_Toc401757990" class="anchor"><span id="_Toc401837793" class="anchor"><span id="_Toc401839057" class="anchor"><span id="_Toc401853939" class="anchor"><span id="_Toc401855013" class="anchor"><span id="_Toc401934716" class="anchor"><span id="_Toc401935790" class="anchor"><span id="_Toc402188112" class="anchor"><span id="_Toc402343501" class="anchor"><span id="_Toc401311057" class="anchor"><span id="_Toc401323119" class="anchor"><span id="_Toc401568979" class="anchor"><span id="_Toc401578723" class="anchor"><span id="_Toc401588151" class="anchor"><span id="_Toc401589231" class="anchor"><span id="_Toc401598036" class="anchor"><span id="_Toc401599152" class="anchor"><span id="_Toc401600198" class="anchor"><span id="_Toc401601253" class="anchor"><span id="_Toc401602308" class="anchor"><span id="_Toc401602031" class="anchor"><span id="_Toc401604376" class="anchor"><span id="_Toc401605450" class="anchor"><span id="_Toc401758045" class="anchor"><span id="_Toc401837848" class="anchor"><span id="_Toc401839112" class="anchor"><span id="_Toc401853994" class="anchor"><span id="_Toc401855068" class="anchor"><span id="_Toc401934771" class="anchor"><span id="_Toc401935845" class="anchor"><span id="_Toc402188167" class="anchor"><span id="_Toc402343556" class="anchor"><span id="_Toc401311058" class="anchor"><span id="_Toc401323120" class="anchor"><span id="_Toc401568980" class="anchor"><span id="_Toc401578724" class="anchor"><span id="_Toc401588152" class="anchor"><span id="_Toc401589232" class="anchor"><span id="_Toc401598037" class="anchor"><span id="_Toc401599153" class="anchor"><span id="_Toc401600199" class="anchor"><span id="_Toc401601254" class="anchor"><span id="_Toc401602309" class="anchor"><span id="_Toc401602039" class="anchor"><span id="_Toc401604377" class="anchor"><span id="_Toc401605451" class="anchor"><span id="_Toc401758046" class="anchor"><span id="_Toc401837849" class="anchor"><span id="_Toc401839113" class="anchor"><span id="_Toc401840129" class="anchor"><span id="_Toc401839600" class="anchor"><span id="_Toc401840184" class="anchor"><span id="_Toc401839888" class="anchor"><span id="_Toc401853995" class="anchor"><span id="_Toc401855069" class="anchor"><span id="_Toc401934772" class="anchor"><span id="_Toc401935846" class="anchor"><span id="_Toc402188168" class="anchor"><span id="_Toc402343557" class="anchor"><span id="_Toc401311059" class="anchor"><span id="_Toc401323121" class="anchor"><span id="_Toc401568981" class="anchor"><span id="_Toc401578725" class="anchor"><span id="_Toc401588153" class="anchor"><span id="_Toc401589233" class="anchor"><span id="_Toc401598038" class="anchor"><span id="_Toc401599154" class="anchor"><span id="_Toc401600200" class="anchor"><span id="_Toc401601255" class="anchor"><span id="_Toc401602310" class="anchor"><span id="_Toc401602040" class="anchor"><span id="_Toc401604378" class="anchor"><span id="_Toc401605452" class="anchor"><span id="_Toc401758047" class="anchor"><span id="_Toc401837850" class="anchor"><span id="_Toc401839114" class="anchor"><span id="_Toc401853996" class="anchor"><span id="_Toc401855070" class="anchor"><span id="_Toc401934773" class="anchor"><span id="_Toc401935847" class="anchor"><span id="_Toc402188169" class="anchor"><span id="_Toc402343558" class="anchor"><span id="_Toc401311060" class="anchor"><span id="_Toc401323122" class="anchor"><span id="_Toc401568982" class="anchor"><span id="_Toc401578726" class="anchor"><span id="_Toc401588154" class="anchor"><span id="_Toc401589234" class="anchor"><span id="_Toc401598039" class="anchor"><span id="_Toc401599155" class="anchor"><span id="_Toc401600201" class="anchor"><span id="_Toc401601256" class="anchor"><span id="_Toc401602311" class="anchor"><span id="_Toc401602047" class="anchor"><span id="_Toc401604379" class="anchor"><span id="_Toc401605453" class="anchor"><span id="_Toc401758048" class="anchor"><span id="_Toc401837851" class="anchor"><span id="_Toc401839115" class="anchor"><span id="_Toc401853997" class="anchor"><span id="_Toc401855071" class="anchor"><span id="_Toc401934774" class="anchor"><span id="_Toc401935848" class="anchor"><span id="_Toc402188170" class="anchor"><span id="_Toc402343559" class="anchor"><span id="_Toc401311073" class="anchor"><span id="_Toc401323135" class="anchor"><span id="_Toc401568995" class="anchor"><span id="_Toc401578739" class="anchor"><span id="_Toc401588167" class="anchor"><span id="_Toc401589247" class="anchor"><span id="_Toc401598052" class="anchor"><span id="_Toc401599168" class="anchor"><span id="_Toc401600214" class="anchor"><span id="_Toc401601269" class="anchor"><span id="_Toc401602324" class="anchor"><span id="_Toc401602241" class="anchor"><span id="_Toc401604392" class="anchor"><span id="_Toc401605466" class="anchor"><span id="_Toc401758061" class="anchor"><span id="_Toc401837864" class="anchor"><span id="_Toc401839128" class="anchor"><span id="_Toc401840130" class="anchor"><span id="_Toc401839603" class="anchor"><span id="_Toc401840185" class="anchor"><span id="_Toc401839890" class="anchor"><span id="_Toc401854010" class="anchor"><span id="_Toc401855084" class="anchor"><span id="_Toc401934787" class="anchor"><span id="_Toc401935861" class="anchor"><span id="_Toc402188183" class="anchor"><span id="_Toc402343572" class="anchor"><span id="_Toc401311074" class="anchor"><span id="_Toc401323136" class="anchor"><span id="_Toc401568996" class="anchor"><span id="_Toc401578740" class="anchor"><span id="_Toc401588168" class="anchor"><span id="_Toc401589248" class="anchor"><span id="_Toc401598053" class="anchor"><span id="_Toc401599169" class="anchor"><span id="_Toc401600215" class="anchor"><span id="_Toc401601270" class="anchor"><span id="_Toc401602325" class="anchor"><span id="_Toc401602243" class="anchor"><span id="_Toc401604393" class="anchor"><span id="_Toc401605467" class="anchor"><span id="_Toc401758062" class="anchor"><span id="_Toc401837865" class="anchor"><span id="_Toc401839129" class="anchor"><span id="_Toc401854011" class="anchor"><span id="_Toc401855085" class="anchor"><span id="_Toc401934788" class="anchor"><span id="_Toc401935862" class="anchor"><span id="_Toc402188184" class="anchor"><span id="_Toc402343573" class="anchor"><span id="_Toc401311075" class="anchor"><span id="_Toc401323137" class="anchor"><span id="_Toc401568997" class="anchor"><span id="_Toc401578741" class="anchor"><span id="_Toc401588169" class="anchor"><span id="_Toc401589249" class="anchor"><span id="_Toc401598054" class="anchor"><span id="_Toc401599170" class="anchor"><span id="_Toc401600216" class="anchor"><span id="_Toc401601271" class="anchor"><span id="_Toc401602326" class="anchor"><span id="_Toc401602244" class="anchor"><span id="_Toc401604394" class="anchor"><span id="_Toc401605468" class="anchor"><span id="_Toc401758063" class="anchor"><span id="_Toc401837866" class="anchor"><span id="_Toc401839130" class="anchor"><span id="_Toc401854012" class="anchor"><span id="_Toc401855086" class="anchor"><span id="_Toc401934789" class="anchor"><span id="_Toc401935863" class="anchor"><span id="_Toc402188185" class="anchor"><span id="_Toc402343574" class="anchor"><span id="_Toc401311076" class="anchor"><span id="_Toc401323138" class="anchor"><span id="_Toc401568998" class="anchor"><span id="_Toc401578742" class="anchor"><span id="_Toc401588170" class="anchor"><span id="_Toc401589250" class="anchor"><span id="_Toc401598055" class="anchor"><span id="_Toc401599171" class="anchor"><span id="_Toc401600217" class="anchor"><span id="_Toc401601272" class="anchor"><span id="_Toc401602327" class="anchor"><span id="_Toc401602245" class="anchor"><span id="_Toc401604395" class="anchor"><span id="_Toc401605469" class="anchor"><span id="_Toc401758064" class="anchor"><span id="_Toc401837867" class="anchor"><span id="_Toc401839131" class="anchor"><span id="_Toc401840131" class="anchor"><span id="_Toc401839606" class="anchor"><span id="_Toc401840186" class="anchor"><span id="_Toc401839894" class="anchor"><span id="_Toc401854013" class="anchor"><span id="_Toc401855087" class="anchor"><span id="_Toc401934790" class="anchor"><span id="_Toc401935864" class="anchor"><span id="_Toc402188186" class="anchor"><span id="_Toc402343575" class="anchor"><span id="_Toc401311077" class="anchor"><span id="_Toc401323139" class="anchor"><span id="_Toc401568999" class="anchor"><span id="_Toc401578743" class="anchor"><span id="_Toc401588171" class="anchor"><span id="_Toc401589251" class="anchor"><span id="_Toc401598056" class="anchor"><span id="_Toc401599172" class="anchor"><span id="_Toc401600218" class="anchor"><span id="_Toc401601273" class="anchor"><span id="_Toc401602328" class="anchor"><span id="_Toc401602248" class="anchor"><span id="_Toc401604396" class="anchor"><span id="_Toc401605470" class="anchor"><span id="_Toc401758065" class="anchor"><span id="_Toc401837868" class="anchor"><span id="_Toc401839132" class="anchor"><span id="_Toc401854014" class="anchor"><span id="_Toc401855088" class="anchor"><span id="_Toc401934791" class="anchor"><span id="_Toc401935865" class="anchor"><span id="_Toc402188187" class="anchor"><span id="_Toc402343576" class="anchor"><span id="_Toc401311078" class="anchor"><span id="_Toc401323140" class="anchor"><span id="_Toc401569000" class="anchor"><span id="_Toc401578744" class="anchor"><span id="_Toc401588172" class="anchor"><span id="_Toc401589252" class="anchor"><span id="_Toc401598057" class="anchor"><span id="_Toc401599173" class="anchor"><span id="_Toc401600219" class="anchor"><span id="_Toc401601274" class="anchor"><span id="_Toc401602329" class="anchor"><span id="_Toc401603323" class="anchor"><span id="_Toc401604397" class="anchor"><span id="_Toc401605471" class="anchor"><span id="_Toc401758066" class="anchor"><span id="_Toc401837869" class="anchor"><span id="_Toc401839133" class="anchor"><span id="_Toc401840132" class="anchor"><span id="_Toc401839609" class="anchor"><span id="_Toc401840187" class="anchor"><span id="_Toc401839897" class="anchor"><span id="_Toc401854015" class="anchor"><span id="_Toc401855089" class="anchor"><span id="_Toc401934792" class="anchor"><span id="_Toc401935866" class="anchor"><span id="_Toc402188188" class="anchor"><span id="_Toc402343577" class="anchor"><span id="_Toc401311079" class="anchor"><span id="_Toc401323141" class="anchor"><span id="_Toc401569001" class="anchor"><span id="_Toc401578745" class="anchor"><span id="_Toc401588173" class="anchor"><span id="_Toc401589253" class="anchor"><span id="_Toc401598058" class="anchor"><span id="_Toc401599174" class="anchor"><span id="_Toc401600220" class="anchor"><span id="_Toc401601275" class="anchor"><span id="_Toc401602330" class="anchor"><span id="_Toc401603324" class="anchor"><span id="_Toc401604398" class="anchor"><span id="_Toc401605472" class="anchor"><span id="_Toc401758067" class="anchor"><span id="_Toc401837870" class="anchor"><span id="_Toc401839134" class="anchor"><span id="_Toc401854016" class="anchor"><span id="_Toc401855090" class="anchor"><span id="_Toc401934793" class="anchor"><span id="_Toc401935867" class="anchor"><span id="_Toc402188189" class="anchor"><span id="_Toc402343578" class="anchor"><span id="_Toc401311080" class="anchor"><span id="_Toc401323142" class="anchor"><span id="_Toc401569002" class="anchor"><span id="_Toc401578746" class="anchor"><span id="_Toc401588174" class="anchor"><span id="_Toc401589254" class="anchor"><span id="_Toc401598059" class="anchor"><span id="_Toc401599175" class="anchor"><span id="_Toc401600221" class="anchor"><span id="_Toc401601276" class="anchor"><span id="_Toc401602331" class="anchor"><span id="_Toc401603325" class="anchor"><span id="_Toc401604399" class="anchor"><span id="_Toc401605473" class="anchor"><span id="_Toc401758068" class="anchor"><span id="_Toc401837871" class="anchor"><span id="_Toc401839135" class="anchor"><span id="_Toc401854017" class="anchor"><span id="_Toc401855091" class="anchor"><span id="_Toc401934794" class="anchor"><span id="_Toc401935868" class="anchor"><span id="_Toc402188190" class="anchor"><span id="_Toc402343579" class="anchor"><span id="_Toc401311081" class="anchor"><span id="_Toc401323143" class="anchor"><span id="_Toc401569003" class="anchor"><span id="_Toc401578747" class="anchor"><span id="_Toc401588175" class="anchor"><span id="_Toc401589255" class="anchor"><span id="_Toc401598060" class="anchor"><span id="_Toc401599176" class="anchor"><span id="_Toc401600222" class="anchor"><span id="_Toc401601277" class="anchor"><span id="_Toc401602332" class="anchor"><span id="_Toc401603326" class="anchor"><span id="_Toc401604400" class="anchor"><span id="_Toc401605474" class="anchor"><span id="_Toc401758069" class="anchor"><span id="_Toc401837872" class="anchor"><span id="_Toc401839136" class="anchor"><span id="_Toc401854018" class="anchor"><span id="_Toc401855092" class="anchor"><span id="_Toc401934795" class="anchor"><span id="_Toc401935869" class="anchor"><span id="_Toc402188191" class="anchor"><span id="_Toc402343580" class="anchor"><span id="_Toc401311082" class="anchor"><span id="_Toc401323144" class="anchor"><span id="_Toc401569004" class="anchor"><span id="_Toc401578748" class="anchor"><span id="_Toc401588176" class="anchor"><span id="_Toc401589256" class="anchor"><span id="_Toc401598061" class="anchor"><span id="_Toc401599177" class="anchor"><span id="_Toc401600223" class="anchor"><span id="_Toc401601278" class="anchor"><span id="_Toc401602333" class="anchor"><span id="_Toc401603327" class="anchor"><span id="_Toc401604401" class="anchor"><span id="_Toc401605475" class="anchor"><span id="_Toc401758070" class="anchor"><span id="_Toc401837873" class="anchor"><span id="_Toc401839137" class="anchor"><span id="_Toc401854019" class="anchor"><span id="_Toc401855093" class="anchor"><span id="_Toc401934796" class="anchor"><span id="_Toc401935870" class="anchor"><span id="_Toc402188192" class="anchor"><span id="_Toc402343581" class="anchor"><span id="_Toc401311083" class="anchor"><span id="_Toc401323145" class="anchor"><span id="_Toc401569005" class="anchor"><span id="_Toc401578749" class="anchor"><span id="_Toc401588177" class="anchor"><span id="_Toc401589257" class="anchor"><span id="_Toc401598062" class="anchor"><span id="_Toc401599178" class="anchor"><span id="_Toc401600224" class="anchor"><span id="_Toc401601279" class="anchor"><span id="_Toc401602334" class="anchor"><span id="_Toc401603328" class="anchor"><span id="_Toc401604402" class="anchor"><span id="_Toc401605476" class="anchor"><span id="_Toc401758071" class="anchor"><span id="_Toc401837874" class="anchor"><span id="_Toc401839138" class="anchor"><span id="_Toc401854020" class="anchor"><span id="_Toc401855094" class="anchor"><span id="_Toc401934797" class="anchor"><span id="_Toc401935871" class="anchor"><span id="_Toc402188193" class="anchor"><span id="_Toc402343582" class="anchor"><span id="_Toc401840188" class="anchor"><span id="_Toc405814757" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Prerequisites
====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section describes the hardware and software environment for the
test suites. In a SharePoint server environment, the test suite
installation takes place on both the client and server side. The
following information will help test suite users to plan their
deployment.

1.  <span id="_Toc401152784" class="anchor"><span id="_Toc397328552"
    > class="anchor"><span id="_Toc401840189" class="anchor"><span
    > id="_Toc405814758"
    > class="anchor"></span></span></span></span>Hardware requirements

    1.  <span id="_Toc401840190" class="anchor"><span id="_Toc405814759"
        class="anchor"><span id="_Toc401152785" class="anchor"><span
        id="_Toc397328553"
        class="anchor"></span></span></span></span>System under test

The SUT is the server side of the test suite environment. SharePoint
server(s) and Active Directory have defined system requirements which
should be taken into account during deployment. The SharePoint Server
Protocol test suites do not have any additional SUT resource
requirements.

1.  <span id="_Toc401152786" class="anchor"><span id="_Toc397328554"
    class="anchor"><span id="_Toc401840191" class="anchor"><span
    id="_Toc405814760" class="anchor"></span></span></span></span>Test
    suite client

The test suite client is the client side of the test suite environment.
The following table shows the minimum resource requirements for the test
suite client.

Test suite client resource requirements

  Component   Test suite client minimum requirement
  ----------- ---------------------------------------
  RAM         2GB
  Hard Disk   3GB of free space
  Processor   &gt;= 1GHz

1.  <span id="_Toc401152787" class="anchor"><span id="_Toc397328555"
    > class="anchor"><span id="_Toc401840192" class="anchor"><span
    > id="_Toc405814761"
    > class="anchor"></span></span></span></span>Software requirements

    1.  <span id="_Toc401840193" class="anchor"><span id="_Toc405814762"
        class="anchor"><span id="_Toc401152788" class="anchor"><span
        id="_Toc397328556"
        class="anchor"></span></span></span></span>System under test

This section is only relevant when running the test suites against the
following versions of SharePoint Server. Some test suites (MS-COPYS)
support two SUTs depending on the protocol requirements:

-   Windows SharePoint Services 3.0 Service Pack 3 (SP3)

-   Microsoft SharePoint Foundation 2010 Service Pack 2 (SP2)

-   Microsoft SharePoint Foundation 2013 Service Pack (SP1)

-   Microsoft Office SharePoint Server 2007 Service Pack 3 (SP3)

-   Microsoft SharePoint Server 2010 Service Pack 2 (SP2)

-   Microsoft SharePoint Server 2013 Service Pack (SP1)

<span id="VirusFile" class="anchor"></span>For the MS-WDVMODUU test
suite, you have to install a virus scanner software in order to test the
X-Virus-Infected header. You will also require a virus file to perform a
security check behavior for the protocol that can be detected by the
virus scanner. When you download, install, or run the test suite, your
security software may intercept your action or even remove the file
directly. If the file is removed or quarantined by the security
software, some test cases of the test suite may fail. To ensure that the
test suites run successfully, you should suspend the security software
in your environment. Microsoft guarantees the content of the package is
clean and virus-free.

1.  Install Microsoft Forefront Protection 2010 for SharePoint in the
    following versions of SharePoint

-   Windows SharePoint Services 3.0 Service Pack 3 (SP3),

-   Microsoft SharePoint Foundation 2010 Service Pack 2 (SP2)

-   Microsoft Office SharePoint Server 2007 Service Pack 3 (SP3)

-   Microsoft SharePoint Server 2010 Service Pack 2 (SP2)

1.  Install any anti-virus software on the following versions of
    SharePoint:

-   Microsoft SharePoint Foundation 2013 Service Pack (SP1)

-   Microsoft SharePoint Server 2013 Service Pack (SP1)

**Note**   The anti-virus software should implement [Virus Scan Engine
API](http://go.microsoft.com/fwlink/?LinkId=518352). A number of ISVs
ship AV scanners (Symantec, Norton, etc.) which integrate with
SharePoint the same way Microsoft Forefront Protection 2010 for
SharePoint does.

The following table describes the necessary server roles required for a
test suite deployment with a Microsoft implementation.

Required SUT roles

  Role                                                                                                                       Description
  -------------------------------------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Active Directory Domain Controller (AD DC)                                                                                 Active Directory Domain Controller provides secure data for users and computers. An AD DC can coexist with a SharePoint server. A typical test configuration has an AD DC and SharePoint Server installed on separate machines.
  SharePoint Server \#1 (SUT1 must be a SharePoint application server if server installation type is Complete (farm mode))   The first SharePoint server in the topology.
  SharePoint Server \#2 (SUT2)                                                                                               Only the MS-COPYS test suite requires the second SharePoint server in the topology.

The following diagram is an example of what a typical SharePoint test
suite environment may look like. This example uses an IPv4, but IPv6 is
also supported within a test suite environment.

1.  <span id="_Toc401152789" class="anchor"><span id="_Toc397328557"
    class="anchor"><span id="_Toc401840194" class="anchor"><span
    id="_Toc405814763" class="anchor"></span></span></span></span>Test
    suite client

This section describes the prerequisite software for installing the
SharePoint Server Protocol test suites on the test suite client. The
following table outlines the software dependencies for the test suite
client.

Test suite client software dependencies

  ----------------------------------------------------------------------------
  Operating systems   Windows 7 x64 Service Pack 1 and above
                      
                      Windows 8 x64 and above
                      
                      Windows 2008 R2 x64 Service Pack 1 and above
  ------------------- --------------------------------------------------------
  Software            Microsoft Visual Studio 2013 Professional
                      
                      Microsoft Protocol Test Framework 1.0.2220.0 and above
  ----------------------------------------------------------------------------

<span id="_Toc401569013" class="anchor"><span id="_Toc401578757" class="anchor"><span id="_Toc401588185" class="anchor"><span id="_Toc401589265" class="anchor"><span id="_Toc401598070" class="anchor"><span id="_Toc401600232" class="anchor"><span id="_Toc401601287" class="anchor"><span id="_Toc401602342" class="anchor"><span id="_Toc401603336" class="anchor"><span id="_Toc401604410" class="anchor"><span id="_Toc401605484" class="anchor"><span id="_Toc401758079" class="anchor"><span id="_Toc401837882" class="anchor"><span id="_Toc401839146" class="anchor"><span id="_Toc401854028" class="anchor"><span id="_Toc401855102" class="anchor"><span id="_Toc401934805" class="anchor"><span id="_Toc401935879" class="anchor"><span id="_Toc402188201" class="anchor"><span id="_Toc402343590" class="anchor"><span id="_Toc397328558" class="anchor"><span id="_Toc401152790" class="anchor"><span id="_Toc401840195" class="anchor"><span id="_Toc405814764" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Deploying the test suites
=================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section describes the deployment of the SharePoint Server Protocol
test suites on the test suite client and the SUT. The SharePoint Server
Protocol test suites are packed in a .zip file which is available on
[**Microsoft Connect**](http://go.microsoft.com/fwlink/?LinkId=516921).
Once you download the test suites, you need to perform the following
steps in order to be able to successfully configure the test suites.

1.  Extract the **SharePoint Server Protocol Test Suites** folder to a
    directory of your choice on the test suite client.

2.  Copy the **SUT** and **Common** folders under **…\\SharePoint Server
    Protocol Test Suites\\Setup\\** to a directory of your choice on
    the SUT. The SUT configuration scripts are the only requirement for
    the SUT. The scripts facilitate the SUT configuration process and
    are contained within the
    **SharePointServerProtocolTestSuites.zip** file.

**Note**   If your computer blocks scripts downloaded from the Internet
for security reasons, you will need to follow these steps to unblock
PowerShell scripts.

  ----------------------------------------------------------------------------------------------------------------------------------------
  1.  Right-click xxx.ps1 and select **Properties**.   ![](media/image3.jpg){width="2.8331955380577427in" height="2.25in"}
                                                       
                                                       
  ---------------------------------------------------- -----------------------------------------------------------------------------------
  1.  Click **Unblock** and click **OK**.              ![](media/image4.png){width="2.1463560804899386in" height="2.9583333333333335in"}
                                                       
                                                       
  ----------------------------------------------------------------------------------------------------------------------------------------

<span id="_Toc401569023" class="anchor"><span id="_Toc401578767" class="anchor"><span id="_Toc401588195" class="anchor"><span id="_Toc401589275" class="anchor"><span id="_Toc401598080" class="anchor"><span id="_Toc401599187" class="anchor"><span id="_Toc401600242" class="anchor"><span id="_Toc401601297" class="anchor"><span id="_Toc401602352" class="anchor"><span id="_Toc401603346" class="anchor"><span id="_Toc401604420" class="anchor"><span id="_Toc401605494" class="anchor"><span id="_Toc401758089" class="anchor"><span id="_Toc401837892" class="anchor"><span id="_Toc401839156" class="anchor"><span id="_Toc401854038" class="anchor"><span id="_Toc401855112" class="anchor"><span id="_Toc401934815" class="anchor"><span id="_Toc401935889" class="anchor"><span id="_Toc402188211" class="anchor"><span id="_Toc402343600" class="anchor"><span id="_Toc401569024" class="anchor"><span id="_Toc401578768" class="anchor"><span id="_Toc401588196" class="anchor"><span id="_Toc401589276" class="anchor"><span id="_Toc401598081" class="anchor"><span id="_Toc401599188" class="anchor"><span id="_Toc401600243" class="anchor"><span id="_Toc401601298" class="anchor"><span id="_Toc401602353" class="anchor"><span id="_Toc401603347" class="anchor"><span id="_Toc401604421" class="anchor"><span id="_Toc401605495" class="anchor"><span id="_Toc401758090" class="anchor"><span id="_Toc401837893" class="anchor"><span id="_Toc401839157" class="anchor"><span id="_Toc401854039" class="anchor"><span id="_Toc401855113" class="anchor"><span id="_Toc401934816" class="anchor"><span id="_Toc401935890" class="anchor"><span id="_Toc402188212" class="anchor"><span id="_Toc402343601" class="anchor"><span id="_Toc401569025" class="anchor"><span id="_Toc401578769" class="anchor"><span id="_Toc401588197" class="anchor"><span id="_Toc401589277" class="anchor"><span id="_Toc401598082" class="anchor"><span id="_Toc401599189" class="anchor"><span id="_Toc401600244" class="anchor"><span id="_Toc401601299" class="anchor"><span id="_Toc401602354" class="anchor"><span id="_Toc401603348" class="anchor"><span id="_Toc401604422" class="anchor"><span id="_Toc401605496" class="anchor"><span id="_Toc401758091" class="anchor"><span id="_Toc401837894" class="anchor"><span id="_Toc401839158" class="anchor"><span id="_Toc401854040" class="anchor"><span id="_Toc401855114" class="anchor"><span id="_Toc401934817" class="anchor"><span id="_Toc401935891" class="anchor"><span id="_Toc402188213" class="anchor"><span id="_Toc402343602" class="anchor"><span id="_Toc401152791" class="anchor"><span id="_Toc401840196" class="anchor"><span id="_Toc405814765" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Test suite directories
====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

In this section you will find a list of the folder structures that are
contained within the **SharePointServerProtocolTestSuites.zip** file.

SharePointServerProtocolTestSuites.zip file contents

  -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Directory/file                                            Description
  --------------------------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  EULA.rtf                                                  The End-User License Agreement

  ReadMe.txt                                                A file that contains information about the deployment guide and prerequisite software

  SharePoint Server Protocol Test Suites                    

  - Docs                                                    A directory that contains documents of all protocol test suites

  - SharePointTestSuiteDeploymentGuide.docx                 A file relevant to the protocol test suite deployment guidance

  - MS-XXXX                                                 MS-XXXX Help documentation

  - \[MS-XXXX\].pdf                                         The technical specification for the protocol

  - MS-XXXX\_TestSuiteSpecification.docx                    Contains test suite-specific configuration details, architecture, and test case details.

  - MS-XXXX\_SUTControlAdapter.chm                          Contains information about the SUT control adapter class library such as declaration syntaxes and their description.

  - MS-XXXX\_RequirementSpecification.xlsx                  A spreadsheet that outlines all requirements associated with the technical specification.

  - Setup                                                   A directory that contains configuration scripts

  > - Test Suite Client                                     A directory that contains the configuration script to configure the test suite client.

  > - SharePointClientConfiguration.cmd                     A command file that runs the
                                                            
                                                            SharePointClientConfiguration.ps1 to configure the properties for the protocol test suites.

  > - SharePointClientConfiguration.ps1                     A configuration script that will be invoked by SharePointClientConfiguration.cmd

  - SUT                                                     A folder that contains the configuration script to configure the SUT.

  > - SharePointSUTConfiguration.cmd                        A command file that runs the
                                                            
                                                            SharePointSUTConfiguration.ps1 to create resources and configure settings on the first SUT.

  > - SharePointSUTConfiguration.ps1                        A configuration script that will be invoked by SharePointSUTConfiguration.cmd.

  > -SharePointSecondSUTConfiguration.cmd                   A command file that runs the SharePointSecondSUTConfiguration.ps1 to create resources and configure settings on the second SUT.

  > - SharePointSecondSUTConfiguration.ps1                  A configuration script that will be invoked by SharePointSecondSUTConfiguration.cmd.

  > - MSCOPYS\_SourceFile.txt                               A source file used to be copied from a source location to a destination location.

  > - MSDWSS\_TestData.txt                                  A test file used by the MS-DWSS test suite.

  > - MSSHDACCWS\_CoStatusTestData.txt                      A test file that will be uploaded to MSSHDACCWS\_DocumentLibrary. This file allows multiple users to edit it.

  > - MSSHDACCWS\_LockedTestData.txt                        A test file that will be uploaded to the MSSHDACCWS\_DocumentLibrary. An exclusive lock is applied to this file.

  > - MSSHDACCWS\_TestData.txt                              A test file that will be uploaded to MSSHDACCWS\_DocumentLibrary without any locks or Co-Authoring status.

  > - MSSITESS\_CustomPage.aspx                             A custom page used by the MS-SITESS test suite.

  > - MSWDVMODUU\_TestData1.txt                             The first text test file used by the MS-WDVMODUU test suite.

  > - MSWDVMODUU\_TestData2.txt                             The second text test file used by the MS-WDVMODUU test suite.

  > - MSWDVMODUU\_TestData3.txt                             The third text test file used by the MS-WDVMODUU test suite.

  > - MSWEBSS\_TestData.docx                                A test file used by the MS-WEBSS test suite.

  > - Common                                                A folder that contains common configuration scripts and resources.

  > -CommonConfiguration.ps1                                A library that contains common functions for configuring Microsoft products and the test suite client.

  > -SharePointCommonConfiguration.ps1                      A library that contains common functions for configuring the SUT.

  > -SharePointTestSuite.config                             The configuration file to store all configuration resources

  - Source                                                  A folder with Microsoft Visual Studio solution that contains the source code for the test suites.

  - Common                                                  A folder with Visual Studio projects that contains source code that are common to the test suites.

  > - SharePointCommonConfiguration. deployment.ptfconfig   The common configuration file.

  -SharePointServerProtocolTestSuites.sln                   A Visual Studio solution that contains projects of the protocol test suites source code.

  - MS-XXXX                                                 MS-XXXX test suite source code directory

  + Adapter                                                 Adapter test suite code

  + TestSuite                                               Test suite code

  > - MS-XXXX.sln                                           A Visual Studio solution that contains projects of the MS-XXXX test suite

  -Scripts                                                  SharePoint Server Protocol test suites can be run using Visual Studio or through batch scripts. The Scripts directory contains a collection of command files that allows users to run specific test cases in the test suite or the entire test suite.

  - RunAllSharePointTestCases.cmd                           A script that can be used to run all test cases in the whole package.

  -MS-XXXX                                                  A folder containing scripts that belong to the MS-XXXX test suite.

  - RunAllMSXXXXTestCases.cmd                               A script that can be used to run all test cases of MS-XXXX.

  - RunMSXXXX\_SYY\_TCZZ\_TestCaseName.cmd                  A script that can be used to run a single test case of MS-XXXX.
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Toc401311093" class="anchor"><span id="_Toc401323155"
class="anchor"><span id="_Toc401311094" class="anchor"><span
id="_Toc401323156" class="anchor"><span id="_Toc401311095"
class="anchor"><span id="_Toc401323157" class="anchor"><span
id="_Toc401311096" class="anchor"><span id="_Toc401323158"
class="anchor"><span id="_Toc401311109" class="anchor"><span
id="_Toc401323171" class="anchor"><span id="_Toc401311110"
class="anchor"><span id="_Toc401323172" class="anchor"><span
id="_Toc401311111" class="anchor"><span id="_Toc401323173"
class="anchor"><span id="_Toc401311112" class="anchor"><span
id="_Toc401323174" class="anchor"><span
id="_SharePoint_resource_requirements" class="anchor"><span
id="_Toc401311125" class="anchor"><span id="_Toc401323187"
class="anchor"><span id="_Toc401311126" class="anchor"><span
id="_Toc401323188" class="anchor"><span id="_Toc401311127"
class="anchor"><span id="_Toc401323189" class="anchor"><span
id="OLE_LINK9"
class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>

<span id="_Toc401569035" class="anchor"><span id="_Toc401578779" class="anchor"><span id="_Toc401588207" class="anchor"><span id="_Toc401589287" class="anchor"><span id="_Toc401598092" class="anchor"><span id="_Toc401599199" class="anchor"><span id="_Toc401600254" class="anchor"><span id="_Toc401601309" class="anchor"><span id="_Toc401602364" class="anchor"><span id="_Toc401603358" class="anchor"><span id="_Toc401604432" class="anchor"><span id="_Toc401605506" class="anchor"><span id="_Toc401758101" class="anchor"><span id="_Toc401837904" class="anchor"><span id="_Toc401839168" class="anchor"><span id="_Toc401854050" class="anchor"><span id="_Toc401855124" class="anchor"><span id="_Toc401934827" class="anchor"><span id="_Toc401935901" class="anchor"><span id="_Toc402188223" class="anchor"><span id="_Toc402343612" class="anchor"><span id="_Toc401311533" class="anchor"><span id="_Toc401323595" class="anchor"><span id="_Toc401569440" class="anchor"><span id="_Toc401579184" class="anchor"><span id="_Toc401588612" class="anchor"><span id="_Toc401589692" class="anchor"><span id="_Toc401598497" class="anchor"><span id="_Toc401599604" class="anchor"><span id="_Toc401600659" class="anchor"><span id="_Toc401601714" class="anchor"><span id="_Toc401602769" class="anchor"><span id="_Toc401603763" class="anchor"><span id="_Toc401604837" class="anchor"><span id="_Toc401605911" class="anchor"><span id="_Toc401758506" class="anchor"><span id="_Toc401838309" class="anchor"><span id="_Toc401839573" class="anchor"><span id="_Toc401840142" class="anchor"><span id="_Toc401839639" class="anchor"><span id="_Toc401840197" class="anchor"><span id="_Toc401839911" class="anchor"><span id="_Toc401854455" class="anchor"><span id="_Toc401855529" class="anchor"><span id="_Toc401935232" class="anchor"><span id="_Toc401936306" class="anchor"><span id="_Toc402188628" class="anchor"><span id="_Toc402344017" class="anchor"><span id="_Toc401311534" class="anchor"><span id="_Toc401323596" class="anchor"><span id="_Toc401569441" class="anchor"><span id="_Toc401579185" class="anchor"><span id="_Toc401588613" class="anchor"><span id="_Toc401589693" class="anchor"><span id="_Toc401598498" class="anchor"><span id="_Toc401599605" class="anchor"><span id="_Toc401600660" class="anchor"><span id="_Toc401601715" class="anchor"><span id="_Toc401602770" class="anchor"><span id="_Toc401603764" class="anchor"><span id="_Toc401604838" class="anchor"><span id="_Toc401605912" class="anchor"><span id="_Toc401758507" class="anchor"><span id="_Toc401838310" class="anchor"><span id="_Toc401839574" class="anchor"><span id="_Toc401854456" class="anchor"><span id="_Toc401855530" class="anchor"><span id="_Toc401935233" class="anchor"><span id="_Toc401936307" class="anchor"><span id="_Toc402188629" class="anchor"><span id="_Toc402344018" class="anchor"><span id="_Toc401311535" class="anchor"><span id="_Toc401323597" class="anchor"><span id="_Toc401569442" class="anchor"><span id="_Toc401579186" class="anchor"><span id="_Toc401588614" class="anchor"><span id="_Toc401589694" class="anchor"><span id="_Toc401598499" class="anchor"><span id="_Toc401599606" class="anchor"><span id="_Toc401600661" class="anchor"><span id="_Toc401601716" class="anchor"><span id="_Toc401602771" class="anchor"><span id="_Toc401603765" class="anchor"><span id="_Toc401604839" class="anchor"><span id="_Toc401605913" class="anchor"><span id="_Toc401758508" class="anchor"><span id="_Toc401838311" class="anchor"><span id="_Toc401839575" class="anchor"><span id="_Toc401854457" class="anchor"><span id="_Toc401855531" class="anchor"><span id="_Toc401935234" class="anchor"><span id="_Toc401936308" class="anchor"><span id="_Toc402188630" class="anchor"><span id="_Toc402344019" class="anchor"><span id="_Toc401311536" class="anchor"><span id="_Toc401323598" class="anchor"><span id="_Toc401569443" class="anchor"><span id="_Toc401579187" class="anchor"><span id="_Toc401588615" class="anchor"><span id="_Toc401589695" class="anchor"><span id="_Toc401598500" class="anchor"><span id="_Toc401599607" class="anchor"><span id="_Toc401600662" class="anchor"><span id="_Toc401601717" class="anchor"><span id="_Toc401602772" class="anchor"><span id="_Toc401603766" class="anchor"><span id="_Toc401604840" class="anchor"><span id="_Toc401605914" class="anchor"><span id="_Toc401758509" class="anchor"><span id="_Toc401838312" class="anchor"><span id="_Toc401839576" class="anchor"><span id="_Toc401840143" class="anchor"><span id="_Toc401839642" class="anchor"><span id="_Toc401840198" class="anchor"><span id="_Toc401839918" class="anchor"><span id="_Toc401854458" class="anchor"><span id="_Toc401855532" class="anchor"><span id="_Toc401935235" class="anchor"><span id="_Toc401936309" class="anchor"><span id="_Toc402188631" class="anchor"><span id="_Toc402344020" class="anchor"><span id="_Toc401311537" class="anchor"><span id="_Toc401323599" class="anchor"><span id="_Toc401569444" class="anchor"><span id="_Toc401579188" class="anchor"><span id="_Toc401588616" class="anchor"><span id="_Toc401589696" class="anchor"><span id="_Toc401598501" class="anchor"><span id="_Toc401599608" class="anchor"><span id="_Toc401600663" class="anchor"><span id="_Toc401601718" class="anchor"><span id="_Toc401602773" class="anchor"><span id="_Toc401603767" class="anchor"><span id="_Toc401604841" class="anchor"><span id="_Toc401605915" class="anchor"><span id="_Toc401758510" class="anchor"><span id="_Toc401838313" class="anchor"><span id="_Toc401839577" class="anchor"><span id="_Toc401854459" class="anchor"><span id="_Toc401855533" class="anchor"><span id="_Toc401935236" class="anchor"><span id="_Toc401936310" class="anchor"><span id="_Toc402188632" class="anchor"><span id="_Toc402344021" class="anchor"><span id="_Installation_instructions_2" class="anchor"><span id="_Toc401311538" class="anchor"><span id="_Toc401323600" class="anchor"><span id="_Toc401569445" class="anchor"><span id="_Toc401579189" class="anchor"><span id="_Toc401588617" class="anchor"><span id="_Toc401589697" class="anchor"><span id="_Toc401598502" class="anchor"><span id="_Toc401599609" class="anchor"><span id="_Toc401600664" class="anchor"><span id="_Toc401601719" class="anchor"><span id="_Toc401602774" class="anchor"><span id="_Toc401603768" class="anchor"><span id="_Toc401604842" class="anchor"><span id="_Toc401605916" class="anchor"><span id="_Toc401758511" class="anchor"><span id="_Toc401838314" class="anchor"><span id="_Toc401839578" class="anchor"><span id="_Toc401840144" class="anchor"><span id="_Toc401839645" class="anchor"><span id="_Toc401840199" class="anchor"><span id="_Toc401839924" class="anchor"><span id="_Toc401854460" class="anchor"><span id="_Toc401855534" class="anchor"><span id="_Toc401935237" class="anchor"><span id="_Toc401936311" class="anchor"><span id="_Toc402188633" class="anchor"><span id="_Toc402344022" class="anchor"><span id="_Toc401311539" class="anchor"><span id="_Toc401323601" class="anchor"><span id="_Toc401569446" class="anchor"><span id="_Toc401579190" class="anchor"><span id="_Toc401588618" class="anchor"><span id="_Toc401589698" class="anchor"><span id="_Toc401598503" class="anchor"><span id="_Toc401599610" class="anchor"><span id="_Toc401600665" class="anchor"><span id="_Toc401601720" class="anchor"><span id="_Toc401602775" class="anchor"><span id="_Toc401603769" class="anchor"><span id="_Toc401604843" class="anchor"><span id="_Toc401605917" class="anchor"><span id="_Toc401758512" class="anchor"><span id="_Toc401838315" class="anchor"><span id="_Toc401839579" class="anchor"><span id="_Toc401854461" class="anchor"><span id="_Toc401855535" class="anchor"><span id="_Toc401935238" class="anchor"><span id="_Toc401936312" class="anchor"><span id="_Toc402188634" class="anchor"><span id="_Toc402344023" class="anchor"><span id="_Toc401311540" class="anchor"><span id="_Toc401323602" class="anchor"><span id="_Toc401569447" class="anchor"><span id="_Toc401579191" class="anchor"><span id="_Toc401588619" class="anchor"><span id="_Toc401589699" class="anchor"><span id="_Toc401598504" class="anchor"><span id="_Toc401599611" class="anchor"><span id="_Toc401600666" class="anchor"><span id="_Toc401601721" class="anchor"><span id="_Toc401602776" class="anchor"><span id="_Toc401603770" class="anchor"><span id="_Toc401604844" class="anchor"><span id="_Toc401605918" class="anchor"><span id="_Toc401758513" class="anchor"><span id="_Toc401838316" class="anchor"><span id="_Toc401839580" class="anchor"><span id="_Toc401854462" class="anchor"><span id="_Toc401855536" class="anchor"><span id="_Toc401935239" class="anchor"><span id="_Toc401936313" class="anchor"><span id="_Toc402188635" class="anchor"><span id="_Toc402344024" class="anchor"><span id="_Toc401311541" class="anchor"><span id="_Toc401323603" class="anchor"><span id="_Toc401569448" class="anchor"><span id="_Toc401579192" class="anchor"><span id="_Toc401588620" class="anchor"><span id="_Toc401589700" class="anchor"><span id="_Toc401598505" class="anchor"><span id="_Toc401599612" class="anchor"><span id="_Toc401600667" class="anchor"><span id="_Toc401601722" class="anchor"><span id="_Toc401602777" class="anchor"><span id="_Toc401603771" class="anchor"><span id="_Toc401604845" class="anchor"><span id="_Toc401605919" class="anchor"><span id="_Toc401758514" class="anchor"><span id="_Toc401838317" class="anchor"><span id="_Toc401839581" class="anchor"><span id="_Toc401854463" class="anchor"><span id="_Toc401855537" class="anchor"><span id="_Toc401935240" class="anchor"><span id="_Toc401936314" class="anchor"><span id="_Toc402188636" class="anchor"><span id="_Toc402344025" class="anchor"><span id="_Toc401311542" class="anchor"><span id="_Toc401323604" class="anchor"><span id="_Toc401569449" class="anchor"><span id="_Toc401579193" class="anchor"><span id="_Toc401588621" class="anchor"><span id="_Toc401589701" class="anchor"><span id="_Toc401598506" class="anchor"><span id="_Toc401599613" class="anchor"><span id="_Toc401600668" class="anchor"><span id="_Toc401601723" class="anchor"><span id="_Toc401602778" class="anchor"><span id="_Toc401603772" class="anchor"><span id="_Toc401604846" class="anchor"><span id="_Toc401605920" class="anchor"><span id="_Toc401758515" class="anchor"><span id="_Toc401838318" class="anchor"><span id="_Toc401839582" class="anchor"><span id="_Toc401854464" class="anchor"><span id="_Toc401855538" class="anchor"><span id="_Toc401935241" class="anchor"><span id="_Toc401936315" class="anchor"><span id="_Toc402188637" class="anchor"><span id="_Toc402344026" class="anchor"><span id="_Toc401311543" class="anchor"><span id="_Toc401323605" class="anchor"><span id="_Toc401569450" class="anchor"><span id="_Toc401579194" class="anchor"><span id="_Toc401588622" class="anchor"><span id="_Toc401589702" class="anchor"><span id="_Toc401598507" class="anchor"><span id="_Toc401599614" class="anchor"><span id="_Toc401600669" class="anchor"><span id="_Toc401601724" class="anchor"><span id="_Toc401602779" class="anchor"><span id="_Toc401603773" class="anchor"><span id="_Toc401604847" class="anchor"><span id="_Toc401605921" class="anchor"><span id="_Toc401758516" class="anchor"><span id="_Toc401838319" class="anchor"><span id="_Toc401839583" class="anchor"><span id="_Toc401854465" class="anchor"><span id="_Toc401855539" class="anchor"><span id="_Toc401935242" class="anchor"><span id="_Toc401936316" class="anchor"><span id="_Toc402188638" class="anchor"><span id="_Toc402344027" class="anchor"><span id="_Toc401311544" class="anchor"><span id="_Toc401323606" class="anchor"><span id="_Toc401569451" class="anchor"><span id="_Toc401579195" class="anchor"><span id="_Toc401588623" class="anchor"><span id="_Toc401589703" class="anchor"><span id="_Toc401598508" class="anchor"><span id="_Toc401599615" class="anchor"><span id="_Toc401600670" class="anchor"><span id="_Toc401601725" class="anchor"><span id="_Toc401602780" class="anchor"><span id="_Toc401603774" class="anchor"><span id="_Toc401604848" class="anchor"><span id="_Toc401605922" class="anchor"><span id="_Toc401758517" class="anchor"><span id="_Toc401838320" class="anchor"><span id="_Toc401839584" class="anchor"><span id="_Toc401854466" class="anchor"><span id="_Toc401855540" class="anchor"><span id="_Toc401935243" class="anchor"><span id="_Toc401936317" class="anchor"><span id="_Toc402188639" class="anchor"><span id="_Toc402344028" class="anchor"><span id="_Toc401311545" class="anchor"><span id="_Toc401323607" class="anchor"><span id="_Toc401569452" class="anchor"><span id="_Toc401579196" class="anchor"><span id="_Toc401588624" class="anchor"><span id="_Toc401589704" class="anchor"><span id="_Toc401598509" class="anchor"><span id="_Toc401599616" class="anchor"><span id="_Toc401600671" class="anchor"><span id="_Toc401601726" class="anchor"><span id="_Toc401602781" class="anchor"><span id="_Toc401603775" class="anchor"><span id="_Toc401604849" class="anchor"><span id="_Toc401605923" class="anchor"><span id="_Toc401758518" class="anchor"><span id="_Toc401838321" class="anchor"><span id="_Toc401839585" class="anchor"><span id="_Toc401854467" class="anchor"><span id="_Toc401855541" class="anchor"><span id="_Toc401935244" class="anchor"><span id="_Toc401936318" class="anchor"><span id="_Toc402188640" class="anchor"><span id="_Toc402344029" class="anchor"><span id="_Toc401311554" class="anchor"><span id="_Toc401323616" class="anchor"><span id="_Toc401569461" class="anchor"><span id="_Toc401579205" class="anchor"><span id="_Toc401588633" class="anchor"><span id="_Toc401589713" class="anchor"><span id="_Toc401598518" class="anchor"><span id="_Toc401599625" class="anchor"><span id="_Toc401600680" class="anchor"><span id="_Toc401601735" class="anchor"><span id="_Toc401602790" class="anchor"><span id="_Toc401603784" class="anchor"><span id="_Toc401604858" class="anchor"><span id="_Toc401605932" class="anchor"><span id="_Toc401758527" class="anchor"><span id="_Toc401838330" class="anchor"><span id="_Toc401839594" class="anchor"><span id="_Toc401854476" class="anchor"><span id="_Toc401855550" class="anchor"><span id="_Toc401935253" class="anchor"><span id="_Toc401936327" class="anchor"><span id="_Toc402188649" class="anchor"><span id="_Toc402344038" class="anchor"><span id="_Test_suite_directories" class="anchor"><span id="_Toc401311555" class="anchor"><span id="_Toc401323617" class="anchor"><span id="_Toc401569462" class="anchor"><span id="_Toc401579206" class="anchor"><span id="_Toc401588634" class="anchor"><span id="_Toc401589714" class="anchor"><span id="_Toc401598519" class="anchor"><span id="_Toc401599626" class="anchor"><span id="_Toc401600681" class="anchor"><span id="_Toc401601736" class="anchor"><span id="_Toc401602791" class="anchor"><span id="_Toc401603785" class="anchor"><span id="_Toc401604859" class="anchor"><span id="_Toc401605933" class="anchor"><span id="_Toc401758528" class="anchor"><span id="_Toc401838331" class="anchor"><span id="_Toc401839595" class="anchor"><span id="_Toc401840145" class="anchor"><span id="_Toc401839648" class="anchor"><span id="_Toc401840200" class="anchor"><span id="_Toc401839930" class="anchor"><span id="_Toc401854477" class="anchor"><span id="_Toc401855551" class="anchor"><span id="_Toc401935254" class="anchor"><span id="_Toc401936328" class="anchor"><span id="_Toc402188650" class="anchor"><span id="_Toc402344039" class="anchor"><span id="_Toc401311556" class="anchor"><span id="_Toc401323618" class="anchor"><span id="_Toc401569463" class="anchor"><span id="_Toc401579207" class="anchor"><span id="_Toc401588635" class="anchor"><span id="_Toc401589715" class="anchor"><span id="_Toc401598520" class="anchor"><span id="_Toc401599627" class="anchor"><span id="_Toc401600682" class="anchor"><span id="_Toc401601737" class="anchor"><span id="_Toc401602792" class="anchor"><span id="_Toc401603786" class="anchor"><span id="_Toc401604860" class="anchor"><span id="_Toc401605934" class="anchor"><span id="_Toc401758529" class="anchor"><span id="_Toc401838332" class="anchor"><span id="_Toc401839596" class="anchor"><span id="_Toc401854478" class="anchor"><span id="_Toc401855552" class="anchor"><span id="_Toc401935255" class="anchor"><span id="_Toc401936329" class="anchor"><span id="_Toc402188651" class="anchor"><span id="_Toc402344040" class="anchor"><span id="_Toc401311557" class="anchor"><span id="_Toc401323619" class="anchor"><span id="_Toc401569464" class="anchor"><span id="_Toc401579208" class="anchor"><span id="_Toc401588636" class="anchor"><span id="_Toc401589716" class="anchor"><span id="_Toc401598521" class="anchor"><span id="_Toc401599628" class="anchor"><span id="_Toc401600683" class="anchor"><span id="_Toc401601738" class="anchor"><span id="_Toc401602793" class="anchor"><span id="_Toc401603787" class="anchor"><span id="_Toc401604861" class="anchor"><span id="_Toc401605935" class="anchor"><span id="_Toc401758530" class="anchor"><span id="_Toc401838333" class="anchor"><span id="_Toc401839597" class="anchor"><span id="_Toc401854479" class="anchor"><span id="_Toc401855553" class="anchor"><span id="_Toc401935256" class="anchor"><span id="_Toc401936330" class="anchor"><span id="_Toc402188652" class="anchor"><span id="_Toc402344041" class="anchor"><span id="_Test_suite_client" class="anchor"><span id="_Toc401311815" class="anchor"><span id="_Toc401323877" class="anchor"><span id="_Toc401569722" class="anchor"><span id="_Toc401579466" class="anchor"><span id="_Toc401588894" class="anchor"><span id="_Toc401589974" class="anchor"><span id="_Toc401598779" class="anchor"><span id="_Toc401599886" class="anchor"><span id="_Toc401600941" class="anchor"><span id="_Toc401601996" class="anchor"><span id="_Toc401603051" class="anchor"><span id="_Toc401604045" class="anchor"><span id="_Toc401605119" class="anchor"><span id="_Toc401606193" class="anchor"><span id="_Toc401758788" class="anchor"><span id="_Toc401838591" class="anchor"><span id="_Toc401839855" class="anchor"><span id="_Toc401840146" class="anchor"><span id="_Toc401839651" class="anchor"><span id="_Toc401840201" class="anchor"><span id="_Toc401839935" class="anchor"><span id="_Toc401854737" class="anchor"><span id="_Toc401855811" class="anchor"><span id="_Toc401935514" class="anchor"><span id="_Toc401936588" class="anchor"><span id="_Toc402188910" class="anchor"><span id="_Toc402344299" class="anchor"><span id="_Toc401311816" class="anchor"><span id="_Toc401323878" class="anchor"><span id="_Toc401569723" class="anchor"><span id="_Toc401579467" class="anchor"><span id="_Toc401588895" class="anchor"><span id="_Toc401589975" class="anchor"><span id="_Toc401598780" class="anchor"><span id="_Toc401599887" class="anchor"><span id="_Toc401600942" class="anchor"><span id="_Toc401601997" class="anchor"><span id="_Toc401603052" class="anchor"><span id="_Toc401604046" class="anchor"><span id="_Toc401605120" class="anchor"><span id="_Toc401606194" class="anchor"><span id="_Toc401758789" class="anchor"><span id="_Toc401838592" class="anchor"><span id="_Toc401839856" class="anchor"><span id="_Toc401854738" class="anchor"><span id="_Toc401855812" class="anchor"><span id="_Toc401935515" class="anchor"><span id="_Toc401936589" class="anchor"><span id="_Toc402188911" class="anchor"><span id="_Toc402344300" class="anchor"><span id="_Pre-requisites/Dependencies" class="anchor"><span id="_Toc401311817" class="anchor"><span id="_Toc401323879" class="anchor"><span id="_Toc401569724" class="anchor"><span id="_Toc401579468" class="anchor"><span id="_Toc401588896" class="anchor"><span id="_Toc401589976" class="anchor"><span id="_Toc401598781" class="anchor"><span id="_Toc401599888" class="anchor"><span id="_Toc401600943" class="anchor"><span id="_Toc401601998" class="anchor"><span id="_Toc401603053" class="anchor"><span id="_Toc401604047" class="anchor"><span id="_Toc401605121" class="anchor"><span id="_Toc401606195" class="anchor"><span id="_Toc401758790" class="anchor"><span id="_Toc401838593" class="anchor"><span id="_Toc401839857" class="anchor"><span id="_Toc401854739" class="anchor"><span id="_Toc401855813" class="anchor"><span id="_Toc401935516" class="anchor"><span id="_Toc401936590" class="anchor"><span id="_Toc402188912" class="anchor"><span id="_Toc402344301" class="anchor"><span id="_Toc401311818" class="anchor"><span id="_Toc401323880" class="anchor"><span id="_Toc401569725" class="anchor"><span id="_Toc401579469" class="anchor"><span id="_Toc401588897" class="anchor"><span id="_Toc401589977" class="anchor"><span id="_Toc401598782" class="anchor"><span id="_Toc401599889" class="anchor"><span id="_Toc401600944" class="anchor"><span id="_Toc401601999" class="anchor"><span id="_Toc401603054" class="anchor"><span id="_Toc401604048" class="anchor"><span id="_Toc401605122" class="anchor"><span id="_Toc401606196" class="anchor"><span id="_Toc401758791" class="anchor"><span id="_Toc401838594" class="anchor"><span id="_Toc401839858" class="anchor"><span id="_Toc401854740" class="anchor"><span id="_Toc401855814" class="anchor"><span id="_Toc401935517" class="anchor"><span id="_Toc401936591" class="anchor"><span id="_Toc402188913" class="anchor"><span id="_Toc402344302" class="anchor"><span id="_Installation_Instructions_1" class="anchor"><span id="_System(s)_under_test" class="anchor"><span id="_Toc401311827" class="anchor"><span id="_Toc401323889" class="anchor"><span id="_Toc401569734" class="anchor"><span id="_Toc401579478" class="anchor"><span id="_Toc401588906" class="anchor"><span id="_Toc401589986" class="anchor"><span id="_Toc401598791" class="anchor"><span id="_Toc401599898" class="anchor"><span id="_Toc401600953" class="anchor"><span id="_Toc401602008" class="anchor"><span id="_Toc401603063" class="anchor"><span id="_Toc401604057" class="anchor"><span id="_Toc401605131" class="anchor"><span id="_Toc401606205" class="anchor"><span id="_Toc401758800" class="anchor"><span id="_Toc401838603" class="anchor"><span id="_Toc401839867" class="anchor"><span id="_Toc401840147" class="anchor"><span id="_Toc401839654" class="anchor"><span id="_Toc401840202" class="anchor"><span id="_Toc401839940" class="anchor"><span id="_Toc401854749" class="anchor"><span id="_Toc401855823" class="anchor"><span id="_Toc401935526" class="anchor"><span id="_Toc401936600" class="anchor"><span id="_Toc402188922" class="anchor"><span id="_Toc402344311" class="anchor"><span id="_Toc401311828" class="anchor"><span id="_Toc401323890" class="anchor"><span id="_Toc401569735" class="anchor"><span id="_Toc401579479" class="anchor"><span id="_Toc401588907" class="anchor"><span id="_Toc401589987" class="anchor"><span id="_Toc401598792" class="anchor"><span id="_Toc401599899" class="anchor"><span id="_Toc401600954" class="anchor"><span id="_Toc401602009" class="anchor"><span id="_Toc401603064" class="anchor"><span id="_Toc401604058" class="anchor"><span id="_Toc401605132" class="anchor"><span id="_Toc401606206" class="anchor"><span id="_Toc401758801" class="anchor"><span id="_Toc401838604" class="anchor"><span id="_Toc401839868" class="anchor"><span id="_Toc401854750" class="anchor"><span id="_Toc401855824" class="anchor"><span id="_Toc401935527" class="anchor"><span id="_Toc401936601" class="anchor"><span id="_Toc402188923" class="anchor"><span id="_Toc402344312" class="anchor"><span id="_Toc401311829" class="anchor"><span id="_Toc401323891" class="anchor"><span id="_Toc401569736" class="anchor"><span id="_Toc401579480" class="anchor"><span id="_Toc401588908" class="anchor"><span id="_Toc401589988" class="anchor"><span id="_Toc401598793" class="anchor"><span id="_Toc401599900" class="anchor"><span id="_Toc401600955" class="anchor"><span id="_Toc401602010" class="anchor"><span id="_Toc401603065" class="anchor"><span id="_Toc401604059" class="anchor"><span id="_Toc401605133" class="anchor"><span id="_Toc401606207" class="anchor"><span id="_Toc401758802" class="anchor"><span id="_Toc401838605" class="anchor"><span id="_Toc401839869" class="anchor"><span id="_Toc401854751" class="anchor"><span id="_Toc401855825" class="anchor"><span id="_Toc401935528" class="anchor"><span id="_Toc401936602" class="anchor"><span id="_Toc402188924" class="anchor"><span id="_Toc402344313" class="anchor"><span id="_Toc401311830" class="anchor"><span id="_Toc401323892" class="anchor"><span id="_Toc401569737" class="anchor"><span id="_Toc401579481" class="anchor"><span id="_Toc401588909" class="anchor"><span id="_Toc401589989" class="anchor"><span id="_Toc401598794" class="anchor"><span id="_Toc401599901" class="anchor"><span id="_Toc401600956" class="anchor"><span id="_Toc401602011" class="anchor"><span id="_Toc401603066" class="anchor"><span id="_Toc401604060" class="anchor"><span id="_Toc401605134" class="anchor"><span id="_Toc401606208" class="anchor"><span id="_Toc401758803" class="anchor"><span id="_Toc401838606" class="anchor"><span id="_Toc401839870" class="anchor"><span id="_Toc401854752" class="anchor"><span id="_Toc401855826" class="anchor"><span id="_Toc401935529" class="anchor"><span id="_Toc401936603" class="anchor"><span id="_Toc402188925" class="anchor"><span id="_Toc402344314" class="anchor"><span id="_Toc401311831" class="anchor"><span id="_Toc401323893" class="anchor"><span id="_Toc401569738" class="anchor"><span id="_Toc401579482" class="anchor"><span id="_Toc401588910" class="anchor"><span id="_Toc401589990" class="anchor"><span id="_Toc401598795" class="anchor"><span id="_Toc401599902" class="anchor"><span id="_Toc401600957" class="anchor"><span id="_Toc401602012" class="anchor"><span id="_Toc401603067" class="anchor"><span id="_Toc401604061" class="anchor"><span id="_Toc401605135" class="anchor"><span id="_Toc401606209" class="anchor"><span id="_Toc401758804" class="anchor"><span id="_Toc401838607" class="anchor"><span id="_Toc401839871" class="anchor"><span id="_Toc401854753" class="anchor"><span id="_Toc401855827" class="anchor"><span id="_Toc401935530" class="anchor"><span id="_Toc401936604" class="anchor"><span id="_Toc402188926" class="anchor"><span id="_Toc402344315" class="anchor"><span id="_Toc401311832" class="anchor"><span id="_Toc401323894" class="anchor"><span id="_Toc401569739" class="anchor"><span id="_Toc401579483" class="anchor"><span id="_Toc401588911" class="anchor"><span id="_Toc401589991" class="anchor"><span id="_Toc401598796" class="anchor"><span id="_Toc401599903" class="anchor"><span id="_Toc401600958" class="anchor"><span id="_Toc401602013" class="anchor"><span id="_Toc401603068" class="anchor"><span id="_Toc401604062" class="anchor"><span id="_Toc401605136" class="anchor"><span id="_Toc401606210" class="anchor"><span id="_Toc401758805" class="anchor"><span id="_Toc401838608" class="anchor"><span id="_Toc401839872" class="anchor"><span id="_Toc401854754" class="anchor"><span id="_Toc401855828" class="anchor"><span id="_Toc401935531" class="anchor"><span id="_Toc401936605" class="anchor"><span id="_Toc402188927" class="anchor"><span id="_Toc402344316" class="anchor"><span id="_Toc401311833" class="anchor"><span id="_Toc401323895" class="anchor"><span id="_Toc401569740" class="anchor"><span id="_Toc401579484" class="anchor"><span id="_Toc401588912" class="anchor"><span id="_Toc401589992" class="anchor"><span id="_Toc401598797" class="anchor"><span id="_Toc401599904" class="anchor"><span id="_Toc401600959" class="anchor"><span id="_Toc401602014" class="anchor"><span id="_Toc401603069" class="anchor"><span id="_Toc401604063" class="anchor"><span id="_Toc401605137" class="anchor"><span id="_Toc401606211" class="anchor"><span id="_Toc401758806" class="anchor"><span id="_Toc401838609" class="anchor"><span id="_Toc401839873" class="anchor"><span id="_Toc401854755" class="anchor"><span id="_Toc401855829" class="anchor"><span id="_Toc401935532" class="anchor"><span id="_Toc401936606" class="anchor"><span id="_Toc402188928" class="anchor"><span id="_Toc402344317" class="anchor"><span id="_Toc401311834" class="anchor"><span id="_Toc401323896" class="anchor"><span id="_Toc401569741" class="anchor"><span id="_Toc401579485" class="anchor"><span id="_Toc401588913" class="anchor"><span id="_Toc401589993" class="anchor"><span id="_Toc401598798" class="anchor"><span id="_Toc401599905" class="anchor"><span id="_Toc401600960" class="anchor"><span id="_Toc401602015" class="anchor"><span id="_Toc401603070" class="anchor"><span id="_Toc401604064" class="anchor"><span id="_Toc401605138" class="anchor"><span id="_Toc401606212" class="anchor"><span id="_Toc401758807" class="anchor"><span id="_Toc401838610" class="anchor"><span id="_Toc401839874" class="anchor"><span id="_Toc401854756" class="anchor"><span id="_Toc401855830" class="anchor"><span id="_Toc401935533" class="anchor"><span id="_Toc401936607" class="anchor"><span id="_Toc402188929" class="anchor"><span id="_Toc402344318" class="anchor"><span id="_Toc401311835" class="anchor"><span id="_Toc401323897" class="anchor"><span id="_Toc401569742" class="anchor"><span id="_Toc401579486" class="anchor"><span id="_Toc401588914" class="anchor"><span id="_Toc401589994" class="anchor"><span id="_Toc401598799" class="anchor"><span id="_Toc401599906" class="anchor"><span id="_Toc401600961" class="anchor"><span id="_Toc401602016" class="anchor"><span id="_Toc401603071" class="anchor"><span id="_Toc401604065" class="anchor"><span id="_Toc401605139" class="anchor"><span id="_Toc401606213" class="anchor"><span id="_Toc401758808" class="anchor"><span id="_Toc401838611" class="anchor"><span id="_Toc401839875" class="anchor"><span id="_Toc401854757" class="anchor"><span id="_Toc401855831" class="anchor"><span id="_Toc401935534" class="anchor"><span id="_Toc401936608" class="anchor"><span id="_Toc402188930" class="anchor"><span id="_Toc402344319" class="anchor"><span id="_Toc401311836" class="anchor"><span id="_Toc401323898" class="anchor"><span id="_Toc401569743" class="anchor"><span id="_Toc401579487" class="anchor"><span id="_Toc401588915" class="anchor"><span id="_Toc401589995" class="anchor"><span id="_Toc401598800" class="anchor"><span id="_Toc401599907" class="anchor"><span id="_Toc401600962" class="anchor"><span id="_Toc401602017" class="anchor"><span id="_Toc401603072" class="anchor"><span id="_Toc401604066" class="anchor"><span id="_Toc401605140" class="anchor"><span id="_Toc401606214" class="anchor"><span id="_Toc401758809" class="anchor"><span id="_Toc401838612" class="anchor"><span id="_Toc401839876" class="anchor"><span id="_Toc401854758" class="anchor"><span id="_Toc401855832" class="anchor"><span id="_Toc401935535" class="anchor"><span id="_Toc401936609" class="anchor"><span id="_Toc402188931" class="anchor"><span id="_Toc402344320" class="anchor"><span id="_Toc401311837" class="anchor"><span id="_Toc401323899" class="anchor"><span id="_Toc401569744" class="anchor"><span id="_Toc401579488" class="anchor"><span id="_Toc401588916" class="anchor"><span id="_Toc401589996" class="anchor"><span id="_Toc401598801" class="anchor"><span id="_Toc401599908" class="anchor"><span id="_Toc401600963" class="anchor"><span id="_Toc401602018" class="anchor"><span id="_Toc401603073" class="anchor"><span id="_Toc401604067" class="anchor"><span id="_Toc401605141" class="anchor"><span id="_Toc401606215" class="anchor"><span id="_Toc401758810" class="anchor"><span id="_Toc401838613" class="anchor"><span id="_Toc401839877" class="anchor"><span id="_Toc401854759" class="anchor"><span id="_Toc401855833" class="anchor"><span id="_Toc401935536" class="anchor"><span id="_Toc401936610" class="anchor"><span id="_Toc402188932" class="anchor"><span id="_Toc402344321" class="anchor"><span id="_Toc401311838" class="anchor"><span id="_Toc401323900" class="anchor"><span id="_Toc401569745" class="anchor"><span id="_Toc401579489" class="anchor"><span id="_Toc401588917" class="anchor"><span id="_Toc401589997" class="anchor"><span id="_Toc401598802" class="anchor"><span id="_Toc401599909" class="anchor"><span id="_Toc401600964" class="anchor"><span id="_Toc401602019" class="anchor"><span id="_Toc401603074" class="anchor"><span id="_Toc401604068" class="anchor"><span id="_Toc401605142" class="anchor"><span id="_Toc401606216" class="anchor"><span id="_Toc401758811" class="anchor"><span id="_Toc401838614" class="anchor"><span id="_Toc401839878" class="anchor"><span id="_Toc401854760" class="anchor"><span id="_Toc401855834" class="anchor"><span id="_Toc401935537" class="anchor"><span id="_Toc401936611" class="anchor"><span id="_Toc402188933" class="anchor"><span id="_Toc402344322" class="anchor"><span id="_Toc401311839" class="anchor"><span id="_Toc401323901" class="anchor"><span id="_Toc401569746" class="anchor"><span id="_Toc401579490" class="anchor"><span id="_Toc401588918" class="anchor"><span id="_Toc401589998" class="anchor"><span id="_Toc401598803" class="anchor"><span id="_Toc401599910" class="anchor"><span id="_Toc401600965" class="anchor"><span id="_Toc401602020" class="anchor"><span id="_Toc401603075" class="anchor"><span id="_Toc401604069" class="anchor"><span id="_Toc401605143" class="anchor"><span id="_Toc401606217" class="anchor"><span id="_Toc401758812" class="anchor"><span id="_Toc401838615" class="anchor"><span id="_Toc401839879" class="anchor"><span id="_Toc401854761" class="anchor"><span id="_Toc401855835" class="anchor"><span id="_Toc401935538" class="anchor"><span id="_Toc401936612" class="anchor"><span id="_Toc402188934" class="anchor"><span id="_Toc402344323" class="anchor"><span id="_Toc401311840" class="anchor"><span id="_Toc401323902" class="anchor"><span id="_Toc401569747" class="anchor"><span id="_Toc401579491" class="anchor"><span id="_Toc401588919" class="anchor"><span id="_Toc401589999" class="anchor"><span id="_Toc401598804" class="anchor"><span id="_Toc401599911" class="anchor"><span id="_Toc401600966" class="anchor"><span id="_Toc401602021" class="anchor"><span id="_Toc401603076" class="anchor"><span id="_Toc401604070" class="anchor"><span id="_Toc401605144" class="anchor"><span id="_Toc401606218" class="anchor"><span id="_Toc401758813" class="anchor"><span id="_Toc401838616" class="anchor"><span id="_Toc401839880" class="anchor"><span id="_Toc401854762" class="anchor"><span id="_Toc401855836" class="anchor"><span id="_Toc401935539" class="anchor"><span id="_Toc401936613" class="anchor"><span id="_Toc402188935" class="anchor"><span id="_Toc402344324" class="anchor"><span id="_Toc401311841" class="anchor"><span id="_Toc401323903" class="anchor"><span id="_Toc401569748" class="anchor"><span id="_Toc401579492" class="anchor"><span id="_Toc401588920" class="anchor"><span id="_Toc401590000" class="anchor"><span id="_Toc401598805" class="anchor"><span id="_Toc401599912" class="anchor"><span id="_Toc401600967" class="anchor"><span id="_Toc401602022" class="anchor"><span id="_Toc401603077" class="anchor"><span id="_Toc401604071" class="anchor"><span id="_Toc401605145" class="anchor"><span id="_Toc401606219" class="anchor"><span id="_Toc401758814" class="anchor"><span id="_Toc401838617" class="anchor"><span id="_Toc401839881" class="anchor"><span id="_Toc401854763" class="anchor"><span id="_Toc401855837" class="anchor"><span id="_Toc401935540" class="anchor"><span id="_Toc401936614" class="anchor"><span id="_Toc402188936" class="anchor"><span id="_Toc402344325" class="anchor"><span id="_Toc401311842" class="anchor"><span id="_Toc401323904" class="anchor"><span id="_Toc401569749" class="anchor"><span id="_Toc401579493" class="anchor"><span id="_Toc401588921" class="anchor"><span id="_Toc401590001" class="anchor"><span id="_Toc401598806" class="anchor"><span id="_Toc401599913" class="anchor"><span id="_Toc401600968" class="anchor"><span id="_Toc401602023" class="anchor"><span id="_Toc401603078" class="anchor"><span id="_Toc401604072" class="anchor"><span id="_Toc401605146" class="anchor"><span id="_Toc401606220" class="anchor"><span id="_Toc401758815" class="anchor"><span id="_Toc401838618" class="anchor"><span id="_Toc401839882" class="anchor"><span id="_Toc401854764" class="anchor"><span id="_Toc401855838" class="anchor"><span id="_Toc401935541" class="anchor"><span id="_Toc401936615" class="anchor"><span id="_Toc402188937" class="anchor"><span id="_Toc402344326" class="anchor"><span id="_Toc401311843" class="anchor"><span id="_Toc401323905" class="anchor"><span id="_Toc401569750" class="anchor"><span id="_Toc401579494" class="anchor"><span id="_Toc401588922" class="anchor"><span id="_Toc401590002" class="anchor"><span id="_Toc401598807" class="anchor"><span id="_Toc401599914" class="anchor"><span id="_Toc401600969" class="anchor"><span id="_Toc401602024" class="anchor"><span id="_Toc401603079" class="anchor"><span id="_Toc401604073" class="anchor"><span id="_Toc401605147" class="anchor"><span id="_Toc401606221" class="anchor"><span id="_Toc401758816" class="anchor"><span id="_Toc401838619" class="anchor"><span id="_Toc401839883" class="anchor"><span id="_Toc401854765" class="anchor"><span id="_Toc401855839" class="anchor"><span id="_Toc401935542" class="anchor"><span id="_Toc401936616" class="anchor"><span id="_Toc402188938" class="anchor"><span id="_Toc402344327" class="anchor"><span id="_Toc401311844" class="anchor"><span id="_Toc401323906" class="anchor"><span id="_Toc401569751" class="anchor"><span id="_Toc401579495" class="anchor"><span id="_Toc401588923" class="anchor"><span id="_Toc401590003" class="anchor"><span id="_Toc401598808" class="anchor"><span id="_Toc401599915" class="anchor"><span id="_Toc401600970" class="anchor"><span id="_Toc401602025" class="anchor"><span id="_Toc401603080" class="anchor"><span id="_Toc401604074" class="anchor"><span id="_Toc401605148" class="anchor"><span id="_Toc401606222" class="anchor"><span id="_Toc401758817" class="anchor"><span id="_Toc401838620" class="anchor"><span id="_Toc401839884" class="anchor"><span id="_Toc401854766" class="anchor"><span id="_Toc401855840" class="anchor"><span id="_Toc401935543" class="anchor"><span id="_Toc401936617" class="anchor"><span id="_Toc402188939" class="anchor"><span id="_Toc402344328" class="anchor"><span id="_Toc401311845" class="anchor"><span id="_Toc401323907" class="anchor"><span id="_Toc401569752" class="anchor"><span id="_Toc401579496" class="anchor"><span id="_Toc401588924" class="anchor"><span id="_Toc401590004" class="anchor"><span id="_Toc401598809" class="anchor"><span id="_Toc401599916" class="anchor"><span id="_Toc401600971" class="anchor"><span id="_Toc401602026" class="anchor"><span id="_Toc401603081" class="anchor"><span id="_Toc401604075" class="anchor"><span id="_Toc401605149" class="anchor"><span id="_Toc401606223" class="anchor"><span id="_Toc401758818" class="anchor"><span id="_Toc401838621" class="anchor"><span id="_Toc401839885" class="anchor"><span id="_Toc401854767" class="anchor"><span id="_Toc401855841" class="anchor"><span id="_Toc401935544" class="anchor"><span id="_Toc401936618" class="anchor"><span id="_Toc402188940" class="anchor"><span id="_Toc402344329" class="anchor"><span id="_Installation_Instructions" class="anchor"><span id="_Toc308770209" class="anchor"><span id="_Toc344286937" class="anchor"><span id="_Toc401840203" class="anchor"><span id="_Toc405814766" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring the test suites
============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

This section provides the necessary guidance to configure the SharePoint
Server Protocol test suites on the SUT and the test suite client. The
configuration should be done in this order: configure the SUT1,
configure the SUT2 (optional), and then configure the test suite client.

For configuration script, the exit code definition is as follows:

1.  A normal termination will set the exit code to 0.

2.  An uncaught THROW will set the exit code to 1.

3.  Script execution warning and issues will set the exit code to 2.

4.  Exit code is set to the actual error code for other issues.

<span id="_Toc344286938" class="anchor"><span id="_Toc401840204" class="anchor"><span id="_Toc405814767" class="anchor"></span></span></span>Configuring the SUT
----------------------------------------------------------------------------------------------------------------------------------------------------------------

You can configure the SUT using automated scripts, as described in
sections [5.1.2](#ConfigTheSUT1) and [5.1.4](#ConfigTheSUT2); or
configure the SUT manually, as described in sections
[5.1.3](#ConfiguringtheSUT1manually) and
[5.1.5](#ConfiguringtheSUT2manually).

***Note**   The scripts should be run by a user who has domain
administrator rights on the SUT.*

1.  <span id="SharePointServerresources" class="anchor"><span
    id="_Toc401152794" class="anchor"><span id="_Toc397328561"
    class="anchor"><span id="_Toc401840205" class="anchor"><span
    id="_Toc405814768"
    class="anchor"></span></span></span></span></span>SUT resource
    requirements

Each test suite contained within the SharePoint Server Protocol test
suites package may require varying level of resources on the SUT. The
following table outlines these resources for each test suite. The SUT
configuration scripts will automatically create all the required
resources for the Microsoft server implementation. To configure the SUT
manually, refer to sections [5.1.3](#_Configuring_test_suite) and
[5.1.5](#ConfiguringtheSUT2manually).

The client configuration script follows the naming convention shown in
the following table. If a change to the resource name is required, then
the corresponding change to the resource name defined in the
SharePointTestSuite.config is required.

SharePoint server resources

  **Test suite**    **Resource type**        **Resource name**
  ----------------- ------------------------ ----------------------------------------------------------------
  All               --                       --
  MS-LISTSWS        Site collection          MSLISTSWS\_SiteCollection
                    Document library         MSLISTSWS\_DocumentLibrary
  MS-VERSS          Site collection          MSVERSS\_SiteCollection
  MS-SITESS         Site collection          MSSITESS\_SiteCollection
                    Site                     MSSITESS\_Site
                    Site                     MSSITESS\_NormalSubSite
                    Site                     MSSITESS\_SpecialSubSite
                    Document library         MSSITESS\_DocumentLibrary
                    Document library         MSSITESS\_SubSite\_DocumentLibrary
                    Text document            MSSITESS\_TestData.txt
                    ASPX file                MSSITESS\_CustomPage.aspx
  MS-DWSS           Site collection          MSDWSS\_SiteCollection
                    Site collection          MSDWSS\_SiteCollection\_DocumentWorkspace
                    Site                     MSDWSS\_Site
                    Site                     MSDWSS\_InheritPermissionSite
                    Document library         MSDWSS\_DocumentLibrary
                    Folder                   MSDWSS\_TestFolder
                    Text document            MSDWSS\_TestData.txt
                    User                     MSDWSS\_NoneRole
                    User                     MSDWSS\_ReaderRole
                    User                     MSDWSS\_GroupOwner
                    Group                    MSDWSS\_CustomGroup
  MS-MEETS          Site collection          MSMEETS\_SiteCollection
                    User                     MSMEETS\_User
  MSWEBSS           Site collection          MSWEBSS\_SiteCollection
                    Document library         MSWEBSS\_DocumentLibrary
                    Word document            MSWEBSS\_TestData.docx
                    Site                     MSWEBSS\_Site
  MS-WDVMODUU       Site collection          MSWDVMODUU\_SiteCollection
                    Document library         MSWDVMODUU\_DocumentLibrary1
                    Document library         MSWDVMODUU\_DocumentLibrary2
                    Text document            MSWDVMODUU\_TestData1.txt
                    Text document            MSWDVMODUU\_TestData2.txt
                    Text document            MSWDVMODUU\_TestData3.txt
                    Fake virus file          FakeVirusInfectedFile\_Get.txt
  MS-WWSP           Site collection          MSWWSP\_SiteCollection
                    Work Flow                MSWWSP\_Workflow
                    Work Flow Task List      Tasks
                    Work flow History List   MSWWSP\_WorkflowHistoryList
                    Document library         MSWWSP\_DocumentLibrary
                    Group                    MSWWSP\_UserGroup
                    User                     MSWWSP\_User
  MS-OUTSPS         Site collection          MSOUTSPS\_SiteCollection
  MS-AUTHWS         Web Application          MSAUTHWS\_FormsWebAPP
                    Web Application          MSAUTHWS\_NoneWebAPP
                    Web Application          MSAUTHWS\_PassportWebAPP
                    Web Application          MSAUTHWS\_WindowsAPP
  MS-SHDACCWS       Site collection          MSSHDACCWS\_SiteCollection
                    Document library         MSSHDACCWS\_DocumentLibrary
                    Text document            MSSHDACCWS\_LockedTestData.txt
                    Text document            MSSHDACCWS\_CoStatusTestData.txt
                    Text document            MSSHDACCWS\_TestData.txt
  MS-CPSWS          User                     MSCPSWS\_User
  MS-WSSREST        Site collection          MSWSSREST\_SiteCollection
                    Document library         MSWSSREST\_DocumentLibrary
                    Calendar                 MSWSSREST\_Calendar
                    DiscussionBoard          MSWSSREST\_DiscussionBoard
                    GenericList              MSWSSREST\_GenericList
                    Survey                   MSWSSREST\_Survey
                    WorkflowHistoryList      MSWSSREST\_WorkflowHistoryList
                    Tasks                    MSWSSREST\_Tasks
                    Work Flow                MSWSSREST\_Workflow
                    ChoiceField              MSWSSREST\_ChoiceField
                    MultiChoiceField         MSWSSREST\_MultiChoiceField
                    ChoiceFieldValue         MSWSSREST\_SingleChoiceOption1, MSWSSREST\_SingleChoiceOption2
                    MultiChoiceFieldValue    MSWSSREST\_MultiChoiceOption1, MSWSSREST\_MultiChoiceOption2
                    LookupField              MSWSSREST\_LookupField
  MS-OFFICIALFILE   Site collection          MSOFFICIALFILE\_SiteCollection
                    Site                     MSOFFICIALFILE\_RoutingRepository
                    Site                     MSOFFICIALFILE\_NoRoutingRepository
                    Site                     MSOFFICIALFILE\_EnabledParsingRepository
                    Document library         Drop Off Library
                    Document library         MSOFFICIALFILE\_DocumentRuleLocationLibrary
                    Document library         MSOFFICIALFILE\_NoEnforceLibrary
                    Document library         MSOFFICIALFILE\_DocumentSetLocationLibrary
                    DocumentSet              MSOFFICIALFILE\_DocumentSetName
                    User                     MSOFFICIALFILE\_User
  MS-COPYS          Site collection          MSCOPYS\_SiteCollection
                    Site                     MSCOPYS\_SubSiteMeetingWorkspace
                    User                     MSCOPYS\_EditUser
                    User                     MSCOPYS\_limitUser
                    Text document            MSCOPYS\_SourceFile.txt
                    Document library         MSCOPYS\_SubSiteDocumentLibrary
                    Document library         MSCOPYS\_SourceDocumentLibrary
                    Document library         MSCOPYS\_DestinationDocumentLibrary
                    Column                   MSCOPYS\_TestReadOnlyField
                    Column                   MSCOPYS\_WorkFlowEventField
                    Column field value       MSCOPYS\_Source
                    Column field value       MSCOPYS\_Destination
  MS-VIEWSS         Site collection          MSVIEWSS\_SiteCollection
                    GenericList              MSVIEWSS\_ViewList
                    ListItem                 MSVIEWSS\_ListItem1
                    ListItem                 MSVIEWSS\_ListItem2
                    ListItem                 MSVIEWSS\_ListItem3
                    ListItem                 MSVIEWSS\_ListItem4
                    ListItem                 MSVIEWSS\_ListItem5
                    ListItem                 MSVIEWSS\_ListItem6
                    ListItem                 MSVIEWSS\_ListItem7
                    ListItem                 MSVIEWSS\_ListItem7

### <span id="_Toc401569756" class="anchor"><span id="_Toc401579500" class="anchor"><span id="_Toc401588928" class="anchor"><span id="_Toc401590008" class="anchor"><span id="_Toc401598813" class="anchor"><span id="_Toc401599920" class="anchor"><span id="_Toc401600975" class="anchor"><span id="_Toc401602030" class="anchor"><span id="_Toc401603085" class="anchor"><span id="_Toc401604079" class="anchor"><span id="_Toc401605153" class="anchor"><span id="_Toc401606227" class="anchor"><span id="_Toc401758822" class="anchor"><span id="_Toc401838625" class="anchor"><span id="_Toc401839889" class="anchor"><span id="_Toc401854771" class="anchor"><span id="_Toc401855845" class="anchor"><span id="_Toc401935548" class="anchor"><span id="_Toc401936622" class="anchor"><span id="_Toc402188944" class="anchor"><span id="_Toc402344333" class="anchor"><span id="ConfigTheSUT1" class="anchor"><span id="_Toc401840206" class="anchor"><span id="_Toc405814769" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring SUT1 using the setup configuration script

> <span id="_Configure_the_SUT2_1" class="anchor"><span
> id="ConfigureSUTWithAttende" class="anchor"></span></span>*The setup
> configuration script is only used for configuring the SUT on the
> Windows platform. *

To configure SUT1 using the setup configuration script, navigate to the
**SUT** folder, right-click **SharePointSUTConfiguration.cmd** and
select **Run as administrator**.

### <span id="_Toc401311849" class="anchor"><span id="_Toc401323911" class="anchor"><span id="_Toc401569758" class="anchor"><span id="_Toc401579502" class="anchor"><span id="_Toc401588930" class="anchor"><span id="_Toc401590010" class="anchor"><span id="_Toc401598815" class="anchor"><span id="_Toc401599922" class="anchor"><span id="_Toc401600977" class="anchor"><span id="_Toc401602032" class="anchor"><span id="_Toc401603087" class="anchor"><span id="_Toc401604081" class="anchor"><span id="_Toc401605155" class="anchor"><span id="_Toc401606229" class="anchor"><span id="_Toc401758824" class="anchor"><span id="_Toc401838627" class="anchor"><span id="_Toc401839891" class="anchor"><span id="_Toc401854773" class="anchor"><span id="_Toc401855847" class="anchor"><span id="_Toc401935550" class="anchor"><span id="_Toc401936624" class="anchor"><span id="_Toc402188946" class="anchor"><span id="_Toc402344335" class="anchor"><span id="_Configuring_test_suite" class="anchor"><span id="_Configuring_the_SUT1" class="anchor"><span id="_Toc401840207" class="anchor"><span id="_Toc405814770" class="anchor"><span id="ConfiguringtheSUT1manually" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Configuring SUT1 manually

If the SUT is a non-Microsoft implementation of SharePoint Server, you
will not be able to run the setup configuration script. The following
steps explain what needs to be created or configured on the SUT in order
to run the test suites.

1.  In Windows Powershell, set the execution policy to **RemoteSigned**,
    enable remoting, and increase the memory allocated per shell for
    remote shell management to **1024MB** or more if you plan to run the
    SUT control adapter in PowerShell mode.

2.  Configure the SUT to support HTTPS.

3.  Set the Alternate Access Mapping (AAM) value to HTTPS on the SUT.

4.  Add the username for the user (who will configure the SUT) in the
    user policy. Please note that if the user policy of the Web
    application has a username with a claim prefix (such as i:0\#.w|),
    you will need to add the username without the claim in the
    user policy.

5.  If the WebDAV Publishing role service is installed on the SUT,
    remove it.

***Notes**   *

-   <span id="OLE_LINK23" class="anchor"><span id="OLE_LINK24"
    class="anchor"></span></span>*The steps in the subsequent sections
    should be performed by the SUT administrator.*

-   *All site templates mentioned in the subsequent sections apply to
    Microsoft implementations only*.

-   <span id="OLE_LINK30" class="anchor"><span id="OLE_LINK33"
    class="anchor"><span id="OLE_LINK35" class="anchor"><span
    id="OLE_LINK36" class="anchor"><span id="OLE_LINK37"
    class="anchor"></span></span></span></span></span>*Any site
    collection created on the SharePoint site should follow the **Team
    Site** template.*

#### MS-SITESS 

1.  Create a site collection named <span id="_Hlk342051414"
    class="anchor"></span>**MSSITESS\_SiteCollection**.

2.  Verify if the Workflows feature is activated.

3.  Create a subsite named <span id="_Hlk342050342"
    class="anchor"></span>**MSSITESS\_Site** in
    **MSSITESS\_SiteCollection** using the *Document Workspace*
    site template.

4.  Create two subsites named **MSSITESS\_NormalSubSite** and <span
    id="_Hlk342051746"
    class="anchor"></span>**MSSITESS\_SpecialSubSite** in MSSITESS\_Site
    using the *Team Site* template.

5.  <span id="OLE_LINK34" class="anchor"></span>Create a document
    library named **MSSITESS\_DocumentLibrary**
    in MSSITESS\_SiteCollection.

6.  Create a document library named<span id="_Hlk342051894"
    class="anchor"></span> **MSSITESS\_SubSite\_DocumentLibrary**
    in MSSITESS\_SpecialSubSite.

7.  Upload a file **MSSITESS\_TestData.txt** with the file size 24MB to
    MSSITESS\_SubSite\_DocumentLibrary <span id="_Hlk342051982"
    class="anchor"></span>in MSSITESS\_SpecialSubSite.

8.  Upload a custom page named **MSSITESS\_CustomPage.aspx** to
    MSSITESS\_SubSite\_DocumentLibrary in MSSITESS\_SpecialSubSite.

9.  Update the Web.config file to enable the custom pages on the server.

#### MS-DWSS 

1.  <span id="OLE_LINK75" class="anchor"></span>Create the following new
    users (as specified in section [5.1.1](#SharePointServerresources))
    and set their password to never expire on the domain controller.

    **MSDWSS\_NoneRole**, **MSDWSS\_ReaderRole**, and
    **MSDWSS\_GroupOwner***. *

2.  Create a site collection named **MSDWSS\_SiteCollection**.

3.  <span id="OLE_LINK44" class="anchor"><span id="OLE_LINK45"
    class="anchor"></span></span>Add an email address for the
    administrator on MSDWSS\_SiteCollection.

4.  Create a site collection named <span id="_Hlk342058515"
    class="anchor"></span>**MSDWSS\_SiteCollection\_DocumentWorkspace**
    using the *Document Workspace* template.

5.  Create a subsite named **MSDWSS\_Site** and
    **MSDWSS\_InheritPermissionSite** in MSDWSS\_SiteCollection using
    the *Document Workspace* template.

6.  In MSDWSS\_Site, break inheritance to the top-level site.

7.  Create a document library <span id="_Hlk342058724"
    class="anchor"></span>named **MSDWSS\_DocumentLibrary**
    in MSDWSS\_Site.

8.  Create a folder named <span id="_Hlk342058831"
    class="anchor"></span>**MSDWSS\_TestFolder** on
    MSDWSS\_DocumentLibrary, and then upload an arbitrary text file
    named MSDWSS\_TestData.txt into this folder.

9.  Grant read permissions to MSDWSS\_ReaderRole on MSDWSS\_Site.

10. Create a group named **MSDWSS\_CustomGroup**, and add
    MSDWSS\_GroupOwner as the group owner on MSDWSS\_Site.

11. Grant full control permissions to MSDWSS\_CustomGroup
    on MSDWSS\_Site.

#### MS-VERSS 

1.  Create a site collection named **MSVERSS\_SiteCollection**.

#### MS-LISTSWS 

1.  Create a site collection named **MSLISTSWS\_SiteCollection**.

2.  Create a document library named **MSLISTSWS\_DocumentLibrary**
    in MSLISTSWS\_SiteCollection.

#### MS-WWSP 

***Note**    The MS-WWSP test suite supports only the following versions
of SharePoint:*

-   *Microsoft Office SharePoint Server 2007*

-   *Microsoft SharePoint Server 2010*

-   *Microsoft SharePoint Server 2013 *

1.  Create a group with the name <span id="_Hlk342467861"
    class="anchor"></span>**MSWWSP\_UserGroup** on the
    domain controller.

2.  Add a default administrator to **MSWWSP\_UserGroup**.

3.  Create a user named **MSWWSP\_User** and set the password to never
    expires on the domain controller.

4.  Add **MSWWSP\_User** to the MSWWSP\_UserGroup.

5.  Create a site collection named **MSWWSP\_SiteCollection**.

6.  Grant full control permissions to **MSWWSP\_User**
    on MSWWSP\_SiteCollection.

7.  Create the document library **MSWWSP\_DocumentLibrary**
    in MSWWSP\_SiteCollection.

8.  Activate the **Workflows** feature on the site features page.

> **Note** This step applies to Microsoft SharePoint Server 2010 and
> Microsoft SharePoint Server 2013 only.

1.  Create a workflow association named **MSWWSP\_Workflow**
    in MSWWSP\_DocumentLibrary.

2.  Create a workflow task list named **Tasks**
    in MSWWSP\_SiteCollection.

3.  Create a workflow history list named **MSWWSP\_WorkflowHistoryList**
    in MSWWSP\_SiteCollection.

> **Note**    The workflow association template name and task name will
> be used in the MS-XXX\_TestSuite.deployment.ptfconfig file in the test
> suite.
>
> The workflow association template name must be **Approval** for
> Microsoft SharePoint Server 2007, and **Approval - SharePoint 2010**
> for Microsoft SharePoint Server 2010 and Microsoft SharePoint Server
> 2013.

#### MS-MEETS 

1.  Create a new user named **MSMEETS\_User** and set the password to
    never expire on the domain controller.

2.  Create a site collection named **MSMEETS\_SiteCollection***.*

3.  Make sure the Meeting Workspace template is enabled.

> **Notes**

-   All Meeting Workspace site templates are hidden from the user
    interface, but a server administrator can remove the hidden flag by
    editing the WEBTEMP.XML file.

-   In Microsoft SharePoint Server 2013 in the Windows platform, the
    following templates are hidden:

> **Basic Meeting Workspace**, **Blank Meeting Workspace**, **Decision
> Meeting Workspace**, **Social Meeting Workspace**, and **Multipage
> Meeting Workspace**.

1.  <span id="OLE_LINK94" class="anchor"><span id="OLE_LINK95"
    class="anchor"></span></span>Restart Internet Information
    Services (IIS).

#### MS-WEBSS 

1.  Create a site collection named **MSWEBSS\_SiteCollection**.

2.  Create a subsite named **MSWEBSS\_Site** in MSWEBSS\_SiteCollection
    using the *Team Site* template. The value of the description field
    of the subsite is *MSWEBSS\_SiteDescription*. The language pack is
    installed on the server originally, for example: the LCID for
    English - United States is 1033.

3.  Create a document library **MSWEBSS\_DocumentLibrary** in the
    MSWEBSS\_Site site.

4.  Upload one arbitrary .docx file named MSWEBSS\_TestData.docx
    into MSWEBSS\_DocumentLibrary.

#### <span id="_Toc405814778" class="anchor"><span id="OLE_LINK15" class="anchor"><span id="OLE_LINK16" class="anchor"></span></span></span>MS-ADMINS 

1.  <span id="OLE_LINK22" class="anchor"></span>In IIS, configure the
    SharePoint site to support HTTPS.

2.  In IIS, set Alternate Access Mapping for HTTPS for the SharePoint
    Central Administration site.

3.  Activate the features DocumentManagement and DocumentSet on
    Microsoft SharePoint Server 2013.

4.  Add a firewall rule to allow HTTPS port of <span id="OLE_LINK27"
    class="anchor"><span id="OLE_LINK28"
    class="anchor"></span></span>the SharePoint Central Administration
    site to receive TCP data.

#### MS-OUTSPS 

1.  Create a site collection named **MSOUTSPS\_SiteCollection**.

#### MS-WDVMODUU 

1.  Create a site collection named **MSWDVMODUU\_SiteCollection**.

2.  Create a document library **MSWDVMODUU\_DocumentLibrary1**
    in MSWDVMODUU\_SiteCollection.

3.  Create the document library **MSWDVMODUU\_DocumentLibrary2**
    in MSWDVMODUU\_SiteCollection. Upload two arbitrary text files named
    MSWDVMODUU \_TestData1.txt and MSWDVMODUU \_TestData2.txt
    into MSWDVMODUU\_DocumentLibrary1.

4.  Create a folder named MSWDVMODUU \_TestFolder on
    MSWDVMODUU\_DocumentLibrary1, and upload an arbitrary text file
    named MSWDVMODUU \_TestData3.txt into this folder.

5.  Upload a fake virus file (mentioned in section [2.2.1](#VirusFile))
    into MSWDVMODUU\_DocumentLibrary2.

#### <span id="ConfigTestSuiteClient" class="anchor"><span id="_Toc405814781" class="anchor"><span id="_Toc344286939" class="anchor"></span></span></span>MS-AUTHWS 

1.  <span id="OLE_LINK96" class="anchor"><span id="OLE_LINK97"
    class="anchor"></span></span>Create three <span id="OLE_LINK70"
    class="anchor"></span>Web Applications named
    **MSAUTHWS\_FormsWebAPP**, <span id="OLE_LINK67"
    class="anchor"></span>**MSAUTHWS\_NoneWebAPP**, and
    **MSAUTHWS\_PassportWebAPP** with authentication mode set to Forms,
    None, and Passport respectively.

> **Note** If you are using Microsoft SharePoint Foundation 2013 or
> Microsoft SharePoint Server 2013, you will need to create a fourth web
> application named MSAUTHWS\_WindowsAPP with authentication mode set to
> Windows.

1.  <span id="OLE_LINK98" class="anchor"><span id="OLE_LINK99"
    class="anchor"></span></span>Configure MSAUTHWS\_FormsWebAPP,
    MSAUTHWS\_NoneWebAPP and MSAUTHWS\_PassportWebAPP,
    MSAUTHWS\_WindowsAPP to support HTTPS.

2.  <span id="OLE_LINK100" class="anchor"><span id="OLE_LINK101"
    class="anchor"></span></span>Configure <span id="OLE_LINK71"
    class="anchor"></span>MSAUTHWS\_FormsWebAPP to support
    forms-based authentication.

3.  Restart IIS.

4.  Add a firewall rule to allow HTTP and HTTPS ports of
    MSAUTHWS\_FormsWebAPP, MSAUTHWS\_NoneWebAPP, and
    MSAUTHWS\_WindowsAPP to receive TCP data.

#### MS-SHDACCWS 

***Note**    The MS-SHDACCWS test suite supports only the following
versions of SharePoint:*

-   *Microsoft SharePoint Foundation 2010*

-   *Microsoft SharePoint Server 2010 *

-   *Microsoft SharePoint Foundation 2013 *

-   *Microsoft SharePoint Server 2013*

1.  Create a site collection named <span id="OLE_LINK58"
    class="anchor"><span id="OLE_LINK59"
    class="anchor"></span></span>**MSSHDACCWS\_SiteCollection**.

2.  Create a document library <span id="OLE_LINK60" class="anchor"><span
    id="OLE_LINK61"
    class="anchor"></span></span>**MSSHDACCWS\_DocumentLibrary**
    in MSSHDACCWS\_SiteCollection.

3.  Upload three arbitrary text files named <span id="OLE_LINK63"
    class="anchor"><span id="OLE_LINK64"
    class="anchor"></span></span>MSSHDACCWS\_LockedTestData.txt,
    MSSHDACCWS\_CoStatusTestData.txt and MSSHDACCWS\_TestData.txt
    into MSSHDACCWS\_DocumentLibrary.

#### MS- CPSWS 

***Note**    The MS-* *CPSWS test suite supports only the following
versions of SharePoint:*

-   *Microsoft SharePoint Foundation 2010*

-   *Microsoft SharePoint Server 2010 *

-   *Microsoft SharePoint Foundation 2013 *

-   *Microsoft SharePoint Server 2013 *

1.  Create a user with the name **MSCPSWS\_User** and set the password
    to never expire on the domain controller.

2.  In IIS, enable anonymous authentication for
    **spclaimproviderwebservice.https.svc** and
    **spclaimproviderwebservice.svc**.

3.  Update the Web.config file to set the **serviceDebug
    includeExceptionDetailInFaults** value to **True** for the behaviors
    ClaimProviderWebServiceBehavior
    and HttpsClaimProviderWebServiceBehavior.

#### MS-WSSREST 

***Note**    The MS-WSSREST test suite supports only the following
versions of SharePoint:*

-   *Microsoft SharePoint Foundation 2010*

-   *Microsoft SharePoint Server 2010 *

-   *Microsoft SharePoint Foundation 2013 *

-   *Microsoft SharePoint Server 2013 *

1.  Create a site collection named **MSWSSREST\_SiteCollection**.

2.  Create a document library named **MSWSSREST\_DocumentLibrary**
    in MSWSSREST\_SiteCollection.

3.  Create a workflow association with the name of
    **MSWSSREST\_Workflow** under MSWSSREST\_DocumentLibrary.

4.  Create a calendar **MSWSSREST\_Calendar**
    in MSWSSREST\_SiteCollection.

5.  Create a discussion board **MSWSSREST\_DiscussionBoard**
    in MSWSSREST\_SiteCollection.

6.  Create a list **MSWSSREST\_GenericList**
    in MSWSSREST\_SiteCollection.

7.  Create a survey **MSWSSREST\_Survey** in the site
    collection MSWSSREST\_SiteCollection.

8.  Create a workflow history list **MSWSSREST\_**<span id="OLE_LINK46"
    class="anchor"><span id="OLE_LINK47"
    class="anchor"></span></span>**WorkflowHistoryList**
    in MSWSSREST\_SiteCollection.

9.  Create a task **MSWSSREST\_Tasks** in MSWSSREST\_SiteCollection.

10. In MSWSSREST\_GenericList, create columns with these types— Boolean,
    Choice, Currency, GridChoice, Integer, MultiChoice, Number, URL,
    PageSeparator, WorkFlowEventType, and Lookup.

11. <span id="OLE_LINK48" class="anchor"><span id="OLE_LINK49"
    class="anchor"></span></span>In MSWSSREST\_GenericList, create a
    column named **MSWSSREST\_ChoiceField** with *Choice* type, and set
    the choice values to MSWSSREST\_SingleChoiceOption1 and
    MSWSSREST\_SingleChoiceOption2, with the default value set
    to MSWSSREST\_SingleChoiceOption1.

12. In MSWSSREST\_GenericList, create a column named
    **MSWSSREST\_MultiChoiceField** with *MultiChoice* type, and set the
    choice values to MSWSSREST\_MultiChoiceOption1 and
    MSWSSREST\_MultiChoiceOption2, with the default value set
    to MSWSSREST\_MultiChoiceOption1.

13. In MSWSSREST\_Survey, create two columns with types GridChoice
    and PageSeparator.

#### MS-OFFICIALFILE 

***Note**    The MS-OFFICIALFILE test suite supports only the following
versions of SharePoint:*

-   *Microsoft Office SharePoint Server 2007*

-   *Microsoft SharePoint Server 2010*

-   *Microsoft SharePoint Server 2013 *

    For *Microsoft Office SharePoint Server 2007*, you will only need to
    configure the steps from 1 to 7.

1.  Create a site collection named **MSOFFICIALFILE\_SiteCollection**.

2.  Create a subsite named **MSOFFICIALFILE\_RoutingRepository** in
    MSOFFICIALFILE\_SiteCollection using the *Record Center*
    site template.

3.  Create a user with the name **MSOFFICIALFILE\_User** and set the
    password to never expire on the domain controller.

4.  Grant read permissions to **MSOFFICIALFILE\_User**
    on MSOFFICIALFILE\_RoutingRepository.

5.  Create a document library
    **MSOFFICIALFILE\_DocumentRuleLocationLibrary** under
    MSOFFICIALFILE\_RoutingRepository, and create a content organizer
    rule where the content type is *document*.

> **Note** The name and title cannot be empty in the rule.

1.  Create a document library named **Drop Off Library** under
    MSOFFICIALFILE\_RoutingRepository, and create a content organizer
    rule where the content type is default type.

> **Note** The name and title cannot be empty in the rule.

1.  Create a hold **MSOFFICIALFILE\_Holds**
    under MSOFFICIALFILE\_RoutingRepository.

2.  For Microsoft products, create a subsite named
    **MSOFFICIALFILE\_NoRoutingRepository** in
    MSOFFICIALFILE\_SiteCollection using the Record Center
    site template.

3.  Create a document library **Drop Off Library**
    in MSOFFICIALFILE\_NoRoutingRepository.

4.  Create a subsite named **MSOFFICIALFILE\_EnabledParsingRepository**
    in MSOFFICIALFILE\_SiteCollection using the Document Center
    site template.

5.  Create a document library
    **MSOFFICIALFILE\_DocumentRuleLocationLibrary** in
    MSOFFICIALFILE\_EnabledParsingRepository, and in the versioning
    settings of the library, enable major versioning.

6.  Activate the *Content Organizer* site feature on
    MSOFFICIALFILE\_EnabledParsingRepository
    and MSOFFICIALFILE\_RoutingRepository.

7.  Deactivate the *Content Organizer* site feature
    on MSOFFICIALFILE\_NoRoutingRepository.

8.  Disable the document parser on MSOFFICIALFILE\_RoutingRepository.

9.  Enable the document parser
    on MSOFFICIALFILE\_EnabledParsingRepository.

10. Enable the *Document Sets* site collection feature
    on MSOFFICIALFILE\_SiteCollection.

11. Add a default administrator to the SharePoint group **Records Center
    Web Service Submitters** for MSOFFICIALFILE\_RoutingRepository
    on MSOFFICIALFILE\_RoutingRepository.

12. Add a default administrator to the SharePoint group **Records Center
    Web Service Submitters** for MSOFFICIALFILE\_NoRoutingRepository"
    on MSOFFICIALFILE\_NoRoutingRepository.

13. Add a default administrator to the SharePoint group **Records Center
    Web Service Submitters** for
    MSOFFICIALFILE\_EnabledParsingRepository
    on MSOFFICIALFILE\_EnabledParsingRepository.

14. In MSOFFICIALFILE\_RoutingRepository, add *Document Set* from the
    existing site content types
    on MSOFFICIALFILE\_DocumentRuleLocationLibrary.

15. In MSOFFICIALFILE\_RoutingRepository, create a document set
    **MSOFFICIALFILE\_DocumentSetName**
    on MSOFFICIALFILE\_DocumentRuleLocationLibrary.

#### MS-COPYS 

1.  Create two users with name of MSCOPYS\_limitUser and
    MSCOPYS\_EditUser, and set their password never expire on the
    domain controller.

2.  Create a site collection named <span id="OLE_LINK79"
    class="anchor"><span id="OLE_LINK80"
    class="anchor"></span></span>MSCOPYS\_SiteCollection.

3.  Grant the user MSCOPYS\_EditUser with Edit permission level
    on MSCOPYS\_SiteCollection.

4.  Create subsites named MSCOPYS\_SubSite<span id="OLE_LINK73"
    class="anchor"><span id="OLE_LINK74"
    class="anchor"></span></span>MeetingWorkspace in
    MSCOPYS\_SiteCollection using the **Basic Meeting Workspace**
    site template.

5.  Create a document library **MSCOPYS\_SubSiteDocumentLibrary**
    in MSCOPYS\_SubSiteMeetingWorkspace.

6.  Create a document library **MSCOPYS\_SourceDocumentLibrary**
    in MSCOPYS\_SiteCollection.

7.  Create a document library **MSCOPYS\_DestinationDocumentLibrary**
    in MSCOPYS\_SiteCollection.

8.  Create a column named <span id="OLE_LINK83" class="anchor"><span
    id="OLE_LINK84"
    class="anchor"></span></span>**MSCOPYS\_TestReadOnlyField** in <span
    id="OLE_LINK81" class="anchor"><span id="OLE_LINK82"
    class="anchor"></span></span>MSCOPYS\_SourceDocumentLibrary with
    Text type, and set the default value to *MSCOPYS\_Source*, and the
    r<span id="OLE_LINK77" class="anchor"><span id="OLE_LINK78"
    class="anchor"></span></span>ead-only properties to false.

9.  Create a column named **MSCOPYS\_WorkFlowEventField** in
    MSCOPYS\_SourceDocumentLibrary with WorkFlowEvent type.

10. Create a column named **MSCOPYS\_TestReadOnlyField** in
    **MSCOPYS\_DestinationDocumentLibrary** with Text type, set the
    default value to *MSCOPYS\_Source* and the read-only properties to
    true*.*

11. Create a column named **MSCOPYS\_WorkFlowEventField** in
    MSCOPYS\_DestinationDocumentLibrary with WorkFlowEvent type.

12. Upload a file MSCOPYS\_SourceFile.txt to
    MSCOPYS\_SourceDocumentLibrary in MSCOPYS\_SiteCollection. The
    contents of the file should be “MSCOPYS\_SourceFile”. The file uses
    a form of ANSI.

#### MS-VIEWSS 

1.  Create a site collection named “*MSVIEWSS\_SiteCollection*”.

2.  Create a generic list *MSVIEWSS\_ViewList*
    in MSVIEWSS\_SiteCollection.

3.  Create the following items in list *MSVIEWSS\_ViewList.\
    \
    **Note*** Two of the eight items should have the same title.

> *MSVIEWSS\_ListItem1, MSVIEWSS\_ListItem2, MSVIEWSS\_ListItem3,
> MSVIEWSS\_ListItem4, MSVIEWSS\_ListItem5, MSVIEWSS\_ListItem6,
> MSVIEWSS\_ListItem7, MSVIEWSS\_ListItem7*

### <span id="_Toc401840208" class="anchor"><span id="_Toc405814788" class="anchor"><span id="ConfigTheSUT2" class="anchor"></span></span></span>Configuring SUT2 using the setup configuration script

***Note** The setup configuration script is only used for configuring
the SUT on Windows. *

To configure SUT2 using the setup configuration script, navigate to the
SUT folder, right-click **SharePointSecondSUTConfiguration.cmd** and
select **Run as administrator.**

### <span id="_Toc401840209" class="anchor"><span id="_Toc405814789" class="anchor"><span id="ConfiguringtheSUT2manually" class="anchor"></span></span></span>Configuring SUT2 manually

If the SUT is a non-Microsoft implementation of SharePoint Server, you
will not be able to run the setup configuration script. The following
steps explain what needs to be created or configured on the SUT in order
to run the test suites.

1.  In Powershell, set the execution policy to **RemoteSigned**, enable
    remoting, and increase the memory allocated per shell for remote
    shell management to **1024MB** or more.

2.  Configure the SUT to support HTTPS.

3.  Set the Alternate Access Mapping value to HTTPS on the SUT.

4.  Add the username for the user (who will configure the SUT) in the
    user policy. Please note that if the user policy of the Web
    application has a username with a claim prefix (such as i:0\#.w|),
    you will need to add the username without the claim in the
    user policy.

***Notes**   *

-   *The steps in the subsequent sections should be performed by the
    SUT administrator.*

-   *Any site collection created on the SharePoint site should follow
    the **Team Site** template. *

#### <span id="_Toc404341042" class="anchor"><span id="_Toc405814790" class="anchor"></span></span>MS-COPYS

1.  Create a site collection named MSCOPYS\_SiteCollection.

2.  Create a document library *MSCOPYS\_SourceDocumentLibrary*
    on MSCOPYS\_SiteCollection.

3.  Create subsites named MSCOPYS\_SubSiteMeetingWorkspace
    in MSCOPYS\_SiteCollection.

> For Microsoft SharePoint Server, use the *Basic Meeting Workspace*
> site template.

1.  Create column named *MSCOPYS\_TestReadOnlyField* in list
    MSCOPYS\_SourceDocumentLibrary with “Text” type, set the default
    value to *MSCOPYS\_Source*.

2.  Create a column named *MSCOPYS\_WorkFlowEventField* in list
    MSCOPYS\_SourceDocumentLibrary with “WorkFlowEvent” type.

3.  Upload a file *MSCOPYS\_SourceFil*e.txt use a form of ANSI with
    content “MSCOPYS\_SourceFile” to MSCOPYS\_SourceDocumentLibrary
    under MSCOPYS\_SiteCollection.

<span id="_Toc401840210" class="anchor"><span id="_Toc405814791" class="anchor"></span></span>Configuring the test suite client
-------------------------------------------------------------------------------------------------------------------------------

The test suite client is managed through a common configuration file,
two test suite-specific configuration files and six SHOULD/MAY
configuration files that have a “.ptfconfig” extension. These
configuration files can be modified directly; the common configuration
file and the test suite-specific configuration files can also be
modified through a script.

1.  <span id="_Toc401152800" class="anchor"><span id="_Toc397328567"
    class="anchor"><span id="_Toc401840211" class="anchor"><span
    id="_Toc405814792" class="anchor"></span></span></span></span>Common
    configuration file

<span id="CommonConfigFile" class="anchor"></span>The common
configuration file contains configurable properties common to all
SharePoint Server Protocol test suites. This file must be modified to
match the characteristics of the environment where the test suites are
installed.

SharePoint common configuration file

  **Configuration file**                               **Description**
  ---------------------------------------------------- -------------------------------------------------------------------------------------------------------------------
  SharePointCommonConfiguration.deployment.ptfconfig   The deployment configuration file provides the environmental details that are common to the protocol test suites.

1.  <span id="_Toc401152801" class="anchor"><span id="_Toc397328568"
    class="anchor"><span id="_Toc401840212" class="anchor"><span
    id="_Toc405814793"
    class="anchor"></span></span></span></span>Test-suite specific
    configuration files

In addition to the common configuration file, each individual test suite
has the following two configuration files for test suite-specific
modification.

Test-suite specific configuration files

  **Configuration file**                    **Description**
  ----------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_TestSuite.deployment.ptfconfig   The deployment configuration file provides the environmental details that are specific to the test suite. The configuration file allows for test suite-specific customization.
  MS-XXXX\_TestSuite.ptfconfig              The test suite configuration file contains details that specify the behavior of the test suite operation.

Both files are present in TestSuite folder of each test suite directory.

If you need to modify the common configuration values for a specific
test suite, you must copy the common properties to the
**MS-XXXX\_TestSuite.deployment.ptfconfig** file and change the values
of the properties. The specific configuration file will take precedence
over the common configuration file when the same property exists in both
places.

1.  <span id="Configure_Interactive_Mode" class="anchor"><span
    id="_Toc405814794" class="anchor"></span></span>**Set the test suite
    to interactive mode**

If the SUT is a non-Microsoft implementation of SharePoint Server, it is
recommended that you further configure the test suite by setting the
test suite to interactive mode. Interactive mode enables the test suite
to function in a manual way, enabling you to perform setup, teardown,
and other tasks in a step-by-step approach. To enable interactive mode
for a specific test suite, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.ptfconfig** configuration file
    within the **\\Source\\MS-XXXX\\TestSuite\\**.

<!-- -->

1.  Set the type value of Adapter property to **Interactive** for the
    SUT control adapter\*\*.

Interactive mode values

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property name   Default value\*         Optional value    Description
  --------------- ----------------------- ----------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Adapter         managed or powershell   interactive\*\*   **managed**: The SUT control adapter is implemented in C\# managed code.
                                                            
                                                            **powershell**: The SUT control adapter is implemented through PowerShell.
                                                            
                                                            **interactive**: Interactive adapter is used for manually configuring the server. Interactive adapter displays a dialog box to perform manual test each time one of its methods is called. The dialog box will show the method name, parameter names and values\*\*\*.
  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

*\*The Adapter property value is set to either **managed** or
**powershell** depending on whether the SUT control adapter is
implemented in managed C\# code or through Powershell. *

*\*\* When changing to interactive mode from managed mode, the
“adaptertype” attribute must be deleted to avoid a runtime error.* *When
changing to interactive mode from powershell mode, an additional step is
required—delete the “scriptdir” attribute to avoid a runtime error.*

*\*\*\*When the manual operation completes successfully, enter the
return value (if any) in “**Action Results**” and click **Succeed** in
the dialog box. When the manual operation is unable to complete, enter
the error messages in the **Failure Message** text box and click
**Fail** to terminate the test. In this case, the test will be treated
as “Inconclusive”.*

Further customization can be done by creating your own SUT control
adapter that matches the server implementation. For information about
how to create a SUT control adapter, see the Protocol Test Framework
(PTF) user documentation.

1.  <span id="_Toc405814795" class="anchor"></span>**Configure TSAP
    broadcast**

Test Session Announcement Protocol (TSAP) is used by PTF to broadcast
test information when the test suite is running. TSAP broadcast helps in
mapping test cases to captured frames.

By default, TSAP packets are broadcasted in the network. Users can
disable TSAP broadcast by adding an entry “BeaconLogTargetServer” to
TestSuite.deployment. config to target the TSAP only to specified
machine.

To change the TSAP packet broadcast, do the following:

1.  Browse to the **MS-XXXX\_TestSuite.deployment.ptfconfig**
    configuration file in the **\\Source\\MS-XXXX\\TestSuite\\** folder.

2.  Add a property “BeaconLogTargetServer” along with the value of the
    specified machine name.

> For example: &lt;Property name="BeaconLogTargetServer" value="SUT01"
> /&gt;

1.  <span id="_Toc401152802" class="anchor"><span id="_Toc397328569"
    class="anchor"><span id="_Toc401840213" class="anchor"><span
    id="_Toc405814796"
    class="anchor"></span></span></span></span>SHOULD/MAY configuration
    files

The test suite has six SHOULD/MAY configuration files that are specific
to all supported versions of the SUT. Each SHOULD/MAY requirement have
an associated parameter with a value of either “true” or “false”
corresponding to the server version that is supported. “true” represents
that the requirement must be validated, whereas “false” means that the
requirement must not be validated.

If the SUT is a non-Microsoft implementation of SharePoint Server,
configure the properties in the configuration file for the SUT which is
the closest match to the SUT implementation.

SHOULD/MAY configuration files

  **Configuration file**                                                **Description**
  --------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------
  MS-XXXX\_WindowsSharePointServices3\_SHOULDMAY.deployment.ptfconfig   Provides the configuration properties for SHOULD and MAY requirements supported by Windows SharePoint Services 3.0 Service Pack 3 (SP3).
  MS-XXXX\_SharePointFoundation2010\_SHOULDMAY.deployment.ptfconfig     Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Foundation 2010 Service Pack 2 (SP2).
  MS-XXXX\_SharePointFoundation2013\_SHOULDMAY.deployment.ptfconfig     Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Foundation 2013 Service Pack 1 (SP1).
  MS-XXXX\_SharePointServer2007\_SHOULDMAY.deployment.ptfconfig         Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft Office SharePoint Server 2007 Service Pack 3 (SP3).
  MS-XXXX\_SharePointServer2010\_SHOULDMAY.deployment.ptfconfig         Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Server 2010 Service Pack 2 (SP2).
  MS-XXXX\_SharePointServer2013\_SHOULDMAY.deployment.ptfconfig         Provides the configuration properties for SHOULD and MAY requirements supported by Microsoft SharePoint Server 2013 Service Pack 1 (SP1).

1.  <span id="_Toc401152803" class="anchor"><span id="_Toc397328570"
    class="anchor"><span id="_Toc401840214" class="anchor"><span
    id="_Toc405814797"
    class="anchor"></span></span></span></span>Configuring the test
    suite client using setup configuration script

***Note** The setup configuration script is only implemented for
configuring the test suite client on the Windows platform. *

To configure the test suite using the setup configuration script,
navigate to the **Setup\\Test Suite Client**\\ folder, right-click
**SharePointClientConfiguration.cmd** and select **Run as
administrator.**

1.  <span id="_Toc405814798" class="anchor"></span>Configuring the test
    suite client manually

If you didn’t use the setup configuration script to configure the test
suite client as described in the previous section, follow the steps
below to update configuration files and configure the test suite client.

1.  Update the property value in the common configuration file and the
    > test suite-specific configuration files according to the comment
    > of the property.

2.  By default, the test suites use PowerShell script in the SUT control
    > adapter to configure the SUT. If you chose interactive mode for
    > the SUT control adapter as described in section
    > [5.2.2.1](#Configure_Interactive_Mode), skip this step.

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
        id="_Toc402188968" class="anchor"><span
        id="_Test_Suite_Specific" class="anchor"><span
        id="_Toc401569834" class="anchor"><span id="_Toc401579578"
        class="anchor"><span id="_Toc401589006" class="anchor"><span
        id="_Toc401590086" class="anchor"><span id="_Toc401598891"
        class="anchor"><span id="_Toc401599998" class="anchor"><span
        id="_Toc401601053" class="anchor"><span id="_Toc401602108"
        class="anchor"><span id="_Toc401603163" class="anchor"><span
        id="_Toc401604157" class="anchor"><span id="_Toc401605231"
        class="anchor"><span id="_Toc401606305" class="anchor"><span
        id="_Toc401758900" class="anchor"><span id="_Toc401838703"
        class="anchor"><span id="_Toc401839967" class="anchor"><span
        id="_Toc401854849" class="anchor"><span id="_Toc401855923"
        class="anchor"><span id="_Toc401935626" class="anchor"><span
        id="_Toc401936700" class="anchor"><span id="_Toc402189022"
        class="anchor"><span id="_Toc401569835" class="anchor"><span
        id="_Toc401579579" class="anchor"><span id="_Toc401589007"
        class="anchor"><span id="_Toc401590087" class="anchor"><span
        id="_Toc401598892" class="anchor"><span id="_Toc401599999"
        class="anchor"><span id="_Toc401601054" class="anchor"><span
        id="_Toc401602109" class="anchor"><span id="_Toc401603164"
        class="anchor"><span id="_Toc401604158" class="anchor"><span
        id="_Toc401605232" class="anchor"><span id="_Toc401606306"
        class="anchor"><span id="_Toc401758901" class="anchor"><span
        id="_Toc401838704" class="anchor"><span id="_Toc401839968"
        class="anchor"><span id="_Toc401854850" class="anchor"><span
        id="_Toc401855924" class="anchor"><span id="_Toc401935627"
        class="anchor"><span id="_Toc401936701" class="anchor"><span
        id="_Toc402189023" class="anchor"><span id="_Toc401569845"
        class="anchor"><span id="_Toc401579589" class="anchor"><span
        id="_Toc401589017" class="anchor"><span id="_Toc401590097"
        class="anchor"><span id="_Toc401598902" class="anchor"><span
        id="_Toc401600009" class="anchor"><span id="_Toc401601064"
        class="anchor"><span id="_Toc401602119" class="anchor"><span
        id="_Toc401603174" class="anchor"><span id="_Toc401604168"
        class="anchor"><span id="_Toc401605242" class="anchor"><span
        id="_Toc401606316" class="anchor"><span id="_Toc401758911"
        class="anchor"><span id="_Toc401838714" class="anchor"><span
        id="_Toc401839978" class="anchor"><span id="_Toc401854860"
        class="anchor"><span id="_Toc401855934" class="anchor"><span
        id="_Toc401935637" class="anchor"><span id="_Toc401936711"
        class="anchor"><span id="_Toc402189033" class="anchor"><span
        id="_Toc401569846" class="anchor"><span id="_Toc401579590"
        class="anchor"><span id="_Toc401589018" class="anchor"><span
        id="_Toc401590098" class="anchor"><span id="_Toc401598903"
        class="anchor"><span id="_Toc401600010" class="anchor"><span
        id="_Toc401601065" class="anchor"><span id="_Toc401602120"
        class="anchor"><span id="_Toc401603175" class="anchor"><span
        id="_Toc401604169" class="anchor"><span id="_Toc401605243"
        class="anchor"><span id="_Toc401606317" class="anchor"><span
        id="_Toc401758912" class="anchor"><span id="_Toc401838715"
        class="anchor"><span id="_Toc401839979" class="anchor"><span
        id="_Toc401854861" class="anchor"><span id="_Toc401855935"
        class="anchor"><span id="_Toc401935638" class="anchor"><span
        id="_Toc401936712" class="anchor"><span id="_Toc402189034"
        class="anchor"><span id="_Toc401569847" class="anchor"><span
        id="_Toc401579591" class="anchor"><span id="_Toc401589019"
        class="anchor"><span id="_Toc401590099" class="anchor"><span
        id="_Toc401598904" class="anchor"><span id="_Toc401600011"
        class="anchor"><span id="_Toc401601066" class="anchor"><span
        id="_Toc401602121" class="anchor"><span id="_Toc401603176"
        class="anchor"><span id="_Toc401604170" class="anchor"><span
        id="_Toc401605244" class="anchor"><span id="_Toc401606318"
        class="anchor"><span id="_Toc401758913" class="anchor"><span
        id="_Toc401838716" class="anchor"><span id="_Toc401839980"
        class="anchor"><span id="_Toc401854862" class="anchor"><span
        id="_Toc401855936" class="anchor"><span id="_Toc401935639"
        class="anchor"><span id="_Toc401936713" class="anchor"><span
        id="_Toc402189035" class="anchor"><span id="_Toc401569848"
        class="anchor"><span id="_Toc401579592" class="anchor"><span
        id="_Toc401589020" class="anchor"><span id="_Toc401590100"
        class="anchor"><span id="_Toc401598905" class="anchor"><span
        id="_Toc401600012" class="anchor"><span id="_Toc401601067"
        class="anchor"><span id="_Toc401602122" class="anchor"><span
        id="_Toc401603177" class="anchor"><span id="_Toc401604171"
        class="anchor"><span id="_Toc401605245" class="anchor"><span
        id="_Toc401606319" class="anchor"><span id="_Toc401758914"
        class="anchor"><span id="_Toc401838717" class="anchor"><span
        id="_Toc401839981" class="anchor"><span id="_Toc401854863"
        class="anchor"><span id="_Toc401855937" class="anchor"><span
        id="_Toc401935640" class="anchor"><span id="_Toc401936714"
        class="anchor"><span id="_Toc402189036" class="anchor"><span
        id="_Toc401569849" class="anchor"><span id="_Toc401579593"
        class="anchor"><span id="_Toc401589021" class="anchor"><span
        id="_Toc401590101" class="anchor"><span id="_Toc401598906"
        class="anchor"><span id="_Toc401600013" class="anchor"><span
        id="_Toc401601068" class="anchor"><span id="_Toc401602123"
        class="anchor"><span id="_Toc401603178" class="anchor"><span
        id="_Toc401604172" class="anchor"><span id="_Toc401605246"
        class="anchor"><span id="_Toc401606320" class="anchor"><span
        id="_Toc401758915" class="anchor"><span id="_Toc401838718"
        class="anchor"><span id="_Toc401839982" class="anchor"><span
        id="_Toc401854864" class="anchor"><span id="_Toc401855938"
        class="anchor"><span id="_Toc401935641" class="anchor"><span
        id="_Toc401936715" class="anchor"><span id="_Toc402189037"
        class="anchor"><span id="_Toc401569850" class="anchor"><span
        id="_Toc401579594" class="anchor"><span id="_Toc401589022"
        class="anchor"><span id="_Toc401590102" class="anchor"><span
        id="_Toc401598907" class="anchor"><span id="_Toc401600014"
        class="anchor"><span id="_Toc401601069" class="anchor"><span
        id="_Toc401602124" class="anchor"><span id="_Toc401603179"
        class="anchor"><span id="_Toc401604173" class="anchor"><span
        id="_Toc401605247" class="anchor"><span id="_Toc401606321"
        class="anchor"><span id="_Toc401758916" class="anchor"><span
        id="_Toc401838719" class="anchor"><span id="_Toc401839983"
        class="anchor"><span id="_Toc401854865" class="anchor"><span
        id="_Toc401855939" class="anchor"><span id="_Toc401935642"
        class="anchor"><span id="_Toc401936716" class="anchor"><span
        id="_Toc402189038" class="anchor"><span id="_Toc401569863"
        class="anchor"><span id="_Toc401579607" class="anchor"><span
        id="_Toc401589035" class="anchor"><span id="_Toc401590115"
        class="anchor"><span id="_Toc401598920" class="anchor"><span
        id="_Toc401600027" class="anchor"><span id="_Toc401601082"
        class="anchor"><span id="_Toc401602137" class="anchor"><span
        id="_Toc401603192" class="anchor"><span id="_Toc401604186"
        class="anchor"><span id="_Toc401605260" class="anchor"><span
        id="_Toc401606334" class="anchor"><span id="_Toc401758929"
        class="anchor"><span id="_Toc401838732" class="anchor"><span
        id="_Toc401839996" class="anchor"><span id="_Toc401854878"
        class="anchor"><span id="_Toc401855952" class="anchor"><span
        id="_Toc401935655" class="anchor"><span id="_Toc401936729"
        class="anchor"><span id="_Toc402189051" class="anchor"><span
        id="_Toc401569864" class="anchor"><span id="_Toc401579608"
        class="anchor"><span id="_Toc401589036" class="anchor"><span
        id="_Toc401590116" class="anchor"><span id="_Toc401598921"
        class="anchor"><span id="_Toc401600028" class="anchor"><span
        id="_Toc401601083" class="anchor"><span id="_Toc401602138"
        class="anchor"><span id="_Toc401603193" class="anchor"><span
        id="_Toc401604187" class="anchor"><span id="_Toc401605261"
        class="anchor"><span id="_Toc401606335" class="anchor"><span
        id="_Toc401758930" class="anchor"><span id="_Toc401838733"
        class="anchor"><span id="_Toc401839997" class="anchor"><span
        id="_Toc401854879" class="anchor"><span id="_Toc401855953"
        class="anchor"><span id="_Toc401935656" class="anchor"><span
        id="_Toc401936730" class="anchor"><span id="_Toc402189052"
        class="anchor"><span id="_Toc401569865" class="anchor"><span
        id="_Toc401579609" class="anchor"><span id="_Toc401589037"
        class="anchor"><span id="_Toc401590117" class="anchor"><span
        id="_Toc401598922" class="anchor"><span id="_Toc401600029"
        class="anchor"><span id="_Toc401601084" class="anchor"><span
        id="_Toc401602139" class="anchor"><span id="_Toc401603194"
        class="anchor"><span id="_Toc401604188" class="anchor"><span
        id="_Toc401605262" class="anchor"><span id="_Toc401606336"
        class="anchor"><span id="_Toc401758931" class="anchor"><span
        id="_Toc401838734" class="anchor"><span id="_Toc401839998"
        class="anchor"><span id="_Toc401854880" class="anchor"><span
        id="_Toc401855954" class="anchor"><span id="_Toc401935657"
        class="anchor"><span id="_Toc401936731" class="anchor"><span
        id="_Toc402189053" class="anchor"><span id="_Toc401569866"
        class="anchor"><span id="_Toc401579610" class="anchor"><span
        id="_Toc401589038" class="anchor"><span id="_Toc401590118"
        class="anchor"><span id="_Toc401598923" class="anchor"><span
        id="_Toc401600030" class="anchor"><span id="_Toc401601085"
        class="anchor"><span id="_Toc401602140" class="anchor"><span
        id="_Toc401603195" class="anchor"><span id="_Toc401604189"
        class="anchor"><span id="_Toc401605263" class="anchor"><span
        id="_Toc401606337" class="anchor"><span id="_Toc401758932"
        class="anchor"><span id="_Toc401838735" class="anchor"><span
        id="_Toc401839999" class="anchor"><span id="_Toc401854881"
        class="anchor"><span id="_Toc401855955" class="anchor"><span
        id="_Toc401935658" class="anchor"><span id="_Toc401936732"
        class="anchor"><span id="_Toc402189054" class="anchor"><span
        id="_Toc401569867" class="anchor"><span id="_Toc401579611"
        class="anchor"><span id="_Toc401589039" class="anchor"><span
        id="_Toc401590119" class="anchor"><span id="_Toc401598924"
        class="anchor"><span id="_Toc401600031" class="anchor"><span
        id="_Toc401601086" class="anchor"><span id="_Toc401602141"
        class="anchor"><span id="_Toc401603196" class="anchor"><span
        id="_Toc401604190" class="anchor"><span id="_Toc401605264"
        class="anchor"><span id="_Toc401606338" class="anchor"><span
        id="_Toc401758933" class="anchor"><span id="_Toc401838736"
        class="anchor"><span id="_Toc401840000" class="anchor"><span
        id="_Toc401854882" class="anchor"><span id="_Toc401855956"
        class="anchor"><span id="_Toc401935659" class="anchor"><span
        id="_Toc401936733" class="anchor"><span id="_Toc402189055"
        class="anchor"><span id="_Toc401569868" class="anchor"><span
        id="_Toc401579612" class="anchor"><span id="_Toc401589040"
        class="anchor"><span id="_Toc401590120" class="anchor"><span
        id="_Toc401598925" class="anchor"><span id="_Toc401600032"
        class="anchor"><span id="_Toc401601087" class="anchor"><span
        id="_Toc401602142" class="anchor"><span id="_Toc401603197"
        class="anchor"><span id="_Toc401604191" class="anchor"><span
        id="_Toc401605265" class="anchor"><span id="_Toc401606339"
        class="anchor"><span id="_Toc401758934" class="anchor"><span
        id="_Toc401838737" class="anchor"><span id="_Toc401840001"
        class="anchor"><span id="_Toc401854883" class="anchor"><span
        id="_Toc401855957" class="anchor"><span id="_Toc401935660"
        class="anchor"><span id="_Toc401936734" class="anchor"><span
        id="_Toc402189056" class="anchor"><span id="_Toc401569869"
        class="anchor"><span id="_Toc401579613" class="anchor"><span
        id="_Toc401589041" class="anchor"><span id="_Toc401590121"
        class="anchor"><span id="_Toc401598926" class="anchor"><span
        id="_Toc401600033" class="anchor"><span id="_Toc401601088"
        class="anchor"><span id="_Toc401602143" class="anchor"><span
        id="_Toc401603198" class="anchor"><span id="_Toc401604192"
        class="anchor"><span id="_Toc401605266" class="anchor"><span
        id="_Toc401606340" class="anchor"><span id="_Toc401758935"
        class="anchor"><span id="_Toc401838738" class="anchor"><span
        id="_Toc401840002" class="anchor"><span id="_Toc401854884"
        class="anchor"><span id="_Toc401855958" class="anchor"><span
        id="_Toc401935661" class="anchor"><span id="_Toc401936735"
        class="anchor"><span id="_Toc402189057" class="anchor"><span
        id="_Toc401569891" class="anchor"><span id="_Toc401579635"
        class="anchor"><span id="_Toc401589063" class="anchor"><span
        id="_Toc401590143" class="anchor"><span id="_Toc401598948"
        class="anchor"><span id="_Toc401600055" class="anchor"><span
        id="_Toc401601110" class="anchor"><span id="_Toc401602165"
        class="anchor"><span id="_Toc401603220" class="anchor"><span
        id="_Toc401604214" class="anchor"><span id="_Toc401605288"
        class="anchor"><span id="_Toc401606362" class="anchor"><span
        id="_Toc401758957" class="anchor"><span id="_Toc401838760"
        class="anchor"><span id="_Toc401840024" class="anchor"><span
        id="_Toc401840160" class="anchor"><span id="_Toc401839694"
        class="anchor"><span id="_Toc401840215" class="anchor"><span
        id="_Toc401840052" class="anchor"><span id="_Toc401854906"
        class="anchor"><span id="_Toc401855980" class="anchor"><span
        id="_Toc401935683" class="anchor"><span id="_Toc401936757"
        class="anchor"><span id="_Toc402189079" class="anchor"><span
        id="_Configure_the_test" class="anchor"><span
        id="_Configure_the_test_1" class="anchor"><span
        id="_Toc401569892" class="anchor"><span id="_Toc401579636"
        class="anchor"><span id="_Toc401589064" class="anchor"><span
        id="_Toc401590144" class="anchor"><span id="_Toc401598949"
        class="anchor"><span id="_Toc401600056" class="anchor"><span
        id="_Toc401601111" class="anchor"><span id="_Toc401602166"
        class="anchor"><span id="_Toc401603221" class="anchor"><span
        id="_Toc401604215" class="anchor"><span id="_Toc401605289"
        class="anchor"><span id="_Toc401606363" class="anchor"><span
        id="_Toc401758958" class="anchor"><span id="_Toc401838761"
        class="anchor"><span id="_Toc401840025" class="anchor"><span
        id="_Toc401854907" class="anchor"><span id="_Toc401855981"
        class="anchor"><span id="_Toc401935684" class="anchor"><span
        id="_Toc401936758" class="anchor"><span id="_Toc402189080"
        class="anchor"><span id="_Toc401569893" class="anchor"><span
        id="_Toc401579637" class="anchor"><span id="_Toc401589065"
        class="anchor"><span id="_Toc401590145" class="anchor"><span
        id="_Toc401598950" class="anchor"><span id="_Toc401600057"
        class="anchor"><span id="_Toc401601112" class="anchor"><span
        id="_Toc401602167" class="anchor"><span id="_Toc401603222"
        class="anchor"><span id="_Toc401604216" class="anchor"><span
        id="_Toc401605290" class="anchor"><span id="_Toc401606364"
        class="anchor"><span id="_Toc401758959" class="anchor"><span
        id="_Toc401838762" class="anchor"><span id="_Toc401840026"
        class="anchor"><span id="_Toc401854908" class="anchor"><span
        id="_Toc401855982" class="anchor"><span id="_Toc401935685"
        class="anchor"><span id="_Toc401936759" class="anchor"><span
        id="_Toc402189081" class="anchor"><span id="_Toc401840216"
        class="anchor"><span id="_Toc335752278"
        class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Set
        the execution policy to RemoteSigned.

    b.  Add the SUT to the TrustedHosts to ensure that the Windows
        Remote Management (WinRM) client can process remote calls
        against the SUT if the test suite client is not joined to
        the domain.

<span id="_Toc402344357" class="anchor"><span id="_Toc402344363" class="anchor"><span id="_Toc402344364" class="anchor"><span id="_Toc402344365" class="anchor"><span id="_Toc402344366" class="anchor"><span id="_Toc402344367" class="anchor"><span id="_Toc402344368" class="anchor"><span id="_Toc402344369" class="anchor"><span id="_Toc401569928" class="anchor"><span id="_Toc401579672" class="anchor"><span id="_Toc401589100" class="anchor"><span id="_Toc401590180" class="anchor"><span id="_Toc401598985" class="anchor"><span id="_Toc401600092" class="anchor"><span id="_Toc401601147" class="anchor"><span id="_Toc401602202" class="anchor"><span id="_Toc401603257" class="anchor"><span id="_Toc401604251" class="anchor"><span id="_Toc401605325" class="anchor"><span id="_Toc401606399" class="anchor"><span id="_Toc401758994" class="anchor"><span id="_Toc401838797" class="anchor"><span id="_Toc401840061" class="anchor"><span id="_Toc401854943" class="anchor"><span id="_Toc401856017" class="anchor"><span id="_Toc401935720" class="anchor"><span id="_Toc401936794" class="anchor"><span id="_Toc402189116" class="anchor"><span id="_Toc402344370" class="anchor"><span id="_Toc401311868" class="anchor"><span id="_Toc401323930" class="anchor"><span id="_Toc401569929" class="anchor"><span id="_Toc401579673" class="anchor"><span id="_Toc401589101" class="anchor"><span id="_Toc401590181" class="anchor"><span id="_Toc401598986" class="anchor"><span id="_Toc401600093" class="anchor"><span id="_Toc401601148" class="anchor"><span id="_Toc401602203" class="anchor"><span id="_Toc401603258" class="anchor"><span id="_Toc401604252" class="anchor"><span id="_Toc401605326" class="anchor"><span id="_Toc401606400" class="anchor"><span id="_Toc401758995" class="anchor"><span id="_Toc401838798" class="anchor"><span id="_Toc401840062" class="anchor"><span id="_Toc401840162" class="anchor"><span id="_Toc401839701" class="anchor"><span id="_Toc401840217" class="anchor"><span id="_Toc401840059" class="anchor"><span id="_Toc401854944" class="anchor"><span id="_Toc401856018" class="anchor"><span id="_Toc401935721" class="anchor"><span id="_Toc401936795" class="anchor"><span id="_Toc402189117" class="anchor"><span id="_Toc402344371" class="anchor"><span id="_Toc401311869" class="anchor"><span id="_Toc401323931" class="anchor"><span id="_Toc401569930" class="anchor"><span id="_Toc401579674" class="anchor"><span id="_Toc401589102" class="anchor"><span id="_Toc401590182" class="anchor"><span id="_Toc401598987" class="anchor"><span id="_Toc401600094" class="anchor"><span id="_Toc401601149" class="anchor"><span id="_Toc401602204" class="anchor"><span id="_Toc401603259" class="anchor"><span id="_Toc401604253" class="anchor"><span id="_Toc401605327" class="anchor"><span id="_Toc401606401" class="anchor"><span id="_Toc401758996" class="anchor"><span id="_Toc401838799" class="anchor"><span id="_Toc401840063" class="anchor"><span id="_Toc401854945" class="anchor"><span id="_Toc401856019" class="anchor"><span id="_Toc401935722" class="anchor"><span id="_Toc401936796" class="anchor"><span id="_Toc402189118" class="anchor"><span id="_Toc402344372" class="anchor"><span id="_Toc401311870" class="anchor"><span id="_Toc401323932" class="anchor"><span id="_Toc401569931" class="anchor"><span id="_Toc401579675" class="anchor"><span id="_Toc401589103" class="anchor"><span id="_Toc401590183" class="anchor"><span id="_Toc401598988" class="anchor"><span id="_Toc401600095" class="anchor"><span id="_Toc401601150" class="anchor"><span id="_Toc401602205" class="anchor"><span id="_Toc401603260" class="anchor"><span id="_Toc401604254" class="anchor"><span id="_Toc401605328" class="anchor"><span id="_Toc401606402" class="anchor"><span id="_Toc401758997" class="anchor"><span id="_Toc401838800" class="anchor"><span id="_Toc401840064" class="anchor"><span id="_Toc401854946" class="anchor"><span id="_Toc401856020" class="anchor"><span id="_Toc401935723" class="anchor"><span id="_Toc401936797" class="anchor"><span id="_Toc402189119" class="anchor"><span id="_Toc402344373" class="anchor"><span id="_Toc401311871" class="anchor"><span id="_Toc401323933" class="anchor"><span id="_Toc401569932" class="anchor"><span id="_Toc401579676" class="anchor"><span id="_Toc401589104" class="anchor"><span id="_Toc401590184" class="anchor"><span id="_Toc401598989" class="anchor"><span id="_Toc401600096" class="anchor"><span id="_Toc401601151" class="anchor"><span id="_Toc401602206" class="anchor"><span id="_Toc401603261" class="anchor"><span id="_Toc401604255" class="anchor"><span id="_Toc401605329" class="anchor"><span id="_Toc401606403" class="anchor"><span id="_Toc401758998" class="anchor"><span id="_Toc401838801" class="anchor"><span id="_Toc401840065" class="anchor"><span id="_Toc401854947" class="anchor"><span id="_Toc401856021" class="anchor"><span id="_Toc401935724" class="anchor"><span id="_Toc401936798" class="anchor"><span id="_Toc402189120" class="anchor"><span id="_Toc402344374" class="anchor"><span id="_Toc401311872" class="anchor"><span id="_Toc401323934" class="anchor"><span id="_Toc401569933" class="anchor"><span id="_Toc401579677" class="anchor"><span id="_Toc401589105" class="anchor"><span id="_Toc401590185" class="anchor"><span id="_Toc401598990" class="anchor"><span id="_Toc401600097" class="anchor"><span id="_Toc401601152" class="anchor"><span id="_Toc401602207" class="anchor"><span id="_Toc401603262" class="anchor"><span id="_Toc401604256" class="anchor"><span id="_Toc401605330" class="anchor"><span id="_Toc401606404" class="anchor"><span id="_Toc401758999" class="anchor"><span id="_Toc401838802" class="anchor"><span id="_Toc401840066" class="anchor"><span id="_Toc401854948" class="anchor"><span id="_Toc401856022" class="anchor"><span id="_Toc401935725" class="anchor"><span id="_Toc401936799" class="anchor"><span id="_Toc402189121" class="anchor"><span id="_Toc402344375" class="anchor"><span id="_Toc401311873" class="anchor"><span id="_Toc401323935" class="anchor"><span id="_Toc401569934" class="anchor"><span id="_Toc401579678" class="anchor"><span id="_Toc401589106" class="anchor"><span id="_Toc401590186" class="anchor"><span id="_Toc401598991" class="anchor"><span id="_Toc401600098" class="anchor"><span id="_Toc401601153" class="anchor"><span id="_Toc401602208" class="anchor"><span id="_Toc401603263" class="anchor"><span id="_Toc401604257" class="anchor"><span id="_Toc401605331" class="anchor"><span id="_Toc401606405" class="anchor"><span id="_Toc401759000" class="anchor"><span id="_Toc401838803" class="anchor"><span id="_Toc401840067" class="anchor"><span id="_Toc401854949" class="anchor"><span id="_Toc401856023" class="anchor"><span id="_Toc401935726" class="anchor"><span id="_Toc401936800" class="anchor"><span id="_Toc402189122" class="anchor"><span id="_Toc402344376" class="anchor"><span id="_Toc401311874" class="anchor"><span id="_Toc401323936" class="anchor"><span id="_Toc401569935" class="anchor"><span id="_Toc401579679" class="anchor"><span id="_Toc401589107" class="anchor"><span id="_Toc401590187" class="anchor"><span id="_Toc401598992" class="anchor"><span id="_Toc401600099" class="anchor"><span id="_Toc401601154" class="anchor"><span id="_Toc401602209" class="anchor"><span id="_Toc401603264" class="anchor"><span id="_Toc401604258" class="anchor"><span id="_Toc401605332" class="anchor"><span id="_Toc401606406" class="anchor"><span id="_Toc401759001" class="anchor"><span id="_Toc401838804" class="anchor"><span id="_Toc401840068" class="anchor"><span id="_Toc401854950" class="anchor"><span id="_Toc401856024" class="anchor"><span id="_Toc401935727" class="anchor"><span id="_Toc401936801" class="anchor"><span id="_Toc402189123" class="anchor"><span id="_Toc402344377" class="anchor"><span id="_Toc401311875" class="anchor"><span id="_Toc401323937" class="anchor"><span id="_Toc401569936" class="anchor"><span id="_Toc401579680" class="anchor"><span id="_Toc401589108" class="anchor"><span id="_Toc401590188" class="anchor"><span id="_Toc401598993" class="anchor"><span id="_Toc401600100" class="anchor"><span id="_Toc401601155" class="anchor"><span id="_Toc401602210" class="anchor"><span id="_Toc401603265" class="anchor"><span id="_Toc401604259" class="anchor"><span id="_Toc401605333" class="anchor"><span id="_Toc401606407" class="anchor"><span id="_Toc401759002" class="anchor"><span id="_Toc401838805" class="anchor"><span id="_Toc401840069" class="anchor"><span id="_Toc401854951" class="anchor"><span id="_Toc401856025" class="anchor"><span id="_Toc401935728" class="anchor"><span id="_Toc401936802" class="anchor"><span id="_Toc402189124" class="anchor"><span id="_Toc402344378" class="anchor"><span id="_Toc401311876" class="anchor"><span id="_Toc401323938" class="anchor"><span id="_Toc401569937" class="anchor"><span id="_Toc401579681" class="anchor"><span id="_Toc401589109" class="anchor"><span id="_Toc401590189" class="anchor"><span id="_Toc401598994" class="anchor"><span id="_Toc401600101" class="anchor"><span id="_Toc401601156" class="anchor"><span id="_Toc401602211" class="anchor"><span id="_Toc401603266" class="anchor"><span id="_Toc401604260" class="anchor"><span id="_Toc401605334" class="anchor"><span id="_Toc401606408" class="anchor"><span id="_Toc401759003" class="anchor"><span id="_Toc401838806" class="anchor"><span id="_Toc401840070" class="anchor"><span id="_Toc401854952" class="anchor"><span id="_Toc401856026" class="anchor"><span id="_Toc401935729" class="anchor"><span id="_Toc401936803" class="anchor"><span id="_Toc402189125" class="anchor"><span id="_Toc402344379" class="anchor"><span id="_Toc401311877" class="anchor"><span id="_Toc401323939" class="anchor"><span id="_Toc401569938" class="anchor"><span id="_Toc401579682" class="anchor"><span id="_Toc401589110" class="anchor"><span id="_Toc401590190" class="anchor"><span id="_Toc401598995" class="anchor"><span id="_Toc401600102" class="anchor"><span id="_Toc401601157" class="anchor"><span id="_Toc401602212" class="anchor"><span id="_Toc401603267" class="anchor"><span id="_Toc401604261" class="anchor"><span id="_Toc401605335" class="anchor"><span id="_Toc401606409" class="anchor"><span id="_Toc401759004" class="anchor"><span id="_Toc401838807" class="anchor"><span id="_Toc401840071" class="anchor"><span id="_Toc401854953" class="anchor"><span id="_Toc401856027" class="anchor"><span id="_Toc401935730" class="anchor"><span id="_Toc401936804" class="anchor"><span id="_Toc402189126" class="anchor"><span id="_Toc402344380" class="anchor"><span id="_Toc401569939" class="anchor"><span id="_Toc401579683" class="anchor"><span id="_Toc401589111" class="anchor"><span id="_Toc401590191" class="anchor"><span id="_Toc401598996" class="anchor"><span id="_Toc401600103" class="anchor"><span id="_Toc401601158" class="anchor"><span id="_Toc401602213" class="anchor"><span id="_Toc401603268" class="anchor"><span id="_Toc401604262" class="anchor"><span id="_Toc401605336" class="anchor"><span id="_Toc401606410" class="anchor"><span id="_Toc401759005" class="anchor"><span id="_Toc401838808" class="anchor"><span id="_Toc401840072" class="anchor"><span id="_Toc401840163" class="anchor"><span id="_Toc401839704" class="anchor"><span id="_Toc401840218" class="anchor"><span id="_Toc401840060" class="anchor"><span id="_Toc401854954" class="anchor"><span id="_Toc401856028" class="anchor"><span id="_Toc401935731" class="anchor"><span id="_Toc401936805" class="anchor"><span id="_Toc402189127" class="anchor"><span id="_Toc402344381" class="anchor"><span id="_Toc401569940" class="anchor"><span id="_Toc401579684" class="anchor"><span id="_Toc401589112" class="anchor"><span id="_Toc401590192" class="anchor"><span id="_Toc401598997" class="anchor"><span id="_Toc401600104" class="anchor"><span id="_Toc401601159" class="anchor"><span id="_Toc401602214" class="anchor"><span id="_Toc401603269" class="anchor"><span id="_Toc401604263" class="anchor"><span id="_Toc401605337" class="anchor"><span id="_Toc401606411" class="anchor"><span id="_Toc401759006" class="anchor"><span id="_Toc401838809" class="anchor"><span id="_Toc401840073" class="anchor"><span id="_Toc401854955" class="anchor"><span id="_Toc401856029" class="anchor"><span id="_Toc401935732" class="anchor"><span id="_Toc401936806" class="anchor"><span id="_Toc402189128" class="anchor"><span id="_Toc402344382" class="anchor"><span id="_Toc401569941" class="anchor"><span id="_Toc401579685" class="anchor"><span id="_Toc401589113" class="anchor"><span id="_Toc401590193" class="anchor"><span id="_Toc401598998" class="anchor"><span id="_Toc401600105" class="anchor"><span id="_Toc401601160" class="anchor"><span id="_Toc401602215" class="anchor"><span id="_Toc401603270" class="anchor"><span id="_Toc401604264" class="anchor"><span id="_Toc401605338" class="anchor"><span id="_Toc401606412" class="anchor"><span id="_Toc401759007" class="anchor"><span id="_Toc401838810" class="anchor"><span id="_Toc401840074" class="anchor"><span id="_Toc401854956" class="anchor"><span id="_Toc401856030" class="anchor"><span id="_Toc401935733" class="anchor"><span id="_Toc401936807" class="anchor"><span id="_Toc402189129" class="anchor"><span id="_Toc402344383" class="anchor"><span id="_Toc401569942" class="anchor"><span id="_Toc401579686" class="anchor"><span id="_Toc401589114" class="anchor"><span id="_Toc401590194" class="anchor"><span id="_Toc401598999" class="anchor"><span id="_Toc401600106" class="anchor"><span id="_Toc401601161" class="anchor"><span id="_Toc401602216" class="anchor"><span id="_Toc401603271" class="anchor"><span id="_Toc401604265" class="anchor"><span id="_Toc401605339" class="anchor"><span id="_Toc401606413" class="anchor"><span id="_Toc401759008" class="anchor"><span id="_Toc401838811" class="anchor"><span id="_Toc401840075" class="anchor"><span id="_Toc401854957" class="anchor"><span id="_Toc401856031" class="anchor"><span id="_Toc401935734" class="anchor"><span id="_Toc401936808" class="anchor"><span id="_Toc402189130" class="anchor"><span id="_Toc402344384" class="anchor"><span id="_Toc401569943" class="anchor"><span id="_Toc401579687" class="anchor"><span id="_Toc401589115" class="anchor"><span id="_Toc401590195" class="anchor"><span id="_Toc401599000" class="anchor"><span id="_Toc401600107" class="anchor"><span id="_Toc401601162" class="anchor"><span id="_Toc401602217" class="anchor"><span id="_Toc401603272" class="anchor"><span id="_Toc401604266" class="anchor"><span id="_Toc401605340" class="anchor"><span id="_Toc401606414" class="anchor"><span id="_Toc401759009" class="anchor"><span id="_Toc401838812" class="anchor"><span id="_Toc401840076" class="anchor"><span id="_Toc401854958" class="anchor"><span id="_Toc401856032" class="anchor"><span id="_Toc401935735" class="anchor"><span id="_Toc401936809" class="anchor"><span id="_Toc402189131" class="anchor"><span id="_Toc402344385" class="anchor"><span id="_Toc401569944" class="anchor"><span id="_Toc401579688" class="anchor"><span id="_Toc401589116" class="anchor"><span id="_Toc401590196" class="anchor"><span id="_Toc401599001" class="anchor"><span id="_Toc401600108" class="anchor"><span id="_Toc401601163" class="anchor"><span id="_Toc401602218" class="anchor"><span id="_Toc401603273" class="anchor"><span id="_Toc401604267" class="anchor"><span id="_Toc401605341" class="anchor"><span id="_Toc401606415" class="anchor"><span id="_Toc401759010" class="anchor"><span id="_Toc401838813" class="anchor"><span id="_Toc401840077" class="anchor"><span id="_Toc401854959" class="anchor"><span id="_Toc401856033" class="anchor"><span id="_Toc401935736" class="anchor"><span id="_Toc401936810" class="anchor"><span id="_Toc402189132" class="anchor"><span id="_Toc402344386" class="anchor"><span id="_Toc401569945" class="anchor"><span id="_Toc401579689" class="anchor"><span id="_Toc401589117" class="anchor"><span id="_Toc401590197" class="anchor"><span id="_Toc401599002" class="anchor"><span id="_Toc401600109" class="anchor"><span id="_Toc401601164" class="anchor"><span id="_Toc401602219" class="anchor"><span id="_Toc401603274" class="anchor"><span id="_Toc401604268" class="anchor"><span id="_Toc401605342" class="anchor"><span id="_Toc401606416" class="anchor"><span id="_Toc401759011" class="anchor"><span id="_Toc401838814" class="anchor"><span id="_Toc401840078" class="anchor"><span id="_Toc401854960" class="anchor"><span id="_Toc401856034" class="anchor"><span id="_Toc401935737" class="anchor"><span id="_Toc401936811" class="anchor"><span id="_Toc402189133" class="anchor"><span id="_Toc402344387" class="anchor"><span id="_Toc401840219" class="anchor"><span id="_Toc405814799" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Running test suites
===================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

Once the required software has been installed and both the SUT and test
suite client have been configured appropriately, the test suite is ready
to run. The test suite can run only on the test suite client and can be
initiated in one of the following two ways: Visual Studio or batch
scripts.

> <span id="OLE_LINK85" class="anchor"><span id="OLE_LINK86"
> class="anchor"></span></span>**Note**  <span id="OLE_LINK56"
> class="anchor"><span id="OLE_LINK57" class="anchor"></span></span> If
> you need to run the test suite MS-WDVMODUU, copy the fake virus file
> that mentioned in section [2.2.1](#VirusFile) to the folder
> **\\Source\\MS-WDVMODUU\\TestSuite\\** **Resources**.

<span id="_Toc306892175" class="anchor"><span id="_Toc344286941" class="anchor"><span id="_Toc401840220" class="anchor"><span id="_Toc405814800" class="anchor"></span></span></span></span>Microsoft Visual Studio
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

A Microsoft Visual Studio solution file
**SharePointServerProtocolTestSuites.sln** is provided in the **Source**
folder. You can run a single or multiple test cases in Visual Studio.

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Open **SharePointServerProtocolTestSuites.sln** in Visual Studio.                                                                        ![](media/image5.png){width="3.425in" height="2.3819444444444446in"}
                                                                                                                                               
                                                                                                                                               
  -------------------------------------------------------------------------------------------------------------------------------------------- ----------------------------------------------------------------------
  1.  In the **Solution Explorer** pane, right-click **Solution ‘SharePointServerProtocolTestSuites’**, and then click **Rebuild Solution**.   ![](media/image6.png){width="3.425in" height="2.6430555555555557in"}
                                                                                                                                               
                                                                                                                                               

  1.  Open **Test Explorer**. On the ribbon, click **TEST** , then click **Windows**, and finally click **Test Explorer**.                     ![](media/image7.png){width="3.425in" height="1.7284722222222222in"}
                                                                                                                                               
                                                                                                                                               

  1.  Select the test case to run. Right-click the test case and then select **Run Selected Tests**.                                           ![](media/image8.png){width="3.425in" height="3.1555555555555554in"}
                                                                                                                                               
                                                                                                                                               
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line" class="anchor"><span id="_Toc306892176"
class="anchor"></span></span>A Visual Studio solution file
**MS-XXXX.sln** is provided in each test suite folder.

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  1.  Select the test suite you would like to run. Let’s take MS-DWSS as an example here, so browse to the **Source\\MS-DWSS\\** directory.

  ------------------------------------------------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------
  1.  Open **MS-DWSS.sln** in Visual Studio.

  1.  In the Solution Explorer pane, right-click **Solution ‘MS-DWSS**’, and then click **Rebuild Solution**.

  1.  Open Test Explorer. On the ribbon, click **TEST** , then click **Windows**, and finally click **Test Explorer**

  1.  Select the test case to run. Right-click the test case and then select **Run Selected Tests**.

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<span id="_Command_line_1" class="anchor"><span id="_Toc401311881" class="anchor"><span id="_Toc401323943" class="anchor"><span id="_Toc401569948" class="anchor"><span id="_Toc401579692" class="anchor"><span id="_Toc401589120" class="anchor"><span id="_Toc401590200" class="anchor"><span id="_Toc401599005" class="anchor"><span id="_Toc401600112" class="anchor"><span id="_Toc401601167" class="anchor"><span id="_Toc401602222" class="anchor"><span id="_Toc401603277" class="anchor"><span id="_Toc401604271" class="anchor"><span id="_Toc401605345" class="anchor"><span id="_Toc401606419" class="anchor"><span id="_Toc401759014" class="anchor"><span id="_Toc401838817" class="anchor"><span id="_Toc401840081" class="anchor"><span id="_Toc401840166" class="anchor"><span id="_Toc401839713" class="anchor"><span id="_Toc401840221" class="anchor"><span id="_Toc401840086" class="anchor"><span id="_Toc401854963" class="anchor"><span id="_Toc401856037" class="anchor"><span id="_Toc401935740" class="anchor"><span id="_Toc401936814" class="anchor"><span id="_Toc402189136" class="anchor"><span id="_Toc402344390" class="anchor"><span id="_Toc401311882" class="anchor"><span id="_Toc401323944" class="anchor"><span id="_Toc401569949" class="anchor"><span id="_Toc401579693" class="anchor"><span id="_Toc401589121" class="anchor"><span id="_Toc401590201" class="anchor"><span id="_Toc401599006" class="anchor"><span id="_Toc401600113" class="anchor"><span id="_Toc401601168" class="anchor"><span id="_Toc401602223" class="anchor"><span id="_Toc401603278" class="anchor"><span id="_Toc401604272" class="anchor"><span id="_Toc401605346" class="anchor"><span id="_Toc401606420" class="anchor"><span id="_Toc401759015" class="anchor"><span id="_Toc401838818" class="anchor"><span id="_Toc401840082" class="anchor"><span id="_Toc401854964" class="anchor"><span id="_Toc401856038" class="anchor"><span id="_Toc401935741" class="anchor"><span id="_Toc401936815" class="anchor"><span id="_Toc402189137" class="anchor"><span id="_Toc402344391" class="anchor"><span id="_Toc401311883" class="anchor"><span id="_Toc401323945" class="anchor"><span id="_Toc401569950" class="anchor"><span id="_Toc401579694" class="anchor"><span id="_Toc401589122" class="anchor"><span id="_Toc401590202" class="anchor"><span id="_Toc401599007" class="anchor"><span id="_Toc401600114" class="anchor"><span id="_Toc401601169" class="anchor"><span id="_Toc401602224" class="anchor"><span id="_Toc401603279" class="anchor"><span id="_Toc401604273" class="anchor"><span id="_Toc401605347" class="anchor"><span id="_Toc401606421" class="anchor"><span id="_Toc401759016" class="anchor"><span id="_Toc401838819" class="anchor"><span id="_Toc401840083" class="anchor"><span id="_Toc401854965" class="anchor"><span id="_Toc401856039" class="anchor"><span id="_Toc401935742" class="anchor"><span id="_Toc401936816" class="anchor"><span id="_Toc402189138" class="anchor"><span id="_Toc402344392" class="anchor"><span id="_Toc402344405" class="anchor"><span id="_Toc306892177" class="anchor"><span id="_Toc344286943" class="anchor"><span id="_Toc401840222" class="anchor"><span id="_Toc405814801" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Batch scripts
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

SharePoint Server Protocol Test Suites are installed with a collection
of scripts that enable a user to run individual test cases
(RunMSXXXX\_SYY\_TCZZ \_TestCaseDescription.cmd) or all test cases in a
test suite (RunAllMSXXXXTestCases.cmd), or all test cases of SharePoint
Server Protocol test suites at once (RunAllSharePointTestCases.cmd).
These scripts can be found in the **\\Source\\Scripts** directory.

**Note**   These scripts depend on having the compiled binaries in the
bin folder.

  **Batch script**                                **Script description**
  ----------------------------------------------- ----------------------------------------------------------------------------
  RunAllSharePointTestCases.cmd                   Runs all the test cases within the SharePoint Server Protocol test suites.
                                                  
  RunAllMSXXXXTestCases.cmd                       Runs all MS-XXXX test cases.
                                                  
  RunMSXXXX\_S01\_TC01\_TestCaseDescription.cmd   Runs a specific test case within the test suite.

<span id="_Toc402344407" class="anchor"><span id="_Toc401569964" class="anchor"><span id="_Toc401579708" class="anchor"><span id="_Toc401589136" class="anchor"><span id="_Toc401590216" class="anchor"><span id="_Toc401599021" class="anchor"><span id="_Toc401603293" class="anchor"><span id="_Toc401604287" class="anchor"><span id="_Toc401605361" class="anchor"><span id="_Toc401606435" class="anchor"><span id="_Toc401759030" class="anchor"><span id="_Toc401838833" class="anchor"><span id="_Toc401840097" class="anchor"><span id="_Toc401854979" class="anchor"><span id="_Toc401856053" class="anchor"><span id="_Toc401935756" class="anchor"><span id="_Toc401936830" class="anchor"><span id="_Toc402189152" class="anchor"><span id="_Toc402344408" class="anchor"><span id="_Toc344286944" class="anchor"><span id="_Toc401840223" class="anchor"><span id="_Toc405814802" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Test suite results, logs, and reporting
=================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

The test suites provide detailed reporting in a variety of formats that
will enable users to quickly debug failures.

<span id="_Toc344286945" class="anchor"><span id="_Toc401840224" class="anchor"><span id="_Toc405814803" class="anchor"></span></span></span>Test suite configuration logs
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

The configuration logs contain information about whether each
configuration step succeeds or not, and detail error information if the
configuration step fails.

### <span id="_Toc401152810" class="anchor"><span id="_Toc401840225" class="anchor"><span id="_Toc405814804" class="anchor"></span></span></span>SUT configuration logs

The configuration scripts create a directory named **SetupLogs** under
**…\\Setup\\SUT\\** separately. The SUT configuration scripts save the
logs from the configuration process as
“SharePointSUTConfiguration.ps1.debug.log” and
“SharePointSUTConfiguration.ps1.log.

The second SUT configuration scripts save the logs as”
SharePointSecondSUTConfiguration.ps1.log”
and”SharePointSecondSUTConfiguration.ps1.debug.log”.

### <span id="_Toc401152811" class="anchor"><span id="_Toc401840226" class="anchor"><span id="_Toc405814805" class="anchor"></span></span></span>Test suite client configuration logs

The configuration scripts create a directory named **SetupLogs** under
**…\\Setup\\Test Suite Client\\**. The test suite client configuration
scripts save the logs from configuration process as
“SharePointClientConfiguration.ps1.debug.log” and
“SharePointClientConfiguration.ps1.log”

<span id="_Toc401311901" class="anchor"><span id="_Toc401323963" class="anchor"><span id="_Toc401569987" class="anchor"><span id="_Toc401579731" class="anchor"><span id="_Toc401589159" class="anchor"><span id="_Toc401590239" class="anchor"><span id="_Toc401599044" class="anchor"><span id="_Toc401600132" class="anchor"><span id="_Toc401601187" class="anchor"><span id="_Toc401602242" class="anchor"><span id="_Toc401603316" class="anchor"><span id="_Toc401604310" class="anchor"><span id="_Toc401605384" class="anchor"><span id="_Toc401606458" class="anchor"><span id="_Toc401759053" class="anchor"><span id="_Toc401838856" class="anchor"><span id="_Toc401840120" class="anchor"><span id="_Toc401855002" class="anchor"><span id="_Toc401856076" class="anchor"><span id="_Toc401935779" class="anchor"><span id="_Toc401936853" class="anchor"><span id="_Toc402189175" class="anchor"><span id="_Toc402344431" class="anchor"><span id="_Toc344286946" class="anchor"><span id="_Toc401840227" class="anchor"><span id="_Toc405814806" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Test suite reports
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

### <span id="_Toc401152813" class="anchor"><span id="_Toc401840228" class="anchor"><span id="_Toc405814807" class="anchor"></span></span></span>Microsoft Visual Studio

Reports are created only after the package level solution or an
individual test suite solution has run successfully in Visual Studio.

-   Reporting information for **SharePointServerProtocolTestSuites.sln**
    is saved in **…\\Source\\TestResults**.

-   Reporting information for an individual test suite **MS-XXXX.sln**
    is saved in **…\\Source\\MS-XXXX\\TestResults**.

### <span id="_Toc401152814" class="anchor"><span id="_Toc401840229" class="anchor"><span id="_Toc405814808" class="anchor"></span></span></span>Batch scripts

If the SharePoint Server Protocol test suites are run by the
RunAllSharePointTestCases.cmd batch file, the reporting information is
saved in **…\\Source\\Scripts\\TestResults**.

If the test suite is run by the batch file RunAllMSXXXXTestCases.cmd or
RunMSXXXX\_SYY\_TCZZ\_Name.cmd, the reporting information is saved in
**…\\Source\\Scripts\\MS-XXXX\\TestResults.**

By default, a .trx file containing the pass/fail information of the run
is created in the TestResults folder along with an associated directory
named **user\_MACHINENAME DateTimeStamp** that contains a log file and
an HTML report.

<span id="_Toc401569991" class="anchor"><span id="_Toc401579735" class="anchor"><span id="_Toc401589163" class="anchor"><span id="_Toc401590243" class="anchor"><span id="_Toc401599048" class="anchor"><span id="_Toc401600136" class="anchor"><span id="_Toc401601191" class="anchor"><span id="_Toc401602246" class="anchor"><span id="_Toc401603320" class="anchor"><span id="_Toc401604314" class="anchor"><span id="_Toc401605388" class="anchor"><span id="_Toc401606462" class="anchor"><span id="_Toc401759057" class="anchor"><span id="_Toc401838860" class="anchor"><span id="_Toc401840124" class="anchor"><span id="_Toc401855006" class="anchor"><span id="_Toc401856080" class="anchor"><span id="_Toc401935783" class="anchor"><span id="_Toc401936857" class="anchor"><span id="_Toc402189179" class="anchor"><span id="_Toc402344435" class="anchor"><span id="_Toc401311905" class="anchor"><span id="_Toc401323967" class="anchor"><span id="_Toc401569992" class="anchor"><span id="_Toc401579736" class="anchor"><span id="_Toc401589164" class="anchor"><span id="_Toc401590244" class="anchor"><span id="_Toc401599049" class="anchor"><span id="_Toc401600137" class="anchor"><span id="_Toc401601192" class="anchor"><span id="_Toc401602247" class="anchor"><span id="_Toc401603321" class="anchor"><span id="_Toc401604315" class="anchor"><span id="_Toc401605389" class="anchor"><span id="_Toc401606463" class="anchor"><span id="_Toc401759058" class="anchor"><span id="_Toc401838861" class="anchor"><span id="_Toc401840125" class="anchor"><span id="_Toc401855007" class="anchor"><span id="_Toc401856081" class="anchor"><span id="_Toc401935784" class="anchor"><span id="_Toc401936858" class="anchor"><span id="_Toc402189180" class="anchor"><span id="_Toc402344436" class="anchor"><span id="_UserESSDN_Configuration" class="anchor"><span id="_Toc405814809" class="anchor"></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span></span>Appendix
=====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

  References                                                                                                             Description
  ---------------------------------------------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------
  <dochelp@microsoft.com>                                                                                                Alias for Interoperability documentation help. Provides support for the Open Specifications and protocol test suites.
  [Open Specifications Forums](http://go.microsoft.com/fwlink/?LinkId=111125)                                            Microsoft Customer Support Services forums. Actively monitored forums that provide support for the Open Specifications and protocol test suites.
  [Open Specifications Developer Center](http://go.microsoft.com/fwlink/?LinkId=254469)                                  Open Specifications home page on MSDN.
  [Open Specifications](http://go.microsoft.com/fwlink/?LinkId=179743)                                                   Open Specifications documentation on MSDN.
  [SharePoint Products and Technologies Protocols](http://go.microsoft.com/fwlink/?LinkId=202122)                        SharePoint Open Specifications documentation on MSDN.
  [RFC2119](http://go.microsoft.com/fwlink/?LinkId=117453)                                                               Normative language reference.
  [Windows SharePoint Services 3.0 deployment](http://go.microsoft.com/fwlink/?LinkId=517502)                            Windows SharePoint Services 3.0 deployment on TechNet
  [Microsoft SharePoint Foundation 2010 deployment](http://go.microsoft.com/fwlink/?LinkId=517503)                       Microsoft SharePoint Foundation 2010 deployment on TechNet
  [Microsoft SharePoint Foundation 2013 installation and configuration](http://go.microsoft.com/fwlink/?LinkId=517504)   Microsoft SharePoint Foundation 2013 installation and configuration on TechNet
  [Microsoft Office SharePoint Server 2007 deployment](http://go.microsoft.com/fwlink/?LinkId=517506)                    Microsoft Office SharePoint Server 2007 deployment on TechNet
  [Microsoft SharePoint Server 2010 deployment](http://go.microsoft.com/fwlink/?LinkId=517505)                           Microsoft SharePoint Server 2010 deployment on TechNet
  [Microsoft SharePoint Server 2013 installation and configuration](http://go.microsoft.com/fwlink/?LinkId=517504)       Microsoft SharePoint Server 2013 installation and configuration on TechNet
  [Microsoft Forefront Protection 2010 for SharePoint deployment](http://go.microsoft.com/fwlink/?LinkId=517510)         Microsoft Forefront Protection 2010 for SharePoint deployment on TechNet
