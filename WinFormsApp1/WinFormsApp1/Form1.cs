using System.Diagnostics.Eventing.Reader;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double ope1 = 0, ope2 = 0, result = 0,resulta=0;
        private string signo = "default";
        private bool even = false;
        public Form1()
        {
            InitializeComponent();
            DisplayText.Text = "0";

        }
        //Función para leer el display y acomodar la primera variable
        //Se realizá un if para comprobar que eñ usuario no  este metiendo algo que no sea númerico
        private void variable1()
        {
            if (double.TryParse(DisplayText.Text, out double num))
            {
                ope1 = num;
                DisplayText.Text = "0";
            }
            else
                DisplayText.Text = "0";
        }
        //Función para leer el display y acomodar la segunda variable
        private void variable2()
        {
            if (double.TryParse(DisplayText.Text, out double num))
            {
                ope2 = num;
                DisplayText.Text = "0";
            }
            else
                DisplayText.Text = "0";
        }
        //Cuando el usuario presione el botón de signo nuevamente se espera que realicé la operación
        //varias veces. Ejemplo: 3+3+3+3+3+3+3. Que no exista un igual sino hasta el final. Consecuencia
        //de esto que el usuario puede hacer varias operaciones como cambiarlas. Ejemplo: 3+3+4-5-6.
        private void secuencia()
        {
                variable2();
                operacion();
                DisplayText.Text = "0";

        }

        //Aqui está la funcion que ayuda a seleccionar que operación se realizará en la calculadora
        //La funcion Math.Round ayuda a mantener un standar de igualdad de simplemente 5 decimales
        private void operacion()
        {
            switch (signo)
            {
                case "+":
                    if (even == false)
                    {
                        result = ope1 + ope2;
                        signo = "default";
                    }
                    else
                        result = ope1 + ope2;
                    break;


                case "-":
                    if (even == false)
                    {
                        result = ope1 - ope2;
                        signo = "default";
                    }
                    else
                    {
                        result = ope1 - ope2;
                    }
                    break;

                case "*":
                    if (even == false)
                    {
                        result = ope1 * ope2;
                        signo = "default";
                    }
                    else
                    {
                        result = ope1 * ope2;
                    }
                    break;
                case "/":
                    if (even == false)
                    {
                        result = ope1 / ope2;
                        signo = "default";
                    }
                    else
                    {
                        result = ope1 / ope2;
                    }
                    break;

                case "%":
                    ope1 = ope1 * 100;
                    DisplayText.Text = ope1.ToString();
                    return;
                case "1/x":
                    ope1 = 1 / ope1;
                    DisplayText.Text = ope1.ToString(); 
                    return;
            }
            ope1 = result;
            DisplayText.Text=result.ToString();
        }
        //Se utiliza el concatenar los elemento agregando al display el número correspondiente 
        //Se inicia con "0" en el display por lo que se hará una función que pueda reemplazar ese 0 de inicio
        //Asi no quedará: 0 -> 0 + [Número ingresado] y que sea 0 -> [Número ingresado]  
        private void button1_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "1";
            else
                DisplayText.Text = DisplayText.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "2";
            else
                DisplayText.Text = DisplayText.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "3";
            else
                DisplayText.Text = DisplayText.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "4";
            else
                DisplayText.Text = DisplayText.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "5";
            else
                DisplayText.Text = DisplayText.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "6";
            else
                DisplayText.Text = DisplayText.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "7";
            else
                DisplayText.Text = DisplayText.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "8";
            else
                DisplayText.Text = DisplayText.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "9";
            else
                DisplayText.Text = DisplayText.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                return;
            else
                DisplayText.Text = DisplayText.Text + 0;

        }
        //Se utiliza el concatenar los elemento agregando al display un punto el cúal simulara valores decimales
        //se pondrá una bandera para impedir que alguien vuelta a presionar el punto y vuelva a poner algo así:
        //13.13.13234.1234
        private void button11_Click(object sender, EventArgs e)
        {
            // Comprobar si existe un punto en el string del display
            if (DisplayText.Text.Contains("."))
            {
                return;
            }
            else
            {
                DisplayText.Text = DisplayText.Text + ".";
            }

        }
        //Verifica si al inicio del display hay un signo lo omitirá, caso contrario lo agregará
        private void button12_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text.StartsWith("-"))
                DisplayText.Text = DisplayText.Text.Substring(1);
            else
                DisplayText.Text = "-" + DisplayText.Text;
        }
        //Elimina los datos que vemos en el Display boton CE
        private void button15_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "0";
        }
        //Se reinician valores botón C
        private void button13_Click(object sender, EventArgs e)
        {
            ope1 = 0;
            ope2 = 0;
            result = 0;
            signo = "default";
            DisplayText.Text = "0";
            even = false;
        }
        //Como el boton es "+" (suma) la variable para que se realicé la operación debe tenerel string
        //PAra el caso requerido. En este "+" que cambia globalmente esa variable llamda "signo"
        //En caso de secuencia se pone un if para realizar la secuencía usando una variable booleana;
        //variable que ayudará a tener un control de eventos
        //Otra consideración es cuando el usuario quiera cambiar en medio de sus operaciones de signo
        //no tenga inconveniente. Ejemplo: 3+ -> 3- -> 3* -> 3[signo que se requiera]´para toda operacion
        private void button16_Click(object sender, EventArgs e)
        {
            if (signo == "+" || signo == "default")
            {
                if (even == false)
                {
                    signo = "+";
                    variable1();
                    even = true;
                }
                else
                {
                    signo = "-";
                    secuencia();

                }
            }
            else
            {
                //se debe ejecutar la operacion anterior para no tener problemas
                variable2();
                operacion();
                DisplayText.Text = "0";
                signo = "+";
            }
        }
        //Boton de igual manda a leer la segunda variable y llama la funcion operacion que realizará
        //la operación de acuerdo al caso de "signo" que este es "="
        private void button14_Click(object sender, EventArgs e)
        {
            if (even==false)
            {
                variable2();
                operacion();
            }
            else
            {
                variable2();
                operacion();
                even = false;
                signo = "default";
            }

        }
        //Como el boton es "-" (resta) la variable para que se realicé la operación debe tener el string
        //para el caso requerido. En este "-" que cambia globalmente esa variable llamda "signo".
        private void button17_Click(object sender, EventArgs e)
        {
            if (signo == "-" || signo == "default")
            {
                if (even == false)
                {
                    signo = "-";
                    variable1();
                    even = true;
                }
                else
                {
                    signo = "-";
                    secuencia();

                }
            }
            else
            {
                //se debe ejecutar la operacion anterior para no tener problemas
                variable2();
                operacion();
                DisplayText.Text = "0";
                signo = "-";
            }
        }
        //Como el boton es "*" (Multiplicación) la variable para que se realicé la operación debe tenerel string
        //para el caso requerido. En este "*" que cambia globalmente esa variable llamada "signo"
        private void button18_Click(object sender, EventArgs e)
        {
            if (signo == "*" || signo == "default")
            {
                if (even == false)
                {
                    signo = "*";
                    variable1();
                    even = true;
                }
                else
                {
                    signo = "*";
                    secuencia();

                }
            }
            else
            {
                //se debe ejecutar la operacion anterior para no tener problemas
                variable2();
                operacion();
                DisplayText.Text = "0";
                signo = "*";
            }
        }
        //Como el boton es "/" (División) la variable para que se realicé la operación debe tenerel string
        //para el caso requerido. En este "/" que cambia globalmente esa variable llamada "signo"
        private void button19_Click(object sender, EventArgs e)
        {
            if (signo == "/" || signo == "default")
            {
                if (even == false)
                {
                    signo = "/";
                    variable1();
                    even = true;
                }
                else
                {
                    signo = "-";
                    secuencia();

                }
            }
            else
            {
                //se debe ejecutar la operacion anterior para no tener problemas
                variable2();
                operacion();
                DisplayText.Text = "0";
                signo = "/";
            }
        }
        //Como el boton es "%" (Porcentaje) la variable para que se realicé la operación debe tenerel string
        //para el caso requerido. En este "%" que cambia globalmente esa variable llamada "signo".
        //Cuando el usuario presiona este botón o necesita una orden de igualdad como las demás podrían,
        //ya que esta lo realizá de forma automatico.
        private void button20_Click(object sender, EventArgs e)
        {
            signo = "%";
            variable1();
            operacion();
        }
        //Como el boton es "1/x" (Porcentaje) la variable para que se realicé la operación debe tenerel string
        //para el caso requerido. En este "1/x" que cambia globalmente esa variable llamada "signo".
        //Cuando el usuario presiona este botón o necesita una orden de igualdad como las demás podrían,
        //ya que esta lo realizá de forma automatico.
        private void button21_Click(object sender, EventArgs e)
        {
            signo = "1/x";
            variable1();
            operacion();
        }
    }
}