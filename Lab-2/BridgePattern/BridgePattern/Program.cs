using System;
internal class Program
{
    private static void Main(string[] args)
    {

        Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
        freelancer.DoWork();
        freelancer.EarnMoney();

        freelancer.Language = new CSharpLanguage();
        freelancer.DoWork();
        freelancer.EarnMoney();

        Console.Read();
    }
}

internal interface ILanguage
{
    void Build();

    void Execute();
}

internal class CPPLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("Folosind compilatorul C++, compilați programul în cod binar");
    }

    public void Execute()
    {
        Console.WriteLine("Rulați fișierul executabil al programului");
    }
}

internal class CSharpLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("Folosind compilatorul Roslyn, compilați codul sursă într-un fișier exe");
    }

    public void Execute()
    {
        Console.WriteLine("JIT compilează codul binar al programului");
        Console.WriteLine(" CLR execută cod binar compilat");
    }
}

internal abstract class Programmer
{
    protected ILanguage language;

    public ILanguage Language
    {
        set { language = value; }
    }

    public Programmer(ILanguage lang)
    {
        language = lang;
    }

    public virtual void DoWork()
    {
        language.Build();
        language.Execute();
    }

    public abstract void EarnMoney();
}

internal class FreelanceProgrammer : Programmer
{
    public FreelanceProgrammer(ILanguage lang) : base(lang)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Primirea plății pentru comanda finalizată");
    }
}

internal class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage lang)
    : base(lang)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Se plătește la sfârșitul lunii");
    }
}