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
            this.btn_detectCircles = new System.Windows.Forms.Button();
            this.btn_detectTriangles = new System.Windows.Forms.Button();
            this.btn_detectLines = new System.Windows.Forms.Button();
            this.btn_detectRectangles = new System.Windows.Forms.Button();
            this.btn_img1_denoise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(817, 418);
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
            this.imgbox1.Location = new System.Drawing.Point(9, 11);
            this.imgbox1.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox1.Name = "imgbox1";
            this.imgbox1.Size = new System.Drawing.Size(400, 400);
            this.imgbox1.TabIndex = 2;
            this.imgbox1.TabStop = false;
            // 
            // imgbox2
            // 
            this.imgbox2.Location = new System.Drawing.Point(413, 11);
            this.imgbox2.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox2.Name = "imgbox2";
            this.imgbox2.Size = new System.Drawing.Size(400, 400);
            this.imgbox2.TabIndex = 3;
            this.imgbox2.TabStop = false;
            // 
            // imgbox3
            // 
            this.imgbox3.Location = new System.Drawing.Point(817, 11);
            this.imgbox3.Margin = new System.Windows.Forms.Padding(2);
            this.imgbox3.Name = "imgbox3";
            this.imgbox3.Size = new System.Drawing.Size(400, 400);
            this.imgbox3.TabIndex = 4;
            this.imgbox3.TabStop = false;
            // 
            // l_matchfound
            // 
            this.l_matchfound.AutoSize = true;
            this.l_matchfound.Location = new System.Drawing.Point(934, 422);
            this.l_matchfound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_matchfound.Name = "l_matchfound";
            this.l_matchfound.Size = new System.Drawing.Size(52, 13);
            this.l_matchfound.TabIndex = 5;
            this.l_matchfound.Text = "not found";
            // 
            // l_matchtime
            // 
            this.l_matchtime.AutoSize = true;
            this.l_matchtime.Location = new System.Drawing.Point(900, 422);
            this.l_matchtime.Name = "l_matchtime";
            this.l_matchtime.Size = new System.Drawing.Size(29, 13);
            this.l_matchtime.TabIndex = 6;
            this.l_matchtime.Text = "0 ms";
            // 
            // btn_img1_load
            // 
            this.btn_img1_load.Location = new System.Drawing.Point(9, 416);
            this.btn_img1_load.Name = "btn_img1_load";
            this.btn_img1_load.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_load.TabIndex = 7;
            this.btn_img1_load.Text = "Load";
            this.btn_img1_load.UseVisualStyleBackColor = true;
            this.btn_img1_load.Click += new System.EventHandler(this.btn_img1_load_Click);
            // 
            // btn_img1_tohsv
            // 
            this.btn_img1_tohsv.Location = new System.Drawing.Point(9, 473);
            this.btn_img1_tohsv.Name = "btn_img1_tohsv";
            this.btn_img1_tohsv.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_tohsv.TabIndex = 8;
            this.btn_img1_tohsv.Text = "toHSV";
            this.btn_img1_tohsv.UseVisualStyleBackColor = true;
            this.btn_img1_tohsv.Click += new System.EventHandler(this.btn_img1_tohsv_Click);
            // 
            // btn_img2_load
            // 
            this.btn_img2_load.Location = new System.Drawing.Point(413, 416);
            this.btn_img2_load.Name = "btn_img2_load";
            this.btn_img2_load.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_load.TabIndex = 9;
            this.btn_img2_load.Text = "Load";
            this.btn_img2_load.UseVisualStyleBackColor = true;
            this.btn_img2_load.Click += new System.EventHandler(this.btn_img2_load_Click);
            // 
            // btn_img2_tohsv
            // 
            this.btn_img2_tohsv.Location = new System.Drawing.Point(413, 473);
            this.btn_img2_tohsv.Name = "btn_img2_tohsv";
            this.btn_img2_tohsv.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_tohsv.TabIndex = 10;
            this.btn_img2_tohsv.Text = "toHSV";
            this.btn_img2_tohsv.UseVisualStyleBackColor = true;
            this.btn_img2_tohsv.Click += new System.EventHandler(this.btn_img2_tohsv_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(817, 443);
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
            this.btn_img1_togrey.Location = new System.Drawing.Point(9, 502);
            this.btn_img1_togrey.Name = "btn_img1_togrey";
            this.btn_img1_togrey.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_togrey.TabIndex = 12;
            this.btn_img1_togrey.Text = "toGrey";
            this.btn_img1_togrey.UseVisualStyleBackColor = true;
            this.btn_img1_togrey.Click += new System.EventHandler(this.btn_img1_togrey_Click);
            // 
            // btn_img2_togrey
            // 
            this.btn_img2_togrey.Location = new System.Drawing.Point(413, 502);
            this.btn_img2_togrey.Name = "btn_img2_togrey";
            this.btn_img2_togrey.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_togrey.TabIndex = 13;
            this.btn_img2_togrey.Text = "toGrey";
            this.btn_img2_togrey.UseVisualStyleBackColor = true;
            this.btn_img2_togrey.Click += new System.EventHandler(this.btn_img2_togrey_Click);
            // 
            // btn_img1_toOrigin
            // 
            this.btn_img1_toOrigin.Location = new System.Drawing.Point(9, 444);
            this.btn_img1_toOrigin.Name = "btn_img1_toOrigin";
            this.btn_img1_toOrigin.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_toOrigin.TabIndex = 14;
            this.btn_img1_toOrigin.Text = "toOrigin";
            this.btn_img1_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img1_toOrigin.Click += new System.EventHandler(this.btn_img1_toOrigin_Click);
            // 
            // btn_img2_toOrigin
            // 
            this.btn_img2_toOrigin.Location = new System.Drawing.Point(413, 445);
            this.btn_img2_toOrigin.Name = "btn_img2_toOrigin";
            this.btn_img2_toOrigin.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_toOrigin.TabIndex = 15;
            this.btn_img2_toOrigin.Text = "toOrigin";
            this.btn_img2_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img2_toOrigin.Click += new System.EventHandler(this.btn_img2_toOrigin_Click);
            // 
            // btn_detectCircles
            // 
            this.btn_detectCircles.Location = new System.Drawing.Point(1063, 473);
            this.btn_detectCircles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_detectCircles.Name = "btn_detectCircles";
            this.btn_detectCircles.Size = new System.Drawing.Size(78, 44);
            this.btn_detectCircles.TabIndex = 16;
            this.btn_detectCircles.Text = "Detect Circles";
            this.btn_detectCircles.UseVisualStyleBackColor = true;
            this.btn_detectCircles.Click += new System.EventHandler(this.btn_detectCircles_Click);
            // 
            // btn_detectTriangles
            // 
            this.btn_detectTriangles.Location = new System.Drawing.Point(899, 473);
            this.btn_detectTriangles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_detectTriangles.Name = "btn_detectTriangles";
            this.btn_detectTriangles.Size = new System.Drawing.Size(78, 44);
            this.btn_detectTriangles.TabIndex = 17;
            this.btn_detectTriangles.Text = "Detect Triangles";
            this.btn_detectTriangles.UseVisualStyleBackColor = true;
            this.btn_detectTriangles.Click += new System.EventHandler(this.btn_detectTriangles_Click);
            // 
            // btn_detectLines
            // 
            this.btn_detectLines.Location = new System.Drawing.Point(817, 473);
            this.btn_detectLines.Margin = new System.Windows.Forms.Padding(2);
            this.btn_detectLines.Name = "btn_detectLines";
            this.btn_detectLines.Size = new System.Drawing.Size(78, 44);
            this.btn_detectLines.TabIndex = 18;
            this.btn_detectLines.Text = "Detect   Lines";
            this.btn_detectLines.UseVisualStyleBackColor = true;
            this.btn_detectLines.Click += new System.EventHandler(this.btn_detectLines_Click);
            // 
            // btn_detectRectangles
            // 
            this.btn_detectRectangles.Location = new System.Drawing.Point(981, 473);
            this.btn_detectRectangles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_detectRectangles.Name = "btn_detectRectangles";
            this.btn_detectRectangles.Size = new System.Drawing.Size(78, 44);
            this.btn_detectRectangles.TabIndex = 19;
            this.btn_detectRectangles.Text = "Detect Rectangles";
            this.btn_detectRectangles.UseVisualStyleBackColor = true;
            this.btn_detectRectangles.Click += new System.EventHandler(this.btn_detectRectangles_Click);
            // 
            // btn_img1_denoise
            // 
            this.btn_img1_denoise.Location = new System.Drawing.Point(9, 531);
            this.btn_img1_denoise.Name = "btn_img1_denoise";
            this.btn_img1_denoise.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_denoise.TabIndex = 20;
            this.btn_img1_denoise.Text = "denoise";
            this.btn_img1_denoise.UseVisualStyleBackColor = true;
            this.btn_img1_denoise.Click += new System.EventHandler(this.btn_img1_denoise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 583);
            this.Controls.Add(this.btn_img1_denoise);
            this.Controls.Add(this.btn_detectRectangles);
            this.Controls.Add(this.btn_detectLines);
            this.Controls.Add(this.btn_detectTriangles);
            this.Controls.Add(this.btn_detectCircles);
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
            this.Text = "SignRecognition";
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
        private System.Windows.Forms.Button btn_detectCircles;
        private System.Windows.Forms.Button btn_detectTriangles;
        private System.Windows.Forms.Button btn_detectLines;
        private System.Windows.Forms.Button btn_detectRectangles;
        private System.Windows.Forms.Button btn_img1_denoise;
    }
}

