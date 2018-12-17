namespace Visilitsa
{
    partial class DictEdit
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
            this.start_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.Word_List = new System.Windows.Forms.ListBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Del_Button = new System.Windows.Forms.Button();
            this.Add_TextBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // Word_List
            // 
            this.Word_List.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word_List.FormattingEnabled = true;
            this.Word_List.ItemHeight = 27;
            this.Word_List.Location = new System.Drawing.Point(229, 32);
            this.Word_List.Name = "Word_List";
            this.Word_List.Size = new System.Drawing.Size(326, 247);
            this.Word_List.TabIndex = 3;
            this.Word_List.SelectedIndexChanged += new System.EventHandler(this.Word_List_Select);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(42, 166);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(177, 45);
            this.Add_Button.TabIndex = 5;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.Del_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Del_Button.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_Button.Location = new System.Drawing.Point(42, 232);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(177, 45);
            this.Del_Button.TabIndex = 4;
            this.Del_Button.Text = "Удалить";
            this.Del_Button.UseVisualStyleBackColor = false;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // Add_TextBox
            // 
            this.Add_TextBox.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_TextBox.Location = new System.Drawing.Point(42, 298);
            this.Add_TextBox.Name = "Add_TextBox";
            this.Add_TextBox.Size = new System.Drawing.Size(302, 44);
            this.Add_TextBox.TabIndex = 6;
            this.Add_TextBox.Visible = false;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_button.Location = new System.Drawing.Point(351, 298);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(60, 45);
            this.OK_button.TabIndex = 7;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Visible = false;
            this.OK_button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // DictEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visilitsa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 428);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Add_TextBox);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Word_List);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DictEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DictEdit_Closed);
            this.Load += new System.EventHandler(this.DictEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.ListBox Word_List;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.TextBox Add_TextBox;
        private System.Windows.Forms.Button OK_button;
    }
}

