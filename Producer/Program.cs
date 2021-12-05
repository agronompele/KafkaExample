using Producer;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<KafkaProducerHostedService>();
    })
    .Build();

await host.RunAsync();
