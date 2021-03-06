using System;

class Program
{
    static void Main(string[] args)
    {
        Pult pult = new Pult();
        TV tv = new TV();
        pult.SetCommand(new TVOnCommand(tv));
        pult.PressButton();
        pult.PressUndo();

        Console.Read();
    }
}

interface ICommand
{
    void Execute();
    void Undo();
}

class TV
{
    public void On()
    {
        Console.WriteLine("Dispozitiv inclus");
    }

    public void Off()
    {
        Console.WriteLine("dispozitivul este dezactivat");
    }
}

class TVOnCommand : ICommand
{
    TV tv;
    public TVOnCommand(TV tvSet)
    {
        tv = tvSet;
    }
    public void Execute()
    {
        tv.On();
    }
    public void Undo()
    {
        tv.Off();
    }
}

class Pult
{
    ICommand command;

    public Pult() { }

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void PressButton()
    {
        command.Execute();
    }
    public void PressUndo()
    {
        command.Undo();
    }
}