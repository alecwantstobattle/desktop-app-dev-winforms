
namespace myFirstApp
{
    partial class ComboExample
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
            this.countriesDropdown = new System.Windows.Forms.ComboBox();
            this.citiesDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Countries";
            // 
            // countriesDropdown
            // 
            this.countriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesDropdown.FormattingEnabled = true;
            this.countriesDropdown.Items.AddRange(new object[] {
            "Pakistan",
            "China",
            "Canada",
            "Iran"});
            this.countriesDropdown.Location = new System.Drawing.Point(15, 26);
            this.countriesDropdown.Name = "countriesDropdown";
            this.countriesDropdown.Size = new System.Drawing.Size(220, 21);
            this.countriesDropdown.TabIndex = 0;
            this.countriesDropdown.SelectedIndexChanged += new System.EventHandler(this.countriesDropdown_SelectedIndexChanged);
            // 
            // citiesDropdown
            // 
            this.citiesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesDropdown.FormattingEnabled = true;
            this.citiesDropdown.Location = new System.Drawing.Point(15, 66);
            this.citiesDropdown.Name = "citiesDropdown";
            this.citiesDropdown.Size = new System.Drawing.Size(220, 21);
            this.citiesDropdown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cities";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 134);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(16, 13);
            this.answerLabel.TabIndex = 4;
            this.answerLabel.Text = "...";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(160, 93);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.itemListbox.Location = new System.Drawing.Point(15, 163);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(219, 95);
            this.itemListbox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(79, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add To List";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ComboExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.itemListbox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.citiesDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countriesDropdown);
            this.Controls.Add(this.label1);
            this.Name = "ComboExample";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countriesDropdown;
        private System.Windows.Forms.ComboBox citiesDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Button addButton;
    }
}