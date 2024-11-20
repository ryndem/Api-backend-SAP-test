using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Proxy
{
    /// <summary>
    /// se hace un singleton para la variable que recuperará la url de la API 
    /// </summary>
    public enum ProxyApiSelector
    {
        Catalogo = 0,
        Logistica = 1,
        Finanzas = 2
    }
public class ApiProquifaDotNetCatalogoUrl
    {
        public string Value { get; }
        public ApiProquifaDotNetCatalogoUrl( string url )
        {
            Value = url;
        }
        
    }
    public class ApiProquifaDotNetLogisticaUrl
    {
        public string Value { get; }
        public ApiProquifaDotNetLogisticaUrl( string url )
        {
            Value = url;
        }
    }
    public class ApiProquifaDotNetFinanzasUrl
    {
        public string Value { get; }
        public ApiProquifaDotNetFinanzasUrl( string url )
        {
            Value = url;
        }
    }
}
