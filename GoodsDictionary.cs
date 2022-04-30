using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napilnik_002
{
    class GoodsDictionary
    {
        private readonly Dictionary<Good, int> _goods = new Dictionary<Good, int>();

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new NullReferenceException(nameof(good));
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_goods.ContainsKey(good))
                _goods[good] += count;
            else
                _goods.Add(good, count);
        }

        public void ShowGoods()
        {
            if (_goods.Count == 0)
                Console.WriteLine("Товаров нет.");
            else
                foreach (var good in _goods) Console.WriteLine(good.Key.Title + " " + good.Value);
        }

        public bool CheckGood(Good good, int count)
        {
            if (_goods.ContainsKey(good) && _goods[good] >= count)
                return true;

            return false;
        }
    }
}
