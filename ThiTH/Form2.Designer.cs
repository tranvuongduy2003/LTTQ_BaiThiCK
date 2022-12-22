namespace ThiTH
{
    partial class Form2
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
            this.cancleButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận Thoát?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancleButton.Location = new System.Drawing.Point(20, 81);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 32);
            this.cancleButton.TabIndex = 1;
            this.cancleButton.Text = "Không";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.handleCancle);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Red;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.acceptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptButton.Location = new System.Drawing.Point(113, 81);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 32);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Có";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.handleAccept);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button acceptButton;
    }
}