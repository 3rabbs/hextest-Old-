using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Mob : Entity
    {
        //dependent stats; [0] is its default, [1] is current based on circumstance
        public int[] health;
        public int[] will;
        public int[] perception;
        public int[] speed;
        public int[] fatigue;
        public int[] weight;
        public int[] sizeModifier;
        public int[] damageModifer;
        //indendent stats; based off of the GURPS system (ST, DX, IQ, HT)
        public int MIGHT;
        public int SKILL;
        public int MIND;
        public int VITALITY;
        //
        public List<string> traits;
        public List<string> vitality;

        public Mob(String[] args)
        {
            
        }


        //generics
        public void update()
        {
            traits.Sort();
        }

    }
}
