using ConvNetSharp.Volume;
using ConvNetSharp.Volume.Double;
using Emgu.CV;
using Emgu.CV.Structure;
using Project.ConvNeuronNet;
using Project.DetectionHaar;
using Project.OpenFileDialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        VideoFolder vidFolder;
        ImageFolder trainFolder;
        ImageFolder testFolder;
        ImageFolder imageFolder;
        List<string> folders_to_detect= new List<string>();
        string path_to_cutted_images;
        string path_to_save_detected_images;
        string path_to_detect_images;
        int images_count_to_detect;
        string path_to_cascade;
        int aim;
        CNN network; 

        public MainForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.last_path_to_videos != "")
            {
                vidFolder = new VideoFolder();
                vidFolder.Load(Properties.Settings.Default.last_path_to_videos);
                lVideos_count.Text = "Found " + vidFolder.getCount();               
                tb_videos_path.Text = vidFolder.getPath();   
            }

            if (Properties.Settings.Default.last_path_for_images_to_save != "")
            {
                var path = Properties.Settings.Default.last_path_for_images_to_save;
                tb_images_to_save_path.Text = path;
            }

            if ((Properties.Settings.Default.last_path_for_images_to_detect != "")&&(Directory.Exists(Properties.Settings.Default.last_path_for_images_to_detect)))
            {
                path_to_detect_images = Properties.Settings.Default.last_path_for_images_to_detect;
                tb_images_to_detect_path.Text = path_to_detect_images;
                folders_to_detect.Add(path_to_detect_images);
                foreach (string s in Directory.GetDirectories(path_to_detect_images))
                folders_to_detect.Add(s);
                
                lFoldersToDetectCount.Text = folders_to_detect.Count.ToString();
                images_count_to_detect = 0;
                foreach (string p in folders_to_detect)
                {
                    string[] dirs = Directory.GetFiles(p, "*.jpg");
                    images_count_to_detect += dirs.Length;
                }
                lImagesToDetectCount.Text = images_count_to_detect.ToString();
            }

            if (Properties.Settings.Default.last_path_to_cascade != "")
            {
                path_to_cascade = Properties.Settings.Default.last_path_to_cascade;
                if (File.Exists(path_to_cascade))
                {
                    lCascadeLoaded.Text = "Loaded";
                    tb_cascade_path.Text = path_to_cascade;
                }
                else
                {
                    lCascadeLoaded.Text = "Not loaded";
                }
            }

            if (Properties.Settings.Default.last_path_for_detected_images_to_save != "")
            {
                var path = Properties.Settings.Default.last_path_for_detected_images_to_save;
                tb_detected_images_to_save_path.Text = path;
            }

            if (Properties.Settings.Default.last_path_to_learn_pictures != "")
            {
                trainFolder = new ImageFolder();
                trainFolder.Load(Properties.Settings.Default.last_path_to_learn_pictures);
                lLearn_count.Text = "Found " + trainFolder.GetCount();
                tb_train_imgs_path.Text = trainFolder.GetPath();
            }

            if (Properties.Settings.Default.last_path_to_test_pictures != "")
            {
                testFolder = new ImageFolder();
                testFolder.Load(Properties.Settings.Default.last_path_to_test_pictures);
                lTest_count.Text = "Found " + testFolder.GetCount();
                tb_test_imgs_path.Text = testFolder.GetPath();
            }

            if (Properties.Settings.Default.last_path_to_test_pictures != "")
            {
                imageFolder = new ImageFolder();
                imageFolder.Load(Properties.Settings.Default.last_path_to_pictures);
                lImages.Text = "Found " + imageFolder.GetCount();
                tb_imgs_path.Text = imageFolder.GetPath();
            }

            if (Properties.Settings.Default.last_path_to_network != "")
            {
                lNetwork.Text = "exists";
                var path = Properties.Settings.Default.last_path_to_network;
                tb_network_path.Text = path;
                network = new CNN(path);
            }
            else
            {
                network = new CNN("");
            }

            if((tb_videos_path.Text!= "") && (lVideos_count.Text != ""))
            {
                btn_convert_videos.Visible = true;
            }
            aim = Int32.Parse(tb_network_acc.Text);
            //Properties.Settings.Default.is_opened_first_time = true;
            /*if (Properties.Settings.Default.is_opened_first_time)
            {
                MessageBox.Show("Hello new User");
                Properties.Settings.Default.is_opened_first_time = false;
                Properties.Settings.Default.Save();
            }*/
        }

        private void btn_videos_open_Click(object sender, EventArgs e)
        {
            var folder = OpenVideoFolderFileDialog.openFolder();
            if (folder.getPath() != "")
            {
                vidFolder = folder;
                if (vidFolder.getCount() > 0)
                {
                    lVideos_count.Text = "Found " + vidFolder.getCount() + " videos";

                    tb_videos_path.Text = vidFolder.getPath();
                    Properties.Settings.Default.last_path_to_videos = vidFolder.getPath();
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Upgrade();
                }
                else
                    lVideos_count.Text = "Videos not found";
            }
        }

        private void btn_images_to_save_open_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                SelectedPath = tb_images_to_save_path.Text
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path_to_cutted_images = dialog.SelectedPath;
                tb_images_to_save_path.Text = path_to_cutted_images;
            }
            Properties.Settings.Default.last_path_for_images_to_save = path_to_cutted_images;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btn_convert_videos_Click(object sender, EventArgs e)
        {
            if (tb_videos_path.Text == "")
            {
                MessageBox.Show("Path to videos is empty");
                return;
            }
            if (tb_images_to_save_path.Text == "")
            {
                MessageBox.Show("Please choose folder for image save");
                return;
            }
            MessageBox.Show("Please wait till the end of conversion");
            foreach (string videopath in vidFolder.videoArray)
            {
                    //int fps = 5;
                    FFMPEGConverter conv = new FFMPEGConverter(videopath,tb_images_to_save_path.Text);
                bool rewrite = false;
                    if (conv.ConvertAll(rewrite) == false)
                {
                    MessageBox.Show("Something went wrong with"+ videopath);
                }
            }
            lFoldersToDetectCount.Text = folders_to_detect.Count.ToString();
            images_count_to_detect = 0;
            foreach (string p in folders_to_detect)
            {
                string[] dirs = Directory.GetFiles(p, "*.jpg");
                images_count_to_detect += dirs.Length;
            }
            lImagesToDetectCount.Text = images_count_to_detect.ToString();
        }

        private void btn_cascade_open_Click(object sender, EventArgs e)
        { 
            string path = OpenXmlFileDialog.openFile();
            if(path != "")
            {
                path_to_cascade = path;
            }
            
            tb_cascade_path.Text = path_to_cascade;
            if (File.Exists(path_to_cascade))
            {
                lCascadeLoaded.Text = "Loaded";
            }
            else
            {
                lCascadeLoaded.Text = "Not Exists";
            }
            Properties.Settings.Default.last_path_to_cascade = path_to_cascade;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btn_images_to_detect_open_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                SelectedPath = tb_images_to_detect_path.Text
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path_to_detect_images = dialog.SelectedPath;
                tb_images_to_detect_path.Text = path_to_detect_images;
                folders_to_detect.Clear();
                folders_to_detect.Add(path_to_detect_images);
                foreach (string s in Directory.GetDirectories(path_to_detect_images))
                    folders_to_detect.Add(s);
                lFoldersToDetectCount.Text = folders_to_detect.Count.ToString();
                int count = 0;
                foreach( string p in folders_to_detect)
                {
                    string[] dirs = Directory.GetFiles(p, "*.jpg");
                    count += dirs.Length;
                }
                lImagesToDetectCount.Text = count.ToString();
                
            }
            Properties.Settings.Default.last_path_for_images_to_detect = path_to_detect_images;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btn_Haar_Detect_Click(object sender, EventArgs e)
        {
            string[] cascades = new string[1];
            cascades[0] = tb_cascade_path.Text;
            foreach (string path in folders_to_detect)
            {
                DetectFolder.DetectAll(path, cascades, tb_detected_images_to_save_path.Text);
            }
        }

        private void btn_detected_images_to_save_open_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                SelectedPath = tb_detected_images_to_save_path.Text
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path_to_save_detected_images = dialog.SelectedPath;
                tb_detected_images_to_save_path.Text = path_to_save_detected_images;
            }
            Properties.Settings.Default.last_path_for_detected_images_to_save = path_to_save_detected_images;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btn_img1_resize_Click(object sender, EventArgs e)
        {
            //    img = ImgOps.InterpolationResize(img, 50, 50);
            //    {
            //        int w = Convert.ToInt32(tb_resize_x.Text);
            //        int h = Convert.ToInt32(tb_resize_y.Text);
            //        imgbox3.Image = ImgOps.InterpolationResize(new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat, w, h);
            //    }
            //    else
            //    {
            MessageBox.Show("Plz load img");
        //    }
        }

        private void btn_img1_clahe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plz load img");
            //imgbox1.Image = ImgOps.ContrastAlignment(new Image<Gray, byte>(imgbox1.Image.Bitmap));
        }

        private void btn_CNN_create_Click(object sender, EventArgs e)
        {
            int c = network.CreateCNN(32, 32, 1, 11);
            lLayers_count.Text = c.ToString();
            lClasses_count.Text = network.GetClassesCount().ToString();
        }

        private void tb_network_acc_TextChanged(object sender, EventArgs e)
        {
            aim = Int32.Parse(tb_network_acc.Text);
        }

        private void btn_CNN_learn_Click(object sender, EventArgs e)
        {
            if (network.IsLearned())
            {
                lLearned.Text = "Learned";
                return;
            }
            if ((trainFolder != null) && (testFolder != null))
            {
                double d = network.TeachCNN(trainFolder.GetPath(), testFolder.GetPath(), aim, 0.02, 50, 0.9);
                if (d == -1)
                    MessageBox.Show("Please add layers and try again");
                else
                    lAccuracy.Text = d.ToString();
                if (network.IsLearned())
                    lLearned.Text = "Learned";
            }
            
            
        }

        private void btn_CNN_recognize_Click(object sender, EventArgs e)
        {
            if (tb_imgs_path.Text != "")
            {
                if (!File.Exists(tb_imgs_path.Text))
                {
                    MessageBox.Show("File not exists");
                    return;
                }
                
                Mat im = new Mat(tb_imgs_path.Text);
                if (im.NumberOfChannels != 1)
                {
                    im = ImgOps.RGBtoGrey(im).Mat;
                }
                
                if (im.Size!= new Size(32, 32))
                {
                    im = new Image<Gray, byte>(ImgOps.InterpolationResize(im,32,32).Bitmap).Mat;
                }
                Image<Gray, byte> img = new Image<Gray, byte>(im.Bitmap);
                string sign = network.Recognize(img.Bytes);
                lLayers_count.Text = network.GetLayersCount().ToString();
                MessageBox.Show(sign);
            }
            else
            {
                MessageBox.Show("Path to image is empty");
            }
        }

        private void btn_CNN_load_Click(object sender, EventArgs e)
        {
            int n = network.LoadCNN(tb_network_path.Text);
            if (n == -1)
            {
                MessageBox.Show("Input network file is not correct");
                return;
            }
            lLayers_count.Text = n.ToString();
            lClasses_count.Text = network.GetClassesCount().ToString();
            if (network.IsLearned())
                lLearned.Text = "Learned";
            var p = Path.GetFileName(tb_network_path.Text);
            p = p.Substring(p.IndexOf('_') + 1, p.IndexOf('.') - p.IndexOf('_') - 1);
            lAccuracy.Text = p;
        }

        private void btn_CNN_save_Click(object sender, EventArgs e)
        {
            var path = network.SaveCNN(tb_network_path.Text);
            if (path != "")
            {
                Console.WriteLine(path);
                tb_network_path.Text = path;
                Properties.Settings.Default.last_path_to_network = path;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
            else
                MessageBox.Show("Error");
        }

        private void btn_autoCompleteAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_learn_resize_Click(object sender, EventArgs e)
        {
            foreach (string imgpath in trainFolder.GetAllImgs())
            {
                Mat tmp = new Mat(imgpath);
                tmp = ImgOps.InterpolationResize(tmp, 32, 32);
                tmp = ImgOps.RGBtoGrey(tmp).Mat;
            }
        }

        private void btn_train_imgs_open_Click(object sender, EventArgs e)
        {
            var folder = OpenPictureFolderFileDialog.openFolder();
            if (folder.GetPath() != "")
            {
                trainFolder = folder;
                if (trainFolder.GetCount() > 0)
                {
                lLearn_count.Text = "Found " + trainFolder.GetCount();
                tb_train_imgs_path.Text = trainFolder.GetPath();
                Properties.Settings.Default.last_path_to_learn_pictures = trainFolder.GetPath();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                }
            else
                lLearn_count.Text = "Not found";
            }
        }

        private void btn_test_imgs_open_Click(object sender, EventArgs e)
        {
            var folder = OpenPictureFolderFileDialog.openFolder();
            if (folder.GetPath() != "")
            {
                testFolder = folder;
                if (testFolder.GetCount() > 0)
                {
                    lTest_count.Text = "Found " + testFolder.GetCount();
                    tb_test_imgs_path.Text = testFolder.GetPath();
                    Properties.Settings.Default.last_path_to_test_pictures = testFolder.GetPath();
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Upgrade();
                }
                else
                    lTest_count.Text = "Not found";
            }
            
        }

        private void tb_train_imgs_path_TextChanged(object sender, EventArgs e)
        {
            trainFolder.SetPath(tb_train_imgs_path.Text);
            trainFolder.Load(tb_train_imgs_path.Text);
            lLearn_count.Text = "Found " + trainFolder.GetCount();
            Properties.Settings.Default.last_path_to_learn_pictures = trainFolder.GetPath();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void tb_test_imgs_path_TextChanged(object sender, EventArgs e)
        {
            lTest_count.Text = "Found " + testFolder.GetCount();
            testFolder.SetPath(tb_test_imgs_path.Text);
            testFolder.Load(tb_test_imgs_path.Text);
            Properties.Settings.Default.last_path_to_test_pictures = testFolder.GetPath();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btn_toGrey_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_imgs_open_Click(object sender, EventArgs e)
        {
            var path = OpenPictureFileDialog.openFile();
            tb_imgs_path.Text = path;
            Properties.Settings.Default.last_path_to_pictures = path;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            /*imageFolder = OpenPictureFolderFileDialog.openFolder();
            if (imageFolder.getCount() > 0)
            {
                lImages.Text = "Found " + imageFolder.getCount();
                tb_imgs_path.Text = imageFolder.getPath();
                Properties.Settings.Default.last_path_to_pictures = imageFolder.getPath();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
            else
                lImages.Text = "Not found";*/
        }

        private void btn_network_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string path;
            dlg.Title = "Open Network";
            dlg.Filter = "txt files (*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;
                tb_network_path.Text = path;
                Properties.Settings.Default.last_path_to_network = path;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }     
        }

        private void tb_network_path_TextChanged(object sender, EventArgs e)
        {

        }

    }

}

