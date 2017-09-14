using System;
using System.Collections.Generic;
using CursoMVCAbril.Application.Validation;
using CursoMVCAbril.Application.ViewModels;

namespace CursoMVCAbril.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        ValidationAppResult Adicionar(ClienteEnderecoViewModel cliente);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCPF(string cpf);
        IEnumerable<ClienteViewModel> ObterTodos();
        void Atualizar(ClienteViewModel cliente);
        void Remover(ClienteViewModel cliente); 
    }
}