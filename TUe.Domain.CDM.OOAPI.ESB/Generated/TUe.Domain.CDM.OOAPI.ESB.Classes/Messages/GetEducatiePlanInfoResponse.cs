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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationalPlan", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    public partial class EducationalPlan {
        
        private string educationalPlanIdField;
        
        private string nameField;
        
        private string descriptionField;
        
        private System.DateTime termStartDateField;
        
        private bool termStartDateFieldSpecified;
        
        private System.DateTime termEndDateField;
        
        private bool termEndDateFieldSpecified;
        
        private uint ectsField;
        
        private bool ectsFieldSpecified;
        
        private uint earnedEctsField;
        
        private bool earnedEctsFieldSpecified;
        
        private string mainLanguageField;
        
        private EducationalPlan_links _linksField;
        
        private string codeField;
        
        private string titleField;
        
        public EducationalPlan() {
            this._linksField = new EducationalPlan_links();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string educationalPlanId {
            get {
                return this.educationalPlanIdField;
            }
            set {
                this.educationalPlanIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime termStartDate {
            get {
                return this.termStartDateField;
            }
            set {
                this.termStartDateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool termStartDateSpecified {
            get {
                return this.termStartDateFieldSpecified;
            }
            set {
                this.termStartDateFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime termEndDate {
            get {
                return this.termEndDateField;
            }
            set {
                this.termEndDateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool termEndDateSpecified {
            get {
                return this.termEndDateFieldSpecified;
            }
            set {
                this.termEndDateFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint ects {
            get {
                return this.ectsField;
            }
            set {
                this.ectsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ectsSpecified {
            get {
                return this.ectsFieldSpecified;
            }
            set {
                this.ectsFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint earnedEcts {
            get {
                return this.earnedEctsField;
            }
            set {
                this.earnedEctsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool earnedEctsSpecified {
            get {
                return this.earnedEctsFieldSpecified;
            }
            set {
                this.earnedEctsFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mainLanguage {
            get {
                return this.mainLanguageField;
            }
            set {
                this.mainLanguageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EducationalPlan_links _links {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationalPlan_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    public partial class EducationalPlan_links {
        
        private EducationalPlan_linksSelf selfField;
        
        private EducationalPlan_linksCourseGroups courseGroupsField;
        
        private EducationalPlan_linksCourses coursesField;
        
        public EducationalPlan_links() {
            this.coursesField = new EducationalPlan_linksCourses();
            this.courseGroupsField = new EducationalPlan_linksCourseGroups();
            this.selfField = new EducationalPlan_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EducationalPlan_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EducationalPlan_linksCourseGroups courseGroups {
            get {
                return this.courseGroupsField;
            }
            set {
                this.courseGroupsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EducationalPlan_linksCourses courses {
            get {
                return this.coursesField;
            }
            set {
                this.coursesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.20270")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationalPlan_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    public partial class EducationalPlan_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationalPlan_linksCourseGroups", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    public partial class EducationalPlan_linksCourseGroups {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationalPlan_linksCourses", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/EducatiePlanInfo/1.0")]
    public partial class EducationalPlan_linksCourses {
        
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
