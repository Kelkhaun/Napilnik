using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napilnik_002
{
    class Good
    {
        public string Title { get; private set; }

        public Good(string title)
        {
            Title = title ?? throw new NullReferenceException(nameof(Title));
        }
    }
}