//private void btn_img1_load_Click(object sender, EventArgs e)
//{
//    imgOrigin1 = OpenPictureFileDialog.OpenPicture();
//    imgbox1.Image = imgOrigin1;
//}

//private void btn_img2_load_Click(object sender, EventArgs e)
//{
//    imgOrigin2 = OpenPictureFileDialog.OpenPicture();
//    imgbox2.Image = imgOrigin2;
//}

//private void btn_img1_toOrigin_Click(object sender, EventArgs e)
//{
//    imgbox1.Image = imgOrigin1;
//}

//private void btn_img2_toOrigin_Click(object sender, EventArgs e)
//{
//    imgbox2.Image = imgOrigin2;
//}

//private void btn_img1_tohsv_Click(object sender, EventArgs e)
//{
//    imgbox1.Image = ImgOps.RGBtoHSV(new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
//}

//private void btn_img2_tohsv_Click(object sender, EventArgs e)
//{
//    imgbox2.Image = ImgOps.RGBtoHSV(new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
//}

//private void btn_img1_togrey_Click(object sender, EventArgs e)
//{
//    imgbox1.Image = ImgOps.RGBtoGrey(new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
//}

//private void btn_img2_togrey_Click(object sender, EventArgs e)
//{
//    imgbox2.Image = ImgOps.RGBtoGrey(new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
//}

