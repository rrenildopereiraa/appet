namespace Clinic
{
    partial class VisualClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualClient));
            menuBtn = new Button();
            clientList = new ListBox();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneInp = new TextBox();
            phoneLbl = new Label();
            addressInp = new TextBox();
            addressLbl = new Label();
            nameLbl = new Label();
            nameInp = new TextBox();
            paragraphLbl = new Label();
            headingLbl = new Label();
            SuspendLayout();
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
            menuBtn.TabIndex = 28;
            menuBtn.Text = "Return to menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // clientList
            // 
            clientList.BackColor = Color.FromArgb(248, 250, 252);
            clientList.Dock = DockStyle.Left;
            clientList.FormattingEnabled = true;
            clientList.ItemHeight = 16;
            clientList.Location = new Point(0, 0);
            clientList.Name = "clientList";
            clientList.Size = new Size(340, 491);
            clientList.TabIndex = 27;
            clientList.Click += clientList_SelectedIndexChanged;
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
            deleteBtn.TabIndex = 26;
            deleteBtn.Text = "Delete a client";
            deleteBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
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
            editBtn.TabIndex = 25;
            editBtn.Text = "Update a client";
            editBtn.TextAlign = ContentAlignment.MiddleRight;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(673, 137);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(119, 16);
            pageContentLbl.TabIndex = 24;
            pageContentLbl.Text = "Available tasks:";
            pageContentLbl.TextAlign = ContentAlignment.MiddleRight;
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
            addBtn.TabIndex = 23;
            addBtn.Text = "Add a client";
            addBtn.TextAlign = ContentAlignment.MiddleRight;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // phoneInp
            // 
            phoneInp.Location = new Point(358, 304);
            phoneInp.MaxLength = 20;
            phoneInp.Name = "phoneInp";
            phoneInp.PlaceholderText = "256 879 010";
            phoneInp.Size = new Size(189, 23);
            phoneInp.TabIndex = 22;
            phoneInp.KeyPress += phoneInp_KeyPress;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(358, 285);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(91, 16);
            phoneLbl.TabIndex = 21;
            phoneLbl.Text = "Client phone";
            // 
            // addressInp
            // 
            addressInp.Location = new Point(358, 230);
            addressInp.MaxLength = 100;
            addressInp.Name = "addressInp";
            addressInp.PlaceholderText = "12823 Colima Rd La Mirada, (CA), 90638";
            addressInp.Size = new Size(189, 23);
            addressInp.TabIndex = 20;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(358, 211);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(119, 16);
            addressLbl.TabIndex = 19;
            addressLbl.Text = "Client address *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(358, 137);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(98, 16);
            nameLbl.TabIndex = 18;
            nameLbl.Text = "Client name *";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(358, 156);
            nameInp.MaxLength = 50;
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "First name";
            nameInp.Size = new Size(189, 23);
            nameInp.TabIndex = 17;
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(358, 74);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(279, 19);
            paragraphLbl.TabIndex = 16;
            paragraphLbl.Text = "Manage all of the pets owners.";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(358, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(210, 31);
            headingLbl.TabIndex = 15;
            headingLbl.Text = "Client manager";
            // 
            // VisualClient
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 491);
            Controls.Add(menuBtn);
            Controls.Add(clientList);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneInp);
            Controls.Add(phoneLbl);
            Controls.Add(addressInp);
            Controls.Add(addressLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet - Clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private ListBox clientList;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox phoneInp;
        private Label phoneLbl;
        private TextBox addressInp;
        private Label addressLbl;
        private Label nameLbl;
        private TextBox nameInp;
        private Label paragraphLbl;
        private Label headingLbl;
    }
}