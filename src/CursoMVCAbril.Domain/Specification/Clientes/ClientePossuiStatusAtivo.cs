using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Interfaces.Specification;

namespace CursoMVCAbril.Domain.Specification.Clientes
{
    class ClientePossuiStatusAtivo : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Ativo;
        }
    }
}
