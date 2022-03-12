using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ConcreteSubject:Subject
    {
        List<Observer> observers = new List<Observer> { };

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update();
            }
        }

        public void RegisterObserver(Observer obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(Observer obs)
        {
            observers.Remove(obs);
        }

        int state;
        public int State
        {
            get { return state; }
            set { state = value; this.NotifyObserver(); }
        }
    }
}
