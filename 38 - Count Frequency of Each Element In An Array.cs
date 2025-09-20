using System;

class FrequencyCount
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 2, 4, 3, 3 };
        int n = arr.Length;

        // Boolean array to mark visited elements
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            // If element is already counted, skip it
            if (visited[i])
                continue;

            int count = 1; // Count the current element

            // Compare with remaining elements
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true; // Mark as visited
                }
            }

            // Print frequency of current element
            Console.WriteLine($"{arr[i]} : {count} times");
        }
    }
}
