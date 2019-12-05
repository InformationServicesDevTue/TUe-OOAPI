namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/CursusLijst/1.0",@"Courses")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Courses"})]
    public sealed class GetCursusLijstResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/CursusLijst/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/CursusLijst/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Courses"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""pageSize"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""pageNumber"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""_embedded"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""items"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""courseId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""name"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""abbreviation"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ects"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""description"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""learningOutcomes"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""goals"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""requirements"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""level"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""format"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""modeOfDelivery"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""mainLanguage"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""enrollment"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""resources"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""exams"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""schedule"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""link"" type=""xs:string"" />
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
                          <xs:element minOccurs=""0"" name=""courseOfferings"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""coordinator"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""lecturers"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""faculties"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""educationalDepartments"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""educationalPlans"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""educationalProgrammes"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""courseGroup"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element name=""title"" type=""xs:string"" />
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
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""_links"">
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
        <xs:element name=""code"" type=""xs:string"" />
        <xs:element name=""title"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetCursusLijstResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Courses";
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
