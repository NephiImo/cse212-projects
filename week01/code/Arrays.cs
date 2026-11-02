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
        // Step 1: Create an array that can hold 'length' doubles.
        // Step 2: Loop through every index of the array.
        // Step 3: Calculate each multiple using the index.
        // Step 4: Return the completed array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // Step 1: Calculate the index of the first element that will be moved to the beginning
        int startIndex = data.Count - amount;

        // Step 2: Create a temporary list to hold the elements that will be moved
        List<int> temp = new List<int>();

        // Step 3: Add the elements that will be moved to the temporary list
        for (int i = startIndex; i < data.Count; i++)
        {
            temp.Add(data[i]);
        }

        // Step 4: Remove the elements that were added to the temporary list from the original list
        for (int i = 0; i < amount; i++)
        {
            data.RemoveAt(startIndex);
        }

        // Step 5: Add the elements from the temporary list to the beginning of the original list
        for (int i = temp.Count - 1; i >= 0; i--)
        {
            data.Insert(0, temp[i]);
        }
    }
}
