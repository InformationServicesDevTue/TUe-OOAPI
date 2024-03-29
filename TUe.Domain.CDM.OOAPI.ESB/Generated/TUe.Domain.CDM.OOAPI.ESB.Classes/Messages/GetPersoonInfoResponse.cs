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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person {
        
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
        
        private Person_links _linksField;
        
        private string codeField;
        
        public Person() {
            this._linksField = new Person_links();
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
        public Person_links _links {
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_links {
        
        private Person_linksSelf selfField;
        
        private Person_linksEducationalDepartments educationalDepartmentsField;
        
        private Person_linksEducationalPlans educationalPlansField;
        
        private Person_linksCourseGroups courseGroupsField;
        
        private Person_linksCourses coursesField;
        
        private Person_linksCourseResults courseResultsField;
        
        private Person_linksTestResults testResultsField;
        
        private Person_linksSchedules schedulesField;
        
        public Person_links() {
            this.schedulesField = new Person_linksSchedules();
            this.testResultsField = new Person_linksTestResults();
            this.courseResultsField = new Person_linksCourseResults();
            this.coursesField = new Person_linksCourses();
            this.courseGroupsField = new Person_linksCourseGroups();
            this.educationalPlansField = new Person_linksEducationalPlans();
            this.educationalDepartmentsField = new Person_linksEducationalDepartments();
            this.selfField = new Person_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksEducationalDepartments educationalDepartments {
            get {
                return this.educationalDepartmentsField;
            }
            set {
                this.educationalDepartmentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksEducationalPlans educationalPlans {
            get {
                return this.educationalPlansField;
            }
            set {
                this.educationalPlansField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksCourseGroups courseGroups {
            get {
                return this.courseGroupsField;
            }
            set {
                this.courseGroupsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksCourses courses {
            get {
                return this.coursesField;
            }
            set {
                this.coursesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksCourseResults courseResults {
            get {
                return this.courseResultsField;
            }
            set {
                this.courseResultsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksTestResults testResults {
            get {
                return this.testResultsField;
            }
            set {
                this.testResultsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Person_linksSchedules schedules {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksEducationalDepartments", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksEducationalDepartments {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksEducationalPlans", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksEducationalPlans {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksCourseGroups", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksCourseGroups {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksCourses", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksCourses {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksCourseResults", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksCourseResults {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksTestResults", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksTestResults {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person_linksSchedules", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/Persoon/1.0")]
    public partial class Person_linksSchedules {
        
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
