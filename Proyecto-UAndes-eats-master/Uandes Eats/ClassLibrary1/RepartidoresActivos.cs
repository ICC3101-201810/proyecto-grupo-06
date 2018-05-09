using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RepartidoresActivos
    {
        Repartidores Repartidores;
        DateTime Time;

        public RepartidoresActivos(Repartidores Repartidores1, DateTime Time1)
        {
            Repartidores = Repartidores1;
            Time = Time1;
        }
        public Repartidores Repartidores1
        {
            get
            {
                return Repartidores;

            }

            set
            {
                Repartidores = value;
            }

        }
        public DateTime Time1
        {
            get
            {
                return Time;
            }
            set
            {
                Time = value;
            }
        }


    }
}
