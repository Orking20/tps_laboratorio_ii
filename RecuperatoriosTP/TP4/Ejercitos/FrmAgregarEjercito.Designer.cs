
namespace Formularios
{
    partial class FrmAgregarEjercito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEjercito));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.pnlNumero = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.pnlAutonomia = new System.Windows.Forms.Panel();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.cmbAutonomia = new System.Windows.Forms.ComboBox();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pnlNacion = new System.Windows.Forms.Panel();
            this.lblNacion = new System.Windows.Forms.Label();
            this.cmbNacion = new System.Windows.Forms.ComboBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.pnlNumero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.pnlAutonomia.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.pnlNacion.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(40, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar ejército";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(3, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.Controls.Add(this.pnlNumero);
            this.grpDatos.Controls.Add(this.pnlAutonomia);
            this.grpDatos.Controls.Add(this.pnlTipo);
            this.grpDatos.Controls.Add(this.pnlNacion);
            this.grpDatos.Controls.Add(this.pnlNombre);
            this.grpDatos.Location = new System.Drawing.Point(156, 154);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(828, 260);
            this.grpDatos.TabIndex = 3;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // pnlNumero
            // 
            this.pnlNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.pnlNumero.Controls.Add(this.lblNumero);
            this.pnlNumero.Controls.Add(this.nudNumero);
            this.pnlNumero.Location = new System.Drawing.Point(315, 161);
            this.pnlNumero.Name = "pnlNumero";
            this.pnlNumero.Size = new System.Drawing.Size(162, 58);
            this.pnlNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(3, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(130, 20);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número de tropas";
            // 
            // nudNumero
            // 
            this.nudNumero.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudNumero.Location = new System.Drawing.Point(3, 23);
            this.nudNumero.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(145, 23);
            this.nudNumero.TabIndex = 5;
            // 
            // pnlAutonomia
            // 
            this.pnlAutonomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.pnlAutonomia.Controls.Add(this.lblAutonomia);
            this.pnlAutonomia.Controls.Add(this.cmbAutonomia);
            this.pnlAutonomia.Location = new System.Drawing.Point(9, 161);
            this.pnlAutonomia.Name = "pnlAutonomia";
            this.pnlAutonomia.Size = new System.Drawing.Size(162, 58);
            this.pnlAutonomia.TabIndex = 14;
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.BackColor = System.Drawing.Color.Transparent;
            this.lblAutonomia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutonomia.Location = new System.Drawing.Point(3, 0);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(83, 20);
            this.lblAutonomia.TabIndex = 7;
            this.lblAutonomia.Text = "Autonomía";
            // 
            // cmbAutonomia
            // 
            this.cmbAutonomia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutonomia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAutonomia.FormattingEnabled = true;
            this.cmbAutonomia.Location = new System.Drawing.Point(3, 23);
            this.cmbAutonomia.Name = "cmbAutonomia";
            this.cmbAutonomia.Size = new System.Drawing.Size(145, 23);
            this.cmbAutonomia.TabIndex = 4;
            // 
            // pnlTipo
            // 
            this.pnlTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.pnlTipo.Controls.Add(this.lblTipo);
            this.pnlTipo.Controls.Add(this.cmbTipo);
            this.pnlTipo.Location = new System.Drawing.Point(625, 40);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(162, 58);
            this.pnlTipo.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 20);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de ejército";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(3, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(145, 23);
            this.cmbTipo.TabIndex = 3;
            // 
            // pnlNacion
            // 
            this.pnlNacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.pnlNacion.Controls.Add(this.lblNacion);
            this.pnlNacion.Controls.Add(this.cmbNacion);
            this.pnlNacion.Location = new System.Drawing.Point(315, 40);
            this.pnlNacion.Name = "pnlNacion";
            this.pnlNacion.Size = new System.Drawing.Size(162, 58);
            this.pnlNacion.TabIndex = 12;
            // 
            // lblNacion
            // 
            this.lblNacion.AutoSize = true;
            this.lblNacion.BackColor = System.Drawing.Color.Transparent;
            this.lblNacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacion.Location = new System.Drawing.Point(3, 0);
            this.lblNacion.Name = "lblNacion";
            this.lblNacion.Size = new System.Drawing.Size(56, 20);
            this.lblNacion.TabIndex = 3;
            this.lblNacion.Text = "Nación";
            // 
            // cmbNacion
            // 
            this.cmbNacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNacion.FormattingEnabled = true;
            this.cmbNacion.Location = new System.Drawing.Point(3, 23);
            this.cmbNacion.Name = "cmbNacion";
            this.cmbNacion.Size = new System.Drawing.Size(145, 23);
            this.cmbNacion.TabIndex = 2;
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.pnlNombre.Controls.Add(this.lblNombre);
            this.pnlNombre.Controls.Add(this.txtNombre);
            this.pnlNombre.Location = new System.Drawing.Point(6, 40);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(162, 58);
            this.pnlNombre.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(783, 553);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 45);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAgregarEjercito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1121, 658);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarEjercito";
            this.Text = "FrmAgregarEjercito";
            this.Load += new System.EventHandler(this.FrmAgregarEjercito_Load);
            this.grpDatos.ResumeLayout(false);
            this.pnlNumero.ResumeLayout(false);
            this.pnlNumero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.pnlAutonomia.ResumeLayout(false);
            this.pnlAutonomia.PerformLayout();
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.pnlNacion.ResumeLayout(false);
            this.pnlNacion.PerformLayout();
            this.pnlNombre.ResumeLayout(false);
            this.pnlNombre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cmbNacion;
        private System.Windows.Forms.Label lblNacion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbAutonomia;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.Panel pnlNumero;
        private System.Windows.Forms.Panel pnlAutonomia;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.Panel pnlNacion;
        private System.Windows.Forms.Button btnAgregar;
    }
}