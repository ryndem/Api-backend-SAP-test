using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Messages
{
    public static partial class EMessageCode
    {
        #region General
        // 2xx Success
        public static EMessageCodeDescription Created = new EMessageCodeDescription(201, "CreatedSuccessfully");
        public static EMessageCodeDescription Updated = new EMessageCodeDescription(201, "ModifiedCorrectly");
        public static EMessageCodeDescription Validated = new EMessageCodeDescription(201, "ValidatedCorrectly");
        public static EMessageCodeDescription Deleted = new EMessageCodeDescription(201, "RemovedSuccessfully");
        public static EMessageCodeDescription Accepted = new EMessageCodeDescription(202, "Accepted");
        public static EMessageCodeDescription Canceled = new EMessageCodeDescription(202, "Canceled");

        // 4xx Client Error
        public static EMessageCodeDescription Unauthorized = new EMessageCodeDescription(401, "Unauthorized");
        public static EMessageCodeDescription EmptyValue = new EMessageCodeDescription(400, "ValueCanotByNull");
        public static EMessageCodeDescription InvalidValue = new EMessageCodeDescription(400, "InvalidValue");
        public static EMessageCodeDescription CannotBeZero = new EMessageCodeDescription(400, "CannotBeZero");
        public static EMessageCodeDescription BadFormat = new EMessageCodeDescription(400, "BadFormat");
        public static EMessageCodeDescription EqualLength = new EMessageCodeDescription(400, "EqualLength");
        public static EMessageCodeDescription MaxLength = new EMessageCodeDescription(400, "MaxLength");
        public static EMessageCodeDescription InvalidExtension = new EMessageCodeDescription(400, "InvalidExtension");
        public static EMessageCodeDescription NotInList = new EMessageCodeDescription(400, "NotInList");
        public static EMessageCodeDescription BigFile = new EMessageCodeDescription(400, "BigFile");
        public static EMessageCodeDescription FileBadFormat = new EMessageCodeDescription(400, "FileBadFormat");
        public static EMessageCodeDescription FileEmpty = new EMessageCodeDescription(400, "FileEmpty");
        public static EMessageCodeDescription NotExists = new EMessageCodeDescription(400, "NotExists");
        public static EMessageCodeDescription Exists = new EMessageCodeDescription(400, "Exists");
        public static EMessageCodeDescription ExistsInFile = new EMessageCodeDescription(400, "ExistsInFile");
        public static EMessageCodeDescription Duplicate = new EMessageCodeDescription(400, "Duplicate");
        public static EMessageCodeDescription InconsistentData = new EMessageCodeDescription(400, "InconsistentData");
        
        public static EMessageCodeDescription Inactive = new EMessageCodeDescription(400, "Inactive");
        public static EMessageCodeDescription IsAlreadyCanceled = new EMessageCodeDescription(400, "IsAlreadyCanceled");
        public static EMessageCodeDescription NotAvailableToCancel = new EMessageCodeDescription(400, "NotAvailableToCancel");
        public static EMessageCodeDescription NotAvailable = new EMessageCodeDescription(400, "NotAvailable");
        
        public static EMessageCodeDescription InternalServerError = new EMessageCodeDescription(500, "InternalServerError");
        #endregion
    }
}
