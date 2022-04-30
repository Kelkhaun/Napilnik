using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napilnik_002
{
    class Warehouse
    {
        private readonly GoodsDictionary _goods = new GoodsDictionary();

        public Warehouse()
        {
            _goods.Add(new Good("Iphone 12"), 3);
            _goods.Add(new Good("Iphone 11"), 1);
        }

        public void Delieve(Good good, int count)
        {
            if (good == null)
                throw new NullReferenceException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            _goods.Add(good, count);
        }

        public void ShowAvaliableGoods()
        {
            Console.WriteLine("\nТовары в наличии: ");
            _goods.ShowGoods();
        }

        public bool HasRequestingGoods(Good good, int count)
        {
            if (good == null)
                throw new NullReferenceException(nameof(good));

            if (_goods.CheckGood(good, count)) return true;
            return false;
        }
    }
}
