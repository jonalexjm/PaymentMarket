using Microsoft.EntityFrameworkCore;
using PaymentMarket.Core.Entities;
using PaymentMarket.Core.Services;
using PaymentMarket.Infrastructure.Data;

namespace PaymentMarket.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using PaymentMarket.Core.Interfaces;
    using PaymentMarket.Infrastructure.Repositories;
    using Microsoft.AspNetCore.Mvc;
    using PaymentMarket.Infrastructure.Data.Seed;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<PaymentMarketContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"));
                //configuracion del servidor
            });

            services.AddTransient<SeedDb>();
            services.AddTransient<ITypeDocumentService, TypeDocumentService>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddApiVersioning(cfg =>
            {
                cfg.DefaultApiVersion = new ApiVersion(1, 0);
                cfg.AssumeDefaultVersionWhenUnspecified = true;
                cfg.ReportApiVersions = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
