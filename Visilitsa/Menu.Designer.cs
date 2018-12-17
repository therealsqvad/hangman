namespace Visilitsa
{
    partial class Menu
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
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.dictEdit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_pictureBox.BackgroundImage = global::Visilitsa.Properties.Resources.start;
            this.logo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_pictureBox.Location = new System.Drawing.Point(230, 32);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(325, 363);
            this.logo_pictureBox.TabIndex = 1;
            this.logo_pictureBox.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Transparent;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(42, 34);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(177, 45);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Начать игру";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help_button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_button.Location = new System.Drawing.Point(42, 100);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(177, 45);
            this.help_button.TabIndex = 2;
            this.help_button.Text = "Правила";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // dictEdit_button
            // 
            this.dictEdit_button.BackColor = System.Drawing.Color.Transparent;
            this.dictEdit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dictEdit_button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictEdit_button.Location = new System.Drawing.Point(42, 166);
            this.dictEdit_button.Name = "dictEdit_button";
            this.dictEdit_button.Size = new System.Drawing.Size(177, 45);
            this.dictEdit_button.TabIndex = 2;
            this.dictEdit_button.Text = "Редактор";
            this.dictEdit_button.UseVisualStyleBackColor = false;
            this.dictEdit_button.Click += new System.EventHandler(this.DictEdit_Button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visilitsa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 428);
            this.Controls.Add(this.dictEdit_button);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.logo_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button dictEdit_button;
    }
}

