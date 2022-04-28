using System;
using System.Collections.Generic;

namespace task_1
{
    enum ClientType : int
    {
        usual,
        VIP
    };

    public class Bank
    {
        public class Client
        {
            private class Deposit
            {
                private int sum;
                private int percent;

                public Deposit()
                {
                    sum = 0;
                    percent = 0;
                }
                public Deposit(int value, int percent)
                {
                    sum = value;
                    this.percent = percent;
                }
                public int Sum()
                {
                    return sum;
                }

                public int setPercent(int sum_)
                {
                    this.sum = sum_ * percent / 100;
                    return sum;
                }
                public void IncDeposit(int value)
                {
                    setPercent(sum += value);
                }
            };

            private int VIP;
            private string name = "";
            private Deposit deposit = new();

            public Client()
            {
                deposit = new Deposit();
                name = "";
                VIP = 0;
            }
            public Client(string nm, int dep, int percent, int VIP_status = 0)
            {
                name = nm;
                deposit = new Deposit(dep, percent);
                VIP = VIP_status;
            }

            public string Name()
            {
                return name;
            }

            public int ClientDeposit()
            {
                return deposit.setPercent(deposit.Sum());
            }
            public string Info()
            {
                return "\nИмя: " + name + "\tВклад: " + ClientDeposit().ToString();
            }
        };

        private List<Client> clients;

        private string name;

        public Bank()
        {
            name = "";
            clients = new List<Client>();
        }
        public Bank(string nm)
        {
            name = nm;
            clients = new List<Client>();
        }

        public void AddClient(string name, int sum, int percent = 3, int status = 0)
        {
            clients.Add(new Client(name, sum, percent, status));
        }

        public void AddClient(Client person)
        {
            clients.Add(person);
        }

        public void PrintInfo()
        {
            foreach (var person in clients)
            {
                Console.WriteLine(person.Info());
            }
        }

        public int getPercent(int i)
        {
            return clients[i].ClientDeposit();
        }
        public int getPayments()
        {
            int sum = 0;

            foreach (var person in clients)
            {
                sum += person.ClientDeposit();
            }

            return sum;
        }
    };

    public class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank("MyBank");

            char answer = '1';
            do
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                string sum_str;
                int sum;

                Console.WriteLine("Enter deposit:");
                sum_str = Console.ReadLine();
                sum = int.Parse(sum_str);

                bank.AddClient(name, sum);

                Console.WriteLine("Continue? (1/0)");
                answer = char.Parse(Console.ReadLine());

            } while (answer != '0');

            bank.PrintInfo();

        }
    }
}