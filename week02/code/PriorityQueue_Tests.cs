using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities
    // and dequeue one item.
    // Expected Result: The item with the highest priority
    // should be returned.
    // Defect(s) Found: The queue returned "Medium" (priority 3)
    // instead of "High" (priority 5). The highest-priority item 
    // was not selected correctly.  
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add two items with the same priority 
    // and dequeue one item.
    // Expected Result: The first item added should be 
    // returned because equal priorities follow FIFO order.
    // Defect(s) Found: The queue returned Bob instead of Alice,
    // even though Alice was added first. Items with equal 
    // prioeirities are not following FIFO order. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 5);

        Assert.AreEqual("Alice", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add two items, dequeue the highest-priority
    // item, then dequeue again.
    // Expected Result: The first dequeue returns "High".
    // The second dequeue returns "Low" because "High" was removed.
    // Defect(s) Found: The first dequeue correctly returns "High",
    // but the second dequeue returned "High" again instead of "Low".
    // The selected item is not being removed from the queue.
    public void TestPriorityQueue_RemovesItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty priority queue.
    // Expected Result: An InvalidOperationException is thrown
    // with the message "The queue is empty."
    // Defect(s) Found: None. The test passed successfully. 
    // The queue throws the expected InvalidOperationException
    // with the correct message when empty.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}