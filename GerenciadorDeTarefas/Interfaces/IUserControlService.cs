using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace GerenciadorDeTarefas.Interfaces
{
    public interface IUserControlService
    {
        Cursor Cursor { get; set; }
        Visibility Visibility { get; set; }
    }
}
