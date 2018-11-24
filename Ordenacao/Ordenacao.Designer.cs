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
            this.bFinal = new System.Windows.Forms.Label();
            this.hFinal = new System.Windows.Forms.Label();
            this.qFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(367, 24);
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
            this.HeadpSort.Location = new System.Drawing.Point(204, 24);
            this.HeadpSort.Name = "HeadpSort";
            this.HeadpSort.Size = new System.Drawing.Size(75, 23);
            this.HeadpSort.TabIndex = 4;
            this.HeadpSort.Text = "HeapSort";
            this.HeadpSort.UseVisualStyleBackColor = true;
            this.HeadpSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(45, 24);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 3;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // bFinal
            // 
            this.bFinal.AutoSize = true;
            this.bFinal.Location = new System.Drawing.Point(42, 63);
            this.bFinal.Name = "bFinal";
            this.bFinal.Size = new System.Drawing.Size(51, 13);
            this.bFinal.TabIndex = 7;
            this.bFinal.Text = "Duração:";
            this.bFinal.Click += new System.EventHandler(this.bFinal_Click);
            // 
            // hFinal
            // 
            this.hFinal.AutoSize = true;
            this.hFinal.Location = new System.Drawing.Point(201, 63);
            this.hFinal.Name = "hFinal";
            this.hFinal.Size = new System.Drawing.Size(51, 13);
            this.hFinal.TabIndex = 9;
            this.hFinal.Text = "Duração:";
            // 
            // qFinal
            // 
            this.qFinal.AutoSize = true;
            this.qFinal.Location = new System.Drawing.Point(364, 63);
            this.qFinal.Name = "qFinal";
            this.qFinal.Size = new System.Drawing.Size(51, 13);
            this.qFinal.TabIndex = 11;
            this.qFinal.Text = "Duração:";
            this.qFinal.Click += new System.EventHandler(this.qFinal_Click);
            // 
            // Ordenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.qFinal);
            this.Controls.Add(this.hFinal);
            this.Controls.Add(this.bFinal);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.HeadpSort);
            this.Controls.Add(this.BubbleSort);
            this.Name = "Ordenacao";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ordenacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Button HeadpSort;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Label bFinal;
        private System.Windows.Forms.Label hFinal;
        private System.Windows.Forms.Label qFinal;
    }
}

