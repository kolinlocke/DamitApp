using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer01_Common.Objects
{
    public abstract class ClsFilterItem
    {
        #region _Variables

        public String mFieldName;
        public String mFieldDesc;
        
        #endregion

        #region _Classes

        public class ClsFilterItem_Text : ClsFilterItem
        {
            public String mFilterValue;
        }

        public class ClsFilterItem_Number : ClsFilterItem
        {
            public String mFilterValue;
        }

        public class ClsFilterItem_Date : ClsFilterItem
        {
            public DateTime mFilterValue;
        }

        public class ClsFilterItem_Boolean : ClsFilterItem
        {
            public Boolean mFilterValue;
        }

        public class ClsFilterItem_Selection : ClsFilterItem
        {
            public List<Int64> mFilterValue;
        }

        #endregion
    }
}
