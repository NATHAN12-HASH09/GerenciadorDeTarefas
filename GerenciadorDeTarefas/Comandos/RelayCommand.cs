using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GerenciadorDeTarefas.Comandos
{
    public class RelayCommand : ICommand
    {

        private Func<bool> targetCanExecuteMethod;
        private Action targetExecuteMethod;

        public RelayCommand(Action targetExecuteMethod)
        {
            this.targetExecuteMethod = targetExecuteMethod;
        }
        public RelayCommand(Action targetExecuteMethod, Func<bool> targetCanExecuteMethod) : this(targetExecuteMethod)
        {
            this.targetCanExecuteMethod = targetCanExecuteMethod;
        }
        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter)
        {
            if (targetCanExecuteMethod != null)
                return targetCanExecuteMethod();
            if (targetExecuteMethod != null)
                return true;
            return false;
        }

        public void Execute(object parameter)
        {
            if (targetExecuteMethod != null)
                targetExecuteMethod();
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

    }
    public class RelayCommand<T> : ICommand
    {
        #region Private Campos

        private Func<T, bool> targetCanExecuteMethod;
        private Action<T> targetExecuteMethod;

        #endregion Private Campos

        #region Public Construtoras

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class.
        /// </summary>
        /// <param name="targetExecuteMethod">The target execute method.</param>
        public RelayCommand(Action<T> targetExecuteMethod)
        {
            this.targetExecuteMethod = targetExecuteMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class.
        /// </summary>
        /// <param name="targetExecuteMethod">The target execute method.</param>
        /// <param name="targetCanExecuteMethod">The target can execute method.</param>
        public RelayCommand(Action<T> targetExecuteMethod, Func<T, bool> targetCanExecuteMethod) : this(targetExecuteMethod)
        {
            this.targetCanExecuteMethod = targetCanExecuteMethod;
        }

        #endregion Public Construtoras

        #region Public Eventos

        /// <summary>
        /// Occurs when [can execute changed].
        /// </summary>
        public event EventHandler CanExecuteChanged = delegate { };

        #endregion Public Eventos

        #region Public Métodos

        /// <summary>
        /// Determines whether this instance can execute the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns>
        ///   <c>true</c> if this instance can execute the specified parameter; otherwise, <c>false</c>.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            if (targetCanExecuteMethod != null)
            {
                T param = (T)parameter;
                return targetCanExecuteMethod(param);
            }
            if (targetExecuteMethod != null)
                return true;
            return false;
        }

        /// <summary>
        /// Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        public void Execute(object parameter)
        {
            if (targetExecuteMethod != null)
                targetExecuteMethod((T)parameter);
        }

        /// <summary>
        /// Raises the can execute changed.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #endregion Public Métodos
    }
}
