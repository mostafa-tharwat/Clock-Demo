using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
            //string pass, input;
            //pass = "111";
            //Console.Write("\n  Enter Your Password : ");
            //input = Console.ReadLine();

            //while (input != pass)
            //{
            //    Console.WriteLine("\a *.* Error Password *.* ");

            //    Console.Write(" Enter Your Password : ");
            //    input = Console.ReadLine();
            }
       
         }
    }

