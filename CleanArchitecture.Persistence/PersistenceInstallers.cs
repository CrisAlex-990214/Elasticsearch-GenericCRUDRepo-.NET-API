using CleanArchitecture.Application.Interfaces;
using Elasticsearch.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace CleanArchitecture.Persistence
{
    public static class PersistenceInstallers
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var credentials = configuration.GetSection("Elastic");
            var settings = new ConnectionSettings(new Uri("https://localhost:9200"))
                .BasicAuthentication(credentials["user"], credentials["pass"])
                .ServerCertificateValidationCallback(CertificateValidations.AllowAll)
                .DefaultIndex("product");

            services.AddSingleton<IElasticClient>(new ElasticClient(settings));
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
        }
    }
}
