public static class Program
{
    private string UserInput { get; set; } = string.Empty;

    public static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Before starting the bot, make sure you have Bullet Echo open on Bluestacks and game mode set to King of the Hill.");
        Console.WriteLine("");
        Console.WriteLine(
            "Also make sure to change the speed, attack_range and HeightScaleFactor for you selected brawler at constants.py (instruction there as well).");
        Console.WriteLine("To exit bot hover cursor to the top left or bottom right corner.");
        Console.WriteLine("");
        Console.WriteLine("IMPORTANT - make sure to disable ads on bluestack and close the right sidebar");

        while True
        {
            Console.WriteLine("");
            Console.WriteLine("1. Start Bot");
            Console.WriteLine("2. Set shutdown timer");
            Console.WriteLine("3. Cancel shutdown timer");
            Console.WriteLine("4. Exit");
            Console.Write("Selection: ");
            UserInput = Console.ReadLine().ToLower();

            switch (UserInput)
            {
                case "1":
                case "start bot":
                    main();
                    break;
                case "2":
                case "set shutdown timer":
                    Console.WriteLine("Set Shutdown Timer");
                    Console.WriteLine("How many hour before shutdown? ");
                    int hour = Console.ReadLine();
                    int second = 3600 * hour;
                    os.system(f'cmd /c "shutdown -s -t {second}"');
                    Console.WriteLine("Shuting down in {hour} hour");
                    ShutdownTimer = new ShutdownTimer()
                    break;
                case "3":
                case "cancel shutdown timer":
                    os.system('cmd /c "shutdown -a"')
                    print("Shutdown timer cancelled")
                    break;
                case "4":
                case "exit":
                    print("Exitting...")
                    break
                default:
                    break;
            }
        }
    }
}