using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceCalling.Interfaces.Interfaces
{
    public interface IMaster
    {
        IComplaint _complaint { get; }
        IEmployee _employee { get; }
    }
}
