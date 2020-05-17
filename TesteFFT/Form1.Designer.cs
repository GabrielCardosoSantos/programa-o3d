namespace TesteFFT
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDCT = new System.Windows.Forms.Button();
            this.btnIdct = new System.Windows.Forms.Button();
            this.btnFFT = new System.Windows.Forms.Button();
            this.btnInverseFFT = new System.Windows.Forms.Button();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDrawing, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnDCT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIdct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFFT, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInverseFFT, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDCT
            // 
            this.btnDCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDCT.Location = new System.Drawing.Point(3, 44);
            this.btnDCT.Name = "btnDCT";
            this.btnDCT.Size = new System.Drawing.Size(148, 23);
            this.btnDCT.TabIndex = 0;
            this.btnDCT.Text = "DCT";
            this.btnDCT.UseVisualStyleBackColor = true;
            this.btnDCT.Click += new System.EventHandler(this.btnDCT_Click);
            // 
            // btnIdct
            // 
            this.btnIdct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdct.Location = new System.Drawing.Point(3, 155);
            this.btnIdct.Name = "btnIdct";
            this.btnIdct.Size = new System.Drawing.Size(148, 23);
            this.btnIdct.TabIndex = 1;
            this.btnIdct.Text = "IDCT";
            this.btnIdct.UseVisualStyleBackColor = true;
            // 
            // btnFFT
            // 
            this.btnFFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFFT.Location = new System.Drawing.Point(3, 266);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(148, 23);
            this.btnFFT.TabIndex = 2;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            // 
            // btnInverseFFT
            // 
            this.btnInverseFFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInverseFFT.Location = new System.Drawing.Point(3, 377);
            this.btnInverseFFT.Name = "btnInverseFFT";
            this.btnInverseFFT.Size = new System.Drawing.Size(148, 23);
            this.btnInverseFFT.TabIndex = 3;
            this.btnInverseFFT.Text = "Inverse FFT";
            this.btnInverseFFT.UseVisualStyleBackColor = true;
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawing.Location = new System.Drawing.Point(3, 3);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(634, 444);
            this.pnlDrawing.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "FFT ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDCT;
        private System.Windows.Forms.Button btnIdct;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.Button btnInverseFFT;
        private System.Windows.Forms.Panel pnlDrawing;
    }
}

