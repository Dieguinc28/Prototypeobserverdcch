using System;

class Program
{
    static void Main()
    {
        // Crear instancias de observadores y sujeto
        var observer1 = new ConcreteObserver("Observador DIEGO");
        var observer2 = new ConcreteObserver("Observador JULIO");
        var subject = new ConcreteSubject();

        // Registrar observadores en el sujeto
        subject.AddObserver(observer1);
        subject.AddObserver(observer2);

        // Publicar noticias y notificar a los observadores
        subject.PublishNews("Nueva noticia sobre el turismo de manta");
    }
}