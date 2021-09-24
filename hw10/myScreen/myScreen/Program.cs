using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myScreen {
    class Program {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        static void Main(string[] args) {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero)) {
                IntPtr hdc = g.GetHdc();
                int resultW = GetDeviceCaps(hdc, 4);
                int resultH = GetDeviceCaps(hdc, 6);
                Console.WriteLine("Диагональ экрана: " + Math.Round((Math.Sqrt(Math.Pow(resultH / 10, 2) + Math.Pow(resultW / 10, 2)) / 2.54), 2).ToString() + " дюймов");
                g.ReleaseHdc();
            }
        }
    }
}
