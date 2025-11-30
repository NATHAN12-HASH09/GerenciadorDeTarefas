using GerenciadorDeTarefas.Interfaces;
using System.Windows;

namespace GerenciadorDeTarefas.UI
{
    /// <summary>
    /// Lógica interna para InformacoesTarefaView.xaml
    /// </summary>
    public partial class InformacoesTarefaView : Window, IDialogService
    {
        public InformacoesTarefaView()
        {
            InitializeComponent();
        }
    }
}
