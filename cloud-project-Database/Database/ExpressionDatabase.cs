using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cloud_project_Database.Database
{
    public class ExpressionDatabase : IExpressionDatabase
    {
        private IList<Location> location = new List<Location>();
        private IList<FacialExpression> facialExpression = new List<FacialExpression>();

        public IList<FacialExpression> FacialExpression
        {
            get
            {
                return new List<FacialExpression>()
                {
                    new FacialExpression()
                    {
                        Id=1,
                        Name="Happiness",
                    },
                    new FacialExpression()
                    {
                        Id=2,
                        Name="Fear",
                    },
                    new FacialExpression()
                    {
                        Id=3,
                        Name="Suprise",
                    }
                };
            }
        }



        public IList<Location> Location
        {
            get { return location; }
            private set { location = value; }
        }

        public void AddLocation(Location newLocation)
        {
            location.Add(newLocation);
        }

        public void UpdateLocationData(int locationId, LocationData newLocationData)
        {
            Location locationToUpdate = location.FirstOrDefault(e => e.Id == locationId);
            if (!(locationToUpdate is null))
            {
                locationToUpdate.LocationData.Add(newLocationData);
            }

        }

        public void DeleteLocation(int locationId)
        {
            Location locationToDelete = location.FirstOrDefault(e => e.Id == locationId);
            if (!(locationToDelete is null))
            {
                location.Remove(locationToDelete);
            }
        }

    }
}
