using Hubs;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<Worker>();

builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");

// app.MapHub<ChatHub>("/hub");

app.MapHub<ClockHub>("/clockhub");

app.Run();
