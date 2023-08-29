namespace Laboratorio_02_SMN_2_ACT_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Numero1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calcular_Click(object sender, EventArgs e)
        {
            int Numero1; // txt1 
            int Numero2; // txt2
            int Numero3; // txt3 

            if (int.TryParse(txt1.Text, out Numero1)
               && int.TryParse(txt2.Text, out Numero2)
               && int.TryParse(txt3.Text, out Numero3))
            {
                if (Numero1 != Numero2 && Numero1 != Numero3 && Numero2 != Numero3)
                {
                    int Numeromayor = Numero1;

                    if (Numero2 > Numeromayor)
                    {
                        Numeromayor = Numero2;
                    }
                    if (Numero3 > Numeromayor)
                    {
                        Numeromayor = Numero3;
                    }

                    //Rlbl Como Resultado

                    Rlbl.Text = "Numero mayor es: " + Numeromayor;
                }
                else
                {
                    Rlbl.Text = "Los tres numeros deben de ser distintos, reintente";
                }

            }
            else
            {
                Rlbl.Text = "Incorrecto";
            }
        }


    }
}