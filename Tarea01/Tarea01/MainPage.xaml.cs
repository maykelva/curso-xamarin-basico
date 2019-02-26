﻿using System;
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
            if (txtnumero.Text != "")
            {
                if (txtnumero.Text == adivinanza.ToString())
                {
                    lblmensaerror.Text = "¡Éxito!";
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
                lblmensaerror.Text = "Debe de digitar un valor";
                lblmensaerror.TextColor = Color.Red;
            }
        }
    }
}