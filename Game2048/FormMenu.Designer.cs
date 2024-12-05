
namespace Game2048
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlay.Image")));
            this.pictureBoxPlay.Location = new System.Drawing.Point(85, 238);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(425, 119);
            this.pictureBoxPlay.TabIndex = 0;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            this.pictureBoxPlay.MouseEnter += new System.EventHandler(this.pictureBoxPlay_MouseEnter);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.pictureBoxPlay_MouseLeave);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(85, 364);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(425, 119);
            this.pictureBoxSettings.TabIndex = 1;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            this.pictureBoxSettings.MouseEnter += new System.EventHandler(this.pictureBoxSettings_MouseEnter);
            this.pictureBoxSettings.MouseLeave += new System.EventHandler(this.pictureBoxSettings_MouseLeave);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(85, 489);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(425, 119);
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click_1);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 110.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(88, -18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 195);
            this.label1.TabIndex = 3;
            this.label1.Text = "2048";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(600, 646);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.pictureBoxPlay);
            this.Name = "FormMenu";
            this.ShowIcon = false;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label1;
    }
}

