using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ChristmasTree c = new ChristmasTree();
            ConcreteDecoratorToys d1 = new ConcreteDecoratorToys();
            ConcreteDecoratorLights d2 = new ConcreteDecoratorLights();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ChristmasTree : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ChristmasTree is here");
        }
    }
    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ConcreteDecoratorToys : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("It is decorated by toys");
        }
    }

    // "ConcreteDecoratorB" 
    class ConcreteDecoratorLights : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Our ChristmasTree is so bright with lights");
        }
        void AddedBehavior()
        { }
    }
}
