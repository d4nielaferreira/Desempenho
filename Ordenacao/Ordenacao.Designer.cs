namespace Ordenacao
{
    partial class Ordenacao
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
            this.QuickSort = new System.Windows.Forms.Button();
            this.HeadpSort = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Label();
            this.bFinal = new System.Windows.Forms.Label();
            this.hInicio = new System.Windows.Forms.Label();
            this.hFinal = new System.Windows.Forms.Label();
            this.qInicio = new System.Windows.Forms.Label();
            this.qFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(333, 12);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(75, 23);
            this.QuickSort.TabIndex = 5;
            this.QuickSort.Text = "QuickSort";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.button3_Click);
            // 
            // HeadpSort
            // 
            this.HeadpSort.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.HeadpSort.Location = new System.Drawing.Point(170, 12);
            this.HeadpSort.Name = "HeadpSort";
            this.HeadpSort.Size = new System.Drawing.Size(75, 23);
            this.HeadpSort.TabIndex = 4;
            this.HeadpSort.Text = "HeadpSort";
            this.HeadpSort.UseVisualStyleBackColor = true;
            this.HeadpSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(11, 12);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 3;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // bInicio
            // 
            this.bInicio.AutoSize = true;
            this.bInicio.Location = new System.Drawing.Point(11, 51);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(83, 13);
            this.bInicio.TabIndex = 6;
            this.bInicio.Text = "Horário de inicio";
            // 
            // bFinal
            // 
            this.bFinal.AutoSize = true;
            this.bFinal.Location = new System.Drawing.Point(11, 78);
            this.bFinal.Name = "bFinal";
            this.bFinal.Size = new System.Drawing.Size(63, 13);
            this.bFinal.TabIndex = 7;
            this.bFinal.Text = "Horário final";
            // 
            // hInicio
            // 
            this.hInicio.AutoSize = true;
            this.hInicio.Location = new System.Drawing.Point(167, 51);
            this.hInicio.Name = "hInicio";
            this.hInicio.Size = new System.Drawing.Size(83, 13);
            this.hInicio.TabIndex = 8;
            this.hInicio.Text = "Horário de inicio";
            // 
            // hFinal
            // 
            this.hFinal.AutoSize = true;
            this.hFinal.Location = new System.Drawing.Point(167, 78);
            this.hFinal.Name = "hFinal";
            this.hFinal.Size = new System.Drawing.Size(63, 13);
            this.hFinal.TabIndex = 9;
            this.hFinal.Text = "Horário final";
            // 
            // qInicio
            // 
            this.qInicio.AutoSize = true;
            this.qInicio.Location = new System.Drawing.Point(330, 51);
            this.qInicio.Name = "qInicio";
            this.qInicio.Size = new System.Drawing.Size(83, 13);
            this.qInicio.TabIndex = 10;
            this.qInicio.Text = "Horário de inicio";
            // 
            // qFinal
            // 
            this.qFinal.AutoSize = true;
            this.qFinal.Location = new System.Drawing.Point(330, 78);
            this.qFinal.Name = "qFinal";
            this.qFinal.Size = new System.Drawing.Size(63, 13);
            this.qFinal.TabIndex = 11;
            this.qFinal.Text = "Horário final";
            // 
            // Ordenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 95);
            this.Controls.Add(this.qFinal);
            this.Controls.Add(this.qInicio);
            this.Controls.Add(this.hFinal);
            this.Controls.Add(this.hInicio);
            this.Controls.Add(this.bFinal);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.HeadpSort);
            this.Controls.Add(this.BubbleSort);
            this.Name = "Ordenacao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Button HeadpSort;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Label bInicio;
        private System.Windows.Forms.Label bFinal;
        private System.Windows.Forms.Label hInicio;
        private System.Windows.Forms.Label hFinal;
        private System.Windows.Forms.Label qInicio;
        private System.Windows.Forms.Label qFinal;
    }
}

