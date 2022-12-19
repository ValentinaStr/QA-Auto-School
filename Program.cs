// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
int [] marks = { 1, 2, 10, 10, 10, 9, 4, 1, 10, 10 };
int summarks = 0;
int minmark = marks[0];
int maxmark = marks[0];

foreach(int mark  in marks) //find the GPA
{ 
        summarks += mark;
}
float gpa = (float)summarks / marks.Length; 
Console.WriteLine(gpa);

foreach(int mark in marks) //find the minimum value
{ 
    if (mark <  minmark) minmark = mark; 
}
Console.WriteLine(minmark);

foreach(int mark in marks)//find the minimum value
{
    if(mark > maxmark) maxmark = mark; 
}
Console.WriteLine(maxmark);

// try method
static void MinimumValue (int[] mark, out int resalt, int minmark = 10)
{  // find the mainimum value
    foreach (int m in mark)
    {
        if (m < minmark) minmark = m; 
    }
     resalt = minmark;
}
int maximummark;
MinimumValue(marks, out maximummark);
Console.WriteLine(maximummark);