using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using cloud_project_Database.Database;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace cloud_project_BackgroundWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IRandomDataGenerator _dataGenerator;

        public Worker(ILogger<Worker> logger, IRandomDataGenerator dataGenerator)
        {
            _logger = logger;
            _dataGenerator = dataGenerator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _dataGenerator.GenerateRandomData();
                await Task.Delay(TimeSpan.FromMinutes(2), stoppingToken);
            }
        }
    }
}
