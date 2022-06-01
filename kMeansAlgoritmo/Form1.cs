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

        public List<Series> listaPuntosCentroides;
        public List<Dato> listaDatos;

        private void btn_CrearK_Click(object sender, EventArgs e)
        {
            insertarCentroides();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            timer1.Stop();
            timer1.Start();
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
            
            int[]xGp1 = new int[20];
            int[]yGp1 = new int[20];

            int[]xGp2 = new int[20];
            int[]yGp2 = new int[20];

            int[]xGp3 = new int[20];
            int[]yGp3 = new int[20];


            for (int i = 0; i < xGp1.Length; i++)
            {
                xGp1[i] = random.Next(2, 8);
                yGp1[i] = random.Next(5, 18);                
                Puntos coordenadasDatoGp1 = new Puntos();
                coordenadasDatoGp1.X = xGp1[i];
                coordenadasDatoGp1.Y = yGp1[i];
                //guarda los puntos en una lista de tipo Dato
                Dato nuevoDatoGp1 = new Dato(coordenadasDatoGp1, Color.Red);


                xGp2[i] = random.Next(10, 14);
                yGp2[i] = random.Next(5, 18);
                Puntos coordenadasDatoGp2 = new Puntos();
                coordenadasDatoGp2.X = xGp2[i];
                coordenadasDatoGp2.Y = yGp2[i];
                //guarda los puntos en una lista de tipo Dato
                Dato nuevoDatoGp2 = new Dato(coordenadasDatoGp2, Color.Red);

                xGp3[i] = random.Next(20, 25);
                yGp3[i] = random.Next(5, 20);
                Puntos coordenadasDatoGp3 = new Puntos();
                coordenadasDatoGp3.X = xGp3[i];
                coordenadasDatoGp3.Y = yGp3[i];
                //guarda los puntos en una lista de tipo Dato
                Dato nuevoDatoGp3 = new Dato(coordenadasDatoGp3, Color.Red);

                listaDatos.Add(nuevoDatoGp1);
                listaDatos.Add(nuevoDatoGp2);
                listaDatos.Add(nuevoDatoGp3);
            }
            Series serieDatos = new Series();
            serieDatos.Name = "Datos";
            serieDatos.ChartType = SeriesChartType.Point;
            serieDatos.MarkerStyle = MarkerStyle.Circle;
            serieDatos.BorderWidth = 1;
            serieDatos.Color = Color.Red;

            grafica.Series.Add(serieDatos);

            for (int i = 0; i < (xGp1.Length + xGp2.Length + xGp3.Length); i++)
            {
                grafica.Series["Datos"].Points.AddXY(listaDatos[i].puntos.X, listaDatos[i].puntos.Y);
            }
        }

        public void calculaDistancias()
        {
            /*Se recorre cada dato de la lista y se calcula C
             * con cada centroide asignado a la grafica             
             * 
             * El metodo calculaDistanciaConCentroide() devuelve C y se le pasa las coordenadas
             * del dato junto con las del centroide.
             *              
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
        public void insertarCentroides()

        {
            List<int> listaXDatos = new List<int>();
            List<int> listaYDatos = new List<int>();
            for (int i = 0; i < listaDatos.Count; i++)
            {
                listaXDatos.Add(listaDatos[i].puntos.X);
                listaYDatos.Add(listaDatos[i].puntos.Y);
            }
            xMin=listaXDatos.Min();
            yMin=listaYDatos.Min();
            xMax=listaXDatos.Max();
            yMax=listaYDatos.Max();
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

        private void timer1_Tick(object sender, EventArgs e)
        {            
            this.calculaDistancias();
            this.reasignaCentroides();
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
            //Random randomGen = new Random();
            //KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            //KnownColor randomColorName = names[randomGen.Next(names.Length)];
            //Color randomColor = Color.FromKnownColor(randomColorName);
            //return randomColor;

            //Generar color random
            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            return rColor;
        }

        public List<Puntos> calculaNuevasCoordenasCentroides()
        {
            //va a recorrer los centroides y dentro va a recorer todos los datos..
            //sacando el promedio en X y el pormedio en Y
            List<Puntos> nuevasCoordenasCentroides = new List<Puntos>();
            
            for (int i = 0; i < listaPuntosCentroides.Count; i++)
            {
                int sumatoriaX = 0;                
                int sumatoriaY = 0;
                
                Puntos promedio = new Puntos();                

                int numeroDeDatos = 0;
                for (int j= 0; j < listaDatos.Count; j++)
                {
                    if(listaPuntosCentroides[i].Color == listaDatos[j].color)
                    {
                        sumatoriaX += listaDatos[j].puntos.X;
                        sumatoriaY += listaDatos[j].puntos.Y;
                        numeroDeDatos++;
                    }                    
                }
                try
                {
                    promedio.X = sumatoriaX / numeroDeDatos;
                    promedio.Y = sumatoriaY / numeroDeDatos;
                    nuevasCoordenasCentroides.Add(promedio);
                }
                catch(Exception ex)
                {
                    continue;
                }               
            }
            //que retorne las coordenas
            return nuevasCoordenasCentroides;
        }

        public void reasignaCentroides()
        {
            List<Puntos> nuevasCoordenasCentroides = new List<Puntos>();
            nuevasCoordenasCentroides = this.calculaNuevasCoordenasCentroides();

            for (int i = 0; i < nuevasCoordenasCentroides.Count; i++)
            {
                int x = nuevasCoordenasCentroides[i].X;
                int y = nuevasCoordenasCentroides[i].Y;
                grafica.Series["Centroide " + (i + 1)].Points[0].XValue = x;
                grafica.Series["Centroide " + (i + 1)].Points[0].YValues[0] = y;
            }
        }
    }
}
