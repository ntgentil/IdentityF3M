using System;
using System.Collections.Generic;
using System.Linq;
using Portal.Domain.Entities;
using Portal.Domain.Interface.Repository;
using Portal.Infra.CrossCutting.Identity.Context;
using Portal.Infra.Data.Context;

namespace Portal.Infra.Data.Repository
{
    public class OperadoraRepository : IOperadoraRepository
    {

        private readonly ApplicationDbContext _db;
        
        public OperadoraRepository()
        {
            _db = new ApplicationDbContext();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Operadora ObterPorId(string id)
        {
            return _db.Operadoras.Find(id);
        }

        public IEnumerable<Operadora> ObterTodos()
        {
            return _db.Operadoras.ToList();
        }
       
    }
}
