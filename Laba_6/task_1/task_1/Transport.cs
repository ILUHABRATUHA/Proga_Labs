using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public abstract class Transport
    {
        protected int cost;
        protected string name;
        public int GetCost()
        {
            return cost;
        }

        public void ChangeName(string NewName)
        {
            name = NewName;
        }

        public string GetName()
        {
            return name;
        }
        public abstract void View();
        public Transport(int cost, string name)
        {
            this.cost = cost;
            this.name = name;
        }
    }

    public sealed class Bus : Transport
    {
        private int places;
        public int Places()
        {
            return places;
        }
        public Bus(string name_, int cost_, int places_) : base(cost_, name_)
        {
            cost = cost_;
            places = places_;
            name = name_;
        }

        public override void View()
        {
            //Console.WriteLine("\nName: " + name + " Cost: " + cost + " Amount of places: " + places);
        }
    }
    public class Car : Transport
    {
        private bool isMinivan;

        public Car(string name, int cost, bool isMinivan) : base(cost, name)
        {
            this.cost = cost;
            this.name = name;
            this.isMinivan = isMinivan;
        }
        public override void View()
        {
            Console.WriteLine("\nName: " + name + " Cost: " + cost);
        }
        public bool IsMinivan()
        {
            return isMinivan;
        }
        public void ChangeStatus(bool status)
        {
            isMinivan = status;
        }
        public new void ChangeName(string NewName)
        {
            name = NewName + (isMinivan ? " (Minivan)" : " (Not minivan)");
        }

    }
}
