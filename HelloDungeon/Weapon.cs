using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Weapon
    {
        private string _name;
        private float _damage;
        private float _weight;
        private float _durability;

        public Weapon(string name, float damage, float weight, float durability)
        {
            _name = name;
            _damage = damage;
            _weight = weight;
            _durability = durability;
            
        }

        public Weapon()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public float GetWeight()
        {
            return _weight;
        }

        public float GetDurability()
        {
            return _durability;
        }

        public float GetDamage()
        {
            return _damage;
        }

        public void Damage()
        {
            //Do damage stuff
        }

        public void Weight()
        {
            //Do weight stuff
        }

        public void Durability()
        {
            //Do durability stuff
        }
    }
}
