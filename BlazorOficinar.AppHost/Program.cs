
var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedisContainer("cache");

//var postgresdb = builder.AddPostgresContainer("pg")
//                        .AddDatabase("postgresdb");

builder.AddProject<Projects.OficinarBackEnd>("oficinarbackend");
builder.AddProject<Projects.BlazorOficinar>("oficinarfrontend");

builder.Build().Run();