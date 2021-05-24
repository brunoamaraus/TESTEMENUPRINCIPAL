using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTEMENUPRINCIPAL.Data
{
    public interface IState
    {
        event Action Notify;
        bool ShowEasterEggs { get; set; }
    }
    public class State : IState
    {
        public event Action Notify;

        bool showEggs = false;
        public bool ShowEasterEggs
        {
            get => showEggs;
            set
            {
                if (showEggs != value)
                {
                    showEggs = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }
    }
}
