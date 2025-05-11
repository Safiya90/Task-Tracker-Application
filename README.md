# Task Tracker Application

Concepts Used: Enum, Indexer, Encapsulation, Collections
Description:
Create an enum `TaskPriority`: Low, Medium, High
Create a class `Task` with:
- Title, Description, Priority (enum), IsCompleted
Create a class `TaskList` with:
- Internal list of tasks
- Indexer to return all tasks of a specific priority (e.g., list[TaskPriority.High])
Add methods:
- AddTask(Task)
- MarkComplete(string taskTitle)
- ShowAll()
Demonstrate:
- Adding tasks
- Using the indexer to list tasks by priority
- Marking a task as complete and showing result
