using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnvalidar.Clicked += Btnvalidar_Clicked;
            var adivinanza = 500;
            var limite = adivinanza + 2;
            lbldetalle.Text = "Digite un numero entre: " + adivinanza.ToString() + " y " + limite.ToString();
        }

        private void Btnvalidar_Clicked(object sender, EventArgs e)
        {
            var adivinanza = 500;
            var limite = adivinanza + 2;
            lbldetalle.Text = "Digite un numero entre: " + adivinanza.ToString() + "y " + limite.ToString();
            if (txtnumero.Text !="")
            {
                if (Int32.Parse(txtnumero.Text) < limite)
                {
                    if (Int32.Parse(txtnumero.Text) >= adivinanza)
                    {
                        if (txtnumero.Text == adivinanza.ToString())
                        {
                            lblmensaerror.Text = "¡Éxito, adivinaste!";
                            lblmensaerror.TextColor = Color.BlueViolet;
                        }
                        else
                        {
                            lblmensaerror.Text = "Será para la Próxima, siga bateando...";
                            lblmensaerror.TextColor = Color.ForestGreen;
                        }
                    }
                    else
                    {
                        lblmensaerror.Text = "No puede Digitar un valor MENOR al detallado...:" + adivinanza.ToString();
                        lblmensaerror.TextColor = Color.Red;
                    }
                }
                else
                {
                    lblmensaerror.Text = "No puede Digitar un valor MAYOR al detallado...:"+ limite.ToString();
                    lblmensaerror.TextColor = Color.Red;
                }
            }
            else
            {
                lblmensaerror.Text = "Debe de digitar un valor";
                lblmensaerror.TextColor = Color.Red;
            }
        }
    }
}
