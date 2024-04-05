using DemoInterfaceCalling.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaces.DataAccess.Implementation
{
    public class Master : IMaster
    {
        private readonly IComplaint complaint;
        private readonly IEmployee employee;
        public IComplaint _complaint => complaint;

        public IEmployee _employee => employee;

        public Master()
        {
            complaint = new Complaint();
            employee = new Employee();
        }
    }
}
