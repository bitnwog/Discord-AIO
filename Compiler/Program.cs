using System;
using System.Windows.Forms;

namespace aiocompiler
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                MessageBox.Show("Invalid arguments. Usage: daioCompiler <output_path> <icon_path>");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new daioCompiler(args));
        }
    }
}
