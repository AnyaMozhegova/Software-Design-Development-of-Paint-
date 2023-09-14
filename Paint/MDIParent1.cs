using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp2
{
    public partial class MDIParent1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            ColorLabel.BackColor = Color.Black;
            Data.GetColor = Color.Black;
            SizeTextBox.Text = "1";
            Data.GetSize = 1;
            save2ToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;

        }

       

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         static private bool ok = true;
       

        
       
      
       

      
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild childForm = new frmChild();
            childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

    
        

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void отрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                GetPictureBox.LiveImage = new Bitmap(Path.GetFullPath(openFileDialog.FileName));
                frmChild PaperForm = new frmChild(GetPictureBox.LiveImage)
                {
                    MdiParent = this
                };
                PaperForm.Show();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                (ActiveMdiChild as frmChild).Image.Save(FileName);
            }
        }

        private void save2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                (ActiveMdiChild as frmChild).Image.Save(FileName);
            }
        }
        static public void ScalePlus()
        {
            try
            {
                if (ok)
                {
                    GetPictureBox.SaveImage = GetPictureBox.LiveImage;
                    ok = false;
                }

                GetPictureBox.LiveImage = new Bitmap(GetPictureBox.LiveImage, GetPictureBox.LiveImage.Width * 2,
                    GetPictureBox.LiveImage.Height * 2);
                GetPictureBox.GetPB.Image = GetPictureBox.LiveImage;
            }
            catch (Exception)
            {
                ScaleNormal();
                MessageBox.Show("Ошибка масштабирования");
            }

        }
        static public void ScaleMinus()
        {
            try
            {
                if (ok)
                {
                    GetPictureBox.SaveImage = GetPictureBox.LiveImage;
                    ok = false;
                }

                GetPictureBox.LiveImage = new Bitmap(GetPictureBox.LiveImage, GetPictureBox.LiveImage.Width / 2,
                    GetPictureBox.LiveImage.Height / 2);
                GetPictureBox.GetPB.Image = GetPictureBox.LiveImage;
            }
            catch (Exception)
            {
                ScaleNormal();
                MessageBox.Show("Ошибка масштабирования");
            }

        }
        static public void ScaleNormal()
        {

            GetPictureBox.LiveImage = new Bitmap(GetPictureBox.LiveImage, GetPictureBox.SaveImage.Width, GetPictureBox.SaveImage.Height);
            GetPictureBox.GetPB.Image = GetPictureBox.LiveImage;
        }



        private void масштабирование1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScalePlus();
        }

        private void масштабирование2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScaleMinus();
        }

        private void изначальныйВидToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleNormal();
        }

     

        private void ColorLabel_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Data.GetColor = colorDialog.Color;                      //Возвращаем полученный цвет
                ColorLabel.BackColor = colorDialog.Color;               //Изменение цвета фона ColorLabel
            }
        }

        private void SizeTextBox_Click(object sender, EventArgs e)
        {
            int size;
            bool check;
            check = int.TryParse(SizeTextBox.Text, out size);       //Проверка на ввод
            if (SizeTextBox.Text == "")                             //Если ввод пустой, то не выводить сообщение
            {

            }
            else if (!check)                                        //Если введено не число
            {
                MessageBox.Show("Введите целое число");
            }
            else
                Data.GetSize = size;
        }

      

        private void пероToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.GetAction = "Pen";
            save2ToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.GetAction = "Line";
            save2ToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.GetAction = "Elipse";
            save2ToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void звездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.GetAction = "Star";
            save2ToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void ластикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.GetAction = "Eraser";
            save2ToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Закрыть программу без сохранения?", "Закрыть", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    (ActiveMdiChild as frmChild).Image.Save(FileName);
                }
                else 
                {
                    e.Cancel = true;
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Закрыть программу без сохранения?", "Закрыть", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    (ActiveMdiChild as frmChild).Image.Save(FileName);
                }
               
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutBox1();
            frmAbout.ShowDialog();

        }

        private void MDIParent1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.F1 && save2ToolStripMenuItem.Enabled ==true && saveToolStripMenuItem.Enabled==true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    (ActiveMdiChild as frmChild).Image.Save(FileName);
                }
              
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Вы еще ничего не нарисовали");
            }
            if (e.Control && e.KeyCode == Keys.N )
            {
                frmChild childForm = new frmChild();
                childForm.MdiParent = this;
                childForm.Text = "Окно " + childFormNumber++;
                childForm.Show();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    GetPictureBox.LiveImage = new Bitmap(Path.GetFullPath(openFileDialog.FileName));
                    frmChild PaperForm = new frmChild(GetPictureBox.LiveImage)
                    {
                        MdiParent = this
                    };
                    PaperForm.Show();

                }
            }
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                DialogResult dialog = MessageBox.Show("Закрыть программу без сохранения?", "Закрыть", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string FileName = saveFileDialog.FileName;
                        (ActiveMdiChild as frmChild).Image.Save(FileName);
                    }

                }
            }
            if (e.Control && e.KeyCode == Keys.S && save2ToolStripMenuItem.Enabled == true && saveToolStripMenuItem.Enabled == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    (ActiveMdiChild as frmChild).Image.Save(FileName);
                }
            }
        }
    }


    class Data
    {
       
        public static Color GetColor { get; set; }
        
        public static int GetSize { get; set; }
    }
}
    

