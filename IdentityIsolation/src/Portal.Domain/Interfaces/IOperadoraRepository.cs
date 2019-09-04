using System;
using System.Collections.Generic;
using Portal.Domain.Entities;
using Portal.Domain.Repository.Interfaces;

namespace Portal.Domain.Interface.Repository
{
    public interface IOperadoraRepository : IDisposable
    {
        Operadora ObterPorId(string id);
        IEnumerable<Operadora> ObterTodos();
    }
}