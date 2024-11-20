using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages
{
    public enum EMessageType
    {
        [Description("Information")]
        Information,
        [Description("Success")]
        Success,
        [Description("Warning")]
        Warning,
        [Description("Error")]
        Error,
        [Description("Validation")]
        Validation,
        [Description("Duplicate")]
        Duplicate,
        [Description("InvalidRequest")]
        InvalidRequest
    }
}
