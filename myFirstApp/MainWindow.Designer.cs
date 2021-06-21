
namespace myFirstApp
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.num1Text = new System.Windows.Forms.TextBox();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num1ErrorLabel = new System.Windows.Forms.Label();
            this.num2ErrorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // num1Text
            // 
            this.num1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num1Text.Location = new System.Drawing.Point(12, 39);
            this.num1Text.MaxLength = 10;
            this.num1Text.Name = "num1Text";
            this.num1Text.Size = new System.Drawing.Size(225, 23);
            this.num1Text.TabIndex = 1;
            this.num1Text.TextChanged += new System.EventHandler(this.num1Text_TextChanged);
            // 
            // num2Text
            // 
            this.num2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num2Text.Location = new System.Drawing.Point(12, 84);
            this.num2Text.MaxLength = 10;
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(225, 23);
            this.num2Text.TabIndex = 3;
            this.num2Text.TextChanged += new System.EventHandler(this.num2Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(162, 113);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resultText
            // 
            this.resultText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultText.Location = new System.Drawing.Point(12, 159);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(225, 23);
            this.resultText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // num1ErrorLabel
            // 
            this.num1ErrorLabel.AutoSize = true;
            this.num1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1ErrorLabel.Location = new System.Drawing.Point(215, 14);
            this.num1ErrorLabel.Name = "num1ErrorLabel";
            this.num1ErrorLabel.Size = new System.Drawing.Size(29, 37);
            this.num1ErrorLabel.TabIndex = 7;
            this.num1ErrorLabel.Text = "*";
            this.num1ErrorLabel.Visible = false;
            // 
            // num2ErrorLabel
            // 
            this.num2ErrorLabel.AutoSize = true;
            this.num2ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2ErrorLabel.Location = new System.Drawing.Point(215, 60);
            this.num2ErrorLabel.Name = "num2ErrorLabel";
            this.num2ErrorLabel.Size = new System.Drawing.Size(29, 37);
            this.num2ErrorLabel.TabIndex = 8;
            this.num2ErrorLabel.Text = "*";
            this.num2ErrorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(162, 188);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 226);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1ErrorLabel);
            this.Controls.Add(this.num2ErrorLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1Text;
        private System.Windows.Forms.TextBox num2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label num1ErrorLabel;
        private System.Windows.Forms.Label num2ErrorLabel;
        private System.Windows.Forms.Button backButton;
    }
}

