namespace projeto2
{
    partial class Frm2
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomepi = new System.Windows.Forms.TextBox();
            this.txtAssento = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(229, 348);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(116, 43);
            this.btnExibir.TabIndex = 20;
            this.btnExibir.Text = "Exibir dados";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(61, 348);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 43);
            this.btnEnviar.TabIndex = 19;
            this.btnEnviar.Text = "Enviar dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor da passagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome do piloto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Número do assento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome cliente";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(135, 288);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 14;
            // 
            // txtNomepi
            // 
            this.txtNomepi.Location = new System.Drawing.Point(135, 217);
            this.txtNomepi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomepi.Name = "txtNomepi";
            this.txtNomepi.Size = new System.Drawing.Size(132, 22);
            this.txtNomepi.TabIndex = 13;
            // 
            // txtAssento
            // 
            this.txtAssento.Location = new System.Drawing.Point(135, 145);
            this.txtAssento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssento.Name = "txtAssento";
            this.txtAssento.Size = new System.Drawing.Size(132, 22);
            this.txtAssento.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 78);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Próximo formulário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomepi);
            this.Controls.Add(this.txtAssento);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm2";
            this.Text = "Projeto 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNomepi;
        private System.Windows.Forms.TextBox txtAssento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
    }
}