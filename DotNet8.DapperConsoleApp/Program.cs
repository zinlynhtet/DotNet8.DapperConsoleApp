var service = new ServiceCollection().AddScoped<Connection>().AddScoped<DapperService>().BuildServiceProvider();

DapperService dapper = service.GetRequiredService<DapperService>();
dapper.Run();