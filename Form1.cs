using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTPIntegrador1Ahumada
{
    public partial class frmPrincipal : Form
    {
        // Define la estructura de datos para los asientos de cada teatro y área
        Dictionary<string, Dictionary<string, List<string>>> asientosPorTeatro = new Dictionary<string, Dictionary<string, List<string>>>();

        public frmPrincipal()
        {
            InitializeComponent();

            // Inicializa los datos de los asientos para cada teatro
            InicializarAsientos();
        }

        private void InicializarAsientos()
        {
            // Asientos para el Teatro Quenaken
            Dictionary<string, List<string>> asientosQuenaken = new Dictionary<string, List<string>>();
            List<string> asientosAzulesQuenaken = new List<string>();
            List<string> asientosVerdesQuenaken = new List<string>();

            // Área Azul
            for (int fila = 1; fila <= 4; fila++) // 20 asientos de 5 asientos por fila
            {
                for (int asiento = 1; asiento <= 5; asiento++)
                {
                    asientosAzulesQuenaken.Add($"A{fila}{asiento}");
                }
            }

            // Área Verde
            for (int fila = 1; fila <= 4; fila++) // 20 asientos de 5 asientos por fila
            {
                for (int asiento = 1; asiento <= 5; asiento++)
                {
                    asientosVerdesQuenaken.Add($"V{fila}{asiento}");
                }
            }

            asientosQuenaken.Add("Azul", asientosAzulesQuenaken);
            asientosQuenaken.Add("Verde", asientosVerdesQuenaken);
            asientosPorTeatro.Add("Teatro Quenaken", asientosQuenaken);

            // Asientos para el Teatro Onas
            Dictionary<string, List<string>> asientosOnas = new Dictionary<string, List<string>>();
            List<string> asientosAzulesOnas = new List<string>();
            List<string> asientosVerdesOnas = new List<string>();

            // Área Azul
            for (int fila = 1; fila <= 10; fila++) // 40 asientos de 4 asientos por fila
            {
                for (int asiento = 1; asiento <= 4; asiento++)
                {
                    asientosAzulesOnas.Add($"A{fila}{asiento}");
                }
            }

            // Área Verde
            for (int fila = 1; fila <= 4; fila++) // 20 asientos de 5 asientos por fila
            {
                for (int asiento = 1; asiento <= 5; asiento++)
                {
                    asientosVerdesOnas.Add($"V{fila}{asiento}");
                }
            }

            asientosOnas.Add("Azul", asientosAzulesOnas);
            asientosOnas.Add("Verde", asientosVerdesOnas);
            asientosPorTeatro.Add("Teatro Onas", asientosOnas);

            // Asientos para el Teatro Tobas
            Dictionary<string, List<string>> asientosTobas = new Dictionary<string, List<string>>();
            List<string> asientosAzulesTobas = new List<string>();
            List<string> asientosVerdesTobas = new List<string>();

            // Área Azul
            for (int fila = 1; fila <= 4; fila++) // 10 asientos de 3 asientos por fila
            {
                for (int asiento = 1; asiento <= 3; asiento++)
                {
                    asientosAzulesTobas.Add($"A{fila}{asiento}");
                }
            }

            // Área Verde
            for (int fila = 1; fila <= 3; fila++) // 15 asientos de 5 asientos por fila
            {
                for (int asiento = 1; asiento <= 5; asiento++)
                {
                    asientosVerdesTobas.Add($"V{fila}{asiento}");
                }
            }

            asientosTobas.Add("Azul", asientosAzulesTobas);
            asientosTobas.Add("Verde", asientosVerdesTobas);
            asientosPorTeatro.Add("Teatro Tobas", asientosTobas);

            // Inicializa el ComboBox con los nombres de los teatros
            cmbTeatros.DataSource = new BindingSource(asientosPorTeatro.Keys, null);
        }


        private void cmbTeatros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el nombre del teatro seleccionado
            string teatroSeleccionado = cmbTeatros.SelectedItem.ToString();

            // Obtiene los asientos para el teatro seleccionado
            Dictionary<string, List<string>> areasAsientos = asientosPorTeatro[teatroSeleccionado];

            // Muestra los asientos disponibles en el DataGridView para cada área
            MostrarAsientosEnDataGridView(dgvAsientosAzules, areasAsientos["Azul"]);
            MostrarAsientosEnDataGridView(dgvAsientosVerdes, areasAsientos["Verde"]);
        }

        private void MostrarAsientosEnDataGridView(DataGridView dataGridView, List<string> asientos)
        {
            // Limpia las filas existentes en el DataGridView
            dataGridView.Rows.Clear();

            // Agrega las columnas si aún no se han agregado
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Asiento", "Asiento"); // Agrega una columna llamada "Asiento"
            }

            // Agrega una fila por cada asiento
            foreach (string asiento in asientos)
            {
                dataGridView.Rows.Add(asiento);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }
    }
}
