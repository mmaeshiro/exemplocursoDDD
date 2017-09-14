using CursoMVCAbril.Application;
using CursoMVCAbril.Application.Interface;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly;
using CursoMVCAbril.Domain.Interfaces.Services;
using CursoMVCAbril.Domain.Services;
using CursoMVCAbril.Infra.Data.Context;
using CursoMVCAbril.Infra.Data.Interface;
using CursoMVCAbril.Infra.Data.Repositories;
using CursoMVCAbril.Infra.Data.Repositories.ReadOnly;
using CursoMVCAbril.Infra.Data.UoW;
using Ninject.Modules;

namespace CursoMVCAbril.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            //APP
            Bind<IClienteAppService>().To<ClienteAppService>();


            //DOMAIN SERVICE
            Bind<IClienteService>().To<ClienteService>();


            //DATA
            Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();

            //Dat ReadOnly
            Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();

            //Data Config
            Bind<IContextManager>().To<ContextManager>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

        }
    }
}