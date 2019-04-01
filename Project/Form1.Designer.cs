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
            this.btn_compare = new System.Windows.Forms.Button();
            this.imgbox1 = new Emgu.CV.UI.ImageBox();
            this.imgbox2 = new Emgu.CV.UI.ImageBox();
            this.imgbox3 = new Emgu.CV.UI.ImageBox();
            this.l_matchfound = new System.Windows.Forms.Label();
            this.l_matchtime = new System.Windows.Forms.Label();
            this.btn_img1_load = new System.Windows.Forms.Button();
            this.btn_img1_tohsv = new System.Windows.Forms.Button();
            this.btn_img2_load = new System.Windows.Forms.Button();
            this.btn_img2_tohsv = new System.Windows.Forms.Button();
            this.btn_detect = new System.Windows.Forms.Button();
            this.btn_img1_togrey = new System.Windows.Forms.Button();
            this.btn_img2_togrey = new System.Windows.Forms.Button();
            this.btn_img1_toOrigin = new System.Windows.Forms.Button();
            this.btn_img2_toOrigin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(526, 279);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(78, 21);
            this.btn_compare.TabIndex = 2;
            this.btn_compare.Text = "Comparation";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // imgbox1
            // 
            this.imgbox1.Location = new System.Drawing.Point(9, 10);
            this.imgbox1.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox1.Name = "imgbox1";
            this.imgbox1.Size = new System.Drawing.Size(252, 262);
            this.imgbox1.TabIndex = 2;
            this.imgbox1.TabStop = false;
            // 
            // imgbox2
            // 
            this.imgbox2.Location = new System.Drawing.Point(266, 10);
            this.imgbox2.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox2.Name = "imgbox2";
            this.imgbox2.Size = new System.Drawing.Size(256, 262);
            this.imgbox2.TabIndex = 3;
            this.imgbox2.TabStop = false;
            // 
            // imgbox3
            // 
            this.imgbox3.Location = new System.Drawing.Point(526, 10);
            this.imgbox3.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox3.Name = "imgbox3";
            this.imgbox3.Size = new System.Drawing.Size(291, 262);
            this.imgbox3.TabIndex = 4;
            this.imgbox3.TabStop = false;
            // 
            // l_matchfound
            // 
            this.l_matchfound.AutoSize = true;
            this.l_matchfound.Location = new System.Drawing.Point(765, 279);
            this.l_matchfound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_matchfound.Name = "l_matchfound";
            this.l_matchfound.Size = new System.Drawing.Size(52, 13);
            this.l_matchfound.TabIndex = 5;
            this.l_matchfound.Text = "not found";
            // 
            // l_matchtime
            // 
            this.l_matchtime.AutoSize = true;
            this.l_matchtime.Location = new System.Drawing.Point(765, 301);
            this.l_matchtime.Name = "l_matchtime";
            this.l_matchtime.Size = new System.Drawing.Size(29, 13);
            this.l_matchtime.TabIndex = 6;
            this.l_matchtime.Text = "0 ms";
            // 
            // btn_img1_load
            // 
            this.btn_img1_load.Location = new System.Drawing.Point(9, 277);
            this.btn_img1_load.Name = "btn_img1_load";
            this.btn_img1_load.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_load.TabIndex = 7;
            this.btn_img1_load.Text = "Load";
            this.btn_img1_load.UseVisualStyleBackColor = true;
            this.btn_img1_load.Click += new System.EventHandler(this.btn_img1_load_Click);
            // 
            // btn_img1_tohsv
            // 
            this.btn_img1_tohsv.Location = new System.Drawing.Point(9, 334);
            this.btn_img1_tohsv.Name = "btn_img1_tohsv";
            this.btn_img1_tohsv.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_tohsv.TabIndex = 8;
            this.btn_img1_tohsv.Text = "toHSV";
            this.btn_img1_tohsv.UseVisualStyleBackColor = true;
            this.btn_img1_tohsv.Click += new System.EventHandler(this.btn_img1_tohsv_Click);
            // 
            // btn_img2_load
            // 
            this.btn_img2_load.Location = new System.Drawing.Point(266, 277);
            this.btn_img2_load.Name = "btn_img2_load";
            this.btn_img2_load.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_load.TabIndex = 9;
            this.btn_img2_load.Text = "Load";
            this.btn_img2_load.UseVisualStyleBackColor = true;
            this.btn_img2_load.Click += new System.EventHandler(this.btn_img2_load_Click);
            // 
            // btn_img2_tohsv
            // 
            this.btn_img2_tohsv.Location = new System.Drawing.Point(266, 334);
            this.btn_img2_tohsv.Name = "btn_img2_tohsv";
            this.btn_img2_tohsv.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_tohsv.TabIndex = 10;
            this.btn_img2_tohsv.Text = "toHSV";
            this.btn_img2_tohsv.UseVisualStyleBackColor = true;
            this.btn_img2_tohsv.Click += new System.EventHandler(this.btn_img2_tohsv_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(526, 307);
            this.btn_detect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(78, 21);
            this.btn_detect.TabIndex = 11;
            this.btn_detect.Text = "Detection";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // btn_img1_togrey
            // 
            this.btn_img1_togrey.Location = new System.Drawing.Point(9, 363);
            this.btn_img1_togrey.Name = "btn_img1_togrey";
            this.btn_img1_togrey.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_togrey.TabIndex = 12;
            this.btn_img1_togrey.Text = "toGrey";
            this.btn_img1_togrey.UseVisualStyleBackColor = true;
            this.btn_img1_togrey.Click += new System.EventHandler(this.btn_img1_togrey_Click);
            // 
            // btn_img2_togrey
            // 
            this.btn_img2_togrey.Location = new System.Drawing.Point(266, 363);
            this.btn_img2_togrey.Name = "btn_img2_togrey";
            this.btn_img2_togrey.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_togrey.TabIndex = 13;
            this.btn_img2_togrey.Text = "toGrey";
            this.btn_img2_togrey.UseVisualStyleBackColor = true;
            this.btn_img2_togrey.Click += new System.EventHandler(this.btn_img2_togrey_Click);
            // 
            // btn_img1_toOrigin
            // 
            this.btn_img1_toOrigin.Location = new System.Drawing.Point(9, 305);
            this.btn_img1_toOrigin.Name = "btn_img1_toOrigin";
            this.btn_img1_toOrigin.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_toOrigin.TabIndex = 14;
            this.btn_img1_toOrigin.Text = "toOrigin";
            this.btn_img1_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img1_toOrigin.Click += new System.EventHandler(this.btn_img1_toOrigin_Click);
            // 
            // btn_img2_toOrigin
            // 
            this.btn_img2_toOrigin.Location = new System.Drawing.Point(266, 306);
            this.btn_img2_toOrigin.Name = "btn_img2_toOrigin";
            this.btn_img2_toOrigin.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_toOrigin.TabIndex = 15;
            this.btn_img2_toOrigin.Text = "toOrigin";
            this.btn_img2_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img2_toOrigin.Click += new System.EventHandler(this.btn_img2_toOrigin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 446);
            this.Controls.Add(this.btn_img2_toOrigin);
            this.Controls.Add(this.btn_img1_toOrigin);
            this.Controls.Add(this.btn_img2_togrey);
            this.Controls.Add(this.btn_img1_togrey);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.btn_img2_tohsv);
            this.Controls.Add(this.btn_img2_load);
            this.Controls.Add(this.btn_img1_tohsv);
            this.Controls.Add(this.btn_img1_load);
            this.Controls.Add(this.l_matchtime);
            this.Controls.Add(this.l_matchfound);
            this.Controls.Add(this.imgbox3);
            this.Controls.Add(this.imgbox2);
            this.Controls.Add(this.imgbox1);
            this.Controls.Add(this.btn_compare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Proj";
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_compare;
        private Emgu.CV.UI.ImageBox imgbox1;
        private Emgu.CV.UI.ImageBox imgbox2;
        private Emgu.CV.UI.ImageBox imgbox3;
        private System.Windows.Forms.Label l_matchfound;
        private System.Windows.Forms.Label l_matchtime;
        private System.Windows.Forms.Button btn_img1_load;
        private System.Windows.Forms.Button btn_img1_tohsv;
        private System.Windows.Forms.Button btn_img2_load;
        private System.Windows.Forms.Button btn_img2_tohsv;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.Button btn_img1_togrey;
        private System.Windows.Forms.Button btn_img2_togrey;
        private System.Windows.Forms.Button btn_img1_toOrigin;
        private System.Windows.Forms.Button btn_img2_toOrigin;
    }
}

