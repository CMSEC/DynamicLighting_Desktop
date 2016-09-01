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
    public partial class Macro : Form
    {
        bool saved = false;
        public Macro()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Macro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("You have not saved your changes! Do you wish to save?", "Save Macros", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saved = true;
                }
                else if (result == DialogResult.No)
                {
                    saved = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Macro_Load(object sender, EventArgs e)
        {
            macros.Columns.Clear();
            macros.GridLines = true;
            macros.View = View.Details;
            macros.Columns.Add("#", 50, HorizontalAlignment.Left);
            macros.Columns.Add("Name", 150, HorizontalAlignment.Left);
            macros.Columns.Add("Action", 225, HorizontalAlignment.Left);
            macros.Columns.Add("Binding", 350, HorizontalAlignment.Left);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            KeyCreator creator = new KeyCreator();
            creator.ShowDialog();
            string name = creator.name;
            List<Keys> bindings = creator.bindings;

            string bindr = "";
            for (int i = 0; i < bindings.Count; i++)
            {
                bindr += bindings[i].ToString();
                if (i < (bindings.Count - 1))
                    bindr += " + ";
            }

            ListViewItem item = new ListViewItem(new[] { macros.Items.Count.ToString(), name, "Undefined Action", bindr });
            macros.Items.Add(item);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saved = true;
        }



        //SENDING THE DATA!!!
        private void apply()
        {

        }
        //SENDING THE DATA!!!
    }
}
