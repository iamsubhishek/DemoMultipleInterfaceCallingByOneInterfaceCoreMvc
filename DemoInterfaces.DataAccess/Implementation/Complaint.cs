using DemoInterfaceCalling.Interfaces.Interfaces;
using DemoInterfaces.EfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaces.DataAccess.Implementation
{
    public class Complaint : IComplaint
    {
        public void Delete(Complaints t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Complaints> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Complaints> GetAllById(Complaints Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Complaints> GetAllResolveComplaints()
        {
            throw new NotImplementedException();
        }

        public void Save(Complaints t)
        {
            throw new NotImplementedException();
        }

        public void Update(Complaints t)
        {
            throw new NotImplementedException();
        }
    }
}
