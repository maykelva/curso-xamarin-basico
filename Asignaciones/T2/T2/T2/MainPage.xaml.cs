using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace T2
{
    public partial class MainPage : ContentPage
    {
        string[,] datos = new string[5, 5];
        string vseleccion_picker = "";
        public MainPage()
        {
            InitializeComponent();
            btnaplicar.Clicked += Btnaplicar_Clicked;
            btnconsultar.Clicked += Btnconsultar_Clicked;
            btneliminar.Clicked += Btneliminar_Clicked;
            PickerPantalla.SelectedIndexChanged += PickerPantalla_SelectedIndexChanged;

        }

        private void Btneliminar_Clicked(object sender, EventArgs e)
        {
            if (vseleccion_picker.Trim() != " ")
            {
                if (datos[0, 0] == vseleccion_picker)
                {
                    datos[0, 0] = "";
                    datos[0, 1] = "";
                    datos[0, 2] = "";
                    datos[0, 3] = "";
                    datos[0, 4] = "";
                }
                if (datos[1, 0] == vseleccion_picker)
                {
                    datos[1, 0] = "";
                    datos[1, 1] = "";
                    datos[1, 2] = "";
                    datos[1, 3] = "";
                    datos[1, 4] = "";
                }
                if (datos[2, 0] == vseleccion_picker)
                {
                    datos[2, 0] = "";
                    datos[2, 1] = "";
                    datos[2, 2] = "";
                    datos[2, 3] = "";
                    datos[2, 4] = "";
                }
                PickerPantalla.Items.Remove(txtnombre.Text);
                txtnombre.Text = "";
                PickerPantalla.SelectedItem = "";
                txtcedula.Text = "";
                txttelefono.Text = "";
                PickerMotivo.SelectedItem = "";
                lblmensaje.TextColor = Color.DarkCyan;                
                DisplayAlert("Botón Eliminar", "DATOS ELIMINADOS...", "OK");
            }
            else
                DisplayAlert("Botón Eliminar", "DEBE DE SELECCIONAR LA PERSONA QUE DESEA ELIMINAR...", "OK");
        }

        private void PickerPantalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            vseleccion_picker = PickerPantalla.SelectedItem.ToString().Trim();
        }

        private void Btnconsultar_Clicked(object sender, EventArgs e)
        {
            if (vseleccion_picker.Trim() != "")
            {
                if (datos[0, 0] == vseleccion_picker)
                {
                    txtnombre.Text = datos[0, 0];
                    PickerMotivo.SelectedItem = datos[0, 1];
                    string vfecha = datos[0, 2];                    
                    //picfecha.Date =  DateTime.ParseExact(vfecha.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    txtcedula.Text = datos[0, 3];
                    txttelefono.Text = datos[0, 4];
                }
                if (datos[1, 0] == vseleccion_picker)
                {
                    txtnombre.Text = datos[1, 0];
                    PickerMotivo.SelectedItem = datos[1, 1];
                    string vfecha = datos[1, 2];
                    //picfecha.Date = DateTime.Parse(vfecha.ToString());
                    txtcedula.Text = datos[1, 3];
                    txttelefono.Text = datos[1, 4];
                }
                if (datos[2, 0] == vseleccion_picker)
                {
                    txtnombre.Text = datos[2, 0];
                    PickerMotivo.SelectedItem = datos[2, 1];
                    string vfecha = datos[0, 2];
                    //picfecha.Date = DateTime.Parse(vfecha.ToString());
                    txtcedula.Text = datos[2, 3];
                    txttelefono.Text = datos[2, 4];
                }
            }
            else
                DisplayAlert("Botón Guardar", "DEBE DE SELECCIONAR LA PERSONA QUE DESEA BORRAR...", "OK");
        }

        private void Btnaplicar_Clicked(object sender, EventArgs e)
        {
            int vfila = 0;
            string vcontinua = "S";
            string vexiste = "N";
                if (datos[0, 0] == null)
                    vfila = 0;
                else
                {
                    if (datos[0, 0] == txtnombre.Text.Trim().ToUpper())
                        vexiste = "S";
                    if (datos[1, 0] == null)
                        vfila = 1;
                    else
                    {
                        if (datos[1, 0] == txtnombre.Text.Trim().ToUpper())
                            vexiste = "S";
                        if (datos[2, 0] == null)
                            vfila = 2;
                        else
                        {
                            if (datos[2, 0] == txtnombre.Text.Trim().ToUpper())
                                vexiste = "S";
                            vcontinua = "N";
                        }
                    }
                }
                if (vcontinua == "S" && vexiste == "N")
                {
                    PickerPantalla.Items.Add(txtnombre.Text.ToUpper());
                    string motivo = PickerMotivo.SelectedItem.ToString().Trim();
                    datos[vfila, 0] = txtnombre.Text.ToUpper();
                    datos[vfila, 1] = motivo;
                    datos[vfila, 2] = picfecha.ToString();
                    datos[vfila, 3] = txtcedula.Text.ToString();
                    datos[vfila, 4] = txttelefono.Text.ToString();
                    lblmensaje.TextColor = Color.ForestGreen;
                    //lblmensaje.Text = "DATOS GUARDADOS...";
                    DisplayAlert("Botón Guardar", "SUS DATOS FUERON GUARDADOS CON EXITO", "OK");
                }
                else
                {
                    if (vexiste == "S")
                        //lblmensaje.Text = "YA LA PERSONA ESTA REGISTRADA...";
                        DisplayAlert("Botón Guardar", "YA LA PERSONA SE ENCUENTRA REGISTRADA...", "OK");
                    if (vcontinua == "N")
                        //lblmensaje.Text = "NO EXISTE ESPACIO...DEBE ELIMINAR A ALGUIEN...";
                        DisplayAlert("Botón Guardar", "NO EXISTE ESPACIO...DEBE ELIMINAR DATOS...", "OK");
                }
                txtnombre.Text = "";
                PickerMotivo.SelectedItem = "";
                txtcedula.Text = "";
                txttelefono.Text = "";
                picfecha.Date = DateTime.Now;
            
        }

    }
}
