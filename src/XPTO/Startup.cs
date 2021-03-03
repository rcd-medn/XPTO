



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XPTO.Data;

namespace XPTO
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ============================================================================================================================
            // Adiciona suporte ao uso de somente "Controllers" e não a Views e Pages.
            // ============================================================================================================================
            services.AddControllers();

            // ============================================================================================================================
            // Registra o serviço (classe) necessário para a aplicação.
            // ============================================================================================================================
            services.AddScoped<IClienteAPIRepository, MockClienteAPIRepository>();

            // ============================================================================================================================
            // Registra o serviço (classe) DBContext para acessar o banco de dados.
            // ============================================================================================================================
            services.AddDbContext<XPTOContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("XPTO"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // ========================================================================================================================
                // Adiciona endpoints para as actions do controller sem especificar qualquer rota.
                // ========================================================================================================================
                endpoints.MapControllers();
            });
        }
    }
}
