using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using DiscordRPC;
using DiscordRPC.Logging;


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
        int KEY = 88;



        // discord srv shit
        public DiscordRpcClient client;
        bool Initialize = false;






        private void AutoClicker_Load(object sender, EventArgs e)
        {
            // ini
            Initialize = true; 
            client = new DiscordRpcClient("947177821787271210");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning};
            client.Initialize();

            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"AutoClicking",
                State = $"www.kongolian.tech",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey =$"monkiclickercursordarkhd_1",
                    LargeImageText = $"Clicking fast!"
                }
            });
            

            

            // starts the auto clicker
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


        private void TBKey_TextChanged(object sender, EventArgs e)
        {
       
            if (TBKey.Text != "")
            {

                for (int i = 0; i <= 255; i++)
                {
                    
                    int keystate = GetAsyncKeyState(i);
                    if(keystate == 32769)
                    {
                        label4.Text = "Press " + TBKey.Text + " To Toggle";
                        KEY = i;
                    }
                }

            }

        }

        private void keyBind()
        {
            while (KBRunning)
            {

                Thread.Sleep(5);

                int keystate = GetAsyncKeyState(KEY);
                
                if (keystate == 32769 || keystate == 32769)
                {
                    Toggle = !Toggle;

                }


            }

        }


        // does the actual clicking
        private void Interval_Tick(object sender, EventArgs e)
        {
            if (Toggle == true)
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
}
