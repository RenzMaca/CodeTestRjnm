using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTestRjnm.CodeTestData;
using CodeTestRjnm.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CodeTestRjnm
{
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

            services.AddDbContextPool<AccountContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CodeTestRjnmConnectionString")));
            services.AddDbContextPool<PaymentHistoryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CodeTestRjnmConnectionString")));

            services.AddScoped<IAccountData, SqlAccountData>();
            services.AddScoped<IPaymentHistoryData, SqlPaymentHistoryData>();
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
