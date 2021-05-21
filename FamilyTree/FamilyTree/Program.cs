using FamilyTree.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{
    internal static class Program
    {
        public static string ImagePath { get; set; }
        public static MainForm MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            GetImagesPath();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            Application.Run(MainForm);
        }

        private static void GetImagesPath()
        {
            ImagePath = Directory.GetCurrentDirectory();
            string[] sl = ImagePath.Split('\\');

            ImagePath = "";

            foreach (string s in sl)
            {
                if (s == "bin")
                    break;
                else
                    if (ImagePath == "")
                    ImagePath = s;
                else
                    ImagePath += "\\" + s;
            }

            ImagePath += "\\Images";
        }
    }
}