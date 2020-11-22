namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxBody = new System.Windows.Forms.CheckBox();
            this.checkBoxBrand = new System.Windows.Forms.CheckBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.checkBoxRegion = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.comboBoxBody = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.DOMradioButton = new System.Windows.Forms.RadioButton();
            this.SAXradioButton = new System.Windows.Forms.RadioButton();
            this.LINQradioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.transformingButton = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkBoxBody
            // 
            this.checkBoxBody.AutoSize = true;
            this.checkBoxBody.Location = new System.Drawing.Point(31, 63);
            this.checkBoxBody.Name = "checkBoxBody";
            this.checkBoxBody.Size = new System.Drawing.Size(71, 24);
            this.checkBoxBody.TabIndex = 0;
            this.checkBoxBody.Text = "Кузов";
            this.checkBoxBody.UseVisualStyleBackColor = true;
            this.checkBoxBody.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxBrand
            // 
            this.checkBoxBrand.AutoSize = true;
            this.checkBoxBrand.Location = new System.Drawing.Point(31, 106);
            this.checkBoxBrand.Name = "checkBoxBrand";
            this.checkBoxBrand.Size = new System.Drawing.Size(76, 24);
            this.checkBoxBrand.TabIndex = 0;
            this.checkBoxBrand.Text = "Марка";
            this.checkBoxBrand.UseVisualStyleBackColor = true;
            this.checkBoxBrand.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Location = new System.Drawing.Point(31, 150);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(85, 24);
            this.checkBoxModel.TabIndex = 0;
            this.checkBoxModel.Text = "Модель";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            this.checkBoxModel.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRegion
            // 
            this.checkBoxRegion.AutoSize = true;
            this.checkBoxRegion.Location = new System.Drawing.Point(31, 194);
            this.checkBoxRegion.Name = "checkBoxRegion";
            this.checkBoxRegion.Size = new System.Drawing.Size(135, 24);
            this.checkBoxRegion.TabIndex = 0;
            this.checkBoxRegion.Text = "Місто продажу";
            this.checkBoxRegion.UseVisualStyleBackColor = true;
            this.checkBoxRegion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(31, 238);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(108, 24);
            this.checkBoxYear.TabIndex = 0;
            this.checkBoxYear.Text = "Рік випуску";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(31, 284);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(63, 24);
            this.checkBoxPrice.TabIndex = 0;
            this.checkBoxPrice.Text = "Ціна";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            this.checkBoxPrice.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxBody
            // 
            this.comboBoxBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBody.FormattingEnabled = true;
            this.comboBoxBody.Location = new System.Drawing.Point(191, 59);
            this.comboBoxBody.Name = "comboBoxBody";
            this.comboBoxBody.Size = new System.Drawing.Size(239, 28);
            this.comboBoxBody.Sorted = true;
            this.comboBoxBody.TabIndex = 1;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(191, 102);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(239, 28);
            this.comboBoxBrand.Sorted = true;
            this.comboBoxBrand.TabIndex = 1;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.comboBoxBrand.SelectedValueChanged += new System.EventHandler(this.comboBoxBrand_SelectedValueChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.Enabled = false;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(191, 146);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(239, 28);
            this.comboBoxModel.Sorted = true;
            this.comboBoxModel.TabIndex = 1;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(191, 190);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(239, 28);
            this.comboBoxRegion.Sorted = true;
            this.comboBoxRegion.TabIndex = 1;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(191, 234);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(239, 28);
            this.comboBoxYear.TabIndex = 1;
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Location = new System.Drawing.Point(191, 280);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(239, 28);
            this.comboBoxPrice.TabIndex = 1;
            // 
            // DOMradioButton
            // 
            this.DOMradioButton.AutoSize = true;
            this.DOMradioButton.Location = new System.Drawing.Point(56, 361);
            this.DOMradioButton.Name = "DOMradioButton";
            this.DOMradioButton.Size = new System.Drawing.Size(65, 24);
            this.DOMradioButton.TabIndex = 2;
            this.DOMradioButton.TabStop = true;
            this.DOMradioButton.Text = "DOM";
            this.DOMradioButton.UseVisualStyleBackColor = true;
            this.DOMradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SAXradioButton
            // 
            this.SAXradioButton.AutoSize = true;
            this.SAXradioButton.Location = new System.Drawing.Point(56, 391);
            this.SAXradioButton.Name = "SAXradioButton";
            this.SAXradioButton.Size = new System.Drawing.Size(57, 24);
            this.SAXradioButton.TabIndex = 2;
            this.SAXradioButton.TabStop = true;
            this.SAXradioButton.Text = "SAX";
            this.SAXradioButton.UseVisualStyleBackColor = true;
            this.SAXradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LINQradioButton
            // 
            this.LINQradioButton.AutoSize = true;
            this.LINQradioButton.Location = new System.Drawing.Point(56, 421);
            this.LINQradioButton.Name = "LINQradioButton";
            this.LINQradioButton.Size = new System.Drawing.Size(114, 24);
            this.LINQradioButton.TabIndex = 2;
            this.LINQradioButton.TabStop = true;
            this.LINQradioButton.Text = "LINQ to XML";
            this.LINQradioButton.UseVisualStyleBackColor = true;
            this.LINQradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(55, 474);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 38);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(55, 527);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(128, 38);
            this.cleanButton.TabIndex = 3;
            this.cleanButton.Text = "Очистити";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // transformingButton
            // 
            this.transformingButton.Location = new System.Drawing.Point(56, 580);
            this.transformingButton.Name = "transformingButton";
            this.transformingButton.Size = new System.Drawing.Size(127, 38);
            this.transformingButton.TabIndex = 3;
            this.transformingButton.Text = "Трансформація";
            this.transformingButton.UseVisualStyleBackColor = true;
            this.transformingButton.Click += new System.EventHandler(this.transformingButton_Click);
            // 
            // rtb
            // 
            this.rtb.BackColor = System.Drawing.SystemColors.Menu;
            this.rtb.Location = new System.Drawing.Point(454, 59);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(588, 558);
            this.rtb.TabIndex = 4;
            this.rtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 639);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.transformingButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LINQradioButton);
            this.Controls.Add(this.SAXradioButton);
            this.Controls.Add(this.DOMradioButton);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxBody);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxRegion);
            this.Controls.Add(this.checkBoxModel);
            this.Controls.Add(this.checkBoxBrand);
            this.Controls.Add(this.checkBoxBody);
            this.Name = "Form1";
            this.Text = "Laboratorna2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBody;
        private System.Windows.Forms.CheckBox checkBoxBrand;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.CheckBox checkBoxRegion;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxBody;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.RadioButton DOMradioButton;
        private System.Windows.Forms.RadioButton SAXradioButton;
        private System.Windows.Forms.RadioButton LINQradioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button transformingButton;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

