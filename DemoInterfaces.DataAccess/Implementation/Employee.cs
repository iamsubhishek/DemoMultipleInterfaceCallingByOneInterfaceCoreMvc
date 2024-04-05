using DemoInterfaceCalling.Interfaces.Interfaces;
using DemoInterfaces.EfCore.Data;
using DemoInterfaces.EfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoInterfaces.DataAccess.Implementation
{
    public class Employee : IEmployee
    {
        private readonly DemoContext _demoContext;
        //public Employee(DemoContext demoContext)
        //{
        //    _demoContext = demoContext; 
        //}
        public void Delete(EfCore.Models.Employee t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EfCore.Models.Employee> GetAll()
        {
            IQueryable<EfCore.Models.Employee> emp = _demoContext.Employee.AsQueryable();
            return emp;
        }

        public IQueryable<EfCore.Models.Employee> GetAllById(EfCore.Models.Employee Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EfCore.Models.Employee> GetAllEXEmployees()
        {
            throw new NotImplementedException();
        }

        public void Save(EfCore.Models.Employee t)
        {
            throw new NotImplementedException();
        }

        public void Update(EfCore.Models.Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
