using System.Collections.Generic;

namespace cloud_project_Database.Database
{
    public interface IExpressionDatabase
    {
        IList<Location> Location { get; }
        IList<FacialExpression> FacialExpression { get; }

        void AddLocation(Location newLocation);
        void DeleteLocation(int locationId);
        void UpdateLocationData(int locationId, LocationData newLocationData);
    }
}