// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

static float GetAverage(int[] marks) 
{
    int summarks = 0;  
    foreach (int mark in marks) 
    {
        summarks += mark;
    }
    float gpa = (float)summarks / marks.Length;
    return gpa;
}
static int GetMaximumValue(int[] marks) 
{
    int maxmark = marks[0];
    for (int i = 1; i < marks.Length; i++ )
        if (marks[i] > maxmark) maxmark = marks[i];
    return maxmark;
}

static int GetMinimumValue (int[] marks)
{
    int minmark = marks[0];
    for (int i = 1; i < marks.Length; i++)
        if (marks[i] < minmark) minmark = marks[i];
    return minmark;
}

static void AllValue(int[] marks)
{
    Console.WriteLine($" Average mark is {GetAverage(marks)}"); 
    Console.WriteLine($" Maximum mark is {GetMaximumValue(marks)}");
    Console.WriteLine($" Mimimum mark is {GetMinimumValue(marks)} \n");
   
  
}

int[] people1 = { 10, 10, 0, 10, 6, 8, 8, 3, 2, 4 };
int[] people2 = { 10, 9, 8, 6, 5, 4, 3, 6, 5, 4, };
int[] people3 = { 10, 6, 7, 5, 10, 5, 6, 7, 5, 4, };
int[] people4 = { 9, 8, 6, 7, 5, 4, 1, 2, 3, 4, };
int[] people5 = { 9, 7, 6, 8, 2, 7, 6, 4, 10, 5 };

AllValue(people1);
AllValue(people2);
AllValue(people3);
AllValue(people4);
AllValue(people5);