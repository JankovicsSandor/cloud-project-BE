using cloud_project_Database.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace cloud_project_BL
{
    public class LocationBussinessLogic
    {
        private IExpressionDatabase _expressionDb;

        public LocationBussinessLogic(IExpressionDatabase expressionDatabase)
        {
            _expressionDb = expressionDatabase;
        }
    }
}
