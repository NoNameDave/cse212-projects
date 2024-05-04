public static class Priority {
    public static void Test() {
        var pq = new PriorityQueue();
        pq.Enqueue("Task1", 5);
        pq.Enqueue("Task2", 1);
        pq.Enqueue("Task3", 3);
        pq.Enqueue("Task4", 5);

        // Test 1: Dequeue should return "Task1" first (first highest priority item)
        Console.WriteLine("Test 1: Dequeue High Priority");
        var item = pq.Dequeue();
        if (item == "Task1") {
            Console.WriteLine("Pass");
        } else {
            Console.WriteLine("Fail");
        }

        // Test 2: Next dequeue should return "Task4" (second item with same high priority)
        Console.WriteLine("Test 2: Dequeue Second High Priority");
        item = pq.Dequeue();
        if (item == "Task4") {
            Console.WriteLine("Pass");
        } else {
            Console.WriteLine("Fail");
        }

        // Test 3: Verify FIFO for different priorities
        Console.WriteLine("Test 3: Verify FIFO for Lower Priorities");
        item = pq.Dequeue();
        if (item == "Task3") {
            Console.WriteLine("Pass");
        } else {
            Console.WriteLine("Fail");
        }

        // Add more tests as needed
    }
}