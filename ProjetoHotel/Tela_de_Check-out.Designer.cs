namespace ProjetoHotel
{
    partial class Tela_de_Check_out
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtbSobrenome = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(295, 338);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(158, 50);
            this.btnCheckout.TabIndex = 11;
            this.btnCheckout.Text = "Check-out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnBusca
            // 
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(295, 244);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(158, 48);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "Confirmar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // txtbSobrenome
            // 
            this.txtbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSobrenome.Location = new System.Drawing.Point(346, 132);
            this.txtbSobrenome.Name = "txtbSobrenome";
            this.txtbSobrenome.Size = new System.Drawing.Size(320, 30);
            this.txtbSobrenome.TabIndex = 9;
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(232, 74);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(434, 30);
            this.txtbNome.TabIndex = 8;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.AutoSize = true;
            this.txtSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(91, 137);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(249, 25);
            this.txtSobrenome.TabIndex = 7;
            this.txtSobrenome.Text = "Digite o Ultimo Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 25);
            this.txtNome.TabIndex = 6;
            this.txtNome.Text = "Digite o Nome:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(13, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 37);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Tela_de_Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtbSobrenome);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Name = "Tela_de_Check_out";
            this.Text = "Tela_de_Check_out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtbSobrenome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label txtSobrenome;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button btnVoltar;
    }
}