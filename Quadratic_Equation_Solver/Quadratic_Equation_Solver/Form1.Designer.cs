namespace Quadratic_Equation_Solver
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
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.txtb4 = new System.Windows.Forms.TextBox();
            this.txtb5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(91, 34);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 20);
            this.txtb1.TabIndex = 0;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(91, 60);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 20);
            this.txtb2.TabIndex = 1;
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(91, 86);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(100, 20);
            this.txtb3.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(69, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "a:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(69, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "b:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(69, 86);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(16, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "c:";
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(91, 113);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(100, 23);
            this.buttonstart.TabIndex = 6;
            this.buttonstart.Text = "&Start!";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // txtb4
            // 
            this.txtb4.BackColor = System.Drawing.SystemColors.Info;
            this.txtb4.Enabled = false;
            this.txtb4.Location = new System.Drawing.Point(91, 143);
            this.txtb4.Name = "txtb4";
            this.txtb4.Size = new System.Drawing.Size(100, 20);
            this.txtb4.TabIndex = 7;
            // 
            // txtb5
            // 
            this.txtb5.BackColor = System.Drawing.SystemColors.Info;
            this.txtb5.Enabled = false;
            this.txtb5.Location = new System.Drawing.Point(91, 169);
            this.txtb5.Name = "txtb5";
            this.txtb5.Size = new System.Drawing.Size(100, 20);
            this.txtb5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 268);
            this.Controls.Add(this.txtb5);
            this.Controls.Add(this.txtb4);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.TextBox txtb5;
    }
}

