int[] marksOfStudent1= { 10, 11, 8, 7, 9 };
int[] marksOfStudent2 = { 5, 7, 6, 7, 8 };
int[] marksOfStudent3 = { 11, 10, 10, 12, 9 };
int[] marksOfStudent4 = { 8, 9, 7, 6, 6 };


int[] MaxMarkPerStudent = {FindHighestMark(marksOfStudent1), FindHighestMark(marksOfStudent2), FindHighestMark(marksOfStudent3), FindHighestMark(marksOfStudent4) };
for (int i=0;i< 4; i++)
{
 Console.WriteLine($"This is max mark for student#{i+1}: {MaxMarkPerStudent[i]}");
}
int[] MinMarkPerStudent = {FindLowestMark(marksOfStudent1), FindLowestMark(marksOfStudent2), FindLowestMark(marksOfStudent3), FindLowestMark(marksOfStudent4) };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"This is mix mark for student#{i + 1}: {MinMarkPerStudent[i]}");
}
int[] AverageMarkPerStudent = {FindAverageMark(marksOfStudent1), FindAverageMark(marksOfStudent2), FindAverageMark(marksOfStudent3), FindAverageMark(marksOfStudent4) };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"This is average mark for student#{i + 1}: {AverageMarkPerStudent[i]}");
}


int maxAverageMakr= FindHighestMark(AverageMarkPerStudent);

for (int i = 0; i < AverageMarkPerStudent.Length; i++)
{
    if (AverageMarkPerStudent[i] == maxAverageMakr)
    {
        Console.WriteLine($"The student with the highest average mark is student#{i + 1}");
    }
}



int FindHighestMark (int[] marks)
{
    int max = 0;

    for (int i = 0; i < marks.Length; i++)
    {
        if (marks[i] > max) 
        {
        max = marks[i];
      
        }
    }
    return max;
  
}

int FindLowestMark(int[] marks)
{
    int min = 100;
    for (int i = 0; i < marks.Length; i++)
    {
        if (marks[i] < min)
        {
            min = marks[i];
        }
    }
    return min;
}

int FindAverageMark(int[] marks)
{
    int average = ((marks[0] + marks[1] + marks[2] + marks[3] + marks[4])/5);
    return average;
}