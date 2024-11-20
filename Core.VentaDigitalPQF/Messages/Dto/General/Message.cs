//using Core.Promsy.Enum;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages.Dto.General
{
    public class Message
    {
        public string Variable { get; set; }
        public string Value { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public EMessageType MessageType { get; set; }
        public string MessageTypeString
        {
            get { return MessageType.ToString(); }
            set { value = MessageType.ToString(); }
        }
        public string DescriptionTranslate { get; set; }

        public Message() 
            : this(null, null, 0, null, EMessageType.Information, null) { }

        public Message(string variable, string value, EMessageCodeDescription messageCodeDescription, EMessageType messageType)
            : this(variable, value, messageCodeDescription.Code, messageCodeDescription.Description, messageType, null) { }
        public Message(string variable, EMessageCodeDescription messageCodeDescription, EMessageType messageType, string descriptionTranslate)
            : this(variable, null, messageCodeDescription.Code, messageCodeDescription.Description, messageType, descriptionTranslate) { }

        public Message(string variable, string value, EMessageCodeDescription messageCodeDescription, EMessageType messageType, string descriptionTranslate)
            : this(variable, value, messageCodeDescription.Code, messageCodeDescription.Description, messageType, descriptionTranslate) { }

        [JsonConstructor]
        public Message(string variable, string value, int code, string description, EMessageType messageType, string descriptionTranslate)
        {
            Variable = variable;
            Value = value;
            Code = code;
            Description = description;
            MessageType = messageType;
            DescriptionTranslate = descriptionTranslate;
        }
        
    }
}
