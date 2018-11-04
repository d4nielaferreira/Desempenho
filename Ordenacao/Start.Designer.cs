namespace Ordenacao
{
    partial class Start
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
            this.btnAleat = new System.Windows.Forms.Button();
            this.btnAdValores = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.campValores = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAleat
            // 
            this.btnAleat.Location = new System.Drawing.Point(11, 76);
            this.btnAleat.Name = "btnAleat";
            this.btnAleat.Size = new System.Drawing.Size(142, 23);
            this.btnAleat.TabIndex = 0;
            this.btnAleat.Text = "Gerar números aleatórios";
            this.btnAleat.UseVisualStyleBackColor = true;
            this.btnAleat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdValores
            // 
            this.btnAdValores.Location = new System.Drawing.Point(184, 76);
            this.btnAdValores.Name = "btnAdValores";
            this.btnAdValores.Size = new System.Drawing.Size(145, 23);
            this.btnAdValores.TabIndex = 1;
            this.btnAdValores.Text = "Adicionar valores";
            this.btnAdValores.UseVisualStyleBackColor = true;
            this.btnAdValores.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(254, 76);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(173, 76);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // campValores
            // 
            this.campValores.Location = new System.Drawing.Point(12, 78);
            this.campValores.Name = "campValores";
            this.campValores.Size = new System.Drawing.Size(141, 20);
            this.campValores.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(11, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(51, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 111);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.campValores);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdValores);
            this.Controls.Add(this.btnAleat);
            this.Name = "Start";
            this.Text = "Ordenação";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAleat;
        private System.Windows.Forms.Button btnAdValores;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox campValores;
        private System.Windows.Forms.Button btnVoltar;
    }
}