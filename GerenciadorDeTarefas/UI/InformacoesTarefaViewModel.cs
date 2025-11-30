using GerenciadorDeTarefas.Comandos;
using GerenciadorDeTarefas.Interfaces;
using GerenciadorDeTarefas.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace GerenciadorDeTarefas.UI
{
    class InformacoesTarefaViewModel :  BindableBase
    {
        private string tituloTarefa;
        private string conteudo;

        public string TituloTarefa
        {
            get { return tituloTarefa; }
            set { SetProperty(ref tituloTarefa, value); }
        }
        public string Conteudo
        {
            get { return conteudo; }
            set { SetProperty(ref conteudo, value); }
        }

        public DelegateCommand<IDialogService> SalvarTarefa { get; set; }

        public InformacoesTarefaViewModel(string tituloDaTarefa, string conteudo = null)
        {
            TituloTarefa = tituloDaTarefa;
            Conteudo = conteudo;
            SalvarTarefa = new DelegateCommand<IDialogService>(OnSalvarTarefa);
        }

        public void OnSalvarTarefa(IDialogService args)
        {
            if(Conteudo == null)
            {
                var mensagem = MessageBox.Show("Certeza que Deseja salvar a tarefa Vazia?", "Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mensagem == MessageBoxResult.No)
                    return;
            }
            args.DialogResult = true;
            args.Close();
        }
    }
}
