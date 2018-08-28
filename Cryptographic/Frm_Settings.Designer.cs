namespace Cryptographic
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
            this.textDecDir = new System.Windows.Forms.TextBox();
            this.btnSelectEncDir = new System.Windows.Forms.Button();
            this.btnSelectDecDir = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.txtEncDir.Size = new System.Drawing.Size(369, 20);
            this.txtEncDir.TabIndex = 2;
            // 
            // textDecDir
            // 
            this.textDecDir.Location = new System.Drawing.Point(135, 53);
            this.textDecDir.Name = "textDecDir";
            this.textDecDir.Size = new System.Drawing.Size(369, 20);
            this.textDecDir.TabIndex = 3;
            // 
            // btnSelectEncDir
            // 
            this.btnSelectEncDir.Location = new System.Drawing.Point(510, 25);
            this.btnSelectEncDir.Name = "btnSelectEncDir";
            this.btnSelectEncDir.Size = new System.Drawing.Size(40, 23);
            this.btnSelectEncDir.TabIndex = 4;
            this.btnSelectEncDir.Text = "...";
            this.btnSelectEncDir.UseVisualStyleBackColor = true;
            // 
            // btnSelectDecDir
            // 
            this.btnSelectDecDir.Location = new System.Drawing.Point(510, 51);
            this.btnSelectDecDir.Name = "btnSelectDecDir";
            this.btnSelectDecDir.Size = new System.Drawing.Size(40, 25);
            this.btnSelectDecDir.TabIndex = 5;
            this.btnSelectDecDir.Text = "...";
            this.btnSelectDecDir.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 102);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectDecDir);
            this.Controls.Add(this.btnSelectEncDir);
            this.Controls.Add(this.textDecDir);
            this.Controls.Add(this.txtEncDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncDir;
        private System.Windows.Forms.TextBox textDecDir;
        private System.Windows.Forms.Button btnSelectEncDir;
        private System.Windows.Forms.Button btnSelectDecDir;
        private System.Windows.Forms.Button btnSave;
    }
}