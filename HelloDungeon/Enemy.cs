using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Enemy : Character
    {
        private bool _isAggro;
        private float _chaseDelay;

        public Enemy(bool isAggro, float chaseDelay, float health, string name, float attack, float defense) : base(health, name, attack, defense)
        {
            _isAggro = isAggro;
            _chaseDelay = chaseDelay;
        }

        public override void Move()
        {
            //Do enemy function
        }
    }
}
