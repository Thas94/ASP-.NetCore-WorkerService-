using IMTSchedulerWorkerService.Services;
using IMTSchedulerWorkerService.Services.Interfaces;

namespace IMTSchedulerWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ISchedulerService _SchedulerService;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _SchedulerService = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ISchedulerService>();
        }

        public override Task StartAsync(CancellationToken stoppingToken)
        { 
            return base.StartAsync(stoppingToken);
        }

        public override Task StopAsync(CancellationToken stoppingToken)
        {
            return base.StopAsync(stoppingToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker Started at: {time}", DateTimeOffset.Now);

                var RunExceptions = await _SchedulerService.RunExceptions();

                //Timer set to 5 sec
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}