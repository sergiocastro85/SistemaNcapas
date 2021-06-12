
namespace Sistema.Presentacion
{
    partial class RegistroComisionesPac
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
            this.CboPac = new System.Windows.Forms.ComboBox();
            this.CboTransaccion = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Corresponsal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboPac
            // 
            this.CboPac.FormattingEnabled = true;
            this.CboPac.Location = new System.Drawing.Point(31, 73);
            this.CboPac.Name = "CboPac";
            this.CboPac.Size = new System.Drawing.Size(121, 21);
            this.CboPac.TabIndex = 0;
            // 
            // CboTransaccion
            // 
            this.CboTransaccion.FormattingEnabled = true;
            this.CboTransaccion.Location = new System.Drawing.Point(31, 147);
            this.CboTransaccion.Name = "CboTransaccion";
            this.CboTransaccion.Size = new System.Drawing.Size(121, 21);
            this.CboTransaccion.TabIndex = 1;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(31, 221);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 20);
            this.TxtCantidad.TabIndex = 2;
            // 
            // Corresponsal
            // 
            this.Corresponsal.AutoSize = true;
            this.Corresponsal.Location = new System.Drawing.Point(31, 40);
            this.Corresponsal.Name = "Corresponsal";
            this.Corresponsal.Size = new System.Drawing.Size(54, 13);
            this.Corresponsal.TabIndex = 3;
            this.Corresponsal.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TRANSACCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(31, 273);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroComisionesPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Corresponsal);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.CboTransaccion);
            this.Controls.Add(this.CboPac);
            this.Name = "RegistroComisionesPac";
            this.Text = "RegistroComisionesPac";
            this.Load += new System.EventHandler(this.RegistroComisionesPac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboPac;
        private System.Windows.Forms.ComboBox CboTransaccion;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label Corresponsal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button button2;
    }
}