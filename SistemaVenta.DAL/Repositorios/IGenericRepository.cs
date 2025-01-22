using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SistemaVenta.DAL.Repositorios
{
    public interface IGenericRepository<Tmodel> where Tmodel : class
    {
        Task<Tmodel> Obtener(Expression<Func<Tmodel, bool>> filtro);
        Task<Tmodel> Crear(Tmodel modelo);
        Task<bool> Editar(Tmodel modelo);
        Task<bool> Eliminar(Tmodel modelo);
        Task<IQueryable<Tmodel>> Consultar(Expression<Func<Tmodel, bool>> filtro = null);
    }
}
