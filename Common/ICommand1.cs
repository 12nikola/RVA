using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ICommand1
    {
        string Execute(int id, IService service);
        string Unexecute(int id, IService service);
        string Execute1(int id, IService service);
        string Unexecute1(int id, IService service);
    }
}
