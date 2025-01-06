using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Core.Requests
{
    public abstract class Request
    {
        public string UserID { get; set; } = string.Empty;
    }
}
