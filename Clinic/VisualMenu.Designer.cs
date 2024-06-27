namespace Clinic
{
    partial class VisualMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualMenu));
            sidePanel = new Panel();
            learnBtn = new Button();
            getStartedBtn = new Button();
            sideParagraphLbl = new Label();
            sideHeadingLbl = new Label();
            headingLbl = new Label();
            paragraphLbl = new Label();
            introductionLbl = new Label();
            appointmentBtn = new Button();
            clientBtn = new Button();
            observatoryBtn = new Button();
            vetBtn = new Button();
            animalBtn = new Button();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(15, 23, 42);
            sidePanel.Controls.Add(learnBtn);
            sidePanel.Controls.Add(getStartedBtn);
            sidePanel.Controls.Add(sideParagraphLbl);
            sidePanel.Controls.Add(sideHeadingLbl);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(270, 417);
            sidePanel.TabIndex = 0;
            // 
            // learnBtn
            // 
            learnBtn.BackColor = Color.FromArgb(30, 41, 59);
            learnBtn.FlatAppearance.BorderSize = 0;
            learnBtn.FlatStyle = FlatStyle.Flat;
            learnBtn.ForeColor = Color.FromArgb(243, 244, 245);
            learnBtn.Location = new Point(12, 322);
            learnBtn.Name = "learnBtn";
            learnBtn.Size = new Size(240, 40);
            learnBtn.TabIndex = 1;
            learnBtn.Text = "Learn more";
            learnBtn.UseVisualStyleBackColor = false;
            learnBtn.Click += viewGitHubBtn_Click;
            // 
            // getStartedBtn
            // 
            getStartedBtn.BackColor = Color.FromArgb(125, 211, 252);
            getStartedBtn.FlatAppearance.BorderSize = 0;
            getStartedBtn.FlatStyle = FlatStyle.Flat;
            getStartedBtn.ForeColor = Color.FromArgb(15, 23, 42);
            getStartedBtn.Location = new Point(12, 276);
            getStartedBtn.Name = "getStartedBtn";
            getStartedBtn.Size = new Size(240, 40);
            getStartedBtn.TabIndex = 0;
            getStartedBtn.Text = "Get Started";
            getStartedBtn.UseVisualStyleBackColor = false;
            getStartedBtn.Click += getStartedBtn_Click;
            // 
            // sideParagraphLbl
            // 
            sideParagraphLbl.AutoSize = true;
            sideParagraphLbl.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            sideParagraphLbl.ForeColor = Color.FromArgb(148, 163, 184);
            sideParagraphLbl.Location = new Point(12, 167);
            sideParagraphLbl.Name = "sideParagraphLbl";
            sideParagraphLbl.Size = new Size(240, 42);
            sideParagraphLbl.TabIndex = 1;
            sideParagraphLbl.Text = "Easily manage animals,\r\nclients, vets and more.";
            // 
            // sideHeadingLbl
            // 
            sideHeadingLbl.AutoSize = true;
            sideHeadingLbl.Font = new Font("JetBrains Mono", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            sideHeadingLbl.ForeColor = Color.FromArgb(192, 209, 254);
            sideHeadingLbl.Location = new Point(12, 65);
            sideHeadingLbl.Name = "sideHeadingLbl";
            sideHeadingLbl.Size = new Size(228, 86);
            sideHeadingLbl.TabIndex = 0;
            sideHeadingLbl.Text = "Clinic made\r\nsimple.";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(288, 31);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(378, 31);
            headingLbl.TabIndex = 1;
            headingLbl.Text = "Getting Started with Appet";
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(288, 83);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(333, 38);
            paragraphLbl.TabIndex = 2;
            paragraphLbl.Text = "Pawlinic enables the user to operate\r\ntypical clinic functions.";
            // 
            // introductionLbl
            // 
            introductionLbl.AutoSize = true;
            introductionLbl.ForeColor = Color.FromArgb(36, 173, 235);
            introductionLbl.Location = new Point(288, 167);
            introductionLbl.Name = "introductionLbl";
            introductionLbl.Size = new Size(98, 16);
            introductionLbl.TabIndex = 3;
            introductionLbl.Text = "Introduction:";
            // 
            // appointmentBtn
            // 
            appointmentBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            appointmentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            appointmentBtn.FlatStyle = FlatStyle.Flat;
            appointmentBtn.ForeColor = Color.FromArgb(67, 80, 98);
            appointmentBtn.Location = new Point(498, 200);
            appointmentBtn.Name = "appointmentBtn";
            appointmentBtn.Size = new Size(100, 205);
            appointmentBtn.TabIndex = 5;
            appointmentBtn.Text = "Appointment\r\n📝";
            appointmentBtn.UseVisualStyleBackColor = true;
            appointmentBtn.Click += appointmentBtn_Click;
            // 
            // clientBtn
            // 
            clientBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            clientBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            clientBtn.FlatStyle = FlatStyle.Flat;
            clientBtn.ForeColor = Color.FromArgb(67, 80, 98);
            clientBtn.Location = new Point(286, 200);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(100, 205);
            clientBtn.TabIndex = 3;
            clientBtn.Text = "Client\r\n👥";
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // observatoryBtn
            // 
            observatoryBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            observatoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            observatoryBtn.FlatStyle = FlatStyle.Flat;
            observatoryBtn.ForeColor = Color.FromArgb(67, 80, 98);
            observatoryBtn.Location = new Point(710, 200);
            observatoryBtn.Name = "observatoryBtn";
            observatoryBtn.Size = new Size(100, 205);
            observatoryBtn.TabIndex = 7;
            observatoryBtn.Text = "Observatory\r\n🔎";
            observatoryBtn.UseVisualStyleBackColor = true;
            observatoryBtn.Click += observatoryBtn_Click;
            // 
            // vetBtn
            // 
            vetBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            vetBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            vetBtn.FlatStyle = FlatStyle.Flat;
            vetBtn.ForeColor = Color.FromArgb(67, 80, 98);
            vetBtn.Location = new Point(604, 200);
            vetBtn.Name = "vetBtn";
            vetBtn.Size = new Size(100, 205);
            vetBtn.TabIndex = 6;
            vetBtn.Text = "Vet\r\n👨🏽‍⚕️";
            vetBtn.UseVisualStyleBackColor = true;
            vetBtn.Click += vetBtn_Click;
            // 
            // animalBtn
            // 
            animalBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            animalBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            animalBtn.FlatStyle = FlatStyle.Flat;
            animalBtn.ForeColor = Color.FromArgb(67, 80, 98);
            animalBtn.Location = new Point(392, 200);
            animalBtn.Name = "animalBtn";
            animalBtn.Size = new Size(100, 205);
            animalBtn.TabIndex = 4;
            animalBtn.Text = "Animal\r\n\U0001f9b4";
            animalBtn.UseVisualStyleBackColor = true;
            animalBtn.Click += animalBtn_Click;
            // 
            // VisualMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 417);
            Controls.Add(animalBtn);
            Controls.Add(vetBtn);
            Controls.Add(observatoryBtn);
            Controls.Add(clientBtn);
            Controls.Add(appointmentBtn);
            Controls.Add(introductionLbl);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(sidePanel);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appet";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidePanel;
        private Label sideParagraphLbl;
        private Label sideHeadingLbl;
        private Label headingLbl;
        private Label paragraphLbl;
        private Label introductionLbl;
        private Button appointmentBtn;
        private Button clientBtn;
        private Button observatoryBtn;
        private Button vetBtn;
        private Button learnBtn;
        private Button getStartedBtn;
        private Button animalBtn;
    }
}
