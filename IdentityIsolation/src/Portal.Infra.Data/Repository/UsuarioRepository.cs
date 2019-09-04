using System;
using System.Collections.Generic;
using System.Linq;
using Portal.Domain.Entities;
using Portal.Domain.Interface.Repository;
using Portal.Infra.Data.Context;

namespace Portal.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IdentityContext _db;

        public UsuarioRepository()
        {
            _db = new IdentityContext();
        }

        public Usuario ObterPorId(string id)
        {
            return _db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _db.Usuarios.ToList();
        }
        public void DesativarLock(string id)
        {
            _db.Usuarios.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}