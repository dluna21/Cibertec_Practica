using System.Collections.Generic;
using System.Linq;

namespace WebDeveloper.DataAccess
{   //Interface
    public interface IDataAccess<T>
    {
        //Creamos Metodos Generico que se implementaran en la BaseDataAccess
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> GetList();
    }
}
