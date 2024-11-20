using Core.VentaDigitalPQF.Messages.Dto.General;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages.Interfaces
{
    public interface IModelMessage
    {
        Collection<Message> Messages { get; set; }
        Exception Exception { get; set; }
        void AddMessage(Message message);   
        void AddMessage(Collection<Message> messages);
    }
}
