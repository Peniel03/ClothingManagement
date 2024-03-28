using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Extensions;
using Service.Abstractions;
using Services.AppServices;
using Services.Logger;
using System.Configuration;

namespace Clothe.Web.Extensions
{
    /// <summary>
    /// app services configuration
    /// </summary>
    public partial class AppDependenciesConfiguration
    {
        public static WebApplicationBuilder ConfigureApplicationServices(this WebApplicationBuilder builder, IConfiguration configuration)
        {

            builder.Services.AddIdentityServiceConfiguration(x =>
            {
                x.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            })
            .AddRepositories()
            .AddSingleton<ILoggerManager, LoggerManager>()
            .AddScoped<IServiceManager, ServiceManager>()
            ;
            //.AddAutoMapper(typeof(UserProfile), typeof(ClaimProfile))
            //.AddScoped<IAccountService, AccountService>()
            //.AddScoped<IAuthorizationService, AuthorizationService>()
            //.AddScoped<ISessionService, SessionService>()
            //.AddScoped<SeedUserRolesData>()
            //.AddValidatorsFromAssemblyContaining<UserCreateValidator>()
            //.AddFluentValidationAutoValidation();

            builder.Services.AddExceptionHandler(options =>
            {
                options.ExceptionHandlingPath = "/Error";
              
            });
            builder.Services.AddMvc();
            //builder.Services.Configure<MySettingsModel>(Configuration.GetSection("MySettings"));
            return builder;
        }

        public static void Configure(this WebApplication app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                 app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRouting();
            app.MapControllers();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}
