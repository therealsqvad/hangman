namespace Visilitsa
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.title_label = new System.Windows.Forms.Label();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.rules_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(34, 3);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(159, 48);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Правила";
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_pictureBox.BackgroundImage = global::Visilitsa.Properties.Resources.start;
            this.logo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_pictureBox.Location = new System.Drawing.Point(500, 53);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(325, 363);
            this.logo_pictureBox.TabIndex = 1;
            this.logo_pictureBox.TabStop = false;
            // 
            // rules_label
            // 
            this.rules_label.BackColor = System.Drawing.Color.Transparent;
            this.rules_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_label.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules_label.Location = new System.Drawing.Point(12, 56);
            this.rules_label.Name = "rules_label";
            this.rules_label.Size = new System.Drawing.Size(482, 397);
            this.rules_label.TabIndex = 3;
            this.rules_label.Text = resources.GetString("rules_label.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visilitsa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 461);
            this.Controls.Add(this.rules_label);
            this.Controls.Add(this.logo_pictureBox);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Label rules_label;
    }
}

