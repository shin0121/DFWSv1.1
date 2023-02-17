namespace DFWSv1._1
{
    partial class More
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
            this.More_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // More_Back
            // 
            this.More_Back.Location = new System.Drawing.Point(24, 333);
            this.More_Back.Name = "More_Back";
            this.More_Back.Size = new System.Drawing.Size(75, 23);
            this.More_Back.TabIndex = 2;
            this.More_Back.Text = "Back";
            this.More_Back.UseVisualStyleBackColor = true;
            this.More_Back.Click += new System.EventHandler(this.More_Back_Click);
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 384);
            this.Controls.Add(this.More_Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "More";
            this.Text = "More";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button More_Back;
    }
}