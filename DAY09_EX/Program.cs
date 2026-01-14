using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY09_EX
{
    public class Animal
    {
        protected string name;
        protected string cry;
        protected string eat;

        public Animal(string animalName, string animalCry, string animalEat)
        {
            name = animalName;
            cry = animalCry;
            eat = animalEat;
        }

        public virtual void ShowAnimal()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"울음 소리 : {cry}");
            Console.WriteLine($"먹이 : {eat}");
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name, string cry, string eat) : base(name, cry, eat) { }

        public override void ShowAnimal()
        {
            Console.WriteLine("원숭이 입니다.");
            base.ShowAnimal();
        }
    }

    public class Lion : Animal
    {
        public Lion(string name, string cry, string eat) : base(name, cry, eat) { }


        public override void ShowAnimal()
        {
            Console.WriteLine("사자 입니다.");
            base.ShowAnimal();
        }
    }

    public class Zoo
    {
        List<Animal> animals = new List<Animal>();

        public void AddList(Animal animal)
        {
            animals.Add(animal);
        }

        public void InfoAnimal()
        {
            foreach (Animal animal in animals)
            {
                animal.ShowAnimal();
            }
        }
    }

    public class Shop
    {
        protected string kind;
        protected int power;
        protected string name;
        protected double price;
        protected int sailPrice;
        protected double sail;

        public Shop(string itemkind, int itempower, string itemname, double itemprice, double itemsail)
        {
            this.kind = itemkind;
            this.power = itempower;
            this.name = itemname;
            this.price = itemprice;
            this.sail = itemsail;
            this.sailPrice = (int)(price - (price / sail));
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"고르신 상품은 : {kind} {{{name}}}입니다.");
            Console.WriteLine($"{name}의 공격력 : {power}");
            Console.WriteLine($"가격 : {price}");
        }
    }

    public class Sword : Shop
    {
        public Sword(string kind, int power, string name, double price, double sail) : base(kind, power, name, price, sail) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"현재 {10}% 할인중입니다.");
            Console.WriteLine($"할인 적용된 가격 : {base.sailPrice}");
        }
    }

    public class Arrow : Shop
    {
        public Arrow(string kind, int power, string name, double price, double sail) : base(kind, power, name, price, sail) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"현재 {sail}% 할인중입니다.");
            Console.WriteLine($"할인 적용된 가격 : {base.sailPrice}");
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Console.WriteLine("=== 동물원 ===");

            animals.Add(new Lion("자", "어흥", "육류"));
            animals.Add(new Monkey("숭이", "우끼", "바나나"));

            foreach (Animal animal in animals)
            {
                animal.ShowAnimal();
                Console.WriteLine();
            }

            Console.WriteLine("=== 무기상점 ===");

            List<Shop> shops = new List<Shop>();

            shops.Add(new Sword("검", 32, "몰락한 왕의 검", 3200, 10));
            shops.Add(new Arrow("활", 55, "돌풍", 3300, 20));

            foreach (Shop shop in shops)
            {
                shop.ShowInfo();
                Console.WriteLine();
            }

        }
    }
}
