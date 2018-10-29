namespace ProjetoHotel
{
    partial class Tela_de_Check_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_Check_In));
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbSobrenome = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaQuarto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(78, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 25);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Digite o Nome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.AutoSize = true;
            this.txtSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(83, 136);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(249, 25);
            this.txtSobrenome.TabIndex = 1;
            this.txtSobrenome.Text = "Digite o Ultimo Sobrenome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(224, 73);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(434, 30);
            this.txtbNome.TabIndex = 2;
            // 
            // txtbSobrenome
            // 
            this.txtbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSobrenome.Location = new System.Drawing.Point(338, 131);
            this.txtbSobrenome.Name = "txtbSobrenome";
            this.txtbSobrenome.Size = new System.Drawing.Size(320, 30);
            this.txtbSobrenome.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(287, 243);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(158, 48);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Confirmar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(287, 337);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(158, 50);
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.Text = "Check-in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrar,
            this.btnCheck,
            this.btnCheckout,
            this.btnBuscaReserva,
            this.btnLogoff});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 20);
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 20);
            this.btnCheck.Text = "Check-IN";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(82, 20);
            this.btnCheckout.Text = "Check-OUT";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnBuscaReserva
            // 
            this.btnBuscaReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscaCliente,
            this.btnBuscaQuarto});
            this.btnBuscaReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscaReserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaReserva.Name = "btnBuscaReserva";
            this.btnBuscaReserva.Size = new System.Drawing.Size(109, 20);
            this.btnBuscaReserva.Text = "Buscar Reservas";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(180, 22);
            this.btnBuscaCliente.Text = "Por Cliente";
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // btnBuscaQuarto
            // 
            this.btnBuscaQuarto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaQuarto.Name = "btnBuscaQuarto";
            this.btnBuscaQuarto.Size = new System.Drawing.Size(180, 22);
            this.btnBuscaQuarto.Text = "Por Quarto";
            this.btnBuscaQuarto.Click += new System.EventHandler(this.btnBuscaQuarto_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogoff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogoff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(56, 20);
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // Tela_de_Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtbSobrenome);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_de_Check_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-IN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtSobrenome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbSobrenome;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnCheck;
        private System.Windows.Forms.ToolStripMenuItem btnCheckout;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaReserva;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaCliente;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaQuarto;
        private System.Windows.Forms.ToolStripMenuItem btnLogoff;
    }
}