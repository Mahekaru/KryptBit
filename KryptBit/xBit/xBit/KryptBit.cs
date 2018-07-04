using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Collections;


namespace KryptBit
{
    public partial class frmKryptBit : Form
    {
        private bool Aliasing;

        private int xAxis;
        private int yAxis;
        public Settings SystemSettings;
        public Filter SystemFilters;
        private Stack sysStack;
        public bool blnDragDrop = false;

        public frmKryptBit()
        {
            InitializeComponent();

            SystemSettings = new Settings(this);
            SystemFilters = new Filter(this);
            sysStack = new Stack(this);
            this.BackColor = Properties.Settings.Default.Background;
            msXbit.BackColor = this.BackColor;
            FileData = "NoData";
            AAOn.BackColor = Color.Red;
            Aliasing = true;
            xAxis = 0;
            yAxis = 0;
            xBitCount = Convert.ToInt32(txtBitCount.Text);
            
            SystemFilters.Initilize();
        }

        private void ReadData(string Path)
        {
            if (Path != "NoData")
            {
                using (StreamReader DataReader = new StreamReader(Path))//Creates And Opens The File using The Path We Choose From the openfiledialogbox
                {
                    FileData = DataReader.ReadToEnd().ToString();
                }
                txtBitCount.Enabled = true;
                antiAliasToolStripMenuItem.Enabled = true;
                ReDraw();
            }
            
        }

        private bool xDraw;
        private String FileData;
        private int xBitCount;
        public static BufferedGraphics MyBuffer;
        private BufferedGraphicsContext CurrentContext;
        
        private string DataPool;
        private void DataPull(int Offset,int xRows)
        {
            int BitScroll,xPullLength;
            
            if (Offset != 0)
            {
                BitScroll = Convert.ToInt32(txtBitCount.Value);
               
                BitScroll *= Offset;
                xPullLength = BitScroll + xRows;
                Offset = BitScroll;
                if (xPullLength > FileData.Length)
                {
                    xPullLength -= FileData.Length;
                    xRows -= xPullLength;
                }
            }
           
            DataPool = FileData.Substring(Offset, xRows);
        }

