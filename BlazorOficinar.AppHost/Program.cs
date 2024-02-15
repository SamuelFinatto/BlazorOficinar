
var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var postgresdb = builder.AddPostgresContainer("pg")
                        .AddDatabase("postgresdb");

builder.Build().Run();