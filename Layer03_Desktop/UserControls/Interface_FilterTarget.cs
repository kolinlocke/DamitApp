using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects_Framework.Objects;

namespace Layer03_Desktop.UserControls
{
    public interface Interface_FilterTarget
    {
        void ApplyFilter(QueryCondition Qc);
    }
}
