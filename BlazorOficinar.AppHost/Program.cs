using BlazorOficinar.ServiceDefaults.Models;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var postgresdb = builder.AddPostgresContainer("pg")
                        .AddDatabase("postgresdb");

builder.AddProject<Projects.BlazorOficinar>("oficinar")
    .WithReference(cache)
    .WithReference(postgresdb);

builder.Build().Run();