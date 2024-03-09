using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlantillaRegistro
{
    public partial class plantilla : Form
    {
        public plantilla()
        {
            InitializeComponent();
        }

        public byte[] userImg { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string position { get; set; }
        public string departament { get; set; }
        public string salary { get; set; }

        private void plantilla_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;
            lblPosition.Text = position;
            lblDep.Text = departament;
            lblSalary.Text = salary;

            Image photo = (Image)new ImageConverter().ConvertFrom(userImg);

            picUserPhoto.Image = photo;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
