using System;

namespace Napilnik_001
{
    class Player
    {
        private int _health;

        private bool _isAlive => _health > 0;

        public Player(int health)
        {
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            if (_isAlive == false)
                throw new ArgumentOutOfRangeException(nameof(_health));

            _health -= damage;
        }
    }
}
