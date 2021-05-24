using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTEMENUPRINCIPAL.Data
{
    public class ItemBarService
    {
        public class NotifierService
        {
            private readonly List<string> values = new List<string>();
            public IReadOnlyList<string> ValuesList => values;

            public NotifierService()
            {

            }

            public async void AddTolist(string value)
            {
                values.Add(value);
                if (Notify != null)
                {
                    await Notify?.Invoke();
                }

            }

            public event Func<Task> Notify;
        }
    }
}
