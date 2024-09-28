/*:-----------------------------------------------------------------------------
 *:                       INSTITUTO TECNOLOGICO DE LA LAGUNA
 *:                     INGENIERIA EN SISTEMAS COMPUTACIONALES
 *:                             SISTEMAS PROGRAMABLES           
 *:                                   Ago-Dic 2024
 *:               
 *:                      Practica 6 Temperatura en Pantalla
 *: 
 *: INTEGRANTES: Diego Muñoz Rede
 *:              Leonardo Zavala González
 *:              Alejandro Cabrera Méndez
 *:---------------------------------------------------------------------------*/
using System.IO.Ports;
namespace Práctica_6_Temperatura_en_Pantalla
{
    public partial class frmSerie : Form
    {
        SerialPort sp = new SerialPort();

        //-----------------------------------------------------------------------

        public frmSerie()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------

        private void ActualizarPuertos()
        {
            string[] puertos = SerialPort.GetPortNames();
            cmbPuertos.DataSource = puertos;

            if (puertos.Length > 0)
            {
                cmbPuertos.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron puertos disponibles.");
            }
        }

        //-----------------------------------------------------------------------

        private void frmSerie_Load(object sender, EventArgs e)
        {
            ActualizarPuertos();
        }

        //-----------------------------------------------------------------------

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Close();
                }

                sp.PortName = cmbPuertos.Text;
                sp.Open();
                MessageBox.Show("Conectado");
                sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-----------------------------------------------------------------------

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort actualSP = (SerialPort)sender;
                string inData = actualSP.ReadLine().Trim();

                rtbLog.Invoke(new MethodInvoker(
                    delegate
                    {
                        rtbLog.AppendText(inData + Environment.NewLine);
                    }));

                if (float.TryParse(inData, out float temperatura))
                {
                    labelTemperatura.Invoke(new MethodInvoker(delegate
                    {
                        labelTemperatura.Text = temperatura.ToString("F1") + "°";

                        // Cambiamos los colores de la aplicación en función de la temperatura marcada
                        if (temperatura <= 12)
                        {
                            panelTemperatura.BackColor = Color.FromArgb(0x5D, 0xAD, 0xE2);
                            this.BackColor = Color.FromArgb(0x34, 0x98, 0xDB);
                            labelClima.Text = "❆";
                        }
                        else if (temperatura > 12 && temperatura <= 29 )
                        {
                            panelTemperatura.BackColor = Color.FromArgb(0xF7, 0xDC, 0x6F);
                            this.BackColor = Color.FromArgb(0xF4, 0xD0, 0x3F);
                            labelClima.Text = "☀";
                        }
                        else
                        {
                            panelTemperatura.BackColor = Color.FromArgb(0xF5, 0xB0, 0x41);
                            this.BackColor = Color.FromArgb(0xF3, 0x9C, 0x12);
                            labelClima.Text = "♨";
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        //-----------------------------------------------------------------------

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPuertos();
        }

        //-----------------------------------------------------------------------

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen) // Verificamos que este abierta la conexión
                {
                    sp.Close(); // Cerramos la conexión
                    MessageBox.Show("Desconectado");

                    // Reseteamos a los valores predeterminados
                    labelTemperatura.Text = "00.00°";
                    panelTemperatura.BackColor = Color.FromArgb(0x40, 0x40, 0x40);
                    this.BackColor = Color.FromArgb(0x40, 0x40, 0x40);
                    labelClima.Text = "●";
                    rtbLog.Clear();
                }
                else
                {
                    MessageBox.Show("El puerto ya está cerrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-----------------------------------------------------------------------

    }
}
