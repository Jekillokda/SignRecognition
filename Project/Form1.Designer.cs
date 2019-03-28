namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.btn_open = new System.Windows.Forms.Button();
            this.imgbox1 = new Emgu.CV.UI.ImageBox();
            this.imgbox2 = new Emgu.CV.UI.ImageBox();
            this.imgbox3 = new Emgu.CV.UI.ImageBox();
            this.l_matchTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(1068, 42);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(85, 26);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "OpenImg";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // imgbox1
            // 
            this.imgbox1.Location = new System.Drawing.Point(12, 12);
            this.imgbox1.Name = "imgbox1";
            this.imgbox1.Size = new System.Drawing.Size(336, 323);
            this.imgbox1.TabIndex = 2;
            this.imgbox1.TabStop = false;
            // 
            // imgbox2
            // 
            this.imgbox2.Location = new System.Drawing.Point(354, 12);
            this.imgbox2.Name = "imgbox2";
            this.imgbox2.Size = new System.Drawing.Size(314, 323);
            this.imgbox2.TabIndex = 3;
            this.imgbox2.TabStop = false;
            // 
            // imgbox3
            // 
            this.imgbox3.Location = new System.Drawing.Point(674, 12);
            this.imgbox3.Name = "imgbox3";
            this.imgbox3.Size = new System.Drawing.Size(388, 323);
            this.imgbox3.TabIndex = 4;
            this.imgbox3.TabStop = false;
            // 
            // l_matchTime
            // 
            this.l_matchTime.AutoSize = true;
            this.l_matchTime.Location = new System.Drawing.Point(1068, 75);
            this.l_matchTime.Name = "l_matchTime";
            this.l_matchTime.Size = new System.Drawing.Size(0, 17);
            this.l_matchTime.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 549);
            this.Controls.Add(this.l_matchTime);
            this.Controls.Add(this.imgbox3);
            this.Controls.Add(this.imgbox2);
            this.Controls.Add(this.imgbox1);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Proj";
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_open;
        private Emgu.CV.UI.ImageBox imgbox1;
        private Emgu.CV.UI.ImageBox imgbox2;
        private Emgu.CV.UI.ImageBox imgbox3;
        private System.Windows.Forms.Label l_matchTime;
    }
}

