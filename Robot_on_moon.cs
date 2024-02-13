using System;
class Program
{
        const int Map_Dimensions = 100;
        const string NORTH = "NORTH";
        const string SOUTH = "SOUTH";
        const string EAST = "EAST";
        const string WEST = "WEST";
        static int x = 0, y = 0;
        static string direction = "";
    static void PlaceRobot()
    {
        Console.WriteLine("Stacy landed on the Moon Successfully.");
        Console.WriteLine();
        Console.Write("Please Enter the X coordinate: ");
        int xCoord = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Enter the Y coordinate: ");
        int yCoord = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the direction Stacy should be facing in (NORTH, SOUTH, EAST, WEST): ");
        string dir = Console.ReadLine().ToUpper();

        if (RangeSpecification(xCoord, yCoord, dir))
        {
            x = xCoord;
            y = yCoord;
            direction = dir;
        }
        else
        {
            Console.WriteLine("Invalid Co-ordinates or direction. STACY, the Robot, is not placed.");
            Console.WriteLine();
        }
    }
    static void Move()
    {
        switch (direction)
        {
            case NORTH:
                if (y < Map_Dimensions - 1) y++;
                break;
            case SOUTH:
                if (y > 0) y--;
                break;                
            case EAST:
                if (x < Map_Dimensions - 1) x++;
                break;
            case WEST:
                if (x > 0) x--;
                break;
        }
    }
    static void Left()
    {
        switch (direction)
        {
            case NORTH:
                direction = WEST;
                break;
            case SOUTH:
                direction = EAST;
                break;
            case EAST:
                direction = NORTH;
                break;
            case WEST:
                direction = SOUTH;
                break;
        }
    }
    static void Right()
    {
        switch (direction)
        {
            case NORTH:
                direction = EAST;
                break;
            case SOUTH:
                direction = WEST;
                break;                
            case EAST:
                direction = SOUTH;
                break;
            case WEST:
                direction = NORTH;
                break;
        }
    }
    enum moon_robot_activities
    {
        PLACE = 1,
        MOVE,
        LEFT,
        RIGHT,
        EXIT
    };
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Activities for STACY to perform on THE MOOOOOON!!!");
            Console.WriteLine("1. Land STACY on the Moon.");
            Console.WriteLine("2. Stacy should Move Forward");
            Console.WriteLine("3. Stacy should Turn Left");
            Console.WriteLine("4. Stacy should Turn Right.");
            Console.WriteLine("5. Let Stacy Rest.");
            Console.Write("Enter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch ((moon_robot_activities)choice)
            {
                case moon_robot_activities.PLACE:
                    PlaceRobot();
                    break;
                case moon_robot_activities.MOVE:
                    Move();
                    break;
                case moon_robot_activities.LEFT:
                    Left();
                    break;
                case moon_robot_activities.RIGHT:
                    Right();
                    break;
                case moon_robot_activities.EXIT:
                    Console.WriteLine("See You Again!!");
                    return;
            }
            Console.WriteLine($"The Current position of Stacy is ({x}, {y}), facing in the {direction} Direction.");
        }
    }
    static bool RangeSpecification(int xPosition, int yPosition, string facingDirection)
    {
        return xPosition >= 0 && xPosition < Map_Dimensions &&
               yPosition >= 0 && yPosition < Map_Dimensions &&
               (facingDirection == NORTH || facingDirection == EAST ||
                facingDirection == SOUTH || facingDirection == WEST);
    }
}
