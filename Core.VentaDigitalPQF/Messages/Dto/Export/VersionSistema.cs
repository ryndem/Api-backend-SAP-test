#region

using System;
using System.Reflection;

#endregion

namespace Core.Promsy.Models.Export
{
    public class VersionSistema
    {
        public VersionSistema(string nombre, string scope, string version, string revId, string rama, string tags,
            string fecha)
        {
            Nombre = nombre;
            Scope = scope;
            Version = version;
            RevId = revId;
            Rama = rama;
            Tags = tags;
            Fecha = DateTime.Parse(fecha);
        }

        public string Nombre { get; set; }
        public string Scope { get; set; }
        public string Version { get; set; }

        public string RevId { get; set; }
        public string Rama { get; set; }

        public string Tags { get; set; }

        public DateTime Fecha { get; set; }

        public static string NumeroVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var arreglo = version.Split('.');
            if (arreglo.Length != 4)
                return version;
            return arreglo[2];
        }
    }
}