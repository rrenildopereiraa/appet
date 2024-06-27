namespace Clinic
{
    partial class VisualAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualAnimal));
            headingLbl = new Label();
            paragraphLbl = new Label();
            nameInp = new TextBox();
            nameLbl = new Label();
            speciesLbl = new Label();
            speciesInp = new TextBox();
            ownerLbl = new Label();
            addBtn = new Button();
            pageContentLbl = new Label();
            editBtn = new Button();
            deleteBtn = new Button();
            animalList = new ListBox();
            menuBtn = new Button();
            ownerCb = new ComboBox();
            SuspendLayout();
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(358, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(210, 31);
            headingLbl.TabIndex = 1;
            headingLbl.Text = "Animal manager";
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(358, 74);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(279, 19);
            paragraphLbl.TabIndex = 2;
            paragraphLbl.Text = "Manage of all kind of animals.";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(358, 156);
            nameInp.MaxLength = 50;
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "Skittles, Bonnie, etc";
            nameInp.Size = new Size(189, 23);
            nameInp.TabIndex = 3;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(358, 137);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(98, 16);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "Animal name *";
            // 
            // speciesLbl
            // 
            speciesLbl.AutoSize = true;
            speciesLbl.Location = new Point(358, 211);
            speciesLbl.Name = "speciesLbl";
            speciesLbl.Size = new Size(119, 16);
            speciesLbl.TabIndex = 5;
            speciesLbl.Text = "Animal species *";
            // 
            // speciesInp
            // 
            speciesInp.Location = new Point(358, 230);
            speciesInp.MaxLength = 100;
            speciesInp.Name = "speciesInp";
            speciesInp.PlaceholderText = "Dog, Cat, etc";
            speciesInp.Size = new Size(189, 23);
            speciesInp.TabIndex = 6;
            // 
            // ownerLbl
            // 
            ownerLbl.AutoSize = true;
            ownerLbl.Location = new Point(358, 285);
            ownerLbl.Name = "ownerLbl";
            ownerLbl.Size = new Size(105, 16);
            ownerLbl.TabIndex = 7;
            ownerLbl.Text = "Animal owner *";
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatAppearance.MouseDownBackColor = Color.White;
            addBtn.FlatAppearance.MouseOverBackColor = Color.White;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.FromArgb(14, 165, 232);
            addBtn.Location = new Point(665, 156);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(127, 23);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add an animal";
            addBtn.TextAlign = ContentAlignment.MiddleRight;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(673, 137);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(119, 16);
            pageContentLbl.TabIndex = 10;
            pageContentLbl.Text = "Available tasks:";
            pageContentLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // editBtn
            // 
            editBtn.Cursor = Cursors.Hand;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatAppearance.CheckedBackColor = Color.White;
            editBtn.FlatAppearance.MouseDownBackColor = Color.White;
            editBtn.FlatAppearance.MouseOverBackColor = Color.White;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.FromArgb(14, 165, 232);
            editBtn.Location = new Point(665, 185);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(127, 23);
            editBtn.TabIndex = 11;
            editBtn.Text = "Update an animal";
            editBtn.TextAlign = ContentAlignment.MiddleRight;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatAppearance.CheckedBackColor = Color.White;
            deleteBtn.FlatAppearance.MouseDownBackColor = Color.White;
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.White;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.FromArgb(188, 67, 46);
            deleteBtn.Location = new Point(665, 214);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(127, 23);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete an animal";
            deleteBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // animalList
            // 
            animalList.BackColor = Color.FromArgb(248, 250, 252);
            animalList.Dock = DockStyle.Left;
            animalList.FormattingEnabled = true;
            animalList.ItemHeight = 16;
            animalList.Location = new Point(0, 0);
            animalList.Name = "animalList";
            animalList.Size = new Size(340, 491);
            animalList.TabIndex = 13;
            animalList.SelectedIndexChanged += animalList_SelectedIndexChanged;
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.White;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.ForeColor = Color.FromArgb(15, 23, 42);
            menuBtn.Location = new Point(674, 453);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(118, 26);
            menuBtn.TabIndex = 14;
            menuBtn.Text = "Return to menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // ownerCb
            // 
            ownerCb.FormattingEnabled = true;
            ownerCb.Location = new Point(358, 304);
            ownerCb.Name = "ownerCb";
            ownerCb.Size = new Size(189, 24);
            ownerCb.TabIndex = 15;
            // 
            // VisualAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 491);
            Controls.Add(ownerCb);
            Controls.Add(menuBtn);
            Controls.Add(animalList);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(ownerLbl);
            Controls.Add(speciesInp);
            Controls.Add(speciesLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet - Animals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label headingLbl;
        private Label paragraphLbl;
        private TextBox nameInp;
        private Label nameLbl;
        private Label speciesLbl;
        private TextBox speciesInp;
        private Label ownerLbl;
        private Button addBtn;
        private Label pageContentLbl;
        private Button editBtn;
        private Button deleteBtn;
        private ListBox animalList;
        private Button menuBtn;
        private ComboBox ownerCb;
    }
}