        private void CheckHeight()
        {
            int lCap, FLength;
            CalWholeNumber CWN = new CalWholeNumber();
            if (FileData != "NoData")
            {
                FLength = FileData.Length;
                xDraw = true;
                
            }

            decimal BitCount;
            int DrawWidth;

            BitCount = txtBitCount.Value;
            pnlDrawContainer.Height = CWN.RoundData(Convert.ToInt32(Math.Round(Convert.ToDecimal(this.Height) - Convert.ToDecimal(130))));
            DrawWidth = Convert.ToInt32(Math.Round(Convert.ToDecimal(pnlDrawingBoard.Width) / Convert.ToDecimal(10)));
            xAxis = 0;
            yAxis = 0;

            lCap = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(BitCount) * pnlDrawingBoard.Height) / 10));//How Bits Can be drawn
            xBitCount = Convert.ToInt32(BitCount);
            if (lCap < FileData.Length +1)
            {
                int MaxScroll;
                MaxScroll = Convert.ToInt32(Math.Ceiling((Convert.ToDecimal(FileData.Length) - Convert.ToDecimal(lCap)) / Convert.ToDecimal(xBitCount)));
                vScrollbar.Visible = true;
                vScrollbar.Maximum = MaxScroll + 9;
                vScrollbar.Refresh();
                
                DataPull(gScrollValue, lCap);
            }
            else
            {
                vScrollbar.Visible = false;
                DataPull(0, FileData.Length);
            }
            txtBitCount.Maximum = DrawWidth;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            antiAliasToolStripMenuItem.Enabled = true;
            FileData = Properties.Resources.BinaryFile;
            xDraw = true;
            xAxis = 0;
            yAxis = 0;
            xBitCount = Convert.ToInt32(txtBitCount.Text);
            txtBitCount.Enabled = true;
            ReDraw();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SystemSettings.ChangeBackGroundColor();
           ReDraw();
        }

        private void tsmZero_Click(object sender, EventArgs e)
        {
            SystemSettings.ChangeBitColor(Convert.ToInt32(tsmZero.Text));
            ReDraw();
        }

        private void tsmOne_Click(object sender, EventArgs e)
        {
            SystemSettings.ChangeBitColor(Convert.ToInt32(tsmOne.Text));
            ReDraw();
        }

        private void lblLoadData_Click(object sender, EventArgs e)
        {
            OpenDataFile ODF = new OpenDataFile(this);
            ReadData(ODF.DataPull());
        }

        public void ReDraw()
        {
            CheckHeight();
            pnlDrawingBoard.Invalidate();
        }

        public void txtBitCount_ValueChanged(object sender, EventArgs e)
        {
            vScrollbar.Value = 0;
            gScrollValue = 0;
            ReDraw();
        }

        private void frmXBit_SizeChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aliasing = true;
            ReDraw();
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aliasing = false;
            ReDraw();
        }

        private int gScrollValue;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gScrollValue = e.NewValue;
            ReDraw();
        }

        private void pnlDrawingBoard_Paint(object sender, PaintEventArgs e)
        {
           
            int Count = 0;
            if (xDraw == true)
            {
                CurrentContext = BufferedGraphicsManager.Current;
                MyBuffer = CurrentContext.Allocate(e.Graphics, pnlDrawingBoard.DisplayRectangle);

                SystemSettings.Alaising(Aliasing);
                
                int BenLength;
                bool Safe = true;
                BenLength = DataPool.Length - 1;

                foreach(Object Obj in DataPool)
                {

                    int xConvert;

                    if (Count == xBitCount || xAxis > pnlDrawingBoard.Width - 10)
                    {
                        txtBitCount.Value = txtBitCount.Value;
                        if (yAxis != this.Height - 10)
                        {
                            xAxis = 0;
                            yAxis += 10;

                            xBitCount += Convert.ToInt32(txtBitCount.Text);
                        }
                    }
                  
                    if (Safe == true)
                    {
                        xConvert = Convert.ToInt32(DataPool.Substring(Count, 1));
                        if (xConvert == 0)
                        {
                            MyBuffer.Graphics.FillRectangle(new SolidBrush(SystemSettings.ZeroColor), xAxis, yAxis, 10, 10);
                        }
                        else
                        {
                            MyBuffer.Graphics.FillRectangle(new SolidBrush(SystemSettings.OneColor), xAxis, yAxis, 10, 10);
                        }
                    }
                    else
                    {
                        txtBitCount.Maximum = txtBitCount.Value;
                    }
        
                    xAxis += 10;
                    Count += 1;
                }
                MyBuffer.Render();
            }
        }

        private void frmXBit_MouseClick(object sender, MouseEventArgs e)
        {
            txtBitCount.Focus();
        }

        private void pnlDrawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            vScrollbar.Focus();
        }

        //private void pnlDrawingBoard_MouseDown(object sender, MouseEventArgs e)
        //{
          
        //    tmrValueUpdater.Enabled = true;
        //}

        //private void pnlDrawingBoard_MouseUp(object sender, MouseEventArgs e)
        //{
            
        //    tmrValueUpdater.Enabled = false;
           
        //}

        public string FilteredDate;
        private void button1_Click_1(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void lblFilter_Click(object sender, EventArgs e)
        {
            
        }

       
        //private void lnkAddFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    lbFilterNames.Items.Add(txtFilterCode.Text);
        //    txtFilterCode.Clear();
        //}


        private void lblFilterClose_Click(object sender, EventArgs e)
        {
            //pnlCreateNew.Visible = false;
        }

        private void pnlDrawingBoard_MouseClick_1(object sender, MouseEventArgs e)
        {

        }


        private void lnkAddToStack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //lbFilterStack.Items.Add(cbFilterList.Text);
        }

        private void pbIcon_Click(object sender, EventArgs e)
        {
            SystemFilters.Load_Filter();
            SystemFilters.PullFilterData(SystemFilters.cbCodeList);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SystemFilters.Load_Filter();
        }

        private void binaryConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.GetTempPath() + "Binary_Converter_2_0.exe";
            File.WriteAllBytes(path,Properties.Resources.Binary_Converter_2_0);//);myProjectName.Properties.Resources.myExecutable);
            System.Diagnostics.Process.Start(path);
        }

        private void lblAddToStack_Click(object sender, EventArgs e)
        {
            sysStack.AddToStack(cbFilterList.Text);
        }

        private void cbFilterList_Leave(object sender, EventArgs e)
        {
            SystemFilters.LeaveFilterList(cbFilterList);
        }

        private void cbFilterList_Click(object sender, EventArgs e)
        {
            SystemFilters.PullFilterData(cbFilterList);
        }

        private void tmrDragDrop_Tick(object sender, EventArgs e)
        {
            if (blnDragDrop == true)
            {
                SystemFilters.BinaryConverter.Location = new Point(SystemFilters.ReturnCalxPosition(), SystemFilters.ReturnCalyPosition());
            }
        }

        private void cbFilterList_DropDown(object sender, EventArgs e)
        {
            SystemFilters.PullFilterData(cbFilterList);
        }

        private void frmKryptBit_Load(object sender, EventArgs e)
        {

        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFilterList_Click_1(object sender, EventArgs e)
        {
            cbFilterList.Text = "";
        }
    }
}
