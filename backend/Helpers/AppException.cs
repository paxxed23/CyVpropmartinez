using System;
using System.Globalization;

namespace WebApi.Helpers
{
    // excepción personalizada para lanzar excepciones específicas de la aplicación (validacion) 
    // pueden ser tomadas y manejadas por la aplicacion
    public class AppException : Exception
    {
        public AppException() : base() {}

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
