namespace ProjetoHotel
{
    partial class Checkinout
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(82, 107);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(176, 69);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Check-IN";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(82, 252);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(176, 72);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Check-OUT";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(402, 107);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(214, 115);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Informações de Reservas";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(402, 252);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(214, 72);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "Cadastrar Cliente";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // Checkinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Name = "Checkinout";
            this.Text = "Checkinout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnReservar;
    }
}