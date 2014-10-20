namespace vdp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonVacinar = new System.Windows.Forms.Button();
            this.linkRA = new System.Windows.Forms.LinkLabel();
            this.buttonFormatar = new System.Windows.Forms.Button();
            this.buttonDisableAR = new System.Windows.Forms.Button();
            this.buttonScanDisk = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.diskSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonEnableAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVacinar
            // 
            this.buttonVacinar.Location = new System.Drawing.Point(12, 12);
            this.buttonVacinar.Name = "buttonVacinar";
            this.buttonVacinar.Size = new System.Drawing.Size(97, 40);
            this.buttonVacinar.TabIndex = 0;
            this.buttonVacinar.Text = "Vacinar pendrive";
            this.buttonVacinar.UseVisualStyleBackColor = true;
            this.buttonVacinar.Click += new System.EventHandler(this.buttonVacinar_Click);
            // 
            // linkRA
            // 
            this.linkRA.AutoSize = true;
            this.linkRA.Location = new System.Drawing.Point(82, 194);
            this.linkRA.Name = "linkRA";
            this.linkRA.Size = new System.Drawing.Size(98, 13);
            this.linkRA.TabIndex = 1;
            this.linkRA.TabStop = true;
            this.linkRA.Tag = "";
            this.linkRA.Text = "Visite o redeaberta!";
            this.linkRA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRA_LinkClicked);
            // 
            // buttonFormatar
            // 
            this.buttonFormatar.Location = new System.Drawing.Point(12, 72);
            this.buttonFormatar.Name = "buttonFormatar";
            this.buttonFormatar.Size = new System.Drawing.Size(97, 40);
            this.buttonFormatar.TabIndex = 2;
            this.buttonFormatar.Text = "Remover vacina do pendrive";
            this.buttonFormatar.UseVisualStyleBackColor = true;
            this.buttonFormatar.Click += new System.EventHandler(this.buttonFormatar_Click);
            // 
            // buttonDisableAR
            // 
            this.buttonDisableAR.Location = new System.Drawing.Point(152, 12);
            this.buttonDisableAR.Name = "buttonDisableAR";
            this.buttonDisableAR.Size = new System.Drawing.Size(97, 40);
            this.buttonDisableAR.TabIndex = 4;
            this.buttonDisableAR.Text = "Vacinar computador";
            this.buttonDisableAR.UseVisualStyleBackColor = true;
            this.buttonDisableAR.Click += new System.EventHandler(this.buttonDisableAR_Click);
            // 
            // buttonScanDisk
            // 
            this.buttonScanDisk.Location = new System.Drawing.Point(80, 130);
            this.buttonScanDisk.Name = "buttonScanDisk";
            this.buttonScanDisk.Size = new System.Drawing.Size(100, 40);
            this.buttonScanDisk.TabIndex = 5;
            this.buttonScanDisk.Text = "Procurar e corrigir erros no pendrive";
            this.buttonScanDisk.UseVisualStyleBackColor = true;
            this.buttonScanDisk.Click += new System.EventHandler(this.buttonScanDisk_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // diskSelect
            // 
            this.diskSelect.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.diskSelect.ShowNewFolderButton = false;
            this.diskSelect.Tag = " ";
            // 
            // buttonEnableAR
            // 
            this.buttonEnableAR.Location = new System.Drawing.Point(152, 72);
            this.buttonEnableAR.Name = "buttonEnableAR";
            this.buttonEnableAR.Size = new System.Drawing.Size(97, 40);
            this.buttonEnableAR.TabIndex = 7;
            this.buttonEnableAR.Text = "Remover vacina do computador";
            this.buttonEnableAR.UseVisualStyleBackColor = true;
            this.buttonEnableAR.Click += new System.EventHandler(this.buttonEnableAR_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(262, 219);
            this.Controls.Add(this.buttonEnableAR);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonScanDisk);
            this.Controls.Add(this.buttonDisableAR);
            this.Controls.Add(this.buttonFormatar);
            this.Controls.Add(this.linkRA);
            this.Controls.Add(this.buttonVacinar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacina de pendrives 3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVacinar;
        private System.Windows.Forms.LinkLabel linkRA;
        private System.Windows.Forms.Button buttonFormatar;
        private System.Windows.Forms.Button buttonDisableAR;
        private System.Windows.Forms.Button buttonScanDisk;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog diskSelect;
        private System.Windows.Forms.Button buttonEnableAR;
    }
}

