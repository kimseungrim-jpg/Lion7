using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY09_03
{
    internal class Program
    {
        public class Character
        {
            public virtual void Render()
            {
                Console.WriteLine("캐릭터");
            }
        }

        public class Warrior : Character
        {
            public override void Render()
            {
                Console.WriteLine("워리어");
            }
        }

        public class Mage : Warrior
        {
            public override void Render()
            {
                Console.WriteLine("마법사");
            }
        }

        static void Main(string[] args)
        {
            Character character = new Character();
            character.Render();
        }
    }
}
