namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/InstitutieGegevens/1.0",@"Institution")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Institution"})]
    public sealed class GetInstitutieResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/InstitutieGegevens/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/InstitutieGegevens/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Institution"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""institutionId"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""brin"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""name"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""description"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""academicCalendar"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""year"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""calender"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""address"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""street"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""additional"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""city"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""zip"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""countryCode"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""logo"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""_links"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""self"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""educational-programmes"">
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
        
        public GetInstitutieResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Institution";
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
