using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace xBit
{
    public partial class frmXBit : Form
    {
        public Color ZeroColor;
        public Color OneColor;

        private bool Aliasing;

        public int xAxis;
        public int yAxis;

        public frmXBit()
        {
           
            InitializeComponent();
            msXbit.BackColor = this.BackColor;
            msXbit.ForeColor = lblBits.ForeColor;
            FileData = "NoData";
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            AAOn.BackColor = Color.Gray;
            Aliasing = true;
            ZeroColor = Color.Red;
            OneColor = Color.Green;
            //label1.Text = pnlContainer.VerticalScroll.Value.ToString();
            
            xAxis = 0;
            yAxis = 0;
            xBitCount = Convert.ToInt32(txtBitCount.Text);
        }

        public void ReadData(string Path)
        {
            using (StreamReader DataReader = new StreamReader(Path))//Creates And Opens The File using The Path We Choose From the openfiledialogbox
            {
               
                FileData = Convert.ToString(DataReader.ReadToEnd());
            }
        }
      
       
       
        //Can Draw 45 Rows Before Going to A new Page.
        //YAxis = 440
        public bool xDraw;
        public String FileData;
        public int xBitCount;
        private BufferedGraphics MyBuffer;
        private BufferedGraphicsContext CurrentContext;
        
        
        private string DataPool;
        void DataPull(int Offset,int xRows)//440 is Max Y
        {
            if (xRows == 45)
            {

            }
            label2.Text = pnlDrawingBoard.Height.ToString();
            label3.Text = yAxis.ToString();
            lblRows.Text = xRows.ToString();
            DataPool = FileData.Substring(Offset, xRows);

        }

        void CheckHeight()
        {
            int lCap, FLength;
            if (FileData != "NoData")
            {
                FLength = FileData.Length;
                xDraw = true;
            }

            decimal BitCount;
            BitCount = txtBitCount.Value;
            pnlDrawingBoard.Width = this.Width - 60;
            pnlDrawingBoard.Height = this.Height - 130;
            vScrollbar.Location = new Point(pnlDrawingBoard.Width + 20, vScrollbar.Location.Y);
            xAxis = 0;
            yAxis = 0;

            lCap = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(FileData.Length) / Convert.ToDouble(txtBitCount.Value))));//How Many Rows
            //DataPull(0,lCap * Convert.ToInt32(BitCount));
            DataPull(0, lCap);
            
            xBitCount = Convert.ToInt32(txtBitCount.Value);

            //if (lCap > 45)
            //{
            //    vScrollbar.Visible = true;
            //    vScrollbar.Refresh();
            //    DataPull(0, lCap * Convert.ToInt32(BitCount));
            //    vScrollbar.Maximum = lCap;
            //}
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FileData = "100000000000000000000000000000000000000000001";
            lblyAxis.Text = FileData.Length.ToString();
            label1.Text = FileData.Length.ToString();
            xDraw = true;
            xAxis = 0;
            yAxis = 0;
            xBitCount = Convert.ToInt32(txtBitCount.Text);
            lblRows.Text = FileData.Length.ToString();
            txtBitCount.Enabled = true;
            
            ReDraw();
        }



        private void frmXBit_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = xBitColor();
            backgroundToolStripMenuItem.BackColor = this.BackColor;
            if (this.BackColor.ToString() == "Black")
            {
                backgroundToolStripMenuItem.ForeColor = Color.White;
                lblBits.ForeColor = Color.White;
            }
            else
            {
                backgroundToolStripMenuItem.ForeColor = Color.Black;
                lblBits.ForeColor = Color.Black;
            }
            pnlDrawingBoard.BackColor = this.BackColor;
            //pnlContainer.BackColor = this.BackColor;
            ReDraw();
        }

        private Color xBitColor()
        {
            Color MyColor;
            BitColor.ShowDialog();
            MyColor = BitColor.Color;
            return MyColor;
        }

        private void tsmZero_Click(object sender, EventArgs e)
        {
            ZeroColor = xBitColor();
            tsmZero.BackColor = ZeroColor;
            ReDraw();
        }

        private void tsmOne_Click(object sender, EventArgs e)
        {
            OneColor = xBitColor();
            tsmOne.BackColor = OneColor;
            ReDraw();
        }


        private void lblLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog BitData = new OpenFileDialog();//Creates OpenFileDialog Object in memory
            DialogResult BitDataResult = new DialogResult();

            BitData.DefaultExt = "txt";
            BitData.Filter = "Text files (*.txt)|*.txt";
            BitData.Title = "Choose A Binary File";
            BitDataResult = BitData.ShowDialog();//Creates The OpenFileDialogBox on screen
            if (BitDataResult == DialogResult.OK)
            {
                string fName;
                fName = BitData.FileName;//Pulls In My File Path From The OpenFileDialogBox
                ReadData(fName);//Passes The File Path To The ReadData Function
                txtBitCount.Enabled = true;
                ReDraw();
                lblyAxis.Text = yAxis.ToString();
            } 
        }

        void ReDraw()
        {
            CheckHeight();
            pnlDrawingBoard.Invalidate();
        }

        public void txtBitCount_ValueChanged(object sender, EventArgs e)
        {
            
            ReDraw();
        }

        private void frmXBit_SizeChanged(object sender, EventArgs e)
        {
            lblyAxis.Text = this.Height.ToString();
            ReDraw();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aliasing = true;
            AAOn.BackColor = Color.Gray;
            AAOff.BackColor = Color.White;
            ReDraw();
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aliasing = false;
            AAOff.BackColor = Color.Gray;
            AAOn.BackColor = Color.White;
            ReDraw();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollbar.Value.ToString();
            lblHeight.Text = vScrollbar.Maximum.ToString();
            ReDraw();
        }

        private void pnlDrawingBoard_Paint(object sender, PaintEventArgs e)
        {
            if (xDraw == true)
            {
                CurrentContext = BufferedGraphicsManager.Current;
                MyBuffer = CurrentContext.Allocate(e.Graphics, pnlDrawingBoard.DisplayRectangle);

                if (Aliasing == true)
                {
                    MyBuffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }

                int BenLength;
                //BenLength = DataPool.Length;
                BenLength = FileData.Length;

                for (int i = 0; i < BenLength; i++)
                {
                    int xConvert;

                    if (i == xBitCount || xAxis > pnlDrawingBoard.Width - 10)
                    {
                        txtBitCount.Value = txtBitCount.Value;//440 is the max Y
                        if (yAxis != this.Height - 10)
                        {
                            xAxis = 0;
                            yAxis += 10;
                            if (yAxis == 450)
                            {
                                MessageBox.Show("");
                            }
                            xBitCount += Convert.ToInt32(txtBitCount.Text);
                        }
                    }

                    xConvert = Convert.ToInt32(FileData.Substring(i, 1));

                    if (xConvert == 0)
                    {
                        MyBuffer.Graphics.FillRectangle(new SolidBrush(ZeroColor), xAxis, yAxis, 10, 10);
                    }
                    else
                    {
                        MyBuffer.Graphics.FillRectangle(new SolidBrush(OneColor), xAxis, yAxis, 10, 10);
                    }

                    xAxis += 10;
                }
                MyBuffer.Render();
            }
        }
    }
}
