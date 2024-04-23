namespace wfaTrabFinalPOO
{
    partial class FormCadastrarVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCPFParaVenda = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoCalcado = new System.Windows.Forms.TextBox();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.rbCondicional = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdicionarCalcado = new System.Windows.Forms.Button();
            this.btRemoverCalcado = new System.Windows.Forms.Button();
            this.cdCadastrarVenda = new System.Windows.Forms.Button();
            this.btLimparDadosCadastrarVenda = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrecoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // mtbCPFParaVenda
            // 
            this.mtbCPFParaVenda.Location = new System.Drawing.Point(103, 42);
            this.mtbCPFParaVenda.Name = "mtbCPFParaVenda";
            this.mtbCPFParaVenda.Size = new System.Drawing.Size(153, 22);
            this.mtbCPFParaVenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // tbCodigoCalcado
            // 
            this.tbCodigoCalcado.Location = new System.Drawing.Point(102, 186);
            this.tbCodigoCalcado.Name = "tbCodigoCalcado";
            this.tbCodigoCalcado.Size = new System.Drawing.Size(153, 22);
            this.tbCodigoCalcado.TabIndex = 3;
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(42, 94);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(68, 20);
            this.rbVenda.TabIndex = 4;
            this.rbVenda.TabStop = true;
            this.rbVenda.Text = "Venda";
            this.rbVenda.UseVisualStyleBackColor = true;
            // 
            // rbCondicional
            // 
            this.rbCondicional.AutoSize = true;
            this.rbCondicional.Location = new System.Drawing.Point(159, 94);
            this.rbCondicional.Name = "rbCondicional";
            this.rbCondicional.Size = new System.Drawing.Size(99, 20);
            this.rbCondicional.TabIndex = 5;
            this.rbCondicional.TabStop = true;
            this.rbCondicional.Text = "Condicional";
            this.rbCondicional.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insira os códigos dos calçado individualmente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista dos produtos para cadastro:";
            // 
            // btAdicionarCalcado
            // 
            this.btAdicionarCalcado.Location = new System.Drawing.Point(45, 247);
            this.btAdicionarCalcado.Name = "btAdicionarCalcado";
            this.btAdicionarCalcado.Size = new System.Drawing.Size(116, 52);
            this.btAdicionarCalcado.TabIndex = 9;
            this.btAdicionarCalcado.Text = "Adicionar";
            this.btAdicionarCalcado.UseVisualStyleBackColor = true;
            this.btAdicionarCalcado.Click += new System.EventHandler(this.btAdicionarCalcado_Click);
            // 
            // btRemoverCalcado
            // 
            this.btRemoverCalcado.Location = new System.Drawing.Point(45, 325);
            this.btRemoverCalcado.Name = "btRemoverCalcado";
            this.btRemoverCalcado.Size = new System.Drawing.Size(116, 56);
            this.btRemoverCalcado.TabIndex = 10;
            this.btRemoverCalcado.Text = "Remover";
            this.btRemoverCalcado.UseVisualStyleBackColor = true;
            this.btRemoverCalcado.Click += new System.EventHandler(this.btRemoverCalcado_Click);
            // 
            // cdCadastrarVenda
            // 
            this.cdCadastrarVenda.Location = new System.Drawing.Point(117, 511);
            this.cdCadastrarVenda.Name = "cdCadastrarVenda";
            this.cdCadastrarVenda.Size = new System.Drawing.Size(129, 60);
            this.cdCadastrarVenda.TabIndex = 11;
            this.cdCadastrarVenda.Text = "Cadastrar";
            this.cdCadastrarVenda.UseVisualStyleBackColor = true;
            this.cdCadastrarVenda.Click += new System.EventHandler(this.cdCadastrarVenda_Click);
            // 
            // btLimparDadosCadastrarVenda
            // 
            this.btLimparDadosCadastrarVenda.Location = new System.Drawing.Point(325, 511);
            this.btLimparDadosCadastrarVenda.Name = "btLimparDadosCadastrarVenda";
            this.btLimparDadosCadastrarVenda.Size = new System.Drawing.Size(125, 60);
            this.btLimparDadosCadastrarVenda.TabIndex = 12;
            this.btLimparDadosCadastrarVenda.Text = "Limpar";
            this.btLimparDadosCadastrarVenda.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(230, 236);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(444, 194);
            this.dgvProdutos.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço total:";
            // 
            // lbPrecoTotal
            // 
            this.lbPrecoTotal.AutoSize = true;
            this.lbPrecoTotal.BackColor = System.Drawing.Color.White;
            this.lbPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoTotal.Location = new System.Drawing.Point(488, 445);
            this.lbPrecoTotal.Name = "lbPrecoTotal";
            this.lbPrecoTotal.Size = new System.Drawing.Size(57, 20);
            this.lbPrecoTotal.TabIndex = 15;
            this.lbPrecoTotal.Text = "R$ 0,0";
            // 
            // FormCadastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 599);
            this.Controls.Add(this.lbPrecoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btLimparDadosCadastrarVenda);
            this.Controls.Add(this.cdCadastrarVenda);
            this.Controls.Add(this.btRemoverCalcado);
            this.Controls.Add(this.btAdicionarCalcado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCondicional);
            this.Controls.Add(this.rbVenda);
            this.Controls.Add(this.tbCodigoCalcado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbCPFParaVenda);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastrarVenda";
            this.Text = "FormCadastrarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCPFParaVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoCalcado;
        private System.Windows.Forms.RadioButton rbVenda;
        private System.Windows.Forms.RadioButton rbCondicional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionarCalcado;
        private System.Windows.Forms.Button btRemoverCalcado;
        private System.Windows.Forms.Button cdCadastrarVenda;
        private System.Windows.Forms.Button btLimparDadosCadastrarVenda;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrecoTotal;
    }
}