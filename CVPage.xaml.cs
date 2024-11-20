using System.Xml;
using Xamarin.Forms;

namespace MyApp
{
    public partial class CVPage : ContentPage
    {
        public CVPage(string name, string age, string email, string phone)
        {
            InitializeComponent();

            // Asignar los datos recibidos a los elementos de la UI
            NameLabel.Text = name;
            AgeLabel.Text = $"Edad: {age}";
            EmailLabel.Text = $"Correo: {email}";
            PhoneLabel.Text = $"Telefono: {phone}";
        }
    }
}
