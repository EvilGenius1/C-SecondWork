using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestGUI
{
    class CVadrat
    {
        Random rnd = new Random();

        private double diagonal;
        protected int lengthCvadrat;
        private int perimeter, square;

        public int getLength()
        {
            return lengthCvadrat;
        }
        public void setLengthCvadrate()
        {
            lengthCvadrat = rnd.Next(1, 15);
            Console.WriteLine(" length of cvadrate: " + lengthCvadrat);
        }

        public int getInformationAboutSquare()
        {
            square = lengthCvadrat * lengthCvadrat;
            return square;
        }

        public double getInformationAboutDiagonal()
        {
            diagonal = lengthCvadrat * 1.4;
            return diagonal;
        }

        public int getInformationPerimeter()
        {
            perimeter = lengthCvadrat * 4;
            return perimeter;
        }

        public void displayMessage()
        {
            MessageBox.Show("\nCvadrat Square = " + getInformationAboutSquare());
            MessageBox.Show("\nCvadrat Diagonal = " + getInformationAboutDiagonal());
            MessageBox.Show("\nCvadrat Perimeter = " + getInformationPerimeter());
        }
    }

}

