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
            this.l_matchfound = new System.Windows.Forms.Label();
            this.l_matchtime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(801, 34);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(64, 21);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "OpenImg";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // imgbox1
            // 
            this.imgbox1.Location = new System.Drawing.Point(9, 10);
            this.imgbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgbox1.Name = "imgbox1";
            this.imgbox1.Size = new System.Drawing.Size(252, 262);
            this.imgbox1.TabIndex = 2;
            this.imgbox1.TabStop = false;
            // 
            // imgbox2
            // 
            this.imgbox2.Location = new System.Drawing.Point(266, 10);
            this.imgbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgbox2.Name = "imgbox2";
            this.imgbox2.Size = new System.Drawing.Size(236, 262);
            this.imgbox2.TabIndex = 3;
            this.imgbox2.TabStop = false;
            // 
            // imgbox3
            // 
            this.imgbox3.Location = new System.Drawing.Point(506, 10);
            this.imgbox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgbox3.Name = "imgbox3";
            this.imgbox3.Size = new System.Drawing.Size(291, 262);
            this.imgbox3.TabIndex = 4;
            this.imgbox3.TabStop = false;
            // 
            // l_matchfound
            // 
            this.l_matchfound.AutoSize = true;
            this.l_matchfound.Location = new System.Drawing.Point(801, 61);
            this.l_matchfound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_matchfound.Name = "l_matchfound";
            this.l_matchfound.Size = new System.Drawing.Size(52, 13);
            this.l_matchfound.TabIndex = 5;
            this.l_matchfound.Text = "not found";
            // 
            // l_matchtime
            // 
            this.l_matchtime.AutoSize = true;
            this.l_matchtime.Location = new System.Drawing.Point(801, 78);
            this.l_matchtime.Name = "l_matchtime";
            this.l_matchtime.Size = new System.Drawing.Size(29, 13);
            this.l_matchtime.TabIndex = 6;
            this.l_matchtime.Text = "0 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 446);
            this.Controls.Add(this.l_matchtime);
            this.Controls.Add(this.l_matchfound);
            this.Controls.Add(this.imgbox3);
            this.Controls.Add(this.imgbox2);
            this.Controls.Add(this.imgbox1);
            this.Controls.Add(this.btn_open);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label l_matchfound;
        private System.Windows.Forms.Label l_matchtime;
    }
}

