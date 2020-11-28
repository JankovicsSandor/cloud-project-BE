using System;
using System.Collections.Generic;
using System.Text;

namespace cloud_project_Database.Database
{
    public class LocationData
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int LocationId { get; set; }
        public int FacialExpressionTypeId { get; set; }
        public int Value { get; set; }

        public virtual Location Location { get; set; }
        public virtual FacialExpression FacialExpression { get; set; }
    }
}
