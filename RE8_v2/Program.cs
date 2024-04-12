namespace RE_28V2
{
    public enum OpcionesPrincipal : byte { Salir, Añadir, Consultar, Verificar }
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS

            OpcionesPrincipal opcion;

            // 1 Obtener acción IU

            opcion = (OpcionesPrincipal)Metodos.UI.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);

            // 2 Ejecutar acción LN
            // 3 ¿Ejecutar Acción? SI --> 1
            // 4 Despedida UI


        }
    }
}
