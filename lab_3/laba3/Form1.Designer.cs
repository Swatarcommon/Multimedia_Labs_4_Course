namespace laba3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sobel = new System.Windows.Forms.RadioButton();
            this.Laplas = new System.Windows.Forms.RadioButton();
            this.Canny = new System.Windows.Forms.RadioButton();
            this.RGB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 949);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sobel
            // 
            this.Sobel.AutoSize = true;
            this.Sobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sobel.Location = new System.Drawing.Point(14, 157);
            this.Sobel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Sobel.Name = "Sobel";
            this.Sobel.Size = new System.Drawing.Size(261, 89);
            this.Sobel.TabIndex = 3;
            this.Sobel.TabStop = true;
            this.Sobel.Text = "Sobel";
            this.Sobel.UseVisualStyleBackColor = true;
            // 
            // Laplas
            // 
            this.Laplas.AutoSize = true;
            this.Laplas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Laplas.Location = new System.Drawing.Point(14, 393);
            this.Laplas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Laplas.Name = "Laplas";
            this.Laplas.Size = new System.Drawing.Size(291, 89);
            this.Laplas.TabIndex = 4;
            this.Laplas.TabStop = true;
            this.Laplas.Text = "Laplas";
            this.Laplas.UseVisualStyleBackColor = true;
            // 
            // Canny
            // 
            this.Canny.AutoSize = true;
            this.Canny.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Canny.Location = new System.Drawing.Point(19, 615);
            this.Canny.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Canny.Name = "Canny";
            this.Canny.Size = new System.Drawing.Size(286, 89);
            this.Canny.TabIndex = 5;
            this.Canny.TabStop = true;
            this.Canny.Text = "Canny";
            this.Canny.UseVisualStyleBackColor = true;
            // 
            // RGB
            // 
            this.RGB.AutoSize = true;
            this.RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGB.Location = new System.Drawing.Point(14, 868);
            this.RGB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(230, 89);
            this.RGB.TabIndex = 6;
            this.RGB.TabStop = true;
            this.RGB.Text = "RGB";
            this.RGB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1162);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.Canny);
            this.Controls.Add(this.Laplas);
            this.Controls.Add(this.Sobel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Sobel;
        private System.Windows.Forms.RadioButton Laplas;
        private System.Windows.Forms.RadioButton Canny;
        private System.Windows.Forms.RadioButton RGB;
    }
}

