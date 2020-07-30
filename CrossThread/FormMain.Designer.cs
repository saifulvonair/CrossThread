namespace CrossThread
{
    partial class FormMain
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnThread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(156, 45);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(157, 77);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(98, 23);
            this.btnThread.TabIndex = 1;
            this.btnThread.Text = "StartThread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Value";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.txtStatus);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross-Thread(saiful_vonair@yahoo.com)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Label label1;
    }
}

