using System.Collections.Generic;

public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(string news);
    void PublishNews(string news);
}

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string news)
    {
        foreach (var observer in observers)
        {
            observer.Update(news);
        }
    }

    public void PublishNews(string news)
    {
        Console.WriteLine($"Publicando noticia: {news}");
        NotifyObservers(news);
    }
}
