
namespace myFirstApp
{
    partial class CheckboxExample
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
            this.internetCheckbox = new System.Windows.Forms.CheckBox();
            this.lunchCheckbox = new System.Windows.Forms.CheckBox();
            this.swimmingCheckbox = new System.Windows.Forms.CheckBox();
            this.newspaperCheckbox = new System.Windows.Forms.CheckBox();
            this.servicesListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services";
            // 
            // internetCheckbox
            // 
            this.internetCheckbox.AutoSize = true;
            this.internetCheckbox.Location = new System.Drawing.Point(16, 30);
            this.internetCheckbox.Name = "internetCheckbox";
            this.internetCheckbox.Size = new System.Drawing.Size(83, 17);
            this.internetCheckbox.TabIndex = 1;
            this.internetCheckbox.Text = "Internet 500";
            this.internetCheckbox.UseVisualStyleBackColor = true;
            this.internetCheckbox.CheckedChanged += new System.EventHandler(this.internetCheckbox_CheckedChanged);
            // 
            // lunchCheckbox
            // 
            this.lunchCheckbox.AutoSize = true;
            this.lunchCheckbox.Location = new System.Drawing.Point(16, 54);
            this.lunchCheckbox.Name = "lunchCheckbox";
            this.lunchCheckbox.Size = new System.Drawing.Size(77, 17);
            this.lunchCheckbox.TabIndex = 2;
            this.lunchCheckbox.Text = "Lunch 450";
            this.lunchCheckbox.UseVisualStyleBackColor = true;
            this.lunchCheckbox.CheckedChanged += new System.EventHandler(this.lunchCheckbox_CheckedChanged);
            // 
            // swimmingCheckbox
            // 
            this.swimmingCheckbox.AutoSize = true;
            this.swimmingCheckbox.Location = new System.Drawing.Point(16, 101);
            this.swimmingCheckbox.Name = "swimmingCheckbox";
            this.swimmingCheckbox.Size = new System.Drawing.Size(100, 17);
            this.swimmingCheckbox.TabIndex = 4;
            this.swimmingCheckbox.Text = "Swimming 1000";
            this.swimmingCheckbox.UseVisualStyleBackColor = true;
            this.swimmingCheckbox.CheckedChanged += new System.EventHandler(this.swimmingCheckbox_CheckedChanged);
            // 
            // newspaperCheckbox
            // 
            this.newspaperCheckbox.AutoSize = true;
            this.newspaperCheckbox.Location = new System.Drawing.Point(16, 77);
            this.newspaperCheckbox.Name = "newspaperCheckbox";
            this.newspaperCheckbox.Size = new System.Drawing.Size(95, 17);
            this.newspaperCheckbox.TabIndex = 3;
            this.newspaperCheckbox.Text = "Newspaper 30";
            this.newspaperCheckbox.UseVisualStyleBackColor = true;
            this.newspaperCheckbox.CheckedChanged += new System.EventHandler(this.newspaperCheckbox_CheckedChanged);
            // 
            // servicesListbox
            // 
            this.servicesListbox.FormattingEnabled = true;
            this.servicesListbox.Location = new System.Drawing.Point(128, 30);
            this.servicesListbox.Name = "servicesListbox";
            this.servicesListbox.Size = new System.Drawing.Size(120, 95);
            this.servicesListbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bill";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(213, 132);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(0, 13);
            this.billLabel.TabIndex = 8;
            // 
            // CheckboxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servicesListbox);
            this.Controls.Add(this.swimmingCheckbox);
            this.Controls.Add(this.newspaperCheckbox);
            this.Controls.Add(this.lunchCheckbox);
            this.Controls.Add(this.internetCheckbox);
            this.Controls.Add(this.label1);
            this.Name = "CheckboxExample";
            this.Text = "CheckboxExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox internetCheckbox;
        private System.Windows.Forms.CheckBox lunchCheckbox;
        private System.Windows.Forms.CheckBox swimmingCheckbox;
        private System.Windows.Forms.CheckBox newspaperCheckbox;
        private System.Windows.Forms.ListBox servicesListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label billLabel;
    }
}