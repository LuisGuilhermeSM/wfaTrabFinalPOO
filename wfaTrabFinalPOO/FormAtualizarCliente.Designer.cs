namespace wfaTrabFinalPOO
{
    partial class FormAtualizarCliente
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
            this.dgvAtualizarCliente = new System.Windows.Forms.DataGridView();
            this.btEditarFormAtualizarCliente = new System.Windows.Forms.Button();
            this.btRemoverFormAtualizarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCPFFormAtualizar = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisarFormAtualizarCliente = new System.Windows.Forms.Button();
            this.btRefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtualizarCliente
            // 
            this.dgvAtualizarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtualizarCliente.Location = new System.Drawing.Point(40, 66);
            this.dgvAtualizarCliente.Name = "dgvAtualizarCliente";
            this.dgvAtualizarCliente.RowHeadersWidth = 51;
            this.dgvAtualizarCliente.RowTemplate.Height = 24;
            this.dgvAtualizarCliente.Size = new System.Drawing.Size(704, 275);
            this.dgvAtualizarCliente.TabIndex = 0;
            // 
            // btEditarFormAtualizarCliente
            // 
            this.btEditarFormAtualizarCliente.Location = new System.Drawing.Point(218, 375);
            this.btEditarFormAtualizarCliente.Name = "btEditarFormAtualizarCliente";
            this.btEditarFormAtualizarCliente.Size = new System.Drawing.Size(132, 48);
            this.btEditarFormAtualizarCliente.TabIndex = 1;
            this.btEditarFormAtualizarCliente.Text = "Editar";
            this.btEditarFormAtualizarCliente.UseVisualStyleBackColor = true;
            this.btEditarFormAtualizarCliente.Click += new System.EventHandler(this.btEditarFormAtualizarCliente_Click);
            // 
            // btRemoverFormAtualizarCliente
            // 
            this.btRemoverFormAtualizarCliente.Location = new System.Drawing.Point(399, 375);
            this.btRemoverFormAtualizarCliente.Name = "btRemoverFormAtualizarCliente";
            this.btRemoverFormAtualizarCliente.Size = new System.Drawing.Size(131, 48);
            this.btRemoverFormAtualizarCliente.TabIndex = 2;
            this.btRemoverFormAtualizarCliente.Text = "Remover";
            this.btRemoverFormAtualizarCliente.UseVisualStyleBackColor = true;
            this.btRemoverFormAtualizarCliente.Click += new System.EventHandler(this.btRemoverFormAtualizarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o CPF para procura:";
            // 
            // mtbCPFFormAtualizar
            // 
            this.mtbCPFFormAtualizar.Location = new System.Drawing.Point(245, 27);
            this.mtbCPFFormAtualizar.Name = "mtbCPFFormAtualizar";
            this.mtbCPFFormAtualizar.Size = new System.Drawing.Size(144, 22);
            this.mtbCPFFormAtualizar.TabIndex = 4;
            // 
            // btPesquisarFormAtualizarCliente
            // 
            this.btPesquisarFormAtualizarCliente.Location = new System.Drawing.Point(434, 25);
            this.btPesquisarFormAtualizarCliente.Name = "btPesquisarFormAtualizarCliente";
            this.btPesquisarFormAtualizarCliente.Size = new System.Drawing.Size(135, 35);
            this.btPesquisarFormAtualizarCliente.TabIndex = 5;
            this.btPesquisarFormAtualizarCliente.Text = "Pesquisar";
            this.btPesquisarFormAtualizarCliente.UseVisualStyleBackColor = true;
            this.btPesquisarFormAtualizarCliente.Click += new System.EventHandler(this.btPesquisarFormAtualizarCliente_Click);
            // 
            // btRefreshDGV
            // 
            this.btRefreshDGV.Location = new System.Drawing.Point(628, 25);
            this.btRefreshDGV.Name = "btRefreshDGV";
            this.btRefreshDGV.Size = new System.Drawing.Size(116, 35);
            this.btRefreshDGV.TabIndex = 6;
            this.btRefreshDGV.Text = "Atualizar";
            this.btRefreshDGV.UseVisualStyleBackColor = true;
            this.btRefreshDGV.Click += new System.EventHandler(this.btRefreshDGV_Click);
            // 
            // FormAtualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRefreshDGV);
            this.Controls.Add(this.btPesquisarFormAtualizarCliente);
            this.Controls.Add(this.mtbCPFFormAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverFormAtualizarCliente);
            this.Controls.Add(this.btEditarFormAtualizarCliente);
            this.Controls.Add(this.dgvAtualizarCliente);
            this.Name = "FormAtualizarCliente";
            this.Text = "FormAtualizarCliente";
            this.Load += new System.EventHandler(this.FormAtualizarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtualizarCliente;
        private System.Windows.Forms.Button btEditarFormAtualizarCliente;
        private System.Windows.Forms.Button btRemoverFormAtualizarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCPFFormAtualizar;
        private System.Windows.Forms.Button btPesquisarFormAtualizarCliente;
        private System.Windows.Forms.Button btRefreshDGV;
    }
}