namespace DFWSv1._1
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upDBDataSet = new DFWSv1._1.upDBDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.WeightTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SexTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.tblUPTableAdapter = new DFWSv1._1.upDBDataSetTableAdapters.tblUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDBDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(108, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(379, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 473);
            this.panel2.TabIndex = 1;
            // 
            // tblUPBindingSource
            // 
            this.tblUPBindingSource.DataMember = "tblUP";
            this.tblUPBindingSource.DataSource = this.upDBDataSet;
            // 
            // upDBDataSet
            // 
            this.upDBDataSet.DataSetName = "upDBDataSet";
            this.upDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EditButton);
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Controls.Add(this.HeightTxtBox);
            this.panel3.Controls.Add(this.WeightTxtBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.SexTxtBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.AgeTxtBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NameTxtBox);
            this.panel3.Location = new System.Drawing.Point(23, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 274);
            this.panel3.TabIndex = 2;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(71, 138);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(173, 138);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUPBindingSource, "Height", true));
            this.HeightTxtBox.Location = new System.Drawing.Point(225, 91);
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.Size = new System.Drawing.Size(50, 22);
            this.HeightTxtBox.TabIndex = 9;
            // 
            // WeightTxtBox
            // 
            this.WeightTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUPBindingSource, "Weight", true));
            this.WeightTxtBox.Location = new System.Drawing.Point(71, 88);
            this.WeightTxtBox.Name = "WeightTxtBox";
            this.WeightTxtBox.Size = new System.Drawing.Size(50, 22);
            this.WeightTxtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sex:";
            // 
            // SexTxtBox
            // 
            this.SexTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SexTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUPBindingSource, "Sex", true));
            this.SexTxtBox.Location = new System.Drawing.Point(225, 61);
            this.SexTxtBox.Name = "SexTxtBox";
            this.SexTxtBox.Size = new System.Drawing.Size(50, 22);
            this.SexTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // AgeTxtBox
            // 
            this.AgeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUPBindingSource, "Age", true));
            this.AgeTxtBox.Location = new System.Drawing.Point(71, 52);
            this.AgeTxtBox.Name = "AgeTxtBox";
            this.AgeTxtBox.Size = new System.Drawing.Size(50, 22);
            this.AgeTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUPBindingSource, "Name", true));
            this.NameTxtBox.Location = new System.Drawing.Point(63, 24);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(237, 22);
            this.NameTxtBox.TabIndex = 0;
            // 
            // tblUPTableAdapter
            // 
            this.tblUPTableAdapter.ClearBeforeFill = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDBDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox AgeTxtBox;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.TextBox WeightTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SexTxtBox;
        private System.Windows.Forms.Label label2;
        private upDBDataSet upDBDataSet;
        private System.Windows.Forms.BindingSource tblUPBindingSource;
        private upDBDataSetTableAdapters.tblUPTableAdapter tblUPTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
    }
}