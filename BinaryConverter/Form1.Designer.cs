namespace BinaryConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectFileToConvertToBinary = new System.Windows.Forms.Button();
            this.lblFilePathToConvert = new System.Windows.Forms.Label();
            this.txtFileToConvertToBinary = new System.Windows.Forms.TextBox();
            this.btnConvertToBinary = new System.Windows.Forms.Button();
            this.lblOperationResultToBinary = new System.Windows.Forms.Label();
            this.pnlToBinary = new System.Windows.Forms.Panel();
            this.txtBinaryName = new System.Windows.Forms.TextBox();
            this.pnlToFile = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.lblBinaryPathToConvert = new System.Windows.Forms.Label();
            this.btnSelectBinaryToConvertToFile = new System.Windows.Forms.Button();
            this.txtBinaryToConvertToFile = new System.Windows.Forms.TextBox();
            this.btnConvertToFile = new System.Windows.Forms.Button();
            this.lblOperationResultToFile = new System.Windows.Forms.Label();
            this.pnlToBinary.SuspendLayout();
            this.pnlToFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFileToConvertToBinary
            // 
            this.btnSelectFileToConvertToBinary.Location = new System.Drawing.Point(653, 62);
            this.btnSelectFileToConvertToBinary.Name = "btnSelectFileToConvertToBinary";
            this.btnSelectFileToConvertToBinary.Size = new System.Drawing.Size(91, 64);
            this.btnSelectFileToConvertToBinary.TabIndex = 0;
            this.btnSelectFileToConvertToBinary.Text = "Select file to convert to binary";
            this.btnSelectFileToConvertToBinary.UseVisualStyleBackColor = true;
            this.btnSelectFileToConvertToBinary.Click += new System.EventHandler(this.btnSelectFileToConvertToBinary_Click);
            // 
            // lblFilePathToConvert
            // 
            this.lblFilePathToConvert.AutoSize = true;
            this.lblFilePathToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePathToConvert.Location = new System.Drawing.Point(9, 12);
            this.lblFilePathToConvert.Name = "lblFilePathToConvert";
            this.lblFilePathToConvert.Size = new System.Drawing.Size(138, 18);
            this.lblFilePathToConvert.TabIndex = 2;
            this.lblFilePathToConvert.Text = "File Path to Convert";
            // 
            // txtFileToConvertToBinary
            // 
            this.txtFileToConvertToBinary.Location = new System.Drawing.Point(12, 88);
            this.txtFileToConvertToBinary.Name = "txtFileToConvertToBinary";
            this.txtFileToConvertToBinary.Size = new System.Drawing.Size(635, 20);
            this.txtFileToConvertToBinary.TabIndex = 3;
            this.txtFileToConvertToBinary.TextChanged += new System.EventHandler(this.txtFileToConvertToBinary_TextChanged);
            // 
            // btnConvertToBinary
            // 
            this.btnConvertToBinary.Location = new System.Drawing.Point(205, 114);
            this.btnConvertToBinary.Name = "btnConvertToBinary";
            this.btnConvertToBinary.Size = new System.Drawing.Size(442, 32);
            this.btnConvertToBinary.TabIndex = 4;
            this.btnConvertToBinary.Text = "Convert";
            this.btnConvertToBinary.UseVisualStyleBackColor = true;
            this.btnConvertToBinary.Click += new System.EventHandler(this.btnConvertToBinary_Click);
            // 
            // lblOperationResultToBinary
            // 
            this.lblOperationResultToBinary.AutoSize = true;
            this.lblOperationResultToBinary.Location = new System.Drawing.Point(12, 149);
            this.lblOperationResultToBinary.Name = "lblOperationResultToBinary";
            this.lblOperationResultToBinary.Size = new System.Drawing.Size(89, 13);
            this.lblOperationResultToBinary.TabIndex = 5;
            this.lblOperationResultToBinary.Text = "Operation Result:";
            // 
            // pnlToBinary
            // 
            this.pnlToBinary.Controls.Add(this.txtBinaryName);
            this.pnlToBinary.Controls.Add(this.lblFilePathToConvert);
            this.pnlToBinary.Controls.Add(this.btnSelectFileToConvertToBinary);
            this.pnlToBinary.Controls.Add(this.txtFileToConvertToBinary);
            this.pnlToBinary.Controls.Add(this.btnConvertToBinary);
            this.pnlToBinary.Controls.Add(this.lblOperationResultToBinary);
            this.pnlToBinary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToBinary.Location = new System.Drawing.Point(0, 0);
            this.pnlToBinary.Name = "pnlToBinary";
            this.pnlToBinary.Size = new System.Drawing.Size(771, 237);
            this.pnlToBinary.TabIndex = 6;
            // 
            // txtBinaryName
            // 
            this.txtBinaryName.Location = new System.Drawing.Point(15, 121);
            this.txtBinaryName.Name = "txtBinaryName";
            this.txtBinaryName.Size = new System.Drawing.Size(184, 20);
            this.txtBinaryName.TabIndex = 7;
            this.txtBinaryName.Text = "File name (default: binaryOutput)";
            // 
            // pnlToFile
            // 
            this.pnlToFile.Controls.Add(this.txtFileName);
            this.pnlToFile.Controls.Add(this.txtFileExtension);
            this.pnlToFile.Controls.Add(this.lblBinaryPathToConvert);
            this.pnlToFile.Controls.Add(this.btnSelectBinaryToConvertToFile);
            this.pnlToFile.Controls.Add(this.txtBinaryToConvertToFile);
            this.pnlToFile.Controls.Add(this.btnConvertToFile);
            this.pnlToFile.Controls.Add(this.lblOperationResultToFile);
            this.pnlToFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToFile.Location = new System.Drawing.Point(0, 267);
            this.pnlToFile.Name = "pnlToFile";
            this.pnlToFile.Size = new System.Drawing.Size(771, 241);
            this.pnlToFile.TabIndex = 6;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 144);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(184, 20);
            this.txtFileName.TabIndex = 7;
            this.txtFileName.Text = "File name (default: fileOutput)";
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Location = new System.Drawing.Point(202, 144);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(184, 20);
            this.txtFileExtension.TabIndex = 7;
            this.txtFileExtension.Text = "Extension type (default .exe)";
            // 
            // lblBinaryPathToConvert
            // 
            this.lblBinaryPathToConvert.AutoSize = true;
            this.lblBinaryPathToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryPathToConvert.Location = new System.Drawing.Point(9, 12);
            this.lblBinaryPathToConvert.Name = "lblBinaryPathToConvert";
            this.lblBinaryPathToConvert.Size = new System.Drawing.Size(156, 18);
            this.lblBinaryPathToConvert.TabIndex = 2;
            this.lblBinaryPathToConvert.Text = "Binary Path to Convert";
            // 
            // btnSelectBinaryToConvertToFile
            // 
            this.btnSelectBinaryToConvertToFile.Location = new System.Drawing.Point(653, 85);
            this.btnSelectBinaryToConvertToFile.Name = "btnSelectBinaryToConvertToFile";
            this.btnSelectBinaryToConvertToFile.Size = new System.Drawing.Size(91, 64);
            this.btnSelectBinaryToConvertToFile.TabIndex = 0;
            this.btnSelectBinaryToConvertToFile.Text = "Select binary to convert to file";
            this.btnSelectBinaryToConvertToFile.UseVisualStyleBackColor = true;
            this.btnSelectBinaryToConvertToFile.Click += new System.EventHandler(this.btnSelectBinaryToConvertToFile_Click);
            // 
            // txtBinaryToConvertToFile
            // 
            this.txtBinaryToConvertToFile.Location = new System.Drawing.Point(12, 111);
            this.txtBinaryToConvertToFile.Name = "txtBinaryToConvertToFile";
            this.txtBinaryToConvertToFile.Size = new System.Drawing.Size(635, 20);
            this.txtBinaryToConvertToFile.TabIndex = 3;
            this.txtBinaryToConvertToFile.TextChanged += new System.EventHandler(this.txtBinaryToConvertToFile_TextChanged);
            // 
            // btnConvertToFile
            // 
            this.btnConvertToFile.Location = new System.Drawing.Point(392, 137);
            this.btnConvertToFile.Name = "btnConvertToFile";
            this.btnConvertToFile.Size = new System.Drawing.Size(255, 32);
            this.btnConvertToFile.TabIndex = 4;
            this.btnConvertToFile.Text = "Convert";
            this.btnConvertToFile.UseVisualStyleBackColor = true;
            this.btnConvertToFile.Click += new System.EventHandler(this.btnConvertToFile_Click);
            // 
            // lblOperationResultToFile
            // 
            this.lblOperationResultToFile.AutoSize = true;
            this.lblOperationResultToFile.Location = new System.Drawing.Point(12, 172);
            this.lblOperationResultToFile.Name = "lblOperationResultToFile";
            this.lblOperationResultToFile.Size = new System.Drawing.Size(89, 13);
            this.lblOperationResultToFile.TabIndex = 5;
            this.lblOperationResultToFile.Text = "Operation Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 508);
            this.Controls.Add(this.pnlToBinary);
            this.Controls.Add(this.pnlToFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Binary File Converter";
            this.pnlToBinary.ResumeLayout(false);
            this.pnlToBinary.PerformLayout();
            this.pnlToFile.ResumeLayout(false);
            this.pnlToFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFileToConvertToBinary;
        private System.Windows.Forms.Label lblFilePathToConvert;
        private System.Windows.Forms.TextBox txtFileToConvertToBinary;
        private System.Windows.Forms.Button btnConvertToBinary;
        private System.Windows.Forms.Label lblOperationResultToBinary;
        private System.Windows.Forms.Panel pnlToBinary;
        private System.Windows.Forms.Panel pnlToFile;
        private System.Windows.Forms.Label lblBinaryPathToConvert;
        private System.Windows.Forms.Button btnSelectBinaryToConvertToFile;
        private System.Windows.Forms.TextBox txtBinaryToConvertToFile;
        private System.Windows.Forms.Button btnConvertToFile;
        private System.Windows.Forms.Label lblOperationResultToFile;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtBinaryName;
    }
}

