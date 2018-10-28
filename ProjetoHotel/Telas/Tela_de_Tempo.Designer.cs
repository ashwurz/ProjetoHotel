namespace ProjetoHotel.Telas
{
    partial class Tela_de_Tempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_Tempo));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnD1 = new System.Windows.Forms.RadioButton();
            this.rbtnD7 = new System.Windows.Forms.RadioButton();
            this.rbtnD14 = new System.Windows.Forms.RadioButton();
            this.rbtnD21 = new System.Windows.Forms.RadioButton();
            this.rbtnD30 = new System.Windows.Forms.RadioButton();
            this.btnPlano = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual será o seu tempo de estadia:";
            // 
            // rbtnD1
            // 
            this.rbtnD1.AutoSize = true;
            this.rbtnD1.Checked = true;
            this.rbtnD1.Location = new System.Drawing.Point(210, 144);
            this.rbtnD1.Name = "rbtnD1";
            this.rbtnD1.Size = new System.Drawing.Size(50, 17);
            this.rbtnD1.TabIndex = 1;
            this.rbtnD1.TabStop = true;
            this.rbtnD1.Text = "1 Dia";
            this.rbtnD1.UseVisualStyleBackColor = true;
            // 
            // rbtnD7
            // 
            this.rbtnD7.AutoSize = true;
            this.rbtnD7.Location = new System.Drawing.Point(356, 144);
            this.rbtnD7.Name = "rbtnD7";
            this.rbtnD7.Size = new System.Drawing.Size(50, 17);
            this.rbtnD7.TabIndex = 2;
            this.rbtnD7.TabStop = true;
            this.rbtnD7.Text = "Dia 7";
            this.rbtnD7.UseVisualStyleBackColor = true;
            // 
            // rbtnD14
            // 
            this.rbtnD14.AutoSize = true;
            this.rbtnD14.Location = new System.Drawing.Point(494, 144);
            this.rbtnD14.Name = "rbtnD14";
            this.rbtnD14.Size = new System.Drawing.Size(56, 17);
            this.rbtnD14.TabIndex = 3;
            this.rbtnD14.TabStop = true;
            this.rbtnD14.Text = "Dia 14";
            this.rbtnD14.UseVisualStyleBackColor = true;
            // 
            // rbtnD21
            // 
            this.rbtnD21.AutoSize = true;
            this.rbtnD21.Location = new System.Drawing.Point(289, 229);
            this.rbtnD21.Name = "rbtnD21";
            this.rbtnD21.Size = new System.Drawing.Size(56, 17);
            this.rbtnD21.TabIndex = 4;
            this.rbtnD21.TabStop = true;
            this.rbtnD21.Text = "Dia 21";
            this.rbtnD21.UseVisualStyleBackColor = true;
            // 
            // rbtnD30
            // 
            this.rbtnD30.AutoSize = true;
            this.rbtnD30.Location = new System.Drawing.Point(424, 229);
            this.rbtnD30.Name = "rbtnD30";
            this.rbtnD30.Size = new System.Drawing.Size(56, 17);
            this.rbtnD30.TabIndex = 5;
            this.rbtnD30.TabStop = true;
            this.rbtnD30.Text = "Dia 30";
            this.rbtnD30.UseVisualStyleBackColor = true;
            // 
            // btnPlano
            // 
            this.btnPlano.Location = new System.Drawing.Point(317, 329);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(116, 23);
            this.btnPlano.TabIndex = 6;
            this.btnPlano.Text = "Escolha o Plano";
            this.btnPlano.UseVisualStyleBackColor = true;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(63, 329);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 7;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // Tela_de_Tempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.rbtnD30);
            this.Controls.Add(this.rbtnD21);
            this.Controls.Add(this.rbtnD14);
            this.Controls.Add(this.rbtnD7);
            this.Controls.Add(this.rbtnD1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_de_Tempo";
            this.Text = "Tela_de_Tempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnD1;
        private System.Windows.Forms.RadioButton rbtnD7;
        private System.Windows.Forms.RadioButton rbtnD14;
        private System.Windows.Forms.RadioButton rbtnD21;
        private System.Windows.Forms.RadioButton rbtnD30;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.Button btnCancela;
    }
}