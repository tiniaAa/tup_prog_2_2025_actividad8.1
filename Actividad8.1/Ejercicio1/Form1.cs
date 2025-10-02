using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<Cuenta> cuentas = new List<Cuenta>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);

            Cuenta cuenta = new Cuenta(nombre, dni, importe);

            cuentas.Sort();

            int idx = cuentas.BinarySearch(cuenta);

            if (idx >= 0)
            {
                cuentas[idx].Nombre = nombre;
                cuentas[idx].Importe += importe;

            }
            else
            {
                cuentas.Add(cuenta);
            }

            //listBox1.Items.Add(cuenta.ToString());

            tbImporte.Text = " ";
            tbDNI.Text = " ";
            tbNombre.Text = " ";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Cuenta c in cuentas)
            {
                listBox1.Items.Add(c);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta c = listBox1.SelectedItem as Cuenta;
            if (c != null)
            {
                tbDNI.Text = $"{c.DNI}";
                tbNombre.Text = $"{c.Nombre}";
                tbImporte.Text = $"{c.Importe}";
            }
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{


        //}
    }
}
