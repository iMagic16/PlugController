using System;
using System.Windows.Forms;

namespace PlugController
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn1ON_Click(object sender, EventArgs e)
        {
            TurnLightOn(1);
        }

        private void Btn1OFF_Click(object sender, EventArgs e)
        {
            TurnLightOff(1);

        }

        private void Btn2ON_Click(object sender, EventArgs e)
        {
            TurnLightOn(2);

        }

        private void Btn2OFF_Click(object sender, EventArgs e)
        {
            TurnLightOff(2);

        }

        private void Btn3ON_Click(object sender, EventArgs e)
        {
            TurnLightOn(3);

        }

        private void Btn3OFF_Click(object sender, EventArgs e)
        {
            TurnLightOff(3);

        }

        private void Btn4ON_Click(object sender, EventArgs e)
        {
            TurnLightOn(4);

        }

        private void Btn4OFF_Click(object sender, EventArgs e)
        {
            TurnLightOff(4);

        }

        private void BtnALLON_Click(object sender, EventArgs e)
        {
            TurnLightOn(0);

        }

        private void BtnALLOFF_Click(object sender, EventArgs e)
        {
            TurnLightOff(0);

        }

        private void TurnLightOn(int LightNo)
        {
            if (LightNo == 0)
            {
                webBrowser1.Navigate("http://192.168.0.15/control.php?allon");

            }
            else
            {
                webBrowser1.Navigate("http://192.168.0.15/control.php?" + LightNo + "on");

            }
        }

        private void TurnLightOff(int LightNo)
        {
            if (LightNo == 0)
            {
                webBrowser1.Navigate("http://192.168.0.15/control.php?alloff");

            }
            else
            {
                webBrowser1.Navigate("http://192.168.0.15/control.php?" + LightNo + "off");

            }
        }

    }
}
