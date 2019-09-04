using Portal.Domain.Entities;
using Portal.Domain.Interface.Repository;
using Portal.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal.Business
{
    public class OperadoraBusiness
    {
        //IOperadoraRepository _operadoraRepository;

        //public OperadoraBusiness()
        //{
        //    _operadoraRepository = new OperadoraRepository();
        //}

        //public List<Operadora> GetOperadoras(int ID = -1)
        //{
        //    if (ID == -1)
        //    {
        //        return _operadoraRepository.GetTodos().ToList();
        //    }
        //    else
        //    {
        //        return _operadoraRepository.Get(p => p.OperadoraID == ID).ToList();
        //    }
        //}

        //public void AdicionarOperadora(Operadora operadora)
        //{
        //    try
        //    {
        //        _operadoraRepository.Adicionar(operadora);
        //        _operadoraRepository.Commit();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

        //public Operadora Get(int? id)
        //{
        //    return _operadoraRepository.Procurar(id);
        //}

        //public void AlterarOperadora(Operadora operadora)
        //{
        //    _operadoraRepository.Atualizar(operadora);
        //    _operadoraRepository.Commit();
        //}

        //public void DeleteOperadora(int operadoraId)
        //{
        //    _operadoraRepository.Deletar(c => c.OperadoraID == operadoraId);
        //    _operadoraRepository.Commit();
        //}
    }
}
