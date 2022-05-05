using System;

namespace Napilnik_001
{
    class Player
    {
        private int _health;

        private bool _isDead => _health <= 0;

        public Player(int health)
        {
            _health = health;

            if (_isDead)
                throw new ArgumentException(nameof(_health));
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_isDead)
                Console.WriteLine("Я умер");
        }
    }
}
