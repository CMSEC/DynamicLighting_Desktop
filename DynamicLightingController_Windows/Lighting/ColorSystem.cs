using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Lighting
{
    public enum States
    {
        Color,
        Download,
        Upload,
        Disco,
        ShortCircuit,
        Bugs,
        Plasma,
        RGB,
        Failure,
        Victory
    }

    public enum Transitions
    {
        Linear,
        Instant,
        LeftRightWipe,
        RightLeftWipe,
        Sparkle,
        Spectrum,
        Fade
    }
    public enum Idle
    {
        None,
        PorterPulse,
        Cylon,
        Stealth,
        Twinkle,
        Alert,
        Chase,
        Fire,
        Pulse,
        Snow,
        Wipe,
        Strobe
    }
    public enum Effects
    {
        Explosion,
        Sparks,
        Brownout,
        Surge,
        Strobe,
        Flicker,
        Blowout,
        BouncySparks,
        SensorData
    }

    public partial class ColorSystem : Form
    {
        public ColorSystem()
        {
            InitializeComponent();
        }

        States state = States.Color;
        Color current = Color.Blue;

        Transitions transCurrent = Transitions.Linear;
        decimal transSpeed = 1.5M;

        Idle idleCurrent = Idle.None;
        decimal cycleSpeed = 10M;
        decimal cycleDelay = 5M;
        Color idleColorCurrent = Color.White;
        bool idleReverseCycle = false;


        //stats
        int dataSent = 0;
        int dataReceived = 0;
        int dataErrors = 0;


        private void ColorSystem_Load(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;

            idleSpeed.Value = cycleSpeed;
            idleDelay.Value = cycleDelay;

            var allButtons = GetAll(this, typeof(Button));

            if (applyStateToolStripMenuItem.Checked)
                applyButton.Visible = true;
            else
                applyButton.Visible = false;

            basicColor(blueColor, null);
        }


        private void customColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelector = new ColorDialog();
            colorSelector.AllowFullOpen = true;
            colorSelector.SolidColorOnly = true;
            colorSelector.FullOpen = true;
            colorSelector.Color = customColor.BackColor;

            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                customColor.BackColor = colorSelector.Color;
                current = colorSelector.Color;
                Color foreColor = (PerceivedBrightness(current) > 130 ? Color.Black : Color.White);
                customColor.ForeColor = foreColor;
                update();
            }
            else
                AutoClosingMessageBox.Show("Color Will Not Be Set!", "Color Canceled", 1000);
        }

        private void basicColor(object sender, EventArgs e)
        {
            Button colorButton = sender as Button;
            current = colorButton.BackColor;
            update();
        }

        private void update(Button btn = null)
        {
            if (btn == null)
            {
                currentDisplay.Image = null;
                currentDisplay.BackColor = current;
                currentDisplay.Text = attemptColorName(current);
                Color foreColor = (PerceivedBrightness(current) > 130 ? Color.Black : Color.White);
                currentDisplay.ForeColor = foreColor;
                currentDisplay.BackgroundImage = null;
            }
            else
            {
                currentDisplay.Text = btn.Text;
                currentDisplay.BackgroundImage = btn.BackgroundImage != null ? btn.BackgroundImage : btn.Image;
                currentDisplay.BackColor = btn.BackColor;
                currentDisplay.ForeColor = btn.ForeColor;
            }
            if (!applyStateToolStripMenuItem.Checked)
            {
                apply();
            }
        }


        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private string attemptColorName(Color color)
        {
            string name = String.Format("R:{0}\nG:{1}\nB:{2}", color.R, color.G, color.B);
            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                Color known = Color.FromKnownColor(kc);
                if (color.ToArgb() == known.ToArgb())
                {
                    name = known.Name;
                }
            }
            return name;
        }


        private int PerceivedBrightness(Color c)
        {
            return (int)Math.Sqrt(
            c.R * c.R * .299 +
            c.G * c.G * .587 +
            c.B * c.B * .114);
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transitionSpeed_ValueChanged(object sender, EventArgs e)
        {
            transSpeed = transitionSpeed.Value;
        }
        private void idleSpeed_ValueChanged(object sender, EventArgs e)
        {
            cycleSpeed = idleSpeed.Value;
        }
        private void idleDelay_ValueChanged(object sender, EventArgs e)
        {
            cycleDelay = idleDelay.Value;
        }

        //STATES
        private void downloadState_Click(object sender, EventArgs e)
        {
            state = States.Download;
            update(downloadState);
        }
        private void uploadState_Click(object sender, EventArgs e)
        {
            state = States.Upload;
            update(uploadState);
        }
        private void discoState_Click(object sender, EventArgs e)
        {
            state = States.Disco;
            update(discoState);
        }
        private void shortCircuitState_Click(object sender, EventArgs e)
        {
            state = States.ShortCircuit;
            update(shortCircuitState);
        }
        private void bugsState_Click(object sender, EventArgs e)
        {
            state = States.Bugs;
            update(bugsState);
        }
        private void plasmaState_Click(object sender, EventArgs e)
        {
            state = States.Plasma;
            update(plasmaState);
        }
        private void rgbState_Click(object sender, EventArgs e)
        {
            state = States.RGB;
            update(rgbState);
        }
        private void failureState_Click(object sender, EventArgs e)
        {
            state = States.Failure;
            update(failureState);
        }
        private void victoryState_Click(object sender, EventArgs e)
        {
            state = States.Victory;
            update(victoryState);
        }

        private void applyStateToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (applyStateToolStripMenuItem.Checked)
            {
                applyButton.Visible = true;
                AutoClosingMessageBox.Show("THE APPLY BUTTON IS NOW [ENABLED]\nPlease note, this will mean the apply button will NEED to be pressed to apply ALL STATE CHANGES!", "Apply Button Enabled", 5000);
            }
            else
                applyButton.Visible = false;
        }

        private void idleChange(object sender, EventArgs e)
        {
            RadioButton newIdle = sender as RadioButton;
            idleName.Text = newIdle.Text;
        }

        private void transitionChange(object sender, EventArgs e)
        {
            RadioButton newTransition = sender as RadioButton;
            transitionName.Text = newTransition.Text;
        }

        private void idleColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelector = new ColorDialog();
            colorSelector.AllowFullOpen = true;
            colorSelector.SolidColorOnly = true;
            colorSelector.FullOpen = true;
            colorSelector.Color = idleColor.BackColor;

            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                idleColor.BackColor = colorSelector.Color;
                idleName.BackColor = colorSelector.Color;
                idleColorCurrent = colorSelector.Color;
                Color foreColor = (PerceivedBrightness(idleColorCurrent) > 130 ? Color.Black : Color.White);
                idleColor.ForeColor = foreColor;
                idleName.ForeColor = foreColor;
                update();
            }
            else
                AutoClosingMessageBox.Show("Idle Color Will Not Be Set!", "Idle Color Canceled", 1000);
        }

        private void connection_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            dataReceived++;
            amountReceivedBox.Text = dataReceived.ToString();
        }
        private void connection_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            dataErrors++;
            amountErrorsBox.Text = dataErrors.ToString();
        }

        private void macros_Click(object sender, EventArgs e)
        {
            Macro macMenu = new Macro();
            macMenu.Show();
        }

        private void blackoutState_Click(object sender, EventArgs e)
        {

        }

        private void ColorSystem_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            currentMacro.Text = e.KeyCode.ToString();
            if (Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.R))
            {
                MessageBox.Show("SUCCESS!");
            }
        }


        //MAGIC!
        private void apply(object sender, EventArgs e)
        {
            progressDisplay.Value = 100;
            //System.Threading.Thread.Sleep(1000);
            progressDisplay.Value = 0;
        }
        private void apply()
        {
            apply(null, null);
        }

        private void brightnessLevel_Scroll(object sender, EventArgs e)
        {
            int level = (int)Math.Ceiling(((double)brightnessLevel.Value / 255) * 100);
            brightnessLevelPercentage.Text = String.Format("%{0}", Math.Ceiling(((double)brightnessLevel.Value / 255) * 100));
            if (instaBright.Checked)
                send(string.Format("BRIGHTNESS B{0}", level));
        }







        private void send(string message)
        {
            lastSent.Text = message;
            if (connection.IsOpen)
            {

            }
            else
                newInformation("Connection not Established!", 255, 0, 0);
        }


        private void newInformation(string message, int r = 0, int g = 0, int b = 0)
        {
            information.ForeColor = Color.FromArgb(255, r, g, b);
            information.Text = message;
        }

        private void brightnessLevel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int level = (int)Math.Ceiling(((double)brightnessLevel.Value / 255) * 100);
            brightnessLevelPercentage.Text = String.Format("%{0}", Math.Ceiling(((double)brightnessLevel.Value / 255) * 100));
            if (!instaBright.Checked)
                send(string.Format("BRIGHTNESS B{0}", level));
        }


        //Effect clicks
        private void explosionEffect_Click(object sender, EventArgs e)
        {
            string cue = "EEXPLOSTION";
            sendEffect(cue);
        }
        private void sparksEffect_Click(object sender, EventArgs e)
        {
            string cue = "ESPARKS";
            sendEffect(cue);
        }
        private void brownoutEffect_Click(object sender, EventArgs e)
        {
            string cue = "EBROWNOUT";
            sendEffect(cue);
        }
        private void powerSurgeEffect_Click(object sender, EventArgs e)
        {
            string cue = "ESURGE";
            sendEffect(cue);
        }
        private void strobeEffect_Click(object sender, EventArgs e)
        {
            string cue = "ESTROBE";
            sendEffect(cue);
        }
        private void flickerEffect_Click(object sender, EventArgs e)
        {
            string cue = "EFLICKER";
            sendEffect(cue);
        }
        private void fireBlowoutEffect_Click(object sender, EventArgs e)
        {
            string cue = "EBLOWOUT";
            sendEffect(cue);
        }
        private void bouncySparks_Click(object sender, EventArgs e)
        {
            string cue = "EBOUNCY";
            sendEffect(cue);
        }
        private void sensorsEffect_Click(object sender, EventArgs e)
        {
            string cue = "ESENSORS";
            sendEffect(cue);
        }
        private void sendEffect(string cue)
        {
            int duration = (int)((double)effectDuration.Value * 1000);
            int tintRed = tintButton.BackColor.R;
            int tintBlue = tintButton.BackColor.G;
            int tintGreen = tintButton.BackColor.B;

            string comp = String.Format("EFFECT {0} D{1} R{2} G{3} B{4}", cue, duration, tintRed, tintBlue, tintGreen);
            send(comp);
        }
    }
}
