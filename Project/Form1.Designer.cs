﻿namespace Project
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
            this.btn_img2_denoise = new System.Windows.Forms.Button();
            this.btn_img1_tobinary = new System.Windows.Forms.Button();
            this.btn_img2_tobinary = new System.Windows.Forms.Button();
            this.btn_img1_findColor = new System.Windows.Forms.Button();
            this.tb_FindSMax = new System.Windows.Forms.TextBox();
            this.tb_FindHMax = new System.Windows.Forms.TextBox();
            this.tb_FindVMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FindVMin = new System.Windows.Forms.TextBox();
            this.tb_FindHMin = new System.Windows.Forms.TextBox();
            this.tb_FindSMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_img1_copyimg3 = new System.Windows.Forms.Button();
            this.btn_img1_makeSmooth = new System.Windows.Forms.Button();
            this.btn_img1_CannyDetect = new System.Windows.Forms.Button();
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
            this.l_matchfound.Location = new System.Drawing.Point(896, 418);
            this.l_matchfound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_matchfound.Name = "l_matchfound";
            this.l_matchfound.Size = new System.Drawing.Size(52, 13);
            this.l_matchfound.TabIndex = 5;
            this.l_matchfound.Text = "not found";
            // 
            // l_matchtime
            // 
            this.l_matchtime.AutoSize = true;
            this.l_matchtime.Location = new System.Drawing.Point(1188, 418);
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
            this.btn_detectCircles.Location = new System.Drawing.Point(1063, 468);
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
            this.btn_detectTriangles.Location = new System.Drawing.Point(899, 468);
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
            this.btn_detectLines.Location = new System.Drawing.Point(817, 468);
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
            this.btn_detectRectangles.Location = new System.Drawing.Point(981, 468);
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
            this.btn_img1_denoise.Location = new System.Drawing.Point(90, 418);
            this.btn_img1_denoise.Name = "btn_img1_denoise";
            this.btn_img1_denoise.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_denoise.TabIndex = 20;
            this.btn_img1_denoise.Text = "denoise";
            this.btn_img1_denoise.UseVisualStyleBackColor = true;
            this.btn_img1_denoise.Click += new System.EventHandler(this.btn_img1_denoise_Click);
            // 
            // btn_img2_denoise
            // 
            this.btn_img2_denoise.Location = new System.Drawing.Point(494, 418);
            this.btn_img2_denoise.Name = "btn_img2_denoise";
            this.btn_img2_denoise.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_denoise.TabIndex = 21;
            this.btn_img2_denoise.Text = "denoise";
            this.btn_img2_denoise.UseVisualStyleBackColor = true;
            this.btn_img2_denoise.Click += new System.EventHandler(this.btn_img2_denoise_Click);
            // 
            // btn_img1_tobinary
            // 
            this.btn_img1_tobinary.Location = new System.Drawing.Point(9, 531);
            this.btn_img1_tobinary.Name = "btn_img1_tobinary";
            this.btn_img1_tobinary.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_tobinary.TabIndex = 22;
            this.btn_img1_tobinary.Text = "toBinary";
            this.btn_img1_tobinary.UseVisualStyleBackColor = true;
            this.btn_img1_tobinary.Click += new System.EventHandler(this.btn_img1_tobinary_Click);
            // 
            // btn_img2_tobinary
            // 
            this.btn_img2_tobinary.Location = new System.Drawing.Point(413, 531);
            this.btn_img2_tobinary.Name = "btn_img2_tobinary";
            this.btn_img2_tobinary.Size = new System.Drawing.Size(75, 23);
            this.btn_img2_tobinary.TabIndex = 23;
            this.btn_img2_tobinary.Text = "toBinary";
            this.btn_img2_tobinary.UseVisualStyleBackColor = true;
            this.btn_img2_tobinary.Click += new System.EventHandler(this.btn_img2_tobinary_Click);
            // 
            // btn_img1_findColor
            // 
            this.btn_img1_findColor.Location = new System.Drawing.Point(178, 502);
            this.btn_img1_findColor.Name = "btn_img1_findColor";
            this.btn_img1_findColor.Size = new System.Drawing.Size(75, 23);
            this.btn_img1_findColor.TabIndex = 24;
            this.btn_img1_findColor.Text = "FindColor";
            this.btn_img1_findColor.UseVisualStyleBackColor = true;
            this.btn_img1_findColor.Click += new System.EventHandler(this.btn_img1_findColor_Click);
            // 
            // tb_FindSMax
            // 
            this.tb_FindSMax.Location = new System.Drawing.Point(278, 557);
            this.tb_FindSMax.Name = "tb_FindSMax";
            this.tb_FindSMax.Size = new System.Drawing.Size(100, 20);
            this.tb_FindSMax.TabIndex = 25;
            this.tb_FindSMax.Text = "255";
            // 
            // tb_FindHMax
            // 
            this.tb_FindHMax.Location = new System.Drawing.Point(278, 531);
            this.tb_FindHMax.Name = "tb_FindHMax";
            this.tb_FindHMax.Size = new System.Drawing.Size(100, 20);
            this.tb_FindHMax.TabIndex = 26;
            this.tb_FindHMax.Text = "255";
            // 
            // tb_FindVMax
            // 
            this.tb_FindVMax.Location = new System.Drawing.Point(278, 583);
            this.tb_FindVMax.Name = "tb_FindVMax";
            this.tb_FindVMax.Size = new System.Drawing.Size(100, 20);
            this.tb_FindVMax.TabIndex = 27;
            this.tb_FindVMax.Text = "255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "H";
            // 
            // tb_FindVMin
            // 
            this.tb_FindVMin.Location = new System.Drawing.Point(153, 583);
            this.tb_FindVMin.Name = "tb_FindVMin";
            this.tb_FindVMin.Size = new System.Drawing.Size(100, 20);
            this.tb_FindVMin.TabIndex = 33;
            this.tb_FindVMin.Text = "230";
            // 
            // tb_FindHMin
            // 
            this.tb_FindHMin.Location = new System.Drawing.Point(153, 531);
            this.tb_FindHMin.Name = "tb_FindHMin";
            this.tb_FindHMin.Size = new System.Drawing.Size(100, 20);
            this.tb_FindHMin.TabIndex = 32;
            this.tb_FindHMin.Text = "0";
            // 
            // tb_FindSMin
            // 
            this.tb_FindSMin.Location = new System.Drawing.Point(153, 557);
            this.tb_FindSMin.Name = "tb_FindSMin";
            this.tb_FindSMin.Size = new System.Drawing.Size(100, 20);
            this.tb_FindSMin.TabIndex = 31;
            this.tb_FindSMin.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Max";
            // 
            // btn_img1_copyimg3
            // 
            this.btn_img1_copyimg3.Location = new System.Drawing.Point(9, 560);
            this.btn_img1_copyimg3.Name = "btn_img1_copyimg3";
            this.btn_img1_copyimg3.Size = new System.Drawing.Size(75, 39);
            this.btn_img1_copyimg3.TabIndex = 42;
            this.btn_img1_copyimg3.Text = "Copy img from img3";
            this.btn_img1_copyimg3.UseVisualStyleBackColor = true;
            this.btn_img1_copyimg3.Click += new System.EventHandler(this.btn_img1_copyimg3_Click);
            // 
            // btn_img1_makeSmooth
            // 
            this.btn_img1_makeSmooth.Location = new System.Drawing.Point(171, 416);
            this.btn_img1_makeSmooth.Name = "btn_img1_makeSmooth";
            this.btn_img1_makeSmooth.Size = new System.Drawing.Size(75, 42);
            this.btn_img1_makeSmooth.TabIndex = 43;
            this.btn_img1_makeSmooth.Text = "make Smooth";
            this.btn_img1_makeSmooth.UseVisualStyleBackColor = true;
            this.btn_img1_makeSmooth.Click += new System.EventHandler(this.btn_img1_makeSmooth_Click);
            // 
            // btn_img1_CannyDetect
            // 
            this.btn_img1_CannyDetect.Location = new System.Drawing.Point(252, 416);
            this.btn_img1_CannyDetect.Name = "btn_img1_CannyDetect";
            this.btn_img1_CannyDetect.Size = new System.Drawing.Size(75, 42);
            this.btn_img1_CannyDetect.TabIndex = 44;
            this.btn_img1_CannyDetect.Text = "Canny Detect";
            this.btn_img1_CannyDetect.UseVisualStyleBackColor = true;
            this.btn_img1_CannyDetect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 611);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btn_img2_denoise;
        private System.Windows.Forms.Button btn_img1_tobinary;
        private System.Windows.Forms.Button btn_img2_tobinary;
        private System.Windows.Forms.Button btn_img1_findColor;
        private System.Windows.Forms.TextBox tb_FindSMax;
        private System.Windows.Forms.TextBox tb_FindHMax;
        private System.Windows.Forms.TextBox tb_FindVMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FindVMin;
        private System.Windows.Forms.TextBox tb_FindHMin;
        private System.Windows.Forms.TextBox tb_FindSMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_img1_copyimg3;
        private System.Windows.Forms.Button btn_img1_makeSmooth;
        private System.Windows.Forms.Button btn_img1_CannyDetect;
    }
}

