using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeTarefas.Interfaces
{
     public interface IDialogService : IUserControlService
    {
        bool? DialogResult { get; set; }
        string Title { get; set; }
        void Close();
        void Show();
        bool? ShowDialog();
    }
}
