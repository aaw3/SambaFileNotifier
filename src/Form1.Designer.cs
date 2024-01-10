
namespace SambaFileDetection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drivesTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drivesChangeApplyBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MuteCB = new System.Windows.Forms.CheckBox();
            this.LoggerTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // drivesTxt
            // 
            this.drivesTxt.Location = new System.Drawing.Point(12, 41);
            this.drivesTxt.Name = "drivesTxt";
            this.drivesTxt.Size = new System.Drawing.Size(100, 23);
            this.drivesTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "CSV List of Drives";
            // 
            // drivesChangeApplyBtn
            // 
            this.drivesChangeApplyBtn.Location = new System.Drawing.Point(118, 40);
            this.drivesChangeApplyBtn.Name = "drivesChangeApplyBtn";
            this.drivesChangeApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.drivesChangeApplyBtn.TabIndex = 1;
            this.drivesChangeApplyBtn.Text = "Apply";
            this.drivesChangeApplyBtn.UseVisualStyleBackColor = true;
            this.drivesChangeApplyBtn.Click += new System.EventHandler(this.drivesChangeApplyBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // MuteCB
            // 
            this.MuteCB.AutoSize = true;
            this.MuteCB.Location = new System.Drawing.Point(212, 43);
            this.MuteCB.Name = "MuteCB";
            this.MuteCB.Size = new System.Drawing.Size(54, 19);
            this.MuteCB.TabIndex = 2;
            this.MuteCB.Text = "Mute";
            this.MuteCB.UseVisualStyleBackColor = true;
            // 
            // LoggerTxt
            // 
            this.LoggerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggerTxt.BackColor = System.Drawing.Color.White;
            this.LoggerTxt.Location = new System.Drawing.Point(12, 70);
            this.LoggerTxt.Name = "LoggerTxt";
            this.LoggerTxt.ReadOnly = true;
            this.LoggerTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.LoggerTxt.Size = new System.Drawing.Size(776, 368);
            this.LoggerTxt.TabIndex = 3;
            this.LoggerTxt.Text = "Debugger:";
            this.LoggerTxt.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LoggerTxt_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoggerTxt);
            this.Controls.Add(this.MuteCB);
            this.Controls.Add(this.drivesChangeApplyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drivesTxt);
            this.Name = "Form1";
            this.Text = "SambaFileDetection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drivesTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drivesChangeApplyBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.CheckBox MuteCB;
        private System.Windows.Forms.RichTextBox LoggerTxt;
    }
}

