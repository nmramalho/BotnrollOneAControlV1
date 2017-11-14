using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BotnrollOneAControlV1
{
    public partial class formControl : Form
    {
        public formControl()
        {
            InitializeComponent();

           string[] ports = SerialPort.GetPortNames();
            

            // Display each port name to the console.
            foreach (string port in ports)
            {
                comboBox_portas.Items.Add(port);
            }

                        

        }

        private void button_move_frente_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("F");
            
        }

        private void button_move_direita_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("D");
        }

        private void button_move_esquerda_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("E");
        }

        private void button_move_tras_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("T");
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("P");
                
        }

        private void button_abrir_com_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_portas.SelectedItem.ToString();
                serialPort1.Open();

                if(serialPort1.IsOpen == true)
                {
                    label_estado.Text = "LIGADO";
                    label_estado.ForeColor = Color.Green;
                }
                else
                {
                    label_estado.Text = "DESLIGADO";
                    label_estado.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Não foi possível estabelecer a ligação!! ", "ERRO");
            }
        }

        private void button_fechar_ligacao_Click(object sender, EventArgs e)
        {
            try
            {
               if (serialPort1.IsOpen == true)
                {
                    label_estado.Text = "LIGADO";
                    label_estado.ForeColor = Color.Green;
                }
                else
                {
                    label_estado.Text = "DESLIGADO";
                    label_estado.ForeColor = Color.Red;
                }
            }
            finally
            {
                label_estado.Text = "DESLIGADO";
                label_estado.ForeColor = Color.Red;
                serialPort1.Close();
            }
        }

        private void buttonLerBateria_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("B");
                String strBateria = serialPort1.ReadLine();
                labelSensorBateria.Text = strBateria + " V";
            }
        }
    }
}
