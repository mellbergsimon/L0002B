
namespace Uppgift3_simmel_9 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.PersonNr = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(204, 75);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(100, 23);
            this.Firstname.TabIndex = 0;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(204, 124);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(100, 23);
            this.Lastname.TabIndex = 1;
            // 
            // PersonNr
            // 
            this.PersonNr.Location = new System.Drawing.Point(204, 180);
            this.PersonNr.Name = "PersonNr";
            this.PersonNr.Size = new System.Drawing.Size(100, 23);
            this.PersonNr.TabIndex = 2;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(229, 221);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(16, 250);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(288, 179);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Förnamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Personnummer (ÅÅMMDDXXXX)";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(229, 435);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Avsluta";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(109, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(111, 25);
            this.welcome.TabIndex = 11;
            this.welcome.Text = "Välkommen";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(75, 34);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(177, 15);
            this.info.TabIndex = 12;
            this.info.Text = "Ange namn och personnummer";
            // 
            // Form1
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 470);
            this.Controls.Add(this.info);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PersonNr);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox PersonNr;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label info;
    }
}

