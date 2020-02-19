using System.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;

using mybudget.Repositories;

namespace mybudget
{
  public class Startup
  {
    private readonly string _connectionString = "";
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
      _connectionString = configuration.GetSection("DB").GetValue<string>("mySQLConnectionString");
    }

    readonly string AllowLocalHost = "This is the secret";

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors(options =>
      {
        options.AddPolicy(AllowLocalHost,
        builder =>
        {
          builder.WithOrigins("http://localhost:8100")
          .AllowAnyHeader()
          .AllowAnyMethod();
        });
      });
      services.AddControllers();
      services.AddTransient<IDbConnection>(x => CreateDBContext());
      services.AddMvc(option => option.EnableEndpointRouting = false);
      services.AddTransient<AccountsRepository>();
    }

    private IDbConnection CreateDBContext()
    {
      var connection = new MySqlConnection(_connectionString);
      connection.Open();
      return connection;
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

      app.UseCors(AllowLocalHost);

      // app.UseEndpoints(endpoints =>
      // {
      //   endpoints.MapControllers();
      // });
      app.UseMvc();
    }
  }
}
