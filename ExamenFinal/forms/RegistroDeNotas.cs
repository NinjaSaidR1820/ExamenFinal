using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {

        int nota = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("D");

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (cbAsignatura.SelectedIndex == null) MessageBox.Show("porfavor seleccionar una asignatura");

            else if (txtNombre.Text == " ") MessageBox.Show("Ingrese un Nombre");

            else if (txtApellido.Text == "") MessageBox.Show("Ingrese un Apellido");

            else if (txtCarnet.Text == "") MessageBox.Show("Ingrese un numero de carnet");

            else if (txtMunicipio.Text == "") MessageBox.Show("Ingrese un Municipio");

            else if (txtDepartamento.Text == "") MessageBox.Show("Ingrese un Departamento");

            string asignatura = cbAsignatura.Text;
            string nombre = cbAsignatura.Text;
            string apellido = cbAsignatura.Text;
            string municipio = cbAsignatura.Text;
            string departamento = cbAsignatura.Text;
            string carnet = cbAsignatura.Text;

            ///////////////////////////////////////////////////

            int sistematico = Convert.ToInt32(txtSistematico.Text);
            int Iparcial = Convert.ToInt32(txtParciali.Text);
            int IIparcial = Convert.ToInt32(txtparcialii.Text);
            int tarea = Convert.ToInt32(txtTarea.Text);

            ////////////////////////////////////////////////////////

            int notafinal = sistematico + Iparcial + IIparcial + tarea;

            int promedio = notafinal / 4;

            ListViewItem fila = new ListViewItem(nombre);

            fila.SubItems.Add(apellido);
            fila.SubItems.Add(carnet);
            fila.SubItems.Add(municipio);
            fila.SubItems.Add(departamento);
            fila.SubItems.Add(asignatura);
            fila.SubItems.Add(sistematico.ToString());
            fila.SubItems.Add(Iparcial.ToString());
            fila.SubItems.Add(IIparcial.ToString());
            fila.SubItems.Add(tarea.ToString());
            fila.SubItems.Add(notafinal.ToString());

            listViewnotas.Items.Add(fila);

            Btncancelar_Click(sender, e);







        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
