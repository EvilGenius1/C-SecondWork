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
            MessageBox.Show("Length of apophema: " + h);
        }
        public void setPiramida(int lengthPiramida)
        {
            this.lengthPiramida = lengthPiramida;
        }
        public void setLengthPiramida()
        {
            lengthPiramida = rnd.Next(1, 15);
            MessageBox.Show("Length of Piramida: " + lengthPiramida);
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
        public void PiramidaSecret()
        {
            MessageBox.Show("Square piramida = " + squarePiramida);
            MessageBox.Show("V piramida = " + VPiramida);
        }
    }
}

