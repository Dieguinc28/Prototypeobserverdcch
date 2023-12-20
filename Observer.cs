using System;

public interface IObserver
{
    void Update(string news);
}

public class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"{name} recibió la noticia: {news}");
    }
}