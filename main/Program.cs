using Modelos;

namespace main
{
    internal static class Program
    {
        public static Fabrica fabrica = ManejadorDeFabrica.ObtenerInstancia();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            
        }
    }
}