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
        public int[] x;
        public int[] y;

        private void btn_CrearK_Click(object sender, EventArgs e)
        {
            generarKClases();
        }

        public Form1()
        {
            InitializeComponent();
            graficarPuntos();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            graficarPuntos();
        }
        public void graficarPuntos()
        {
            Random random = new Random();
            x = new int[10];
            y = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(2, 40);
                y[i] = random.Next(2, 40);
            }
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
            int[] randx = new int[nClases];
            int[] randy = new int[nClases];
            Random random = new Random();
            for (int i = 0; i < randx.Length; i++)
            {                
                randx[i] = random.Next(xMin,xMax);
                randy[i] = random.Next(yMin,yMax);
            }

            for (int i = 0; i < nClases; i++)
            {
                grafica.Series["Series2"].Points.AddXY(randx[i],randy[i]);
            }
        }
    }
}
