using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;
using Models;
using BusinessLayer.Validator;

namespace Program
{
    public partial class Form1 : Form
    {
        Controllers podController;
        private string errorMessage;
        private string validator = "Validering";
        private bool isValid = true;
        public Form1()
        {
            InitializeComponent();
            this.podController = new Controllers();
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            //podController.CreatePodcast(txtUrl, cBoxFreq.Text, cBoxCat.Text
            if (!Validator.ValidLink(txtUrl.Text))
            {
                errorMessage = "Vänligen ange en länk med ett RSS-feed!";
                isValid = false;
            }
            

                if (isValid == false) {
                MessageBox.Show(errorMessage, validator, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Podcast podCast = podController.CreatePodcast(txtUrl.Text, cBoxFreq.Text, cBoxCat.Text);

            dataGridView1.Rows.Add(podCast.episodes, podCast.title, podCast.frequency, podCast.category);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Controllers.returnEpisodeList();
        }

        private void cBoxFreq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Kan inte ta bort den valda raden", validator, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
