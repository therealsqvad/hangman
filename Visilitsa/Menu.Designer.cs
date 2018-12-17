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
            this.logo = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.DictEdit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Visilitsa.Properties.Resources.start;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Location = new System.Drawing.Point(230, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(325, 363);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
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
            // DictEdit_button
            // 
            this.DictEdit_button.BackColor = System.Drawing.Color.Transparent;
            this.DictEdit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DictEdit_button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictEdit_button.Location = new System.Drawing.Point(42, 166);
            this.DictEdit_button.Name = "DictEdit_button";
            this.DictEdit_button.Size = new System.Drawing.Size(177, 45);
            this.DictEdit_button.TabIndex = 2;
            this.DictEdit_button.Text = "Редактор";
            this.DictEdit_button.UseVisualStyleBackColor = false;
            this.DictEdit_button.Click += new System.EventHandler(this.DictEdit_Button);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visilitsa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 428);
            this.Controls.Add(this.DictEdit_button);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button DictEdit_button;
    }
}

