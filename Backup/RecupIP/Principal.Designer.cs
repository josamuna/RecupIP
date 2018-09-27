namespace RecupIP
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblElement1 = new System.Windows.Forms.Label();
            this.rtfContent = new System.Windows.Forms.RichTextBox();
            this.CmdLoadFile = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cmdIntitialise = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblElement2 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFormatText = new System.Windows.Forms.TextBox();
            this.cboTypeGenerate = new System.Windows.Forms.ComboBox();
            this.chkMerge = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTypeGenerate);
            this.groupBox1.Controls.Add(this.lblElement1);
            this.groupBox1.Controls.Add(this.rtfContent);
            this.groupBox1.Controls.Add(this.CmdLoadFile);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cmdGenerate);
            this.groupBox1.Controls.Add(this.cmdIntitialise);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charger un fichier";
            // 
            // lblElement1
            // 
            this.lblElement1.BackColor = System.Drawing.Color.White;
            this.lblElement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblElement1.Location = new System.Drawing.Point(352, 285);
            this.lblElement1.Name = "lblElement1";
            this.lblElement1.Size = new System.Drawing.Size(164, 21);
            this.lblElement1.TabIndex = 11;
            this.lblElement1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtfContent
            // 
            this.rtfContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfContent.Location = new System.Drawing.Point(9, 46);
            this.rtfContent.Name = "rtfContent";
            this.rtfContent.ReadOnly = true;
            this.rtfContent.Size = new System.Drawing.Size(507, 230);
            this.rtfContent.TabIndex = 9;
            this.rtfContent.Text = "";
            // 
            // CmdLoadFile
            // 
            this.CmdLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLoadFile.Location = new System.Drawing.Point(482, 19);
            this.CmdLoadFile.Name = "CmdLoadFile";
            this.CmdLoadFile.Size = new System.Drawing.Size(34, 23);
            this.CmdLoadFile.TabIndex = 1;
            this.CmdLoadFile.Text = "....";
            this.CmdLoadFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdLoadFile.UseVisualStyleBackColor = true;
            this.CmdLoadFile.Click += new System.EventHandler(this.CmdLoadFile_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(155, 285);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(69, 23);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "&Enregistrer";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(83, 285);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(69, 23);
            this.cmdGenerate.TabIndex = 6;
            this.cmdGenerate.Text = "&Générer";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdIntitialise
            // 
            this.cmdIntitialise.Location = new System.Drawing.Point(10, 285);
            this.cmdIntitialise.Name = "cmdIntitialise";
            this.cmdIntitialise.Size = new System.Drawing.Size(69, 23);
            this.cmdIntitialise.TabIndex = 8;
            this.cmdIntitialise.Text = "&Réinitialiser";
            this.cmdIntitialise.UseVisualStyleBackColor = true;
            this.cmdIntitialise.Click += new System.EventHandler(this.cmdIntitialise_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(9, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(467, 20);
            this.txtPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chkMerge);
            this.groupBox2.Controls.Add(this.lblElement2);
            this.groupBox2.Controls.Add(this.lstResult);
            this.groupBox2.Location = new System.Drawing.Point(541, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat";
            // 
            // lblElement2
            // 
            this.lblElement2.BackColor = System.Drawing.Color.White;
            this.lblElement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblElement2.Location = new System.Drawing.Point(12, 285);
            this.lblElement2.Name = "lblElement2";
            this.lblElement2.Size = new System.Drawing.Size(164, 21);
            this.lblElement2.TabIndex = 10;
            this.lblElement2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstResult
            // 
            this.lstResult.BackColor = System.Drawing.Color.Snow;
            this.lstResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.ForeColor = System.Drawing.Color.DimGray;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(12, 17);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(164, 229);
            this.lstResult.TabIndex = 8;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Fichier texte (*.txt)|*.txt";
            this.dlgOpen.InitialDirectory = ".";
            this.dlgOpen.Title = "Ouvrir un fichier";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "txt";
            this.dlgSave.Filter = "Fichier texte (*.txt)|*.txt";
            this.dlgSave.InitialDirectory = ".";
            this.dlgSave.Title = "Enregister un fichier";
            // 
            // txtFormatText
            // 
            this.txtFormatText.Location = new System.Drawing.Point(9, 328);
            this.txtFormatText.Multiline = true;
            this.txtFormatText.Name = "txtFormatText";
            this.txtFormatText.Size = new System.Drawing.Size(720, 28);
            this.txtFormatText.TabIndex = 12;
            this.txtFormatText.Enter += new System.EventHandler(this.txtFormatText_Enter);
            // 
            // cboTypeGenerate
            // 
            this.cboTypeGenerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeGenerate.FormattingEnabled = true;
            this.cboTypeGenerate.Location = new System.Drawing.Point(230, 286);
            this.cboTypeGenerate.Name = "cboTypeGenerate";
            this.cboTypeGenerate.Size = new System.Drawing.Size(116, 21);
            this.cboTypeGenerate.TabIndex = 12;
            // 
            // chkMerge
            // 
            this.chkMerge.AutoSize = true;
            this.chkMerge.Location = new System.Drawing.Point(16, 258);
            this.chkMerge.Name = "chkMerge";
            this.chkMerge.Size = new System.Drawing.Size(157, 17);
            this.chkMerge.TabIndex = 11;
            this.chkMerge.Text = "Fusionner tous les doublons";
            this.chkMerge.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 361);
            this.Controls.Add(this.txtFormatText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reformatage adresses IP";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdIntitialise;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button CmdLoadFile;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.RichTextBox rtfContent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lblElement1;
        private System.Windows.Forms.Label lblElement2;
        private System.Windows.Forms.TextBox txtFormatText;
        private System.Windows.Forms.ComboBox cboTypeGenerate;
        private System.Windows.Forms.CheckBox chkMerge;
        private System.Windows.Forms.Button button1;

    }
}

