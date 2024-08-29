var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.UserMicroService_API>("usermicroservice-api");

builder.Build().Run();
