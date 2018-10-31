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
            this.rbtnD1 = new System.Windows.Forms.RadioButton();
            this.rbtnD7 = new System.Windows.Forms.RadioButton();
            this.rbtnD14 = new System.Windows.Forms.RadioButton();
            this.rbtnD21 = new System.Windows.Forms.RadioButton();
            this.rbtnD30 = new System.Windows.Forms.RadioButton();
            this.btnPlano = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnD1
            // 
            this.rbtnD1.AutoSize = true;
            this.rbtnD1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtnD1.Checked = true;
            this.rbtnD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.rbtnD1.ForeColor = System.Drawing.Color.White;
            this.rbtnD1.Location = new System.Drawing.Point(48, 153);
            this.rbtnD1.Name = "rbtnD1";
            this.rbtnD1.Size = new System.Drawing.Size(115, 43);
            this.rbtnD1.TabIndex = 1;
            this.rbtnD1.TabStop = true;
            this.rbtnD1.Text = "1 Dia";
            this.rbtnD1.UseVisualStyleBackColor = false;
            // 
            // rbtnD7
            // 
            this.rbtnD7.AutoSize = true;
            this.rbtnD7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rbtnD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.rbtnD7.ForeColor = System.Drawing.Color.White;
            this.rbtnD7.Location = new System.Drawing.Point(163, 153);
            this.rbtnD7.Name = "rbtnD7";
            this.rbtnD7.Size = new System.Drawing.Size(133, 43);
            this.rbtnD7.TabIndex = 2;
            this.rbtnD7.TabStop = true;
            this.rbtnD7.Text = "7 Dias";
            this.rbtnD7.UseVisualStyleBackColor = false;
            // 
            // rbtnD14
            // 
            this.rbtnD14.AutoSize = true;
            this.rbtnD14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rbtnD14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.rbtnD14.ForeColor = System.Drawing.Color.White;
            this.rbtnD14.Location = new System.Drawing.Point(296, 153);
            this.rbtnD14.Name = "rbtnD14";
            this.rbtnD14.Size = new System.Drawing.Size(152, 43);
            this.rbtnD14.TabIndex = 3;
            this.rbtnD14.TabStop = true;
            this.rbtnD14.Text = "14 Dias";
            this.rbtnD14.UseVisualStyleBackColor = false;
            // 
            // rbtnD21
            // 
            this.rbtnD21.AutoSize = true;
            this.rbtnD21.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbtnD21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.rbtnD21.ForeColor = System.Drawing.Color.White;
            this.rbtnD21.Location = new System.Drawing.Point(448, 153);
            this.rbtnD21.Name = "rbtnD21";
            this.rbtnD21.Size = new System.Drawing.Size(152, 43);
            this.rbtnD21.TabIndex = 4;
            this.rbtnD21.TabStop = true;
            this.rbtnD21.Text = "21 Dias";
            this.rbtnD21.UseVisualStyleBackColor = false;
            // 
            // rbtnD30
            // 
            this.rbtnD30.AutoSize = true;
            this.rbtnD30.BackColor = System.Drawing.Color.MediumBlue;
            this.rbtnD30.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.rbtnD30.ForeColor = System.Drawing.Color.White;
            this.rbtnD30.Location = new System.Drawing.Point(600, 153);
            this.rbtnD30.Name = "rbtnD30";
            this.rbtnD30.Size = new System.Drawing.Size(152, 43);
            this.rbtnD30.TabIndex = 5;
            this.rbtnD30.TabStop = true;
            this.rbtnD30.Text = "30 Dias";
            this.rbtnD30.UseVisualStyleBackColor = false;
            this.rbtnD30.CheckedChanged += new System.EventHandler(this.rbtnD30_CheckedChanged);
            // 
            // btnPlano
            // 
            this.btnPlano.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlano.ForeColor = System.Drawing.Color.White;
            this.btnPlano.Location = new System.Drawing.Point(406, 354);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(359, 52);
            this.btnPlano.TabIndex = 6;
            this.btnPlano.Text = "Escolha o Plano";
            this.btnPlano.UseVisualStyleBackColor = false;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.White;
            this.btnCancela.Location = new System.Drawing.Point(37, 354);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(366, 52);
            this.btnCancela.TabIndex = 7;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // Tela_de_Tempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoHotel.Properties.Resources.Tela_de_Tempo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnD21);
            this.Controls.Add(this.rbtnD7);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.rbtnD30);
            this.Controls.Add(this.rbtnD14);
            this.Controls.Add(this.rbtnD1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_de_Tempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Tempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnD1;
        private System.Windows.Forms.RadioButton rbtnD7;
        private System.Windows.Forms.RadioButton rbtnD14;
        private System.Windows.Forms.RadioButton rbtnD21;
        private System.Windows.Forms.RadioButton rbtnD30;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.Button btnCancela;
    }
}