using System;
using System.Collections.Generic;


var stop = false;

do
{
    Console.WriteLine("Give names of your friends:");
    string friends = Console.ReadLine();
    var friendsList = new List<string>();
    friendsList.AddRange(friends.Split(";"));

    var count = friendsList.Count;
    Console.WriteLine(count);
    switch (count)
    {
        case 0:
            Console.WriteLine("fgdf");
            stop = true;
            break;
        case 1:
            Console.WriteLine(friendsList.First<string>());
            break;
        case 2:
            Console.WriteLine(friendsList[0] + ", " + friendsList[1]);
            break;
        default:
            Console.WriteLine(
                friendsList[0] + ", " +
                friendsList[1] + ", " +
                friendsList.Last<string>()
            );
            break;
    }

} while (!stop);

