using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Product.Infrastructure;
using Product.Infrastructure.Persistence.sql;

namespace Product
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var sessionFactory = NHibernateHelper.CreateSessionFactory();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}