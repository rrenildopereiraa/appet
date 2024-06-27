using Lib;

namespace Clinic
{
    public partial class VisualAppointment : Form
    {
        private List<Appointment> appointments;
        private string appointmentFile = "appointments.txt";
        private List<Client> clients;
        private List<Vet> vets;

        public VisualAppointment()
        {
            InitializeComponent();
            appointments = new List<Appointment>();
            clients = new List<Client>();
            vets = new List<Vet>();
            LoadData();
            LoadClients();
            LoadVets();
        }

        /// <summary>
        /// Lê os dados contidos no ficheiro - appointments.txt
        /// </summary>
        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(appointmentFile);

            foreach (var rowData in data)
            {
                appointments.Add(new Appointment
                {
                    Id = Convert.ToInt32(rowData[0]),
                    ClientName = rowData[1],
                    VetName = rowData[2],
                    AppointmentDateTime = DateTime.Parse(rowData[3]),
                    Notes = rowData[4]
                });
            }

            RefreshAppointmentList();
        }

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var appointment in appointments)
            {
                data.Add(new string[] { 
                    appointment.Id.ToString(), 
                    appointment.ClientName, appointment.VetName, 
                    appointment.AppointmentDateTime.ToString(), 
                    appointment.Notes
                });
            }

            FileHandler.SaveData(data, appointmentFile);
        }

        private void LoadClients()
        {
            clients = VisualClient.GetClients();
            clientCb.DataSource = clients;
            clientCb.DisplayMember = "Name";
        }

        private void LoadVets()
        {
            vets = VisualVet.GetVets();
            vetCb.DataSource = vets;
            vetCb.DisplayMember = "Name";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Appointment appointment = new Appointment
                {
                    Id = GetNextAppointmentId(),
                    ClientName = ((Client)clientCb.SelectedItem).Name,
                    VetName = ((Vet)vetCb.SelectedItem).Name,
                    AppointmentDateTime = dateInp.Value,
                    Notes = notesInp.Text
                };

                appointments.Add(appointment);
                SaveData();
                RefreshAppointmentList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Appointment selectedAppointment = (Appointment)appointmentList.SelectedItem;

                if (selectedAppointment != null)
                {
                    selectedAppointment.ClientName = (clientCb.SelectedItem as Client)?.Name;
                    selectedAppointment.VetName = (vetCb.SelectedItem as Vet)?.Name;
                    selectedAppointment.AppointmentDateTime = dateInp.Value;
                    selectedAppointment.Notes = notesInp.Text;

                    SaveData();
                    RefreshAppointmentList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Appointment selectedAppointment = (Appointment)appointmentList.SelectedItem;

            if (selectedAppointment != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to remove this appointment for {selectedAppointment.ClientName} with {selectedAppointment.VetName}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    appointments.Remove(selectedAppointment);
                    SaveData();
                    RefreshAppointmentList();
                    ClearForm();

                    MessageBox.Show($"The removal of appointment ID {selectedAppointment.Id} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to remove all appointments instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        appointments.Clear();
                        SaveData();
                        RefreshAppointmentList();
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

        private void RefreshAppointmentList()
        {
            appointmentList.DataSource = null;
            appointmentList.DataSource = appointments;
            appointmentList.DisplayMember = "ClientName";
        }

        private void ClearForm()
        {
            clientCb.SelectedItem = null;
            vetCb.SelectedItem = null;
            dateInp.Value = DateTime.Now;
            notesInp.Text = "";
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos ou vazios ou possuem somente espaços.
        /// </summary>
        /// <returns>Retorna verdadeiro se os campos encontram-se devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (clientCb.SelectedItem == null || vetCb.SelectedItem == null || dateInp.Value == DateTime.MinValue)
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtém o próximo ID da consulta
        /// </summary>
        /// <returns>Retorna o próximo ID</returns>
        private int GetNextAppointmentId()
        {
            return appointments.Count > 0 ? appointments[^1].Id + 1 : 1;
        }

        private void appointmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Appointment selectedAppointment = (Appointment)appointmentList.SelectedItem;
            if (selectedAppointment != null)
            {
                clientCb.SelectedItem = clients.FirstOrDefault(c => c.Name == selectedAppointment.ClientName);
                vetCb.SelectedItem = vets.FirstOrDefault(v => v.Name == selectedAppointment.VetName);

                dateInp.Value = selectedAppointment.AppointmentDateTime;
                notesInp.Text = selectedAppointment.Notes;
            }
        }
    }
}
