using System.Windows.Forms;

namespace KryptBit
{
    class OpenDataFile
    {
        private string fName;
        private frmKryptBit MainForm;

        public OpenDataFile(frmKryptBit frmMainForm)
        {
            MainForm = frmMainForm;
            fName = "NoData";
        }

        public string DataPull()
        {
            OpenFileDialog BitData = new OpenFileDialog();//Creates OpenFileDialog Object in memory
            DialogResult BitDataResult = new DialogResult();

            BitData.DefaultExt = "txt";
            BitData.Filter = "Text files (*.txt)|*.txt";
            BitData.Title = "Choose A Binary File";
            BitDataResult = BitData.ShowDialog();//Creates The OpenFileDialogBox on screen

            if (BitDataResult == DialogResult.OK)
            {
                fName = BitData.FileName;//Pulls In My File Path From The OpenFileDialogBox
                MainForm.txtBitCount.Enabled = true;
            }
            return fName;
        }
    }
}
