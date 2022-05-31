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
        public List<Dato> listaDatos;

        private void btn_CrearK_Click(object sender, EventArgs e)
        {
            insertarCentroides();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Se recorre cada dato de la lista y se calcula C
             * con cada centroide asignado a la grafica             
             * 
             * El metodo calculaDistanciaConCentroide() devuelve C y se le pasa las coordenadas
             * del dato junto con las del centroide.
             * 
             * Se van guardando todas las distancias que tuvo con ese centroide en una lista
             * de la misma clase dato.
             * Despues se determina el minimo y se le asignara el color del centroide.
             * 
            */

            for (int i = 0; i < listaDatos.Count; i++)
            {

                List<double> listaValoresC = new List<double>();                
                for (int j = 0; j < listaPuntosCentroides.Count; j++)
                {
                    int datoX = listaDatos[i].puntos.X;
                    int datoY = listaDatos[i].puntos.Y;
                    System.Windows.Forms.DataVisualization.Charting.Series centroide = listaPuntosCentroides[j];                    
                    double c = this.calculaDistanciaConCentroide(datoX, datoY, centroide);
                    listaValoresC.Add(c);                                        
                }
                //sacar el color del centroide que tuvo la menor distancia con el dato.
                int posicionColor = listaValoresC.IndexOf(listaValoresC.Min());
                Console.WriteLine(listaDatos);
                Console.WriteLine(listaPuntosCentroides);
                Color color = listaPuntosCentroides[posicionColor].ShadowColor;
                grafica.Series["Datos"].Points[i].Color = color;
                listaDatos[i].c = listaValoresC;
            }
            Console.WriteLine(listaDatos);
        }

        public Form1()
        {
            InitializeComponent();
            graficarPuntosIniciales();
            listaPuntosCentroides = new List<System.Windows.Forms.DataVisualization.Charting.Series>();
            btnCalcular.Enabled = false;
        }        
        public void graficarPuntosIniciales()
        {
            listaDatos = new List<Dato>();
            Random random = new Random();
            x = new int[10];
            y = new int[10];
                        

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(2, 40);
                y[i] = random.Next(2, 40);
                
                Puntos coordenadasDato = new Puntos();
                coordenadasDato.X = x[i];
                coordenadasDato.Y = y[i];                

                //guarda los puntos en una lista de tipo Dato
                Dato nuevoDato = new Dato(coordenadasDato,Color.Blue); 
                listaDatos.Add(nuevoDato);                
            }
            System.Windows.Forms.DataVisualization.Charting.Series serieDatos = new System.Windows.Forms.DataVisualization.Charting.Series();
            serieDatos.Name = "Datos";
            serieDatos.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            serieDatos.BorderWidth = 1;
            serieDatos.Color = Color.Blue;

            grafica.Series.Add(serieDatos);

            for (int i = 0; i < x.Length; i++)
            {
                grafica.Series["Datos"].Points.AddXY(listaDatos[i].puntos.X, listaDatos[i].puntos.Y);
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
                //Generar color random
                Random r = new Random();
                Color rColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                System.Windows.Forms.DataVisualization.Charting.Series nuevaSerie = new System.Windows.Forms.DataVisualization.Charting.Series();
                nuevaSerie.Name = "Centroide " + (i+1);
                nuevaSerie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                nuevaSerie.BorderWidth = 1;
                nuevaSerie.ShadowColor = rColor;

                nuevaSerie.Points.AddXY(randx[i], randy[i]);
                //nuevaSerie.Points[i].Color = rColor;
                //nuevaSerie.Points[i].BorderWidth = 1;
                listaPuntosCentroides.Add(nuevaSerie);                
                grafica.Series.Add(nuevaSerie);                                            
            }
            this.txtB_clases.Enabled = false;
            this.btn_CrearK.Enabled = false;
            this.btnCalcular.Enabled = true;
        }
        public double calculaDistanciaConCentroide(int puntoX, int puntoY,
            System.Windows.Forms.DataVisualization.Charting.Series coordenadasCentroide)
        {
            double x2 = coordenadasCentroide.Points[0].XValue;            
            double y2 = coordenadasCentroide.Points[0].YValues[0];
            double a = x2 - puntoX;
            double b = y2 - puntoY;

            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            return c;

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
