using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }*/

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static MODIFY_SERVER subForm;
        public static MAIN_FORM mainForm;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm = new MAIN_FORM());
        }
    }
}