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
            //podController.CreatePodcast(txtUrl, cBoxFreq.Text, cBoxCat.Text
            Podcast podCast = podController.CreatePodcast(txtUrl.Text, cBoxFreq.Text, cBoxCat.Text);

            dataGridView1.Rows.Add(podCast.episodes, podCast.title, podCast.frequency, podCast.category);




        }
    }
}
