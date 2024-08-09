namespace CS_API_Tests {
    partial class FTestForm {
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
            this.LBLName = new Label();
            this.TBName = new TextBox();
            this.BTNSubmitPost = new Button();
            this.LBLSurname = new Label();
            this.LBLAge = new Label();
            this.TBSurname = new TextBox();
            this.TBAge = new TextBox();
            this.TBCMain = new TabControl();
            this.TBPost = new TabPage();
            this.TBGet = new TabPage();
            this.BTNSearchOneClear = new Button();
            this.LBLGetOneAge = new Label();
            this.LBLGetOneSurname = new Label();
            this.LBLGetOneName = new Label();
            this.BTNSubmitGetOne = new Button();
            this.TBSearchOne = new TextBox();
            this.LBLSearchBy = new Label();
            this.CMBCrit = new ComboBox();
            this.LBLGetOpt = new Label();
            this.TBGetMany = new TabPage();
            this.BTNGetManyClear = new Button();
            this.BTNDeleteUser = new Button();
            this.BTNDisplay = new Button();
            this.LBLGetManyAge = new Label();
            this.LBLGetManySurname = new Label();
            this.LBLGetManyName = new Label();
            this.CmbAllPeople = new ComboBox();
            this.LBLGetManySelect = new Label();
            this.BTNGetAll = new Button();
            this.TBGetManyAge = new TextBox();
            this.LBLGetManyAgeOpt = new Label();
            this.TBCMain.SuspendLayout();
            this.TBPost.SuspendLayout();
            this.TBGet.SuspendLayout();
            this.TBGetMany.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Font = new Font("Segoe UI", 20F);
            this.LBLName.Location = new Point(127, 3);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new Size(156, 37);
            this.LBLName.TabIndex = 0;
            this.LBLName.Text = "Enter Name";
            // 
            // TBName
            // 
            this.TBName.Font = new Font("Segoe UI", 16F);
            this.TBName.Location = new Point(127, 43);
            this.TBName.Name = "TBName";
            this.TBName.Size = new Size(158, 36);
            this.TBName.TabIndex = 0;
            // 
            // BTNSubmitPost
            // 
            this.BTNSubmitPost.Font = new Font("Segoe UI", 20F);
            this.BTNSubmitPost.Location = new Point(114, 259);
            this.BTNSubmitPost.Name = "BTNSubmitPost";
            this.BTNSubmitPost.Size = new Size(171, 63);
            this.BTNSubmitPost.TabIndex = 3;
            this.BTNSubmitPost.Text = "Submit";
            this.BTNSubmitPost.UseVisualStyleBackColor = true;
            this.BTNSubmitPost.Click += this.BTNSubmit_Click;
            // 
            // LBLSurname
            // 
            this.LBLSurname.AutoSize = true;
            this.LBLSurname.Font = new Font("Segoe UI", 20F);
            this.LBLSurname.Location = new Point(105, 82);
            this.LBLSurname.Name = "LBLSurname";
            this.LBLSurname.Size = new Size(189, 37);
            this.LBLSurname.TabIndex = 7;
            this.LBLSurname.Text = "Enter Surname";
            // 
            // LBLAge
            // 
            this.LBLAge.AutoSize = true;
            this.LBLAge.Font = new Font("Segoe UI", 20F);
            this.LBLAge.Location = new Point(127, 161);
            this.LBLAge.Name = "LBLAge";
            this.LBLAge.Size = new Size(132, 37);
            this.LBLAge.TabIndex = 8;
            this.LBLAge.Text = "Enter Age";
            // 
            // TBSurname
            // 
            this.TBSurname.Font = new Font("Segoe UI", 16F);
            this.TBSurname.Location = new Point(120, 122);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new Size(158, 36);
            this.TBSurname.TabIndex = 1;
            // 
            // TBAge
            // 
            this.TBAge.Font = new Font("Segoe UI", 16F);
            this.TBAge.Location = new Point(120, 201);
            this.TBAge.Name = "TBAge";
            this.TBAge.Size = new Size(158, 36);
            this.TBAge.TabIndex = 2;
            // 
            // TBCMain
            // 
            this.TBCMain.Controls.Add(this.TBPost);
            this.TBCMain.Controls.Add(this.TBGet);
            this.TBCMain.Controls.Add(this.TBGetMany);
            this.TBCMain.Dock = DockStyle.Fill;
            this.TBCMain.Location = new Point(0, 0);
            this.TBCMain.Name = "TBCMain";
            this.TBCMain.SelectedIndex = 0;
            this.TBCMain.Size = new Size(418, 607);
            this.TBCMain.TabIndex = 9;
            this.TBCMain.SelectedIndexChanged += this.TBCMain_SelectedIndexChanged;
            // 
            // TBPost
            // 
            this.TBPost.Controls.Add(this.TBName);
            this.TBPost.Controls.Add(this.TBAge);
            this.TBPost.Controls.Add(this.LBLName);
            this.TBPost.Controls.Add(this.TBSurname);
            this.TBPost.Controls.Add(this.BTNSubmitPost);
            this.TBPost.Controls.Add(this.LBLAge);
            this.TBPost.Controls.Add(this.LBLSurname);
            this.TBPost.Location = new Point(4, 24);
            this.TBPost.Name = "TBPost";
            this.TBPost.Padding = new Padding(3);
            this.TBPost.Size = new Size(410, 579);
            this.TBPost.TabIndex = 0;
            this.TBPost.Text = "Post Request";
            this.TBPost.UseVisualStyleBackColor = true;
            // 
            // TBGet
            // 
            this.TBGet.Controls.Add(this.BTNSearchOneClear);
            this.TBGet.Controls.Add(this.LBLGetOneAge);
            this.TBGet.Controls.Add(this.LBLGetOneSurname);
            this.TBGet.Controls.Add(this.LBLGetOneName);
            this.TBGet.Controls.Add(this.BTNSubmitGetOne);
            this.TBGet.Controls.Add(this.TBSearchOne);
            this.TBGet.Controls.Add(this.LBLSearchBy);
            this.TBGet.Controls.Add(this.CMBCrit);
            this.TBGet.Controls.Add(this.LBLGetOpt);
            this.TBGet.Location = new Point(4, 24);
            this.TBGet.Name = "TBGet";
            this.TBGet.Padding = new Padding(3);
            this.TBGet.Size = new Size(410, 579);
            this.TBGet.TabIndex = 1;
            this.TBGet.Text = "Get One Request";
            this.TBGet.UseVisualStyleBackColor = true;
            // 
            // BTNSearchOneClear
            // 
            this.BTNSearchOneClear.Font = new Font("Segoe UI", 20F);
            this.BTNSearchOneClear.Location = new Point(8, 367);
            this.BTNSearchOneClear.Name = "BTNSearchOneClear";
            this.BTNSearchOneClear.Size = new Size(171, 63);
            this.BTNSearchOneClear.TabIndex = 9;
            this.BTNSearchOneClear.Text = "Clear";
            this.BTNSearchOneClear.UseVisualStyleBackColor = true;
            this.BTNSearchOneClear.Click += this.BTNSearchOneClear_Click;
            // 
            // LBLGetOneAge
            // 
            this.LBLGetOneAge.AutoSize = true;
            this.LBLGetOneAge.Font = new Font("Segoe UI", 20F);
            this.LBLGetOneAge.Location = new Point(8, 327);
            this.LBLGetOneAge.Name = "LBLGetOneAge";
            this.LBLGetOneAge.Size = new Size(70, 37);
            this.LBLGetOneAge.TabIndex = 8;
            this.LBLGetOneAge.Text = "Age:";
            // 
            // LBLGetOneSurname
            // 
            this.LBLGetOneSurname.AutoSize = true;
            this.LBLGetOneSurname.Font = new Font("Segoe UI", 20F);
            this.LBLGetOneSurname.Location = new Point(8, 290);
            this.LBLGetOneSurname.Name = "LBLGetOneSurname";
            this.LBLGetOneSurname.Size = new Size(127, 37);
            this.LBLGetOneSurname.TabIndex = 7;
            this.LBLGetOneSurname.Text = "Surname:";
            // 
            // LBLGetOneName
            // 
            this.LBLGetOneName.AutoSize = true;
            this.LBLGetOneName.Font = new Font("Segoe UI", 20F);
            this.LBLGetOneName.Location = new Point(8, 253);
            this.LBLGetOneName.Name = "LBLGetOneName";
            this.LBLGetOneName.Size = new Size(101, 37);
            this.LBLGetOneName.TabIndex = 6;
            this.LBLGetOneName.Text = "Name: ";
            // 
            // BTNSubmitGetOne
            // 
            this.BTNSubmitGetOne.Font = new Font("Segoe UI", 20F);
            this.BTNSubmitGetOne.Location = new Point(8, 164);
            this.BTNSubmitGetOne.Name = "BTNSubmitGetOne";
            this.BTNSubmitGetOne.Size = new Size(171, 63);
            this.BTNSubmitGetOne.TabIndex = 5;
            this.BTNSubmitGetOne.Text = "Submit";
            this.BTNSubmitGetOne.UseVisualStyleBackColor = true;
            this.BTNSubmitGetOne.Click += this.BTNSubmitGetOne_Click;
            // 
            // TBSearchOne
            // 
            this.TBSearchOne.Font = new Font("Segoe UI", 16F);
            this.TBSearchOne.Location = new Point(8, 122);
            this.TBSearchOne.Name = "TBSearchOne";
            this.TBSearchOne.Size = new Size(158, 36);
            this.TBSearchOne.TabIndex = 4;
            // 
            // LBLSearchBy
            // 
            this.LBLSearchBy.AutoSize = true;
            this.LBLSearchBy.Font = new Font("Segoe UI", 20F);
            this.LBLSearchBy.Location = new Point(3, 82);
            this.LBLSearchBy.Name = "LBLSearchBy";
            this.LBLSearchBy.Size = new Size(130, 37);
            this.LBLSearchBy.TabIndex = 3;
            this.LBLSearchBy.Text = "Search By";
            // 
            // CMBCrit
            // 
            this.CMBCrit.Font = new Font("Segoe UI", 15F);
            this.CMBCrit.FormattingEnabled = true;
            this.CMBCrit.Items.AddRange(new object[] { "Name", "Surname", "Age" });
            this.CMBCrit.Location = new Point(8, 43);
            this.CMBCrit.Name = "CMBCrit";
            this.CMBCrit.Size = new Size(240, 36);
            this.CMBCrit.TabIndex = 2;
            this.CMBCrit.Text = "Select";
            this.CMBCrit.SelectedIndexChanged += this.CMBCrit_SelectedIndexChanged;
            // 
            // LBLGetOpt
            // 
            this.LBLGetOpt.AutoSize = true;
            this.LBLGetOpt.Font = new Font("Segoe UI", 20F);
            this.LBLGetOpt.Location = new Point(8, 3);
            this.LBLGetOpt.Name = "LBLGetOpt";
            this.LBLGetOpt.Size = new Size(256, 37);
            this.LBLGetOpt.TabIndex = 1;
            this.LBLGetOpt.Text = "Enter Search Criteria";
            // 
            // TBGetMany
            // 
            this.TBGetMany.Controls.Add(this.BTNGetManyClear);
            this.TBGetMany.Controls.Add(this.BTNDeleteUser);
            this.TBGetMany.Controls.Add(this.BTNDisplay);
            this.TBGetMany.Controls.Add(this.LBLGetManyAge);
            this.TBGetMany.Controls.Add(this.LBLGetManySurname);
            this.TBGetMany.Controls.Add(this.LBLGetManyName);
            this.TBGetMany.Controls.Add(this.CmbAllPeople);
            this.TBGetMany.Controls.Add(this.LBLGetManySelect);
            this.TBGetMany.Controls.Add(this.BTNGetAll);
            this.TBGetMany.Controls.Add(this.TBGetManyAge);
            this.TBGetMany.Controls.Add(this.LBLGetManyAgeOpt);
            this.TBGetMany.Location = new Point(4, 24);
            this.TBGetMany.Name = "TBGetMany";
            this.TBGetMany.Size = new Size(410, 579);
            this.TBGetMany.TabIndex = 2;
            this.TBGetMany.Text = "Get Many";
            this.TBGetMany.UseVisualStyleBackColor = true;
            // 
            // BTNGetManyClear
            // 
            this.BTNGetManyClear.Font = new Font("Segoe UI", 20F);
            this.BTNGetManyClear.Location = new Point(8, 478);
            this.BTNGetManyClear.Name = "BTNGetManyClear";
            this.BTNGetManyClear.Size = new Size(171, 63);
            this.BTNGetManyClear.TabIndex = 14;
            this.BTNGetManyClear.Text = "Clear";
            this.BTNGetManyClear.UseVisualStyleBackColor = true;
            this.BTNGetManyClear.Click += this.BTNGetManyClear_Click;
            // 
            // BTNDeleteUser
            // 
            this.BTNDeleteUser.Font = new Font("Segoe UI", 20F);
            this.BTNDeleteUser.Location = new Point(8, 409);
            this.BTNDeleteUser.Name = "BTNDeleteUser";
            this.BTNDeleteUser.Size = new Size(171, 63);
            this.BTNDeleteUser.TabIndex = 13;
            this.BTNDeleteUser.Text = "Delete User";
            this.BTNDeleteUser.UseVisualStyleBackColor = true;
            this.BTNDeleteUser.Click += this.BTNDeleteUser_Click;
            // 
            // BTNDisplay
            // 
            this.BTNDisplay.Font = new Font("Segoe UI", 20F);
            this.BTNDisplay.Location = new Point(8, 200);
            this.BTNDisplay.Name = "BTNDisplay";
            this.BTNDisplay.Size = new Size(171, 63);
            this.BTNDisplay.TabIndex = 12;
            this.BTNDisplay.Text = "Display";
            this.BTNDisplay.UseVisualStyleBackColor = true;
            this.BTNDisplay.Click += this.BTNDisplay_Click;
            // 
            // LBLGetManyAge
            // 
            this.LBLGetManyAge.AutoSize = true;
            this.LBLGetManyAge.Font = new Font("Segoe UI", 20F);
            this.LBLGetManyAge.Location = new Point(8, 354);
            this.LBLGetManyAge.Name = "LBLGetManyAge";
            this.LBLGetManyAge.Size = new Size(70, 37);
            this.LBLGetManyAge.TabIndex = 11;
            this.LBLGetManyAge.Text = "Age:";
            // 
            // LBLGetManySurname
            // 
            this.LBLGetManySurname.AutoSize = true;
            this.LBLGetManySurname.Font = new Font("Segoe UI", 20F);
            this.LBLGetManySurname.Location = new Point(8, 317);
            this.LBLGetManySurname.Name = "LBLGetManySurname";
            this.LBLGetManySurname.Size = new Size(127, 37);
            this.LBLGetManySurname.TabIndex = 10;
            this.LBLGetManySurname.Text = "Surname:";
            // 
            // LBLGetManyName
            // 
            this.LBLGetManyName.AutoSize = true;
            this.LBLGetManyName.Font = new Font("Segoe UI", 20F);
            this.LBLGetManyName.Location = new Point(8, 280);
            this.LBLGetManyName.Name = "LBLGetManyName";
            this.LBLGetManyName.Size = new Size(101, 37);
            this.LBLGetManyName.TabIndex = 9;
            this.LBLGetManyName.Text = "Name: ";
            // 
            // CmbAllPeople
            // 
            this.CmbAllPeople.Font = new Font("Segoe UI", 15F);
            this.CmbAllPeople.FormattingEnabled = true;
            this.CmbAllPeople.Location = new Point(8, 158);
            this.CmbAllPeople.Name = "CmbAllPeople";
            this.CmbAllPeople.Size = new Size(240, 36);
            this.CmbAllPeople.TabIndex = 8;
            this.CmbAllPeople.Text = "No Users";
            // 
            // LBLGetManySelect
            // 
            this.LBLGetManySelect.AutoSize = true;
            this.LBLGetManySelect.Font = new Font("Segoe UI", 20F);
            this.LBLGetManySelect.Location = new Point(8, 118);
            this.LBLGetManySelect.Name = "LBLGetManySelect";
            this.LBLGetManySelect.Size = new Size(301, 37);
            this.LBLGetManySelect.TabIndex = 7;
            this.LBLGetManySelect.Text = "Select Person To Display";
            // 
            // BTNGetAll
            // 
            this.BTNGetAll.Font = new Font("Segoe UI", 20F);
            this.BTNGetAll.Location = new Point(8, 40);
            this.BTNGetAll.Name = "BTNGetAll";
            this.BTNGetAll.Size = new Size(171, 63);
            this.BTNGetAll.TabIndex = 6;
            this.BTNGetAll.Text = "Get All";
            this.BTNGetAll.UseVisualStyleBackColor = true;
            this.BTNGetAll.Click += this.BTNGetAll_Click;
            // 
            // TBGetManyAge
            // 
            this.TBGetManyAge.Font = new Font("Segoe UI", 16F);
            this.TBGetManyAge.Location = new Point(244, 3);
            this.TBGetManyAge.Name = "TBGetManyAge";
            this.TBGetManyAge.Size = new Size(158, 36);
            this.TBGetManyAge.TabIndex = 5;
            // 
            // LBLGetManyAgeOpt
            // 
            this.LBLGetManyAgeOpt.AutoSize = true;
            this.LBLGetManyAgeOpt.Font = new Font("Segoe UI", 20F);
            this.LBLGetManyAgeOpt.Location = new Point(0, 0);
            this.LBLGetManyAgeOpt.Name = "LBLGetManyAgeOpt";
            this.LBLGetManyAgeOpt.Size = new Size(217, 37);
            this.LBLGetManyAgeOpt.TabIndex = 2;
            this.LBLGetManyAgeOpt.Text = "Enter Search Age";
            // 
            // FTestForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(418, 607);
            this.Controls.Add(this.TBCMain);
            this.Name = "FTestForm";
            this.Text = "API Test Form";
            this.TBCMain.ResumeLayout(false);
            this.TBPost.ResumeLayout(false);
            this.TBPost.PerformLayout();
            this.TBGet.ResumeLayout(false);
            this.TBGet.PerformLayout();
            this.TBGetMany.ResumeLayout(false);
            this.TBGetMany.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label LBLName;
        private TextBox TBName;
        private Button BTNSubmitPost;
        private Label LBLSurname;
        private Label LBLAge;
        private TextBox TBSurname;
        private TextBox TBAge;
        private TabControl TBCMain;
        private TabPage TBPost;
        private TabPage TBGet;
        private Label LBLGetOpt;
        private ComboBox CMBCrit;
        private TabPage TBGetMany;
        private Button BTNSubmitGetOne;
        private TextBox TBSearchOne;
        private Label LBLGetOneAge;
        private Label LBLGetOneSurname;
        private Label LBLGetOneName;
        private Label LBLSearchBy;
        private Button BTNDisplay;
        private Label LBLGetManyAge;
        private Label LBLGetManySurname;
        private Label LBLGetManyName;
        private ComboBox CmbAllPeople;
        private Label LBLGetManySelect;
        private Button BTNGetAll;
        private TextBox TBGetManyAge;
        private Label LBLGetManyAgeOpt;
        private Button BTNSearchOneClear;
        private Button BTNGetManyClear;
        private Button BTNDeleteUser;
    }
}
