/*
 * Keith Evans
 * Exercise 2 - Grade Console Application 
 * 2/4/2024
 * CSCI-1630
 * Dr. I
 * WEB-82771
 * 
 * This application converts an input grade percentage to a letter grade.
 * 
 */


// Prompt the user to input a grade.
Console.Write("Please input a grade: ");
int numberGrade = int.Parse(Console.ReadLine());


// Calculate teh letter grade from the provided percentage.
string letterGrade = "";
if (numberGrade >= 88) {
    letterGrade = "A";
}
else if (numberGrade >= 80 && numberGrade <= 87) {
    letterGrade = "B";

}
else if (numberGrade >= 68 && numberGrade <= 79) {
    letterGrade = "C";
}
else if (numberGrade >= 60 && numberGrade <= 67) {
    letterGrade = "D";
}
else {
    letterGrade = "F";
}




// Display the letter grade calculation result.
Console.WriteLine("============      ============");
Console.WriteLine("|Grade Point      Letter Grade|");
Console.WriteLine("============      ============");
Console.WriteLine("|{0, -17}{1, -12}|", numberGrade, letterGrade);
Console.WriteLine("==============================");