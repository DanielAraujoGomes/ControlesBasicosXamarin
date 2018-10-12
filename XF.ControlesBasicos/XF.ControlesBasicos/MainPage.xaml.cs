﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ControlesBasicos.Views;

namespace XF.ControlesBasicos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (!App.configuracao.AceitaReceberEmail)
                DisplayAlert("Atenção", "E-mail não autorizado", "OK");
            else if (App.configuracao.EnderecoEmail.Equals(""))
                DisplayAlert("Atenção", "E-mail não informado", "OK");
            else
                DisplayAlert("Enviado"
                        , $"E-mail enviado para: {App.configuracao.EnderecoEmail}", "OK");
        }

        void btnConfigurar_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigurarPage());
        }
    }
}
