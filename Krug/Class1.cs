using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krug
{
    class Krug
    {
        double plo;
        double radius;

        public Krug()
        {
            plo = 0;
            radius = 0;
        }

        public Krug(double plo, double radius)
        {
            this.plo = plo;
            this.radius = radius;
        }
        public double Plo
        {
            get
            {
                return plo;
            }
            set
            {
                if (value<= 0)
                    throw new Exception("Ошибка!");
                else
                    plo = value;

            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value< 0)
                    throw new Exception("Ошибка!");
                else
                    radius = value;

            }
        }
        public double RasPlo(double radius)
        {
            plo = Math.Round( Math.Pow(radius,2) * Math.PI);
            return plo;
        }

        }
    }

