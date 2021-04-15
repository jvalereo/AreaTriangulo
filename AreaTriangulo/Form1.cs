using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            /*Treinamento - Calcule a Area do Triangulo Retangulo, tipo double*/
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double b, h, area;

            //Declarando entrada de dado no textbox

            b = double.Parse(textBoxBase.Text, CultureInfo.InvariantCulture);
            h = double.Parse(textBoxAltura.Text, CultureInfo.InvariantCulture);

            //Declarando a variavel area do triangulo retangulo

            area = (b * h) / 2;


            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("A area do triangulo: " + area.ToString("F1", CultureInfo.InvariantCulture)
                ,"Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Teste de Novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar textbox, focus

            textBoxAltura.Text = " ";
            textBoxBase.Text = " ";
            textBoxBase.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair do programa

            Close();
        }

        //Fim do progama
    }
}
