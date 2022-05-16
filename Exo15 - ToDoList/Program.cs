using System;
using System.Collections.Generic;
using System.Linq;

namespace Exo15___ToDoList
{
    class Program
    {
        #region Avec une List<string>
        //static void Main(string[] args)
        //{
        //    List<string> list = new List<string>();
        //    string command;
        //    do
        //    {
        //        Console.Clear();
        //        int index = 0;
        //        foreach (string task in list)
        //        {
        //            Console.WriteLine($"{index} : {task}");
        //            index++;
        //        }
        //        Console.WriteLine($"Veuillez indiquer une option :\n1) Ajouter\n2)Supprimer\n3)Quitter");
        //        command = Console.ReadLine();
        //        if (command == "1")
        //        {
        //            Console.WriteLine("Ajouter une tâche :");
        //            string task = Console.ReadLine().Trim();
        //            if(task.Length > 0) list.Add(task);
        //        }
        //        else if(command == "2")
        //        {
        //            int delete;
        //            do
        //            {
        //                Console.WriteLine("Veuillez choisir un numéro de tâche:");
        //            } while (!int.TryParse(Console.ReadLine(), out delete) || delete < 0 || delete > list.Count-1);
        //            list.Remove(list[delete]);
        //        }

        //    } while (command != "3");
        //} 
        #endregion

        #region Avec un dictionnary<string, bool>
        static void Main(string[] args)
        {
            Dictionary<string, bool> list = new Dictionary<string, bool>();
            string command;
            do
            {
                Console.Clear();
                int index = 0;
                foreach (KeyValuePair<string, bool> task in list)
                {
                    if (task.Value) Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{index} : {task.Key}");
                    Console.ResetColor();
                    index++;
                }
                Console.WriteLine($"Veuillez indiquer une option :\n1) Ajouter\n2)  Finir tâche\n3) Supprimer\n4) Quitter");
                command = Console.ReadLine();
                if (command == "1")
                {
                    Console.WriteLine("Ajouter une tâche :");
                    string task = Console.ReadLine().Trim();
                    if (task.Length > 0 && !list.ContainsKey(task)) list.Add(task, false);
                }
                else if (command == "2")
                {
                    int delete;
                    do
                    {
                        Console.WriteLine("Veuillez choisir un numéro de tâche:");
                    } while (!int.TryParse(Console.ReadLine(), out delete) || delete < 0 || delete > list.Count - 1);
                    list[list.ElementAt(delete).Key] = true;
                }
                else if (command == "3")
                {
                    int delete;
                    do
                    {
                        Console.WriteLine("Veuillez choisir un numéro de tâche:");
                    } while (!int.TryParse(Console.ReadLine(), out delete) || delete < 0 || delete > list.Count - 1);
                    list.Remove(list.ElementAt(delete).Key);
                }

            } while (command != "4");
        }
        #endregion
    }
}
