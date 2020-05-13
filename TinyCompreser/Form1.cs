using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TinifyAPI;
using TinyCompreser.Utils;
using Exception = TinifyAPI.Exception;

namespace TinyCompreser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressPanel1.Hide();
            ToplamDurumProgressBar.Hide();
            durumLabel.Hide();
           // Tinify.Key = Util.APIKEY;
        }
        List<string> resimYollari=new List<string>();
        Dictionary<string, string> resimYol =  new Dictionary<string, string>();
        private string kayitYeri = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        Random rn = new Random();
        private async void CompresserBtn_Click(object sender, EventArgs e)
        {
            
            if (resimYol.Count!=0 && (!string.IsNullOrWhiteSpace(metroTextBox1.Text)))
            {
                try
                {
                    
                    progressPanel1.Show();
                    ToplamDurumProgressBar.Show();
                    kayitYeri = KlasorOlustur();
                  indirilenDosyaListBox.Items.Clear();
                    int i = 0;

                    int boyut = 100 / resimYol.Count;
                    foreach (var resim in resimYol)
                    {
                        ToplamDurumProgressBar.Percentage = boyut * i;
                        Image img = Image.FromFile(resim.Value);
                        var resultData = await Tinify.FromBuffer(Util.ImgToByte(img)).ToBuffer();
                        Image responseImage = Util.ByteToImage(resultData);
                        responseImage.Save(kayitYeri + "\\" + resim.Key);
                        indirilenDosyaListBox.Items.Add(resim.Key);

                        i++;
                        ToplamDurumProgressBar.Percentage = boyut * i;
                    }

                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);
                    ToplamDurumProgressBar.Hide();
                }
                finally
                {
                    ToplamDurumProgressBar.Percentage = 100;
                    progressPanel1.Hide();
                    resimYol.Clear();
                    dosyaListBox.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Klasör Seçili değil veya API Key alanı boş!");
            }
          
        }

        private string KlasorOlustur()
        {
            string masaustu = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string randomDosya = Guid.NewGuid().ToString();
            string tamYol = Path.Combine(masaustu, randomDosya);
            if (!Directory.Exists(tamYol))
            {
                Directory.CreateDirectory(tamYol);
                return tamYol;
            }
            else
            {
                //şu anlık gerek yok
                return "";
            }

           
        }
        

        private void progressPanel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser =new OpenFileDialog();
            
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser=new FolderBrowserDialog();
            if (folderBrowser.ShowDialog()==DialogResult.OK)
            {
                dosyaListBox.Items.Clear();
                resimYol.Clear();
                string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                foreach (string file in files)
                {
                   FileInfo ff=new FileInfo(file);
                   if (ff.Extension==".jpg" || ff.Extension==".png")
                   {
                       resimYol.Add(Path.GetFileName(file),file);
                       resimYollari.Add(file);
                       dosyaListBox.Items.Add(Path.GetFileName(file));
                   }
                   
                }

                if (resimYollari.Count==0 || resimYol.Count==0)
                {
                    MessageBox.Show("Resim bulunamadı!");
                }
            }
        }

        private void klasorAcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (indirilenDosyaListBox.Items.Count!=0)
                {
                    indirilenDosyaListBox.Items.Clear();
                    ToplamDurumProgressBar.Hide();
                    Process.Start(kayitYeri);
                }
                else
                {
                    MessageBox.Show("Klasör Boş");
                }
               
            }
            catch 
            {
                MessageBox.Show("Klasör Bulunamadı!");
            }
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Tinify.Key = metroTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
