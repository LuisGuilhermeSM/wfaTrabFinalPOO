namespace wfaTrabFinalPOO
{
    partial class FormAtualizarVenda
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
            this.btPesquisarFormAtualizarVenda = new System.Windows.Forms.Button();
            this.mtbCPFFormAtualizarVenda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverFormAtualizarVenda = new System.Windows.Forms.Button();
            this.btEditarFormAtualizarVenda = new System.Windows.Forms.Button();
            this.dgvAtualizarVenda = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesquisarFormAtualizarVenda
            // 
            this.btPesquisarFormAtualizarVenda.Location = new System.Drawing.Point(442, 26);
            this.btPesquisarFormAtualizarVenda.Name = "btPesquisarFormAtualizarVenda";
            this.btPesquisarFormAtualizarVenda.Size = new System.Drawing.Size(135, 35);
            this.btPesquisarFormAtualizarVenda.TabIndex = 17;
            this.btPesquisarFormAtualizarVenda.Text = "Pesquisar";
            this.btPesquisarFormAtualizarVenda.UseVisualStyleBackColor = true;
            this.btPesquisarFormAtualizarVenda.Click += new System.EventHandler(this.btPesquisarFormAtualizarVenda_Click);
            // 
            // mtbCPFFormAtualizarVenda
            // 
            this.mtbCPFFormAtualizarVenda.Location = new System.Drawing.Point(253, 28);
            this.mtbCPFFormAtualizarVenda.Name = "mtbCPFFormAtualizarVenda";
            this.mtbCPFFormAtualizarVenda.Size = new System.Drawing.Size(144, 22);
            this.mtbCPFFormAtualizarVenda.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite o CPF para procura:";
            // 
            // btRemoverFormAtualizarVenda
            // 
            this.btRemoverFormAtualizarVenda.Location = new System.Drawing.Point(407, 376);
            this.btRemoverFormAtualizarVenda.Name = "btRemoverFormAtualizarVenda";
            this.btRemoverFormAtualizarVenda.Size = new System.Drawing.Size(131, 48);
            this.btRemoverFormAtualizarVenda.TabIndex = 14;
            this.btRemoverFormAtualizarVenda.Text = "Remover";
            this.btRemoverFormAtualizarVenda.UseVisualStyleBackColor = true;
            this.btRemoverFormAtualizarVenda.Click += new System.EventHandler(this.btRemoverFormAtualizarVenda_Click);
            // 
            // btEditarFormAtualizarVenda
            // 
            this.btEditarFormAtualizarVenda.Location = new System.Drawing.Point(226, 376);
            this.btEditarFormAtualizarVenda.Name = "btEditarFormAtualizarVenda";
            this.btEditarFormAtualizarVenda.Size = new System.Drawing.Size(132, 48);
            this.btEditarFormAtualizarVenda.TabIndex = 13;
            this.btEditarFormAtualizarVenda.Text = "Editar";
            this.btEditarFormAtualizarVenda.UseVisualStyleBackColor = true;
            this.btEditarFormAtualizarVenda.Click += new System.EventHandler(this.btEditarFormAtualizarVenda_Click);
            // 
            // dgvAtualizarVenda
            // 
            this.dgvAtualizarVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtualizarVenda.Location = new System.Drawing.Point(48, 67);
            this.dgvAtualizarVenda.Name = "dgvAtualizarVenda";
            this.dgvAtualizarVenda.RowHeadersWidth = 51;
            this.dgvAtualizarVenda.RowTemplate.Height = 24;
            this.dgvAtualizarVenda.Size = new System.Drawing.Size(704, 275);
            this.dgvAtualizarVenda.TabIndex = 12;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(607, 26);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(134, 35);
            this.btAtualizar.TabIndex = 18;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormAtualizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btPesquisarFormAtualizarVenda);
            this.Controls.Add(this.mtbCPFFormAtualizarVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverFormAtualizarVenda);
            this.Controls.Add(this.btEditarFormAtualizarVenda);
            this.Controls.Add(this.dgvAtualizarVenda);
            this.Name = "FormAtualizarVenda";
            this.Text = "FormAtualizarVenda";
            this.Load += new System.EventHandler(this.FormAtualizarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisarFormAtualizarVenda;
        private System.Windows.Forms.MaskedTextBox mtbCPFFormAtualizarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverFormAtualizarVenda;
        private System.Windows.Forms.Button btEditarFormAtualizarVenda;
        private System.Windows.Forms.DataGridView dgvAtualizarVenda;
        private System.Windows.Forms.Button btAtualizar;
    }
}