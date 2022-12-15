using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TenmoServer.DAO;

namespace TenmoServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            // We made this to test if our GetBalance(userId) method worked
            /*TransferSqlDao transferSql = new TransferSqlDao(@"Server=.\SQLEXPRESS;Database=tenmo;Trusted_Connection=True");
            System.Console.WriteLine(transferSql.GetBalance(1001));*/

            // We made this to test if our TransferFunds() method worked
            /*TransferSqlDao transferSql = new TransferSqlDao(@"Server=.\SQLEXPRESS;Database=tenmo;Trusted_Connection=True");
            transferSql.TransferFunds(1001, 1002, 500);
            System.Console.WriteLine("1001: " + transferSql.GetBalance(1001)); // should be 500
            System.Console.WriteLine("1002 " + transferSql.GetBalance(1002)); // should be 1500*/
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
