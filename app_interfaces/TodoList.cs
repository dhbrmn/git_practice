using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;
        

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            if (nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            else
            {
                Console.WriteLine("Your To-Do list is full!");
            }
        }

        public string HeaderSymbol
        { get { return "-"; } }


        public void Display()
        {
            Console.WriteLine("To-Do List:");
            Console.WriteLine($"{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}");
            foreach (string task in Todos)
            {
                if (string.IsNullOrEmpty(task))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(task);
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
