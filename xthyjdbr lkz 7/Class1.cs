
class Menu
{
    public int minstrel;
    public int maxstrel;

    public int Show()
    {


        int pos = 3;
        ConsoleKeyInfo key;

        key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter)
        {
             Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");
            
            {
                Console.SetCursorPosition(0, pos);
            }
            if (key.Key == ConsoleKey.UpArrow &&  pos != minstrel)
            {
                pos--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }
             else if (key.Key == ConsoleKey.Escape)
            {
                return -1;
            }

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("=>");
            key = Console.ReadKey();
        }

        return pos;


    }
}
