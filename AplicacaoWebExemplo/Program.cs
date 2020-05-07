using ConfiguracaoPersonalizada;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AplicacaoWebExemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureAppConfiguration((builderContext, config) =>
                {
                    config.AdicionarConfiguracaoPersonalizada(opcoes =>
                    {
                        // Aqui é o momento onde podemos passar os argumentos para
                        // o provedor das configurações personalizadas através da
                        // variável 'opcoes'.
                    });
                });
    }
}
