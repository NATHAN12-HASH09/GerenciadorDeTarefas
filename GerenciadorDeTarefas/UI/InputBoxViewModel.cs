using GerenciadorDeTarefas.Comandos;
using GerenciadorDeTarefas.Interfaces;
using GerenciadorDeTarefas.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace GerenciadorDeTarefas.UI
{
    class InputBoxViewModel : BindableBase
    {
        private string tituloInput;
        private string tituloJanela;
        private string input;

        public string TituloInput
        {
            get { return tituloInput; }
            set { SetProperty(ref tituloInput, value); }
        }
        public string TituloJanela
        {
            get { return tituloJanela; }
            set { SetProperty(ref tituloJanela, value); }
        }
        public string Input
        {
            get { return input; }
            set { SetProperty(ref input, value); }
        }

        public DelegateCommand<IDialogService> SalvarInput { get; set; }

        public InputBoxViewModel(string tituloInput, string tituloJanele)
        {
            TituloInput = tituloInput;
            TituloJanela = tituloJanele;
            SalvarInput = new DelegateCommand<IDialogService>(OnSalvar);
        }

        public void OnSalvar(IDialogService args)
        {
            if(Input == null)
            {
                MessageBox.Show("Preencha o campo de nome para poder salvar");
                return;
            }
            args.DialogResult = true;
            args.Close();
        }
    }
}
