using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3_datagridviw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtcal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)||char.IsControl(e.KeyChar))
                e.Handled =false;
            else
                e.Handled=true;

            string a;
            double b;
            bool rep= dgvcalificacion.Rows.Cast<DataGridViewRow>().Any(row=> Convert.ToString(row.Cells["Nombre"].Value)==txtnombre.Text.Trim());

            if (e.KeyChar == 13)
            {
                if (txtcal.Text == "")
                {
                    MessageBox.Show("Agrega Calificacion");
                }
                else if (rep)
                {
                    MessageBox.Show("Este resgistro ya existe");
                    txtcal.Clear();
                    txtnombre.Clear();
                    txtnombre.Focus();
                }
                else
                {
                    a=txtnombre.Text;
                    b = int.Parse(txtcal.Text);
                    dgvcalificacion.Rows.Add(a,b);
                    //Promedio();saca promedio grupal en el key press//
                    txtcal.Clear();
                    txtcal.Focus();
                    txtnombre.Clear();
                    txtnombre.Focus();
                }
                {
         
                }
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtcal.Clear();
            dgvcalificacion.Rows.Clear();
            lblpromedio.Text = "Promedio Grupal: ";
            txtnombre.Focus();

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            Promedio();
        }

        private void btnlineaa_Click(object sender, EventArgs e)
        {
            dgvcalificacion.Rows.Remove(dgvcalificacion.CurrentRow);
            Promedio();
        }
        private void Promedio()
        {
                double a = 0;
            double b;
            if (dgvcalificacion.Rows.Count==0)
            {
                MessageBox.Show("INGRESE LOS DATOS REQUERIDOS");
                txtnombre.Focus();
            }
            else
            {
                foreach (DataGridViewRow row in dgvcalificacion.Rows)
                {
                    a += Convert.ToDouble(row.Cells["Calificacion"].Value);
                }
                b = dgvcalificacion.Rows.Count - 1;
                a = a / b;
                lblpromedio.Text = ("Promedio grupal: " + Convert.ToString(a.ToString("f2")));
                txtnombre.Focus();
        }
       }

        private void lblpromedio_Click(object sender, EventArgs e)
        {
        
            }

        private void lblpromedio_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        }
    }

