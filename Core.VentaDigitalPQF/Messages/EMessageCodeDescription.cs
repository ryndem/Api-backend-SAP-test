using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages
{
    public class EMessageCodeDescription
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public EMessageCodeDescription() { }
        public EMessageCodeDescription(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
