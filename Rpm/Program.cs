using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverLibrary;

namespace Rpm
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            ConcreteSubject subject = new ConcreteSubject();

            subject.RegisterObserver(observer1);
            subject.State = 5;
            Console.WriteLine("Наблюдатель 1 - " + observer1.Counter);
            Console.WriteLine("Наблюдатель 2 - " + observer2.Counter);

            subject.RegisterObserver(observer2);
            subject.State = 3;
            Console.WriteLine("Наблюдатель 1 - " + observer1.Counter);
            Console.WriteLine("Наблюдатель 2 - " + observer2.Counter);

            subject.RemoveObserver(observer2);
            subject.State = 0;
            Console.WriteLine("Наблюдатель 1 - " + observer1.Counter + "\nНаблюдатель 2 - " + observer2.Counter);

            Console.ReadKey();
        }
    }
}
