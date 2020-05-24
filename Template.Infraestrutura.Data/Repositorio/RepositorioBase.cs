using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Template.Infraestrutura.Data.Context;
using Template.Infraestrutura.Dominio.Interfaces;

namespace Template.Infraestrutura.Data.Repositorio
{
    public class RepositorioBase<T> : IRepositorioGenerico<T> where T : class
    {
        private EntityContext _context;

        public RepositorioBase(EntityContext entityContext)
        {
            _context = entityContext;
        }

        public void Adicionar(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Atualizar(T obj)
        {
            _context.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Excluir(T obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
                _context.Attach(obj);

            _context.Remove(obj);
        }

        public IEnumerable<T> ListarTodos() => _context.Set<T>();
    }
}
