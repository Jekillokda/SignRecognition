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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_load_videos = new System.Windows.Forms.Button();
            this.btn_convert_videos = new System.Windows.Forms.Button();
            this.btn_Haar_Detect = new System.Windows.Forms.Button();
            this.gb_haar_cascade = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_ffmpeg = new System.Windows.Forms.GroupBox();
            this.btn_img1_resize = new System.Windows.Forms.Button();
            this.btn_img1_clahe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTest = new System.Windows.Forms.Label();
            this.lLearn = new System.Windows.Forms.Label();
            this.btn_load_test = new System.Windows.Forms.Button();
            this.btn_load_learn = new System.Windows.Forms.Button();
            this.btn_CNN_save = new System.Windows.Forms.Button();
            this.btn_CNN_load = new System.Windows.Forms.Button();
            this.btn_CNN_recognize = new System.Windows.Forms.Button();
            this.btn_CNN_learn = new System.Windows.Forms.Button();
            this.btn_CNN_create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_autoCompleteAll = new System.Windows.Forms.Button();
            this.gb_haar_cascade.SuspendLayout();
            this.gb_ffmpeg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            // gb_haar_cascade
            // 
            this.gb_haar_cascade.Controls.Add(this.button1);
            this.gb_haar_cascade.Controls.Add(this.btn_Haar_Detect);
            resources.ApplyResources(this.gb_haar_cascade, "gb_haar_cascade");
            this.gb_haar_cascade.Name = "gb_haar_cascade";
            this.gb_haar_cascade.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gb_ffmpeg
            // 
            this.gb_ffmpeg.Controls.Add(this.btn_load_videos);
            this.gb_ffmpeg.Controls.Add(this.btn_convert_videos);
            resources.ApplyResources(this.gb_ffmpeg, "gb_ffmpeg");
            this.gb_ffmpeg.Name = "gb_ffmpeg";
            this.gb_ffmpeg.TabStop = false;
            // 
            // btn_img1_resize
            // 
            resources.ApplyResources(this.btn_img1_resize, "btn_img1_resize");
            this.btn_img1_resize.Name = "btn_img1_resize";
            this.btn_img1_resize.UseVisualStyleBackColor = true;
            this.btn_img1_resize.Click += new System.EventHandler(this.btn_img1_resize_Click);
            // 
            // btn_img1_clahe
            // 
            resources.ApplyResources(this.btn_img1_clahe, "btn_img1_clahe");
            this.btn_img1_clahe.Name = "btn_img1_clahe";
            this.btn_img1_clahe.UseVisualStyleBackColor = true;
            this.btn_img1_clahe.Click += new System.EventHandler(this.btn_img1_clahe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lTest);
            this.groupBox1.Controls.Add(this.lLearn);
            this.groupBox1.Controls.Add(this.btn_load_test);
            this.groupBox1.Controls.Add(this.btn_load_learn);
            this.groupBox1.Controls.Add(this.btn_CNN_save);
            this.groupBox1.Controls.Add(this.btn_CNN_load);
            this.groupBox1.Controls.Add(this.btn_CNN_recognize);
            this.groupBox1.Controls.Add(this.btn_CNN_learn);
            this.groupBox1.Controls.Add(this.btn_CNN_create);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lTest
            // 
            resources.ApplyResources(this.lTest, "lTest");
            this.lTest.Name = "lTest";
            // 
            // lLearn
            // 
            resources.ApplyResources(this.lLearn, "lLearn");
            this.lLearn.Name = "lLearn";
            // 
            // btn_load_test
            // 
            resources.ApplyResources(this.btn_load_test, "btn_load_test");
            this.btn_load_test.Name = "btn_load_test";
            this.btn_load_test.UseVisualStyleBackColor = true;
            this.btn_load_test.Click += new System.EventHandler(this.btn_load_test_Click);
            // 
            // btn_load_learn
            // 
            resources.ApplyResources(this.btn_load_learn, "btn_load_learn");
            this.btn_load_learn.Name = "btn_load_learn";
            this.btn_load_learn.UseVisualStyleBackColor = true;
            this.btn_load_learn.Click += new System.EventHandler(this.btn_load_learn_Click);
            // 
            // btn_CNN_save
            // 
            resources.ApplyResources(this.btn_CNN_save, "btn_CNN_save");
            this.btn_CNN_save.Name = "btn_CNN_save";
            this.btn_CNN_save.UseVisualStyleBackColor = true;
            this.btn_CNN_save.Click += new System.EventHandler(this.btn_CNN_save_Click);
            // 
            // btn_CNN_load
            // 
            resources.ApplyResources(this.btn_CNN_load, "btn_CNN_load");
            this.btn_CNN_load.Name = "btn_CNN_load";
            this.btn_CNN_load.UseVisualStyleBackColor = true;
            this.btn_CNN_load.Click += new System.EventHandler(this.btn_CNN_load_Click);
            // 
            // btn_CNN_recognize
            // 
            resources.ApplyResources(this.btn_CNN_recognize, "btn_CNN_recognize");
            this.btn_CNN_recognize.Name = "btn_CNN_recognize";
            this.btn_CNN_recognize.UseVisualStyleBackColor = true;
            this.btn_CNN_recognize.Click += new System.EventHandler(this.btn_CNN_recognize_Click);
            // 
            // btn_CNN_learn
            // 
            resources.ApplyResources(this.btn_CNN_learn, "btn_CNN_learn");
            this.btn_CNN_learn.Name = "btn_CNN_learn";
            this.btn_CNN_learn.UseVisualStyleBackColor = true;
            this.btn_CNN_learn.Click += new System.EventHandler(this.btn_CNN_learn_Click);
            // 
            // btn_CNN_create
            // 
            resources.ApplyResources(this.btn_CNN_create, "btn_CNN_create");
            this.btn_CNN_create.Name = "btn_CNN_create";
            this.btn_CNN_create.UseVisualStyleBackColor = true;
            this.btn_CNN_create.Click += new System.EventHandler(this.btn_CNN_create_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_img1_clahe);
            this.groupBox4.Controls.Add(this.btn_img1_resize);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btn_autoCompleteAll
            // 
            resources.ApplyResources(this.btn_autoCompleteAll, "btn_autoCompleteAll");
            this.btn_autoCompleteAll.Name = "btn_autoCompleteAll";
            this.btn_autoCompleteAll.UseVisualStyleBackColor = true;
            this.btn_autoCompleteAll.Click += new System.EventHandler(this.btn_autoCompleteAll_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_autoCompleteAll);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_haar_cascade);
            this.Controls.Add(this.gb_ffmpeg);
            this.Name = "MainForm";
            this.gb_haar_cascade.ResumeLayout(false);
            this.gb_ffmpeg.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_load_videos;
        private System.Windows.Forms.Button btn_convert_videos;
        private System.Windows.Forms.Button btn_Haar_Detect;
        private System.Windows.Forms.GroupBox gb_haar_cascade;
        private System.Windows.Forms.GroupBox gb_ffmpeg;
        private System.Windows.Forms.Button btn_img1_resize;
        private System.Windows.Forms.Button btn_img1_clahe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CNN_save;
        private System.Windows.Forms.Button btn_CNN_load;
        private System.Windows.Forms.Button btn_CNN_recognize;
        private System.Windows.Forms.Button btn_CNN_learn;
        private System.Windows.Forms.Button btn_CNN_create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_autoCompleteAll;
        private System.Windows.Forms.Button btn_load_test;
        private System.Windows.Forms.Button btn_load_learn;
        private System.Windows.Forms.Label lTest;
        private System.Windows.Forms.Label lLearn;
    }
}

