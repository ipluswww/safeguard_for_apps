using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;

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


            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;

            Application.Run(new Form1());

        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Process[] localByName = Process.GetProcessesByName("astrill");

            if (localByName.Length == 0)
            {
                Point pt = Cursor.Position; // Get the mouse cursor in screen coordinates 

                using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                {

                    SolidBrush blueBrush = new SolidBrush(Color.Blue);

                    // Create rectangle. 
                    Rectangle rect = new Rectangle(0, 0, 200, 200);

                    // Fill rectangle to screen.
                    g.FillRectangle(blueBrush, rect);
                }

            }
            else
            {
                /*Point pt = Cursor.Position; // Get the mouse cursor in screen coordinates 

                using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                {
                    g.DrawEllipse(Pens.Black, pt.X - 10, pt.Y - 10, 20, 20);
                }
                //this.Text = "alive";
                */
            }    
        }
    }
}
