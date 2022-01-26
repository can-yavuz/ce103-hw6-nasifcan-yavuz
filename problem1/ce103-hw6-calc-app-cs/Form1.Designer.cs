namespace fullCalc
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBasicCalc = new System.Windows.Forms.Button();
            this.btnGraphCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasicCalc
            // 
            this.btnBasicCalc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBasicCalc.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicCalc.Location = new System.Drawing.Point(12, 136);
            this.btnBasicCalc.Name = "btnBasicCalc";
            this.btnBasicCalc.Size = new System.Drawing.Size(336, 62);
            this.btnBasicCalc.TabIndex = 0;
            this.btnBasicCalc.Text = "Basic Calculator";
            this.btnBasicCalc.UseVisualStyleBackColor = false;
            this.btnBasicCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraphCalc
            // 
            this.btnGraphCalc.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGraphCalc.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphCalc.Location = new System.Drawing.Point(12, 222);
            this.btnGraphCalc.Name = "btnGraphCalc";
            this.btnGraphCalc.Size = new System.Drawing.Size(336, 62);
            this.btnGraphCalc.TabIndex = 1;
            this.btnGraphCalc.Text = "Graphic Calculator";
            this.btnGraphCalc.UseVisualStyleBackColor = false;
            this.btnGraphCalc.Click += new System.EventHandler(this.btnGraphCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extended Calculator Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGraphCalc);
            this.Controls.Add(this.btnBasicCalc);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasicCalc;
        private System.Windows.Forms.Button btnGraphCalc;
        private System.Windows.Forms.Label label1;
    }
}

