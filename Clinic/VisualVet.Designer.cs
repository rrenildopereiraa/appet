namespace Clinic
{
    partial class VisualVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualVet));
            menuBtn = new Button();
            vetList = new ListBox();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneInp = new TextBox();
            phoneLbl = new Label();
            specializationInp = new TextBox();
            specializationLbl = new Label();
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
            menuBtn.Location = new Point(680, 453);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(118, 26);
            menuBtn.TabIndex = 28;
            menuBtn.Text = "Return to menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // vetList
            // 
            vetList.BackColor = Color.FromArgb(248, 250, 252);
            vetList.Dock = DockStyle.Left;
            vetList.FormattingEnabled = true;
            vetList.ItemHeight = 16;
            vetList.Location = new Point(0, 0);
            vetList.Name = "vetList";
            vetList.Size = new Size(340, 491);
            vetList.TabIndex = 27;
            vetList.SelectedIndexChanged += vetList_SelectedIndexChanged;
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
            deleteBtn.Location = new Point(671, 214);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(127, 23);
            deleteBtn.TabIndex = 26;
            deleteBtn.Text = "Delete a vet";
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
            editBtn.Location = new Point(671, 185);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(127, 23);
            editBtn.TabIndex = 25;
            editBtn.Text = "Update a vet";
            editBtn.TextAlign = ContentAlignment.MiddleRight;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(679, 137);
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
            addBtn.Location = new Point(671, 156);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(127, 23);
            addBtn.TabIndex = 23;
            addBtn.Text = "Add a vet";
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
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(358, 285);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(70, 16);
            phoneLbl.TabIndex = 21;
            phoneLbl.Text = "Vet phone";
            // 
            // specializationInp
            // 
            specializationInp.Location = new Point(358, 230);
            specializationInp.MaxLength = 100;
            specializationInp.Name = "specializationInp";
            specializationInp.PlaceholderText = "Surgical, Dermatological etc";
            specializationInp.Size = new Size(189, 23);
            specializationInp.TabIndex = 20;
            // 
            // specializationLbl
            // 
            specializationLbl.AutoSize = true;
            specializationLbl.Location = new Point(358, 211);
            specializationLbl.Name = "specializationLbl";
            specializationLbl.Size = new Size(147, 16);
            specializationLbl.TabIndex = 19;
            specializationLbl.Text = "Vet specialization *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(358, 137);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(77, 16);
            nameLbl.TabIndex = 18;
            nameLbl.Text = "Vet name *";
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
            paragraphLbl.Size = new Size(351, 19);
            paragraphLbl.TabIndex = 16;
            paragraphLbl.Text = "Manage all veterinarians in the clinic";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(358, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(168, 31);
            headingLbl.TabIndex = 15;
            headingLbl.Text = "Vet manager";
            // 
            // VisualVet
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 491);
            Controls.Add(menuBtn);
            Controls.Add(vetList);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneInp);
            Controls.Add(phoneLbl);
            Controls.Add(specializationInp);
            Controls.Add(specializationLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualVet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet - Vets";
            KeyPress += phoneInp_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private ListBox vetList;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox phoneInp;
        private Label phoneLbl;
        private TextBox specializationInp;
        private Label specializationLbl;
        private Label nameLbl;
        private TextBox nameInp;
        private Label paragraphLbl;
        private Label headingLbl;
    }
}