using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradutorLista
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Criando lista
        List<String> portugues = new List<string>();
        List<String> ingles = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portugues.Add("vermelho");
            portugues.Add("azul");
            portugues.Add("verde");

            ingles.Add("red");
            ingles.Add("blue");
            ingles.Add("green");

        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            String valor = txtValor.Text;

            for (int i = 0; i < portugues.Count; i++)
            {
                if(valor == portugues.ElementAt(i))
                {
                    txtMostrar.Text = ingles[i];
                }
                if (valor == ingles[i])
                {
                    txtMostrar.Text = portugues.ElementAt(i);
                }
                if(valor == "")
                {
                    MessageBox.Show("Prencha o campo");
                }

            }
        }
    }
}
