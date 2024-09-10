using Microsoft.Extensions.Configuration;

namespace Modelo
{
    public static class ConnectionString
    {
        public static string GetConnectionString()
        {
            var _configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
     .Build();
            var cs = _configuration.GetSection("Connnectionstrings");
            var a = cs.GetSection("DAS_1");
            return a.Value;
        }
    }
}
