using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lighting
{
    public partial class KeyCreator : Form
    {
        bool recording = false;
        int currentKey = 1;

        public string name = "";
        public List<Keys> bindings = new List<Keys>();

        public KeyCreator()
        {
            InitializeComponent();
        }

        TextBox microchange = null;

        private void KeyCreator_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            bool keyExists = false;
            foreach (Keys code in bindings)
                if (key == code)
                    keyExists = true;

            if (recording == true && keyExists == false)
            {
                switch (currentKey)
                {
                    case 1:
                        key1.Text = key.ToString();
                        bindings.Add(key);
                        break;
                    case 2:
                        key2.Text = key.ToString();
                        bindings.Add(key);
                        break;
                    case 3:
                        key3.Text = key.ToString();
                        bindings.Add(key);
                        break;
                    case 4:
                        key4.Text = key.ToString();
                        bindings.Add(key);
                        break;
                    case 5:
                        key5.Text = key.ToString();
                        bindings.Add(key);
                        recording = false;
                        currentKey = 0;
                        recordMacro.Text = "Record Shortcut";
                        recordMacro.ForeColor = Color.Black;
                        this.ActiveControl = nameLabel;
                        break;
                }
                currentKey++;
            }

            if (microchange != null)
            {
                microchange.Text = key.ToString();
                microchange.ForeColor = Color.Black;
                microchange = null;

                bindings.Clear();

                Keys key1Data;
                Enum.TryParse(key1.Text, out key1Data);
                bindings.Add(key1Data);

                Keys key2Data;
                Enum.TryParse(key2.Text, out key2Data);
                bindings.Add(key2Data);

                Keys key3Data;
                Enum.TryParse(key3.Text, out key3Data);
                bindings.Add(key3Data);

                Keys key4Data;
                Enum.TryParse(key4.Text, out key4Data);
                bindings.Add(key4Data);

                Keys key5Data;
                Enum.TryParse(key5.Text, out key5Data);
                bindings.Add(key5Data);
            }
        }

        private void recordMacro_Click(object sender, EventArgs e)
        {
            if (recording == false)
            {
                MessageBox.Show("Recording will start after this window is closed. Press a combination of keys that you want to use as a macro. Recording will stop when you use 5 keys or press the record button again.");
                bindings.Clear();
                key1.Text = null;
                key2.Text = null;
                key3.Text = null;
                key4.Text = null;
                key5.Text = null;
                recording = true;
                currentKey = 1;
                recordMacro.Text = " • RECORDING!";
                recordMacro.ForeColor = Color.Red;
            }
            else
            {
                recording = false;
                recordMacro.Text = "Record Shortcut";
                recordMacro.ForeColor = Color.Black;
                this.ActiveControl = nameLabel;
            }
        }

        private void miniChange(object sender, MouseEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Red;
            microchange = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindings.Clear();
            key1.Text = null;
            key2.Text = null;
            key3.Text = null;
            key4.Text = null;
            key5.Text = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            bindings.Clear();
            name = "";
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            this.Close();
        }
    }
}
