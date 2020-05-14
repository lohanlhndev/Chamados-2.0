namespace Chamados_2._0
{
    partial class frmIncluirChamado
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.brnSalvar = new System.Windows.Forms.Button();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(308, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // brnSalvar
            // 
            this.brnSalvar.Location = new System.Drawing.Point(245, 109);
            this.brnSalvar.Name = "brnSalvar";
            this.brnSalvar.Size = new System.Drawing.Size(75, 23);
            this.brnSalvar.TabIndex = 2;
            this.brnSalvar.Text = "Salvar";
            this.brnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(12, 58);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 3;
            this.lblCusto.Text = "Custo:";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(12, 74);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(147, 20);
            this.txtCusto.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(218, 58);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(221, 74);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(99, 20);
            this.txtData.TabIndex = 8;
            // 
            // frmIncluirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 144);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.brnSalvar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncluirChamado";
            this.Text = "Novo Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button brnSalvar;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtData;
    }
}

