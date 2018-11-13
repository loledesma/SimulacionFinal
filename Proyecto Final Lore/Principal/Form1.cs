using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Colas;
using NumerosAleatorios;
using NumerosAleatorios.NumerosAleatorios;
using NumerosAleatorios.VariablesAleatorias;
using Colas.Colas;
using Colas.Clientes;
using Montecarlo;
using System.Reflection;



namespace Principal
{
    public partial class principal : Form
    {

        private const int Decimales = 2;
        private readonly CultureInfo _culture;
        private bool _cancelar;
        private Thread _simularThread; //manejo de hilos

        //private delegate void InicioFinDelegate(bool fin);
        //private delegate void ColumnasDelegate(int numCamion);
        //private delegate void FilaDelegate(DateTime relojActual, string eventoActual, Llegada llegadas,
        //   ICola colaRecepcion, Servidor recepcion, ICola colaBalanza, Servidor balanza, ICola colaDarsenas, Servidor darsena1,
        //   Servidor darsena2, int atendidos, int noAtendidos, decimal permanenciaDiaria, IEnumerable<Cliente> clientes);
        //private delegate void StatusDelegate(int dia, DateTime relojActual, int simulacion);
        //private delegate void ResultadosDelegate(decimal promedioAtendidos, decimal promedioNoAtendidos, decimal promedioPermanencia);

        public principal()
        {
            InitializeComponent();
    
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;
            InitializeComponent();
            DoubleBuffer();

        }

        public void DoubleBuffer()
        {
            // ReSharper disable once PossibleNullReferenceException
            dgv_simulaciones.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dgv_simulaciones, true);
        }

        private Boolean ValidarDatos()
        {
            if(!ValidarExponencial(txt_llegadas_media))
                return false;

            if (!ValidarUniforme(txt_lavado_a, txt_lavado_b))
                return false;

            if (!ValidarUniforme(txt_aspirado_a, txt_aspirado_b))
                return false;

            return ValidarCantidades(txt_desde, txt_hasta, txt_dias);
        }

        private static bool ValidarExponencial(Control txtMedia)
        {
            var mensaje = "Lambda debe ser un número positivo";

            if (string.IsNullOrEmpty(txtMedia.Text))
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            double lambda;

            if (!double.TryParse(txtMedia.Text, out lambda) || lambda <= 0)
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            return true;
        }

        private static bool ValidarUniforme(Control txtA, Control txtB)
        {
            var mensaje = "Ingrese un número válido para A";

            if (string.IsNullOrEmpty(txtA.Text))
            {
                MensajeError(mensaje, txtA);
                return false;
            }

            double a;

            if (!double.TryParse(txtA.Text, out a))
            {
                MensajeError(mensaje, txtA);
                return false;
            }

            mensaje = "Ingrese un número válido para B";

            if (string.IsNullOrEmpty(txtB.Text))
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            double b;

            if (!double.TryParse(txtB.Text, out b))
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            mensaje = "B debe ser mayor que A";

            if (b <= a)
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            MessageBox.Show(mensaje, @"Error");
            textBox.Focus();
        }

        private static bool ValidarCantidades(Control txtDesde, Control txtHasta, Control txtDias)
        {
            var mensaje = "Los días deben ser un entero positivo";

            if (string.IsNullOrEmpty(txtDias.Text))
            {
                MensajeError(mensaje, txtDias);
                return false;
            }

            int dias;

            if (!int.TryParse(txtDias.Text, out dias) || dias <= 0)
            {
                MensajeError(mensaje, txtDias);
                return false;
            }

            mensaje = "El evento desde debe ser un entero positivo";

            if (string.IsNullOrEmpty(txtDesde.Text))
            {
                MensajeError(mensaje, txtDesde);
                return false;
            }

            int desde;

            if (!int.TryParse(txtDesde.Text, out desde) || desde <= 0)
            {
                MensajeError(mensaje, txtDesde);
                return false;
            }

            mensaje = "El evento hasta debe ser un entero positivo";

            if (string.IsNullOrEmpty(txtHasta.Text))
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            int hasta;

            if (!int.TryParse(txtHasta.Text, out hasta) || hasta <= 0)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }
            mensaje = "El evento hasta no puede ser inferior al desde";

            if (hasta < desde)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            return true;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            _simularThread = new Thread(Simular)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };

            _simularThread.Start();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }

        private void Simular()
        {

            //aca manejar la simulacion
        }
    }

}
