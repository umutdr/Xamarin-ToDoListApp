using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListApp.ViewModels
{
    public class TodoListViewModel : ContentPage
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public ICommand AddTodoCommand { get; set; }
        public ICommand RemoveTodoCommand { get; set; }

        string _NewTodoInputValue = string.Empty;
        public string NewTodoInputValue
        {
            get => _NewTodoInputValue;
            set
            {
                if (_NewTodoInputValue != value)
                {
                    _NewTodoInputValue = value;
                    OnPropertyChanged();
                }
            }
        }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            AddTodoCommand = new Command(AddTodoItem);
            RemoveTodoCommand = new Command(RemoveTodoItem);

            TodoItems.Add(new TodoItem("Add a Todo!", false));
        }

        void AddTodoItem()
        {

            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = string.Empty;
        }

        void RemoveTodoItem(object o)
        {
            TodoItems.Remove((TodoItem)o);
        }

    }
}
