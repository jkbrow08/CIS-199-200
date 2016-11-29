//Name:    Jeremy Brown
//Date:    9/23/2011
//Class:   CIS 199-01
//Purpose: The purpose of this program is to calculate the number of gallons needed by the
//         user to paint their needed room.  This is done by gathering the required inputs from the user,
//         calculating the needed output, and then displaying the required output for the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double paintLength;  //This is the variable needed to hold the total length of the room in ft.
            Double paintHeight;  //This is the variable needed to hold the total height of the room in ft.
            Double sumPaint;  //This is the variable needed to hold the total length of the room * the total height in ft.
            UInt16 roomDoors;  //This is the variable needed to hold the total number of doors in the room.
            UInt16 roomWindows;  //This is the variable needed to hold the total number of windows for the room.
            UInt16 numCoats;  //This is the variable needed to hold the total number of coats that the user wishes to paint the room.
            const UInt16 DOORS = 15;  //This is the constant value in feet for every door needed for the sumPaint calculation.
            const UInt16 WINDOWS = 20;  //This is the constant value in feet for every window needed for the sumPaint calculation.
            const UInt16 SQUAREFEETPERGALLON = 350;  //This is the constant value in feet for how much every gallon of paint can cover.

            Console.Write("Please enter the total length of the room ");//Asks the user to input the total length of the room.
            paintLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the height of the room ");//Asks the user to input the total height of the room.
            paintHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the number of doors in the room ");//Asks the user to input the total number of doors inside the room about to be painted.
            roomDoors = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Please enter the number of windows in the room ");//Asks the user to input the total number of windows inside the room about to be painted.
            roomWindows = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Please enter the number of coats needed to paint over the previous color ");//Asks the user to input the total number of coats needed to paint the room  Ex:1 to paint over a light color, 3 to paint over a dark.
            numCoats = Convert.ToUInt16(Console.ReadLine());


            sumPaint = paintLength * paintHeight;  //Performs the various calculations to reach the desired output.
            sumPaint = sumPaint - (roomDoors * DOORS) - (roomWindows * WINDOWS);
            sumPaint = sumPaint / SQUAREFEETPERGALLON;
            sumPaint = sumPaint * numCoats;


            Console.WriteLine(" ");  //Performs output of calculations, Line 47 is a blank line to seperate output from the user inputs.
            Console.WriteLine("The number of gallons needed to paint the room is {0}", sumPaint.ToString("F1"));



        }
    }
}
