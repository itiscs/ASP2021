using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class Todos
    {
        public List<ToDo> List { get; set; } 

        public Todos()
        {
            List = new List<ToDo>();
            List.Add(new ToDo() { Id=1, Name = "Task 1", IsComplete = true });
            List.Add(new ToDo() { Id=2, Name = "Task 2", IsComplete = false });
            List.Add(new ToDo() { Id=3, Name = "Task 3", IsComplete = true });
            List.Add(new ToDo() { Id=4, Name = "Task 4", IsComplete = false });
            List.Add(new ToDo() { Id=1, Name = "Task 1", IsComplete = true });
            List.Add(new ToDo() { Id=2, Name = "Task 2", IsComplete = false });
            List.Add(new ToDo() { Id=3, Name = "Task 3", IsComplete = true });
            List.Add(new ToDo() { Id=4, Name = "Task 4", IsComplete = false });
            List.Add(new ToDo() { Id=1, Name = "Task 1", IsComplete = true });
            List.Add(new ToDo() { Id=2, Name = "Task 2", IsComplete = false });
            List.Add(new ToDo() { Id=3, Name = "Task 3", IsComplete = true });
            List.Add(new ToDo() { Id=4, Name = "Task 4", IsComplete = false });

        }



    }
}
