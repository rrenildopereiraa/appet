using Lib;

namespace Clinic
{
    public partial class VisualObservatory : Form
    {
        private List<Observatory> observatories;
        private string observatoryFile = "observatories.txt";

        public VisualObservatory()
        {
            InitializeComponent();
            observatories = new List<Observatory>();
            LoadData();
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(observatoryFile);

            foreach (var rowData in data)
            {
                observatories.Add(new Observatory
                {
                    Id = Convert.ToInt32(rowData[0]),
                    Name = rowData[1],
                    Location = rowData[2],
                    TelescopesCount = Convert.ToInt32(rowData[3])
                });
            }

            RefreshObservatoryList();
        }

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var observatory in observatories)
            {
                data.Add(new string[] { 
                    observatory.Id.ToString(), 
                    observatory.Name, observatory.Location, 
                    observatory.TelescopesCount.ToString() 
                });
            }

            FileHandler.SaveData(data, observatoryFile);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Observatory observatory = new Observatory
                {
                    Id = GetNextObservatoryId(),
                    Name = nameInp.Text,
                    Location = locationInp.Text,
                    TelescopesCount = Convert.ToInt32(telescopeInp.Text)
                };

                observatories.Add(observatory);
                SaveData();
                RefreshObservatoryList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Observatory selectedObservatory = (Observatory)observatoryList.SelectedItem;

                if (selectedObservatory != null)
                {
                    selectedObservatory.Name = nameInp.Text;
                    selectedObservatory.Location = locationInp.Text;
                    selectedObservatory.TelescopesCount = Convert.ToInt32(telescopeInp.Text);

                    SaveData();
                    RefreshObservatoryList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Observatory selectedObservatory = (Observatory)observatoryList.SelectedItem;

            if (selectedObservatory != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to delete {selectedObservatory.Name}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    observatories.Remove(selectedObservatory);
                    SaveData();
                    RefreshObservatoryList();
                    ClearForm();

                    MessageBox.Show($"The deletion of {selectedObservatory.Name} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to delete all observatories instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        observatories.Clear();
                        SaveData();
                        RefreshObservatoryList();
                        ClearForm();

                        MessageBox.Show("All deletions have been successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void telescope_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("That doesn't appear to be a number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshObservatoryList()
        {
            observatoryList.DataSource = null;
            observatoryList.DataSource = observatories;
            observatoryList.DisplayMember = "Name";
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            locationInp.Text = "";
            telescopeInp.Text = "";
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos ou vazios ou possuem somente espaços.
        /// </summary>
        /// <returns>Retorna verdadeiro se os campos encontram-se devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) || string.IsNullOrWhiteSpace(locationInp.Text) || string.IsNullOrWhiteSpace(telescopeInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtém o próximo ID do observatório
        /// </summary>
        /// <returns>Retorna o próximo ID</returns>
        private int GetNextObservatoryId()
        {
            return observatories.Count > 0 ? observatories[^1].Id + 1 : 1;
        }

        private void observatoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Observatory selectedObservatory = (Observatory)observatoryList.SelectedItem;
            if (selectedObservatory != null)
            {
                nameInp.Text = selectedObservatory.Name;
                locationInp.Text = selectedObservatory.Location;
                telescopeInp.Text = selectedObservatory.TelescopesCount.ToString();
            }
        }
    }
}
