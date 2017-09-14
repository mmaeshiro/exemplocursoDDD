using CursoMVCAbril.Infra.Data.Context;

namespace CursoMVCAbril.Infra.Data.Interface
{
    public interface IContextManager
    {
        CursoMvcContext GetContext();
    }
}