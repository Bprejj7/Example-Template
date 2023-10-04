using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Character
    {
        private float _health;
        private string _name;
        private float _attack;
        private float _defense;

        public Character(float health, string name, float attack, float defense)
        {
            _health = health;
            _name = name;
            _attack = attack;
            _defense = defense;
        }

        public Character()
        {

        }
        
        public string GetName()
        {
            return _name;
        }

        public float GetHealth()
        {
            return _health;
        }

        public float GetAttack()
        {
            return _attack;
        }

        public float GetDefense()
        {
            return _defense;
        }
        public void Move()
        {
            //Do move stuff
        }
        
        public void Speak()
        {
            //Do speak stuff
        }

        public void Attack()
        {
            //Do attack stuff
        }
    }
}
