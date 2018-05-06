namespace Vori
{
    partial class NeiroNet
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
            this.NeiroLearnTextBox = new System.Windows.Forms.TextBox();
            this.NeiroLearnButton = new System.Windows.Forms.Button();
            this.CancelNeiroLearnButton = new System.Windows.Forms.Button();
            this.BuildAnAnswerButton = new System.Windows.Forms.Button();
            this.WrongLearnAnswerButton = new System.Windows.Forms.Button();
            this.HelpingButton = new System.Windows.Forms.Button();
            this.NeiroAnswerLabel = new System.Windows.Forms.Label();
            this.KeyWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeiroLearnTextBox
            // 
            this.NeiroLearnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NeiroLearnTextBox.Location = new System.Drawing.Point(12, 12);
            this.NeiroLearnTextBox.Name = "NeiroLearnTextBox";
            this.NeiroLearnTextBox.Size = new System.Drawing.Size(470, 20);
            this.NeiroLearnTextBox.TabIndex = 0;
            this.NeiroLearnTextBox.Text = "\"\"";
            // 
            // NeiroLearnButton
            // 
            this.NeiroLearnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NeiroLearnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NeiroLearnButton.Location = new System.Drawing.Point(12, 243);
            this.NeiroLearnButton.Name = "NeiroLearnButton";
            this.NeiroLearnButton.Size = new System.Drawing.Size(134, 23);
            this.NeiroLearnButton.TabIndex = 1;
            this.NeiroLearnButton.Text = "Сохранить";
            this.NeiroLearnButton.UseVisualStyleBackColor = false;
            this.NeiroLearnButton.Click += new System.EventHandler(this.NeiroLearnButton_Click);
            // 
            // CancelNeiroLearnButton
            // 
            this.CancelNeiroLearnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelNeiroLearnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelNeiroLearnButton.Location = new System.Drawing.Point(348, 243);
            this.CancelNeiroLearnButton.Name = "CancelNeiroLearnButton";
            this.CancelNeiroLearnButton.Size = new System.Drawing.Size(134, 23);
            this.CancelNeiroLearnButton.TabIndex = 2;
            this.CancelNeiroLearnButton.Text = "Отменить";
            this.CancelNeiroLearnButton.UseVisualStyleBackColor = false;
            this.CancelNeiroLearnButton.Click += new System.EventHandler(this.CancelNeiroLearnButton_Click);
            // 
            // BuildAnAnswerButton
            // 
            this.BuildAnAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BuildAnAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuildAnAnswerButton.Location = new System.Drawing.Point(12, 38);
            this.BuildAnAnswerButton.Name = "BuildAnAnswerButton";
            this.BuildAnAnswerButton.Size = new System.Drawing.Size(180, 23);
            this.BuildAnAnswerButton.TabIndex = 3;
            this.BuildAnAnswerButton.Text = "Автоматически построить ответ\r\n";
            this.BuildAnAnswerButton.UseVisualStyleBackColor = false;
            this.BuildAnAnswerButton.Click += new System.EventHandler(this.BuildAnAnswerButton_Click);
            // 
            // WrongLearnAnswerButton
            // 
            this.WrongLearnAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WrongLearnAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WrongLearnAnswerButton.Location = new System.Drawing.Point(261, 38);
            this.WrongLearnAnswerButton.Name = "WrongLearnAnswerButton";
            this.WrongLearnAnswerButton.Size = new System.Drawing.Size(221, 23);
            this.WrongLearnAnswerButton.TabIndex = 4;
            this.WrongLearnAnswerButton.Text = "Неверный ответ! Перегенирировать!\r\n";
            this.WrongLearnAnswerButton.UseVisualStyleBackColor = false;
            this.WrongLearnAnswerButton.Click += new System.EventHandler(this.WrongLearnAnswerButton_Click);
            // 
            // HelpingButton
            // 
            this.HelpingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HelpingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HelpingButton.Location = new System.Drawing.Point(200, 38);
            this.HelpingButton.Name = "HelpingButton";
            this.HelpingButton.Size = new System.Drawing.Size(55, 23);
            this.HelpingButton.TabIndex = 5;
            this.HelpingButton.UseVisualStyleBackColor = false;
            // 
            // NeiroAnswerLabel
            // 
            this.NeiroAnswerLabel.AutoSize = true;
            this.NeiroAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NeiroAnswerLabel.Location = new System.Drawing.Point(12, 64);
            this.NeiroAnswerLabel.Name = "NeiroAnswerLabel";
            this.NeiroAnswerLabel.Size = new System.Drawing.Size(154, 22);
            this.NeiroAnswerLabel.TabIndex = 6;
            this.NeiroAnswerLabel.Text = "\"Премер ответа.\"";
            // 
            // KeyWordButton
            // 
            this.KeyWordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.KeyWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyWordButton.Location = new System.Drawing.Point(152, 243);
            this.KeyWordButton.Name = "KeyWordButton";
            this.KeyWordButton.Size = new System.Drawing.Size(190, 23);
            this.KeyWordButton.TabIndex = 7;
            this.KeyWordButton.Text = "|X| Ключевое слово";
            this.KeyWordButton.UseVisualStyleBackColor = false;
            this.KeyWordButton.Click += new System.EventHandler(this.KeyWordButton_Click);
            // 
            // NeiroNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 278);
            this.ControlBox = false;
            this.Controls.Add(this.KeyWordButton);
            this.Controls.Add(this.NeiroAnswerLabel);
            this.Controls.Add(this.HelpingButton);
            this.Controls.Add(this.WrongLearnAnswerButton);
            this.Controls.Add(this.BuildAnAnswerButton);
            this.Controls.Add(this.CancelNeiroLearnButton);
            this.Controls.Add(this.NeiroLearnButton);
            this.Controls.Add(this.NeiroLearnTextBox);
            this.Name = "NeiroNet";
            this.Text = "Обучение нейронной сети (Vori)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NeiroLearnTextBox;
        private System.Windows.Forms.Button NeiroLearnButton;
        private System.Windows.Forms.Button CancelNeiroLearnButton;
        private System.Windows.Forms.Button BuildAnAnswerButton;
        private System.Windows.Forms.Button WrongLearnAnswerButton;
        private System.Windows.Forms.Button HelpingButton;
        private System.Windows.Forms.Label NeiroAnswerLabel;
        private System.Windows.Forms.Button KeyWordButton;
    }
}