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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_Plano));
            this.txtComum = new System.Windows.Forms.Label();
            this.txtDeluxe = new System.Windows.Forms.Label();
            this.txtPremium = new System.Windows.Forms.Label();
            this.rbtnComum = new System.Windows.Forms.RadioButton();
            this.rbtnDeluxe = new System.Windows.Forms.RadioButton();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComum
            // 
            this.txtComum.AutoSize = true;
            this.txtComum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComum.Location = new System.Drawing.Point(111, 307);
            this.txtComum.Name = "txtComum";
            this.txtComum.Size = new System.Drawing.Size(112, 31);
            this.txtComum.TabIndex = 1;
            this.txtComum.Text = "RSxx,xx";
            // 
            // txtDeluxe
            // 
            this.txtDeluxe.AutoSize = true;
            this.txtDeluxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeluxe.Location = new System.Drawing.Point(339, 307);
            this.txtDeluxe.Name = "txtDeluxe";
            this.txtDeluxe.Size = new System.Drawing.Size(125, 31);
            this.txtDeluxe.TabIndex = 2;
            this.txtDeluxe.Text = "RSxxx,xx";
            // 
            // txtPremium
            // 
            this.txtPremium.AutoSize = true;
            this.txtPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremium.Location = new System.Drawing.Point(566, 307);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(138, 31);
            this.txtPremium.TabIndex = 3;
            this.txtPremium.Text = "RSxxxx,xx";
            // 
            // rbtnComum
            // 
            this.rbtnComum.AutoSize = true;
            this.rbtnComum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnComum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComum.Location = new System.Drawing.Point(98, 93);
            this.rbtnComum.Name = "rbtnComum";
            this.rbtnComum.Size = new System.Drawing.Size(126, 35);
            this.rbtnComum.TabIndex = 7;
            this.rbtnComum.Text = "Comum";
            this.rbtnComum.UseVisualStyleBackColor = true;
            // 
            // rbtnDeluxe
            // 
            this.rbtnDeluxe.AutoSize = true;
            this.rbtnDeluxe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnDeluxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDeluxe.Location = new System.Drawing.Point(318, 93);
            this.rbtnDeluxe.Name = "rbtnDeluxe";
            this.rbtnDeluxe.Size = new System.Drawing.Size(116, 35);
            this.rbtnDeluxe.TabIndex = 8;
            this.rbtnDeluxe.Text = "Deluxe";
            this.rbtnDeluxe.UseVisualStyleBackColor = true;
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPremium.Location = new System.Drawing.Point(547, 93);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(139, 35);
            this.rbtnPremium.TabIndex = 9;
            this.rbtnPremium.Text = "Premium";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistra.Location = new System.Drawing.Point(329, 358);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(162, 42);
            this.btnRegistra.TabIndex = 10;
            this.btnRegistra.Text = "Finalizar Registro";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(572, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 42);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(117, 358);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 42);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Tela_de_Plano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoHotel.Properties.Resources.Tela_de_Plano;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.rbtnPremium);
            this.Controls.Add(this.rbtnDeluxe);
            this.Controls.Add(this.rbtnComum);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.txtDeluxe);
            this.Controls.Add(this.txtComum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_de_Plano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Plano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtComum;
        private System.Windows.Forms.Label txtDeluxe;
        private System.Windows.Forms.Label txtPremium;
        private System.Windows.Forms.RadioButton rbtnComum;
        private System.Windows.Forms.RadioButton rbtnDeluxe;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
    }
}