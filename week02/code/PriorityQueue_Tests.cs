using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities and dequeue all
    // Expected Result: Items come out highest priority first: High, Medium, Low
    // Defect(s) Found: None after fix. Before fix: Loop used Count-1 so last item was never checked, and item was not removed 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 10);
        priorityQueue.Enqueue("Medium", 20);
        priorityQueue.Enqueue("High", 30);
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with the same priority
    // Expected Result: Items with same priority come out in FIFO order: First, then Second
    // Defect(s) Found: None after fix. Before fix: Order was reversed for same priority 

    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue
    // Expected Result: Should throw InvalidOperationException
    // Defect(s) Found: None after fix. Before fix: Threw ArgumentOutOfRangeException

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}