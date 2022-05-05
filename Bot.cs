using System;

namespace Napilnik_001
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon ?? throw new NullReferenceException(nameof(_weapon));
        }

        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new NullReferenceException(nameof(player));

            _weapon.Fire(player);
        }
    }
}
