namespace Contrato_de_Locação
{
    partial class FrmLocalImovel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalImovel));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnBuscarCepLocador = new System.Windows.Forms.Button();
            this.mkCEP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            resources.ApplyResources(this.btnConfirmar, "btnConfirmar");
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.TabStop = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbEstado, "cbEstado");
            this.cbEstado.ForeColor = System.Drawing.Color.White;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            resources.GetString("cbEstado.Items"),
            resources.GetString("cbEstado.Items1"),
            resources.GetString("cbEstado.Items2"),
            resources.GetString("cbEstado.Items3"),
            resources.GetString("cbEstado.Items4"),
            resources.GetString("cbEstado.Items5"),
            resources.GetString("cbEstado.Items6"),
            resources.GetString("cbEstado.Items7"),
            resources.GetString("cbEstado.Items8"),
            resources.GetString("cbEstado.Items9"),
            resources.GetString("cbEstado.Items10"),
            resources.GetString("cbEstado.Items11"),
            resources.GetString("cbEstado.Items12"),
            resources.GetString("cbEstado.Items13"),
            resources.GetString("cbEstado.Items14"),
            resources.GetString("cbEstado.Items15"),
            resources.GetString("cbEstado.Items16"),
            resources.GetString("cbEstado.Items17"),
            resources.GetString("cbEstado.Items18"),
            resources.GetString("cbEstado.Items19"),
            resources.GetString("cbEstado.Items20"),
            resources.GetString("cbEstado.Items21"),
            resources.GetString("cbEstado.Items22"),
            resources.GetString("cbEstado.Items23"),
            resources.GetString("cbEstado.Items24"),
            resources.GetString("cbEstado.Items25"),
            resources.GetString("cbEstado.Items26")});
            this.cbEstado.Name = "cbEstado";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.txtBairro.Name = "txtBairro";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.txtEndereco.Name = "txtEndereco";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // btnBuscarCepLocador
            // 
            this.btnBuscarCepLocador.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnBuscarCepLocador, "btnBuscarCepLocador");
            this.btnBuscarCepLocador.Name = "btnBuscarCepLocador";
            this.btnBuscarCepLocador.TabStop = false;
            this.btnBuscarCepLocador.UseVisualStyleBackColor = false;
            this.btnBuscarCepLocador.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // mkCEP
            // 
            resources.ApplyResources(this.mkCEP, "mkCEP");
            this.mkCEP.Name = "mkCEP";
            // 
            // FrmLocalImovel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnBuscarCepLocador);
            this.Controls.Add(this.mkCEP);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnConfirmar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalImovel";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLocalImovel_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnBuscarCepLocador;
        private System.Windows.Forms.MaskedTextBox mkCEP;
    }
}

