using System;

namespace Napilnik_001
{
       class Weapon
    {
        private readonly int _damage;
        private int _bullets;

        private bool _CanFire => _bullets > 0;

        public Weapon(int damage, int bullets)
        {
            _damage = damage;
            _bullets = bullets;

            if (_damage <= 0)
                throw new ArgumentException(nameof(_damage));
            if(_bullets < 0)
                throw new ArgumentException(nameof(_bullets));
        }

        public void Fire(Player player)
        {
            if (_CanFire == false)
                throw new ArgumentOutOfRangeException(nameof(_bullets));

            _bullets--;
            player.TakeDamage(_damage);
        }
    }
}
