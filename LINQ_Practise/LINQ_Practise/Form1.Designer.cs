﻿namespace LINQ_Practise
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
            this.listCountries = new System.Windows.Forms.ListBox();
            this.txtCountryFilter = new System.Windows.Forms.TextBox();
            this.dgwRamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).BeginInit();
            this.SuspendLayout();
            // 
            // listCountries
            // 
            this.listCountries.FormattingEnabled = true;
            this.listCountries.ItemHeight = 15;
            this.listCountries.Location = new System.Drawing.Point(30, 70);
            this.listCountries.Name = "listCountries";
            this.listCountries.Size = new System.Drawing.Size(120, 304);
            this.listCountries.TabIndex = 0;
            // 
            // txtCountryFilter
            // 
            this.txtCountryFilter.Location = new System.Drawing.Point(30, 30);
            this.txtCountryFilter.Name = "txtCountryFilter";
            this.txtCountryFilter.Size = new System.Drawing.Size(119, 23);
            this.txtCountryFilter.TabIndex = 1;
            // 
            // dgwRamen
            // 
            this.dgwRamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRamen.Location = new System.Drawing.Point(167, 70);
            this.dgwRamen.Name = "dgwRamen";
            this.dgwRamen.RowTemplate.Height = 25;
            this.dgwRamen.Size = new System.Drawing.Size(316, 304);
            this.dgwRamen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwRamen);
            this.Controls.Add(this.txtCountryFilter);
            this.Controls.Add(this.listCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listCountries;
        private TextBox txtCountryFilter;
        private DataGridView dgwRamen;
    }
}