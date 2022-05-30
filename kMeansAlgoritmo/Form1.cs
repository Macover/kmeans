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

        public List<System.Windows.Forms.DataVisualization.Charting.Series> listaPuntosCentroides;

        private void btn_CrearK_Click(object sender, EventArgs e)
        {
            insertarCentroides();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.asignarCentroide(x[0], y[0], listaPuntosCentroides[0]);
        }

        public Form1()
        {
            InitializeComponent();
            graficarPuntos();
            listaPuntosCentroides = new List<System.Windows.Forms.DataVisualization.Charting.Series>();
            btnCalcular.Enabled = false;
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
        public void insertarCentroides()
        {
            xMax=x.Max();
            xMin=x.Min();
            yMax=y.Max();
            yMin=y.Min();
            nClases = int.Parse(txtB_clases.Text);
            int[] randx = new int[nClases];
            int[] randy = new int[nClases];
            Random random = new Random();
            //System.Windows.Forms.DataVisualization.Charting.Series.
            for (int i = 0; i < randx.Length; i++)
            {                
                //Puntos en el arreglo para graficar.
                randx[i] = random.Next(xMin,xMax);
                randy[i] = random.Next(yMin,yMax);
                //Puntos en la lista para guardarlos.

            }          
            for (int i = 0; i < nClases; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.Series nuevaSerie = new System.Windows.Forms.DataVisualization.Charting.Series();
                nuevaSerie.Name = "Centroide " + (i+1);
                nuevaSerie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                nuevaSerie.Points.AddXY(randx[i], randy[i]);
                listaPuntosCentroides.Add(nuevaSerie);
                //nuevaSerie.Color = randomColor;                               

                grafica.Series.Add(nuevaSerie);                                            
            }
            this.txtB_clases.Enabled = false;
            this.btn_CrearK.Enabled = false;
            this.btnCalcular.Enabled = true;
        }
        public void asignarCentroide(int puntoX, int puntoY,
            System.Windows.Forms.DataVisualization.Charting.Series coordenadasCentroide)
        {
            double x2 = coordenadasCentroide.Points[0].XValue;            
            double y2 = coordenadasCentroide.Points[0].YValues[0];
            double a = x2 - puntoX;
            double b = y2 - puntoY;

            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

            //for (int i = 0; i < x.Length; i++)
            //{
            //    arreglo.dato = x[i], y[i]
            //    arreglo.centroide = [listaPuntosCentroides[i]]
            //    arreglo = asignarCentroide(x[i], y[i], centroide);
            //    arreglo.c = [[54,65,76,45], [54,65,76,45]]                
            //}           
        }
    }
}
