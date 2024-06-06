using System;
using Microsoft.Maui.Controls;

namespace XavierGordillo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRechargeClicked(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberEntry.Text;
            string selectedOperator = operatorPicker.SelectedItem?.ToString();
            string selectedRecharge = rechargePicker.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(phoneNumber) || selectedOperator == null || selectedRecharge == null)
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            
            DisplayAlert("Recarga Exitosa", $"Número: {phoneNumber}\nOperador: {selectedOperator}\nRecarga: {selectedRecharge}", "OK");
        }
    }
}
