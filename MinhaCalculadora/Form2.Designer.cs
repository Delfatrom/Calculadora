using System.Windows.Forms;

namespace MinhaCalculadora
{
    partial class frm_Historico : Form
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
            this.tb_historicocompleto = new System.Windows.Forms.TextBox();
            this.btn_limparhistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_historicocompleto
            // 
            this.tb_historicocompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_historicocompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_historicocompleto.Enabled = false;
            this.tb_historicocompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_historicocompleto.Location = new System.Drawing.Point(0, 0);
            this.tb_historicocompleto.Multiline = true;
            this.tb_historicocompleto.Name = "tb_historicocompleto";
            this.tb_historicocompleto.ReadOnly = true;
            this.tb_historicocompleto.Size = new System.Drawing.Size(357, 416);
            this.tb_historicocompleto.TabIndex = 0;
            this.tb_historicocompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_limparhistorico
            // 
            this.btn_limparhistorico.Location = new System.Drawing.Point(133, 367);
            this.btn_limparhistorico.Name = "btn_limparhistorico";
            this.btn_limparhistorico.Size = new System.Drawing.Size(75, 37);
            this.btn_limparhistorico.TabIndex = 1;
            this.btn_limparhistorico.Text = "Limpar";
            this.btn_limparhistorico.UseVisualStyleBackColor = true;
            this.btn_limparhistorico.Click += new System.EventHandler(this.btn_limparhistorico_Click);
            // 
            // frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(357, 416);
            this.Controls.Add(this.btn_limparhistorico);
            this.Controls.Add(this.tb_historicocompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_historicocompleto;
        private System.Windows.Forms.Button btn_limparhistorico;
    }
}