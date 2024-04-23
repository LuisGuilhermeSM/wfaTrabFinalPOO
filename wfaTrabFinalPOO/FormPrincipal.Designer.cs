namespace wfaTrabFinalPOO
{
    partial class FormPrincipal
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
            this.mSFormPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calçadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaCondicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calçadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaCondicionalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbCalcado = new System.Windows.Forms.RadioButton();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.laEscolhaMenu = new System.Windows.Forms.Label();
            this.dgvFormPrincipal = new System.Windows.Forms.DataGridView();
            this.laMenuEscolha = new System.Windows.Forms.Label();
            this.mtbDadoPesquisaMenu = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisarMenu = new System.Windows.Forms.Button();
            this.btAtualizarMenu = new System.Windows.Forms.Button();
            this.mSFormPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // mSFormPrincipal
            // 
            this.mSFormPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSFormPrincipal.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mSFormPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.mSFormPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mSFormPrincipal.MaximumSize = new System.Drawing.Size(250, 0);
            this.mSFormPrincipal.MinimumSize = new System.Drawing.Size(0, 40);
            this.mSFormPrincipal.Name = "mSFormPrincipal";
            this.mSFormPrincipal.Size = new System.Drawing.Size(250, 40);
            this.mSFormPrincipal.TabIndex = 0;
            this.mSFormPrincipal.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.calçadoToolStripMenuItem,
            this.vendaCondicionalToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // calçadoToolStripMenuItem
            // 
            this.calçadoToolStripMenuItem.Name = "calçadoToolStripMenuItem";
            this.calçadoToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.calçadoToolStripMenuItem.Text = "Calçado";
            this.calçadoToolStripMenuItem.Click += new System.EventHandler(this.calçadoToolStripMenuItem_Click);
            // 
            // vendaCondicionalToolStripMenuItem
            // 
            this.vendaCondicionalToolStripMenuItem.Name = "vendaCondicionalToolStripMenuItem";
            this.vendaCondicionalToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.vendaCondicionalToolStripMenuItem.Text = "Venda/Condicional";
            this.vendaCondicionalToolStripMenuItem.Click += new System.EventHandler(this.vendaCondicionalToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.calçadoToolStripMenuItem1,
            this.vendaCondicionalToolStripMenuItem1});
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(264, 32);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // calçadoToolStripMenuItem1
            // 
            this.calçadoToolStripMenuItem1.Name = "calçadoToolStripMenuItem1";
            this.calçadoToolStripMenuItem1.Size = new System.Drawing.Size(264, 32);
            this.calçadoToolStripMenuItem1.Text = "Calçado";
            this.calçadoToolStripMenuItem1.Click += new System.EventHandler(this.calçadoToolStripMenuItem1_Click);
            // 
            // vendaCondicionalToolStripMenuItem1
            // 
            this.vendaCondicionalToolStripMenuItem1.Name = "vendaCondicionalToolStripMenuItem1";
            this.vendaCondicionalToolStripMenuItem1.Size = new System.Drawing.Size(264, 32);
            this.vendaCondicionalToolStripMenuItem1.Text = "Venda/Condicional";
            this.vendaCondicionalToolStripMenuItem1.Click += new System.EventHandler(this.vendaCondicionalToolStripMenuItem1_Click);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbCliente.Location = new System.Drawing.Point(71, 103);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 20);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbCalcado
            // 
            this.rbCalcado.AutoSize = true;
            this.rbCalcado.Location = new System.Drawing.Point(232, 103);
            this.rbCalcado.Name = "rbCalcado";
            this.rbCalcado.Size = new System.Drawing.Size(79, 20);
            this.rbCalcado.TabIndex = 2;
            this.rbCalcado.Text = "Calçado";
            this.rbCalcado.UseVisualStyleBackColor = true;
            this.rbCalcado.CheckedChanged += new System.EventHandler(this.rbCalcado_CheckedChanged);
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(403, 103);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(141, 20);
            this.rbVenda.TabIndex = 3;
            this.rbVenda.Text = "Venda/condicional";
            this.rbVenda.UseVisualStyleBackColor = true;
            this.rbVenda.CheckedChanged += new System.EventHandler(this.rbVenda_CheckedChanged);
            // 
            // laEscolhaMenu
            // 
            this.laEscolhaMenu.AutoSize = true;
            this.laEscolhaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEscolhaMenu.Location = new System.Drawing.Point(67, 65);
            this.laEscolhaMenu.Name = "laEscolhaMenu";
            this.laEscolhaMenu.Size = new System.Drawing.Size(257, 20);
            this.laEscolhaMenu.TabIndex = 4;
            this.laEscolhaMenu.Text = "Escolha qual item deseja checar:";
            // 
            // dgvFormPrincipal
            // 
            this.dgvFormPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormPrincipal.Location = new System.Drawing.Point(71, 280);
            this.dgvFormPrincipal.Name = "dgvFormPrincipal";
            this.dgvFormPrincipal.RowHeadersWidth = 51;
            this.dgvFormPrincipal.RowTemplate.Height = 24;
            this.dgvFormPrincipal.Size = new System.Drawing.Size(969, 150);
            this.dgvFormPrincipal.TabIndex = 5;
            // 
            // laMenuEscolha
            // 
            this.laMenuEscolha.AutoSize = true;
            this.laMenuEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMenuEscolha.Location = new System.Drawing.Point(67, 200);
            this.laMenuEscolha.Name = "laMenuEscolha";
            this.laMenuEscolha.Size = new System.Drawing.Size(234, 20);
            this.laMenuEscolha.TabIndex = 6;
            this.laMenuEscolha.Text = "Pesquise pelo CPF do cliente:";
            // 
            // mtbDadoPesquisaMenu
            // 
            this.mtbDadoPesquisaMenu.Location = new System.Drawing.Point(368, 200);
            this.mtbDadoPesquisaMenu.Name = "mtbDadoPesquisaMenu";
            this.mtbDadoPesquisaMenu.Size = new System.Drawing.Size(231, 22);
            this.mtbDadoPesquisaMenu.TabIndex = 7;
            // 
            // btPesquisarMenu
            // 
            this.btPesquisarMenu.Location = new System.Drawing.Point(675, 194);
            this.btPesquisarMenu.Name = "btPesquisarMenu";
            this.btPesquisarMenu.Size = new System.Drawing.Size(126, 46);
            this.btPesquisarMenu.TabIndex = 8;
            this.btPesquisarMenu.Text = "Pesquisar";
            this.btPesquisarMenu.UseVisualStyleBackColor = true;
            this.btPesquisarMenu.Click += new System.EventHandler(this.btPesquisarMenu_Click);
            // 
            // btAtualizarMenu
            // 
            this.btAtualizarMenu.Location = new System.Drawing.Point(868, 194);
            this.btAtualizarMenu.Name = "btAtualizarMenu";
            this.btAtualizarMenu.Size = new System.Drawing.Size(123, 48);
            this.btAtualizarMenu.TabIndex = 9;
            this.btAtualizarMenu.Text = "Atualizar";
            this.btAtualizarMenu.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 558);
            this.Controls.Add(this.btAtualizarMenu);
            this.Controls.Add(this.btPesquisarMenu);
            this.Controls.Add(this.mtbDadoPesquisaMenu);
            this.Controls.Add(this.laMenuEscolha);
            this.Controls.Add(this.dgvFormPrincipal);
            this.Controls.Add(this.laEscolhaMenu);
            this.Controls.Add(this.rbVenda);
            this.Controls.Add(this.rbCalcado);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.mSFormPrincipal);
            this.Name = "FormPrincipal";
            this.Text = "Menu";
            this.mSFormPrincipal.ResumeLayout(false);
            this.mSFormPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSFormPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calçadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaCondicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calçadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaCondicionalToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbCalcado;
        private System.Windows.Forms.RadioButton rbVenda;
        private System.Windows.Forms.Label laEscolhaMenu;
        private System.Windows.Forms.DataGridView dgvFormPrincipal;
        private System.Windows.Forms.Label laMenuEscolha;
        private System.Windows.Forms.MaskedTextBox mtbDadoPesquisaMenu;
        private System.Windows.Forms.Button btPesquisarMenu;
        private System.Windows.Forms.Button btAtualizarMenu;
    }
}

