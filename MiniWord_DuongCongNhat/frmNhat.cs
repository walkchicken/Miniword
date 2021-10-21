using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MiniWord_DuongCongNhat
{
    public partial class frmNhat : Form
    {
        public frmNhat()
        {
            InitializeComponent();
            tsmiFontStyle.Visible = false;
            tsBtnFontColor.Font = new Font(tsBtnFontColor.Font, FontStyle.Bold);
            tsBtnHightLight.Font = new Font(tsBtnHightLight.Font, FontStyle.Bold);
            foreach (FontFamily Font in FontFamily.Families)
            {
                tsCbFontStyle.Items.Add(Font.Name.ToString());
            }
            tsCbFontStyle.Text = rtxtWordPad.SelectionFont.Name.ToString();
            tsCbFontSize.Text = rtxtWordPad.SelectionFont.Size.ToString();
            tsBtnFontColor.ForeColor = rtxtWordPad.SelectionColor;
        }

        private bool isSaved = true;

        private void rtxtWordPad_TextChanged(object sender, EventArgs e) => isSaved = false;

        private void frmWordPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved == false)
            {
                //MessageBo = "Thoát";
                //MessageBoxManager.No = "Lưu lại";
               // MessageBoxManager.Cancel = "Trở lại";
                //MessageBoxManager.Register();
                DialogResult dR = MessageBox.Show("Dữ liệu chưa được lưu sẽ bị mất\r\nBạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dR == DialogResult.No)
                {
                    this.saveFile(false, "Save Document Files");
                    e.Cancel = true;
                }
                //MessageBoxManager.Unregister();
            }
        }

        private void rtxtWordPad_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Tab)
            {
                this.SuspendLayout();
                rtb.Undo();
                rtb.Redo();
                this.ResumeLayout();
            }
        }

        //File menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == false)
            {
               // MessageBoxManager.Yes = "Thoát";
                //MessageBoxManager.No = "Lưu lại";
               // MessageBoxManager.Cancel = "Trở lại";
                //MessageBoxManager.Register();
                DialogResult dR = MessageBox.Show("Dữ liệu chưa được lưu sẽ bị mất\r\nBạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dR == DialogResult.Yes)
                    this.Close();
                else if (dR == DialogResult.No)
                {
                    this.saveFile(false, "Save Document Files");
                }
               // MessageBoxManager.Unregister();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == false)
            {
                //MessageBox.Yes = "Tiếp tục";
               // MessageBoxManager.No = "Lưu lại";
                //MessageBoxManager.Cancel = "Hủy bỏ";
               // MessageBoxManager.Register();
                DialogResult dR = MessageBox.Show("Dữ liệu chưa được lưu sẽ bị mất\r\nBạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dR == DialogResult.Yes)
                    rtxtWordPad.Clear();
                else if (dR == DialogResult.No)
                    this.saveFile(false, "Save Document Files");
               // MessageBoxManager.Unregister();
            }
        }

        private void saveFile(bool check, string title)
        {
            saveFDWordPad.InitialDirectory = @"F:\laptrinhwindows\MiniWord_DuongCongNhat\MiniWord_DuongCongNhat\savefile";
            saveFDWordPad.Title = title;
            saveFDWordPad.CheckFileExists = check;
            saveFDWordPad.CheckPathExists = true;
            saveFDWordPad.DefaultExt = "*.rtf";
            saveFDWordPad.Filter = "Document Files(*.rtf)|*.rtf|(*.txt)|*.txt|All files (*.*)|*.*";
            saveFDWordPad.FilterIndex = 2;
            saveFDWordPad.RestoreDirectory = true;
            if (saveFDWordPad.ShowDialog() == DialogResult.OK && saveFDWordPad.FileName.Length > 0)
            {
                rtxtWordPad.SaveFile(saveFDWordPad.FileName, RichTextBoxStreamType.RichText);
                isSaved = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(false, "Save Document Files");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(true, "Save Document Files As");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFDWordPad.InitialDirectory = @"F:\laptrinhwindows\MiniWord_DuongCongNhat\MiniWord_DuongCongNhat\savefile";
            openFDWordPad.Title = "Open Document Files";
            openFDWordPad.CheckFileExists = true;
            openFDWordPad.CheckPathExists = true;
            openFDWordPad.DefaultExt = "*.rtf";
            openFDWordPad.Filter = "Document Files(*.rtf)|*.rtf|(*.txt)|*.txt|All files (*.*)|*.*";
            openFDWordPad.FilterIndex = 2;
            if (openFDWordPad.ShowDialog() == DialogResult.OK && openFDWordPad.FileName.Length > 0)
            {
                rtxtWordPad.LoadFile(openFDWordPad.FileName, RichTextBoxStreamType.RichText);
                isSaved = true;
            }
        }

        //fontStyle Menu
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (rtxtWordPad.SelectionFont.Style != (FontStyle.Bold | rtxtWordPad.SelectionFont.Style))
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style | FontStyle.Bold);
            else
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style & ~FontStyle.Bold);
            rtxtWordPad.SelectionFont = newFont;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (rtxtWordPad.SelectionFont.Style != (FontStyle.Italic | rtxtWordPad.SelectionFont.Style))
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style | FontStyle.Italic);
            else
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style & ~FontStyle.Italic);
            rtxtWordPad.SelectionFont = newFont;
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (rtxtWordPad.SelectionFont.Style != (FontStyle.Underline | rtxtWordPad.SelectionFont.Style))
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style | FontStyle.Underline);
            else
                newFont = new Font(rtxtWordPad.SelectionFont.FontFamily.Name, rtxtWordPad.SelectionFont.Size, rtxtWordPad.SelectionFont.Style & ~FontStyle.Underline);
            rtxtWordPad.SelectionFont = newFont;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtWordPad.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtWordPad.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtWordPad.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tsCbFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtWordPad.SelectionFont = new Font(tsCbFontStyle.Text, rtxtWordPad.SelectionFont.Size);
        }

        private void tsCbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtWordPad.SelectionFont = new Font(rtxtWordPad.SelectionFont.FontFamily, float.Parse(tsCbFontSize.Text));
        }


        private void changeFont()
        {
            if (tsCbFontSize.Text.Length < 1)
            {
                tsCbFontSize.Text = "10";
            }
            rtxtWordPad.SelectionFont = new Font(rtxtWordPad.SelectionFont.FontFamily, float.Parse(tsCbFontSize.Text));
        }

        private void tsCbFontSize_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                changeFont();
                rtxtWordPad.Focus();
            }
        }

        private void tsCbFontSize_Leave(object sender, EventArgs e)
        {
            changeFont();
        }

        private void tsBtnFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDiag = new ColorDialog();
            if (colorDiag.ShowDialog() == DialogResult.OK)
            {
                rtxtWordPad.SelectionColor = colorDiag.Color;
            }
        }

        private void tsBtnHightlight_Click(object sender, EventArgs e)
        {
            ColorDialog colorDiag = new ColorDialog();
            if (colorDiag.ShowDialog() == DialogResult.OK)
            {
                rtxtWordPad.SelectionBackColor = colorDiag.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDiag = new FontDialog();
            if (fontDiag.ShowDialog() == DialogResult.OK)
                if (rtxtWordPad.SelectedText != "")
                    rtxtWordPad.Font = fontDiag.Font;
        }

        //About menu
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trường Đại Học Kiến Trúc Đà Nẵng\r\nKhoa Công Nghệ Thông Tin\r\nDương Công Nhật", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Undo & Redo
        private void tsBtnUndo_Click(object sender, EventArgs e)
        {
            rtxtWordPad.Undo();
        }

        private void tsBtnRedo_Click(object sender, EventArgs e)
        {
            rtxtWordPad.Redo();
        }

        //Edit menu
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => rtxtWordPad.SelectAll();

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindReplace frm = new frmFindReplace(rtxtWordPad, this);
            frm.Show();
        }

        private void tsCbFontStyle_Click(object sender, EventArgs e)
        {

        }

        private void rtxtWordPad_SelectionChanged(object sender, EventArgs e)
        {
            if (rtxtWordPad.SelectionFont != null)
            {
                tsBtnBold.Checked = rtxtWordPad.SelectionFont.Bold;
                tsBtnItalic.Checked = rtxtWordPad.SelectionFont.Italic;
                tsBtnUnderline.Checked = rtxtWordPad.SelectionFont.Underline;

                tsBtnLeft.Checked = false;
                tsBtnCenter.Checked = false;
                tsBtnRight.Checked = false;

                toolStripLabel2.Text = rtxtWordPad.SelectionStart.ToString();

                switch (rtxtWordPad.SelectionAlignment)
                {
                    case HorizontalAlignment.Left:
                        tsBtnLeft.Checked = true;
                        break;
                    case HorizontalAlignment.Center:
                        tsBtnCenter.Checked = true;
                        break;
                    case HorizontalAlignment.Right:
                        tsBtnRight.Checked = true;
                        break;
                }
            }
        }
        int id = 0;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:\laptrinhwindows\MiniWord_DuongCongNhat\MiniWord_DuongCongNhat\Icon"); //change and get your folder
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);
            this.listView1.LargeImageList = this.imageList1;
            //or
            //this.listView1.View = View.SmallIcon;
            //this.listView1.SmallImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }

            listView1.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.FocusedItem == null) return;
                id = listView1.SelectedIndices[0];
                Clipboard.SetImage(imageList1.Images[id]);
                rtxtWordPad.Paste();
            }
            catch (Exception)
            {
                return;
            }
            
            listView1.Visible = false;
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            string path = f.FileName;
            try
            {
                Clipboard.SetImage(Image.FromFile(path));
                rtxtWordPad.Paste();
            }
            catch (Exception)
            {
                return;
            }                
        }

        private void frmNhat_Load(object sender, EventArgs e)
        {
           
        }
    }
}