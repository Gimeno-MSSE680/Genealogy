namespace Presentation
{
    partial class FormFather
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
            this.checkBoxFatherKnown = new System.Windows.Forms.CheckBox();
            this.labelFFirstName = new System.Windows.Forms.Label();
            this.labelFLastName = new System.Windows.Forms.Label();
            this.labelFGivenName = new System.Windows.Forms.Label();
            this.textBoxFFirstName = new System.Windows.Forms.TextBox();
            this.textBoxFLastName = new System.Windows.Forms.TextBox();
            this.textBoxFGivenName = new System.Windows.Forms.TextBox();
            this.buttonAddFather = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxFatherKnown
            // 
            this.checkBoxFatherKnown.AutoSize = true;
            this.checkBoxFatherKnown.Checked = true;
            this.checkBoxFatherKnown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFatherKnown.Location = new System.Drawing.Point(12, 12);
            this.checkBoxFatherKnown.Name = "checkBoxFatherKnown";
            this.checkBoxFatherKnown.Size = new System.Drawing.Size(203, 21);
            this.checkBoxFatherKnown.TabIndex = 1;
            this.checkBoxFatherKnown.Text = "check box if father is known";
            this.checkBoxFatherKnown.UseVisualStyleBackColor = true;
            this.checkBoxFatherKnown.CheckedChanged += new System.EventHandler(this.checkBoxFatherKnown_CheckedChanged);
            // 
            // labelFFirstName
            // 
            this.labelFFirstName.AutoSize = true;
            this.labelFFirstName.Location = new System.Drawing.Point(20, 48);
            this.labelFFirstName.Name = "labelFFirstName";
            this.labelFFirstName.Size = new System.Drawing.Size(129, 17);
            this.labelFFirstName.TabIndex = 2;
            this.labelFFirstName.Text = "Father\'s first name:";
            // 
            // labelFLastName
            // 
            this.labelFLastName.AutoSize = true;
            this.labelFLastName.Location = new System.Drawing.Point(21, 80);
            this.labelFLastName.Name = "labelFLastName";
            this.labelFLastName.Size = new System.Drawing.Size(128, 17);
            this.labelFLastName.TabIndex = 3;
            this.labelFLastName.Text = "Father\'s last name:";
            // 
            // labelFGivenName
            // 
            this.labelFGivenName.AutoSize = true;
            this.labelFGivenName.Location = new System.Drawing.Point(9, 112);
            this.labelFGivenName.Name = "labelFGivenName";
            this.labelFGivenName.Size = new System.Drawing.Size(140, 17);
            this.labelFGivenName.TabIndex = 4;
            this.labelFGivenName.Text = "Father\'s given name:";
            // 
            // textBoxFFirstName
            // 
            this.textBoxFFirstName.Location = new System.Drawing.Point(155, 45);
            this.textBoxFFirstName.Name = "textBoxFFirstName";
            this.textBoxFFirstName.Size = new System.Drawing.Size(144, 22);
            this.textBoxFFirstName.TabIndex = 5;
            this.textBoxFFirstName.Text = "Father";
            // 
            // textBoxFLastName
            // 
            this.textBoxFLastName.Location = new System.Drawing.Point(155, 77);
            this.textBoxFLastName.Name = "textBoxFLastName";
            this.textBoxFLastName.Size = new System.Drawing.Size(144, 22);
            this.textBoxFLastName.TabIndex = 6;
            this.textBoxFLastName.Text = "Time";
            // 
            // textBoxFGivenName
            // 
            this.textBoxFGivenName.Location = new System.Drawing.Point(155, 109);
            this.textBoxFGivenName.Name = "textBoxFGivenName";
            this.textBoxFGivenName.Size = new System.Drawing.Size(144, 22);
            this.textBoxFGivenName.TabIndex = 7;
            this.textBoxFGivenName.Text = "Time";
            // 
            // buttonAddFather
            // 
            this.buttonAddFather.Location = new System.Drawing.Point(45, 156);
            this.buttonAddFather.Name = "buttonAddFather";
            this.buttonAddFather.Size = new System.Drawing.Size(126, 23);
            this.buttonAddFather.TabIndex = 8;
            this.buttonAddFather.Text = "Add father";
            this.buttonAddFather.UseVisualStyleBackColor = true;
            this.buttonAddFather.Click += new System.EventHandler(this.buttonAddFather_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(224, 156);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormFather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 209);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddFather);
            this.Controls.Add(this.textBoxFGivenName);
            this.Controls.Add(this.textBoxFLastName);
            this.Controls.Add(this.textBoxFFirstName);
            this.Controls.Add(this.labelFGivenName);
            this.Controls.Add(this.labelFLastName);
            this.Controls.Add(this.labelFFirstName);
            this.Controls.Add(this.checkBoxFatherKnown);
            this.Name = "FormFather";
            this.Text = "FormFather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFatherKnown;
        private System.Windows.Forms.Label labelFFirstName;
        private System.Windows.Forms.Label labelFLastName;
        private System.Windows.Forms.Label labelFGivenName;
        private System.Windows.Forms.TextBox textBoxFFirstName;
        private System.Windows.Forms.TextBox textBoxFLastName;
        private System.Windows.Forms.TextBox textBoxFGivenName;
        private System.Windows.Forms.Button buttonAddFather;
        private System.Windows.Forms.Button buttonClear;
    }
}