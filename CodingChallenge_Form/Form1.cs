using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Given_weights_TextChanged(object sender, EventArgs e)
        {
            textBoxLeft1.Text = "";
            textBoxLeft2.Text = "";
            textBoxLeft3.Text = "";
            textBoxLeft4.Text = "";
            textBoxRight1.Text = "";
            textBoxRight2.Text = "";
            textBoxRight3.Text = "";
            textBoxRight4.Text = "";
            //alle variabel in die Programm
            Double dEndweigh = 40, dPieces = 4, dFirst_piece, dSecond_piece, dThird_piece, dForth_piece, dGiven_weights = 0;
            String sGiven_weights;

            //lösung durch dEndweigh = 3^(dPieces -4)+ 3^(dPieces -3)+ 3^(dPieces -2)+ 3^(dPieces -1) = 1 + 3 + 9 + 27 = 40

            dFirst_piece = Math.Pow(3, (dPieces - 4));

            dSecond_piece = Math.Pow(3, (dPieces - 3));

            dThird_piece = Math.Pow(3, (dPieces - 2));

            dForth_piece = Math.Pow(3, (dPieces - 1));

            First_piece.Text = dFirst_piece + " kg";
            Second_piece.Text = dSecond_piece + " kg";
            Third_piece.Text = dThird_piece + " kg";
            Forth_piece.Text = dForth_piece + " kg";

            sGiven_weights = Convert.ToString(Given_weights.Text);

            if (sGiven_weights == "")
            {
                
            }
            else
            {
                try
                {

                    dGiven_weights = Convert.ToDouble(sGiven_weights);
                    if (dGiven_weights > 0 && dGiven_weights <= 40)
                    {
                        switch (dGiven_weights)
                        {
                            case 1:
                                //1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 2:
                                //3 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 3:
                                //3 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 4:
                                //3 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dSecond_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 5:
                                //9 kg auf linke Seite und gegeben Gewichte + 3 kg + 1 kg  ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                textBoxRight3.Text = dFirst_piece + "kg";
                                break;
                            case 6:
                                //9 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 7:
                                //9 kg +1 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 8:
                                //9 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 9:
                                //9 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 10:
                                //9 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 11:
                                //9 kg + 3 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 12:
                                //9 kg + 3 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 13:
                                //9 kg + 3 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dThird_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxLeft3.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 14:
                                //27 kg auf linke Seite und gegeben Gewichte + 9 kg + 3 kg + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                textBoxRight3.Text = dSecond_piece + "kg";
                                textBoxRight4.Text = dFirst_piece + "kg";
                                break;
                            case 15:
                                //27 kg auf linke Seite und gegeben Gewichte + 9 kg + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                textBoxRight3.Text = dSecond_piece + "kg";
                                break;
                            case 16:
                                //27 kg + 1 kg auf linke Seite und gegeben Gewichte + 9 kg + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                textBoxRight3.Text = dSecond_piece + "kg";
                                break;
                            case 17:
                                //27 kg auf linke Seite und gegeben Gewichte + 9 kg + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                textBoxRight3.Text = dFirst_piece + "kg";
                                break;
                            case 18:
                                //27 kg auf linke Seite und gegeben Gewichte + 9 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                break;
                            case 19:
                                //27 kg + 1 kg auf linke Seite und gegeben Gewichte + 9 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                break;
                            case 20:
                                //27 kg + 3 kg auf linke Seite und gegeben Gewichte + 9 kg + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                textBoxRight3.Text = dFirst_piece + "kg";
                                break;
                            case 21:
                                //27 kg + 3 kg auf linke Seite und gegeben Gewichte + 9 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                break;
                            case 22:
                                //27 kg + 3 kg + 1 kg auf linke Seite und gegeben Gewichte + 9 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxLeft3.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dThird_piece + "kg";
                                break;
                            case 23:
                                //27 kg auf linke Seite und gegeben Gewichte + 3 kg + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                textBoxRight3.Text = dFirst_piece + "kg";
                                break;
                            case 24:
                                //27 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 25:
                                //27 kg + 1 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 26:
                                //27 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 27:
                                //27 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 28:
                                //27 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 29:
                                //27 kg + 3 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 30:
                                //27 kg + 3 kg auf linke Seite und gegeben Gewichte kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 31:
                                //27 kg + 3 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dSecond_piece + "kg";
                                textBoxLeft3.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 32:
                                //27 kg + 9 kg auf linke Seite und gegeben Gewichte + 1 kg + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                textBoxRight3.Text = dFirst_piece + "kg";

                                break;
                            case 33:
                                //27 kg + 9 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 34:
                                //27 kg + 9 kg + 1 kg auf linke Seite und gegeben Gewichte + 3 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxLeft3.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dSecond_piece + "kg";
                                break;
                            case 35:
                                //27 kg + 9 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 36:
                                //27 kg + 9 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 37:
                                //27 kg + 9 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxLeft3.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 38:
                                //27 kg + 9 kg + 3 kg auf linke Seite und gegeben Gewichte + 1 kg ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxLeft3.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                textBoxRight2.Text = dFirst_piece + "kg";
                                break;
                            case 39:
                                //27 kg + 9 kg + 3 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxLeft3.Text = dSecond_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                            case 40:
                                //27 kg + 9 kg + 3 kg + 1 kg auf linke Seite und gegeben Gewichte ist auf die rechte Seite
                                textBoxLeft1.Text = dForth_piece + "kg";
                                textBoxLeft2.Text = dThird_piece + "kg";
                                textBoxLeft3.Text = dSecond_piece + "kg";
                                textBoxLeft4.Text = dFirst_piece + "kg";
                                textBoxRight1.Text = dGiven_weights + "kg";
                                break;
                        }
                    }
                    else
                    {
                        //wenn der user ein zahl außerhalb die grenze schreibe
                        MessageBox.Show("Bitte schreiben Sie eine Gewicht zwischen 1 kg und 40 kg");
                    }

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Bitte schreiben Sie eine Gewicht zwischen 1 kg und 40 kg");
                    
                }
                
            }
        }
    }
}
