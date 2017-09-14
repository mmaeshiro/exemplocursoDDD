using CursoMVCAbril.Domain.Entities;
using CursoMVCAbril.Domain.Specification.Clientes;
using CursoMVCAbril.Domain.Validation.Base;

namespace CursoMVCAbril.Domain.Validation.Clientes
{
    public class ClienteConsistenteValidation : FiscalBase<Cliente>
    {
        public ClienteConsistenteValidation()
        {
            var clienteEndereco = new ClientePossuiEnderecoCadastradoSpecification();
            var clienteAtivo = new ClientePossuiStatusAtivo();
            var clienteCPFValido = new ClientePossuiCPFValido();
            var clienteMaiorDe18 = new ClienteMaior18AnosSpecification();

            base.AdicionarRegra("ClienteEspecial", new Regra<Cliente>(clienteEndereco, "Cliente não possui endereço castrado"));
            base.AdicionarRegra("ClienteAtivo", new Regra<Cliente>(clienteAtivo, "Cliente não está ativo no sistema"));
            base.AdicionarRegra("ClienteCPFValido", new Regra<Cliente>(clienteCPFValido, "Cliente informou um CPF Inválido"));
            base.AdicionarRegra("clienteEspecial", new Regra<Cliente>(clienteMaiorDe18, "Cliente Menor de 18 anos"));
        }
    }
}
