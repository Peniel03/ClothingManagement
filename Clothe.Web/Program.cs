using Clothe.Web.Extensions;
using Microsoft.Extensions.DependencyInjection;
using NLog;

var builder = WebApplication.CreateBuilder(args);
LogManager.Setup().LoadConfigurationFromFile("nlog.config");
//LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
//"/nlog.config"));
builder.Services.AddControllersWithViews();
builder.ConfigureApplicationServices(builder.Configuration);
var app = builder.Build();
app.Configure();
