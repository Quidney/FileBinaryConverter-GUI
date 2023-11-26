using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        string pathInputFile;

        string pathInputBinary;
        public Form1()
        {
            InitializeComponent();
        }

        #region ToBinary
        private void btnSelectFileToConvertToBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileToConvertToBinary.Text = openFileDialog1.FileName;
            }
        }
        private void txtFileToConvertToBinary_TextChanged(object sender, EventArgs e)
        {
            pathInputFile = txtFileToConvertToBinary.Text;

            lblFilePathToConvert.Text = "File Path to Convert: " + pathInputFile;
        }
        private void btnConvertToBinary_Click(object sender, EventArgs e)
        {
            string binaryName = "binaryOutput";

            if (!txtBinaryName.Text.StartsWith("File name (default: binaryOutput)"))
            {
                binaryName = txtBinaryName.Text;
            }

            string fullName = binaryName + ".txt";
            string pathOutputBinary = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + fullName);

            try
            {
                byte[] fileData = File.ReadAllBytes(pathInputFile);
                string binaryText = Convert.ToBase64String(fileData);

                File.WriteAllText(pathOutputBinary, binaryText);

                lblOperationResultToBinary.Text = "Operation Result: Success! Binary Output: " + pathOutputBinary;
            }
            catch (Exception ex)
            {
                lblOperationResultToBinary.Text = "Operation Result: " + ex.Message;
            }

        }
        #endregion

        #region ToFile
        private void btnSelectBinaryToConvertToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBinaryToConvertToFile.Text = openFileDialog1.FileName;
            }
        }
        private void txtBinaryToConvertToFile_TextChanged(object sender, EventArgs e)
        {
            pathInputBinary = txtBinaryToConvertToFile.Text;

            lblBinaryPathToConvert.Text = "Binary Path to Convert: " + pathInputBinary;
        }

        private void btnConvertToFile_Click(object sender, EventArgs e)
        {
            string fileName = "fileOutput";
            string fileExtension = ".exe";

            if (txtFileExtension.Text.StartsWith("."))
            {
                fileExtension = txtFileExtension.Text;
            }
            if (!txtFileName.Text.StartsWith("File name (default: fileOutput)"))
            {
                fileName = txtFileName.Text;
            }

            string fullFile = fileName + fileExtension;
            string pathOutputFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + fullFile);

            try
            {
                string binaryText = File.ReadAllText(pathInputBinary);
                byte[] fileData = Convert.FromBase64String(binaryText);

                File.WriteAllBytes(pathOutputFile, fileData);

                lblOperationResultToFile.Text = pathOutputFile;
            }
            catch (Exception ex)
            {
                lblOperationResultToFile.Text = "Operation Result: " + ex.Message;
            }

        }
        #endregion


    }
}
