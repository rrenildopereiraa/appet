using Lib;

namespace Clinic
{
    public partial class VisualClient : Form
    {
        private List<Client> clients;
        private string clientFile = "clients.txt";

        public VisualClient()
        {
            InitializeComponent();
            clients = new List<Client>();
            LoadData();
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(clientFile);

            foreach (var rowData in data)
            {
                clients.Add(new Client
                {
                    Id = Convert.ToInt32(rowData[0]),
                    Name = rowData[1],
                    Address = rowData[2],
                    Phone = rowData[3]
                });
            }

            RefreshClientList();
        }

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var client in clients)
            {
                data.Add(new string[] { 
                    client.Id.ToString(), 
                    client.Name, client.Address, 
                    client.Phone 
                });
            }

            FileHandler.SaveData(data, clientFile);
        }

        /// <summary>
        /// Obtém a lista de clientes do ficheiro - clients.txt
        /// </summary>
        /// <returns>Retorna a lista de clientes.</returns>
        public static List<Client> GetClients()
        {
            VisualClient vc = new VisualClient();
            return vc.clients;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Client client = new Client
                {
                    Id = GetNextClientId(),
                    Name = nameInp.Text,
                    Address = addressInp.Text,
                    Phone = phoneInp.Text
                };

                clients.Add(client);
                SaveData();
                RefreshClientList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Client selectedClient = (Client)clientList.SelectedItem;

                if (selectedClient != null)
                {
                    selectedClient.Name = nameInp.Text;
                    selectedClient.Address = addressInp.Text;
                    selectedClient.Phone = phoneInp.Text;

                    SaveData();
                    RefreshClientList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientList.SelectedItem;

            if (selectedClient != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to remove {selectedClient.Name}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    clients.Remove(selectedClient);
                    SaveData();
                    RefreshClientList();
                    ClearForm();

                    MessageBox.Show($"The removal of {selectedClient.Name} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to remove all clients instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        clients.Clear();
                        SaveData();
                        RefreshClientList();
                        ClearForm();

                        MessageBox.Show("All removals have been successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela carateres alfabéticos.
        /// </summary>
        /// <param name="sender">Utilizador.</param>
        /// <param name="e">Evento.</param>
        private void phoneInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("That doesn't appear to be a number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshClientList()
        {
            clientList.DataSource = null;
            clientList.DataSource = clients;
            clientList.DisplayMember = "Name";
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            addressInp.Text = "";
            phoneInp.Text = "";
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos ou vazios ou possuem somente espaços.
        /// </summary>
        /// <returns>Retorna verdadeiro se os campos encontram-se devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) || string.IsNullOrWhiteSpace(addressInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtém o próximo ID de clientes
        /// </summary>
        /// <returns>Retorna o próximo ID</returns>
        private int GetNextClientId()
        {
            return clients.Count > 0 ? clients[^1].Id + 1 : 1;
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientList.SelectedItem;
            if (selectedClient != null)
            {
                nameInp.Text = selectedClient.Name;
                addressInp.Text = selectedClient.Address;
                phoneInp.Text = selectedClient.Phone;
            }
        }
    }
}
