
namespace Sistema.Presentacion.Reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DssSistema = new Sistema.Presentacion.Reportes.DssSistema();
            this.inventario_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventario_listarTableAdapter = new Sistema.Presentacion.Reportes.DssSistemaTableAdapters.inventario_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DssSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DssSistema";
            reportDataSource1.Value = this.inventario_listarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(501, 187);
            this.reportViewer1.TabIndex = 0;
            // 
            // DssSistema
            // 
            this.DssSistema.DataSetName = "DssSistema";
            this.DssSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventario_listarBindingSource
            // 
            this.inventario_listarBindingSource.DataMember = "inventario_listar";
            this.inventario_listarBindingSource.DataSource = this.DssSistema;
            // 
            // inventario_listarTableAdapter
            // 
            this.inventario_listarTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DssSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inventario_listarBindingSource;
        private DssSistema DssSistema;
        private DssSistemaTableAdapters.inventario_listarTableAdapter inventario_listarTableAdapter;
    }
}