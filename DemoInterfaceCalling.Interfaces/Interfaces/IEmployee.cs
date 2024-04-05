﻿using DemoInterfaces.EfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceCalling.Interfaces.Interfaces
{
    public interface IEmployee : IDao<Employee>
    {
        IQueryable<Employee> GetAllEXEmployees();
    }
}
