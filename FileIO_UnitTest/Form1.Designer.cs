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
            this.SuspendLayout();
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Location = new System.Drawing.Point(12, 12);
            this.tbxUserInput.Multiline = true;
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.Size = new System.Drawing.Size(500, 250);
            this.tbxUserInput.TabIndex = 0;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 268);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(150, 50);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save Text to txt File";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnUploadData
            // 
            this.btnUploadData.Location = new System.Drawing.Point(168, 268);
            this.btnUploadData.Name = "btnUploadData";
            this.btnUploadData.Size = new System.Drawing.Size(150, 50);
            this.btnUploadData.TabIndex = 2;
            this.btnUploadData.Text = "Upload txt File";
            this.btnUploadData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 329);
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
    }
}

