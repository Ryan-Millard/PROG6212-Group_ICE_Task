using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var eventManager = new EventManager();

        // Start tasks to notify students and update event statuses concurrently
        Task notifyTask = Task.Run(() => eventManager.NotifyStudents());
        Task updateStatusTask = Task.Run(() => eventManager.UpdateEventStatuses());

        // Wait for all tasks to complete
        Task.WaitAll(notifyTask, updateStatusTask);

        Console.WriteLine("All tasks completed.");
    }
}

class EventManager
{
    private readonly ConcurrentQueue<string> _studentsToNotify = new ConcurrentQueue<string>();
    private readonly List<Event> _events = new List<Event>();
    private readonly object _eventStatusLock = new object();

    public EventManager()
    {
        // Populate students to notify
        _studentsToNotify.Enqueue("student1@example.com");
        _studentsToNotify.Enqueue("student2@example.com");

        // Initialize events
        _events.Add(new Event { Id = 1, Name = "Event 1", Status = "Pending" });
        _events.Add(new Event { Id = 2, Name = "Event 2", Status = "Pending" });
    }

    public void NotifyStudents()
    {
        while (_studentsToNotify.TryDequeue(out string studentEmail))
        {
            // Simulate notifying the student
            Console.WriteLine($"Notifying {studentEmail}");
            Thread.Sleep(1000); // Simulate time delay in notification
        }
    }

    public void UpdateEventStatuses()
    {
        foreach (var ev in _events)
        {
            lock (_eventStatusLock)
            {
                // Simulate updating event status
                ev.Status = "Completed";
                Console.WriteLine($"Updated event {ev.Name} to status {ev.Status}");
                Thread.Sleep(1000); // Simulate time delay in updating status
            }
        }
    }
}

class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
}
