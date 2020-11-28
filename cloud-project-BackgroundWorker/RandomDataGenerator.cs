using cloud_project_Database.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace cloud_project_BackgroundWorker
{
    public class RandomDataGenerator : IRandomDataGenerator
    {
        private Random random = new Random();
        private IExpressionDatabase _expressionDatabase;

        public RandomDataGenerator(IExpressionDatabase expressionDb)
        {
            _expressionDatabase = expressionDb;
        }

        public void GenerateRandomData()
        {
            foreach (var oneLocation in _expressionDatabase.Location)
            {
                foreach (var faceExpression in _expressionDatabase.FacialExpression)
                {
                    LocationData newData = new LocationData() { LocationId = oneLocation.Id };
                    // Generate data only in 50% cases
                    if (random.Next(0, 1000) > 500)
                    {
                        newData.FacialExpressionTypeId = faceExpression.Id;
                        newData.FacialExpression = faceExpression;
                        newData.Value = random.Next(1, 10);
                        newData.Time = DateTime.Now;
                        _expressionDatabase.UpdateLocationData(oneLocation.Id, newData);
                    }
                }

            }
        }
    }
}
