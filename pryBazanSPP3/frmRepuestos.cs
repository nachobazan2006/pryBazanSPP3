using System.Numerics;
using System.Text.RegularExpressions;

namespace pryBazanSPP3
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }


        public class Repuesto
        {
            public char Marca;
            public string Descripcion;
            public float Precio;
            public int Numero;
            public char origen;
        }
        Repuesto[] repuestos = new Repuesto[100];
        int cantidadRepuestos = 0;
        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden agregar más repuestos.");
                return;
            }

            // comprueboo que los combos tengan texto antes de acceder al primer carácter
            if (string.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                MessageBox.Show("Seleccione una marca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbOrigen.Text))
            {
                MessageBox.Show("Seleccione un origen.");
                return;
            }
            // obtener y validar datos
            char Marca = char.ToUpper(cmbMarca.Text[0]); //.ToUpper para asegurar mayúscula
            char origen = char.ToUpper(cmbOrigen.Text[0]);
            string descripcion = txtDescripcion.Text ?? "";
            float precio;
            int numero;

            // validacion del campo número
            if (!int.TryParse(NupNúmero.Text, out numero) || numero < 0 || NupNúmero.Text.Length >= 6)
            {
                MessageBox.Show("Número inválido. Debe ser hasta 6 dígitos.");
                return;
            }

            // validar que no exista el número
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (repuestos[i] != null && repuestos[i].Numero == numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }

            // validaciones necesarias
            if (Marca != 'P' && Marca != 'F' && Marca != 'R')
            {
                MessageBox.Show("Marca inválida. Solo P, F o R.");
                return;
            }

            if (origen != 'N' && origen != 'I')
            {
                MessageBox.Show("Origen inválido. Solo N o I.");
                return;
            }

            if (descripcion.Length > 50)
            {
                MessageBox.Show("Descripción demasiado larga (máximo 50 caracteres).");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            // Crear instancia y guardar repuesto en el arreglo
            var nuevo = new Repuesto
            {
                Marca = Marca,
                origen = origen,
                Numero = numero,
                Descripcion = descripcion,
                Precio = precio
            };

            repuestos[cantidadRepuestos] = nuevo;
            cantidadRepuestos++;

            MessageBox.Show("Repuesto agregado correctamente.");
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstConsulta.Items.Clear();

            if (cantidadRepuestos == 0)
            {
                MessageBox.Show("No hay repuestos cargados.");
                return;
            }

            char marca = cmbMarcaConsulta.Text.ToUpper()[0];
            char origen = rbNacional.Checked ? 'N' : 'I';

            bool encontrado = false;

            //bucle para buscar repuestos que coincidan con los criterios
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (repuestos[i].Marca == marca && repuestos[i].origen == origen)
                {
                    string linea = "Número: " + repuestos[i].Numero +
                                   " | Desc: " + repuestos[i].Descripcion +
                                   " | Precio: $" + repuestos[i].Precio.ToString("0.00");
                    lstConsulta.Items.Add(linea);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                lstConsulta.Items.Add("No se encontraron repuestos con los criterios especificados.");
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
