using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_28V2.Metodos
{
    public static class UI
    {
        public static void MostrarError(string Merror)
        {
            Console.WriteLine($"Error: {Merror}.");
            Console.ReadLine();
            Console.Clear();
        }

        public static byte CaptarOpcionEnum(byte numOpciones)
        {
            // RECURSOS
            byte opcion = 0;
            string aux = "";

            aux = Console.ReadLine();

            if (string.IsNullOrEmpty(aux)) throw new FormatException("Cadena vacía");

            opcion = Convert.ToByte(aux);

            if (opcion >= numOpciones) throw new OverflowException();

            return opcion;
            

        }

        public static string CaptarCadena()
        {
            // Recursos

            string cadena = "";
            bool esValido;
            string MensajeError = "";

            do
            {
                esValido = true;
                try
                {
                    cadena = Console.ReadLine();
                }
                catch(Exception Error)
                {
                    esValido = false;
                    MensajeError = Error.Message;
                }
                finally
                {
                    if (!esValido) UI.MostrarError(MensajeError);
                }

            } while (!esValido);

            return cadena;
        }

        public static void Pausa()
        {
            Console.Write("\nPulse Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

        }

        public static void MostrarDato(string dato)
        {
            Console.Clear();
            Console.WriteLine($"{dato}");

            Pausa();
        }

    }
}
