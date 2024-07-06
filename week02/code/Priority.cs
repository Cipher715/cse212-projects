public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following value and turns: Apple(1), Banana(5), Kiwi(4), Lemon(3).
        // Dequeue a single data.
        // Expected Result: Banana
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("Banana", 4);
        priorityQueue.Enqueue("Kiwi", 4);
        priorityQueue.Enqueue("Lemon", 3);
        Console.WriteLine(priorityQueue);

        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Kiwi is displayed instead of Banana.
        // The comparison condition is set to replace the index when the priority is "more than or equal to".

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with no data.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        Console.WriteLine(priorityQueue.Dequeue());


        // Defect(s) Found: None.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

    }
}