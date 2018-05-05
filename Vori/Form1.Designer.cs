namespace Vori
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HearVoriButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RefishButton = new System.Windows.Forms.Button();
            this.HeardWorldLabel = new System.Windows.Forms.Label();
            this.NeiroLearnButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RootLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HearVoriButton
            // 
            this.HearVoriButton.BackColor = System.Drawing.Color.White;
            this.HearVoriButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HearVoriButton.BackgroundImage")));
            this.HearVoriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HearVoriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HearVoriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HearVoriButton.Location = new System.Drawing.Point(6, 358);
            this.HearVoriButton.Name = "HearVoriButton";
            this.HearVoriButton.Size = new System.Drawing.Size(82, 80);
            this.HearVoriButton.TabIndex = 2;
            this.HearVoriButton.UseVisualStyleBackColor = false;
            this.HearVoriButton.Click += new System.EventHandler(this.HearVoriButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AboutButton.Location = new System.Drawing.Point(0, 1);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "О проэкте";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(340, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RefishButton
            // 
            this.RefishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RefishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefishButton.ForeColor = System.Drawing.Color.Black;
            this.RefishButton.Location = new System.Drawing.Point(250, 1);
            this.RefishButton.Name = "RefishButton";
            this.RefishButton.Size = new System.Drawing.Size(94, 23);
            this.RefishButton.TabIndex = 5;
            this.RefishButton.Text = "Перезагрузка";
            this.RefishButton.UseVisualStyleBackColor = false;
            this.RefishButton.Click += new System.EventHandler(this.RefishButton_Click);
            // 
            // HeardWorldLabel
            // 
            this.HeardWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeardWorldLabel.Location = new System.Drawing.Point(0, 27);
            this.HeardWorldLabel.Name = "HeardWorldLabel";
            this.HeardWorldLabel.Size = new System.Drawing.Size(363, 328);
            this.HeardWorldLabel.TabIndex = 1;
            // 
            // NeiroLearnButton
            // 
            this.NeiroLearnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NeiroLearnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NeiroLearnButton.ForeColor = System.Drawing.Color.Black;
            this.NeiroLearnButton.Location = new System.Drawing.Point(159, 1);
            this.NeiroLearnButton.Name = "NeiroLearnButton";
            this.NeiroLearnButton.Size = new System.Drawing.Size(94, 23);
            this.NeiroLearnButton.TabIndex = 6;
            this.NeiroLearnButton.Text = "Обучить Н.С.\r\n\r\n\r\n";
            this.NeiroLearnButton.UseVisualStyleBackColor = false;
            this.NeiroLearnButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(71, 1);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранение";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RootLabel
            // 
            this.RootLabel.AutoSize = true;
            this.RootLabel.BackColor = System.Drawing.Color.White;
            this.RootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RootLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RootLabel.Location = new System.Drawing.Point(105, 414);
            this.RootLabel.Name = "RootLabel";
            this.RootLabel.Size = new System.Drawing.Size(0, 24);
            this.RootLabel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RootLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NeiroLearnButton);
            this.Controls.Add(this.RefishButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HearVoriButton);
            this.Controls.Add(this.HeardWorldLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 489);
            this.MinimumSize = new System.Drawing.Size(381, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vori (Русский голосовой ассистент)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HearVoriButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RefishButton;
        private System.Windows.Forms.Label HeardWorldLabel;
        private System.Windows.Forms.Button NeiroLearnButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label RootLabel;
    }
}

