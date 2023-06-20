internal class Program
{
    static int LinearSearchIndexOf(int[] arr, int element)
    {
        int index = 0;
        foreach (int i in arr)
        {
            if (i == element)
                break;
            index++;
        }

        return index;
    }

    static List<int> LinearSearchAllElement(int[] arr, int element)
    {
        var result = new List<int>();
        int index = 0;

        foreach (int i in arr)
        {
            if (i == element)
                result.Add(index);
            index++;
        }
        return result;
    }
    private static void Main(string[] args)
    {
        int element = 3;
        var array = new int[] { 1, 2, 5, 6, 3, 4 , 1, 2, 3, 1, 1, 3, 2, 5, 4};
        
        Console.WriteLine($"Index of first element of {element}: {LinearSearchIndexOf(array, element)}");

        Console.Write($"Indexes of {element}s:");

        foreach (int index in LinearSearchAllElement(array, element))
        {
            Console.Write($" {index}");
        }

    }
}