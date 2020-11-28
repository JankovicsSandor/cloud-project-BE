using cloud_project_Database.Database;
using cloud_project_Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cloud_project_BL.LocationUOW
{
    public class LocationBussinessLogic : ILocationBussinessLogic
    {
        private IExpressionDatabase _expressionDb;

        public LocationBussinessLogic(IExpressionDatabase expressionDatabase)
        {
            _expressionDb = expressionDatabase;
        }

        public void CreateNewLocation(CreateNewLocationModel newLocation)
        {
            _expressionDb.AddLocation(newLocation);
        }

        public IEnumerable<LocationListModel> GetAllLocationList()
        {
            return _expressionDb.Location.Select(item => new LocationListModel()
            {
                Id = item.Id,
                LocationName = item.LocationName,
                Name = item.Name
            });
        }

        public Location GetOneLocation(int locationId)
        {
            return _expressionDb.Location.FirstOrDefault(item => item.Id == locationId);
        }

        public void DeleteLocation(int locationID)
        {
            _expressionDb.DeleteLocation(locationID);
        }
    }
}
