using System.Collections.Generic;

namespace Template.Infraestrutura.Dominio.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        void Excluir(T obj);
        IEnumerable<T> ListarTodos();
        void Adicionar(T obj);
        void Atualizar(T obj);
    }
}
