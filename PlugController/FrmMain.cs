using System;
using System.Windows.Forms;

namespace PlugController
{
    public partial class FrmMain : Form
    {

        KeyboardHook hook = new KeyboardHook();

        public FrmMain()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + x numpad ombination as hot key.
            //all
            hook.RegisterHotKey(PlugController.ModifierKeys.Alt | PlugController.ModifierKeys.Control, Keys.NumPad0);
            //1
            hook.RegisterHotKey(PlugController.ModifierKeys.Alt | PlugController.ModifierKeys.Control, Keys.NumPad1);
            //2
            hook.RegisterHotKey(PlugController.ModifierKeys.Alt | PlugController.ModifierKeys.Control, Keys.NumPad2);
            //3
            hook.RegisterHotKey(PlugController.ModifierKeys.Alt | PlugController.ModifierKeys.Control, Keys.NumPad3);
            //4
            hook.RegisterHotKey(PlugController.ModifierKeys.Alt | PlugController.ModifierKeys.Control, Keys.NumPad4);


        }

        bool ZeroOn, OneOn, TwoOn, ThreeOn, FourOn, FiveOn;

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            string KeyPressed = e.Key.ToString();
            Console.WriteLine("[KEY DETECTED] " + KeyPressed + " pressed. (FrmMain.cs)");
            switch (KeyPressed)
            {
                case "NumPad0":
                    if (ZeroOn)
                    {
                        Console.WriteLine("NumPad0 registered, Toggling turning light On/Off [OFF] (FrmMain.cs)");
                        TurnLightOff(0);
                        ZeroOn = false;
                    }
                    else
                    {
                        Console.WriteLine("NumPad0 registered, Toggling turning light On/Off [ON] (FrmMain.cs)");
                        TurnLightOn(0);
                        ZeroOn = true;
                    }
                    break;
                case "NumPad1":
                    if (OneOn)
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning light On/Off [OFF] (FrmMain.cs)");
                        TurnLightOff(1);
                        OneOn = false;
                    }
                    else
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning light On/Off [ON] (FrmMain.cs)");
                        TurnLightOn(1);
                        OneOn = true;
                    }
                    break;
                case "NumPad2":
                    if (TwoOn)
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning light On/Off [OFF] (FrmMain.cs)");
                        TurnLightOff(2);
                        TwoOn = false;
                    }
                    else
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning light On/Off [ON] (FrmMain.cs)");
                        TurnLightOn(2);
                        TwoOn = true;
                    }
                    break;
                case "NumPad3":
                    if (ThreeOn)
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning fan On/Off [OFF] (FrmMain.cs)");
                        TurnLightOff(3);
                        ThreeOn = false;
                    }
                    else
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning fan On/Off [ON] (FrmMain.cs)");
                        TurnLightOn(3);
                        ThreeOn = true;
                    }
                    break;
                case "NumPad4":
                    if (FourOn)
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning PC On/Off [OFF] (FrmMain.cs)");
                        TurnLightOff(4);
                        FourOn = false;
                    }
                    else
                    {
                        Console.WriteLine(KeyPressed + " registered, Toggling turning PC On/Off [ON] (FrmMain.cs)");
                        TurnLightOn(4);
                        FourOn = true;
                    }
                    break;
                default:
                    Console.WriteLine("Switch-Case defaulted [no registered key pressed or detection error] (FrmMain.cs)");
                    break;
            }

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
