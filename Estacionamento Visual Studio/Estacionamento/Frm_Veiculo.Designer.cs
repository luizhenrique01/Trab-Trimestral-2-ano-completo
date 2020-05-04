namespace Estacionamento
{
    partial class Frm_Veiculo
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
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_enviarveiculo = new System.Windows.Forms.Button();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(12, 44);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(100, 20);
            this.txt_veiculo.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 11);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(55, 13);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID veiculo";
            // 
            // btn_enviarveiculo
            // 
            this.btn_enviarveiculo.Location = new System.Drawing.Point(132, 95);
            this.btn_enviarveiculo.Name = "btn_enviarveiculo";
            this.btn_enviarveiculo.Size = new System.Drawing.Size(155, 53);
            this.btn_enviarveiculo.TabIndex = 9;
            this.btn_enviarveiculo.Text = "Enviar";
            this.btn_enviarveiculo.UseVisualStyleBackColor = true;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(12, 112);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Placa";
            // 
            // txt_cnh
            // 
            this.txt_cnh.Location = new System.Drawing.Point(12, 188);
            this.txt_cnh.Name = "txt_cnh";
            this.txt_cnh.Size = new System.Drawing.Size(100, 20);
            this.txt_cnh.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CNH";
            // 
            // Frm_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 241);
            this.Controls.Add(this.txt_cnh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviarveiculo);
            this.Controls.Add(this.txt_veiculo);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Veiculo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Veiculo";
            this.Load += new System.EventHandler(this.Frm_Veiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_enviarveiculo;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cnh;
        private System.Windows.Forms.Label label2;
    }
}