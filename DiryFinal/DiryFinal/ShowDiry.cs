using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace DiryFinal
{
    public partial class ShowDiry : Form
    {
        DataAccesscs dataAccess;
        public ShowDiry()
        {
            InitializeComponent();
            this.dataAccess = new DataAccesscs();
            
            AddEvent.Click += this.ShowDiry_Load;
            Updatebutton.Click += this.ShowDiry_Load;
            Deletebutton.Click += this.ShowDiry_Load;

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            // DateTime datetime = new DateTime();
            DiaryServices diaryServiice = new DiaryServices();
            MemoryStream ms2 = new MemoryStream();
          
           byte[] img_arry= new byte[ms2.Length];
            ms2.Read(img_arry, 0, img_arry.Length);
            
            //string date = EventdateTime.Value.ToString() ;
            int result = diaryServiice.AddNewEvent(EperiencetextBox.Text, ThoughttextBox.Text, FellingstextBox.Text, importancecomboBox.Text,img_arry, EventdateTime.Value.ToString());
            
            
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");

            }
            else
            {
                MessageBox.Show("Error in adding Event");
            }
        }


        private void ShowDiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DiaryServices productService = new DiaryServices();
            //dataGridView1.DataSource = productService.GetProductList();
            EperiencetextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ThoughttextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FellingstextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            importancecomboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void ShowDiry_Load(object sender, EventArgs e)
        {
            DiaryServices diaryService = new DiaryServices();
            var list = diaryService.GetEventtList();
            dataGridView1.DataSource = list;
            var byteImage = list.FirstOrDefault().Picture;

            var image = GetBitmapImage(byteImage);
        }

        private static BitmapImage GetBitmapImage(byte[] imgByte)
        {
            try
            {
                var memoryStream = new MemoryStream();
                var bitmapImage = new BitmapImage();

                if (imgByte == null || imgByte.Length <= 2)
                    return bitmapImage;

                memoryStream.Write(imgByte, 0, imgByte.Length);

                memoryStream.Position = 0;

                Image img = Image.FromStream(memoryStream);

                bitmapImage.BeginInit();

                var mS = new MemoryStream();

                img.Save(mS, System.Drawing.Imaging.ImageFormat.Bmp);

                mS.Seek(0, SeekOrigin.Begin);

                bitmapImage.StreamSource = mS;

                bitmapImage.EndInit();

                return bitmapImage;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : \n" + e.Message);
                return null;
            }
        }

        private void EventpictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //EventpictureBox.Text = open.FileName;
            }
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";
            DialogResult dres1 = fd1.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            imgtextBox.Text = fd1.FileName;

            ShowDiry sdiary = new ShowDiry();
            //sdiary.EventpictureBox.Image= Image.FromFile(fd1.FileName);
            MemoryStream ms1 = new MemoryStream();
            //sdiary.EventpictureBox.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DiaryServices diaryService = new DiaryServices();


            // dataGridView1.SelectedColumns[0].Index.ToString();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            DiryAccess diryAccess = new DiryAccess();
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Are you sure want to update this Event?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridView1.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        DiaryServices diaryServiice = new DiaryServices();
                        MemoryStream ms2 = new MemoryStream();

                        byte[] img_arry = new byte[ms2.Length];
                        ms2.Read(img_arry, 0, img_arry.Length);

                        //string date = EventdateTime.Value.ToString() ;
                        int result = diaryServiice.UpdateOldEvent(EperiencetextBox.Text, ThoughttextBox.Text, FellingstextBox.Text, importancecomboBox.Text, img_arry, EventdateTime.Value.ToString(),id);


                        if (result > 0)
                        {
                            MessageBox.Show("Event added successfully.");

                        }
                        else
                        {
                            MessageBox.Show("Error in adding Event");
                        }

                    }
                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
           
                DiryAccess diryAccess = new DiryAccess();
           int id= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Are you sure want to delete this Event?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridView1.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        diryAccess.DeleteEvent(id);
                       
                    }
                }
            }

        }

        private void Backlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
