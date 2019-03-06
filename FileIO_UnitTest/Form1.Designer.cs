namespace FileIO_UnitTest {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnUploadData = new System.Windows.Forms.Button();
            this.btnEncryptText = new System.Windows.Forms.Button();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Location = new System.Drawing.Point(11, 12);
            this.tbxUserInput.Multiline = true;
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.Size = new System.Drawing.Size(500, 250);
            this.tbxUserInput.TabIndex = 0;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 267);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(121, 50);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save Text to txt File";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnUploadData
            // 
            this.btnUploadData.Location = new System.Drawing.Point(136, 267);
            this.btnUploadData.Name = "btnUploadData";
            this.btnUploadData.Size = new System.Drawing.Size(121, 50);
            this.btnUploadData.TabIndex = 2;
            this.btnUploadData.Text = "Upload txt File";
            this.btnUploadData.UseVisualStyleBackColor = true;
            this.btnUploadData.Click += new System.EventHandler(this.btnUploadData_Click);
            // 
            // btnEncryptText
            // 
            this.btnEncryptText.Location = new System.Drawing.Point(263, 267);
            this.btnEncryptText.Name = "btnEncryptText";
            this.btnEncryptText.Size = new System.Drawing.Size(121, 50);
            this.btnEncryptText.TabIndex = 3;
            this.btnEncryptText.Text = "Encrypt Text";
            this.btnEncryptText.UseVisualStyleBackColor = true;
            this.btnEncryptText.Click += new System.EventHandler(this.btnEncryptText_Click);
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.Location = new System.Drawing.Point(390, 267);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(121, 50);
            this.btnDecryptText.TabIndex = 4;
            this.btnDecryptText.Text = "Decrypt Text";
            this.btnDecryptText.UseVisualStyleBackColor = true;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.btnDecryptText);
            this.Controls.Add(this.btnEncryptText);
            this.Controls.Add(this.btnUploadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.tbxUserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserInput;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnUploadData;
        private System.Windows.Forms.Button btnEncryptText;
        private System.Windows.Forms.Button btnDecryptText;
    }
}

