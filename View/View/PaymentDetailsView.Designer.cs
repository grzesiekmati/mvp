namespace View
{
    partial class PaymentDetailsView
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCardType = new System.Windows.Forms.TextBox();
            this.tbCardCvn = new System.Windows.Forms.TextBox();
            this.tbCardExpiry = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(253, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbCardType
            // 
            this.tbCardType.Location = new System.Drawing.Point(80, 142);
            this.tbCardType.Name = "tbCardType";
            this.tbCardType.Size = new System.Drawing.Size(253, 20);
            this.tbCardType.TabIndex = 1;
            // 
            // tbCardCvn
            // 
            this.tbCardCvn.Location = new System.Drawing.Point(80, 116);
            this.tbCardCvn.Name = "tbCardCvn";
            this.tbCardCvn.Size = new System.Drawing.Size(253, 20);
            this.tbCardCvn.TabIndex = 2;
            // 
            // tbCardExpiry
            // 
            this.tbCardExpiry.Location = new System.Drawing.Point(80, 90);
            this.tbCardExpiry.Name = "tbCardExpiry";
            this.tbCardExpiry.Size = new System.Drawing.Size(253, 20);
            this.tbCardExpiry.TabIndex = 3;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(80, 64);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(253, 20);
            this.tbCardNumber.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(80, 38);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(253, 20);
            this.tbSurname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Typ karty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CVN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wygasa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nr karty";
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(258, 168);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(75, 23);
            this.saveBttn.TabIndex = 13;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // PaymentDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 340);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.tbCardExpiry);
            this.Controls.Add(this.tbCardCvn);
            this.Controls.Add(this.tbCardType);
            this.Controls.Add(this.tbName);
            this.Name = "PaymentDetailsView";
            this.Text = "PaymentDetailsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCardType;
        private System.Windows.Forms.TextBox tbCardCvn;
        private System.Windows.Forms.TextBox tbCardExpiry;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveBttn;
    }
}