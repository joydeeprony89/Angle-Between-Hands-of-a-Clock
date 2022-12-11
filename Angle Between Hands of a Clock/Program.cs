// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Solution s = new Solution();
var asnwer = s.AngleClock(12, 30);

public class Solution
{
  public double AngleClock(int hour, int minutes)
  {
    /*
    in 12 hours hour hand completes 360 degree
    in 1 hour it completes = 360/12 = 30 degree

    in 60 minutes minutes hand completes 360 degrees
    in 1 minutes  = 360 / 60 = 6 degrees

    in for given hour+minutes it will complete total hour's degree ?
    (hour % 12) * 30 and if given minute is greater than 0 then it hour hand additionally complete 
    (minutes / 60) * 30 degrees
    so hour = (hour % 12) * 30 + (minutes / 60) * 30
    minutes = (minutes * 6) 
    */


    double h = (double)((hour % 12) * 30) + (((double)minutes / 60) * 30);
    double m = (double)minutes * 6;
    double angle = Math.Abs(m - h);
    if (angle > 180) angle = 360 - angle;
    return angle;
  }
}