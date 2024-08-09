using System.Net.Http.Json;
using Api_Class_Library;

namespace CS_API_Tests {
    public partial class FTestForm : Form {
        private readonly string SEARCH_BY = "Search by";
        private readonly API_Handler handler;
        private List<User> users;
        public FTestForm() {
            InitializeComponent();
            this.handler = new("https://localhost:3050");
            this.users = [];
        }

        private async void BTNSubmit_Click(object sender, EventArgs e) {
            if (this.TBName.Text.Trim() == string.Empty) {
                MessageBox.Show(this, "No name was added!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TBName.Focus();
                return;
            }
            if (this.TBSurname.Text.Trim() == string.Empty) {
                MessageBox.Show(this, "No surname was added!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TBSurname.Focus();
                return;
            }
            if (this.TBAge.Text.Trim() == string.Empty) {
                MessageBox.Show(this, "No age was added!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TBAge.Focus();
                return;
            }
            try {
                Convert.ToInt32(this.TBAge.Text);
            } catch (FormatException) {
                MessageBox.Show(this, "A Valid age needs to be added", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TBAge.Focus();
                return;
            }
            string name = TBName.Text;

            string surname = TBSurname.Text;
            string age = TBAge.Text;

            ApiResponseCodeMessage result = await this.handler.PostToServer("add-user", name, surname, age);

            if (result.Code == 200) {
                MessageBox.Show(this, result.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TBName.Clear();
                this.TBSurname.Clear();
                this.TBAge.Clear();
                this.TBName.Focus();
            } else {
                MessageBox.Show(this, result.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BTNSubmitGetOne_Click(object sender, EventArgs e) {
            if (this.CMBCrit.SelectedIndex == -1) {
                MessageBox.Show(this, "Please select a search Criteria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CMBCrit.Focus();
                return;
            }

            if (this.TBSearchOne.Text.Trim() == string.Empty) {
                MessageBox.Show(this, "Please enter a search value", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TBSearchOne.Focus();
                return;
            }

            if (this.CMBCrit.SelectedIndex == 2) {
                try {
                    Convert.ToInt32(this.TBSearchOne.Text);
                } catch (FormatException) {
                    MessageBox.Show(this, "A Valid age needs to be added", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TBSearchOne.Focus();
                    return;
                }
            }

            string critetria = CMBCrit.Text;
            string searchOpt = TBSearchOne.Text;

            ApiResponseOne result = await this.handler.GetFromServer("get-one", critetria, searchOpt);

            switch (result.Code) {
                case 200: {
                    MessageBox.Show(this, $"Found by {critetria} value: {searchOpt}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LBLGetOneName.Text = $"Name: {result.NewUser.Name}";
                    LBLGetOneSurname.Text = $"Surname: {result.NewUser.Surname}";
                    LBLGetOneAge.Text = $"Age: {result.NewUser.Age}";
                    break;
                }
                case 404: {
                    MessageBox.Show(this, $"No user found by {critetria} with search {searchOpt}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                case 500: {
                    MessageBox.Show(this, $"Server Error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private async void BTNGetAll_Click(object sender, EventArgs e) {
            if (this.TBGetManyAge.Text.Trim() == string.Empty) {
                MessageBox.Show(this, "No age was added!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                Convert.ToInt32(this.TBGetManyAge.Text);
            } catch (FormatException) {
                MessageBox.Show(this, "A Valid Age needs to be entered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string age = this.TBGetManyAge.Text;

            ApiResponseMany result = await this.handler.GetManyServer("get-many", age);
            switch (result.Code) {
                case 200: {
                    MessageBox.Show(this, $"{result.Users.Count()} users found at age {age}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.users = result.Users;
                    break;
                }
                case 201: {
                    MessageBox.Show(this, $"No Users found at age {age}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                case 500: {
                    MessageBox.Show(this, "Internal Server Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            this.InitGetMany();
        }

        private void BTNDisplay_Click(object sender, EventArgs e) {
            if (this.CmbAllPeople.SelectedIndex == -1) {
                MessageBox.Show(this, "Select a Person to display", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User selectedUser = this.users[this.CmbAllPeople.SelectedIndex];
            this.LBLGetManyName.Text = $"Name: {selectedUser.Name}";
            this.LBLGetManySurname.Text = $"Surname: {selectedUser.Surname}";
            this.LBLGetManyAge.Text = $"Age: {selectedUser.Age}";
        }

        private async void BTNDeleteUser_Click(object sender, EventArgs e) {
            int idx = this.CmbAllPeople.SelectedIndex;
            User selectedUser = this.users[idx];

            ApiResponseCodeMessage response = await this.handler.DeleteFromServer("delete-one", selectedUser._ID);

            switch (response.Code) {
                case 200: {
                    MessageBox.Show(this, $"User {this.users[idx].Name} {this.users[idx].Surname} Deleted", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTNGetManyClear_Click(sender, e);
                    break;
                }
                case 500: {
                    MessageBox.Show(this, "Internal Server Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            this.InitGetMany();
        }

        private void CMBCrit_SelectedIndexChanged(object sender, EventArgs e) {
            string searchCriteria = this.CMBCrit.Text;
            this.LBLSearchBy.Text = $"{this.SEARCH_BY} {searchCriteria}";
        }

        private void BTNSearchOneClear_Click(object sender, EventArgs e) {
            this.CMBCrit.SelectedIndex = -1;
            this.CMBCrit.Text = "Select";
            this.CMBCrit.Focus();
            this.TBSearchOne.Clear();
            this.LBLGetOneName.Text = "Name: ";
            this.LBLGetOneSurname.Text = "Surname: ";
            this.LBLGetOneAge.Text = "Age: ";
        }

        private void BTNGetManyClear_Click(object sender, EventArgs e) {
            this.TBGetManyAge.Clear();
            this.TBGetManyAge.Focus();
            this.CmbAllPeople.SelectedIndex = -1;
            this.CmbAllPeople.Items.Clear();
            this.CmbAllPeople.Text = "No Users";
            this.LBLGetManyName.Text = "Name: ";
            this.LBLGetManySurname.Text = "Surname: ";
            this.LBLGetManyAge.Text = "Age: ";
            this.users.Clear();
        }

        private void TBCMain_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.TBCMain.SelectedTab == this.TBPost) {
                this.TBName.Focus();
            } else if (this.TBCMain.SelectedTab == this.TBGet) {
                this.CMBCrit.Focus();
            } else {
                this.TBGetManyAge.Focus();
            }
        }

        private void InitGetMany() {
            this.CmbAllPeople.Items.Clear();
            this.users.ForEach(user => this.CmbAllPeople.Items.Add(user.Name));
            if (this.CmbAllPeople.Items.Count > 0) {
                this.CmbAllPeople.Text = "Select User";
            } else {
                this.CmbAllPeople.Text = "No Users";
            }
        }
    }
}
