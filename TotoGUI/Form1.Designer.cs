namespace TotoGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.box_hossz = new System.Windows.Forms.CheckBox();
            this.box_rkarakter = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a forduló eredményeit [1,2,X]:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 276);
            this.textBox1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12X12X12X12X12";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // box_hossz
            // 
            this.box_hossz.AutoSize = true;
            this.box_hossz.BackColor = System.Drawing.SystemColors.ControlLight;
            this.box_hossz.Enabled = false;
            this.box_hossz.Location = new System.Drawing.Point(396, 390);
            this.box_hossz.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.box_hossz.Name = "box_hossz";
            this.box_hossz.Size = new System.Drawing.Size(577, 41);
            this.box_hossz.TabIndex = 2;
            this.box_hossz.Text = "Nem megfelelő karakterek száma (14)";
            this.box_hossz.UseVisualStyleBackColor = false;
            this.box_hossz.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // box_rkarakter
            // 
            this.box_rkarakter.AutoSize = true;
            this.box_rkarakter.Enabled = false;
            this.box_rkarakter.Location = new System.Drawing.Point(396, 487);
            this.box_rkarakter.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.box_rkarakter.Name = "box_rkarakter";
            this.box_rkarakter.Size = new System.Drawing.Size(567, 41);
            this.box_rkarakter.TabIndex = 3;
            this.box_rkarakter.Text = "Helytelen karakter az eredményben ()";
            this.box_rkarakter.UseVisualStyleBackColor = true;
            this.box_rkarakter.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 643);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eredmények mentése";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_rkarakter);
            this.Controls.Add(this.box_hossz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Form1";
            this.Text = "Totó eredmény ellenőrző";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox box_hossz;
        private System.Windows.Forms.CheckBox box_rkarakter;
        private System.Windows.Forms.Button button1;
    }
}

