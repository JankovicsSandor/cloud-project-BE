using System;
using System.Collections.Generic;
using System.Text;

namespace cloud_project_Database.Database
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }

        public virtual IList<LocationData> LocationData { get; set; }

        public Location()
        { 
            LocationData=new List<LocationData>();
        }
    }
}
