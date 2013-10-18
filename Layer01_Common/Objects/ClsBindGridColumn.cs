using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Layer01_Common;
using Layer01_Common.Common;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Layer01_Common.Objects
{
    [DataContract(Name = "BindGridColumn")]
    [Serializable()]
    public class ClsBindGridColumn
    {
        #region _Constructor

        public ClsBindGridColumn() { }

        public ClsBindGridColumn(string FieldName)
        { this.Setup(FieldName, FieldName); }

        public ClsBindGridColumn(string FieldName
            , string FieldDesc
            , Int32 Width = 100
            , string DataFormat = ""
            , Layer01_Constants.eSystem_Lookup_FieldType FieldType = Layer01_Constants.eSystem_Lookup_FieldType.FieldType_Static
            , Layer01_Constants.eSystem_Lookup_HorizontalAlign HorizontalAlign = Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_General
            , bool IsVisible = true
            , bool Enabled = true
            , bool IsFilter = true)
        {
            this.Setup(
                FieldName
                , FieldDesc
                , Width
                , DataFormat
                , FieldType
                , HorizontalAlign
                , IsVisible
                , Enabled
                , IsFilter);
        }

        #endregion

        #region _Methods

        protected virtual void Setup(
            string FieldName
            , string FieldDesc
            , Int32 Width = 100
            , string DataFormat = ""
            , Layer01_Constants.eSystem_Lookup_FieldType FieldType = Layer01_Constants.eSystem_Lookup_FieldType.FieldType_Static
            , Layer01_Constants.eSystem_Lookup_HorizontalAlign HorizontalAlign = Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_General
            , bool IsVisible = true
            , bool Enabled = true
            , bool IsFilter = true)
        {
            this.pFieldName = FieldName;
            this.pFieldDesc = FieldDesc;
            this.pColumnName = FieldName;
            this.pWidth = Width;
            this.pDataFormat = DataFormat;
            this.pFieldType = FieldType;
            this.pHorizontalAlign = HorizontalAlign;
            this.pIsVisible = IsVisible;
            this.pIsEnabled = Enabled;
            this.pIsFilter = IsFilter;
        }

        #endregion

        #region _Properties

        [XmlAttribute(AttributeName = "FieldName")]
        [DataMember(Name = "FieldName")]
        public String pFieldName { get; set; }

        [XmlAttribute(AttributeName = "FieldDesc")]
        [DataMember(Name = "FieldDesc")]
        public String pFieldDesc { get; set; }

        [XmlAttribute(AttributeName = "ColumnName")]
        [DataMember(Name = "ColumnName")]
        public String pColumnName { get; set; }

        [XmlAttribute(AttributeName = "Width")]
        [DataMember(Name = "Width")]
        public Int32 pWidth { get; set; }

        [XmlAttribute(AttributeName = "FieldType")]
        [DataMember(Name = "FieldType")]
        public Layer01_Constants.eSystem_Lookup_FieldType pFieldType { get; set; }

        [XmlAttribute(AttributeName = "HorizontalAlign")]
        [DataMember(Name = "HorizontalAlign")]
        public Layer01_Constants.eSystem_Lookup_HorizontalAlign pHorizontalAlign { get; set; }

        [XmlAttribute(AttributeName = "DataFormat")]
        [DataMember(Name = "DataFormat")]
        public String pDataFormat { get; set; }

        [XmlAttribute(AttributeName = "IsVisible")]
        [DataMember(Name = "IsVisible")]
        public Boolean pIsVisible { get; set; }

        [XmlAttribute(AttributeName = "IsEnabled")]
        [DataMember(Name = "IsEnabled")]
        public Boolean pIsEnabled { get; set; }

        [XmlAttribute(AttributeName = "IsFilter")]
        [DataMember(Name = "IsFilter")]
        public Boolean pIsFilter { get; set; }

        [XmlAttribute(AttributeName = "OrderIndex")]
        [DataMember(Name = "OrderIndex")]
        public Int32 pOrderIndex { get; set; }

        #endregion
    }

    [DataContract(Name = "BindGrid")]
    public class ClsBindGrid
    {
        #region _Variables

        List<ClsBindGridColumn> mColumns = new List<ClsBindGridColumn>();

        #endregion

        #region _Properties
        
        [XmlAttribute(AttributeName = "Name")]
        [DataMember(Name = "Name")]
        public String pName { get; set; }

        //[XmlIgnore()]
        //public String pTableName { get; set; }

        //[XmlIgnore()]
        //public String pTableKey { get; set; }

        //[XmlIgnore()]
        //public String pDesc { get; set; }

        //[XmlIgnore()]
        //public String pCondition { get; set; }

        //[XmlIgnore()]
        //public String pSort { get; set; }

        [XmlArray(ElementName = "Columns")]
        [XmlArrayItem(ElementName = "Column")]
        [DataMember(Name = "Column")]
        public List<ClsBindGridColumn> pColumns
        {
            get { return this.mColumns; }
            set { this.mColumns = value; }
        }

        public ClsBindGridColumn pColumn_Get(String FieldName)
        { return this.pColumns.FirstOrDefault(O => O.pFieldName == FieldName); }

        #endregion
    }
}
