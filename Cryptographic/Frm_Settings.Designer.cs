namespace Cryptographic.UI
{
    partial class Frm_Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncDir = new System.Windows.Forms.TextBox();
            this.txtDecDir = new System.Windows.Forms.TextBox();
            this.btnSelectEncDir = new System.Windows.Forms.Button();
            this.btnSelectDecDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectPubKeyDir = new System.Windows.Forms.Button();
            this.txtPubKeyDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypted Files Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrypted Files Directory";
            // 
            // txtEncDir
            // 
            this.txtEncDir.Location = new System.Drawing.Point(135, 26);
            this.txtEncDir.Name = "txtEncDir";
            this.txtEncDir.ReadOnly = true;
            this.txtEncDir.Size = new System.Drawing.Size(369, 20);
            this.txtEncDir.TabIndex = 2;
            // 
            // txtDecDir
            // 
            this.txtDecDir.Location = new System.Drawing.Point(135, 53);
            this.txtDecDir.Name = "txtDecDir";
            this.txtDecDir.ReadOnly = true;
            this.txtDecDir.Size = new System.Drawing.Size(369, 20);
            this.txtDecDir.TabIndex = 3;
            // 
            // btnSelectEncDir
            // 
            this.btnSelectEncDir.Location = new System.Drawing.Point(510, 25);
            this.btnSelectEncDir.Name = "btnSelectEncDir";
            this.btnSelectEncDir.Size = new System.Drawing.Size(40, 23);
            this.btnSelectEncDir.TabIndex = 4;
            this.btnSelectEncDir.Text = "...";
            this.btnSelectEncDir.UseVisualStyleBackColor = true;
            this.btnSelectEncDir.Click += new System.EventHandler(this.btnSelectEncDir_Click);
            // 
            // btnSelectDecDir
            // 
            this.btnSelectDecDir.Location = new System.Drawing.Point(510, 51);
            this.btnSelectDecDir.Name = "btnSelectDecDir";
            this.btnSelectDecDir.Size = new System.Drawing.Size(40, 25);
            this.btnSelectDecDir.TabIndex = 5;
            this.btnSelectDecDir.Text = "...";
            this.btnSelectDecDir.UseVisualStyleBackColor = true;
            this.btnSelectDecDir.Click += new System.EventHandler(this.btnSelectDecDir_Click);
            // 
            // btnSelectPubKeyDir
            // 
            this.btnSelectPubKeyDir.Location = new System.Drawing.Point(510, 78);
            this.btnSelectPubKeyDir.Name = "btnSelectPubKeyDir";
            this.btnSelectPubKeyDir.Size = new System.Drawing.Size(40, 25);
            this.btnSelectPubKeyDir.TabIndex = 8;
            this.btnSelectPubKeyDir.Text = "...";
            this.btnSelectPubKeyDir.UseVisualStyleBackColor = true;
            this.btnSelectPubKeyDir.Click += new System.EventHandler(this.btnSelectPubKeyDir_Click);
            // 
            // txtPubKeyDir
            // 
            this.txtPubKeyDir.Location = new System.Drawing.Point(135, 80);
            this.txtPubKeyDir.Name = "txtPubKeyDir";
            this.txtPubKeyDir.ReadOnly = true;
            this.txtPubKeyDir.Size = new System.Drawing.Size(369, 20);
            this.txtPubKeyDir.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public Key File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 134);
            this.Controls.Add(this.btnSelectPubKeyDir);
            this.Controls.Add(this.txtPubKeyDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectDecDir);
            this.Controls.Add(this.btnSelectEncDir);
            this.Controls.Add(this.txtDecDir);
            this.Controls.Add(this.txtEncDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncDir;
        private System.Windows.Forms.TextBox txtDecDir;
        private System.Windows.Forms.Button btnSelectEncDir;
        private System.Windows.Forms.Button btnSelectDecDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button btnSelectPubKeyDir;
        private System.Windows.Forms.TextBox txtPubKeyDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}