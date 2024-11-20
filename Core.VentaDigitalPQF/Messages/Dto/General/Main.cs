using Core.VentaDigitalPQF.Messages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//[assembly: InternalsVisibleTo("Logic.Promsy")]
//[assembly: InternalsVisibleTo("WebApi.Promsy")]
namespace Core.VentaDigitalPQF.Messages.Dto.General
{
    public class Main<T> where T : class, IModelMessage, new()
    {
        #region Properties
        internal M<T> M { get; set; }
        internal T Model { get; set; }
        internal MCResponse Response { get; set; }
        #endregion
        public Main() { 
            M = new M<T>();
            M.Instance = new T();
            Model = M.Instance;
        }

        #region Messages 
        #region ClearMessages
        internal void ClearMessages()
        {
            ClearMessages(Model);
        }

        internal void ClearMessages(EMessageType messageType)
        {
            ClearMessages(Model, messageType);
        }

        internal void ClearMessages(IModelMessage model)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            model.Messages.Clear();
        }

        internal void ClearMessages(IModelMessage model, EMessageType messageType)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            if (model.Messages == null) throw new Exception("MessagesIsNullException");

            var list = model.Messages.ToList();
            list.RemoveAll(m => m.MessageType == messageType);
            model.Messages.Clear();
            list.ForEach(m => model.Messages.Add(m));
        }
        #endregion

        #region AddMessage
        internal void AddMessage(string variable, string value, EMessageCodeDescription messageCodeDescription, EMessageType type)
        {
            AddMessage(variable, value, messageCodeDescription, type, Model);
        }

        internal void AddMessage(string variable, string value, EMessageCodeDescription messageCodeDescription, EMessageType type, IModelMessage model)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            if (model.Messages == null) ClearMessages(model);

            if (model.Messages.ToList().Exists(x => x.Variable == variable && x.Value == value && x.Code == messageCodeDescription.Code && x.Description == messageCodeDescription.Description && x.MessageType == type)) return;

            model.Messages.Add(new Message(variable, value, messageCodeDescription, type));
        }

        internal void AddMessage(Message message)
        {
            AddMessage(message, Model);
        }

        internal void AddMessage(Message message, IModelMessage model)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            if (model.Messages == null) ClearMessages(model);

            if (model.Messages.ToList().Exists(x => x == message)) return;

            model.Messages.Add(message);
        }
        #endregion

        #region ContainMessages
        internal bool ContainMessages { get { return ModelContainMessages(Model); } }
        internal bool ContainInformationMessages { get { return ModelContainMessageType(Model, EMessageType.Information); } }
        internal bool ContainErrorMessages { get { return ModelContainMessageType(Model, EMessageType.Error); } }
        internal bool ContainValidationMessages { get { return ModelContainMessageType(Model, EMessageType.Validation); } }
        internal bool ContainDuplicateMessages { get { return ModelContainMessageType(Model, EMessageType.Duplicate); } }
        internal bool ContainWarningMessages { get { return ModelContainMessageType(Model, EMessageType.Warning); } }
        internal bool ContainAlerts { get { return ContainErrorMessages || ContainValidationMessages || ContainWarningMessages || ContainDuplicateMessages; } }

        private bool ModelContainMessages(IModelMessage model)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            if (model.Messages == null) return false;
            return model.Messages.Count > 0;
        }
        private bool ModelContainMessageType(IModelMessage model, EMessageType messageType)
        {
            if (model == null) throw new Exception("ModelIsNullException");
            if (model.Messages == null) return false;
            return model.Messages.Count(x => x.MessageType == messageType) > 0;
        }
        #endregion
        #endregion
    }

    [Serializable]
    public class M<T>
    { 
        public T Instance { get; set; }
    }
}
