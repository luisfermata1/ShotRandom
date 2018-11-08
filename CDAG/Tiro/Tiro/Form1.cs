using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double coordenada()
        {
            Random random = new Random();
            double num = (random.NextDouble() * (1.00 - 0.00) + 0.00);
            switch (random.Next(1, 3))
            {
                case 1:
                    num= num*-1;
                    break;
                default:
                    break;
            }
            return num; 
            //(random.NextDouble() * (max - min) + min);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string FilePath = "C:\\Users\\lfmata\\Documents\\data.csv";

                // si el archivo no existe crearlo y agtregar encabezado
                if (!File.Exists(FilePath)){
                    string encabezado = "Date,MAC,ShotInterval,BackstrokePause,Jab,FollowThrough,TipSteer,TipSteerDir,Straightness,Finesse,Finish,ImpactX,ImpactY";
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.WriteLine(encabezado);
                    sw.Close();
                }
                Random random = new Random();

                string shot = "";

                string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffffff") + ",";
                shot += date;

                string mac = "00:A0:C9:14:C8:29,";
                shot += mac;

                string shotinterval = (random.NextDouble() * (120)).ToString("0.00") + ",";
                shot += shotinterval;

                string backstrokepause = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += backstrokepause;

                string jab = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += jab;

                string followthrough = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += followthrough;

                string TipSteer = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += TipSteer;

                string tipsteerdir = "";
                switch (random.Next(1, 4))
                {
                    case 1:
                        tipsteerdir = "C,";
                        break;
                    case 2:
                        tipsteerdir = "R,";
                        break;
                    case 3:
                        tipsteerdir = "L,";
                        break;
                }
                shot += tipsteerdir;

                string straightness = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += straightness;

                string finesse = (random.NextDouble() * (10)).ToString("0.00") + ",";
                shot += finesse;

                

                double num = (random.NextDouble() * (1));
                switch (random.Next(1, 3))
                {
                    case 1:
                        num = num * -1;
                        break;
                    default:
                        break;
                }
                string impactx = num.ToString("0.00") + ",";
                shot += impactx;

                num = (random.NextDouble() * (1));
                switch (random.Next(1, 3))
                {
                    case 1:
                        num = num * -1;
                        break;
                    default:
                        break;
                }

                string impacty = num.ToString("0.00");
                shot += impacty;

                File.AppendAllText(FilePath, shot + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
