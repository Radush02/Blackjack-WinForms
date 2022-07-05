namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeltest = new System.Windows.Forms.Label();
            this.buttonhit = new System.Windows.Forms.Button();
            this.labelscor = new System.Windows.Forms.Label();
            this.labeldealer = new System.Windows.Forms.Label();
            this.labelscordealer = new System.Windows.Forms.Label();
            this.buttonstand = new System.Windows.Forms.Button();
            this.buttondoubledown = new System.Windows.Forms.Button();
            this.buttonrestart = new System.Windows.Forms.Button();
            this.labelcredite = new System.Windows.Forms.Label();
            this.labelmiza = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonsurrender = new System.Windows.Forms.Button();
            this.insurance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltest
            // 
            this.labeltest.AutoSize = true;
            this.labeltest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltest.Location = new System.Drawing.Point(153, 79);
            this.labeltest.Name = "labeltest";
            this.labeltest.Size = new System.Drawing.Size(173, 41);
            this.labeltest.TabIndex = 0;
            this.labeltest.Text = "carti jucator";
            // 
            // buttonhit
            // 
            this.buttonhit.Location = new System.Drawing.Point(153, 473);
            this.buttonhit.Name = "buttonhit";
            this.buttonhit.Size = new System.Drawing.Size(113, 40);
            this.buttonhit.TabIndex = 1;
            this.buttonhit.Text = "Hit";
            this.buttonhit.UseVisualStyleBackColor = true;
            this.buttonhit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelscor
            // 
            this.labelscor.AutoSize = true;
            this.labelscor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelscor.Location = new System.Drawing.Point(153, 307);
            this.labelscor.Name = "labelscor";
            this.labelscor.Size = new System.Drawing.Size(252, 41);
            this.labelscor.TabIndex = 2;
            this.labelscor.Text = "suma carti jucator";
            // 
            // labeldealer
            // 
            this.labeldealer.AutoSize = true;
            this.labeldealer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldealer.Location = new System.Drawing.Point(614, 79);
            this.labeldealer.Name = "labeldealer";
            this.labeldealer.Size = new System.Drawing.Size(164, 41);
            this.labeldealer.TabIndex = 3;
            this.labeldealer.Text = "carti dealer";
            // 
            // labelscordealer
            // 
            this.labelscordealer.AutoSize = true;
            this.labelscordealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelscordealer.Location = new System.Drawing.Point(614, 307);
            this.labelscordealer.Name = "labelscordealer";
            this.labelscordealer.Size = new System.Drawing.Size(240, 36);
            this.labelscordealer.TabIndex = 4;
            this.labelscordealer.Text = "suma carti dealer";
            // 
            // buttonstand
            // 
            this.buttonstand.Location = new System.Drawing.Point(328, 473);
            this.buttonstand.Name = "buttonstand";
            this.buttonstand.Size = new System.Drawing.Size(113, 40);
            this.buttonstand.TabIndex = 5;
            this.buttonstand.Text = "Stand";
            this.buttonstand.UseVisualStyleBackColor = true;
            this.buttonstand.Click += new System.EventHandler(this.buttonstand_Click);
            // 
            // buttondoubledown
            // 
            this.buttondoubledown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttondoubledown.Location = new System.Drawing.Point(490, 473);
            this.buttondoubledown.Name = "buttondoubledown";
            this.buttondoubledown.Size = new System.Drawing.Size(167, 40);
            this.buttondoubledown.TabIndex = 6;
            this.buttondoubledown.Text = "Double Down";
            this.buttondoubledown.UseVisualStyleBackColor = true;
            this.buttondoubledown.Click += new System.EventHandler(this.buttondoubledown_Click);
            // 
            // buttonrestart
            // 
            this.buttonrestart.Location = new System.Drawing.Point(445, 568);
            this.buttonrestart.Name = "buttonrestart";
            this.buttonrestart.Size = new System.Drawing.Size(181, 36);
            this.buttonrestart.TabIndex = 7;
            this.buttonrestart.Text = "Joc nou";
            this.buttonrestart.UseVisualStyleBackColor = true;
            this.buttonrestart.Click += new System.EventHandler(this.buttonrestart_Click);
            // 
            // labelcredite
            // 
            this.labelcredite.AutoSize = true;
            this.labelcredite.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcredite.Location = new System.Drawing.Point(85, 559);
            this.labelcredite.Name = "labelcredite";
            this.labelcredite.Size = new System.Drawing.Size(209, 41);
            this.labelcredite.TabIndex = 8;
            this.labelcredite.Text = "Credite: 10000";
            this.labelcredite.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelmiza
            // 
            this.labelmiza.AutoEllipsis = true;
            this.labelmiza.AutoSize = true;
            this.labelmiza.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmiza.Location = new System.Drawing.Point(708, 563);
            this.labelmiza.Name = "labelmiza";
            this.labelmiza.Size = new System.Drawing.Size(96, 41);
            this.labelmiza.TabIndex = 9;
            this.labelmiza.Text = "Miza: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(810, 561);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 47);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonsurrender
            // 
            this.buttonsurrender.Location = new System.Drawing.Point(708, 473);
            this.buttonsurrender.Name = "buttonsurrender";
            this.buttonsurrender.Size = new System.Drawing.Size(182, 40);
            this.buttonsurrender.TabIndex = 11;
            this.buttonsurrender.Text = "Surrender";
            this.buttonsurrender.UseVisualStyleBackColor = true;
            this.buttonsurrender.Click += new System.EventHandler(this.buttonsurrender_Click);
            // 
            // insurance
            // 
            this.insurance.AutoSize = true;
            this.insurance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insurance.Location = new System.Drawing.Point(614, 79);
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(0, 41);
            this.insurance.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 680);
            this.Controls.Add(this.insurance);
            this.Controls.Add(this.buttonsurrender);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelmiza);
            this.Controls.Add(this.labelcredite);
            this.Controls.Add(this.buttonrestart);
            this.Controls.Add(this.buttondoubledown);
            this.Controls.Add(this.buttonstand);
            this.Controls.Add(this.labelscordealer);
            this.Controls.Add(this.labeldealer);
            this.Controls.Add(this.labelscor);
            this.Controls.Add(this.buttonhit);
            this.Controls.Add(this.labeltest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltest;
        private System.Windows.Forms.Button buttonhit;
        private System.Windows.Forms.Label labelscor;
        private System.Windows.Forms.Label labeldealer;
        private System.Windows.Forms.Label labelscordealer;
        private System.Windows.Forms.Button buttonstand;
        private System.Windows.Forms.Button buttondoubledown;
        private System.Windows.Forms.Button buttonrestart;
        private System.Windows.Forms.Label labelcredite;
        private System.Windows.Forms.Label labelmiza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonsurrender;
        private System.Windows.Forms.Label insurance;
    }
}

