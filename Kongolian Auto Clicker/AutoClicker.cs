using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Kongolian_Auto_Clicker
{
    public partial class AutoClicker : Form
    {
        public AutoClicker()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private void AutoClicker_Load(object sender, EventArgs e)
        {

        }





    }
}
