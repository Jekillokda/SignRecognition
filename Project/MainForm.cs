using ConvNetSharp.Volume;
using ConvNetSharp.Volume.Double;
using Emgu.CV;
using Emgu.CV.Structure;
using Project.ConvNeuronNet;
using Project.DetectionHaar;
using Project.MediaFolders;
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
        XmlFolder xmlFolder;
        List<string> folders_to_detect = new List<string>();
        string path_to_cutted_images;
        string path_to_save_detected_images;
        string path_to_detect_images;
        int images_count_to_detect;
        string path_to_cascades;
        string path_to_results_save;
        int aim;
        CNN network;
        ResultExport exp;

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

            if ((Properties.Settings.Default.last_path_for_images_to_detect != "") && (Directory.Exists(Properties.Settings.Default.last_path_for_images_to_detect)))
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

            if (Properties.Settings.Default.last_path_to_cascades != "")
            {
                path_to_cascades = Properties.Settings.Default.last_path_to_cascades;
                if (path_to_cascades.Length != 0)
                {
                    xmlFolder = new XmlFolder();
                    xmlFolder.Load(path_to_cascades);
                    tb_cascade_path.Text = path_to_cascades;
                    if (xmlFolder.GetCount() > 0)
                    {
                        lCascadeLoaded.Text = "Loaded " + xmlFolder.GetCount().ToString();
                    }
                    else
                    {
                        lCascadeLoaded.Text = "Not Exists";
                    }
                    tb_cascade_path.Text = Properties.Settings.Default.last_path_to_cascades;

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

            if (Properties.Settings.Default.last_path_to_results_save != "")
            {
                path_to_results_save = Properties.Settings.Default.last_path_to_results_save;
                if (Directory.Exists(path_to_results_save))
                {
                    tb_result_save_path.Text = path_to_results_save;
                }
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

            if ((tb_videos_path.Text != "") && (lVideos_count.Text != ""))
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
                FFMPEGConverter conv = new FFMPEGConverter(videopath, tb_images_to_save_path.Text);
                bool rewrite = false;
                if (conv.ConvertAll(rewrite) == false)
                {
                    MessageBox.Show("Something went wrong with" + videopath);
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
            xmlFolder = OpenXmlFolderFileDialog.openFolder();
            path_to_cascades = xmlFolder.GetFolderPath();
            tb_cascade_path.Text = path_to_cascades;
            if (xmlFolder.GetCount() > 0)
            {
                lCascadeLoaded.Text = "Loaded " + xmlFolder.GetCount().ToString();
            }
            else
            {
                lCascadeLoaded.Text = "Not Exists";
            }
            Properties.Settings.Default.last_path_to_cascades = path_to_cascades;
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
                foreach (string p in folders_to_detect)
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
            foreach (string path in folders_to_detect)
            {
                DetectFolder.DetectAll(path, xmlFolder.GetAll(), tb_detected_images_to_save_path.Text);
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
            Int32.TryParse(tb_network_acc.Text, out aim);
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
                double d = network.TeachCNN(trainFolder.GetPath(), testFolder.GetPath(), aim, 0.02, 100, 0.9);
                if (d == -1)
                    MessageBox.Show("Please add layers and try again");
                else
                    lAccuracy.Text = d.ToString();
                if (network.IsLearned())
                {
                    lLearned.Text = "Learned";
                    MessageBox.Show("Network is learned acc is " + lAccuracy.Text);
                }
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

                if (im.Size != new Size(32, 32))
                {
                    im = new Image<Gray, byte>(ImgOps.InterpolationResize(im, 32, 32).Bitmap).Mat;
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
            btn_convert_videos_Click(sender, e);
            btn_Haar_Detect_Click(sender, e);
        }

        private void btn_learn_resize_Click(object sender, EventArgs e)
        {
            foreach (string imgpath in trainFolder.GetAll())
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

        private void btn_results_save_Click(object sender, EventArgs e)
        {
            Result[] arr = new Result[10];
            for (int i = 0; i < 10; i++)
            {
                Result r = new Result(i, 0, "123", "456", new DateTime(2019, 5, 27), 1, 100);
                arr[i] = r;
            }
            exp = new ResultExport("l", "p", "s", tb_result_save_path.Text);
            exp.ExportToFile(arr);
            MessageBox.Show("Done");
        }

        private void btn_results_to_save_open_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                SelectedPath = tb_result_save_path.Text
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               path_to_results_save = dialog.SelectedPath;
                tb_result_save_path.Text = path_to_results_save;
                Properties.Settings.Default.last_path_to_results_save = path_to_results_save;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
            }

        private void btn_results_upload_Click(object sender, EventArgs e)
        {
            exp = new ResultExport("l", "p", "s", tb_result_save_path.Text);
            exp.ExportFolder(tb_result_save_path.Text);
            MessageBox.Show("Successfull");
        }

        private void btn_ROI_makeAll_Click(object sender, EventArgs e)
        {

        }
    }

}