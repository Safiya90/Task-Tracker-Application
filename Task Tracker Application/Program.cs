namespace Task_Tracker_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskList list = new TaskList(10);

            list.AddTask(new Task("Study", "Study for the math test", TaskPriority.High));
            list.AddTask(new Task("Buy Milk", "Get milk from the shop", TaskPriority.Low));
            list.AddTask(new Task("Project", "Finish OOP project", TaskPriority.Medium));

            Console.WriteLine("All Tasks:");
            list.ShowAll();

            Console.WriteLine("\nHigh Priority Tasks:");
            foreach (Task t in list[TaskPriority.High])
            {
                t.ShowInfo();
            }

            Console.WriteLine("\nMarking 'Study' as complete...");
            list.MarkComplete("Study");

            Console.WriteLine("\nAll Tasks After Update:");
            list.ShowAll();
        }
    }
    enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    class Task
    {
        public string Title;
        public string Description;
        public TaskPriority Priority;
        public bool IsCompleted;

        public Task(string title, string description, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}, Priority: {Priority}, Completed: {IsCompleted}");
        }
    }

    class TaskList
    {
        private Task[] tasks;
        private int count;

        public TaskList(int size)
        {
            tasks = new Task[size];
            count = 0;
        }

        public void AddTask(Task task)
        {
            if (count < tasks.Length)
            {
                tasks[count++] = task;
            }
            else
            {
                Console.WriteLine("Task list is full.");
            }
        }

        public void MarkComplete(string taskTitle)
        {
            for (int i = 0; i < count; i++)
            {
                if (tasks[i].Title == taskTitle)
                {
                    tasks[i].IsCompleted = true;
                    break;
                }
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < count; i++)
            {
                tasks[i].ShowInfo();
            }
        }

        public Task[] this[TaskPriority priority]
        {
            get
            {
                Task[] filtered = new Task[count];
                int index = 0;

                for (int i = 0; i < count; i++)
                {
                    if (tasks[i].Priority == priority)
                    {
                        filtered[index++] = tasks[i];
                    }
                }

                Task[] result = new Task[index];
                Array.Copy(filtered, result, index);
                return result;
            }
        }
    }

}
