namespace Empresa
{
    partial class FrmTelaPrincipal
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Funcionarios = new System.Windows.Forms.Button();
            this.btn_Setor = new System.Windows.Forms.Button();
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.btn_Perfil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // setorToolStripMenuItem
            // 
            this.setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            this.setorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.setorToolStripMenuItem.Text = "Setor";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionários";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btn_Funcionarios
            // 
            this.btn_Funcionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Funcionarios.ForeColor = System.Drawing.Color.Black;
            this.btn_Funcionarios.Location = new System.Drawing.Point(12, 53);
            this.btn_Funcionarios.Name = "btn_Funcionarios";
            this.btn_Funcionarios.Size = new System.Drawing.Size(141, 62);
            this.btn_Funcionarios.TabIndex = 1;
            this.btn_Funcionarios.Text = "Funcionários";
            this.btn_Funcionarios.UseVisualStyleBackColor = false;
            // 
            // btn_Setor
            // 
            this.btn_Setor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Setor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Setor.Location = new System.Drawing.Point(12, 185);
            this.btn_Setor.Name = "btn_Setor";
            this.btn_Setor.Size = new System.Drawing.Size(141, 62);
            this.btn_Setor.TabIndex = 2;
            this.btn_Setor.Text = "Setor";
            this.btn_Setor.UseVisualStyleBackColor = false;
            this.btn_Setor.Click += new System.EventHandler(this.btn_Setor_Click);
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Usuario.Location = new System.Drawing.Point(12, 449);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(141, 62);
            this.btn_Usuario.TabIndex = 3;
            this.btn_Usuario.Text = "Usuário";
            this.btn_Usuario.UseVisualStyleBackColor = false;
            // 
            // btn_Perfil
            // 
            this.btn_Perfil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Perfil.Location = new System.Drawing.Point(12, 317);
            this.btn_Perfil.Name = "btn_Perfil";
            this.btn_Perfil.Size = new System.Drawing.Size(141, 62);
            this.btn_Perfil.TabIndex = 4;
            this.btn_Perfil.Text = "Perfil";
            this.btn_Perfil.UseVisualStyleBackColor = false;
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Empresa.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(537, 543);
            this.Controls.Add(this.btn_Perfil);
            this.Controls.Add(this.btn_Usuario);
            this.Controls.Add(this.btn_Setor);
            this.Controls.Add(this.btn_Funcionarios);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTelaPrincipal";
            this.Text = "FrmTelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_Funcionarios;
        private System.Windows.Forms.Button btn_Setor;
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.Button btn_Perfil;
    }
}