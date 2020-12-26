using System;
using System.Collections.Generic;
using System.Text;

namespace Bake
{
    class Bread : BakerBuilder
    {
        public override void AddFlour()
        {
            Eat.flour = new Flour() { Name = "Arabaica" };
        }

        public override void AddSalt()
        {
            Eat.salt = new Salt() { Name = "some milk with foam" };
        }

        public override void AddEgg()
        {
            Eat.egg = new Egg() { Name = "some sugar for capuchino" };
        }

        public override void AddWater()
        {
            Eat.water = new Water() { Name = "some water for capuchino" };
        }
    }
    class Loaf : BakerBuilder
    {
        public override void AddFlour()
        {
            Eat.flour = new Flour() { Name = "Arabaica" };
        }

        public override void AddSalt()
        {
            Eat.salt = new Salt() { Name = "No milk" };
        }

        public override void AddEgg()
        {
            Eat.egg = new Egg() { Name = "some sugar for Espresso" };
        }

        public override void AddWater()
        {
            Eat.water = new Water() { Name = "some water for Espresso" };
        }
    }
    class Pita : BakerBuilder
    {
        public override void AddFlour()
        {
            Eat.flour = new Flour() { Name = "Arabaica" };
        }

        public override void AddSalt()
        {
            Eat.salt = new Salt() { Name = "No milk" };
        }

        public override void AddEgg()
        {
            Eat.egg = new Egg() { Name = "some sugar for Espresso" };
        }

        public override void AddWater()
        {
            Eat.water = new Water() { Name = "some water for Espresso" };
        }
    }
    class Barista
    {
        public CoffeeDrink Make(BakerBuilder bakerBuilder)
        {
            bakerBuilder.CreateDrink();
            bakerBuilder.AddFlour();
            bakerBuilder.AddWater();
            bakerBuilder.AddEgg();
            bakerBuilder.AddSalt();
            return bakerBuilder.Eat;
        }
    }
    abstract class BakerBuilder
    {
        public BakerBuilder Eat { get; set; }
        public void CreateDrink()
        {
            Eat = new BakerBuilder();
        }
        public abstract void AddFlour();
        public abstract void AddWater();
        public abstract void AddEgg();
        public abstract void AddSalt();

    }
    class CoffeeDrink
    {
        public Flour flour { get; set; }
        public Water water { get; set; }
        public Egg egg { get; set; }
        public Salt salt { get; set; }
        public override string ToString()
        {
            string result = flour.Name + Environment.NewLine +
                water.Name + Environment.NewLine +
                egg.Name + Environment.NewLine +
                salt.Name + Environment.NewLine;
            return result;
        }
    }
    class Flour
    {
        public string Name { get; set; }
    }
    class Water
    {
        public string Name { get; set; }
    }

    class Egg
    {
        public string Name { get; set; }
    }

    class Salt
    {
        public string Name { get; set; }
    }
}
