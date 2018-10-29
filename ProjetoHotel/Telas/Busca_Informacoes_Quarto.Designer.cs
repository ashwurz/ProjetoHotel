namespace ProjetoHotel.Telas
{
    partial class Busca_Informacoes_Quarto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscaQuarto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCliente = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 16;
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
            this.btnBuscaCliente.Size = new System.Drawing.Size(135, 22);
            this.btnBuscaCliente.Text = "Por Cliente";
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // btnBuscaQuarto
            // 
            this.btnBuscaQuarto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaQuarto.Name = "btnBuscaQuarto";
            this.btnBuscaQuarto.Size = new System.Drawing.Size(135, 22);
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
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(166, 24);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(103, 31);
            this.labelCliente.TabIndex = 17;
            this.labelCliente.Text = "Quarto";
            // 
            // panelResult
            // 
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Controls.Add(this.txtSobrenome);
            this.panelResult.Controls.Add(this.label2);
            this.panelResult.Controls.Add(this.btnOK);
            this.panelResult.Controls.Add(this.txtPlano);
            this.panelResult.Controls.Add(this.txtTempo);
            this.panelResult.Controls.Add(this.txtEndereco);
            this.panelResult.Controls.Add(this.txtNome);
            this.panelResult.Controls.Add(this.txtTelefone);
            this.panelResult.Controls.Add(this.label8);
            this.panelResult.Controls.Add(this.label7);
            this.panelResult.Controls.Add(this.label6);
            this.panelResult.Controls.Add(this.label5);
            this.panelResult.Controls.Add(this.label4);
            this.panelResult.Location = new System.Drawing.Point(457, 27);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(343, 411);
            this.panelResult.TabIndex = 18;
            this.panelResult.Visible = false;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Enabled = false;
            this.txtSobrenome.Location = new System.Drawing.Point(8, 84);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(328, 20);
            this.txtSobrenome.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sobrenome";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(129, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 36);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPlano
            // 
            this.txtPlano.Enabled = false;
            this.txtPlano.Location = new System.Drawing.Point(8, 241);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(328, 20);
            this.txtPlano.TabIndex = 9;
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Location = new System.Drawing.Point(8, 202);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(328, 20);
            this.txtTempo.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(8, 163);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(328, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(8, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(8, 123);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(328, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Plano:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Período:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone:";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(115, 104);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(340, 20);
            this.txtQuarto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número do Quarto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(169, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 36);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Busca_Informacoes_Quarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Busca_Informacoes_Quarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Reserva";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnCheck;
        private System.Windows.Forms.ToolStripMenuItem btnCheckout;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaReserva;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaCliente;
        private System.Windows.Forms.ToolStripMenuItem btnBuscaQuarto;
        private System.Windows.Forms.ToolStripMenuItem btnLogoff;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label2;
    }
}