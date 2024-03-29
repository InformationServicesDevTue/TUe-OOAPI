// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.20270 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>TUe.Domain.CDM.OOAPI.ESB.Messages.Classes</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TUe.Domain.CDM.OOAPI.ESB.Messages.Classes {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class Persons {
        
        private byte pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        private byte pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private List<PersonsItems> _embeddedField;
        
        private Persons_links _linksField;
        
        private string codeField;
        
        private string titleField;
        
        public Persons() {
            this._linksField = new Persons_links();
            this._embeddedField = new List<PersonsItems>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                this.pageSizeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool pageSizeSpecified {
            get {
                return this.pageSizeFieldSpecified;
            }
            set {
                this.pageSizeFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte pageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                this.pageNumberField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool pageNumberSpecified {
            get {
                return this.pageNumberFieldSpecified;
            }
            set {
                this.pageNumberFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("items", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<PersonsItems> _embedded {
            get {
                return this._embeddedField;
            }
            set {
                this._embeddedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Persons_links _links {
            get {
                return this._linksField;
            }
            set {
                this._linksField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems {
        
        private string personIdField;
        
        private string givenNameField;
        
        private string surnamePrefixField;
        
        private string surnameField;
        
        private string displayNameField;
        
        private System.DateTime dateOfBirthField;
        
        private bool dateOfBirthFieldSpecified;
        
        private string affiliationsField;
        
        private string mailField;
        
        private string telephoneNumberField;
        
        private string mobileNumberField;
        
        private string photoSocialField;
        
        private string photoOfficialField;
        
        private string genderField;
        
        private string titleField;
        
        private string officeField;
        
        private PersonsItems_links _linksField;
        
        public PersonsItems() {
            this._linksField = new PersonsItems_links();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string personId {
            get {
                return this.personIdField;
            }
            set {
                this.personIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string givenName {
            get {
                return this.givenNameField;
            }
            set {
                this.givenNameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surnamePrefix {
            get {
                return this.surnamePrefixField;
            }
            set {
                this.surnamePrefixField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool dateOfBirthSpecified {
            get {
                return this.dateOfBirthFieldSpecified;
            }
            set {
                this.dateOfBirthFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string affiliations {
            get {
                return this.affiliationsField;
            }
            set {
                this.affiliationsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                this.mailField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobileNumber {
            get {
                return this.mobileNumberField;
            }
            set {
                this.mobileNumberField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string photoSocial {
            get {
                return this.photoSocialField;
            }
            set {
                this.photoSocialField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string photoOfficial {
            get {
                return this.photoOfficialField;
            }
            set {
                this.photoOfficialField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string office {
            get {
                return this.officeField;
            }
            set {
                this.officeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_links _links {
            get {
                return this._linksField;
            }
            set {
                this._linksField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_links {
        
        private PersonsItems_linksSelf selfField;
        
        private PersonsItems_linksEducationalDepartments educationalDepartmentsField;
        
        private PersonsItems_linksEducationalPlans educationalPlansField;
        
        private PersonsItems_linksCourseGroups courseGroupsField;
        
        private PersonsItems_linksCourses coursesField;
        
        private PersonsItems_linksCourseResults courseResultsField;
        
        private PersonsItems_linksTestResults testResultsField;
        
        private PersonsItems_linksSchedules schedulesField;
        
        public PersonsItems_links() {
            this.schedulesField = new PersonsItems_linksSchedules();
            this.testResultsField = new PersonsItems_linksTestResults();
            this.courseResultsField = new PersonsItems_linksCourseResults();
            this.coursesField = new PersonsItems_linksCourses();
            this.courseGroupsField = new PersonsItems_linksCourseGroups();
            this.educationalPlansField = new PersonsItems_linksEducationalPlans();
            this.educationalDepartmentsField = new PersonsItems_linksEducationalDepartments();
            this.selfField = new PersonsItems_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksEducationalDepartments educationalDepartments {
            get {
                return this.educationalDepartmentsField;
            }
            set {
                this.educationalDepartmentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksEducationalPlans educationalPlans {
            get {
                return this.educationalPlansField;
            }
            set {
                this.educationalPlansField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksCourseGroups courseGroups {
            get {
                return this.courseGroupsField;
            }
            set {
                this.courseGroupsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksCourses courses {
            get {
                return this.coursesField;
            }
            set {
                this.coursesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksCourseResults courseResults {
            get {
                return this.courseResultsField;
            }
            set {
                this.courseResultsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksTestResults testResults {
            get {
                return this.testResultsField;
            }
            set {
                this.testResultsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonsItems_linksSchedules schedules {
            get {
                return this.schedulesField;
            }
            set {
                this.schedulesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksSelf {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksEducationalDepartments", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksEducationalDepartments {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksEducationalPlans", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksEducationalPlans {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksCourseGroups", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksCourseGroups {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksCourses", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksCourses {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksCourseResults", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksCourseResults {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksTestResults", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksTestResults {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsItems_linksSchedules", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class PersonsItems_linksSchedules {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class Persons_links {
        
        private Persons_linksSelf selfField;
        
        private Persons_linksPrev prevField;
        
        private Persons_linksNext nextField;
        
        public Persons_links() {
            this.nextField = new Persons_linksNext();
            this.prevField = new Persons_linksPrev();
            this.selfField = new Persons_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Persons_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Persons_linksPrev prev {
            get {
                return this.prevField;
            }
            set {
                this.prevField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Persons_linksNext next {
            get {
                return this.nextField;
            }
            set {
                this.nextField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class Persons_linksSelf {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons_linksPrev", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class Persons_linksPrev {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons_linksNext", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/PersonenLijst/1.0")]
    public partial class Persons_linksNext {
        
        private string hrefField;
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
}
