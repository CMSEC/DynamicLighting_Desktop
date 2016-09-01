namespace Lighting
{
    partial class AutoConnector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gif = new System.Windows.Forms.PictureBox();
            this.portDisplay = new System.Windows.Forms.Label();
            this.baudDisplay = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.Image = global::Lighting.Properties.Resources.final;
            this.gif.Location = new System.Drawing.Point(0, 0);
            this.gif.Margin = new System.Windows.Forms.Padding(0);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(350, 200);
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            // 
            // portDisplay
            // 
            this.portDisplay.BackColor = System.Drawing.Color.Black;
            this.portDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.portDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.portDisplay.Location = new System.Drawing.Point(12, 156);
            this.portDisplay.Name = "portDisplay";
            this.portDisplay.Size = new System.Drawing.Size(150, 35);
            this.portDisplay.TabIndex = 1;
            this.portDisplay.Text = "PORT";
            this.portDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baudDisplay
            // 
            this.baudDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baudDisplay.BackColor = System.Drawing.Color.Black;
            this.baudDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.baudDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.baudDisplay.Location = new System.Drawing.Point(188, 156);
            this.baudDisplay.Name = "baudDisplay";
            this.baudDisplay.Size = new System.Drawing.Size(150, 35);
            this.baudDisplay.TabIndex = 2;
            this.baudDisplay.Text = "BAUD";
            this.baudDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BackColor = System.Drawing.Color.Black;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.output.ForeColor = System.Drawing.SystemColors.Control;
            this.output.Location = new System.Drawing.Point(10, 203);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(330, 36);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // AutoConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 236);
            this.Controls.Add(this.output);
            this.Controls.Add(this.baudDisplay);
            this.Controls.Add(this.portDisplay);
            this.Controls.Add(this.gif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(366, 850);
            this.Name = "AutoConnector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Connector";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AutoConnector_Load);
            this.Shown += new System.EventHandler(this.AutoConnector_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.Label portDisplay;
        private System.Windows.Forms.Label baudDisplay;
        private System.Windows.Forms.RichTextBox output;
    }
}