namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0",@"CourseOfferings")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CourseOfferings"})]
    public sealed class GetCursusAanbiedingenLijstResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CourseOfferings"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""pageSize"" type=""xs:unsignedByte"" />
        <xs:element minOccurs=""0"" name=""pageNumber"" type=""xs:unsignedByte"" />
        <xs:element minOccurs=""0"" name=""_embedded"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""items"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""courseOfferingId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""course"" type=""xs:anyType"" />
                    <xs:element minOccurs=""0"" name=""maxNumberStudents"" type=""xs:unsignedInt"" />
                    <xs:element minOccurs=""0"" name=""currentNumberStudents"" type=""xs:unsignedInt"" />
                    <xs:element minOccurs=""0"" name=""academicYear"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""period"" type=""xs:string"" />
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
                          <xs:element minOccurs=""0"" name=""lecturers"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""schedules"">
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
        <xs:element name=""code"" type=""xs:string"" />
        <xs:element name=""title"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetCursusAanbiedingenLijstResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CourseOfferings";
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
