namespace GenMapper
{
    partial class DebInfo
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
            this.textBox_mouse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cubeid = new System.Windows.Forms.TextBox();
            this.label3_info = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse:";
            // 
            // textBox_mouse
            // 
            this.textBox_mouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mouse.Location = new System.Drawing.Point(12, 30);
            this.textBox_mouse.Multiline = true;
            this.textBox_mouse.Name = "textBox_mouse";
            this.textBox_mouse.ReadOnly = true;
            this.textBox_mouse.Size = new System.Drawing.Size(282, 40);
            this.textBox_mouse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cube ID:";
            // 
            // textBox_cubeid
            // 
            this.textBox_cubeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cubeid.Location = new System.Drawing.Point(12, 90);
            this.textBox_cubeid.Multiline = true;
            this.textBox_cubeid.Name = "textBox_cubeid";
            this.textBox_cubeid.ReadOnly = true;
            this.textBox_cubeid.Size = new System.Drawing.Size(282, 20);
            this.textBox_cubeid.TabIndex = 3;
            // 
            // label3_info
            // 
            this.label3_info.AutoSize = true;
            this.label3_info.Location = new System.Drawing.Point(9, 113);
            this.label3_info.Name = "label3_info";
            this.label3_info.Size = new System.Drawing.Size(25, 13);
            this.label3_info.TabIndex = 4;
            this.label3_info.Text = "Info";
            // 
            // textBox_info
            // 
            this.textBox_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_info.Location = new System.Drawing.Point(12, 130);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_info.Size = new System.Drawing.Size(282, 146);
            this.textBox_info.TabIndex = 5;
            this.textBox_info.WordWrap = false;
            // 
            // DebInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 288);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label3_info);
            this.Controls.Add(this.textBox_cubeid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_mouse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebInfo";
            this.ShowInTaskbar = false;
            this.Text = "DebInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cubeid;
        private System.Windows.Forms.Label label3_info;
        private System.Windows.Forms.TextBox textBox_info;
    }
}