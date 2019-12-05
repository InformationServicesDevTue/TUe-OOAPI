namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0",@"Faculteiten")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Faculteiten"})]
    public sealed class GetFaculteitenLijstResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Faculteiten"">
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
                    <xs:element minOccurs=""0"" name=""facultyId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""type"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""name"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""description"" type=""xs:string"" />
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
                          <xs:element minOccurs=""0"" name=""parentFaculty"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""childFaculties"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""educationalDepartments"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""educationalPlans"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""title"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""courseGroups"">
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
        <xs:element name=""code"" type=""xs:string"" />
        <xs:element name=""title"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetFaculteitenLijstResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Faculteiten";
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
