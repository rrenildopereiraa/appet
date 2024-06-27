namespace Clinic
{
    partial class VisualObservatory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualObservatory));
            menuBtn = new Button();
            observatoryList = new ListBox();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            telescopeInp = new TextBox();
            telescopeLbl = new Label();
            locationInp = new TextBox();
            locationLbl = new Label();
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
            menuBtn.Location = new Point(681, 453);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(118, 26);
            menuBtn.TabIndex = 42;
            menuBtn.Text = "Return to menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // observatoryList
            // 
            observatoryList.BackColor = Color.FromArgb(248, 250, 252);
            observatoryList.Dock = DockStyle.Left;
            observatoryList.FormattingEnabled = true;
            observatoryList.ItemHeight = 16;
            observatoryList.Location = new Point(0, 0);
            observatoryList.Name = "observatoryList";
            observatoryList.Size = new Size(340, 491);
            observatoryList.TabIndex = 41;
            observatoryList.SelectedIndexChanged += observatoryList_SelectedIndexChanged;
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
            deleteBtn.Location = new Point(618, 214);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(170, 23);
            deleteBtn.TabIndex = 40;
            deleteBtn.Text = "Delete an observatory";
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
            editBtn.Location = new Point(622, 185);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(166, 23);
            editBtn.TabIndex = 39;
            editBtn.Text = "Update an observatory";
            editBtn.TextAlign = ContentAlignment.MiddleRight;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(680, 137);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(119, 16);
            pageContentLbl.TabIndex = 38;
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
            addBtn.Location = new Point(633, 156);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(155, 23);
            addBtn.TabIndex = 37;
            addBtn.Text = "Add an observatory";
            addBtn.TextAlign = ContentAlignment.MiddleRight;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // telescopeInp
            // 
            telescopeInp.Location = new Point(358, 304);
            telescopeInp.MaxLength = 4;
            telescopeInp.Name = "telescopeInp";
            telescopeInp.PlaceholderText = "3, 12, 24, etc";
            telescopeInp.Size = new Size(189, 23);
            telescopeInp.TabIndex = 36;
            telescopeInp.KeyPress += telescope_KeyPress;
            // 
            // telescopeLbl
            // 
            telescopeLbl.AutoSize = true;
            telescopeLbl.Location = new Point(358, 285);
            telescopeLbl.Name = "telescopeLbl";
            telescopeLbl.Size = new Size(126, 16);
            telescopeLbl.TabIndex = 35;
            telescopeLbl.Text = "Telescope count *";
            // 
            // locationInp
            // 
            locationInp.Location = new Point(358, 230);
            locationInp.MaxLength = 100;
            locationInp.Name = "locationInp";
            locationInp.PlaceholderText = "California, France, etc";
            locationInp.Size = new Size(189, 23);
            locationInp.TabIndex = 34;
            // 
            // locationLbl
            // 
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(358, 211);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(161, 16);
            locationLbl.TabIndex = 33;
            locationLbl.Text = "Observatory location *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(358, 137);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(133, 16);
            nameLbl.TabIndex = 32;
            nameLbl.Text = "Observatory name *";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(358, 156);
            nameInp.MaxLength = 100;
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "First name";
            nameInp.Size = new Size(189, 23);
            nameInp.TabIndex = 31;
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(358, 74);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(306, 19);
            paragraphLbl.TabIndex = 30;
            paragraphLbl.Text = "Manage the observatory locations.";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(358, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(280, 31);
            headingLbl.TabIndex = 29;
            headingLbl.Text = "Observatory manager";
            // 
            // VisualObservatory
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 491);
            Controls.Add(menuBtn);
            Controls.Add(observatoryList);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(telescopeInp);
            Controls.Add(telescopeLbl);
            Controls.Add(locationInp);
            Controls.Add(locationLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualObservatory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet - Observatories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private ListBox observatoryList;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox telescopeInp;
        private Label telescopeLbl;
        private TextBox locationInp;
        private Label locationLbl;
        private Label nameLbl;
        private TextBox nameInp;
        private Label paragraphLbl;
        private Label headingLbl;
    }
}