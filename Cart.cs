using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napilnik_002
{
    class Cart
    {
        private readonly GoodsDictionary _goods = new GoodsDictionary();
        private readonly Warehouse _warehouse;

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new NullReferenceException(nameof(_warehouse));
        }

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new NullReferenceException(nameof(good));

            if (_warehouse.HasRequestingGoods(good, count))
                _goods.Add(good, count);
            else
                throw new NullReferenceException(nameof(count));
        }

        public void ShowRequestGoods()
        {
            Console.WriteLine("\nКорзина товаров: ");
            _goods.ShowGoods();
        }
    }
}
