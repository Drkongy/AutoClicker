using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;


namespace Kongolian_Auto_Clicker
{
    public partial class AutoClicker : Form
    {


        public AutoClicker()
        {
            InitializeComponent();
        }


        //Imports system tools so that the program can actually click.
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);


        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);



        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;  // LeftClicks
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;  // RightClicks
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        public bool Toggle = false;
        int clicks = 0;


        public bool MBToggle = false; // mouse Button toggle





        public int Delaysecs = 0;
        public bool check;


        // this is for the keybinds stuff

        bool KBRunning = true;
        bool Pressed = false;



        private void AutoClicker_Load(object sender, EventArgs e)
        {
            Thread KB = new Thread(keyBind);
            KB.Start();
        }


        //Moves the window

        Point lastPoint;
        bool mousedown;


        private void LblAutoClicker_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // records the position of the mouse.
            mousedown = true;
        }

        private void LblAutoClicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }


        }

        private void LblAutoClicker_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }


        //Closes the Application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            KBRunning = false;
        }



        // Main AutoClicker Code!
        private void TBIntervel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.

        }

        private void TBIntervel_TextChanged(object sender, EventArgs e)
        {
            if (TBIntervel.Text == "0")
            {
                TBIntervel.Text = "100";
            }

            if (TBIntervel.Text != "")
            {
                Interval.Interval = Int32.Parse(TBIntervel.Text);

                BtnConfirm.Text = "Enable";

                Interval.Enabled = false;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //changes the text on the button and starts up the auto clicker.
            if (Interval.Enabled == true)
            {
                Interval.Enabled = false;
                BtnConfirm.Text = "Enable";
            }
            else
            {
                Delay.Enabled = true;

            }
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            // The text that appears on the button when you enable the auto clicker.
            Delaysecs += 1000;

            if (Delaysecs == 1000)
            {
                BtnConfirm.Text = "3";
            }
            else if (Delaysecs == 2000)
            {
                BtnConfirm.Text = "2";
            }
            else if (Delaysecs == 3000)
            {
                BtnConfirm.Text = "1";

            }
            else if (Delaysecs > 3000)
            {
                Delay.Enabled = false;
                BtnConfirm.Text = "Disable";
                Interval.Enabled = true;
                Toggle = false;
                Delaysecs = 0;
            }
        }

        //Toggle Button allows you to choose between left and right click.
        private void btnButtonToggle_Click(object sender, EventArgs e)
        {
            if (MBToggle == true)
            {
                MBToggle = false;
                btnButtonToggle.Text = "Left Click";
            }
            else
            {
                MBToggle = true;
                btnButtonToggle.Text = "Right Click";


            }
        }

        private void keyBind()
        {
            while (KBRunning)
            {



                int keystate = GetAsyncKeyState(88);

                if (keystate == 32769)
                {
                    Pressed = !Pressed;
                }

                if (Pressed == true)
                {
                    Thread.Sleep(Interval.Interval);

                    Interval.Enabled = false;

                    clicks++;
                    TBClicks.Text = clicks.ToString();
                    //Call the imported function with the cursor's current position
                    int X = (int)Cursor.Position.X;
                    int Y = (int)Cursor.Position.Y;


                    if (MBToggle == true)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0); // Right click mouse event.

                    }
                    else
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); // Left click mouse event.
                    }

                }



            

            }

        }





        // does the actual clicking
        private void Interval_Tick(object sender, EventArgs e)
        {
            clicks++;
            TBClicks.Text = clicks.ToString();
            //Call the imported function with the cursor's current position
            int X = (int)Cursor.Position.X;
            int Y = (int)Cursor.Position.Y;


            if (MBToggle == true)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0); // Right click mouse event.

            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); // Left click mouse event.
            }
        }


    }
}
