namespace TUe.Domain.CDM.OOAPI.ESB.Schemas.messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0",@"OOAPIRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Endpoint), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Endpoint' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.ItemId), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='ItemId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.PageSize), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='pageSize' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.PageNumber), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='pageNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Student), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Student' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Faculty), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Faculty' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.EducationalDepartment), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='educationalDepartment' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.EducationalPlan), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='educationalPlan' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.EducationalProgramme), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='EducationalProgramme' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.CourseGroup), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='courseGroup' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Course), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Course' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Order), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Order' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Lecturer), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Lecturer' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.Affiliation), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Affiliation' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.DisplayName), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='DisplayName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.SurName), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='SurName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.type), XPath = @"/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='type' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OOAPIRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.PropertySchema", typeof(global::TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.PropertySchema))]
    public sealed class GetOOAPIGenericRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema"" targetNamespace=""http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema"" location=""TUe.Domain.CDM.OOAPI.ESB.Schemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OOAPIRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Endpoint"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Endpoint' and namespace-uri()='']"" />
          <b:property name=""ns0:ItemId"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='ItemId' and namespace-uri()='']"" />
          <b:property name=""ns0:PageSize"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='pageSize' and namespace-uri()='']"" />
          <b:property name=""ns0:PageNumber"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='pageNumber' and namespace-uri()='']"" />
          <b:property name=""ns0:Student"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Student' and namespace-uri()='']"" />
          <b:property name=""ns0:Faculty"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Faculty' and namespace-uri()='']"" />
          <b:property name=""ns0:EducationalDepartment"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='educationalDepartment' and namespace-uri()='']"" />
          <b:property name=""ns0:EducationalPlan"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='educationalPlan' and namespace-uri()='']"" />
          <b:property name=""ns0:EducationalProgramme"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='EducationalProgramme' and namespace-uri()='']"" />
          <b:property name=""ns0:CourseGroup"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='courseGroup' and namespace-uri()='']"" />
          <b:property name=""ns0:Course"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Course' and namespace-uri()='']"" />
          <b:property name=""ns0:Order"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Order' and namespace-uri()='']"" />
          <b:property name=""ns0:Lecturer"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Lecturer' and namespace-uri()='']"" />
          <b:property name=""ns0:Affiliation"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='Affiliation' and namespace-uri()='']"" />
          <b:property name=""ns0:DisplayName"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='DisplayName' and namespace-uri()='']"" />
          <b:property name=""ns0:SurName"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='SurName' and namespace-uri()='']"" />
          <b:property name=""ns0:type"" xpath=""/*[local-name()='OOAPIRequest' and namespace-uri()='http://TUe.Domain.CDM.OOAPI.Messages/GenericRequest/1.0']/*[local-name()='Parameters' and namespace-uri()='']/*[local-name()='type' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""Root"" name=""Endpoint"" type=""xs:string"" />
        <xs:element default=""geen"" name=""ItemId"" type=""xs:string"" />
        <xs:element name=""Parameters"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""pageSize"" type=""xs:string"" />
              <xs:element name=""pageNumber"" type=""xs:string"" />
              <xs:element name=""Student"" type=""xs:string"" />
              <xs:element name=""Faculty"" type=""xs:string"" />
              <xs:element name=""educationalDepartment"" type=""xs:string"" />
              <xs:element name=""educationalPlan"" type=""xs:string"" />
              <xs:element name=""EducationalProgramme"" type=""xs:string"" />
              <xs:element name=""courseGroup"" type=""xs:string"" />
              <xs:element name=""Course"" type=""xs:string"" />
              <xs:element name=""Order"" type=""xs:string"" />
              <xs:element name=""Lecturer"" type=""xs:string"" />
              <xs:element name=""Affiliation"" type=""xs:string"" />
              <xs:element name=""DisplayName"" type=""xs:string"" />
              <xs:element name=""SurName"" type=""xs:string"" />
              <xs:element name=""type"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetOOAPIGenericRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OOAPIRequest";
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
