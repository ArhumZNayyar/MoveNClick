using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; //lets us use user32.dll
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLATOMoveNClick
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void DoMouseClick(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
            var userSetDelay = delayValue.Value; //gets the delay value the user sets using the numericUpDown control
            timer1.Interval = Convert.ToInt32(userSetDelay) * 1000; //multiply by 1000 because this is supposed to be in miliseconds but we 
            //use seconds on the numericUpDown to make it easier for the user.
            timer1.Start(); //starts the first timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //first tick
            Win32.POINT p = new Win32.POINT();
            p.x = Convert.ToInt16(XTxtBox.Text); //x coordinate taken from the txtbox
            p.y = Convert.ToInt16(YTxtBox.Text); //y coordinate taken from the txtbox

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            DoMouseClick(p.x, p.y);

            var userSetDelay2 = delayValue2.Value; //gets the delay value the user sets using the numericUpDown control
            timer2.Interval = Convert.ToInt32(userSetDelay2) * 1000; //multiply by 1000 because this is supposed to be in miliseconds but we 
            //use seconds on the numericUpDown to make it easier for the user.

            timer2.Start();
            timer1.Stop();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Win32.POINT p2 = new Win32.POINT();
            p2.x = Convert.ToInt16(X2TxtBox.Text); //x coordinate taken from the txtbox
            p2.y = Convert.ToInt16(Y2TxtBox.Text); //y coordinate taken from the txtbox

            Win32.ClientToScreen(this.Handle, ref p2);
            Win32.SetCursorPos(p2.x, p2.y);

            DoMouseClick(p2.x, p2.y);

            var userSetDelay = delayValue.Value; //gets the delay value the user sets using the numericUpDown control
            timer1.Interval = Convert.ToInt32(userSetDelay) * 1000; //multiply by 1000 because this is supposed to be in miliseconds but we 
            //use seconds on the numericUpDown to make it easier for the user.

            timer1.Start();
            timer2.Stop();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void delayValue_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            warningLabel.Visible = true;
        }

        private void delayValue2_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            warningLabel.Visible = true;
        }
    }
}
