using GerenciadorDeTarefas.Comandos;
using GerenciadorDeTarefas.Model;
using System.Collections.ObjectModel;

namespace GerenciadorDeTarefas.UI
{
    class GerenciadorDeTarefasViewModel : BindableBase
    {
        private bool filtrarPesquisaTarefaEnable;
        private string tarefaPesquisa;
        private Tarefa tarefa;

        public bool FiltrarPesquisaTarefaEnable
        {
            get { return filtrarPesquisaTarefaEnable; }
            set { SetProperty(ref filtrarPesquisaTarefaEnable, value); }
        }
        public string TarefaPesquisa
        {
            get { return tarefaPesquisa; }
            set { SetProperty(ref tarefaPesquisa, value);}
        }
        public Tarefa Tarefa
        {
            get { return tarefa; }
            set { SetProperty(ref tarefa, value); }
        }

        public DelegateCommand NovaTarefaCommand { get; set; }
        public DelegateCommand ExcluirTarefaCommand { get; set; }
        public DelegateCommand FiltrarPesquisaTarefa { get; set; }
        public DelegateCommand PesquisarTarefaCommand { get; set;  }
        public DelegateCommand AbrirTarefaCommand { get; set; }

        public ObservableCollection<Tarefa> Tarefas { get; set; }

        public GerenciadorDeTarefasViewModel()
        {
            NovaTarefaCommand = new DelegateCommand(OnNovaTarefaCommand);
            ExcluirTarefaCommand = new DelegateCommand(OnExcluirTarefaCommand);
            FiltrarPesquisaTarefa = new DelegateCommand(OnFiltrarPesquisaTarefa);
            PesquisarTarefaCommand = new DelegateCommand(OnPesquisarTarefaCommand);
            AbrirTarefaCommand = new DelegateCommand(OnAbrirTarefaCommand);
            Tarefas = new ObservableCollection<Tarefa>();
        }

        public void OnNovaTarefaCommand()
        {
            var dc = new InputBoxViewModel("Titulo da Tarefa", "Nova Tarefa");
            var dlg = new InputBoxView() { DataContext = dc };
            if (dlg.ShowDialog() != true)
                return;
            var dlgInformacoes = new InformacoesTarefaViewModel(dc.Input);
            var dcInformacoes = new InformacoesTarefaView() { DataContext = dc };
            if (dlg.ShowDialog() != true)
                return;

        }
        public void OnExcluirTarefaCommand()
        {

        }
        public void OnFiltrarPesquisaTarefa()
        {

        }
        public void OnPesquisarTarefaCommand()
        {

        }
        public void OnAbrirTarefaCommand()
        {

        }
    }
}
