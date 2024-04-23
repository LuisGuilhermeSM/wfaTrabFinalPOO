namespace wfaTrabFinalPOO
{
    partial class FormAtualizarCalcado
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
            this.btPesquisarFormAtualizarCalcado = new System.Windows.Forms.Button();
            this.mtbCodigoFormAtualizarCalcado = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverFormAtualizarCalcado = new System.Windows.Forms.Button();
            this.btEditarFormAtualizarCalcado = new System.Windows.Forms.Button();
            this.dgvAtualizarCalcado = new System.Windows.Forms.DataGridView();
            this.btRefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCalcado)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesquisarFormAtualizarCalcado
            // 
            this.btPesquisarFormAtualizarCalcado.Location = new System.Drawing.Point(477, 28);
            this.btPesquisarFormAtualizarCalcado.Name = "btPesquisarFormAtualizarCalcado";
            this.btPesquisarFormAtualizarCalcado.Size = new System.Drawing.Size(135, 35);
            this.btPesquisarFormAtualizarCalcado.TabIndex = 11;
            this.btPesquisarFormAtualizarCalcado.Text = "Pesquisar";
            this.btPesquisarFormAtualizarCalcado.UseVisualStyleBackColor = true;
            this.btPesquisarFormAtualizarCalcado.Click += new System.EventHandler(this.btPesquisarFormAtualizarCalcado_Click);
            // 
            // mtbCodigoFormAtualizarCalcado
            // 
            this.mtbCodigoFormAtualizarCalcado.Location = new System.Drawing.Point(305, 28);
            this.mtbCodigoFormAtualizarCalcado.Name = "mtbCodigoFormAtualizarCalcado";
            this.mtbCodigoFormAtualizarCalcado.Size = new System.Drawing.Size(144, 22);
            this.mtbCodigoFormAtualizarCalcado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite o Código do calçado para procura:";
            // 
            // btRemoverFormAtualizarCalcado
            // 
            this.btRemoverFormAtualizarCalcado.Location = new System.Drawing.Point(407, 376);
            this.btRemoverFormAtualizarCalcado.Name = "btRemoverFormAtualizarCalcado";
            this.btRemoverFormAtualizarCalcado.Size = new System.Drawing.Size(131, 48);
            this.btRemoverFormAtualizarCalcado.TabIndex = 8;
            this.btRemoverFormAtualizarCalcado.Text = "Remover";
            this.btRemoverFormAtualizarCalcado.UseVisualStyleBackColor = true;
            this.btRemoverFormAtualizarCalcado.Click += new System.EventHandler(this.btRemoverFormAtualizarCalcado_Click);
            // 
            // btEditarFormAtualizarCalcado
            // 
            this.btEditarFormAtualizarCalcado.Location = new System.Drawing.Point(226, 376);
            this.btEditarFormAtualizarCalcado.Name = "btEditarFormAtualizarCalcado";
            this.btEditarFormAtualizarCalcado.Size = new System.Drawing.Size(132, 48);
            this.btEditarFormAtualizarCalcado.TabIndex = 7;
            this.btEditarFormAtualizarCalcado.Text = "Editar";
            this.btEditarFormAtualizarCalcado.UseVisualStyleBackColor = true;
            this.btEditarFormAtualizarCalcado.Click += new System.EventHandler(this.btEditarFormAtualizarCalcado_Click);
            // 
            // dgvAtualizarCalcado
            // 
            this.dgvAtualizarCalcado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtualizarCalcado.Location = new System.Drawing.Point(48, 67);
            this.dgvAtualizarCalcado.Name = "dgvAtualizarCalcado";
            this.dgvAtualizarCalcado.RowHeadersWidth = 51;
            this.dgvAtualizarCalcado.RowTemplate.Height = 24;
            this.dgvAtualizarCalcado.Size = new System.Drawing.Size(704, 275);
            this.dgvAtualizarCalcado.TabIndex = 6;
            // 
            // btRefreshDGV
            // 
            this.btRefreshDGV.Location = new System.Drawing.Point(649, 28);
            this.btRefreshDGV.Name = "btRefreshDGV";
            this.btRefreshDGV.Size = new System.Drawing.Size(103, 33);
            this.btRefreshDGV.TabIndex = 12;
            this.btRefreshDGV.Text = "Atualizar";
            this.btRefreshDGV.UseVisualStyleBackColor = true;
            this.btRefreshDGV.Click += new System.EventHandler(this.btRefreshDGV_Click);
            // 
            // FormAtualizarCalcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRefreshDGV);
            this.Controls.Add(this.btPesquisarFormAtualizarCalcado);
            this.Controls.Add(this.mtbCodigoFormAtualizarCalcado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverFormAtualizarCalcado);
            this.Controls.Add(this.btEditarFormAtualizarCalcado);
            this.Controls.Add(this.dgvAtualizarCalcado);
            this.Name = "FormAtualizarCalcado";
            this.Text = "FormAtualizarCalcado";
            this.Load += new System.EventHandler(this.FormAtualizarCalcado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCalcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisarFormAtualizarCalcado;
        private System.Windows.Forms.MaskedTextBox mtbCodigoFormAtualizarCalcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverFormAtualizarCalcado;
        private System.Windows.Forms.Button btEditarFormAtualizarCalcado;
        private System.Windows.Forms.DataGridView dgvAtualizarCalcado;
        private System.Windows.Forms.Button btRefreshDGV;
    }
}