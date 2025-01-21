using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateServicesList();
            Logger.WriteLog("App started.");
        }

        /* This version is used for the CheckListBox format and is deprecated
         * private void PopulateServicesList()
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                clServices.Items.Add(service.ServiceName);
            }
        } */

        private void PopulateServicesList() //Populate the list of Windows services into a DataGridView
        {
            // Clear existing rows for start/refresh
            dataGridView1.Rows.Clear();

            //initialize datagridview columns
            dataGridView1.Columns.Add("ServiceName", "Service Name");
            dataGridView1.Columns.Add("DisplayName", "Display Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("LogOnAs", "Log on ");

            //retrieve all services on local machine
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                //retrieve service info
                string serviceName = service.ServiceName;
                string displayName = service.DisplayName;
                string description = ""; //replace with WMI data if possible
                string logOnAs = ""; //replace with WMI data if possible
                string status = service.Status.ToString();

                string query = $"SELECT * FROM Win32_Service WHERE Name = '{serviceName}'";
                /* Disabled for testing - NOT FINISHED - WMI data retrieval for Desc and LogOnAs info
                 * ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                     foreach (ManagementObject serviceObj in searcher.Get())
                     {
                         string description = serviceObj["Description"]?.ToString() ?? "";
                         string logOnAs = serviceObj["StartName"]?.ToString() ?? "";
                         string status = service.Status.ToString();

                     }
                */

                //Add row to datagridview
                dataGridView1.Rows.Add(serviceName, displayName, description, status, logOnAs);
            }

        }

        private void bStop_Service_Click(object sender, EventArgs e)
        {
            try //Prep for potential exceptions
            {
                //Disabled checklist clServices - switched from checklist to datagridview
                //foreach (var item in clServices.CheckedItems)
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //Access data from the row
                    string serviceName = row.Cells["ServiceName"].Value.ToString();
                    string displayName = row.Cells["DisplayName"].Value.ToString();
                    StopService(serviceName);

                    //Disabled checklist functions
                    //string serviceName = DataGridView.
                    //StopService(serviceName);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"Exception occurred: {ex.Message}");
            }
        }

        private void StopService(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                    MessageBox.Show($"Service {serviceName} stopped successfully.");
                }
                else
                {
                    MessageBox.Show($"Service {serviceName} is not running.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping service {serviceName}: {ex.Message}");
            }
        }


        private void bStart_Service_Click(object sender, EventArgs e)
        {
            try //Prep for potential exceptions
            {
                //Disabled checklist clServices - switched from checklist to datagridview
                //foreach (var item in clServices.CheckedItems)
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //Access data from the row
                    string serviceName = row.Cells["ServiceName"].Value.ToString();
                    string displayName = row.Cells["DisplayName"].Value.ToString();
                    StartService(serviceName);

                    //Disabled checklist functions
                    //string serviceName = DataGridView.
                    //StopService(serviceName);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"Exception occurred: {ex.Message}");
            }
        }

        private void StartService(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                    MessageBox.Show($"Service {serviceName} started successfully.");
                }
                else
                {
                    MessageBox.Show($"Service {serviceName} could not be started.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting service {serviceName}: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bRefreshDGV1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            PopulateServicesList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bFilterSearch_Click(object sender, EventArgs e)
        {
            string filterText =  tbSearch.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the row contains the search text in any cell
                bool rowContainsText = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filterText))
                    { rowContainsText = true; break; }
                }
                // Hide or show the row based on the search text
                row.Visible = rowContainsText;
            }
        }

        private void bStop_IIS_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a ServiceController instance for IIS (W3SVC)
                ServiceController iisService = new ServiceController("W3SVC");

                //Check if service is running
                if (iisService.Status == ServiceControllerStatus.Running) 
                {
                //stop the service
                iisService.Stop();

                    //wait for the service to stop
                    iisService.WaitForStatus(ServiceControllerStatus.Stopped);
                    MessageBox.Show("IIS Service stopped successfully muh dude.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //If service is not running, message box user
                else
                {
                    MessageBox.Show("IIS Service is not currently running mang.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //catch exceptions for services not providing the expected stop response
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred while stopping the IIS Service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bStart_IIS_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a ServiceController instance for IIS (W3SVC)
                ServiceController iisService = new ServiceController("W3SVC");

                //Check if service is stopped
                if (iisService.Status == ServiceControllerStatus.Stopped)
                {
                    //start the service
                    iisService.Start();

                    //wait for the service to start
                    iisService.WaitForStatus(ServiceControllerStatus.Running);
                    MessageBox.Show("IIS Service started with tremendous gusto!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("IIS Service was not started and is feeling like a total failure.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting the IIS Service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
