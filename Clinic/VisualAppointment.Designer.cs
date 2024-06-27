namespace Clinic
{
    partial class VisualAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualAppointment));
            menuBtn = new Button();
            appointmentList = new ListBox();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            notesInp = new TextBox();
            appointmentNoteLbl = new Label();
            vetNameLbl = new Label();
            nameLbl = new Label();
            paragraphLbl = new Label();
            headingLbl = new Label();
            dateInp = new DateTimePicker();
            appointmentDateLbl = new Label();
            vetCb = new ComboBox();
            clientCb = new ComboBox();
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
            // appointmentList
            // 
            appointmentList.BackColor = Color.FromArgb(248, 250, 252);
            appointmentList.Dock = DockStyle.Left;
            appointmentList.FormattingEnabled = true;
            appointmentList.ItemHeight = 16;
            appointmentList.Location = new Point(0, 0);
            appointmentList.Name = "appointmentList";
            appointmentList.Size = new Size(340, 491);
            appointmentList.TabIndex = 27;
            appointmentList.SelectedIndexChanged += appointmentList_SelectedIndexChanged;
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
            deleteBtn.Location = new Point(627, 214);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(165, 23);
            deleteBtn.TabIndex = 26;
            deleteBtn.Text = "Delete an appointment";
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
            editBtn.Location = new Point(627, 185);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(165, 23);
            editBtn.TabIndex = 25;
            editBtn.Text = "Update an appointment";
            editBtn.TextAlign = ContentAlignment.MiddleRight;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.ForeColor = Color.FromArgb(15, 23, 42);
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
            addBtn.Location = new Point(650, 156);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(142, 23);
            addBtn.TabIndex = 23;
            addBtn.Text = "Add an appointment";
            addBtn.TextAlign = ContentAlignment.MiddleRight;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // notesInp
            // 
            notesInp.Location = new Point(358, 378);
            notesInp.MaxLength = 1000;
            notesInp.Multiline = true;
            notesInp.Name = "notesInp";
            notesInp.PlaceholderText = "Important observations";
            notesInp.Size = new Size(189, 101);
            notesInp.TabIndex = 22;
            // 
            // appointmentNoteLbl
            // 
            appointmentNoteLbl.AutoSize = true;
            appointmentNoteLbl.ForeColor = Color.FromArgb(15, 23, 42);
            appointmentNoteLbl.Location = new Point(358, 359);
            appointmentNoteLbl.Name = "appointmentNoteLbl";
            appointmentNoteLbl.Size = new Size(119, 16);
            appointmentNoteLbl.TabIndex = 21;
            appointmentNoteLbl.Text = "Appointment note";
            // 
            // vetNameLbl
            // 
            vetNameLbl.AutoSize = true;
            vetNameLbl.ForeColor = Color.FromArgb(15, 23, 42);
            vetNameLbl.Location = new Point(358, 211);
            vetNameLbl.Name = "vetNameLbl";
            vetNameLbl.Size = new Size(77, 16);
            vetNameLbl.TabIndex = 19;
            vetNameLbl.Text = "Vet name *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.ForeColor = Color.FromArgb(15, 23, 42);
            nameLbl.Location = new Point(358, 137);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(98, 16);
            nameLbl.TabIndex = 18;
            nameLbl.Text = "Client name *";
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(358, 74);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(306, 19);
            paragraphLbl.TabIndex = 16;
            paragraphLbl.Text = "Manage all customer appointments.";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(358, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(238, 31);
            headingLbl.TabIndex = 15;
            headingLbl.Text = "Appointment list";
            // 
            // dateInp
            // 
            dateInp.CalendarForeColor = Color.FromArgb(118, 132, 153);
            dateInp.CalendarTitleBackColor = Color.FromArgb(14, 165, 232);
            dateInp.CalendarTitleForeColor = Color.FromArgb(118, 132, 153);
            dateInp.CalendarTrailingForeColor = Color.FromArgb(118, 132, 153);
            dateInp.Location = new Point(358, 304);
            dateInp.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateInp.Name = "dateInp";
            dateInp.Size = new Size(189, 23);
            dateInp.TabIndex = 29;
            // 
            // appointmentDateLbl
            // 
            appointmentDateLbl.AutoSize = true;
            appointmentDateLbl.ForeColor = Color.FromArgb(15, 23, 42);
            appointmentDateLbl.Location = new Point(358, 285);
            appointmentDateLbl.Name = "appointmentDateLbl";
            appointmentDateLbl.Size = new Size(133, 16);
            appointmentDateLbl.TabIndex = 31;
            appointmentDateLbl.Text = "Appointment date *";
            // 
            // vetCb
            // 
            vetCb.FormattingEnabled = true;
            vetCb.Location = new Point(358, 230);
            vetCb.Name = "vetCb";
            vetCb.Size = new Size(189, 24);
            vetCb.TabIndex = 32;
            // 
            // clientCb
            // 
            clientCb.FormattingEnabled = true;
            clientCb.Location = new Point(358, 156);
            clientCb.Name = "clientCb";
            clientCb.Size = new Size(189, 24);
            clientCb.TabIndex = 33;
            // 
            // VisualAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 491);
            Controls.Add(clientCb);
            Controls.Add(vetCb);
            Controls.Add(appointmentDateLbl);
            Controls.Add(dateInp);
            Controls.Add(menuBtn);
            Controls.Add(appointmentList);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(notesInp);
            Controls.Add(appointmentNoteLbl);
            Controls.Add(vetNameLbl);
            Controls.Add(nameLbl);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet - Appointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private ListBox appointmentList;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox notesInp;
        private Label appointmentNoteLbl;
        private Label vetNameLbl;
        private Label nameLbl;
        private Label paragraphLbl;
        private Label headingLbl;
        private DateTimePicker dateInp;
        private Label appointmentDateLbl;
        private ComboBox vetCb;
        private ComboBox clientCb;
    }
}