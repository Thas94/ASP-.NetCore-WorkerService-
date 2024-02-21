using IMTSchedulerWorkerService;
using IMTSchedulerWorkerService.Entities.ClinicalEntities;
using IMTSchedulerWorkerService.Entities.Helpers;
using IMTSchedulerWorkerService.Services;
using IMTSchedulerWorkerService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<ISchedulerService, SchedulerService>();
        services.AddScoped<IIMTAPIService, IMTAPIService>();

        var ConnectionString = "Data Source=NCDCNSQLDEV01;Initial Catalog=clinical_Hl7IMT_ntcweb.co.za_data;User ID=ntcmasterdb;Password=anGAe5NgTe0bgLZwC1z";

        services.AddDbContext<clinicalHl7IMTntcwebcozadataContext>(options =>
        {
            options.UseSqlServer(ConnectionString, sqlServerOptionsAction: sqloptions =>
            {
                sqloptions.EnableRetryOnFailure(maxRetryCount: 60, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
                sqloptions.MaxBatchSize(20);
            });
        });

        services.AddScoped<clinicalHl7IMTntcwebcozadataContext>();
        services.AddSingleton<ClinicalEntityHelper>(); 
        services.AddSingleton<EntityHelper>();



    })
    .Build();

await host.RunAsync();
