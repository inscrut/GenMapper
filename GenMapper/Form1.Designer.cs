namespace GenMapper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapBox.Location = new System.Drawing.Point(12, 12);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(500, 500);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.Click += new System.EventHandler(this.MapBox_Click);
            this.MapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MapBox_Paint);
            this.MapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapBox_MouseMove);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(522, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(100, 30);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(522, 48);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 524);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.MapBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator map";
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
    }
}

