public class YieldTest
{
    public IEnumerable<int> GetNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return i;
        }
    }

    public IEnumerable<int> GenerateEvenNumbers()
    {
        int number = 0;
        while (true)
        {
            yield return number;
            number += 2;
        }
    }
}