using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_U2
{
    public class formula
    {
        private int distance;
        private int time;
        private double velocity;

        public int Distance { get => distance; set => distance = value; }
        public int Time { get => time; set => time = value; }
        public double Velocity { get => velocity; set => velocity = value; }

        public void v_carro(int _distance, int _time, double _velocity)
        {
            this.distance = _distance;
            this.time= _time;
            this.velocity = _velocity;
        }


    }
}
