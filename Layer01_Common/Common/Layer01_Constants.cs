using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects_Framework.Common;

namespace Layer01_Common.Common
{
    public class Layer01_Constants
    {
        public const String CnsRegistryKey = @"Software\Damit";
        public const String CnsConnectionString_Cache = "CnsConnectionString_Cache";
        public static String CnsPathAppRoot = Do_Methods.SetFolderPath(Do_Methods.SetFolderPath(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + CnsRegistryKey);
        public static String CnsPathDatabaseCfg = CnsPathAppRoot + "DatabaseCfg.xml";
        public static String CnsPathGridCfg = CnsPathAppRoot + "GridCfg.xml";
        public static String CnsPathGridCfgSchema = CnsPathAppRoot + "GridSchemaCfg.xml";

        public enum eSystem_Modules : long
        {
            None = 0,
            Sys_Login = 1,
            Mayari = 2
        }

        public enum eAccessLib : int
        {
            None = 0,
            eSystem_Modules_AccessLib_Access = 1,
            eSystem_Modules_AccessLib_New = 2,
            eSystem_Modules_AccessLib_Edit = 3,
            eSystem_Modules_AccessLib_Delete = 4,
            eSystem_Modules_AccessLib_View = 5,
            eSystem_Modules_AccessLib_Approve = 6,
            eSystem_Modules_AccessLib_Post = 7,
            eSystem_Modules_AccessLib_Cancel = 8
        }

        public enum eLookup : int
        { 
            None = 0
            , CallTopic = 1
            , Category = 2
            , ClientType = 3
            , CostDeductionType = 4
            , Country = 5
            , Currency = 6
            , DeliveryMethod = 7
            , Department = 8
            , EmployeeType = 9
            , InvoiceType = 10
            , ItemType = 11
            , OrderType = 12
            , Payee_Type = 13
            , PaymentTerm = 14
            , PayRate = 15
            , ShipVia = 16
            , States = 17
            , UOM = 18
            , TaxCode = 19
            , Warehouse = 20
            , PriceDiscount = 21
            , Brand = 22
            , Retailer = 23
            , ShippingCost = 24
            , LeaveType = 25
        }

        public enum eSystem_Lookup : int
        {
            None = 0,
            FieldType_Static = 1,
            FieldType_Text = 2,
            FieldType_Checkbox = 3,
            FieldType_DateTime = 4,
            FieldType_Button = 5,
            FieldType_Delete = 6,
            Gender_Male = 7,
            Gender_Female = 8,
            CivilStatus_Single = 9,
            CivilStatus_Married = 10,
            CivilStatus_Widowed = 11,
            Grid_HorizontalAlign_Center = 12,
            Grid_HorizontalAlign_Far = 13,
            Grid_HorizontalAlign_General = 14,
            Grid_HorizontalAlign_Justify = 15,
            Grid_HorizontalAlign_Near = 16
        }
        
        public enum eSystem_Lookup_FieldType : int
        { 
            None = eSystem_Lookup.None
            , FieldType_Static = eSystem_Lookup.FieldType_Static
            , FieldType_Text = eSystem_Lookup.FieldType_Text
            , FieldType_Checkbox = eSystem_Lookup.FieldType_Checkbox
            , FieldType_DateTime = eSystem_Lookup.FieldType_DateTime
            , FieldType_Button = eSystem_Lookup.FieldType_Button
            , FieldType_Delete = eSystem_Lookup.FieldType_Delete
        }

        public enum eSystem_Lookup_HorizontalAlign : int
        {
            Grid_HorizontalAlign_Center = eSystem_Lookup.Grid_HorizontalAlign_Center,
            Grid_HorizontalAlign_Far = eSystem_Lookup.Grid_HorizontalAlign_Far,
            Grid_HorizontalAlign_General = eSystem_Lookup.Grid_HorizontalAlign_General,
            Grid_HorizontalAlign_Justify = eSystem_Lookup.Grid_HorizontalAlign_Justify,
            Grid_HorizontalAlign_Near = eSystem_Lookup.Grid_HorizontalAlign_Near
        }

        public enum eSystem_LookupPartyType: int
        {
            None = 0,
            Employee = 1,
            Customer = 2,
            Supplier = 3,
            Warehouse = 4,
            Bank = 5
        }

        public struct Str_AddSelectedFields
        {
            public string Field_Target;
            public string Field_Selected;

            public Str_AddSelectedFields(string pField_Target, string pField_Selected)
            {
                Field_Target = pField_Target;
                Field_Selected = pField_Selected;
            }
        }

        public struct Str_AddSelectedFieldsDefault
        {
            public string Field_Target;
            public object Value;

            public Str_AddSelectedFieldsDefault(string pField_Target, object pValue)
            {
                Field_Target = pField_Target;
                Value = pValue;
            }
        }
    }
}
