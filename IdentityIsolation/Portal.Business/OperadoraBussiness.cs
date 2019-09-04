using Portal.Domain.Entities;
using Portal.Domain.Interfaces;
using Portal.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal.Business
{
    public class OperadoraBussiness
    {
        IOperadoraRepositorio _operadoraRepositorio;

        public OperadoraBussiness()
        {
            _operadoraRepositorio = new OperadoraRepositorio();
        }

        public List<Operadora> GetOperadoras(int ID = -1)
        {
            if (ID == -1)
            {
                return _operadoraRepositorio.GetTodos().ToList();
            }
            else
            {
                return _operadoraRepositorio.Get(p => p.OperadoraID == ID).ToList();
            }
        }

        public void AdicionarOperadora(Operadora operadora)
        {
            try
            {
                _operadoraRepositorio.Adicionar(operadora);
                _operadoraRepositorio.Commit();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Operadora Get(int? id)
        {
            return _operadoraRepositorio.Procurar(id);
        }

        public void AlterarOperadora(Operadora operadora)
        {
            _operadoraRepositorio.Atualizar(operadora);
            _operadoraRepositorio.Commit();
        }

        public void DeleteOperadora(int operadoraId)
        {
            _operadoraRepositorio.Deletar(c => c.OperadoraID == operadoraId);
            _operadoraRepositorio.Commit();
        }
    }
}
