namespace Visilitsa
{
    partial class Game
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
            this.label_for_word = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.new_game_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_for_word
            // 
            this.label_for_word.AutoSize = true;
            this.label_for_word.BackColor = System.Drawing.Color.Transparent;
            this.label_for_word.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_for_word.Location = new System.Drawing.Point(47, 19);
            this.label_for_word.Name = "label_for_word";
            this.label_for_word.Size = new System.Drawing.Size(0, 35);
            this.label_for_word.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::Visilitsa.Properties.Resources.start;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(500, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(325, 363);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.Color.Transparent;
            this.new_game_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_game_button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_game_button.Location = new System.Drawing.Point(289, 347);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(177, 43);
            this.new_game_button.TabIndex = 2;
            this.new_game_button.Text = "Новая игра";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.New_Game_Button_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visilitsa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 428);
            this.Controls.Add(this.new_game_button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_for_word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_Closed);
            this.Shown += new System.EventHandler(this.Game_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_for_word;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button new_game_button;
    }
}

