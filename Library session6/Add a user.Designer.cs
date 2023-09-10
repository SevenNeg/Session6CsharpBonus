namespace Library_session6
{
    partial class Add_a_user
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
            FNamelabel = new Label();
            userinftextbox = new TextBox();
            cellphonelabel = new Label();
            LNamelabel = new Label();
            subCodeLabel = new Label();
            NameUserTxt = new TextBox();
            Cellphoneusertxt = new TextBox();
            Subcodetxt = new TextBox();
            Lnameusertxt = new TextBox();
            UserBackbutton = new Button();
            UserButtonn = new Button();
            SuspendLayout();
            // 
            // FNamelabel
            // 
            FNamelabel.AutoSize = true;
            FNamelabel.Location = new Point(23, 113);
            FNamelabel.Name = "FNamelabel";
            FNamelabel.Size = new Size(134, 32);
            FNamelabel.TabIndex = 0;
            FNamelabel.Text = "First Name:";
            // 
            // userinftextbox
            // 
            userinftextbox.BackColor = SystemColors.ActiveCaption;
            userinftextbox.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userinftextbox.Location = new Point(23, 12);
            userinftextbox.Name = "userinftextbox";
            userinftextbox.Size = new Size(571, 46);
            userinftextbox.TabIndex = 1;
            userinftextbox.Text = "Please insert the user's information";
            // 
            // cellphonelabel
            // 
            cellphonelabel.AutoSize = true;
            cellphonelabel.Location = new Point(26, 259);
            cellphonelabel.Name = "cellphonelabel";
            cellphonelabel.Size = new Size(128, 32);
            cellphonelabel.TabIndex = 2;
            cellphonelabel.Text = "Cellphone:";
            // 
            // LNamelabel
            // 
            LNamelabel.AutoSize = true;
            LNamelabel.Location = new Point(23, 186);
            LNamelabel.Name = "LNamelabel";
            LNamelabel.Size = new Size(131, 32);
            LNamelabel.TabIndex = 3;
            LNamelabel.Text = "Last Name:";
            // 
            // subCodeLabel
            // 
            subCodeLabel.AutoSize = true;
            subCodeLabel.Location = new Point(29, 335);
            subCodeLabel.Name = "subCodeLabel";
            subCodeLabel.Size = new Size(210, 32);
            subCodeLabel.TabIndex = 5;
            subCodeLabel.Text = "Subscription code:";
            // 
            // NameUserTxt
            // 
            NameUserTxt.Location = new Point(255, 110);
            NameUserTxt.Name = "NameUserTxt";
            NameUserTxt.Size = new Size(320, 39);
            NameUserTxt.TabIndex = 6;
            // 
            // Cellphoneusertxt
            // 
            Cellphoneusertxt.Location = new Point(255, 259);
            Cellphoneusertxt.Name = "Cellphoneusertxt";
            Cellphoneusertxt.Size = new Size(320, 39);
            Cellphoneusertxt.TabIndex = 7;
            // 
            // Subcodetxt
            // 
            Subcodetxt.Location = new Point(255, 332);
            Subcodetxt.Name = "Subcodetxt";
            Subcodetxt.Size = new Size(320, 39);
            Subcodetxt.TabIndex = 8;
            // 
            // Lnameusertxt
            // 
            Lnameusertxt.Location = new Point(255, 179);
            Lnameusertxt.Name = "Lnameusertxt";
            Lnameusertxt.Size = new Size(320, 39);
            Lnameusertxt.TabIndex = 10;
            // 
            // UserBackbutton
            // 
            UserBackbutton.BackColor = SystemColors.ButtonShadow;
            UserBackbutton.CausesValidation = false;
            UserBackbutton.Location = new Point(39, 442);
            UserBackbutton.Name = "UserBackbutton";
            UserBackbutton.Size = new Size(174, 41);
            UserBackbutton.TabIndex = 13;
            UserBackbutton.Text = "Back";
            UserBackbutton.UseVisualStyleBackColor = false;
            UserBackbutton.Click += UserBackbutton_Click;
            // 
            // UserButtonn
            // 
            UserButtonn.BackColor = Color.SkyBlue;
            UserButtonn.Location = new Point(571, 442);
            UserButtonn.Name = "UserButtonn";
            UserButtonn.Size = new Size(179, 41);
            UserButtonn.TabIndex = 14;
            UserButtonn.Text = "Done";
            UserButtonn.UseVisualStyleBackColor = false;
            UserButtonn.Click += UserButtonn_Click;
            // 
            // Add_a_user
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(UserButtonn);
            Controls.Add(UserBackbutton);
            Controls.Add(Lnameusertxt);
            Controls.Add(Subcodetxt);
            Controls.Add(Cellphoneusertxt);
            Controls.Add(NameUserTxt);
            Controls.Add(subCodeLabel);
            Controls.Add(LNamelabel);
            Controls.Add(cellphonelabel);
            Controls.Add(userinftextbox);
            Controls.Add(FNamelabel);
            Name = "Add_a_user";
            Text = "Add_a_user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FNamelabel;
        private TextBox userinftextbox;
        private Label cellphonelabel;
        private Label LNamelabel;
        private Label subCodeLabel;
        private TextBox NameUserTxt;
        private TextBox Cellphoneusertxt;
        private TextBox Subcodetxt;
        private TextBox Lnameusertxt;
        private Button UserBackbutton;
        private Button UserButtonn;
    }
}