using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kMeansAlgoritmo
{
    public partial class Form1 : Form
    {
        public int xMax=0,xMin=0,yMin=0,yMax=0,nClases;
        public int[] x = { 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        public int[] y = { 3, 6, 9, 12, 15, 18, 21, 24, 27 };

        private void btn_CrearK_Click(object sender, EventArgs e)
        {
            generarKClases();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            graficarPuntos();
        }
        public void graficarPuntos()
        {
            for (int i = 0; i < x.Length; i++)
            {
                grafica.Series["Series1"].Points.AddXY(x[i],y[i]);
            }
        }
        public void generarKClases()
        {
            xMax=x.Max();
            xMin=x.Min();
            yMax=y.Max();
            yMin=y.Min();
            nClases = int.Parse(txtB_clases.Text);
            int[] randx=new int [nClases];
            int [] randy = new int[nClases];
            for (int i = 0; i < randx.Length; i++)
            {
                Random random = new Random();
                randx [i] = random.Next(xMin,xMax);
                randy [i] = random.Next(yMin,yMax);
            }

            for (int i = 0; i < randx.Length; i++)
            {
                grafica.Series["Series2"].Points.AddXY(randx[i],randy[i]);
            }
        }
    }
}
