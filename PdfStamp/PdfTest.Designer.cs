namespace PdfStamp
{
    partial class PdfTest
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
            this.bShowGrade = new System.Windows.Forms.Button();
            this.bShowStamp = new System.Windows.Forms.Button();
            this.bCreateAndShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShowGrade
            // 
            this.bShowGrade.Location = new System.Drawing.Point(26, 29);
            this.bShowGrade.Name = "bShowGrade";
            this.bShowGrade.Size = new System.Drawing.Size(142, 29);
            this.bShowGrade.TabIndex = 0;
            this.bShowGrade.Text = "Titta på betyg";
            this.bShowGrade.UseVisualStyleBackColor = true;
            this.bShowGrade.Click += new System.EventHandler(this.bShowGrade_Click);
            // 
            // bShowStamp
            // 
            this.bShowStamp.Location = new System.Drawing.Point(26, 76);
            this.bShowStamp.Name = "bShowStamp";
            this.bShowStamp.Size = new System.Drawing.Size(142, 30);
            this.bShowStamp.TabIndex = 1;
            this.bShowStamp.Text = "Titta på stämpel";
            this.bShowStamp.UseVisualStyleBackColor = true;
            this.bShowStamp.Click += new System.EventHandler(this.bShowStamp_Click);
            // 
            // bCreateAndShow
            // 
            this.bCreateAndShow.Location = new System.Drawing.Point(26, 131);
            this.bCreateAndShow.Name = "bCreateAndShow";
            this.bCreateAndShow.Size = new System.Drawing.Size(193, 30);
            this.bCreateAndShow.TabIndex = 2;
            this.bCreateAndShow.Text = "Skapa ny pdf med stämpel";
            this.bCreateAndShow.UseVisualStyleBackColor = true;
            this.bCreateAndShow.Click += new System.EventHandler(this.bCreateAndShow_Click);
            // 
            // PdfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.bCreateAndShow);
            this.Controls.Add(this.bShowStamp);
            this.Controls.Add(this.bShowGrade);
            this.Name = "PdfTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShowGrade;
        private System.Windows.Forms.Button bShowStamp;
        private System.Windows.Forms.Button bCreateAndShow;
    }
}

