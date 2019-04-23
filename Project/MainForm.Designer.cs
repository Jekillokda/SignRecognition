namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_compare = new System.Windows.Forms.Button();
            this.l_matchfound = new System.Windows.Forms.Label();
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
            this.btn_img2_denoise = new System.Windows.Forms.Button();
            this.btn_img1_tobinary = new System.Windows.Forms.Button();
            this.btn_img2_tobinary = new System.Windows.Forms.Button();
            this.btn_img1_findColor = new System.Windows.Forms.Button();
            this.tb_FindSMax = new System.Windows.Forms.TextBox();
            this.tb_FindHMax = new System.Windows.Forms.TextBox();
            this.tb_FindVMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FindVMin = new System.Windows.Forms.TextBox();
            this.tb_FindHMin = new System.Windows.Forms.TextBox();
            this.tb_FindSMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_img1_copyimg3 = new System.Windows.Forms.Button();
            this.l_rectangles_count = new System.Windows.Forms.Label();
            this.l_triangles_count = new System.Windows.Forms.Label();
            this.l_lines_count = new System.Windows.Forms.Label();
            this.l_circles_count = new System.Windows.Forms.Label();
            this.img1_toBinary_border = new System.Windows.Forms.TextBox();
            this.img2_toBinary_border = new System.Windows.Forms.TextBox();
            this.btn_load_videos = new System.Windows.Forms.Button();
            this.btn_convert_videos = new System.Windows.Forms.Button();
            this.btn_Haar_Detect = new System.Windows.Forms.Button();
            this.imgbox3 = new Emgu.CV.UI.ImageBox();
            this.imgbox2 = new Emgu.CV.UI.ImageBox();
            this.imgbox1 = new Emgu.CV.UI.ImageBox();
            this.gb_haar_cascade = new System.Windows.Forms.GroupBox();
            this.gb_ffmpeg = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_img1_denoise = new System.Windows.Forms.Button();
            this.btn_img1_CannyDetect = new System.Windows.Forms.Button();
            this.btn_img1_makeSmooth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_img1_resize = new System.Windows.Forms.Button();
            this.tb_resize_y = new System.Windows.Forms.TextBox();
            this.tb_resize_x = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).BeginInit();
            this.gb_haar_cascade.SuspendLayout();
            this.gb_ffmpeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            resources.ApplyResources(this.btn_compare, "btn_compare");
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // l_matchfound
            // 
            resources.ApplyResources(this.l_matchfound, "l_matchfound");
            this.l_matchfound.Name = "l_matchfound";
            // 
            // btn_img1_load
            // 
            resources.ApplyResources(this.btn_img1_load, "btn_img1_load");
            this.btn_img1_load.Name = "btn_img1_load";
            this.btn_img1_load.UseVisualStyleBackColor = true;
            this.btn_img1_load.Click += new System.EventHandler(this.btn_img1_load_Click);
            // 
            // btn_img1_tohsv
            // 
            resources.ApplyResources(this.btn_img1_tohsv, "btn_img1_tohsv");
            this.btn_img1_tohsv.Name = "btn_img1_tohsv";
            this.btn_img1_tohsv.UseVisualStyleBackColor = true;
            this.btn_img1_tohsv.Click += new System.EventHandler(this.btn_img1_tohsv_Click);
            // 
            // btn_img2_load
            // 
            resources.ApplyResources(this.btn_img2_load, "btn_img2_load");
            this.btn_img2_load.Name = "btn_img2_load";
            this.btn_img2_load.UseVisualStyleBackColor = true;
            this.btn_img2_load.Click += new System.EventHandler(this.btn_img2_load_Click);
            // 
            // btn_img2_tohsv
            // 
            resources.ApplyResources(this.btn_img2_tohsv, "btn_img2_tohsv");
            this.btn_img2_tohsv.Name = "btn_img2_tohsv";
            this.btn_img2_tohsv.UseVisualStyleBackColor = true;
            this.btn_img2_tohsv.Click += new System.EventHandler(this.btn_img2_tohsv_Click);
            // 
            // btn_detect
            // 
            resources.ApplyResources(this.btn_detect, "btn_detect");
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // btn_img1_togrey
            // 
            resources.ApplyResources(this.btn_img1_togrey, "btn_img1_togrey");
            this.btn_img1_togrey.Name = "btn_img1_togrey";
            this.btn_img1_togrey.UseVisualStyleBackColor = true;
            this.btn_img1_togrey.Click += new System.EventHandler(this.btn_img1_togrey_Click);
            // 
            // btn_img2_togrey
            // 
            resources.ApplyResources(this.btn_img2_togrey, "btn_img2_togrey");
            this.btn_img2_togrey.Name = "btn_img2_togrey";
            this.btn_img2_togrey.UseVisualStyleBackColor = true;
            this.btn_img2_togrey.Click += new System.EventHandler(this.btn_img2_togrey_Click);
            // 
            // btn_img1_toOrigin
            // 
            resources.ApplyResources(this.btn_img1_toOrigin, "btn_img1_toOrigin");
            this.btn_img1_toOrigin.Name = "btn_img1_toOrigin";
            this.btn_img1_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img1_toOrigin.Click += new System.EventHandler(this.btn_img1_toOrigin_Click);
            // 
            // btn_img2_toOrigin
            // 
            resources.ApplyResources(this.btn_img2_toOrigin, "btn_img2_toOrigin");
            this.btn_img2_toOrigin.Name = "btn_img2_toOrigin";
            this.btn_img2_toOrigin.UseVisualStyleBackColor = true;
            this.btn_img2_toOrigin.Click += new System.EventHandler(this.btn_img2_toOrigin_Click);
            // 
            // btn_detectCircles
            // 
            resources.ApplyResources(this.btn_detectCircles, "btn_detectCircles");
            this.btn_detectCircles.Name = "btn_detectCircles";
            this.btn_detectCircles.UseVisualStyleBackColor = true;
            this.btn_detectCircles.Click += new System.EventHandler(this.btn_detectCircles_Click);
            // 
            // btn_detectTriangles
            // 
            resources.ApplyResources(this.btn_detectTriangles, "btn_detectTriangles");
            this.btn_detectTriangles.Name = "btn_detectTriangles";
            this.btn_detectTriangles.UseVisualStyleBackColor = true;
            this.btn_detectTriangles.Click += new System.EventHandler(this.btn_detectTriangles_Click);
            // 
            // btn_detectLines
            // 
            resources.ApplyResources(this.btn_detectLines, "btn_detectLines");
            this.btn_detectLines.Name = "btn_detectLines";
            this.btn_detectLines.UseVisualStyleBackColor = true;
            this.btn_detectLines.Click += new System.EventHandler(this.btn_detectLines_Click);
            // 
            // btn_detectRectangles
            // 
            resources.ApplyResources(this.btn_detectRectangles, "btn_detectRectangles");
            this.btn_detectRectangles.Name = "btn_detectRectangles";
            this.btn_detectRectangles.UseVisualStyleBackColor = true;
            this.btn_detectRectangles.Click += new System.EventHandler(this.btn_detectRectangles_Click);
            // 
            // btn_img2_denoise
            // 
            resources.ApplyResources(this.btn_img2_denoise, "btn_img2_denoise");
            this.btn_img2_denoise.Name = "btn_img2_denoise";
            this.btn_img2_denoise.UseVisualStyleBackColor = true;
            this.btn_img2_denoise.Click += new System.EventHandler(this.btn_img2_denoise_Click);
            // 
            // btn_img1_tobinary
            // 
            resources.ApplyResources(this.btn_img1_tobinary, "btn_img1_tobinary");
            this.btn_img1_tobinary.Name = "btn_img1_tobinary";
            this.btn_img1_tobinary.UseVisualStyleBackColor = true;
            this.btn_img1_tobinary.Click += new System.EventHandler(this.btn_img1_tobinary_Click);
            // 
            // btn_img2_tobinary
            // 
            resources.ApplyResources(this.btn_img2_tobinary, "btn_img2_tobinary");
            this.btn_img2_tobinary.Name = "btn_img2_tobinary";
            this.btn_img2_tobinary.UseVisualStyleBackColor = true;
            this.btn_img2_tobinary.Click += new System.EventHandler(this.btn_img2_tobinary_Click);
            // 
            // btn_img1_findColor
            // 
            resources.ApplyResources(this.btn_img1_findColor, "btn_img1_findColor");
            this.btn_img1_findColor.Name = "btn_img1_findColor";
            this.btn_img1_findColor.UseVisualStyleBackColor = true;
            this.btn_img1_findColor.Click += new System.EventHandler(this.btn_img1_findColor_Click);
            // 
            // tb_FindSMax
            // 
            resources.ApplyResources(this.tb_FindSMax, "tb_FindSMax");
            this.tb_FindSMax.Name = "tb_FindSMax";
            // 
            // tb_FindHMax
            // 
            resources.ApplyResources(this.tb_FindHMax, "tb_FindHMax");
            this.tb_FindHMax.Name = "tb_FindHMax";
            // 
            // tb_FindVMax
            // 
            resources.ApplyResources(this.tb_FindVMax, "tb_FindVMax");
            this.tb_FindVMax.Name = "tb_FindVMax";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_FindVMin
            // 
            resources.ApplyResources(this.tb_FindVMin, "tb_FindVMin");
            this.tb_FindVMin.Name = "tb_FindVMin";
            // 
            // tb_FindHMin
            // 
            resources.ApplyResources(this.tb_FindHMin, "tb_FindHMin");
            this.tb_FindHMin.Name = "tb_FindHMin";
            // 
            // tb_FindSMin
            // 
            resources.ApplyResources(this.tb_FindSMin, "tb_FindSMin");
            this.tb_FindSMin.Name = "tb_FindSMin";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btn_img1_copyimg3
            // 
            resources.ApplyResources(this.btn_img1_copyimg3, "btn_img1_copyimg3");
            this.btn_img1_copyimg3.Name = "btn_img1_copyimg3";
            this.btn_img1_copyimg3.UseVisualStyleBackColor = true;
            this.btn_img1_copyimg3.Click += new System.EventHandler(this.btn_img1_copyimg3_Click);
            // 
            // l_rectangles_count
            // 
            resources.ApplyResources(this.l_rectangles_count, "l_rectangles_count");
            this.l_rectangles_count.Name = "l_rectangles_count";
            // 
            // l_triangles_count
            // 
            resources.ApplyResources(this.l_triangles_count, "l_triangles_count");
            this.l_triangles_count.Name = "l_triangles_count";
            // 
            // l_lines_count
            // 
            resources.ApplyResources(this.l_lines_count, "l_lines_count");
            this.l_lines_count.Name = "l_lines_count";
            // 
            // l_circles_count
            // 
            resources.ApplyResources(this.l_circles_count, "l_circles_count");
            this.l_circles_count.Name = "l_circles_count";
            // 
            // img1_toBinary_border
            // 
            resources.ApplyResources(this.img1_toBinary_border, "img1_toBinary_border");
            this.img1_toBinary_border.Name = "img1_toBinary_border";
            // 
            // img2_toBinary_border
            // 
            resources.ApplyResources(this.img2_toBinary_border, "img2_toBinary_border");
            this.img2_toBinary_border.Name = "img2_toBinary_border";
            // 
            // btn_load_videos
            // 
            resources.ApplyResources(this.btn_load_videos, "btn_load_videos");
            this.btn_load_videos.Name = "btn_load_videos";
            this.btn_load_videos.UseVisualStyleBackColor = true;
            this.btn_load_videos.Click += new System.EventHandler(this.btn_load_videos_Click);
            // 
            // btn_convert_videos
            // 
            resources.ApplyResources(this.btn_convert_videos, "btn_convert_videos");
            this.btn_convert_videos.Name = "btn_convert_videos";
            this.btn_convert_videos.UseVisualStyleBackColor = true;
            this.btn_convert_videos.Click += new System.EventHandler(this.btn_convert_videos_Click);
            // 
            // btn_Haar_Detect
            // 
            resources.ApplyResources(this.btn_Haar_Detect, "btn_Haar_Detect");
            this.btn_Haar_Detect.Name = "btn_Haar_Detect";
            this.btn_Haar_Detect.UseVisualStyleBackColor = true;
            this.btn_Haar_Detect.Click += new System.EventHandler(this.btn_Haar_Detect_Click);
            // 
            // imgbox3
            // 
            resources.ApplyResources(this.imgbox3, "imgbox3");
            this.imgbox3.Name = "imgbox3";
            this.imgbox3.TabStop = false;
            // 
            // imgbox2
            // 
            resources.ApplyResources(this.imgbox2, "imgbox2");
            this.imgbox2.Name = "imgbox2";
            this.imgbox2.TabStop = false;
            // 
            // imgbox1
            // 
            resources.ApplyResources(this.imgbox1, "imgbox1");
            this.imgbox1.Name = "imgbox1";
            this.imgbox1.TabStop = false;
            // 
            // gb_haar_cascade
            // 
            this.gb_haar_cascade.Controls.Add(this.btn_Haar_Detect);
            resources.ApplyResources(this.gb_haar_cascade, "gb_haar_cascade");
            this.gb_haar_cascade.Name = "gb_haar_cascade";
            this.gb_haar_cascade.TabStop = false;
            // 
            // gb_ffmpeg
            // 
            this.gb_ffmpeg.Controls.Add(this.btn_load_videos);
            this.gb_ffmpeg.Controls.Add(this.btn_convert_videos);
            resources.ApplyResources(this.gb_ffmpeg, "gb_ffmpeg");
            this.gb_ffmpeg.Name = "gb_ffmpeg";
            this.gb_ffmpeg.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btn_img1_denoise
            // 
            resources.ApplyResources(this.btn_img1_denoise, "btn_img1_denoise");
            this.btn_img1_denoise.Name = "btn_img1_denoise";
            this.btn_img1_denoise.UseVisualStyleBackColor = true;
            this.btn_img1_denoise.Click += new System.EventHandler(this.btn_img1_denoise_Click);
            // 
            // btn_img1_CannyDetect
            // 
            resources.ApplyResources(this.btn_img1_CannyDetect, "btn_img1_CannyDetect");
            this.btn_img1_CannyDetect.Name = "btn_img1_CannyDetect";
            this.btn_img1_CannyDetect.UseVisualStyleBackColor = true;
            this.btn_img1_CannyDetect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_img1_makeSmooth
            // 
            resources.ApplyResources(this.btn_img1_makeSmooth, "btn_img1_makeSmooth");
            this.btn_img1_makeSmooth.Name = "btn_img1_makeSmooth";
            this.btn_img1_makeSmooth.UseVisualStyleBackColor = true;
            this.btn_img1_makeSmooth.Click += new System.EventHandler(this.btn_img1_makeSmooth_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_img1_resize
            // 
            resources.ApplyResources(this.btn_img1_resize, "btn_img1_resize");
            this.btn_img1_resize.Name = "btn_img1_resize";
            this.btn_img1_resize.UseVisualStyleBackColor = true;
            this.btn_img1_resize.Click += new System.EventHandler(this.btn_img1_resize_Click);
            // 
            // tb_resize_y
            // 
            resources.ApplyResources(this.tb_resize_y, "tb_resize_y");
            this.tb_resize_y.Name = "tb_resize_y";
            // 
            // tb_resize_x
            // 
            resources.ApplyResources(this.tb_resize_x, "tb_resize_x");
            this.tb_resize_x.Name = "tb_resize_x";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_img1_resize);
            this.Controls.Add(this.tb_resize_y);
            this.Controls.Add(this.tb_resize_x);
            this.Controls.Add(this.gb_haar_cascade);
            this.Controls.Add(this.img2_toBinary_border);
            this.Controls.Add(this.img1_toBinary_border);
            this.Controls.Add(this.l_circles_count);
            this.Controls.Add(this.l_lines_count);
            this.Controls.Add(this.l_triangles_count);
            this.Controls.Add(this.l_rectangles_count);
            this.Controls.Add(this.btn_img1_CannyDetect);
            this.Controls.Add(this.btn_img1_makeSmooth);
            this.Controls.Add(this.btn_img1_copyimg3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_FindVMin);
            this.Controls.Add(this.tb_FindHMin);
            this.Controls.Add(this.tb_FindSMin);
            this.Controls.Add(this.tb_FindVMax);
            this.Controls.Add(this.tb_FindHMax);
            this.Controls.Add(this.tb_FindSMax);
            this.Controls.Add(this.btn_img1_findColor);
            this.Controls.Add(this.btn_img2_tobinary);
            this.Controls.Add(this.btn_img1_tobinary);
            this.Controls.Add(this.btn_img2_denoise);
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
            this.Controls.Add(this.l_matchfound);
            this.Controls.Add(this.imgbox3);
            this.Controls.Add(this.imgbox2);
            this.Controls.Add(this.imgbox1);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.gb_ffmpeg);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox1)).EndInit();
            this.gb_haar_cascade.ResumeLayout(false);
            this.gb_ffmpeg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Label l_matchfound;
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
        private System.Windows.Forms.Button btn_img2_denoise;
        private System.Windows.Forms.Button btn_img1_tobinary;
        private System.Windows.Forms.Button btn_img2_tobinary;
        private System.Windows.Forms.Button btn_img1_findColor;
        private System.Windows.Forms.TextBox tb_FindSMax;
        private System.Windows.Forms.TextBox tb_FindHMax;
        private System.Windows.Forms.TextBox tb_FindVMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FindVMin;
        private System.Windows.Forms.TextBox tb_FindHMin;
        private System.Windows.Forms.TextBox tb_FindSMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_img1_copyimg3;
        private System.Windows.Forms.Label l_rectangles_count;
        private System.Windows.Forms.Label l_triangles_count;
        private System.Windows.Forms.Label l_lines_count;
        private System.Windows.Forms.Label l_circles_count;
        private System.Windows.Forms.TextBox img1_toBinary_border;
        private System.Windows.Forms.TextBox img2_toBinary_border;
        private System.Windows.Forms.Button btn_load_videos;
        private System.Windows.Forms.Button btn_convert_videos;
        private System.Windows.Forms.Button btn_Haar_Detect;
        private Emgu.CV.UI.ImageBox imgbox3;
        private Emgu.CV.UI.ImageBox imgbox2;
        private Emgu.CV.UI.ImageBox imgbox1;
        private System.Windows.Forms.GroupBox gb_haar_cascade;
        private System.Windows.Forms.GroupBox gb_ffmpeg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_img1_denoise;
        private System.Windows.Forms.Button btn_img1_CannyDetect;
        private System.Windows.Forms.Button btn_img1_makeSmooth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_img1_resize;
        private System.Windows.Forms.TextBox tb_resize_y;
        private System.Windows.Forms.TextBox tb_resize_x;
    }
}

