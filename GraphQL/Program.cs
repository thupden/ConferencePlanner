using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//services
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("ConferencePlanner"))
    );

builder.Services
    .AddGraphQLServer()
    .AddGraphQLTypes();

var app = builder.Build();

//middleware
app.MapGraphQL();

await app.RunWithGraphQLCommandsAsync(args);
