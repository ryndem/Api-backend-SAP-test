using System;
using System.Globalization;

namespace Core.VentaDigitalPQF.ExceptionHandler
{
    public enum TipoExcepcion
    {
        Error,
        Negocio,
    }

    /// <summary>
    /// Custom exception class for throwing application specific exceptions (e.g. for validation) 
    /// that can be caught and handled within the application.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class AppException : Exception
    {
        public TipoExcepcion Tipo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        public AppException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AppException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public AppException(string message, Exception ex)
            : base(message, ex)
        {
            Tipo = (ex as AppException)?.Tipo ?? TipoExcepcion.Error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public AppException(TipoExcepcion tipo, string message) : base(message)
        {
            Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public AppException(TipoExcepcion tipo, string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
            Tipo = tipo;
        }
    }
}