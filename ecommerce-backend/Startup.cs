
using Backend.Config;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Backend.Domain.Connection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Backend.Domain.Migrations;
using MongoDB.Driver;


namespace ecommerce_backend 
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                Console.WriteLine("Development");
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ApplyMigrations(app);


        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração da conexão com o MongoDB
            services.Configure<DatabaseSettings>(
                Configuration.GetSection(nameof(DatabaseSettings)));

            services.AddSingleton<IDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);
            // Configuração de autenticação
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecretKey"))
                    };
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ecommerce-backend", Version = "v1" });

                // Configura o Swagger para usar o esquema de autenticação Bearer
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Bearer token authorization header using the Bearer scheme.",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
            });

            services.ResolveDependencies();
            // Configuração de autorização
            services.AddAuthorization();

            // Adiciona os serviços MVC ou de controlador
            services.AddControllers();

        }


        private void ConfigureDatabase(IServiceCollection services)
        {
            services.Configure<DatabaseSettings>(
               Configuration.GetSection(nameof(DatabaseSettings)));

            services.AddSingleton<IDatabaseSettings>(sp =>
               sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);
        }

        private void ApplyMigrations(IApplicationBuilder app)
        {

            var serviceProvider = app.ApplicationServices;
            var databaseSettings = serviceProvider.GetRequiredService<IDatabaseSettings>();
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);

            var migration = new Migration();
            migration.Down(database);
            migration.Up(database);
        }
    }
}
