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

namespace Program
{
    public partial class Form1 : Form
    {
        Controllers podController;
        public Form1()
        {
            InitializeComponent();
            this.podController = new Controllers();

        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            podController.CreatePodcast(txtUrl.Text, cBoxFreq.Text, cBoxCat.Text);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
