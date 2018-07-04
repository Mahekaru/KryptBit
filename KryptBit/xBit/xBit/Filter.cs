using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace KryptBit
{
    public class Filter
    {
        private frmKryptBit MainForm;
        private DragDrop sysDragDrop;
        private string RootPath;

        public Filter(frmKryptBit frmMainForm)
        {
            MainForm = frmMainForm;
            RootPath = Properties.Settings.Default.Root;
            sysDragDrop = new DragDrop(this);
            if (Directory.Exists(RootPath) == false)
            {
                CreateDirectory(RootPath);
            }
        }

        public Form BinaryConverter = new Form();

        private Panel pnlFilterTitle;
        private Panel pnlFilterSystem;

        private Label lblClosebtn;
        private Label lblFilterTitle;
        private Label lblError;

        private TextBox txtFilterName;
        private TextBox txtCode;

        private LinkLabel llAddCode;
        private LinkLabel llSingle;
        private LinkLabel llMulti;
        private LinkLabel llReversal;
        private LinkLabel llMultiReversal;
        private LinkLabel llRemoveCode;
        private LinkLabel llDeleteFilter;
        private LinkLabel llSaveFilter;

        private GroupBox gbCodeList;
        private GroupBox gbFilterTypes;

        private ListBox lbFilterNames;

        public ComboBox cbCodeList;

        private void Reset()
        {
            txtFilterName.Text = "Filter Name";
            txtCode.Text = "Insert Code";
            lblError.Text = "";
            txtCode.ForeColor = Color.DarkGray;
            txtFilterName.ForeColor = Color.DarkGray;
            lbFilterNames.Items.Clear();
        }

        public void Initilize()
        {
           
            BinaryConverter.FormBorderStyle = FormBorderStyle.None;
            BinaryConverter.Size = new Size(283, 375);

            pnlFilterTitle = new Panel();
            pnlFilterSystem = new Panel();

            lblClosebtn = new Label();
            lblFilterTitle = new Label();
            lblError = new Label();

            txtFilterName = new TextBox();
            txtCode = new TextBox();

            llAddCode = new LinkLabel();
            llSingle = new LinkLabel();
            llMulti = new LinkLabel();
            llReversal = new LinkLabel();
            llMultiReversal = new LinkLabel();
            llRemoveCode = new LinkLabel();
            llDeleteFilter = new LinkLabel();
            llSaveFilter = new LinkLabel();

            gbCodeList = new GroupBox();
            gbFilterTypes = new GroupBox();

            lbFilterNames = new ListBox();

            cbCodeList = new ComboBox();

            //Form
            BinaryConverter.BackColor = Color.Black;
            BinaryConverter.ForeColor = Color.White;
            BinaryConverter.Controls.Add(pnlFilterTitle);
           
            //Panel
            pnlFilterSystem.Size = new Size(300, 395);
            pnlFilterSystem.Location = new Point(-1, 30);
            pnlFilterSystem.BorderStyle = BorderStyle.FixedSingle;
            pnlFilterSystem.Controls.Add(txtFilterName);
            pnlFilterSystem.Controls.Add(llAddCode);
            pnlFilterSystem.Controls.Add(txtCode);
            pnlFilterSystem.Controls.Add(gbCodeList);
            pnlFilterSystem.Controls.Add(cbCodeList);
            pnlFilterSystem.Controls.Add(gbFilterTypes);
            pnlFilterSystem.Controls.Add(lblError);
            pnlFilterSystem.MouseDown +=new MouseEventHandler(pnlFilterSystem_MouseDown);
            pnlFilterSystem.MouseUp +=new MouseEventHandler(pnlFilterSystem_MouseUp);
            
            //Textbox
            txtFilterName.Location = new Point(9, 10);
            txtFilterName.Size = new Size(125, 20);
            txtFilterName.Text = "Filter Name";
            txtFilterName.ForeColor = Color.DarkGray;
            txtFilterName.Enter += new EventHandler(txtFilterName_Enter);
            txtFilterName.Leave += new EventHandler(txtFilterName_Leave);

            //textBox
            txtCode.Location = new Point(9, 35);
            txtCode.Size = new Size(100, 20);
            txtCode.Text = "Insert Code";
            txtCode.ForeColor = Color.DarkGray;
            txtCode.Enter +=new EventHandler(txtCode_Enter);
            txtCode.Leave +=new EventHandler(txtCode_Leave);

            //Link Label - - - Add Code
            llAddCode.Location = new Point(9, 60);
            llAddCode.AutoSize = true;
            llAddCode.LinkColor = Color.White;
            llAddCode.LinkBehavior = LinkBehavior.SystemDefault;
            llAddCode.Font = new Font("Microsoft San Serif", 10);
            llAddCode.Text = "Add Code";
            llAddCode.Click +=new EventHandler(llAddCode_Click);




            //Panel
            pnlFilterTitle.Location = new Point(0, 0);
            pnlFilterTitle.Size = new Size(282, 374);
            pnlFilterTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlFilterTitle.Controls.Add(lblFilterTitle);
            pnlFilterTitle.Controls.Add(lblClosebtn);
            pnlFilterTitle.Controls.Add(pnlFilterSystem);
            pnlFilterTitle.MouseDown+=new MouseEventHandler(pnlFilterTitle_MouseDown);
            pnlFilterTitle.MouseUp+=new MouseEventHandler(pnlFilterTitle_MouseUp);

            //Label - - - Filter Menu
            lblFilterTitle.Location = new Point(75, 3);
            lblFilterTitle.Font = new Font("Microsoft San Serif", 12);
            lblFilterTitle.Size = new Size(124, 20);
            lblFilterTitle.BackColor = Color.Black;
            lblFilterTitle.ForeColor = Color.White;
            lblFilterTitle.Text = "- - Filter Menu - -";

            //Label - - - X
            lblClosebtn.Location = new Point(251, 0);
            lblClosebtn.BackColor = Color.Black;
            lblClosebtn.ForeColor = Color.White;
            lblClosebtn.Size = new Size(30, 30);
            lblClosebtn.Text = "X";
            lblClosebtn.BorderStyle = BorderStyle.FixedSingle;
            lblClosebtn.TextAlign = ContentAlignment.MiddleCenter;
            lblClosebtn.Click += new EventHandler(lblClosebtn_Click);

            //Groupbox - - - Code List
            gbCodeList.Location = new Point(140, 5);
            gbCodeList.Size = new Size(131, 325);
            gbCodeList.Text = "Code List";
            gbCodeList.ForeColor = Color.White;
            gbCodeList.Font = new Font("Microsoft San Serif", 10);

            //// Combo Box (Drop Down)
            cbCodeList.Location = new Point(9, 90);
            cbCodeList.Size = new Size(100, 21);
            cbCodeList.DropDownHeight = 220;
            //this.comboBox1.DropDownHeight = 300;
            cbCodeList.Text = "Choose A Filter";
            PullFilterData(cbCodeList);
            cbCodeList.Leave += new EventHandler(cbCodeList_Leave);
            cbCodeList.Click +=new EventHandler(cbCodeList_Click);

            //Groupbox
            gbCodeList.Controls.Add(lbFilterNames);

            //Listbox
            lbFilterNames.Size = new Size(118, 292);
            lbFilterNames.Location = new Point(7, 21);
            lbFilterNames.BackColor = Color.Black;
            lbFilterNames.ForeColor = Color.White;
            lbFilterNames.BorderStyle = BorderStyle.None;
            lbFilterNames.SelectedValueChanged +=new EventHandler(lbFilterNames_SelectedValueChanged);

            //Groupbox - - - Filter Types
            gbFilterTypes.Text = "Filter Types";
            gbFilterTypes.ForeColor = Color.White;
            gbFilterTypes.Location = new Point(9, 160);
            gbFilterTypes.Size = new Size(125, 170);
            gbFilterTypes.Font = new Font("Microsoft San Serif", 10);
            gbFilterTypes.Controls.Add(llSingle);
            gbFilterTypes.Controls.Add(llMulti);
            gbFilterTypes.Controls.Add(llReversal);
            gbFilterTypes.Controls.Add(llMultiReversal);
            gbFilterTypes.Controls.Add(llRemoveCode);
            gbFilterTypes.Controls.Add(llDeleteFilter);
            gbFilterTypes.Controls.Add(llSaveFilter);

            //Label - - - Error
            lblError.Location = new Point(9, 340);
            lblError.AutoSize = true;
            lblError.ForeColor = Color.White;
            lblError.Font = new Font("Microsoft San Serif", 10);
            //lblError.Text = "ERROR";

            //link Label - - - Single
            llSingle.Location = new Point(5, 20);
            llSingle.AutoSize = true;
            llSingle.LinkColor = Color.White;
            llSingle.LinkBehavior = LinkBehavior.SystemDefault;
            llSingle.Font = new Font("Microsoft San Serif", 10);
            llSingle.Text = "Single";
            llSingle.Click +=new EventHandler(llSingle_Click);

            //Link Label - - - Multi
            llMulti.Location = new Point(5, 36);
            llMulti.AutoSize = true;
            llMulti.LinkBehavior = LinkBehavior.SystemDefault;
            llMulti.LinkColor = Color.White;
            llMulti.Text = "Multi";
            llMulti.Click +=new EventHandler(llMulti_Click);

            //Link Label - - - Reversal
            llReversal.Location = new Point(5, 52);
            llReversal.AutoSize = true;
            llReversal.LinkColor = Color.White;
            llReversal.Text = "Reversal";
            llReversal.Click +=new EventHandler(llReversal_Click);

            //Link Label - - - Multi Reversal
            llMultiReversal.Location = new Point(5, 68);
            llMultiReversal.AutoSize = true;
            llMultiReversal.LinkColor = Color.White;
            llMultiReversal.Text = "Multi Reversal";
            llMultiReversal.Click +=new EventHandler(llMultiReversal_Click);

            //Link Label - - - Remove Code
            llRemoveCode.Location = new Point(5, 100);
            llRemoveCode.AutoSize = true;
            llRemoveCode.LinkColor = Color.White;
            llRemoveCode.Text = "Remove Code";
            llRemoveCode.Enabled = false;
            llRemoveCode.Click +=new EventHandler(llRemoveCode_Click);

            //Link Label - - - Delete Filter
            llDeleteFilter.Location = new Point(5, 116);
            llDeleteFilter.AutoSize = true;
            llDeleteFilter.LinkColor = Color.White;
            llDeleteFilter.Text = "Delete Filter";
            llDeleteFilter.Click +=new EventHandler(llDeleteFilter_Click);

            //Link Label - - - Save Filter
            llSaveFilter.Location = new Point(5, 132);
            llSaveFilter.AutoSize = true;
            llSaveFilter.LinkColor = Color.White;
            llSaveFilter.Text = "Save Filter";
            llSaveFilter.Click +=new EventHandler(llSaveFilter_Click);
        }

        private void cbCodeList_Click(object sender, EventArgs e)
        {
            PullFilterData(cbCodeList);
        }

        private void llSaveFilter_Click(object sender, EventArgs e)
        {
            CreateDirectory(RootPath + txtFilterName.Text);
            WriteConfigFile(RootPath + txtFilterName.Text);
        }

        public void CreateDirectory(string Path)
        {
            Directory.CreateDirectory(Path);
        }

        public void WriteConfigFile(string Path)
        {
            StreamWriter w = new StreamWriter(Path + @"\FilterConfig");
            foreach(Object Obj in lbFilterNames.Items)
            {
                w.WriteLine(Obj);
            }
            w.Close();
            lblError.Text = "Filter Saved!!!";
        }

        //private void FileSetup(string FileName)
        //{
        //    if (FileName != "Filter Name")
        //    {
        //        string FilePath;
        //        FilePath = RootPath + @"\" + FileName;
        //        lblError.Text = "";
        //        //DirectoryInfo di = Directory.CreateDirectory(FilePath);
        //        //StreamWriter w = new StreamWriter(FilePath + @"\FilterConfig");
        //        //foreach(object in cbCodeList.Items)
        //        //{

        //        //}
        //    }
        //    else
        //    {
        //        lblError.Text = "Filename Is Required...";
        //    }
        //}

        private void pnlFilterSystem_MouseDown(object sender, EventArgs e)
        {
            sysDragDrop.findOffsets();
            MainForm.blnDragDrop = true;
        }

        private void pnlFilterSystem_MouseUp(object sender, EventArgs e)
        {
            MainForm.blnDragDrop = false;
        }

        private void pnlFilterTitle_MouseDown(object sender, EventArgs e)
        {
            sysDragDrop.findOffsets();
            MainForm.blnDragDrop = true;
        }

        private void pnlFilterTitle_MouseUp(object sender, EventArgs e)
        {
            MainForm.blnDragDrop = false;
        }

        public int ReturnCalxPosition()
        {
            return sysDragDrop.CalxPosition();
        }

        public int ReturnCalyPosition()
        {
            return sysDragDrop.CalyPosition();
        }

        private void cbCodeList_Leave(object sender, EventArgs e)
        {
            LeaveFilterList(cbCodeList);
        }

        private void llSingle_Click(object sender, EventArgs e)
        {
            txtCode.Text = "(0,0)";
        }

        private void llMulti_Click(object sender, EventArgs e)
        {
            txtCode.Text = "(0,0:0,0)";
        }

        private void llReversal_Click(object sender, EventArgs e)
        {
            txtCode.Text = "(0,0::0,0)";
        }

        private void llMultiReversal_Click(object sender, EventArgs e)
        {
            txtCode.Text = "(0,0:0,0::0,0:0,0)";
        }

        public void Load_Filter()
        {
            BinaryConverter.Show();
            BinaryConverter.Location = new Point(MainForm.Location.X + MainForm.Width, MainForm.Location.Y);
            BinaryConverter.Focus();
        }

        private void lbFilterNames_SelectedValueChanged(object sender, EventArgs e)
        {
            llRemoveCode.Enabled = true;
        }

        private void llRemoveCode_Click(object sender, EventArgs e)
        {
            try
            {
                string FilterName;
                FilterName = lbFilterNames.SelectedItem.ToString();

                lbFilterNames.Items.Remove(FilterName);
                llRemoveCode.Enabled = false;
            }
            catch
            {
            }
        }

        private void llDeleteFilter_Click(object send, EventArgs e)
        {
            DeleteFilter(RootPath + cbCodeList.Text);
        }

        private void DeleteFilter(string Path)
        {
            Directory.Delete(Path,true);
            cbCodeList.Text = "";
            cbCodeList.Refresh();
            txtFilterName.Focus();
        }

        private void llAddCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != "Insert Code")
            {
                lbFilterNames.Items.Add(txtCode.Text);
            }
        }

        private void lblClosebtn_Click(object sender, EventArgs e)
        {
            BinaryConverter.Visible = false;
            Reset();
        }

        private void txtFilterName_Enter(object sender, EventArgs e)
        {
            txtFilterName.Text = "";
            txtFilterName.ForeColor = Color.Black;
        }

        private void txtFilterName_Leave(object sender, EventArgs e)
        {
            if (txtFilterName.Text == "")
            {
                txtFilterName.Text = "Filter Name";
                txtFilterName.ForeColor = Color.DarkGray;
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtCode.ForeColor = Color.Black;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                txtCode.Text = "Insert Code";
                txtCode.ForeColor = Color.DarkGray;
            }
        }

        public void LeaveFilterList(ComboBox FList)
        {
            if (FList.Text == "")
            {
                FList.Text = "Choose A Filter";
            }
        }
       
        public void PullFilterData(ComboBox FList)
        {
            FList.Items.Clear();
            FList.Items.Add("");
            foreach (string s in Directory.GetDirectories(RootPath))
            {
                FList.Items.Add(s.Remove(0, RootPath.Length));
            }
        }

    }
}
