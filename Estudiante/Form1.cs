using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LBLClave_Click(object sender, EventArgs e)
        {

        }

        private void MSKClave_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if (MSKClave.Text == "*")
            {
                GPBXFormulario.Visible = true;
            }
            else
            {
                MessageBox.Show("Clave incorrecta. Intente nuevamente.");
            }
        }

        private void GPBXFormulario_Enter(object sender, EventArgs e)
        {

        }

        private void LBLClave2_Click(object sender, EventArgs e)
        {

        }

        private void MSKClave2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LBLEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void CKBXActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBXActivo.Checked)
            {
                CKBXEgresado.Checked = false;
            }
        }

        private void CKBXEgresado_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBXEgresado.Checked)
            {
                CKBXActivo.Checked = false;
            }
        }

        private void LBLPrograma_Click(object sender, EventArgs e)
        {

        }

        private void CBXPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBXPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBLEdad_Click(object sender, EventArgs e)
        {

        }

        private void NUDEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNAumentar_Click(object sender, EventArgs e)
        {
            if (Progressbar.Value <= 90)
            {
                Progressbar.Value += 10;
            }
            else
            {
                MessageBox.Show("No insista, ya esta en el maximo");
            }
        }

        private void BTNDIsminuir_Click(object sender, EventArgs e)
        {
            if (Progressbar.Value >= 10)
            {
                Progressbar.Value -= 10;
            }
            else
            {
                MessageBox.Show("Error, llego a 0.", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Progressbar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void GPBXEstadoCivil_Enter(object sender, EventArgs e)
        {

        }

        private void RBTNSoltero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTNCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GPBXGenero_Enter(object sender, EventArgs e)
        {

        }

        private void RBTNMasculino_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hombre;
        }

        private void RBTNFemenino_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mujer;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
