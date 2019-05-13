using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestGUI
{
    class CVadrat
    {
        string pathCvadrat = @"C:\Users\Иванов\Desktop\Программирование\cvadrat.dat";

        Random rnd = new Random();

        private double diagonal;
        protected int lengthCvadrat;
        private int perimeter, square;

        public int getLength()
        {
            return lengthCvadrat;
        }
        public void setLengthCvadrate( )
        {
            lengthCvadrat = rnd.Next(1, 15);
            //File.WriteAllText(pathCvadrat, Convert.ToString(lengthCvadrat));
        }

        public int getInformationAboutSquare()
        {
            square = lengthCvadrat * lengthCvadrat;
            //File.WriteAllText(pathCvadrat, Convert.ToString(square));
            return square;
        }

        public double getInformationAboutDiagonal()
        {
            diagonal = lengthCvadrat * 1.4;
           // File.WriteAllText(pathCvadrat, Convert.ToString(diagonal));
            return diagonal;
        }

        public int getInformationPerimeter()
        {
            perimeter = lengthCvadrat * 4;
            //File.WriteAllText(pathCvadrat, Convert.ToString(perimeter));
            return perimeter;
        }

        public string displayMessageSquare()
        {
            setLengthCvadrate();
            String squareCvadratov = "\nCvadrat Square = " + getInformationAboutSquare() + ". Cvadrat diagonal = " + getInformationAboutDiagonal() + ". Cvadrat Perimeter = " + getInformationPerimeter();
            File.WriteAllText(pathCvadrat, squareCvadratov);
            return squareCvadratov;
        }
    }
}
