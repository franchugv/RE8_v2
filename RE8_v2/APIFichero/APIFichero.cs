using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_28V2.APIFichero
{
    public static class APIFichero
    {

        // RECURSOS

        private const string RUTA = "Nombres.txt";

        // MÉTODOS

        public static string[] ListaNombres()
        {
            // 1 ¿Existe Fichero?
            VerificarExistenciaFichero();
            // 2 Abrir Fichero

            // 3 Cerrar Fichero

            // 4 Cerrar Fichero

            // 5 Devolver

        }

        private static void CrearFichero()
        {
            StreamWriter escritor;
            escritor = File.CreateText(RUTA);
            escritor.Close();

        }

        private static void VerificarExistenciaFichero()
        {
            if (File.Exists(RUTA)) CrearFichero();
        }
    }
}
