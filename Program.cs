
using System.Collections.Generic;

static int[] Snail(int[][] array)
{
    List<int> result = new List<int>();

    int horizontal = 0;
    int currHorizontal = 0;
    int vertical = 0;
    int currVertical = 0;

    int count = 0;
    int length = array.Length * array[0].Length;

    if (length == 0)
    {
        return new int[] { };
    }

    while (count < length)
    {

        //right
        while (horizontal < array[0].Length - currHorizontal && count < length)
        {
            result.Add(array[vertical][horizontal]);

            horizontal++;
            count++;

        }       
       
        horizontal--;
        vertical++;
       
        //down
        while (vertical < array.Length - currVertical && count < length)
        {
            result.Add(array[vertical][horizontal]);

            vertical++;
            count++;
        }
        vertical--;
        horizontal--;


        //left
        while (horizontal >= 0 + currHorizontal && count < length)
        {
            result.Add(array[vertical][horizontal]);

            horizontal--;
            count++;
        }
        horizontal++;
        vertical--;

        currVertical++;

        // up
        while (vertical >= 0 + currVertical && count < length)
        {
            result.Add(array[vertical][horizontal]);

            vertical--;
            count++;

        }
        
        vertical++;
        horizontal++;

        currHorizontal++;

    }


    return result.ToArray();
}

int[][] array =
       {
    new[] { 1, 2, 3, 4,5 },
    new[] { 16, 17, 18,19,6 },
    new[] { 15, 24, 25,20,7 },
     new[] { 14, 23,22, 21,8 },
     new[] {13, 12, 11, 10, 9 }
       };



Console.WriteLine(String.Join(", ", Snail(array)));