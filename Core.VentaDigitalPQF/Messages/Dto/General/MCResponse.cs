//using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages.Dto.General
{
    public class MCResponse
    {
        private  bool _Status;
        private  Collection<Message> _Messages;

        public bool Status { get { return _Status; } }

        public Collection<Message> Messages { get { return _Messages; } }

        public MCResponse() 
        {
            this._Status = false;
            this._Messages = null;
        }

        public MCResponse(bool status, Collection<Message> messages)
        {
            this._Status = status;
            this._Messages = messages;
        }
    }
}
