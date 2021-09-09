using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class TodoItem
    {
        public string Text { get; set; }
        public bool Completed { get; set; }

        public TodoItem(string todoText, bool todoCompleted)
        {
            this.Text = todoText;
            this.Completed = todoCompleted;
        }
    }
}
