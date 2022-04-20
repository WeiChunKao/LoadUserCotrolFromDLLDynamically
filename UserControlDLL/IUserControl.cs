using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlDLL
{
    public interface IUserControl
    {
        event Action<Exception> OnError;
        event Action<string> OnLog;
    }
}
