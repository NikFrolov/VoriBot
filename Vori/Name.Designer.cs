namespace Vori
{
    partial class NameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.GRButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 12);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(227, 40);
            this.NameTextBox.TabIndex = 0;
            // 
            // ReadyButton
            // 
            this.ReadyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadyButton.Location = new System.Drawing.Point(12, 54);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(227, 34);
            this.ReadyButton.TabIndex = 1;
            this.ReadyButton.Text = "Готово";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GRButton
            // 
            this.GRButton.BackColor = System.Drawing.Color.Red;
            this.GRButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GRButton.ForeColor = System.Drawing.Color.White;
            this.GRButton.Location = new System.Drawing.Point(12, 104);
            this.GRButton.Name = "GRButton";
            this.GRButton.Size = new System.Drawing.Size(227, 34);
            this.GRButton.TabIndex = 2;
            this.GRButton.Text = "Получить root";
            this.GRButton.UseVisualStyleBackColor = false;
            this.GRButton.Click += new System.EventHandler(this.GRButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 54);
            this.PasswordTextBox.MaximumSize = new System.Drawing.Size(227, 40);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(227, 40);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(227, 40);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Visible = false;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 74);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.GRButton);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.NameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(267, 143);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите имя!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Button GRButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}