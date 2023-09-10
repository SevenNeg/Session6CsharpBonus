namespace Library_session6
{
    partial class Add_a_book
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
            Namelabel = new Label();
            NametextBox = new TextBox();
            Codelabel = new Label();
            bookdisclabel = new Label();
            IsAvailableLabel = new Label();
            AuthorLabel = new Label();
            shortdiscTextbox = new TextBox();
            codetextbox = new TextBox();
            AuthortextBox = new TextBox();
            bookinftextbox = new TextBox();
            domainAvailable = new DomainUpDown();
            userbutton = new Button();
            Userbackbutton = new Button();
            SuspendLayout();
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(38, 86);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(83, 32);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Name:";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(273, 83);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(303, 39);
            NametextBox.TabIndex = 1;
            // 
            // Codelabel
            // 
            Codelabel.AutoSize = true;
            Codelabel.Location = new Point(38, 153);
            Codelabel.Name = "Codelabel";
            Codelabel.Size = new Size(152, 32);
            Codelabel.TabIndex = 2;
            Codelabel.Text = "Book's Code:";
            // 
            // bookdisclabel
            // 
            bookdisclabel.AutoSize = true;
            bookdisclabel.Location = new Point(38, 293);
            bookdisclabel.Name = "bookdisclabel";
            bookdisclabel.Size = new Size(194, 32);
            bookdisclabel.TabIndex = 3;
            bookdisclabel.Text = "Short discription:";
            // 
            // IsAvailableLabel
            // 
            IsAvailableLabel.AutoSize = true;
            IsAvailableLabel.Location = new Point(38, 368);
            IsAvailableLabel.Name = "IsAvailableLabel";
            IsAvailableLabel.Size = new Size(138, 32);
            IsAvailableLabel.TabIndex = 4;
            IsAvailableLabel.Text = "Is Available:";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(38, 229);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(92, 32);
            AuthorLabel.TabIndex = 5;
            AuthorLabel.Text = "Author:";
            // 
            // shortdiscTextbox
            // 
            shortdiscTextbox.Location = new Point(273, 290);
            shortdiscTextbox.Name = "shortdiscTextbox";
            shortdiscTextbox.Size = new Size(303, 39);
            shortdiscTextbox.TabIndex = 6;
            // 
            // codetextbox
            // 
            codetextbox.Location = new Point(273, 150);
            codetextbox.Name = "codetextbox";
            codetextbox.Size = new Size(303, 39);
            codetextbox.TabIndex = 7;
            // 
            // AuthortextBox
            // 
            AuthortextBox.Location = new Point(273, 222);
            AuthortextBox.Name = "AuthortextBox";
            AuthortextBox.Size = new Size(303, 39);
            AuthortextBox.TabIndex = 9;
            // 
            // bookinftextbox
            // 
            bookinftextbox.BackColor = SystemColors.ActiveCaption;
            bookinftextbox.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookinftextbox.Location = new Point(12, 3);
            bookinftextbox.Name = "bookinftextbox";
            bookinftextbox.Size = new Size(498, 46);
            bookinftextbox.TabIndex = 10;
            bookinftextbox.Text = "Please insert the book's information";
            // 
            // domainAvailable
            // 
            domainAvailable.Items.Add("Yes");
            domainAvailable.Items.Add("No");
            domainAvailable.Location = new Point(282, 368);
            domainAvailable.Name = "domainAvailable";
            domainAvailable.Size = new Size(180, 39);
            domainAvailable.TabIndex = 11;
            domainAvailable.Text = "Choose";
            // 
            // userbutton
            // 
            userbutton.BackColor = Color.SkyBlue;
            userbutton.Location = new Point(570, 448);
            userbutton.Name = "userbutton";
            userbutton.Size = new Size(176, 41);
            userbutton.TabIndex = 12;
            userbutton.Text = "Done";
            userbutton.UseVisualStyleBackColor = false;
            userbutton.Click += userbutton_Click;
            // 
            // Userbackbutton
            // 
            Userbackbutton.BackColor = SystemColors.ButtonShadow;
            Userbackbutton.Location = new Point(38, 448);
            Userbackbutton.Name = "Userbackbutton";
            Userbackbutton.Size = new Size(176, 41);
            Userbackbutton.TabIndex = 13;
            Userbackbutton.Text = "Back";
            Userbackbutton.UseVisualStyleBackColor = false;
            Userbackbutton.Click += Userbackbutton_Click;
            // 
            // Add_a_book
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(Userbackbutton);
            Controls.Add(userbutton);
            Controls.Add(domainAvailable);
            Controls.Add(bookinftextbox);
            Controls.Add(AuthortextBox);
            Controls.Add(codetextbox);
            Controls.Add(shortdiscTextbox);
            Controls.Add(AuthorLabel);
            Controls.Add(IsAvailableLabel);
            Controls.Add(bookdisclabel);
            Controls.Add(Codelabel);
            Controls.Add(NametextBox);
            Controls.Add(Namelabel);
            Name = "Add_a_book";
            Text = "Add_a_book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelabel;
        private TextBox NametextBox;
        private Label Codelabel;
        private Label bookdisclabel;
        private Label IsAvailableLabel;
        private Label AuthorLabel;
        private TextBox shortdiscTextbox;
        private TextBox codetextbox;
        private TextBox AuthortextBox;
        private TextBox bookinftextbox;
        private DomainUpDown domainAvailable;
        private Button userbutton;
        private Button Userbackbutton;
    }
}