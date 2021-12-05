using Consumer;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<KafkaConsumerHostedService>();
    })
    .Build();

await host.RunAsync();
