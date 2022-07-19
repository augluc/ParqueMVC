using Exp3.Models;
using Exp3.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Exp3.Repositories
{
    public class BrinquedoRepository : IBrinquedoRepository
    {
        private ParqueDiversaoContext _context;

        public BrinquedoRepository(ParqueDiversaoContext context)
        {
            _context = context;
        }
        public void Atualizar(Brinquedo brinquedo)
        {
            _context.Brinquedos.Update(brinquedo);
        }

        public Brinquedo BuscarPorId(int id)
        {
            return _context.Brinquedos.Include(b => b.Manutencao).Where(b => b.BrinquedoId == id).FirstOrDefault();
        }

        public List<Brinquedo> BuscarPor(Expression<Func<Brinquedo, bool>> filtro)
        {

            return _context.Brinquedos.Include(b => b.Manutencao).Where(filtro).ToList();

        }

        public void Cadastrar(Brinquedo brinquedo)
        {
            _context.Brinquedos.Add(brinquedo);
        }

        public List<Brinquedo> Listar()
        {
            return _context.Brinquedos.ToList();
        }

        public void Remover(int id)
        {
            Brinquedo brinquedo = _context.Brinquedos.Find(id);
            _context.Brinquedos.Remove(brinquedo);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
