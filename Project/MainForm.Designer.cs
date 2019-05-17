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
            this.btn_convert_videos = new System.Windows.Forms.Button();
            this.btn_Haar_Detect = new System.Windows.Forms.Button();
            this.gb_haar_cascade = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lImagesToDetectCount = new System.Windows.Forms.Label();
            this.tb_detected_images_to_save_path = new System.Windows.Forms.TextBox();
            this.btn_detected_images_to_save_open = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lFoldersToDetectCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_images_to_detect_path = new System.Windows.Forms.TextBox();
            this.btn_images_to_detect_open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_cascade_path = new System.Windows.Forms.TextBox();
            this.btn_cascade_open = new System.Windows.Forms.Button();
            this.lCascadeLoaded = new System.Windows.Forms.Label();
            this.gb_ffmpeg = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_images_to_save_path = new System.Windows.Forms.TextBox();
            this.btn_images_to_save_open = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lVideos_count = new System.Windows.Forms.Label();
            this.tb_videos_path = new System.Windows.Forms.TextBox();
            this.btn_videos_open = new System.Windows.Forms.Button();
            this.btn_ROI_resize = new System.Windows.Forms.Button();
            this.btn_ROI_clahe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_network_acc = new System.Windows.Forms.TextBox();
            this.lAccuracy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lNetwork = new System.Windows.Forms.Label();
            this.btn_network_open = new System.Windows.Forms.Button();
            this.tb_network_path = new System.Windows.Forms.TextBox();
            this.lLearned = new System.Windows.Forms.Label();
            this.lClasses_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lImages = new System.Windows.Forms.Label();
            this.btn_imgs_open = new System.Windows.Forms.Button();
            this.tb_imgs_path = new System.Windows.Forms.TextBox();
            this.lLayers_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_test_imgs_path = new System.Windows.Forms.TextBox();
            this.tb_train_imgs_path = new System.Windows.Forms.TextBox();
            this.btn_test_imgs_open = new System.Windows.Forms.Button();
            this.btn_train_imgs_open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_learn_resize = new System.Windows.Forms.Button();
            this.lTest_count = new System.Windows.Forms.Label();
            this.lLearn_count = new System.Windows.Forms.Label();
            this.btn_CNN_save = new System.Windows.Forms.Button();
            this.btn_CNN_load = new System.Windows.Forms.Button();
            this.btn_CNN_recognize = new System.Windows.Forms.Button();
            this.btn_CNN_learn = new System.Windows.Forms.Button();
            this.btn_CNN_create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_resize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ROI_makeAll = new System.Windows.Forms.Button();
            this.btn_ROI_toGrey = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_autoCompleteAll = new System.Windows.Forms.Button();
            this.btn_subtitles_parse = new System.Windows.Forms.Button();
            this.gb_haar_cascade.SuspendLayout();
            this.gb_ffmpeg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.gb_haar_cascade.Controls.Add(this.label12);
            this.gb_haar_cascade.Controls.Add(this.lImagesToDetectCount);
            this.gb_haar_cascade.Controls.Add(this.tb_detected_images_to_save_path);
            this.gb_haar_cascade.Controls.Add(this.btn_detected_images_to_save_open);
            this.gb_haar_cascade.Controls.Add(this.label10);
            this.gb_haar_cascade.Controls.Add(this.lFoldersToDetectCount);
            this.gb_haar_cascade.Controls.Add(this.label13);
            this.gb_haar_cascade.Controls.Add(this.label14);
            this.gb_haar_cascade.Controls.Add(this.tb_images_to_detect_path);
            this.gb_haar_cascade.Controls.Add(this.btn_images_to_detect_open);
            this.gb_haar_cascade.Controls.Add(this.button1);
            this.gb_haar_cascade.Controls.Add(this.btn_Haar_Detect);
            this.gb_haar_cascade.Controls.Add(this.label11);
            this.gb_haar_cascade.Controls.Add(this.tb_cascade_path);
            this.gb_haar_cascade.Controls.Add(this.btn_cascade_open);
            this.gb_haar_cascade.Controls.Add(this.lCascadeLoaded);
            resources.ApplyResources(this.gb_haar_cascade, "gb_haar_cascade");
            this.gb_haar_cascade.Name = "gb_haar_cascade";
            this.gb_haar_cascade.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lImagesToDetectCount
            // 
            resources.ApplyResources(this.lImagesToDetectCount, "lImagesToDetectCount");
            this.lImagesToDetectCount.Name = "lImagesToDetectCount";
            // 
            // tb_detected_images_to_save_path
            // 
            resources.ApplyResources(this.tb_detected_images_to_save_path, "tb_detected_images_to_save_path");
            this.tb_detected_images_to_save_path.Name = "tb_detected_images_to_save_path";
            // 
            // btn_detected_images_to_save_open
            // 
            resources.ApplyResources(this.btn_detected_images_to_save_open, "btn_detected_images_to_save_open");
            this.btn_detected_images_to_save_open.Name = "btn_detected_images_to_save_open";
            this.btn_detected_images_to_save_open.UseVisualStyleBackColor = true;
            this.btn_detected_images_to_save_open.Click += new System.EventHandler(this.btn_detected_images_to_save_open_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lFoldersToDetectCount
            // 
            resources.ApplyResources(this.lFoldersToDetectCount, "lFoldersToDetectCount");
            this.lFoldersToDetectCount.Name = "lFoldersToDetectCount";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // tb_images_to_detect_path
            // 
            resources.ApplyResources(this.tb_images_to_detect_path, "tb_images_to_detect_path");
            this.tb_images_to_detect_path.Name = "tb_images_to_detect_path";
            // 
            // btn_images_to_detect_open
            // 
            resources.ApplyResources(this.btn_images_to_detect_open, "btn_images_to_detect_open");
            this.btn_images_to_detect_open.Name = "btn_images_to_detect_open";
            this.btn_images_to_detect_open.UseVisualStyleBackColor = true;
            this.btn_images_to_detect_open.Click += new System.EventHandler(this.btn_images_to_detect_open_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tb_cascade_path
            // 
            resources.ApplyResources(this.tb_cascade_path, "tb_cascade_path");
            this.tb_cascade_path.Name = "tb_cascade_path";
            // 
            // btn_cascade_open
            // 
            resources.ApplyResources(this.btn_cascade_open, "btn_cascade_open");
            this.btn_cascade_open.Name = "btn_cascade_open";
            this.btn_cascade_open.UseVisualStyleBackColor = true;
            this.btn_cascade_open.Click += new System.EventHandler(this.btn_cascade_open_Click);
            // 
            // lCascadeLoaded
            // 
            resources.ApplyResources(this.lCascadeLoaded, "lCascadeLoaded");
            this.lCascadeLoaded.Name = "lCascadeLoaded";
            // 
            // gb_ffmpeg
            // 
            this.gb_ffmpeg.Controls.Add(this.btn_subtitles_parse);
            this.gb_ffmpeg.Controls.Add(this.label9);
            this.gb_ffmpeg.Controls.Add(this.tb_images_to_save_path);
            this.gb_ffmpeg.Controls.Add(this.btn_images_to_save_open);
            this.gb_ffmpeg.Controls.Add(this.label7);
            this.gb_ffmpeg.Controls.Add(this.btn_convert_videos);
            this.gb_ffmpeg.Controls.Add(this.lVideos_count);
            this.gb_ffmpeg.Controls.Add(this.tb_videos_path);
            this.gb_ffmpeg.Controls.Add(this.btn_videos_open);
            resources.ApplyResources(this.gb_ffmpeg, "gb_ffmpeg");
            this.gb_ffmpeg.Name = "gb_ffmpeg";
            this.gb_ffmpeg.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tb_images_to_save_path
            // 
            resources.ApplyResources(this.tb_images_to_save_path, "tb_images_to_save_path");
            this.tb_images_to_save_path.Name = "tb_images_to_save_path";
            // 
            // btn_images_to_save_open
            // 
            resources.ApplyResources(this.btn_images_to_save_open, "btn_images_to_save_open");
            this.btn_images_to_save_open.Name = "btn_images_to_save_open";
            this.btn_images_to_save_open.UseVisualStyleBackColor = true;
            this.btn_images_to_save_open.Click += new System.EventHandler(this.btn_images_to_save_open_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lVideos_count
            // 
            resources.ApplyResources(this.lVideos_count, "lVideos_count");
            this.lVideos_count.Name = "lVideos_count";
            // 
            // tb_videos_path
            // 
            resources.ApplyResources(this.tb_videos_path, "tb_videos_path");
            this.tb_videos_path.Name = "tb_videos_path";
            // 
            // btn_videos_open
            // 
            resources.ApplyResources(this.btn_videos_open, "btn_videos_open");
            this.btn_videos_open.Name = "btn_videos_open";
            this.btn_videos_open.UseVisualStyleBackColor = true;
            this.btn_videos_open.Click += new System.EventHandler(this.btn_videos_open_Click);
            // 
            // btn_ROI_resize
            // 
            resources.ApplyResources(this.btn_ROI_resize, "btn_ROI_resize");
            this.btn_ROI_resize.Name = "btn_ROI_resize";
            this.btn_ROI_resize.UseVisualStyleBackColor = true;
            this.btn_ROI_resize.Click += new System.EventHandler(this.btn_img1_resize_Click);
            // 
            // btn_ROI_clahe
            // 
            resources.ApplyResources(this.btn_ROI_clahe, "btn_ROI_clahe");
            this.btn_ROI_clahe.Name = "btn_ROI_clahe";
            this.btn_ROI_clahe.UseVisualStyleBackColor = true;
            this.btn_ROI_clahe.Click += new System.EventHandler(this.btn_img1_clahe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_network_acc);
            this.groupBox1.Controls.Add(this.lAccuracy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lNetwork);
            this.groupBox1.Controls.Add(this.btn_network_open);
            this.groupBox1.Controls.Add(this.tb_network_path);
            this.groupBox1.Controls.Add(this.lLearned);
            this.groupBox1.Controls.Add(this.lClasses_count);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lImages);
            this.groupBox1.Controls.Add(this.btn_imgs_open);
            this.groupBox1.Controls.Add(this.tb_imgs_path);
            this.groupBox1.Controls.Add(this.lLayers_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_test_imgs_path);
            this.groupBox1.Controls.Add(this.tb_train_imgs_path);
            this.groupBox1.Controls.Add(this.btn_test_imgs_open);
            this.groupBox1.Controls.Add(this.btn_train_imgs_open);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_learn_resize);
            this.groupBox1.Controls.Add(this.lTest_count);
            this.groupBox1.Controls.Add(this.lLearn_count);
            this.groupBox1.Controls.Add(this.btn_CNN_save);
            this.groupBox1.Controls.Add(this.btn_CNN_load);
            this.groupBox1.Controls.Add(this.btn_CNN_recognize);
            this.groupBox1.Controls.Add(this.btn_CNN_learn);
            this.groupBox1.Controls.Add(this.btn_CNN_create);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tb_network_acc
            // 
            resources.ApplyResources(this.tb_network_acc, "tb_network_acc");
            this.tb_network_acc.Name = "tb_network_acc";
            this.tb_network_acc.TextChanged += new System.EventHandler(this.tb_network_acc_TextChanged);
            // 
            // lAccuracy
            // 
            resources.ApplyResources(this.lAccuracy, "lAccuracy");
            this.lAccuracy.Name = "lAccuracy";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lNetwork
            // 
            resources.ApplyResources(this.lNetwork, "lNetwork");
            this.lNetwork.Name = "lNetwork";
            // 
            // btn_network_open
            // 
            resources.ApplyResources(this.btn_network_open, "btn_network_open");
            this.btn_network_open.Name = "btn_network_open";
            this.btn_network_open.UseVisualStyleBackColor = true;
            this.btn_network_open.Click += new System.EventHandler(this.btn_network_open_Click);
            // 
            // tb_network_path
            // 
            resources.ApplyResources(this.tb_network_path, "tb_network_path");
            this.tb_network_path.Name = "tb_network_path";
            this.tb_network_path.TextChanged += new System.EventHandler(this.tb_network_path_TextChanged);
            // 
            // lLearned
            // 
            resources.ApplyResources(this.lLearned, "lLearned");
            this.lLearned.Name = "lLearned";
            // 
            // lClasses_count
            // 
            resources.ApplyResources(this.lClasses_count, "lClasses_count");
            this.lClasses_count.Name = "lClasses_count";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lImages
            // 
            resources.ApplyResources(this.lImages, "lImages");
            this.lImages.Name = "lImages";
            // 
            // btn_imgs_open
            // 
            resources.ApplyResources(this.btn_imgs_open, "btn_imgs_open");
            this.btn_imgs_open.Name = "btn_imgs_open";
            this.btn_imgs_open.UseVisualStyleBackColor = true;
            this.btn_imgs_open.Click += new System.EventHandler(this.btn_imgs_open_Click);
            // 
            // tb_imgs_path
            // 
            resources.ApplyResources(this.tb_imgs_path, "tb_imgs_path");
            this.tb_imgs_path.Name = "tb_imgs_path";
            // 
            // lLayers_count
            // 
            resources.ApplyResources(this.lLayers_count, "lLayers_count");
            this.lLayers_count.Name = "lLayers_count";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tb_test_imgs_path
            // 
            resources.ApplyResources(this.tb_test_imgs_path, "tb_test_imgs_path");
            this.tb_test_imgs_path.Name = "tb_test_imgs_path";
            this.tb_test_imgs_path.TextChanged += new System.EventHandler(this.tb_test_imgs_path_TextChanged);
            // 
            // tb_train_imgs_path
            // 
            resources.ApplyResources(this.tb_train_imgs_path, "tb_train_imgs_path");
            this.tb_train_imgs_path.Name = "tb_train_imgs_path";
            this.tb_train_imgs_path.TextChanged += new System.EventHandler(this.tb_train_imgs_path_TextChanged);
            // 
            // btn_test_imgs_open
            // 
            resources.ApplyResources(this.btn_test_imgs_open, "btn_test_imgs_open");
            this.btn_test_imgs_open.Name = "btn_test_imgs_open";
            this.btn_test_imgs_open.UseVisualStyleBackColor = true;
            this.btn_test_imgs_open.Click += new System.EventHandler(this.btn_test_imgs_open_Click);
            // 
            // btn_train_imgs_open
            // 
            resources.ApplyResources(this.btn_train_imgs_open, "btn_train_imgs_open");
            this.btn_train_imgs_open.Name = "btn_train_imgs_open";
            this.btn_train_imgs_open.UseVisualStyleBackColor = true;
            this.btn_train_imgs_open.Click += new System.EventHandler(this.btn_train_imgs_open_Click);
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
            // btn_learn_resize
            // 
            resources.ApplyResources(this.btn_learn_resize, "btn_learn_resize");
            this.btn_learn_resize.Name = "btn_learn_resize";
            this.btn_learn_resize.UseVisualStyleBackColor = true;
            this.btn_learn_resize.Click += new System.EventHandler(this.btn_learn_resize_Click);
            // 
            // lTest_count
            // 
            resources.ApplyResources(this.lTest_count, "lTest_count");
            this.lTest_count.Name = "lTest_count";
            // 
            // lLearn_count
            // 
            resources.ApplyResources(this.lLearn_count, "lLearn_count");
            this.lLearn_count.Name = "lLearn_count";
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
            this.groupBox3.Controls.Add(this.btn_resize);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btn_resize
            // 
            resources.ApplyResources(this.btn_resize, "btn_resize");
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ROI_makeAll);
            this.groupBox4.Controls.Add(this.btn_ROI_toGrey);
            this.groupBox4.Controls.Add(this.btn_ROI_clahe);
            this.groupBox4.Controls.Add(this.btn_ROI_resize);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btn_ROI_makeAll
            // 
            resources.ApplyResources(this.btn_ROI_makeAll, "btn_ROI_makeAll");
            this.btn_ROI_makeAll.Name = "btn_ROI_makeAll";
            this.btn_ROI_makeAll.UseVisualStyleBackColor = true;
            // 
            // btn_ROI_toGrey
            // 
            resources.ApplyResources(this.btn_ROI_toGrey, "btn_ROI_toGrey");
            this.btn_ROI_toGrey.Name = "btn_ROI_toGrey";
            this.btn_ROI_toGrey.UseVisualStyleBackColor = true;
            this.btn_ROI_toGrey.Click += new System.EventHandler(this.btn_toGrey_Click);
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
            // btn_subtitles_parse
            // 
            resources.ApplyResources(this.btn_subtitles_parse, "btn_subtitles_parse");
            this.btn_subtitles_parse.Name = "btn_subtitles_parse";
            this.btn_subtitles_parse.UseVisualStyleBackColor = true;
            this.btn_subtitles_parse.Click += new System.EventHandler(this.btn_subtitles_parse_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_autoCompleteAll);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_haar_cascade);
            this.Controls.Add(this.gb_ffmpeg);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainForm";
            this.gb_haar_cascade.ResumeLayout(false);
            this.gb_haar_cascade.PerformLayout();
            this.gb_ffmpeg.ResumeLayout(false);
            this.gb_ffmpeg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_convert_videos;
        private System.Windows.Forms.Button btn_Haar_Detect;
        private System.Windows.Forms.GroupBox gb_haar_cascade;
        private System.Windows.Forms.GroupBox gb_ffmpeg;
        private System.Windows.Forms.Button btn_ROI_resize;
        private System.Windows.Forms.Button btn_ROI_clahe;
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
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_autoCompleteAll;
        private System.Windows.Forms.Label lTest_count;
        private System.Windows.Forms.Label lLearn_count;
        private System.Windows.Forms.Button btn_learn_resize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_test_imgs_open;
        private System.Windows.Forms.Button btn_train_imgs_open;
        private System.Windows.Forms.TextBox tb_train_imgs_path;
        private System.Windows.Forms.TextBox tb_test_imgs_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lLayers_count;
        private System.Windows.Forms.Button btn_ROI_toGrey;
        private System.Windows.Forms.Button btn_imgs_open;
        private System.Windows.Forms.TextBox tb_imgs_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lImages;
        private System.Windows.Forms.Label lClasses_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lLearned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lNetwork;
        private System.Windows.Forms.Button btn_network_open;
        private System.Windows.Forms.TextBox tb_network_path;
        private System.Windows.Forms.Label lAccuracy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lVideos_count;
        private System.Windows.Forms.TextBox tb_videos_path;
        private System.Windows.Forms.Button btn_videos_open;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_images_to_save_path;
        private System.Windows.Forms.Button btn_images_to_save_open;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_cascade_path;
        private System.Windows.Forms.Button btn_cascade_open;
        private System.Windows.Forms.Label lCascadeLoaded;
        private System.Windows.Forms.Button btn_ROI_makeAll;
        private System.Windows.Forms.Label lFoldersToDetectCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_images_to_detect_path;
        private System.Windows.Forms.Button btn_images_to_detect_open;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lImagesToDetectCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_detected_images_to_save_path;
        private System.Windows.Forms.Button btn_detected_images_to_save_open;
        private System.Windows.Forms.TextBox tb_network_acc;
        private System.Windows.Forms.Button btn_subtitles_parse;
    }
}

