﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Client.Domain.Interfaces;
using TMS.Client.Domain.Services;
using TMS.Clientes.Repository.Repository;
using TMS.Clientes.Service.Model;
using TMS.UI.ClientForms;

namespace TMS.UI
{
    public partial class ClientsForm : Form
    {
        private readonly ClientService clientService;
        private List<ClientDto> clients = new List<ClientDto>();
        public ClientsForm()
        {
            clientService = new ClientService(new ClientDomainService(new ClientRepository()));

            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            clients = clientService.GetAll().ToList();
            dataGridView1.DataSource = clients;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var addClientForm = new CreateOrUpdateClientForm(null);

            Hide();

            addClientForm.Closed += (s, args) => Show();
            addClientForm.Show();

            RefreshDataSource();
        }

        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnDelete.Enabled = !btnDelete.Enabled;
                btnEdit.Enabled = !btnEdit.Enabled;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var clientIndex = dataGridView1.CurrentCell.RowIndex;

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer eliminar este cliente?", "Confirmação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                clientService.Delete(clients[clientIndex].Id);
                RefreshDataSource();
            }
        }

        private void RefreshDataSource()
        {
            clients = clientService.GetAll().ToList();
            dataGridView1.DataSource = clients;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var selectedClient = clients[dataGridView1.CurrentCell.RowIndex];
            var addClientForm = new CreateOrUpdateClientForm(selectedClient);

            Hide();

            addClientForm.Closed += (s, args) => Show();
            addClientForm.Show();

            RefreshDataSource();
        }
    }
}
