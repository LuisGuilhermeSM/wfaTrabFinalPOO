namespace wfaTrabFinalPOO
{
    partial class FormEditaVenda
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
            this.lbPrecoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConcluir = new System.Windows.Forms.Button();
            this.rbCondicional = new System.Windows.Forms.RadioButton();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.tbCodigoCalcado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCPFParaVenda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPrecoTotal
            // 
            this.lbPrecoTotal.AutoSize = true;
            this.lbPrecoTotal.BackColor = System.Drawing.Color.White;
            this.lbPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoTotal.Location = new System.Drawing.Point(122, 194);
            this.lbPrecoTotal.Name = "lbPrecoTotal";
            this.lbPrecoTotal.Size = new System.Drawing.Size(57, 20);
            this.lbPrecoTotal.TabIndex = 30;
            this.lbPrecoTotal.Text = "R$ 0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Preço total:";
            // 
            // btConcluir
            // 
            this.btConcluir.Location = new System.Drawing.Point(75, 267);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(129, 60);
            this.btConcluir.TabIndex = 26;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // rbCondicional
            // 
            this.rbCondicional.AutoSize = true;
            this.rbCondicional.Location = new System.Drawing.Point(145, 114);
            this.rbCondicional.Name = "rbCondicional";
            this.rbCondicional.Size = new System.Drawing.Size(99, 20);
            this.rbCondicional.TabIndex = 21;
            this.rbCondicional.TabStop = true;
            this.rbCondicional.Text = "Condicional";
            this.rbCondicional.UseVisualStyleBackColor = true;
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(28, 114);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(68, 20);
            this.rbVenda.TabIndex = 20;
            this.rbVenda.TabStop = true;
            this.rbVenda.Text = "Venda";
            this.rbVenda.UseVisualStyleBackColor = true;
            // 
            // tbCodigoCalcado
            // 
            this.tbCodigoCalcado.Location = new System.Drawing.Point(88, 150);
            this.tbCodigoCalcado.Name = "tbCodigoCalcado";
            this.tbCodigoCalcado.Size = new System.Drawing.Size(153, 22);
            this.tbCodigoCalcado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código:";
            // 
            // mtbCPFParaVenda
            // 
            this.mtbCPFParaVenda.Location = new System.Drawing.Point(92, 74);
            this.mtbCPFParaVenda.Name = "mtbCPFParaVenda";
            this.mtbCPFParaVenda.Size = new System.Drawing.Size(153, 22);
            this.mtbCPFParaVenda.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(92, 40);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(149, 22);
            this.tbNome.TabIndex = 32;
            // 
            // FormEditaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 364);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrecoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.rbCondicional);
            this.Controls.Add(this.rbVenda);
            this.Controls.Add(this.tbCodigoCalcado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbCPFParaVenda);
            this.Controls.Add(this.label1);
            this.Name = "FormEditaVenda";
            this.Text = "FormEditaVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrecoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.RadioButton rbCondicional;
        private System.Windows.Forms.RadioButton rbVenda;
        private System.Windows.Forms.TextBox tbCodigoCalcado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCPFParaVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
    }
}