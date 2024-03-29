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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculteiten", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class Faculteiten {
        
        private byte pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        private byte pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private List<FaculteitenItems> _embeddedField;
        
        private Faculteiten_links _linksField;
        
        private string codeField;
        
        private string titleField;
        
        public Faculteiten() {
            this._linksField = new Faculteiten_links();
            this._embeddedField = new List<FaculteitenItems>();
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
        public List<FaculteitenItems> _embedded {
            get {
                return this._embeddedField;
            }
            set {
                this._embeddedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Faculteiten_links _links {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems {
        
        private string facultyIdField;
        
        private string typeField;
        
        private string nameField;
        
        private string descriptionField;
        
        private FaculteitenItems_links _linksField;
        
        public FaculteitenItems() {
            this._linksField = new FaculteitenItems_links();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string facultyId {
            get {
                return this.facultyIdField;
            }
            set {
                this.facultyIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_links _links {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_links {
        
        private FaculteitenItems_linksSelf selfField;
        
        private FaculteitenItems_linksParentFaculty parentFacultyField;
        
        private FaculteitenItems_linksChildFaculties childFacultiesField;
        
        private FaculteitenItems_linksEducationalDepartments educationalDepartmentsField;
        
        private FaculteitenItems_linksEducationalPlans educationalPlansField;
        
        private FaculteitenItems_linksCourseGroups courseGroupsField;
        
        private FaculteitenItems_linksCourses coursesField;
        
        public FaculteitenItems_links() {
            this.coursesField = new FaculteitenItems_linksCourses();
            this.courseGroupsField = new FaculteitenItems_linksCourseGroups();
            this.educationalPlansField = new FaculteitenItems_linksEducationalPlans();
            this.educationalDepartmentsField = new FaculteitenItems_linksEducationalDepartments();
            this.childFacultiesField = new FaculteitenItems_linksChildFaculties();
            this.parentFacultyField = new FaculteitenItems_linksParentFaculty();
            this.selfField = new FaculteitenItems_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksParentFaculty parentFaculty {
            get {
                return this.parentFacultyField;
            }
            set {
                this.parentFacultyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksChildFaculties childFaculties {
            get {
                return this.childFacultiesField;
            }
            set {
                this.childFacultiesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksEducationalDepartments educationalDepartments {
            get {
                return this.educationalDepartmentsField;
            }
            set {
                this.educationalDepartmentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksEducationalPlans educationalPlans {
            get {
                return this.educationalPlansField;
            }
            set {
                this.educationalPlansField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksCourseGroups courseGroups {
            get {
                return this.courseGroupsField;
            }
            set {
                this.courseGroupsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FaculteitenItems_linksCourses courses {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksParentFaculty", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksParentFaculty {
        
        private string hrefField;
        
        private string titleField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksChildFaculties", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksChildFaculties {
        
        private string hrefField;
        
        private string titleField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksEducationalDepartments", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksEducationalDepartments {
        
        private string hrefField;
        
        private string titleField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksEducationalPlans", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksEducationalPlans {
        
        private string hrefField;
        
        private string titleField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksCourseGroups", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksCourseGroups {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaculteitenItems_linksCourses", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class FaculteitenItems_linksCourses {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculteiten_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class Faculteiten_links {
        
        private Faculteiten_linksSelf selfField;
        
        private Faculteiten_linksPrev prevField;
        
        private Faculteiten_linksNext nextField;
        
        public Faculteiten_links() {
            this.nextField = new Faculteiten_linksNext();
            this.prevField = new Faculteiten_linksPrev();
            this.selfField = new Faculteiten_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Faculteiten_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Faculteiten_linksPrev prev {
            get {
                return this.prevField;
            }
            set {
                this.prevField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Faculteiten_linksNext next {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculteiten_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class Faculteiten_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculteiten_linksPrev", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class Faculteiten_linksPrev {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculteiten_linksNext", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/FaculteitenLijst/1.0")]
    public partial class Faculteiten_linksNext {
        
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
