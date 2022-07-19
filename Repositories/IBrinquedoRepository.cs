using Exp3.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Exp3.Repositories
{
    public interface IBrinquedoRepository
    {
        void Cadastrar(Brinquedo brinquedo);

        void Atualizar(Brinquedo brinquedo);

        void Remover(int id);

        Brinquedo BuscarPorId(int id);

        List<Brinquedo> Listar();

        List<Brinquedo> BuscarPor(Expression<Func<Brinquedo, bool>>filtro);

        void Salvar();




    }
}
