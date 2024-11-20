//using Core.Promsy.Interfaces;
using Core.VentaDigitalPQF.Messages.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Core.Promsy.Interfaces

namespace Core.VentaDigitalPQF.Messages.Dto.General
{
    public class ModelMessage : IModelMessage
    {
        public Collection<Message> Messages { get; set; }
        public Exception Exception { get; set; }    

        public ModelMessage()
        {
            Messages = new Collection<Message>();
        }   

        public void AddMessage(Message message)
        {
            Messages.Add(message);
        }

        public void AddMessage(Collection<Message> messages)
        {
            foreach (var message in messages)
                Messages.Add(message);
        }
    }
}