//private void btn_compare_Click(object sender, EventArgs e)
//{
//    bool matchfound = false;
//    Mat result = new Mat();
//    if ((imgbox1.Image != null) && (imgbox1.Image != null))
//    {
//        result = ShapeComparation.Draw((new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat), (new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat), ref matchfound);
//    }
//    else
//    {
//        MessageBox.Show("Load images and try again", "Error");
//    }
//    if (matchfound == true)
//    {
//        l_matchfound.Text = "Found";
//    }
//    imgbox3.Image = result;
//}

//private void btn_detect_Click(object sender, EventArgs e)
//{
//    try
//    {
//        Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        imgbox3.Image = ShapeDetection.detectShapes(img);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}  

//private void btn_detectLines_Click(object sender, EventArgs e)
//{
//    try
//    {
//        Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        int count = 0;
//        imgbox3.Image = ShapeDetection.detectShape(img, 1, out count);
//        l_lines_count.Text = "lines:"+ count;
//        l_rectangles_count.Text = "rectangles:";
//        l_circles_count.Text = "circles:";
//        l_triangles_count.Text = "triangles:";
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_detectTriangles_Click(object sender, EventArgs e)
//{
//    try
//    {
//        int count = 0;
//        Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        imgbox3.Image = ShapeDetection.detectShape(img, 2, out count);
//        l_triangles_count.Text = "triangles:" + count;
//        l_lines_count.Text = "lines:";
//        l_rectangles_count.Text = "rectangles:";
//        l_circles_count.Text = "circles:";
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_detectRectangles_Click(object sender, EventArgs e)
//{
//    try
//    {
//        int count = 0;
//        Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        imgbox3.Image = ShapeDetection.detectShape(img, 3, out count);
//        l_rectangles_count.Text = "rectangles:" + count;
//        l_lines_count.Text = "lines:";
//        l_circles_count.Text = "circles:";
//        l_triangles_count.Text = "triangles:";
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_detectCircles_Click(object sender, EventArgs e)
//{
//    try
//    {
//        //Old realization works bad
//        /*Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        imgbox3.Image = ShapeDetection.detectShape2(img, 4);*/
//        int count = 0;
//        Image<Bgr, byte> tmp = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//        imgbox3.Image = ShapeDetection.findCircles(tmp, out count);
//        l_circles_count.Text = "circles:" + count;
//        l_lines_count.Text = "lines:";
//        l_rectangles_count.Text = "rectangles:";
//        l_triangles_count.Text = "triangles:";
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_img1_denoise_Click(object sender, EventArgs e)
//{
//    UMat pyrDown = new UMat();
//    CvInvoke.PyrDown(imgbox1.Image, pyrDown);
//    Image<Bgr,byte> res = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//    CvInvoke.PyrUp(pyrDown, res);
//    imgbox1.Image = res;
//}

