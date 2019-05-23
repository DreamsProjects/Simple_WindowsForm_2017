using Databasteknik_Inlämning1.All_forms;
using System;
using System.Windows.Forms;

namespace Databasteknik_Inlämning1
{
    static class Program
    {
        public static bool OpenSecondForm { get; set; }
        public static bool UpdateForm { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Book());

            OpenAnotherForm();
            UpdateAnotherForm();

        }

        private static void OpenAnotherForm()
        {
            if(OpenSecondForm)
            {
                Application.Run(new RegisterNew());
            }

            OpenSecondForm = false;
        }

        public static void UpdateAnotherForm()
        {
            if(UpdateForm)
            {
                Application.Run(new UpdateDelete());
            }

            UpdateForm = false;
        }
    }
}
