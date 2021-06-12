
namespace Sistema.Presentacion
{
    partial class Corresponsales
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
            this.CboCorresponsales = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CboCorresponsales
            // 
            this.CboCorresponsales.FormattingEnabled = true;
            this.CboCorresponsales.Location = new System.Drawing.Point(21, 29);
            this.CboCorresponsales.Name = "CboCorresponsales";
            this.CboCorresponsales.Size = new System.Drawing.Size(181, 21);
            this.CboCorresponsales.TabIndex = 0;
            // 
            // Corresponsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboCorresponsales);
            this.Name = "Corresponsales";
            this.Text = "Corresponsales";
            this.Load += new System.EventHandler(this.Corresponsales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCorresponsales;
    }
}