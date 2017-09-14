using CursoMVCAbril.Application;
using CursoMVCAbril.Application.Interface;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly;
using CursoMVCAbril.Domain.Interfaces.Services;
using CursoMVCAbril.Domain.Services;
using CursoMVCAbril.Infra.Data.Repositories;
using CursoMVCAbril.Infra.Data.Repositories.ReadOnly;
using SimpleInjector;

namespace CursoMVCAbril.Infra.CrossCutting.SimpleInjector
{
    public static class SimpleInjector
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            //Registrando as implementações

            //APP
            container.Register<IClienteAppService,ClienteAppService>();

            //DOMAIN
            container.Register<IClienteService,ClienteService>();

            //DATA
            container.Register<IClienteRepository,ClienteRepository>();
            container.Register<IEnderecoRepository,EnderecoRepository>();

            //ReadOnly
            container.Register<IClienteReadOnlyRepository,ClienteReadOnlyRepository>();

            container.Verify();

            return container;
        }
    }
}