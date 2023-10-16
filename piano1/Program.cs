Console.WriteLine("Piano");
static void beep(int hertz)
{
    Console.Beep(hertz, 90);
}
static int[] octaves(int octava)
{
    int[] firsttoctave = new int[]
    {
        450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000
    };
    int[] seconddoctave = new int[]
    {
        1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000, 2100, 2200
    };
    int[] thirddoctave = new int[] {
        2350, 2500, 2650, 2800, 2950, 3100, 3250, 3400, 3550, 3700, 3850, 4000
    };
    if (octava == 1)
    {
        return firsttoctave;
    }
    else if (octava == 2)
    {
        return seconddoctave;
    }
    else if (octava == 3)
    {
        return thirddoctave;
    }
    return firsttoctave;
}
ConsoleKeyInfo press;
int[] octave = octaves(1);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("                            /      How to work:      /");
Console.WriteLine("   / <<Q>> - 1 / <<W>> - 3 / <<E>> - 5 / <<R>> - 7  / <<T>> - 9  / <<Y>> - 11 /");
Console.WriteLine("  / <<A>> - 2 / <<S>> - 4 / <<D>> - 6 / <<F>> - 8  / <<G>> - 10 / <<H>> - 12 /");
Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("/   <<F5>> - 5 octave   /   <<F6>> - 6 octave    /    <<F7>> - 7 octave    /");
Console.WriteLine("                       /     Exit - <<Enter>>   /");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
do
{
    press = Console.ReadKey(true);
    switch (press.Key)
    {
        case ConsoleKey.F5:
            octave = octaves(1);
            break;
        case ConsoleKey.F6:
            octave = octaves(2);
            break;
        case ConsoleKey.F7:
            octave = octaves(3);
            break;
        case ConsoleKey.Q:
            beep(octave[0]);
            break;
        case ConsoleKey.A:
            beep(octave[1]);
            break;
        case ConsoleKey.W:
            beep(octave[2]);
            break;
        case ConsoleKey.S:
            beep(octave[3]);
            break;
        case ConsoleKey.E:
            beep(octave[4]);
            break;
        case ConsoleKey.D:
            beep(octave[5]);
            break;
        case ConsoleKey.R:
            beep(octave[6]);
            break;
        case ConsoleKey.F:
            beep(octave[7]);
            break;
        case ConsoleKey.T:
            beep(octave[8]);
            break;
        case ConsoleKey.G:
            beep(octave[9]);
            break;
        case ConsoleKey.Y:
            beep(octave[10]);
            break;
        case ConsoleKey.H:
            beep(octave[11]);
            break;
        case ConsoleKey.X:
            beep(octave[0]);
            beep(octave[1]);
            beep(octave[2]);
            beep(octave[3]);
            beep(octave[4]);
            beep(octave[5]);
            beep(octave[6]);
            beep(octave[7]);
            beep(octave[8]);
            beep(octave[9]);
            beep(octave[10]);
            beep(octave[11]);
            break;
    }
} while (press.Key != ConsoleKey.Enter);