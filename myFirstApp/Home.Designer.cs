
namespace myFirstApp
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckboxButton = new System.Windows.Forms.Button();
            this.RadioButtonsButton = new System.Windows.Forms.Button();
            this.ComboBoxButton = new System.Windows.Forms.Button();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 91);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to My Software";
            // 
            // CheckboxButton
            // 
            this.CheckboxButton.FlatAppearance.BorderSize = 2;
            this.CheckboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckboxButton.Location = new System.Drawing.Point(17, 26);
            this.CheckboxButton.Name = "CheckboxButton";
            this.CheckboxButton.Size = new System.Drawing.Size(90, 36);
            this.CheckboxButton.TabIndex = 1;
            this.CheckboxButton.Text = "CheckBox";
            this.CheckboxButton.UseVisualStyleBackColor = true;
            this.CheckboxButton.Click += new System.EventHandler(this.CheckboxButton_Click);
            // 
            // RadioButtonsButton
            // 
            this.RadioButtonsButton.FlatAppearance.BorderSize = 2;
            this.RadioButtonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButtonsButton.Location = new System.Drawing.Point(17, 68);
            this.RadioButtonsButton.Name = "RadioButtonsButton";
            this.RadioButtonsButton.Size = new System.Drawing.Size(90, 36);
            this.RadioButtonsButton.TabIndex = 2;
            this.RadioButtonsButton.Text = "Radio Buttons";
            this.RadioButtonsButton.UseVisualStyleBackColor = true;
            this.RadioButtonsButton.Click += new System.EventHandler(this.RadioButtonsButton_Click);
            // 
            // ComboBoxButton
            // 
            this.ComboBoxButton.FlatAppearance.BorderSize = 2;
            this.ComboBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxButton.Location = new System.Drawing.Point(17, 110);
            this.ComboBoxButton.Name = "ComboBoxButton";
            this.ComboBoxButton.Size = new System.Drawing.Size(90, 36);
            this.ComboBoxButton.TabIndex = 3;
            this.ComboBoxButton.Text = "Combo Box";
            this.ComboBoxButton.UseVisualStyleBackColor = true;
            this.ComboBoxButton.Click += new System.EventHandler(this.ComboBoxButton_Click);
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.FlatAppearance.BorderSize = 2;
            this.MainWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowButton.Location = new System.Drawing.Point(17, 152);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Padding = new System.Windows.Forms.Padding(20);
            this.MainWindowButton.Size = new System.Drawing.Size(90, 97);
            this.MainWindowButton.TabIndex = 4;
            this.MainWindowButton.Text = "Main Window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckboxButton);
            this.panel2.Controls.Add(this.MainWindowButton);
            this.panel2.Controls.Add(this.RadioButtonsButton);
            this.panel2.Controls.Add(this.ComboBoxButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 359);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(130, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 359);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(664, 334);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckboxButton;
        private System.Windows.Forms.Button RadioButtonsButton;
        private System.Windows.Forms.Button ComboBoxButton;
        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}