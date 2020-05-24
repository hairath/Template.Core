using Microsoft.Extensions.DependencyInjection;
using Template.Infraestrutura.Data.Context;
using Template.Infraestrutura.Data.Repositorio;
using Template.Infraestrutura.Dominio.Interfaces;

namespace Template.Infraestrutura.Container
{
    public class Container
    {
        public static void RegistroServicos(IServiceCollection servicos)
        {
            //Infra
            servicos.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioBase<>));
            servicos.AddScoped<EntityContext, EntityContext>();
        }
    }
}
