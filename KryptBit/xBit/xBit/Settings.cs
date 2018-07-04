using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace KryptBit
{
    public class Settings
    {
        private ColorDialog BitColor = new ColorDialog();
        private frmKryptBit MainForm;
        public Color ZeroColor;
        public Color OneColor;
        
        private Color BitColorDialog()
        {
            Color MyColor;
            BitColor.ShowDialog();
            MyColor = BitColor.Color;
            return MyColor;
        }

        public Settings(frmKryptBit frmMainForm)
        {
            MainForm = frmMainForm;
            ZeroColor = Properties.Settings.Default.Zero;
            OneColor = Properties.Settings.Default.One;
        }

        public void ChangeBitColor(int Bit)
        {
            
            if (Bit == 1)
            {
                Properties.Settings.Default.One = BitColorDialog();
                OneColor = Properties.Settings.Default.One;
                MainForm.tsmOne.BackColor = OneColor;
            }
            else
            {
                Properties.Settings.Default.Zero = BitColorDialog();
                ZeroColor = Properties.Settings.Default.Zero;
                MainForm.tsmZero.BackColor = ZeroColor;
            }
        }

        public void ChangeBackGroundColor()
        {
            Properties.Settings.Default.Background = BitColorDialog();
            MainForm.BackColor = Properties.Settings.Default.Background;
            MainForm.msXbit.BackColor = MainForm.BackColor;
            MainForm.bitToolStripMenuItem.BackColor = MainForm.msXbit.BackColor;
            MainForm.backgroundToolStripMenuItem.BackColor = MainForm.msXbit.BackColor;
            MainForm.antiAliasToolStripMenuItem.BackColor = MainForm.msXbit.BackColor;
            MainForm.binaryConverterToolStripMenuItem.BackColor = MainForm.msXbit.BackColor;
            MainForm.pnlDrawingBoard.BackColor = MainForm.BackColor;
        }

        public void Alaising(bool AliasOn)
        {
            if (AliasOn == true)
            {
                frmKryptBit.MyBuffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                MainForm.AAOn.BackColor = Color.Red;
                MainForm.AAOff.BackColor = Color.Black;
            }
            else
            {
                MainForm.AAOn.BackColor = Color.Black;
                MainForm.AAOff.BackColor = Color.Red;
            }
        }

        //public List<Label> Rulerlbl = new List<Label>();
        //public void Ruler(bool Toggle)
        //{
          
        //    if (Toggle == true)
        //    {
        //        Label RulerCount = new Label();
        //        Rulerlbl.Add(RulerCount);
        //        //Rulerlbl.Add(RulerCount);
        //        MainForm.Controls.Add(Rulerlbl.ElementAt(0));
        //        Rulerlbl.ElementAt(0).Name = "RulerX";
        //        Rulerlbl.ElementAt(0).ForeColor = Color.White;
        //        Rulerlbl.ElementAt(0).Location = new Point(MainForm.gbBitCount.Location.X + 1, 85);
        //        Rulerlbl.ElementAt(0).Size = new System.Drawing.Size(MainForm.pnlDrawingBoard.Size.Width, 15);
        //        Rulerlbl.ElementAt(0).BorderStyle = BorderStyle.FixedSingle;
        //        Rulerlbl.ElementAt(0).Font = new Font("Times New Roman", 9);
        //        Rulerlbl.ElementAt(0).Text = "";
        //        for (int i = 0; i <= MainForm.txtBitCount.Value - 1; i++)
        //        {
        //            Rulerlbl.ElementAt(0).Text += "|" + "  ";
        //        }
                
        //        Rulerlbl.ElementAt(0).BringToFront();
        //        MainForm.pnlDrawContainer.Location = new Point(17, 99);
        //    }
        //    else
        //    {
        //        Rulerlbl.ElementAt(0).Dispose();
        //        Rulerlbl.RemoveAt(0);
        //        MainForm.pnlDrawContainer.Location = new Point(17, 87);
        //    }
        //}

        public string Filter(int FormX,int FormY,string xPool)
        {

            int Count = 1;
            String Edit;
            StringBuilder PoolData = new StringBuilder();
            ArrayList lstPools = new ArrayList();
            List<string> lstPool = new List<string>();

            foreach (object pobj in xPool)
            {
                PoolData.Append(pobj.ToString());
                if (Count == MainForm.txtBitCount.Value)
                {
                    lstPool.Add(PoolData.ToString());
                    PoolData.Clear();
                    Count = 1;
                }
                else
                {
                    Count += 1;
                }
            }

            if (PoolData.Length > 0)
            {
                lstPool.Add(PoolData.ToString());
                PoolData.Clear();
            }

            Edit = lstPool[FormY].Substring(FormX, 1);
            Edit = "x";
            Count = lstPool[FormY].Length;
            lstPool[FormY] = lstPool[FormY].Remove(FormX, 1);
            lstPool[FormY] = lstPool[FormY].Insert(FormX, Edit);
            PoolData.Clear();
            for (int h = 0; h <= lstPool.Count - 1; h++)
            {
                PoolData.Append(lstPool[h]);
            }
            return PoolData.ToString();
        }
    }
}
