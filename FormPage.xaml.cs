using System;
using Xamarin.Forms;

namespace MyApp
{
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private async void OnGenerateCVClicked(object sender, EventArgs e)
        {
            // Recoger datos del formulario
            string name = NameEntry.Text;
            string age = AgeEntry.Text;
            string email = EmailEntry.Text;
            string phone = PhoneEntry.Text;

            // Validar campos (opcional)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                await DisplayAlert("Error", "Por favor complete todos los campos.", "OK");
                return;
            }

            // Redirigir a la página de CV, pasando datos como parámetros
            await Navigation.PushAsync(new CVPage(name, age, email, phone));
        }
    }
}
