namespace Microsoft.Protocols.TestSuites.MS_OXWSCONT
{
    using System;
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.Protocols.TestTools;
    
    /// <summary>
    /// The class provides methods to verify data/operation format in MS-OXWSCONT.
    /// </summary>
    public partial class MS_OXWSCONTAdapter
    {
        #region Verify requirements related to GetItem operation
        /// <summary>
        /// Capture GetItemResponseType related requirements.
        /// </summary>
        /// <param name="getItemResponse">The response message of GetItem operation.</param>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyGetContactItem(GetItemResponseType getItemResponse, bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R114");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R114
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                114,
                @"[In GetItem] The following is the WSDL port type specification for the GetItem operation:<wsdl:operation name=""GetItem"">
                    <wsdl:input message=""tns:GetItemSoapIn"" />
                    <wsdl:output message=""tns:GetItemSoapOut"" />
                    </wsdl:operation>");

            ContactItemType[] contacts = Common.GetItemsFromInfoResponse<ContactItemType>(getItemResponse);
            foreach (ContactItemType contact in contacts)
            {
                // Capture ContactItemType Complex Type related requirements.
                this.VerifyContactItemTypeComplexType(contact, isSchemaValidated);
            }
        }
        #endregion

        #region Verify requirements related to DeleteItem operation
        /// <summary>
        /// Capture DeleteItemResponseType related requirements.
        /// </summary>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyDeleteContactItem(bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R274");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R274
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                274,
                @"[In DeleteItem] The following is the WSDL port type specification for the DeleteItem operation: <wsdl:operation name=""DeleteItem"">
                      <wsdl:input message=""tns:DeleteItemSoapIn"" />
                      <wsdl:output message=""tns:DeleteItemSoapOut"" />
                      </wsdl:operation>");
        }
        #endregion

        #region Verify requirements related to UpdateItem operation
        /// <summary>
        /// Capture UpdateItemResponseType related requirements.
        /// </summary>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyUpdateContactItem(bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R280");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R280
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                280,
                @"[In UpdateItem] The following is the WSDL port type specification for the UpdateItem operation: <wsdl:operation name=""UpdateItem"">
                    <wsdl:input message=""tns:UpdateItemSoapIn"" />
                    <wsdl:output message=""tns:UpdateItemSoapOut"" />
                </wsdl:operation>");
        }
        #endregion

        #region Verify requirements related to MoveItem operation
        /// <summary>
        /// Capture MoveItemResponseType related requirements.
        /// </summary>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyMoveContactItem(bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R286");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R286
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                286,
                @"[In MoveItem] The following is the WSDL port type specification for the MoveItem operation: <wsdl:operation name=""MoveItem"">
                      <wsdl:input message=""tns:MoveItemSoapIn"" />
                      <wsdl:output message=""tns:MoveItemSoapOut"" />
                      </wsdl:operation>");
        }
        #endregion

        #region Verify requirements related to CopyItem operation
        /// <summary>
        /// Capture CopyItemResponseType related requirements.
        /// </summary>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyCopyContactItem(bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R292");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R292
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                292,
                @"[In CopyItem] The following is the WSDL port type specification for the CopyItem operation: <wsdl:operation name=""CopyItem"">
                      <wsdl:input message=""tns:CopyItemSoapIn"" />
                      <wsdl:output message=""tns:CopyItemSoapOut"" />
                      </wsdl:operation>");
        }
        #endregion

        #region Verify requirements related to CreateItem operation
        /// <summary>
        /// Capture CreateItemResponseType related requirements.
        /// </summary>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyCreateContactItem(bool isSchemaValidated)
        {
            // Add the debug information
            Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R298");

            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R298
            Site.CaptureRequirementIfIsTrue(
                isSchemaValidated,
                298,
                @"[In CreateItem] The following is the WSDL port type specification for the CreateItem operation:<wsdl:operation name=""CreateItem"">
                    <wsdl:input message=""tns:CreateItemSoapIn"" />
                    <wsdl:output message=""tns:CreateItemSoapOut"" />
                </wsdl:operation>");
        }
        #endregion

        #region Verify requirements related to ContactItemType complex types
        /// <summary>
        /// Capture ContactItemType Complex Type related requirements.
        /// </summary>
        /// <param name="contactItemType">A contact item from the response package of GetItem operation.</param>
        /// <param name="isSchemaValidated">A boolean value indicates the schema validation result. True means the response conforms with the schema, false means not.</param>
        private void VerifyContactItemTypeComplexType(ContactItemType contactItemType, bool isSchemaValidated)
        {
            Site.Assert.IsTrue(isSchemaValidated, "The schema validation result should be true!");

            if (contactItemType != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R19");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R19
                // If the contactItemType element is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    19,
                    @"[In t: ContactItemType Complex Type] The type[ContactItemType] is defined as follow:
  < xs:complexType name = ""ContactItemType"" >
   < xs:complexContent >
     < xs:extension
       base = ""t: ItemType""
     >
       < xs:sequence >
         < xs:element name = ""FileAs""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""FileAsMapping""
           type = ""t: FileAsMappingType""
           minOccurs = ""0""
          />
         < xs:element name = ""DisplayName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""GivenName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Initials""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""MiddleName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Nickname""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""CompleteName""
           type = ""t: CompleteNameType""
           minOccurs = ""0""
          />
         < xs:element name = ""CompanyName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""EmailAddresses""
           type = ""t: EmailAddressDictionaryType""
           minOccurs = ""0""
          />
         < xs:element name = ""AbchEmailAddresses""
           type = ""t: AbchEmailAddressDictionaryType""
           minOccurs = ""0""
          />
         < xs:element name = ""PhysicalAddresses""
           type = ""t: PhysicalAddressDictionaryType""
           minOccurs = ""0""
          />
         < xs:element name = ""PhoneNumbers""
           type = ""t: PhoneNumberDictionaryType""
           minOccurs = ""0""
          />
         < xs:element name = ""AssistantName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Birthday""
           type = ""xs: dateTime""
           minOccurs = ""0""
          />
         < xs:element name = ""BusinessHomePage""
           type = ""xs: anyURI""
           minOccurs = ""0""
          />
         < xs:element name = ""Children""
           type = ""t: ArrayOfStringsType""
           minOccurs = ""0""
          />
         < xs:element name = ""Companies""
           type = ""t: ArrayOfStringsType""
           minOccurs = ""0""
          />
         < xs:element name = ""ContactSource""
           type = ""t: ContactSourceType""
           minOccurs = ""0""
          />
         < xs:element name = ""Department""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Generation""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""ImAddresses""
           type = ""t: ImAddressDictionaryType""
           minOccurs = ""0""
          />
         < xs:element name = ""JobTitle""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Manager""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Mileage""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""OfficeLocation""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""PostalAddressIndex""
           type = ""t: PhysicalAddressIndexType""
           minOccurs = ""0""
          />
         < xs:element name = ""Profession""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""SpouseName""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""Surname""
           type = ""xs: string""
           minOccurs = ""0""
          />
         < xs:element name = ""WeddingAnniversary""
           type = ""xs: dateTime""
           minOccurs = ""0""
          />
         < xs:element name = ""HasPicture""
           type = ""xs: boolean""
           minOccurs = ""0""
          />
         < xs:element name = ""PhoneticFullName""
           type = ""xs: string""
           minOccurs = ""0""
         />
         < xs:element name = ""PhoneticFirstName""
           type = ""xs: string""
           minOccurs = ""0""
         />
         < xs:element name = ""PhoneticLastName""
           type = ""xs: string""
           minOccurs = ""0""
         />
         < xs:element name = ""Alias""
           type = ""xs: string""
           minOccurs = ""0""
         />
         < xs:element name = ""Notes""
           type = ""xs: string""
           minOccurs = ""0""
         />
         < xs:element name = ""Photo""
           type = ""xs: base64Binary""
           minOccurs = ""0""
        />
        < xs:element name = ""UserSMIMECertificate""
          type = ""t: ArrayOfBinaryType""
          minOccurs = ""0""
        />
        < xs:element name = ""MSExchangeCertificate""
          type = ""t: ArrayOfBinaryType""
          minOccurs = ""0""
        />
        < xs:element name = ""DirectoryId""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""ManagerMailbox""
          type = ""t: SingleRecipientType""
          minOccurs = ""0""
        />
        < xs:element name = ""DirectReports""
          type = ""t: ArrayOfRecipientsType""
          minOccurs = ""0""
        />
        < xs:element name = ""AccountName""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""IsAutoUpdateDisabled""
          type = ""xs: boolean""
          minOccurs = ""0""
        />
        < xs:element name = ""IsMessengerEnabled""
          type = ""xs: boolean""
          minOccurs = ""0""
        />
        < xs:element name = ""Comment""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""ContactShortId""
          type = ""xs: int""
          minOccurs = ""0""
        />
        < xs:element name = ""ContactType""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""Gender""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""IsHidden""
          type = ""xs: boolean""
          minOccurs = ""0""
        />
        < xs:element name = ""ObjectId""
          type = ""xs: string""
          minOccurs = ""0""
        />
        < xs:element name = ""PassportId""
          type = ""xs: long""
          minOccurs = ""0""
        />
        < xs:element name = ""PersonId""
          type = ""xs: int""
          minOccurs = ""0""
        />
        < xs:element name = ""IsPrivate""
          type = ""xs: boolean""
          minOccurs = ""0""
        />
        < xs:element name = ""SourceId""
          type = ""xs: string""
          minOccurs = ""0""
        />
");
            }

            if (contactItemType.FileAsMappingSpecified)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R128");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R128
                // If the FileAsMapping element is specified and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    128,
                    @"[In t:FileAsMappingType Simple Type] The type [FileAsMappingType] is defined as follow:
                        <xs:simpleType name=""FileAsMappingType"">
                         <xs:restriction
                          base=""xs:string""
                         >
                          <xs:enumeration
                           value=""None""
                           />
                          <xs:enumeration
                           value=""LastCommaFirst""
                           />
                          <xs:enumeration
                           value=""FirstSpaceLast""
                           />
                          <xs:enumeration
                           value=""Company""
                           />
                          <xs:enumeration
                           value=""LastCommaFirstCompany""
                           />
                          <xs:enumeration
                           value=""CompanyLastFirst""
                           />
                          <xs:enumeration
                           value=""LastFirst""
                           />
                          <xs:enumeration
                           value=""LastFirstCompany""
                           />
                          <xs:enumeration
                           value=""CompanyLastCommaFirst""
                           />
                          <xs:enumeration
                           value=""LastFirstSuffix""
                           />
                          <xs:enumeration
                           value=""LastSpaceFirstCompany""
                           />
                          <xs:enumeration
                           value=""CompanyLastSpaceFirst""
                           />
                          <xs:enumeration
                           value=""LastSpaceFirst""
                           />
                          <xs:enumeration
                           value=""DisplayName""
                           />
                          <xs:enumeration
                           value=""FirstName""
                           />
                          <xs:enumeration
                           value=""LastFirstMiddleSuffix""
                           />
                          <xs:enumeration
                           value=""LastName""
                           />
                          <xs:enumeration
                           value=""Empty""
                           />
                         </xs:restriction>
                        </xs:simpleType>");
            }

            if (contactItemType.Companies != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCDATA_R1081");

                // Verify MS-OXWSCDATA requirement: MS-OXWSCDATA_R1081
                // If the Companies element is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    "MS-OXWSCDATA",
                    1081,
                    @"[In t:ArrayOfStringsType Complex Type] The type [ArrayOfStringsType] is defined as follow:
                        <xs:complexType name=""ArrayOfStringsType"">
                          <xs:sequence>
                            <xs:element name=""String"" type=""xs:string"" minOccurs=""0"" maxOccurs=""unbounded""/>
                          </xs:sequence>
                        </xs:complexType>");
            }

            if (contactItemType.PostalAddressIndexSpecified)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R178");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R178
                // If the PostalAddressIndex element is specified and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    178,
                    @"[t:PhysicalAddressIndexType Simple Type] The type [PhysicalAddressIndexType] is defined as follow:<xs:simpleType name=""PhysicalAddressIndexType"">
                         <xs:restriction
                          base=""xs:string""
                         >
                          <xs:enumeration
                           value=""None""
                           />
                          <xs:enumeration
                           value=""Business""
                           />
                          <xs:enumeration
                           value=""Home""
                           />
                          <xs:enumeration
                           value=""Other""
                           />
                         </xs:restriction>
                        </xs:simpleType>");
            }

            if (contactItemType.CompleteName != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R192");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R192
                // If the CompleteName element is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    192,
                    @"[In t:CompleteNameType Complex Type] The type [CompleteNameType] is defined as follow:<xs:complexType name=""CompleteNameType"">
                         <xs:sequence>
                          <xs:element name=""Title""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""FirstName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""MiddleName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""LastName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""Suffix""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""Initials""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""FullName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""Nickname""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""YomiFirstName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                          <xs:element name=""YomiLastName""
                           type=""xs:string""
                           minOccurs=""0""
                           />
                         </xs:sequence>
                        </xs:complexType>");
            }

            if (contactItemType.EmailAddresses != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R236");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R236
                // If the EmailAddresses is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    236,
                    @"[In t:EmailAddressDictionaryType Complex Type] The type [EmailAddressDictionaryType] is defined as follow:<xs:complexType name=""EmailAddressDictionaryType"">
                         <xs:sequence>
                          <xs:element name=""Entry""
                           type=""t:EmailAddressDictionaryEntryType""
                           maxOccurs=""unbounded""
                           />
                         </xs:sequence>
                        </xs:complexType>");

                for (int i = 0; i < contactItemType.EmailAddresses.Length; i++)
                {
                    if (contactItemType.EmailAddresses[i] != null)
                    {
                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R226");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R226
                        // If the entry of EmailAddresses is not null and schema is validated,
                        // the requirement can be validated.
                        Site.CaptureRequirement(
                            226,
                            @"[In t: EmailAddressDictionaryEntryType Complex Type] The type[EmailAddressDictionaryEntryType] is defined as follow:
 < xs:complexType name = ""EmailAddressDictionaryEntryType"" >
 < xs:simpleContent >
  < xs:extension
   base = ""xs: string""
  >
   < xs:attribute name = ""Key""
    type = ""t: EmailAddressKeyType""
    use = ""required""
    />
   < xs:attribute name = ""Name""
    type = ""xs: string""
    use = ""optional""
    />
   < xs:attribute name = ""RoutingType""
    type = ""xs: string""
    use = ""optional""
    />
   < xs:attribute name = ""MailboxType""
    type = ""t: MailboxTypeType""
    use = ""optional""
    />
  </ xs:extension >
 </ xs:simpleContent >
</ xs:complexType > ");

                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R122");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R122
                        // The Key element is a required element of EmailAddressDictionaryEntryType, if the entry as EmailAddressDictionaryEntryType is not null,
                        // and the schema is validated, this requirement can be validated.
                        Site.CaptureRequirement(
                            122,
                            @"[In t:EmailAddressKeyType Simple Type] The type [EmailAddressKeyType] is defined as follow:
                                <xs:simpleType name=""EmailAddressKeyType"">
                                 <xs:restriction
                                  base=""xs:string""
                                 >
                                  <xs:enumeration
                                   value=""EmailAddress1""
                                   />
                                  <xs:enumeration
                                   value=""EmailAddress2""
                                   />
                                  <xs:enumeration
                                   value=""EmailAddress3""
                                   />
                                 </xs:restriction>
                                </xs:simpleType>");
                    }
                    else
                    {
                        Site.Assert.Fail("The entry of EmailAddresses should not be null!");
                    }
                }
            }

            if (contactItemType.ImAddresses != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R244");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R244
                // If the ImAddresses is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    244,
                    @"[In t:ImAddressDictionaryType Complex Type] The type [ImAddressDictionaryType] is defined as follow:<xs:complexType name=""ImAddressDictionaryType"">
                         <xs:sequence>
                          <xs:element name=""Entry""
                           type=""t:ImAddressDictionaryEntryType""
                           maxOccurs=""unbounded""
                           />
                         </xs:sequence>
                        </xs:complexType>");

                for (int i = 0; i < contactItemType.ImAddresses.Length; i++)
                {
                    if (contactItemType.ImAddresses[i] != null)
                    {
                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R240");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R240
                        // If the entry of ImAddresses is not null and schema is validated,
                        // the requirement can be validated.
                        Site.CaptureRequirement(
                            240,
                            @"[In t:ImAddressDictionaryEntryType Complex Type] The type [ImAddressDictionaryEntryType] is defined as follow:<xs:complexType name=""ImAddressDictionaryEntryType"">
                                 <xs:simpleContent>
                                  <xs:extension
                                   base=""xs:string""
                                  >
                                   <xs:attribute name=""key""
                                    type=""t:ImAddressKeyType""
                                    use=""required""
                                    />
                                  </xs:extension>
                                 </xs:simpleContent>
                                </xs:complexType>");

                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R149");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R149
                        // The Key element is a required element of ImAddressDictionaryEntryType, if the entry as ImAddressDictionaryEntryType is not null,
                        // and the schema is validated, this requirement can be validated.
                        Site.CaptureRequirement(
                            149,
                            @"[In t:ImAddressKeyType Simple Type] The type [ImAddressKeyType] is defined as follow:
                                <xs:simpleType name=""ImAddressKeyType"">
                                 <xs:restriction
                                  base=""xs:string""
                                 >
                                  <xs:enumeration
                                   value=""ImAddress1""
                                   />
                                  <xs:enumeration
                                   value=""ImAddress2""
                                   />
                                  <xs:enumeration
                                   value=""ImAddress3""
                                   />
                                 </xs:restriction>
                                </xs:simpleType>");
                    }
                    else
                    {
                        Site.Assert.Fail("The entry of ImAddresses should not be null!");
                    }
                }
            }

            if (contactItemType.PhoneNumbers != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R252");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R252
                // If the PhoneNumbers is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    252,
                    @"[In t:PhoneNumberDictionaryType Complex Type] The type [PhoneNumberDictionaryType] is defined as follow:<xs:complexType name=""PhoneNumberDictionaryType"">
                     <xs:sequence>
                      <xs:element name=""Entry""
                       type=""t:PhoneNumberDictionaryEntryType""
                       maxOccurs=""unbounded""
                       />
                     </xs:sequence>
                    </xs:complexType>");

                for (int i = 0; i < contactItemType.PhoneNumbers.Length; i++)
                {
                    if (contactItemType.PhoneNumbers[i] != null)
                    {
                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R248");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R248
                        // If the entry of PhoneNumbers is not null and schema is validated,
                        // the requirement can be validated.
                        Site.CaptureRequirement(
                            248,
                            @"[In t:PhoneNumberDictionaryEntryType Complex Type] The type [PhoneNumberDictionaryEntryType] is defined as follow:<xs:complexType name=""PhoneNumberDictionaryEntryType"">
                                <xs:simpleContent>
                                <xs:extension
                                base=""xs:string""
                                >
                                <xs:attribute name=""Key""
                                type=""t:PhoneNumberKeyType""
                                use=""required""
                                />
                                </xs:extension>
                                </xs:simpleContent>
                            </xs:complexType>");

                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R155");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R155
                        // The Key element is a required element of PhoneNumberDictionaryEntryType, if the entry as PhoneNumberDictionaryEntryType is not null,
                        // and the schema is validated, this requirement can be validated.
                        Site.CaptureRequirement(
                            155,
                            @"[In t: PhoneNumberKeyType Simple Type] The type[PhoneNumberKeyType] is defined as follow:
< xs:simpleType name = ""PhoneNumberKeyType"" >
 < xs:restriction
  base = ""xs: string""
 >
  < xs:enumeration
   value = ""AssistantPhone""
   />
  < xs:enumeration
   value = ""BusinessFax""
   />
  < xs:enumeration
   value = ""BusinessPhone""
   />
  < xs:enumeration
   value = ""BusinessPhone2""
   />
  < xs:enumeration
   value = ""Callback""
   />
  < xs:enumeration
   value = ""CarPhone""
   />
  < xs:enumeration
   value = ""CompanyMainPhone""
   />
  < xs:enumeration
   value = ""HomeFax""
   />
  < xs:enumeration
   value = ""HomePhone""
   />
  < xs:enumeration
   value = ""HomePhone2""
   />
  < xs:enumeration
   value = ""Isdn""
   />
  < xs:enumeration
   value = ""MobilePhone""
   />
  < xs:enumeration
   value = ""OtherFax""
   />
  < xs:enumeration
   value = ""OtherTelephone""
   />
  < xs:enumeration
   value = ""Pager""
   />
  < xs:enumeration
   value = ""PrimaryPhone""
   />
  < xs:enumeration
   value = ""RadioPhone""
   />
  < xs:enumeration
   value = ""Telex""
   />
  < xs:enumeration
   value = ""TtyTddPhone""
   />
   < xs:enumeration
       value = ""BusinessMobile"" />
     < xs:enumeration
       value = ""IPPhone"" />
     < xs:enumeration
       value = ""Mms"" />
     < xs:enumeration
       value = ""Msn"" />

 </ xs:restriction >
</ xs:simpleType > ");
                    }
                    else
                    {
                        Site.Assert.Fail("The entry of PhoneNumbers should not be null!");
                    }
                }
            }

            if (contactItemType.PhysicalAddresses != null)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R270");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R270
                // If the PhysicalAddresses is not null and schema is validated,
                // the requirement can be validated.
                Site.CaptureRequirement(
                    270,
                    @"[In t:PhysicalAddressDictionaryType Complex Type] The type [PhysicalAddressDictionaryType] is defined as follow:<xs:complexType name=""PhysicalAddressDictionaryType"">
                         <xs:sequence>
                          <xs:element name=""entry""
                           type=""t:PhysicalAddressDictionaryEntryType""
                           maxOccurs=""unbounded""
                           />
                         </xs:sequence>
                        </xs:complexType>");

                for (int i = 0; i < contactItemType.PhysicalAddresses.Length; i++)
                {
                    if (contactItemType.PhysicalAddresses[i] != null)
                    {
                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R256");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R256
                        // If the entry of PhysicalAddresses is not null and schema is validated,
                        // the requirement can be validated.
                        Site.CaptureRequirement(
                            256,
                            @"[In t:PhysicalAddressDictionaryEntryType Complex Type] The type [PhysicalAddressDictionaryEntryType] is defined as follow:<xs:complexType name=""PhysicalAddressDictionaryEntryType"">
                                 <xs:sequence>
                                  <xs:element name=""Street""
                                   type=""xs:string""
                                   minOccurs=""0""
                                   />
                                  <xs:element name=""City""
                                   type=""xs:string""
                                   minOccurs=""0""
                                   />
                                  <xs:element name=""State""
                                   type=""xs:string""
                                   minOccurs=""0""
                                   />
                                  <xs:element name=""CountryOrRegion""
                                   type=""xs:string""
                                   minOccurs=""0""
                                   />
                                  <xs:element name=""PostalCode""
                                   type=""xs:string""
                                   minOccurs=""0""
                                   />
                                 </xs:sequence>
                                 <xs:attribute name=""Key""
                                  type=""t:PhysicalAddressKeyType""
                                  use=""required""
                                  />
                                </xs:complexType>");

                        // Add the debug information
                        Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R185");

                        // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R185
                        // The Key element is a required element of PhysicalAddressDictionaryEntryType, if the entry as PhysicalAddressDictionaryEntryType is not null,
                        // and the schema is validated, this requirement can be validated.
                        Site.CaptureRequirement(
                            185,
                            @"[In t:PhysicalAddressKeyType Simple Type] The type [PhysicalAddressKeyType] is defined as follow:<xs:simpleType name=""PhysicalAddressKeyType"">
                                 <xs:restriction
                                  base=""xs:string""
                                 >
                                  <xs:enumeration
                                   value=""Business""
                                   />
                                  <xs:enumeration
                                   value=""Home""
                                   />
                                  <xs:enumeration
                                   value=""Other""
                                   />
                                 </xs:restriction>
                                </xs:simpleType>");
                    }
                    else
                    {
                        Site.Assert.Fail("The entry of PhysicalAddresses should not be null!");
                    }
                }
            }
        }
        #endregion

        #region Verify requirements related to SOAP version
        /// <summary>
        /// Verify the SOAP version.
        /// </summary>
        private void VerifySoapVersion()
        {
            // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R1
            // According to the implementation of adapter, the message is formatted as SOAP 1.1. If the operation is invoked successfully, then this requirement can be verified.
            Site.CaptureRequirement(
                1,
                @"[In Transport] The SOAP version supported is SOAP 1.1, as specified in [SOAP1.1].");
        }
        #endregion

        #region Verify transport related requirements.
        /// <summary>
        /// Verify the transport related requirements.
        /// </summary>
        private void VerifyTransportType()
        {
            // Get the transport type
            TransportProtocol transport = (TransportProtocol)Enum.Parse(typeof(TransportProtocol), Common.GetConfigurationPropertyValue("TransportType", Site), true);
            if (Common.IsRequirementEnabled(335001, this.Site) && transport == TransportProtocol.HTTPS)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R335001");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R335001
                // When test suite running on HTTPS, if there are no exceptions or error messages returned from server, this requirement will be captured.
                Site.CaptureRequirement(
                    335001,
                    @"[In Appendix B: Product Behavior] Implementation does use secure communications via HTTPS, as defined in [RFC2818]. (Exchange 2007 and above follow this behavior.)");
            }

            if (transport == TransportProtocol.HTTP)
            {
                // Add the debug information
                Site.Log.Add(LogEntryKind.Debug, "Verify MS-OXWSCONT_R101");

                // Verify MS-OXWSCONT requirement: MS-OXWSCONT_R101
                // When test suite running on HTTP, if there are no exceptions or error messages returned from server, this requirement will be captured.
                Site.CaptureRequirement(
                    101,
                    @"[In Transport] The protocol MUST support SOAP over HTTP, as specified in [RFC2616]. ");
            }
        }
        #endregion
    }
}