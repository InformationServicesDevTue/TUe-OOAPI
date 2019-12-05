namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/SiteSpecificatie/1.0",@"SiteSpecification")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SiteSpecification"})]
    public sealed class GetSiteSpecificationResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/InstitutieGegevens/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/SiteSpecificatie/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SiteSpecification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""owner"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""logo"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""specification"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""documentation"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""courseLevels"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""roomTypes"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""_links"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""self"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""endpoints"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""code"" type=""xs:string"" />
        <xs:element name=""title"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetSiteSpecificationResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SiteSpecification";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