//private void btn_img2_denoise_Click(object sender, EventArgs e)
//{
//    try
//    {
//        UMat pyrDown = new UMat();
//        CvInvoke.PyrDown(imgbox2.Image, pyrDown);
//        Image<Bgr, byte> res = new Image<Bgr, byte>(imgbox2.Image.Bitmap);
//        CvInvoke.PyrUp(pyrDown, res);
//        imgbox2.Image = res;
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_img1_tobinary_Click(object sender, EventArgs e)
//{
//    try
//    {
//        Mat tmp = (new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
//        tmp = ImgOps.toBinary(tmp, Convert.ToInt32(img1_toBinary_border.Text), 255);
//        imgbox1.Image = tmp;
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_img2_tobinary_Click(object sender, EventArgs e)
//{
//    try
//    {
//        Mat tmp = (new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
//        tmp = ImgOps.toBinary(tmp, Convert.ToInt32(img2_toBinary_border.Text), 255);
//        imgbox2.Image = tmp;
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_img1_findColor_Click(object sender, EventArgs e)
//{
//    try
//    {
//        Image<Hsv, byte> tmp = new Image<Hsv, byte>(imgbox1.Image.Bitmap);
//        Image<Gray, Byte> gr;
//        double Rmin = Convert.ToInt32(tb_FindHMin.Text);
//        double Rmax = Convert.ToInt32(tb_FindHMax.Text);
//        double Gmin = Convert.ToInt32(tb_FindSMin.Text);
//        double Gmax = Convert.ToInt32(tb_FindSMax.Text);
//        double Bmin = Convert.ToInt32(tb_FindVMin.Text);
//        double Bmax = Convert.ToInt32(tb_FindVMax.Text);
//        gr = ImgOps.RGBFilter(tmp, Rmin, Rmax, Gmin, Gmax, Bmin, Bmax);
//        //CvInvoke.Threshold(tmp, tmp, 200, 255, 0);
//        imgbox1.Image = gr;
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void btn_img1_copyimg3_Click(object sender, EventArgs e)
//{
//    imgbox1.Image = imgbox3.Image;
//}

//private void btn_img1_makeSmooth_Click(object sender, EventArgs e)
//{
//    Image<Bgr, byte> tmp = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//    Size s = new Size(5, 5);
//    imgbox3.Image = ImgOps.makeSmooth(tmp, s, 0, 0);
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    Image<Bgr, byte> tmp = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
//    imgbox3.Image = ImgOps.cannydetect(tmp);
//}