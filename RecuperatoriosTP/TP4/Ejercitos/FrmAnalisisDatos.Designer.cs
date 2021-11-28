
namespace Formularios
{
    partial class FrmAnalisisDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnalisisDatos));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnDormenios = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.btnEridios = new System.Windows.Forms.Button();
            this.btnGuneares = new System.Windows.Forms.Button();
            this.btnAutonomiaCompleta = new System.Windows.Forms.Button();
            this.btnHarrasianos = new System.Windows.Forms.Button();
            this.btnCaballeriaBuenaAutonomia = new System.Windows.Forms.Button();
            this.btnInfanteriaLigera = new System.Windows.Forms.Button();
            this.btnMayores5000 = new System.Windows.Forms.Button();
            this.btnInfanteriaEntre1000Y5000 = new System.Windows.Forms.Button();
            this.dgvEjercitos = new System.Windows.Forms.DataGridView();
            this.Criterio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxInfo = new System.Windows.Forms.RichTextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rtxMejorEjercito = new System.Windows.Forms.RichTextBox();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(115)))));
            this.pnlBotones.Controls.Add(this.btnExportar);
            this.pnlBotones.Controls.Add(this.btnDormenios);
            this.pnlBotones.Controls.Add(this.lblInfo);
            this.pnlBotones.Controls.Add(this.lblAyuda);
            this.pnlBotones.Controls.Add(this.btnEridios);
            this.pnlBotones.Controls.Add(this.btnGuneares);
            this.pnlBotones.Controls.Add(this.btnAutonomiaCompleta);
            this.pnlBotones.Controls.Add(this.btnHarrasianos);
            this.pnlBotones.Controls.Add(this.btnCaballeriaBuenaAutonomia);
            this.pnlBotones.Controls.Add(this.btnInfanteriaLigera);
            this.pnlBotones.Controls.Add(this.btnMayores5000);
            this.pnlBotones.Controls.Add(this.btnInfanteriaEntre1000Y5000);
            this.pnlBotones.Location = new System.Drawing.Point(0, 523);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1121, 135);
            this.pnlBotones.TabIndex = 20;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.Location = new System.Drawing.Point(977, 0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(144, 135);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnDormenios
            // 
            this.btnDormenios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnDormenios.FlatAppearance.BorderSize = 0;
            this.btnDormenios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnDormenios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnDormenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormenios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDormenios.Location = new System.Drawing.Point(0, 0);
            this.btnDormenios.Name = "btnDormenios";
            this.btnDormenios.Size = new System.Drawing.Size(144, 45);
            this.btnDormenios.TabIndex = 13;
            this.btnDormenios.Text = "Dormenios";
            this.btnDormenios.UseVisualStyleBackColor = false;
            this.btnDormenios.Click += new System.EventHandler(this.btnDormenios_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblInfo.Location = new System.Drawing.Point(634, 79);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(260, 30);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Guardado correctamente";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Visible = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.Location = new System.Drawing.Point(559, 20);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(401, 25);
            this.lblAyuda.TabIndex = 18;
            this.lblAyuda.Text = "Se generará un archivo con los datos filtrados";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEridios
            // 
            this.btnEridios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnEridios.FlatAppearance.BorderSize = 0;
            this.btnEridios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnEridios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnEridios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEridios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEridios.Location = new System.Drawing.Point(0, 45);
            this.btnEridios.Name = "btnEridios";
            this.btnEridios.Size = new System.Drawing.Size(144, 45);
            this.btnEridios.TabIndex = 12;
            this.btnEridios.Text = "Eridios";
            this.btnEridios.UseVisualStyleBackColor = false;
            this.btnEridios.Click += new System.EventHandler(this.btnEridios_Click);
            // 
            // btnGuneares
            // 
            this.btnGuneares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnGuneares.FlatAppearance.BorderSize = 0;
            this.btnGuneares.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnGuneares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnGuneares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuneares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuneares.Location = new System.Drawing.Point(0, 90);
            this.btnGuneares.Name = "btnGuneares";
            this.btnGuneares.Size = new System.Drawing.Size(144, 45);
            this.btnGuneares.TabIndex = 6;
            this.btnGuneares.Text = "Guneares";
            this.btnGuneares.UseVisualStyleBackColor = false;
            this.btnGuneares.Click += new System.EventHandler(this.btnGuneares_Click);
            // 
            // btnAutonomiaCompleta
            // 
            this.btnAutonomiaCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnAutonomiaCompleta.FlatAppearance.BorderSize = 0;
            this.btnAutonomiaCompleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnAutonomiaCompleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnAutonomiaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutonomiaCompleta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutonomiaCompleta.Location = new System.Drawing.Point(288, 90);
            this.btnAutonomiaCompleta.Name = "btnAutonomiaCompleta";
            this.btnAutonomiaCompleta.Size = new System.Drawing.Size(253, 45);
            this.btnAutonomiaCompleta.TabIndex = 16;
            this.btnAutonomiaCompleta.Text = "Autonomía completa";
            this.btnAutonomiaCompleta.UseVisualStyleBackColor = false;
            this.btnAutonomiaCompleta.Click += new System.EventHandler(this.btnAutonomiaCompleta_Click);
            // 
            // btnHarrasianos
            // 
            this.btnHarrasianos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnHarrasianos.FlatAppearance.BorderSize = 0;
            this.btnHarrasianos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnHarrasianos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnHarrasianos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarrasianos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHarrasianos.Location = new System.Drawing.Point(144, 0);
            this.btnHarrasianos.Name = "btnHarrasianos";
            this.btnHarrasianos.Size = new System.Drawing.Size(144, 45);
            this.btnHarrasianos.TabIndex = 11;
            this.btnHarrasianos.Text = "Herrasianos";
            this.btnHarrasianos.UseVisualStyleBackColor = false;
            this.btnHarrasianos.Click += new System.EventHandler(this.btnHarrasianos_Click);
            // 
            // btnCaballeriaBuenaAutonomia
            // 
            this.btnCaballeriaBuenaAutonomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnCaballeriaBuenaAutonomia.FlatAppearance.BorderSize = 0;
            this.btnCaballeriaBuenaAutonomia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnCaballeriaBuenaAutonomia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnCaballeriaBuenaAutonomia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaballeriaBuenaAutonomia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaballeriaBuenaAutonomia.Location = new System.Drawing.Point(288, 45);
            this.btnCaballeriaBuenaAutonomia.Name = "btnCaballeriaBuenaAutonomia";
            this.btnCaballeriaBuenaAutonomia.Size = new System.Drawing.Size(253, 45);
            this.btnCaballeriaBuenaAutonomia.TabIndex = 15;
            this.btnCaballeriaBuenaAutonomia.Text = "Cabellería con buena autonomía";
            this.btnCaballeriaBuenaAutonomia.UseVisualStyleBackColor = false;
            this.btnCaballeriaBuenaAutonomia.Click += new System.EventHandler(this.btnCaballeriaBuenaAutonomia_Click);
            // 
            // btnInfanteriaLigera
            // 
            this.btnInfanteriaLigera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnInfanteriaLigera.FlatAppearance.BorderSize = 0;
            this.btnInfanteriaLigera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnInfanteriaLigera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnInfanteriaLigera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfanteriaLigera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfanteriaLigera.Location = new System.Drawing.Point(144, 45);
            this.btnInfanteriaLigera.Name = "btnInfanteriaLigera";
            this.btnInfanteriaLigera.Size = new System.Drawing.Size(144, 45);
            this.btnInfanteriaLigera.TabIndex = 8;
            this.btnInfanteriaLigera.Text = "Infantería ligera";
            this.btnInfanteriaLigera.UseVisualStyleBackColor = false;
            this.btnInfanteriaLigera.Click += new System.EventHandler(this.btnInfanteriaLigera_Click);
            // 
            // btnMayores5000
            // 
            this.btnMayores5000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnMayores5000.FlatAppearance.BorderSize = 0;
            this.btnMayores5000.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnMayores5000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnMayores5000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayores5000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMayores5000.Location = new System.Drawing.Point(144, 90);
            this.btnMayores5000.Name = "btnMayores5000";
            this.btnMayores5000.Size = new System.Drawing.Size(144, 45);
            this.btnMayores5000.TabIndex = 9;
            this.btnMayores5000.Text = "Ejercitos >= 5000";
            this.btnMayores5000.UseVisualStyleBackColor = false;
            this.btnMayores5000.Click += new System.EventHandler(this.btnMayores5000_Click);
            // 
            // btnInfanteriaEntre1000Y5000
            // 
            this.btnInfanteriaEntre1000Y5000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnInfanteriaEntre1000Y5000.FlatAppearance.BorderSize = 0;
            this.btnInfanteriaEntre1000Y5000.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnInfanteriaEntre1000Y5000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnInfanteriaEntre1000Y5000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfanteriaEntre1000Y5000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfanteriaEntre1000Y5000.Location = new System.Drawing.Point(288, 0);
            this.btnInfanteriaEntre1000Y5000.Name = "btnInfanteriaEntre1000Y5000";
            this.btnInfanteriaEntre1000Y5000.Size = new System.Drawing.Size(253, 45);
            this.btnInfanteriaEntre1000Y5000.TabIndex = 14;
            this.btnInfanteriaEntre1000Y5000.Text = "Infantería entre 1000 y 5000";
            this.btnInfanteriaEntre1000Y5000.UseVisualStyleBackColor = false;
            this.btnInfanteriaEntre1000Y5000.Click += new System.EventHandler(this.btnInfanteriaEntre1000Y5000_Click);
            // 
            // dgvEjercitos
            // 
            this.dgvEjercitos.AllowUserToAddRows = false;
            this.dgvEjercitos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.dgvEjercitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjercitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criterio,
            this.Porcentaje});
            this.dgvEjercitos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEjercitos.Location = new System.Drawing.Point(244, 138);
            this.dgvEjercitos.Name = "dgvEjercitos";
            this.dgvEjercitos.RowTemplate.Height = 25;
            this.dgvEjercitos.Size = new System.Drawing.Size(607, 48);
            this.dgvEjercitos.TabIndex = 21;
            // 
            // Criterio
            // 
            this.Criterio.HeaderText = "Criterio";
            this.Criterio.Name = "Criterio";
            this.Criterio.Width = 450;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 115;
            // 
            // rtxInfo
            // 
            this.rtxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxInfo.Location = new System.Drawing.Point(12, 205);
            this.rtxInfo.Name = "rtxInfo";
            this.rtxInfo.ReadOnly = true;
            this.rtxInfo.Size = new System.Drawing.Size(537, 267);
            this.rtxInfo.TabIndex = 23;
            this.rtxInfo.Text = "";
            this.rtxInfo.Visible = false;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.btnAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(162)))));
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalisis.Location = new System.Drawing.Point(0, 478);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(1121, 45);
            this.btnAnalisis.TabIndex = 24;
            this.btnAnalisis.Text = "Análisis";
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(476, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // rtxMejorEjercito
            // 
            this.rtxMejorEjercito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMejorEjercito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxMejorEjercito.Location = new System.Drawing.Point(555, 205);
            this.rtxMejorEjercito.Name = "rtxMejorEjercito";
            this.rtxMejorEjercito.ReadOnly = true;
            this.rtxMejorEjercito.Size = new System.Drawing.Size(554, 267);
            this.rtxMejorEjercito.TabIndex = 26;
            this.rtxMejorEjercito.Text = "";
            this.rtxMejorEjercito.Visible = false;
            // 
            // FrmAnalisisDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1121, 658);
            this.Controls.Add(this.rtxMejorEjercito);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.rtxInfo);
            this.Controls.Add(this.dgvEjercitos);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnalisisDatos";
            this.Text = "FrmAnalisisDatos";
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnDormenios;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Button btnEridios;
        private System.Windows.Forms.Button btnGuneares;
        private System.Windows.Forms.Button btnAutonomiaCompleta;
        private System.Windows.Forms.Button btnHarrasianos;
        private System.Windows.Forms.Button btnCaballeriaBuenaAutonomia;
        private System.Windows.Forms.Button btnInfanteriaLigera;
        private System.Windows.Forms.Button btnMayores5000;
        private System.Windows.Forms.Button btnInfanteriaEntre1000Y5000;
        private System.Windows.Forms.DataGridView dgvEjercitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criterio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.RichTextBox rtxInfo;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox rtxMejorEjercito;
    }
}