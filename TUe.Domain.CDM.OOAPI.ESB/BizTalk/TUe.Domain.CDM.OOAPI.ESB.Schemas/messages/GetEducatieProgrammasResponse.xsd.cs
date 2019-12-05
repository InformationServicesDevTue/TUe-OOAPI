namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.ESB.Schemas.messages.GetEducatieProgrammasResponse",@"EducationalPrograms")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EducationalPrograms"})]
    public sealed class GetEducatieProgrammasResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.ESB.Schemas.messages.GetEducatieProgrammasResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""EducationalPrograms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""pageSize"" type=""xs:unsignedByte"" />
        <xs:element minOccurs=""0"" name=""_embedded"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""items"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""educationalProgrammeId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""name"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""description"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""termStartDate"" type=""xs:date"" />
                    <xs:element minOccurs=""0"" name=""termEndDate"" type=""xs:date"" />
                    <xs:element minOccurs=""0"" name=""ects"" type=""xs:integer"" />
                    <xs:element minOccurs=""0"" name=""mainLanguage"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""qualificationAwarded"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""lenghtOfProgramme"" type=""xs:integer"" />
                    <xs:element minOccurs=""0"" name=""levelOfQualification"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""fieldsOfStudy"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""profileOfProgramme"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""programmeLearningOutcomes"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""modeOfStudy"" type=""xs:string"" />
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
                          <xs:element minOccurs=""0"" name=""courses"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
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
              <xs:element minOccurs=""0"" name=""prev"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""next"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetEducatieProgrammasResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "EducationalPrograms";
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
