namespace Lighting
{
    partial class KeyCreator
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key2 = new System.Windows.Forms.TextBox();
            this.key3 = new System.Windows.Forms.TextBox();
            this.key4 = new System.Windows.Forms.TextBox();
            this.key5 = new System.Windows.Forms.TextBox();
            this.recordMacro = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(12, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(360, 22);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // key1
            // 
            this.key1.Location = new System.Drawing.Point(5, 90);
            this.key1.Margin = new System.Windows.Forms.Padding(0);
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Size = new System.Drawing.Size(74, 20);
            this.key1.TabIndex = 2;
            this.key1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keys";
            // 
            // key2
            // 
            this.key2.Location = new System.Drawing.Point(80, 90);
            this.key2.Margin = new System.Windows.Forms.Padding(0);
            this.key2.Name = "key2";
            this.key2.ReadOnly = true;
            this.key2.Size = new System.Drawing.Size(74, 20);
            this.key2.TabIndex = 4;
            this.key2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniChange);
            // 
            // key3
            // 
            this.key3.Location = new System.Drawing.Point(155, 90);
            this.key3.Margin = new System.Windows.Forms.Padding(0);
            this.key3.Name = "key3";
            this.key3.ReadOnly = true;
            this.key3.Size = new System.Drawing.Size(74, 20);
            this.key3.TabIndex = 5;
            this.key3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniChange);
            // 
            // key4
            // 
            this.key4.Location = new System.Drawing.Point(230, 90);
            this.key4.Margin = new System.Windows.Forms.Padding(0);
            this.key4.Name = "key4";
            this.key4.ReadOnly = true;
            this.key4.Size = new System.Drawing.Size(74, 20);
            this.key4.TabIndex = 6;
            this.key4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniChange);
            // 
            // key5
            // 
            this.key5.Location = new System.Drawing.Point(305, 90);
            this.key5.Margin = new System.Windows.Forms.Padding(0);
            this.key5.Name = "key5";
            this.key5.ReadOnly = true;
            this.key5.Size = new System.Drawing.Size(74, 20);
            this.key5.TabIndex = 7;
            this.key5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniChange);
            // 
            // recordMacro
            // 
            this.recordMacro.Location = new System.Drawing.Point(230, 113);
            this.recordMacro.Name = "recordMacro";
            this.recordMacro.Size = new System.Drawing.Size(149, 23);
            this.recordMacro.TabIndex = 8;
            this.recordMacro.Text = "Record Shortcut";
            this.recordMacro.UseVisualStyleBackColor = true;
            this.recordMacro.Click += new System.EventHandler(this.recordMacro_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Location = new System.Drawing.Point(12, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.acceptButton.Location = new System.Drawing.Point(230, 176);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(142, 23);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Macros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyCreator
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.recordMacro);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "KeyCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyCreator";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCreator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key2;
        private System.Windows.Forms.TextBox key3;
        private System.Windows.Forms.TextBox key4;
        private System.Windows.Forms.TextBox key5;
        private System.Windows.Forms.Button recordMacro;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button button1;
    }
}