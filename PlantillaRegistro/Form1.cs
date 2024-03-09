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
    public partial class FormRegistro : Form
    {
        public PictureBox userPhoto;

        public FormRegistro()
        {
            InitializeComponent();

            selectPosition.Items.AddRange(new string[] { "CEO", "CTO", "Gerente", "Supervisor", "Senior", "Junior", "Auxiliar", "Pasante" });
            selectDep.Items.AddRange(new string[] { "Sistemas", "Administración", "Contabilidad", "Marketing", "Ventas", "Soporte", "Mantenimiento" });
        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            userPhoto = userImage;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen " + ex.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            byte[] userImgByte = (byte[])new ImageConverter().ConvertTo(userPhoto.Image, typeof(Byte[]));

            plantilla imprimirPlantilla = new plantilla();
            imprimirPlantilla.userImg = userImgByte;
            imprimirPlantilla.firstName = inpFirstName.Text;
            imprimirPlantilla.lastName = inpLastName.Text;
            imprimirPlantilla.position = selectPosition.SelectedItem.ToString();
            imprimirPlantilla.departament= selectDep.SelectedItem.ToString();
            imprimirPlantilla.salary = inpSalary.Text;
            imprimirPlantilla.ShowDialog();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inpFirstName.Clear();
            inpLastName.Clear();
            selectPosition.SelectedIndex = -1;
            selectDep.SelectedIndex = -1;
            inpSalary.Clear();
            userPhoto.Image = Properties.Resources.face1;
        }
    }
}
