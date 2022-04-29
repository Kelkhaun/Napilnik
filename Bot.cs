using System;

namespace Napilnik_001
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon ?? throw new ArgumentOutOfRangeException(nameof(weapon));
        }

        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentOutOfRangeException(nameof(player));

            _weapon.Fire(player);
        }
    }
}
