
namespace Formularios
{
    partial class FrmHermandad
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
            this.llbFuente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llbFuente
            // 
            this.llbFuente.AutoSize = true;
            this.llbFuente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbFuente.Location = new System.Drawing.Point(12, 24);
            this.llbFuente.Name = "llbFuente";
            this.llbFuente.Size = new System.Drawing.Size(315, 30);
            this.llbFuente.TabIndex = 0;
            this.llbFuente.TabStop = true;
            this.llbFuente.Text = "Fuente: Hermanos juramentados";
            this.llbFuente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbFuente_LinkClicked);
            // 
            // FrmHermandad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(117)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(335, 83);
            this.Controls.Add(this.llbFuente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHermandad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbFuente;
    }
}