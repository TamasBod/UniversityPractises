namespace VAR_2022
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
            this.dGw = new System.Windows.Forms.DataGridView();
            this.dGW2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).BeginInit();
            this.SuspendLayout();
            // 
            // dGw
            // 
            this.dGw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGw.Location = new System.Drawing.Point(134, 99);
            this.dGw.Name = "dGw";
            this.dGw.Size = new System.Drawing.Size(240, 150);
            this.dGw.TabIndex = 0;
            // 
            // dGW2
            // 
            this.dGW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW2.Location = new System.Drawing.Point(401, 99);
            this.dGW2.Name = "dGW2";
            this.dGW2.Size = new System.Drawing.Size(240, 150);
            this.dGW2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGW2);
            this.Controls.Add(this.dGw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGw;
        private System.Windows.Forms.DataGridView dGW2;
    }
}

