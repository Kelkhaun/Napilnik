using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napilnik_002
{
    class Shop
    {
        private readonly Warehouse _warehouse = new Warehouse();
        private Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new NullReferenceException(nameof(_warehouse));
        }

        public Cart Cart()
        {
            _cart = new Cart(_warehouse);
            return _cart;
        }
    }
}
