using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeansAlgoritmo
{    
    public class Dato
    {
        public Puntos puntos;        
        public Color color;        
        //Iniciar puntos
        public Dato(Puntos puntos, Color color)
        {
            this.puntos = puntos;
            this.color = color;            
        }        

    }
}
