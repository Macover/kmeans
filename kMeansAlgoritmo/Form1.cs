using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kMeansAlgoritmo
{
    public partial class Form1 : Form
    {
        public int xMax=0,xMin=0,yMin=0,yMax=0,nClases;
        public int[] x;
        public int[] y;

        public List<Series> listaPuntosCentroides;
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

            //for (int i = 0; i < listaPuntosCentroides.Count; i++)
            //{
            //    List<double> listaValoresC = new List<double>();
            //    int posicionColor = 0;
            //    for (int j = 0; j < listaDatos.Count; j++)
            //    {
            //        int datoX = listaDatos[j].puntos.X;
            //        int datoY = listaDatos[j].puntos.Y;
            //        Series centroide = listaPuntosCentroides[i];
            //        double c = this.calculaDistanciaConCentroide(datoX, datoY, centroide);
            //        listaValoresC.Add(c);
            //    }                
            //    posicionColor = listaValoresC.IndexOf(listaValoresC.Min());
            //    Color color = listaPuntosCentroides[i].Color;
            //    listaDatos[i].color = color;                
            //    grafica.Series["Datos"].Points[posicionColor].Color = color;
            //}

            for (int i = 0; i < listaDatos.Count; i++)
            {
                List<double> listaValoresC = new List<double>();
                for (int j = 0; j < listaPuntosCentroides.Count; j++)
                {
                    int datoX = listaDatos[i].puntos.X;
                    int datoY = listaDatos[i].puntos.Y;
                    Series centroide = listaPuntosCentroides[j];
                    double c = this.calculaDistanciaConCentroide(datoX, datoY, centroide);
                    listaValoresC.Add(c);
                }
                //sacar el color del centroide que tuvo la menor distancia con el dato.
                int posicionColor = listaValoresC.IndexOf(listaValoresC.Min());                
                Color color = listaPuntosCentroides[posicionColor].Color;                
                listaDatos[i].color = color;                
                grafica.Series["Datos"].Points[i].Color = color;                
            }            
        }

        public Form1()
        {
            InitializeComponent();
            graficarPuntosIniciales();
            listaPuntosCentroides = new List<Series>();
            btnCalcular.Enabled = false;
        }        
        public void graficarPuntosIniciales()
        {
            listaDatos = new List<Dato>();
            Random random = new Random();
            x = new int[20];
            y = new int[20];
                        

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
            serieDatos.Color = Color.Red;

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
                Series nuevaSerie = new Series();
                nuevaSerie.Name = "Centroide " + (i+1);
                nuevaSerie.ChartType = SeriesChartType.Point;
                nuevaSerie.BorderWidth = 1;
                nuevaSerie.MarkerSize = 10;
                nuevaSerie.MarkerStyle = MarkerStyle.Cross;
                nuevaSerie.Color = this.generarColorAleatorio();
                nuevaSerie.Points.AddXY(randx[i], randy[i]);
                //nuevaSerie.Points[0].Color =  rColor;
                //nuevaSerie.Points[0].BorderWidth = 2;
                listaPuntosCentroides.Add(nuevaSerie);                
                grafica.Series.Add(nuevaSerie);
                
            }
            this.txtB_clases.Enabled = false;
            this.btn_CrearK.Enabled = false;
            this.btnCalcular.Enabled = true;
        }
        public double calculaDistanciaConCentroide(int puntoX, int puntoY,
            Series coordenadasCentroide)
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
        public Color generarColorAleatorio()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);        
            return randomColor;
        }
    }
}
