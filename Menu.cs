using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Menu
    {
        private List<ToDo> collection = new List<ToDo>();
        public Menu()
        {
            while (true)
            {
                MainMenu();
            }
        }
        public void MainMenu()
        {
            do
            {
                if (collection.Count == 0)
                {
                    Console.WriteLine("[0] Add item");
                    string input = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
                    ClearCurrentConsoleLine();
                    if (input == "0")
                    {
                        AddItem();
                    }
                }
                else
                {
                    Console.WriteLine("[0] Show List\t[1] Add item\t[2] Remove item\t");
                    string input = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
                    ClearCurrentConsoleLine();
                    
                    if (input == "0")
                    {
                        ShowList();
                    }
                    else if (input == "1")
                    {
                        AddItem();
                    }
                    else if (input == "2")
                    {
                        RemoveItem();
                    }
                }
            } while (true);
        }
        private void ShowList()
        {
            foreach (ToDo item in collection)
            {
                ShowItem(item);
            }
        }

        private void AddItem()
        {
            ToDo todo = new ToDo();
            do
            {
                Console.Write("Enter todo: ");
                todo.Todo = Console.ReadLine();
            } while (todo.Todo == null);

            do
            {
                Console.Write("Enter description: ");
                todo.Description = Console.ReadLine();
            } while (todo.Description == null);

            do
            {
                Console.Write("Enter deadline: ");
                todo.Deadline = Convert.ToDateTime(Console.ReadLine());
            } while (todo.Deadline == null);

            collection.Add(todo);
        }

        private void RemoveItem()
        {
            ShowList();
            Console.WriteLine("Enter index of item to remove: ");
            int index = Convert.ToInt32(Console.ReadLine());
            collection.RemoveAt(index);
        }

        public void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        private void ShowItem(ToDo item)
        {
            Console.WriteLine($"Created: {item.Created}\nDeadline: {item.Deadline}\nTodo: {item.Todo}\nDescription: {item.Description}\n");
        }

    }
}
