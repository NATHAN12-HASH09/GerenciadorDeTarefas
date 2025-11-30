using GerenciadorDeTarefas.Interfaces;
using System.Windows;

namespace GerenciadorDeTarefas.UI
{
    /// <summary>
    /// Lógica interna para InputBoxView.xaml
    /// </summary>
    public partial class InputBoxView : Window, IDialogService
    {
        public InputBoxView()
        {
            InitializeComponent();
        }
    }
}
