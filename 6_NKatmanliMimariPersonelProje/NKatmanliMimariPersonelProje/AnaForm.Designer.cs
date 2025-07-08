namespace NKatmanliMimariPersonelProje
{
    partial class AnaForm
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
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnDepartmanIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(0, 0);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(382, 239);
            this.btnPersonelIslemleri.TabIndex = 0;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = true;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnDepartmanIslemleri
            // 
            this.btnDepartmanIslemleri.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDepartmanIslemleri.Location = new System.Drawing.Point(388, 0);
            this.btnDepartmanIslemleri.Name = "btnDepartmanIslemleri";
            this.btnDepartmanIslemleri.Size = new System.Drawing.Size(411, 239);
            this.btnDepartmanIslemleri.TabIndex = 0;
            this.btnDepartmanIslemleri.Text = "Departman İşlemleri";
            this.btnDepartmanIslemleri.UseVisualStyleBackColor = true;
            this.btnDepartmanIslemleri.Click += new System.EventHandler(this.btnDepartmanIslemleri_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 239);
            this.Controls.Add(this.btnDepartmanIslemleri);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnDepartmanIslemleri;
    }
}