namespace MinhaCalculadora
{
    partial class frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.tb_visor = new System.Windows.Forms.TextBox();
            this.tb_historico = new System.Windows.Forms.TextBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_maismenos = new System.Windows.Forms.Button();
            this.btn_fracao = new System.Windows.Forms.Button();
            this.btn_quadrado = new System.Windows.Forms.Button();
            this.btn_porcentagem = new System.Windows.Forms.Button();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_visor
            // 
            this.tb_visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_visor.Location = new System.Drawing.Point(12, 97);
            this.tb_visor.Name = "tb_visor";
            this.tb_visor.ReadOnly = true;
            this.tb_visor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_visor.Size = new System.Drawing.Size(390, 35);
            this.tb_visor.TabIndex = 2;
            this.tb_visor.Text = "0";
            this.tb_visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_historico
            // 
            this.tb_historico.BackColor = System.Drawing.SystemColors.Control;
            this.tb_historico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_historico.Enabled = false;
            this.tb_historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_historico.Location = new System.Drawing.Point(12, 59);
            this.tb_historico.Multiline = true;
            this.tb_historico.Name = "tb_historico";
            this.tb_historico.ReadOnly = true;
            this.tb_historico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_historico.Size = new System.Drawing.Size(390, 32);
            this.tb_historico.TabIndex = 2;
            this.tb_historico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_c
            // 
            this.btn_c.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_C;
            this.btn_c.Location = new System.Drawing.Point(212, 138);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(97, 57);
            this.btn_c.TabIndex = 3;
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_CE;
            this.btn_ce.Location = new System.Drawing.Point(109, 138);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(97, 57);
            this.btn_ce.TabIndex = 0;
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.BackColor = System.Drawing.Color.Transparent;
            this.btn_menos.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Menos;
            this.btn_menos.Location = new System.Drawing.Point(315, 327);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(97, 57);
            this.btn_menos.TabIndex = 0;
            this.btn_menos.UseVisualStyleBackColor = false;
            this.btn_menos.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_historico
            // 
            this.btn_historico.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Historico;
            this.btn_historico.Location = new System.Drawing.Point(347, 2);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(55, 51);
            this.btn_historico.TabIndex = 4;
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Apagar;
            this.btn_apagar.Location = new System.Drawing.Point(315, 138);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(97, 57);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_0
            // 
            this.btn_0.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_0;
            this.btn_0.Location = new System.Drawing.Point(109, 453);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(97, 57);
            this.btn_0.TabIndex = 1;
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_9
            // 
            this.btn_9.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_9;
            this.btn_9.Location = new System.Drawing.Point(212, 390);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(97, 57);
            this.btn_9.TabIndex = 1;
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_6
            // 
            this.btn_6.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_6;
            this.btn_6.Location = new System.Drawing.Point(212, 327);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(97, 57);
            this.btn_6.TabIndex = 1;
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_3
            // 
            this.btn_3.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_3;
            this.btn_3.Location = new System.Drawing.Point(212, 264);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(97, 57);
            this.btn_3.TabIndex = 1;
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_8
            // 
            this.btn_8.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_8;
            this.btn_8.Location = new System.Drawing.Point(109, 390);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(97, 57);
            this.btn_8.TabIndex = 1;
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_7
            // 
            this.btn_7.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_7;
            this.btn_7.Location = new System.Drawing.Point(6, 390);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(97, 57);
            this.btn_7.TabIndex = 1;
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_5
            // 
            this.btn_5.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_5;
            this.btn_5.Location = new System.Drawing.Point(109, 327);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(97, 57);
            this.btn_5.TabIndex = 1;
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_4
            // 
            this.btn_4.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_4;
            this.btn_4.Location = new System.Drawing.Point(6, 327);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(97, 57);
            this.btn_4.TabIndex = 1;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_2
            // 
            this.btn_2.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_2;
            this.btn_2.Location = new System.Drawing.Point(109, 264);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(97, 57);
            this.btn_2.TabIndex = 1;
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_1
            // 
            this.btn_1.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_1;
            this.btn_1.Location = new System.Drawing.Point(6, 264);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(97, 57);
            this.btn_1.TabIndex = 1;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.ClicouBotao);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Virgula;
            this.btn_virgula.Location = new System.Drawing.Point(212, 453);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(97, 57);
            this.btn_virgula.TabIndex = 0;
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_virgula_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Igual;
            this.btn_igual.Location = new System.Drawing.Point(315, 453);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(97, 57);
            this.btn_igual.TabIndex = 0;
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_maismenos
            // 
            this.btn_maismenos.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Maismenos;
            this.btn_maismenos.Location = new System.Drawing.Point(6, 453);
            this.btn_maismenos.Name = "btn_maismenos";
            this.btn_maismenos.Size = new System.Drawing.Size(97, 57);
            this.btn_maismenos.TabIndex = 0;
            this.btn_maismenos.UseVisualStyleBackColor = true;
            this.btn_maismenos.Click += new System.EventHandler(this.btn_maismenos_Click);
            // 
            // btn_fracao
            // 
            this.btn_fracao.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Inverso;
            this.btn_fracao.Location = new System.Drawing.Point(6, 201);
            this.btn_fracao.Name = "btn_fracao";
            this.btn_fracao.Size = new System.Drawing.Size(97, 57);
            this.btn_fracao.TabIndex = 0;
            this.btn_fracao.UseVisualStyleBackColor = true;
            this.btn_fracao.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_quadrado
            // 
            this.btn_quadrado.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Quadrado;
            this.btn_quadrado.Location = new System.Drawing.Point(109, 201);
            this.btn_quadrado.Name = "btn_quadrado";
            this.btn_quadrado.Size = new System.Drawing.Size(97, 57);
            this.btn_quadrado.TabIndex = 0;
            this.btn_quadrado.UseVisualStyleBackColor = true;
            this.btn_quadrado.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_porcentagem
            // 
            this.btn_porcentagem.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Porcentagem;
            this.btn_porcentagem.Location = new System.Drawing.Point(6, 138);
            this.btn_porcentagem.Name = "btn_porcentagem";
            this.btn_porcentagem.Size = new System.Drawing.Size(97, 57);
            this.btn_porcentagem.TabIndex = 0;
            this.btn_porcentagem.UseVisualStyleBackColor = true;
            this.btn_porcentagem.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_raiz
            // 
            this.btn_raiz.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Raiz;
            this.btn_raiz.Location = new System.Drawing.Point(212, 201);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(97, 57);
            this.btn_raiz.TabIndex = 0;
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_div
            // 
            this.btn_div.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Divisao;
            this.btn_div.Location = new System.Drawing.Point(315, 201);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(97, 57);
            this.btn_div.TabIndex = 0;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_mult
            // 
            this.btn_mult.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Multiplicacao;
            this.btn_mult.Location = new System.Drawing.Point(315, 264);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(97, 57);
            this.btn_mult.TabIndex = 0;
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // btn_mais
            // 
            this.btn_mais.Image = global::MinhaCalculadora.Properties.Resources.CalculadoraDesenho_Mais;
            this.btn_mais.Location = new System.Drawing.Point(315, 390);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(97, 57);
            this.btn_mais.TabIndex = 0;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_Click_Operacao);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(416, 516);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.tb_historico);
            this.Controls.Add(this.tb_visor);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_maismenos);
            this.Controls.Add(this.btn_fracao);
            this.Controls.Add(this.btn_quadrado);
            this.Controls.Add(this.btn_porcentagem);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_mais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_quadrado;
        private System.Windows.Forms.Button btn_fracao;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_porcentagem;
        public System.Windows.Forms.TextBox tb_visor;
        public System.Windows.Forms.TextBox tb_historico;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_maismenos;
    }
}

