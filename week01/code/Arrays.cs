public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // Step 1: Create a new double array with size 'length' because we need that many multiples
        // Step 2: Use a for loop that goes from 1 to 'length' inclusive
        // Step 3: For each loop iteration i, calculate the multiple as number * i
        // Step 4: Store that result as index i-1 because arrays start at index 0
        // Step 5: After the loop finishes, return the filled array

        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // Step 1: If amount is 0 or equal to data.Count, the list stays the same so it can run
        // Step 2: To rotate right, we need to take the last 'amount' elements
        // Step 3: Remove those last 'amount' elements from the end of the list
        // Step 4: Insert those removed elements at the beginning of the list at index 0
        // Step 5: Because list is dynamic, modify 'data' directly and return nothing

        if (amount <= 0 || amount >= data.Count) return;

        // Step 2 and 3: Get the last 'amount' elements
        List<int> lastElements = data.GetRange(data.Count - amount, amount);

        // Remove them from end
        data.RemoveRange(data.Count - amount, amount);

        // Step 4: Insert them at the beginning
        data.InsertRange(0, lastElements);
    }
}
