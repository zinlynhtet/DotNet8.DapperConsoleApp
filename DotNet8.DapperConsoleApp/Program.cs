var service = new ServiceCollection().AddScoped<Connection>().AddScoped<DapperExample>().BuildServiceProvider();

DapperExample dapper = service.GetRequiredService<DapperExample>();
dapper.Run();