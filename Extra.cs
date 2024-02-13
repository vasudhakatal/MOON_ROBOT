//         using System;

// class Program
// {
//     const int surfaceSize = 100;
//     const string NORTH = "NORTH";
//     const string EAST = "EAST";
//     const string SOUTH = "SOUTH";
//     const string WEST = "WEST";
//     static int x = 0, y = 0; 
//     static string direction = "";
//     enum moon_robot_activities
//     {
//         PLACE = 1,
//         LEFT,
//         RIGHT,
//         MOVE,
//         EXIT
//     };
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1. Place Robot");
//             Console.WriteLine("2. Turn Left");
//             Console.WriteLine("3. Turn Right");
//             Console.WriteLine("4. Move Forward");
//             Console.WriteLine("5. Exit");
//             Console.Write("Enter your choice (1-5): ");
//             int choice = Convert.ToInt32(Console.ReadLine());
//             switch ((moon_robot_activities)choice)
//             {
//                 case moon_robot_activities.PLACE:
//                     Console.Write("Enter X coordinate: ");
//                     int xCoord = Convert.ToInt32(Console.ReadLine());
//                     Console.Write("Enter Y coordinate: ");
//                     int yCoord = Convert.ToInt32(Console.ReadLine());
//                     Console.Write("Enter direction (NORTH, EAST, SOUTH, WEST): ");
//                     string dir = Console.ReadLine().ToUpper();
//                     void Place(int xPosition, int yPosition, string facingDirection)
//                     {
//                         if (xPosition >= 0 && xPosition < surfaceSize &&
//                             yPosition >= 0 && yPosition < surfaceSize &&
//                             (facingDirection == NORTH || facingDirection == EAST ||
//                             facingDirection == SOUTH || facingDirection == WEST))
//                         {
//                             x = xPosition;
//                             y = yPosition;
//                             direction = facingDirection;
//                         }
//                     };
//                     break;
//                 case moon_robot_activities.MOVE:
//                     void Move()
//                     {
//                         switch (direction)
//                         {
//                             case NORTH:
//                                 if (y < surfaceSize - 1) y++;
//                                 break;
//                             case EAST:
//                                 if (x < surfaceSize - 1) x++;
//                                 break;
//                             case SOUTH:
//                                 if (y > 0) y--;
//                                 break;
//                             case WEST:
//                                 if (x > 0) x--;
//                                 break;
//                         }
//                     };
//                     break;
//                 case moon_robot_activities.LEFT:
//                     void Left()
//                     {
//                         switch (direction)
//                         {
//                             case NORTH:
//                                 direction = WEST;
//                                 break;
//                             case EAST:
//                                 direction = NORTH;
//                                 break;
//                             case SOUTH:
//                                 direction = EAST;
//                                 break;
//                             case WEST:
//                                 direction = SOUTH;
//                                 break;
//                         }
//                     };
//                     break;
//                 case moon_robot_activities.RIGHT:
//                     void Right()
//                     {
//                         switch (direction)
//                         {
//                             case NORTH:
//                                 direction = EAST;
//                                 break;
//                             case EAST:
//                                 direction = SOUTH;
//                                 break;
//                             case SOUTH:
//                                 direction = WEST;
//                                 break;
//                             case WEST:
//                                 direction = NORTH;
//                                 break;
//                         }
//                     };
//                     break;
//                 case moon_robot_activities.EXIT:
//                     Console.WriteLine("Exiting the program. Goodbye!");
//                     return;
//             }Console.WriteLine($"Current position: ({x}, {y}), facing {direction}");
//         }
//     }
// }
//         // Console.WriteLine("Do you want to place the robot? (yes/no)");
//         // string response = Console.ReadLine();
//         // if (response.ToLower() == "yes")
//         // {
//         //     Console.WriteLine("Enter X coordinate:");
//         //     int xCoord = Convert.ToInt32((Console.ReadLine()));
//         //     Console.WriteLine("Enter Y coordinate:");
//         //     int yCoord = Convert.ToInt32((Console.ReadLine()));
//         //     Console.WriteLine("Enter direction (NORTH/EAST/SOUTH/WEST):");
//         //     string dir = Console.ReadLine().ToUpper();
//         //     Place(xCoord, yCoord, dir);
//         // }
//         // Console.WriteLine("Do you want to move the robot? (yes/no)");
//         // response = Console.ReadLine();
//         // if (response.ToLower() == "yes")
//         // {
//         //     Console.WriteLine("Do you want to move left or right? (left/right)");
//         //     string moveDirection = Console.ReadLine().ToLower();
//         //     if (moveDirection == "left")
//         //     {
//         //         Left();
//         //     }
//         //     else if (moveDirection == "right")
//         //     {
//         //         Right();
//         //     }
//         //     else
//         //     {
//         //         Console.WriteLine("Invalid move direction");
//         //     }
//         // }
//         // Console.WriteLine($"Current position: ({x}, {y}), facing {direction}");