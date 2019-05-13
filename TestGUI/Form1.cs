using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//C:\Users\Иванов\Desktop\Программирование


namespace TestGUI
{
    public partial class Form1 : Form
    {
    
        CVadrat t = new CVadrat();
        Piramida p = new Piramida();
        Random rnd = new Random();
        
        string path = @"C:\Users\Иванов\Desktop\Программирование\anotherResults.dat";
      
    public Form1()
        {
            InitializeComponent();
            //Char.IsNumber(str[index])&& str[index-1]=='-']
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           label2.Text =  t.displayMessageSquare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = p.PiramidaSecret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int Nlength, NsquareMin;
            int NmassivLength = rnd.Next(2, 10);

            int[] arrayN = new int[NmassivLength];

            for (int i = 0; i < NmassivLength; i++)
            {
                Nlength = rnd.Next(2, 5);
                arrayN[i] = Convert.ToInt32(Math.Pow(Nlength, 2));
                label4.Text = ("Square N cvadratov : " + arrayN[i] + ". ");
                File.WriteAllText(path, Convert.ToString(label4));
            }
            NsquareMin = arrayN.Min();
            label5.Text = ("Min = " + NsquareMin + ". ");
            File.WriteAllText(path, Convert.ToString(label5));
        }

       
        public int mpart(int a)
        {
            return a;
        }

        private void inpurtA_TextChanged(object sender, EventArgs e)
        {

        }
        public void label2_Click(object sender, EventArgs e)
        {
         
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a, mLength;
            try {
                 a = (mpart(Convert.ToInt32(inpurtA.Text)));
             }
             catch(System.FormatException)
             {
              a = 0;
             }

            for (int i = 0; i < rnd.Next(3, 6); i++)
            {
                mLength = rnd.Next(5, 25);
                if (a > mLength)
                {
                    label6.Text = (Convert.ToString(a) + " > " + Convert.ToString(mLength));
                    File.WriteAllText(path, Convert.ToString(label6));
                }
                else
                {
                    label7.Text = (Convert.ToString(a) + " < " + Convert.ToString(mLength));
                    File.WriteAllText(path, Convert.ToString(label7));
                }             
            }         
        }

        public   void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
              
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
   }
