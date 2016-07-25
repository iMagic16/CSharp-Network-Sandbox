namespace GenericServerBasedGameTest_Server
{
    partial class Server
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
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.TxtCmdToSend = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(13, 13);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(259, 219);
            this.TxtOutput.TabIndex = 0;
            // 
            // TxtCmdToSend
            // 
            this.TxtCmdToSend.Location = new System.Drawing.Point(75, 238);
            this.TxtCmdToSend.Name = "TxtCmdToSend";
            this.TxtCmdToSend.Size = new System.Drawing.Size(167, 20);
            this.TxtCmdToSend.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(249, 238);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(23, 20);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtCmdToSend);
            this.Controls.Add(this.TxtOutput);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.TextBox TxtCmdToSend;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label1;
    }
}