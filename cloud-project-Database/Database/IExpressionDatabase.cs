using cloud_project_Shared;
using System.Collections.Generic;

namespace cloud_project_Database.Database
{
    public interface IExpressionDatabase
    {
        IList<Location> Location { get; }
        IList<FacialExpression> FacialExpression { get; }

        Location AddLocation(CreateNewLocationModel newLocation);
        void DeleteLocation(int locationId);
        void UpdateLocationData(int locationId, LocationData newLocationData);
    }
}