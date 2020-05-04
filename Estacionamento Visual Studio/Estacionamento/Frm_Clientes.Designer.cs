namespace Estacionamento
{
    partial class Frm_Clientes
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
            this.lbl_cnh = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_vencimento = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cnh = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_vencimento = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cnh
            // 
            this.lbl_cnh.AutoSize = true;
            this.lbl_cnh.Location = new System.Drawing.Point(20, 16);
            this.lbl_cnh.Name = "lbl_cnh";
            this.lbl_cnh.Size = new System.Drawing.Size(30, 13);
            this.lbl_cnh.TabIndex = 0;
            this.lbl_cnh.Text = "CNH";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(20, 89);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(20, 162);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_vencimento
            // 
            this.lbl_vencimento.AutoSize = true;
            this.lbl_vencimento.Location = new System.Drawing.Point(20, 235);
            this.lbl_vencimento.Name = "lbl_vencimento";
            this.lbl_vencimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_vencimento.TabIndex = 3;
            this.lbl_vencimento.Text = "Vencimento CNH";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(20, 122);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_cnh
            // 
            this.txt_cnh.Location = new System.Drawing.Point(20, 49);
            this.txt_cnh.Name = "txt_cnh";
            this.txt_cnh.Size = new System.Drawing.Size(100, 20);
            this.txt_cnh.TabIndex = 5;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(20, 195);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 6;
            // 
            // txt_vencimento
            // 
            this.txt_vencimento.Location = new System.Drawing.Point(20, 268);
            this.txt_vencimento.Name = "txt_vencimento";
            this.txt_vencimento.Size = new System.Drawing.Size(100, 20);
            this.txt_vencimento.TabIndex = 7;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(135, 122);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(155, 53);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 300);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_vencimento);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_cnh);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_vencimento);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cnh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Clientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cnh;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_vencimento;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cnh;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_vencimento;
        private System.Windows.Forms.Button btn_enviar;
    }
}