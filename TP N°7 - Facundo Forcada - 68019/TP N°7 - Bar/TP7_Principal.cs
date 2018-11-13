using NumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Colas;
using Colas.Colas;
using NumerosAleatorios.VariablesAleatorias;
using NumerosAleatorios.NumerosAleatorios;
using Colas.Clientes;

namespace TP_N_7___Bar
{
    public partial class TP7_Principal : Form
    {
        private const int Decimales = 2;
        private readonly CultureInfo _culture;
        private bool _cancelar;
        private Thread _simularThread; //manejo de hilos para simular y que no explote todo

        private delegate void InicioFinDelegate(bool fin);
        private delegate void ColumnasDelegate(int numCamion);
        private delegate void FilaDelegate(DateTime relojActual, string eventoActual, Llegada llegadas,
           ICola colaRecepcion, Servidor recepcion, ICola colaBalanza, Servidor balanza, ICola colaDarsenas, Servidor darsena1,
           Servidor darsena2, int atendidos, int noAtendidos, decimal permanenciaDiaria, IEnumerable<Cliente> clientes);
        private delegate void StatusDelegate(int dia, DateTime relojActual, int simulacion);
        private delegate void ResultadosDelegate(decimal promedioAtendidos, decimal promedioNoAtendidos, decimal promedioPermanencia);

        public TP7_Principal()
        {
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;
            InitializeComponent();
            DoubleBuffer();
        }

        //mejora de rendimiento
        public void DoubleBuffer()
        {
            // ReSharper disable once PossibleNullReferenceException
            dgv_simulaciones.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dgv_simulaciones, true);
        }
    }
}
