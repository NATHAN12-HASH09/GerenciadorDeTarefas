using GerenciadorDeTarefas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeTarefas.Comandos
{
    public class DelegateCommand : RelayCommand
    {
        public DelegateCommand(Action targetExecuteMethod) : base(targetExecuteMethod)
        {
        }

        public DelegateCommand(Action targetExecuteMethod, Func<bool> targetCanExecuteMethod) : base(targetExecuteMethod, targetCanExecuteMethod)
        {
        }

        public static implicit operator DelegateCommand(DelegateCommand<IDialogService> v)
        {
            throw new NotImplementedException();
        }
    }
    public class DelegateCommand<T> : RelayCommand<T>
    {
        public DelegateCommand(Action<T> targetExecuteMethod) : base(targetExecuteMethod)
        {
        }

        public DelegateCommand(Action<T> targetExecuteMethod, Func<T, bool> targetCanExecuteMethod) : base(targetExecuteMethod, targetCanExecuteMethod)
        {
        }
    }
}
