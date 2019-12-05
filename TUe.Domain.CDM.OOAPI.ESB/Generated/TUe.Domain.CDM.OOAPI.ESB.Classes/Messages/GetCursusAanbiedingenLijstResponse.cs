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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferings", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferings {
        
        private byte pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        private byte pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private List<CourseOfferingsItems> _embeddedField;
        
        private CourseOfferings_links _linksField;
        
        private string codeField;
        
        private string titleField;
        
        public CourseOfferings() {
            this._linksField = new CourseOfferings_links();
            this._embeddedField = new List<CourseOfferingsItems>();
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
        public List<CourseOfferingsItems> _embedded {
            get {
                return this._embeddedField;
            }
            set {
                this._embeddedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferings_links _links {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferingsItems", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferingsItems {
        
        private string courseOfferingIdField;
        
        private object courseField;
        
        private uint maxNumberStudentsField;
        
        private bool maxNumberStudentsFieldSpecified;
        
        private uint currentNumberStudentsField;
        
        private bool currentNumberStudentsFieldSpecified;
        
        private string academicYearField;
        
        private string periodField;
        
        private CourseOfferingsItems_links _linksField;
        
        public CourseOfferingsItems() {
            this._linksField = new CourseOfferingsItems_links();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string courseOfferingId {
            get {
                return this.courseOfferingIdField;
            }
            set {
                this.courseOfferingIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object course {
            get {
                return this.courseField;
            }
            set {
                this.courseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint maxNumberStudents {
            get {
                return this.maxNumberStudentsField;
            }
            set {
                this.maxNumberStudentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool maxNumberStudentsSpecified {
            get {
                return this.maxNumberStudentsFieldSpecified;
            }
            set {
                this.maxNumberStudentsFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint currentNumberStudents {
            get {
                return this.currentNumberStudentsField;
            }
            set {
                this.currentNumberStudentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool currentNumberStudentsSpecified {
            get {
                return this.currentNumberStudentsFieldSpecified;
            }
            set {
                this.currentNumberStudentsFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string academicYear {
            get {
                return this.academicYearField;
            }
            set {
                this.academicYearField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferingsItems_links _links {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferingsItems_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferingsItems_links {
        
        private CourseOfferingsItems_linksSelf selfField;
        
        private CourseOfferingsItems_linksLecturers lecturersField;
        
        private CourseOfferingsItems_linksSchedules schedulesField;
        
        public CourseOfferingsItems_links() {
            this.schedulesField = new CourseOfferingsItems_linksSchedules();
            this.lecturersField = new CourseOfferingsItems_linksLecturers();
            this.selfField = new CourseOfferingsItems_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferingsItems_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferingsItems_linksLecturers lecturers {
            get {
                return this.lecturersField;
            }
            set {
                this.lecturersField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferingsItems_linksSchedules schedules {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferingsItems_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferingsItems_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferingsItems_linksLecturers", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferingsItems_linksLecturers {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferingsItems_linksSchedules", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferingsItems_linksSchedules {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferings_links", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferings_links {
        
        private CourseOfferings_linksSelf selfField;
        
        private CourseOfferings_linksPrev prevField;
        
        private CourseOfferings_linksNext nextField;
        
        public CourseOfferings_links() {
            this.nextField = new CourseOfferings_linksNext();
            this.prevField = new CourseOfferings_linksPrev();
            this.selfField = new CourseOfferings_linksSelf();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferings_linksSelf self {
            get {
                return this.selfField;
            }
            set {
                this.selfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferings_linksPrev prev {
            get {
                return this.prevField;
            }
            set {
                this.prevField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CourseOfferings_linksNext next {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferings_linksSelf", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferings_linksSelf {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferings_linksPrev", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferings_linksPrev {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseOfferings_linksNext", Namespace="http://TUe.Domain.CDM.OOAPI.Messages/CursusAanbiedingenLijst/1.0")]
    public partial class CourseOfferings_linksNext {
        
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
