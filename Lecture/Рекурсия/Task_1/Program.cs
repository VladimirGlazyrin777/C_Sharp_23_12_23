void OpenMatryoshka(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Smallest!");
        return;
    }
     OpenMatryoshka(size - 1);
    Console.WriteLine($"Opening matryoshka of size {size}...");
}
 OpenMatryoshka(5);
