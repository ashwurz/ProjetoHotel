namespace ProjetoHotel.Telas
{
    partial class Tela_de_Plano
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
            this.txtEscolha = new System.Windows.Forms.Label();
            this.txtComum = new System.Windows.Forms.Label();
            this.txtDeluxe = new System.Windows.Forms.Label();
            this.txtPremium = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.rbtnComum = new System.Windows.Forms.RadioButton();
            this.rbtnDeluxe = new System.Windows.Forms.RadioButton();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEscolha
            // 
            this.txtEscolha.AutoSize = true;
            this.txtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscolha.Location = new System.Drawing.Point(279, 50);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(193, 17);
            this.txtEscolha.TabIndex = 0;
            this.txtEscolha.Text = "Escolha um Plano de Quarto:";
            // 
            // txtComum
            // 
            this.txtComum.AutoSize = true;
            this.txtComum.Location = new System.Drawing.Point(129, 122);
            this.txtComum.Name = "txtComum";
            this.txtComum.Size = new System.Drawing.Size(42, 13);
            this.txtComum.TabIndex = 1;
            this.txtComum.Text = "Comum";
            // 
            // txtDeluxe
            // 
            this.txtDeluxe.AutoSize = true;
            this.txtDeluxe.Location = new System.Drawing.Point(347, 122);
            this.txtDeluxe.Name = "txtDeluxe";
            this.txtDeluxe.Size = new System.Drawing.Size(40, 13);
            this.txtDeluxe.TabIndex = 2;
            this.txtDeluxe.Text = "Deluxe";
            // 
            // txtPremium
            // 
            this.txtPremium.AutoSize = true;
            this.txtPremium.Location = new System.Drawing.Point(565, 122);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(47, 13);
            this.txtPremium.TabIndex = 3;
            this.txtPremium.Text = "Premium";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(75, 166);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(159, 135);
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(293, 166);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(159, 135);
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(511, 166);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(159, 135);
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // rbtnComum
            // 
            this.rbtnComum.AutoSize = true;
            this.rbtnComum.Location = new System.Drawing.Point(111, 344);
            this.rbtnComum.Name = "rbtnComum";
            this.rbtnComum.Size = new System.Drawing.Size(63, 17);
            this.rbtnComum.TabIndex = 7;
            this.rbtnComum.Text = "RSxx,xx";
            this.rbtnComum.UseVisualStyleBackColor = true;
            // 
            // rbtnDeluxe
            // 
            this.rbtnDeluxe.AutoSize = true;
            this.rbtnDeluxe.Location = new System.Drawing.Point(334, 344);
            this.rbtnDeluxe.Name = "rbtnDeluxe";
            this.rbtnDeluxe.Size = new System.Drawing.Size(68, 17);
            this.rbtnDeluxe.TabIndex = 8;
            this.rbtnDeluxe.Text = "RSxxx,xx";
            this.rbtnDeluxe.UseVisualStyleBackColor = true;
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.Location = new System.Drawing.Point(549, 344);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(73, 17);
            this.rbtnPremium.TabIndex = 9;
            this.rbtnPremium.Text = "RSxxxx,xx";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(315, 396);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(122, 23);
            this.btnRegistra.TabIndex = 10;
            this.btnRegistra.Text = "Finalizar Registro";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(595, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(75, 395);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Tela_de_Plano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.rbtnPremium);
            this.Controls.Add(this.rbtnDeluxe);
            this.Controls.Add(this.rbtnComum);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.txtDeluxe);
            this.Controls.Add(this.txtComum);
            this.Controls.Add(this.txtEscolha);
            this.Name = "Tela_de_Plano";
            this.Text = "Tela_de_Plano";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEscolha;
        private System.Windows.Forms.Label txtComum;
        private System.Windows.Forms.Label txtDeluxe;
        private System.Windows.Forms.Label txtPremium;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.RadioButton rbtnComum;
        private System.Windows.Forms.RadioButton rbtnDeluxe;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
    }
}