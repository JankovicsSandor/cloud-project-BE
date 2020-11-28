using cloud_project_Database.Database;
using cloud_project_Shared;
using System.Collections.Generic;

namespace cloud_project_BL.LocationUOW
{
    public interface ILocationBussinessLogic
    {
        void CreateNewLocation(CreateNewLocationModel newLocation);
        void DeleteLocation(int locationID);
        IEnumerable<LocationListModel> GetAllLocationList();
        Location GetOneLocation(int locationId);
    }
}