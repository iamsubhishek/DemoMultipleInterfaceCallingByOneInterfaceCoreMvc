using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceCalling.Interfaces.Interfaces
{
    public interface IDao<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllById(T Id);
        void Save(T t);
        void Update(T t);
        void Delete(T t);
    }
}
