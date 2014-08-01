using System;
using System.Collections.Generic;
using System.Linq;
using Dover.Framework;

namespace Dover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application b1App;

                b1App = new Application();
                b1App.Run();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Erro inesperado no AddOne: {0}\n {1}", e.Message, e.StackTrace));
            }
        }

    }
}
