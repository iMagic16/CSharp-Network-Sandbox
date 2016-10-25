namespace GenericServerBasedGameTest_Client
{
    partial class Client
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtCmdToSend = new System.Windows.Forms.TextBox();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(249, 233);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(23, 20);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtCmdToSend
            // 
            this.TxtCmdToSend.Location = new System.Drawing.Point(12, 233);
            this.TxtCmdToSend.Name = "TxtCmdToSend";
            this.TxtCmdToSend.Size = new System.Drawing.Size(230, 20);
            this.TxtCmdToSend.TabIndex = 4;
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(13, 8);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(259, 173);
            this.TxtOutput.TabIndex = 3;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtCmdToSend);
            this.Controls.Add(this.TxtOutput);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtCmdToSend;
        private System.Windows.Forms.TextBox TxtOutput;
    }
}