
namespace Formularios
{
    partial class FrmExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportar));
            this.btnJson = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExportarTodo = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnVerCambiosSinGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJson
            // 
            this.btnJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnJson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJson.Location = new System.Drawing.Point(746, 510);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(376, 62);
            this.btnJson.TabIndex = 6;
            this.btnJson.Text = ".json";
            this.btnJson.UseVisualStyleBackColor = false;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXml.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXml.Location = new System.Drawing.Point(373, 510);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(374, 62);
            this.btnXml.TabIndex = 7;
            this.btnXml.Text = ".xml";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // picTitulo
            // 
            this.picTitulo.BackColor = System.Drawing.Color.Transparent;
            this.picTitulo.Image = ((System.Drawing.Image)(resources.GetObject("picTitulo.Image")));
            this.picTitulo.Location = new System.Drawing.Point(92, 12);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(921, 63);
            this.picTitulo.TabIndex = 9;
            this.picTitulo.TabStop = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.Location = new System.Drawing.Point(286, 189);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(507, 37);
            this.lblAyuda.TabIndex = 10;
            this.lblAyuda.Text = "Elija el formato en el que desea exportar";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblInfo.Location = new System.Drawing.Point(368, 118);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(329, 37);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Exportado correctamente";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Visible = false;
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnExportarTodo.FlatAppearance.BorderSize = 0;
            this.btnExportarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnExportarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnExportarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarTodo.Location = new System.Drawing.Point(1, 572);
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(1120, 86);
            this.btnExportarTodo.TabIndex = 18;
            this.btnExportarTodo.Text = "Exportar en los 3 archivos";
            this.btnExportarTodo.UseVisualStyleBackColor = false;
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportarTodo_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnCsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsv.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCsv.Location = new System.Drawing.Point(-1, 510);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(375, 62);
            this.btnCsv.TabIndex = 8;
            this.btnCsv.Text = ".csv";
            this.btnCsv.UseVisualStyleBackColor = false;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnVerCambiosSinGuardar
            // 
            this.btnVerCambiosSinGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnVerCambiosSinGuardar.FlatAppearance.BorderSize = 0;
            this.btnVerCambiosSinGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnVerCambiosSinGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnVerCambiosSinGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCambiosSinGuardar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerCambiosSinGuardar.Location = new System.Drawing.Point(438, 441);
            this.btnVerCambiosSinGuardar.Name = "btnVerCambiosSinGuardar";
            this.btnVerCambiosSinGuardar.Size = new System.Drawing.Size(253, 44);
            this.btnVerCambiosSinGuardar.TabIndex = 19;
            this.btnVerCambiosSinGuardar.Text = "Ver cambios sin guardar";
            this.btnVerCambiosSinGuardar.UseVisualStyleBackColor = false;
            this.btnVerCambiosSinGuardar.Click += new System.EventHandler(this.btnVerCambiosSinGuardar_Click);
            // 
            // FrmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1121, 658);
            this.Controls.Add(this.btnVerCambiosSinGuardar);
            this.Controls.Add(this.btnExportarTodo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.picTitulo);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnJson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExportar";
            this.Text = "FrmExportar";
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnExportarTodo;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnVerCambiosSinGuardar;
    }
}