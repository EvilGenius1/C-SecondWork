using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    class Piramida
    {
        private int lengthPiramida;
        private double VPiramida, squarePiramida, h;
        private static float pi = 3.14f;

        Random rnd = new Random();

        public void setLengthApophema()
        {
            h = rnd.Next(1, 15);
        }
        public void setLengthPiramida()
        {
            lengthPiramida = rnd.Next(1, 15);
        }
        public void setPiramidaH()
        {
            h = rnd.Next(1, 10);
        }
        public double getPiramidaH()
        {
            return h;
        }
        public int getLengthPiramida()
        {
            return lengthPiramida;
        }
        public double getSquarePiramida()
        {
            squarePiramida = 0.5 * h * lengthPiramida;
            return squarePiramida;
        }

        public double getVpiramida()
        {
            VPiramida = 0.33 * squarePiramida * h;
            return VPiramida;
        }
        public string PiramidaSecret()
        {
            setLengthApophema();
            setLengthPiramida();
            setPiramidaH();

            String resultPiramida = "Square piramida = " + getSquarePiramida() + ". V piramida = " + getVpiramida();
            return resultPiramida;
        }
    }
}

