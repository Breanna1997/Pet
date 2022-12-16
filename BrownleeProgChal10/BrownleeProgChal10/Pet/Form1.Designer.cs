
namespace Pet
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtBox_Pet = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(263, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Pet\'s Name:";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(263, 128);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(127, 23);
            this.txtBox_Name.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(263, 171);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(98, 15);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Enter Type of Pet:";
            // 
            // txtBox_Pet
            // 
            this.txtBox_Pet.Location = new System.Drawing.Point(263, 189);
            this.txtBox_Pet.Name = "txtBox_Pet";
            this.txtBox_Pet.Size = new System.Drawing.Size(127, 23);
            this.txtBox_Pet.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(263, 234);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(116, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter Your Pet\'s Age:";
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(263, 252);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(127, 23);
            this.txtBox_Age.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(263, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBox_Pet);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Pet Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBox_Pet;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}

