using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Pizza pizza1 = new ItalianPizza();
        pizza1 = new TomatoPizza(pizza1);
        Console.WriteLine("Numele: {0}", pizza1.Name);
        Console.WriteLine("Pretul: {0}", pizza1.GetCost());

        Pizza pizza2 = new ItalianPizza();
        pizza2 = new CheesePizza(pizza2);
        Console.WriteLine("Numele: {0}", pizza2.Name);
        Console.WriteLine("Pretul: {0}", pizza2.GetCost());

        Pizza pizza3 = new BulgerianPizza();
        pizza3 = new TomatoPizza(pizza3);
        pizza3 = new CheesePizza(pizza3);
        Console.WriteLine("Numele: {0}", pizza3.Name);
        Console.WriteLine("Pretul: {0}", pizza3.GetCost());

        Console.ReadLine();
    }
}

internal abstract class Pizza
{
    public Pizza(string n)
    {
        this.Name = n;
    }

    public string Name { get; protected set; }

    public abstract int GetCost();
}

internal class ItalianPizza : Pizza
{
    public ItalianPizza() : base("Pizza italiana")
    { }

    public override int GetCost()
    {
        return 10;
    }
}

internal class BulgerianPizza : Pizza
{
    public BulgerianPizza()
    : base("Pizza bulgara")
    { }

    public override int GetCost()
    {
        return 8;
    }
}

internal abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;

    public PizzaDecorator(string n, Pizza pizza) : base(n)
    {
        this.pizza = pizza;
    }
}

internal class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza p)
    : base(p.Name + ", cu tomat", p)
    { }

    public override int GetCost()
    {
        return pizza.GetCost() + 3;
    }
}

internal class CheesePizza : PizzaDecorator
{
    public CheesePizza(Pizza p)
    : base(p.Name + ", cu cascaval", p)
    { }

    public override int GetCost()
    {
        return pizza.GetCost() + 5;
    }
}
