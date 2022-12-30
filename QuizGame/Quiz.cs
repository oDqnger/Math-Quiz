using System;
using System.Collections.Generic;
using System.Linq;

public class Quiz {
     static bool isReady = false;
     static int question = 0;

     static int questionCorrect = 0;
     static void Beginning() {
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("Hi! Welcome to the math quiz!");
          Thread.Sleep(2000);
          Console.WriteLine("Before we begin, we need to give you some information on what we're dealing here.");
          Thread.Sleep(2000);
          Console.WriteLine("There are 3 difficulties: easy, medium and hard.");
          Thread.Sleep(2000);
          Console.WriteLine("After a set of questions (5 - 10), you move on to the next difficulty.");
          Thread.Sleep(2000);
          Console.WriteLine("The easy difficulty will include the basics of the basics like adding, substracting etc.... The stuff you learn in elementary school");
          Thread.Sleep(2000);
          Console.WriteLine("The medium difficulty will include stuff like fractions, decimal numbers, inequalities and so on");
          Thread.Sleep(2000);
          Console.WriteLine("The hard difficulty will include both but with a TIMER");
          Thread.Sleep(2000);
          Console.WriteLine("There is a win condition in this quiz and so to win this, you must get ATLEAST more than 25+ questions correct. pretty hard eh");
          Thread.Sleep(3500);

          Console.WriteLine("Are you ready to begin? (y/n)");
          string input = Console.ReadLine();

          if (input.ToLower() == "y") {
               isReady = true;
          } else {
               isReady = false;
               System.Environment.Exit(1);
          }
     }

     static void EasyWave() {
          Random random = new Random();
          string operatorX;
          int num1;
          int num2;
          string ans;

          for (int x = 0; x<5; x++) {
               switch(random.Next(1,4)) {
                    case 1:
                         operatorX = "+";
                         break;
                    case 2:
                         operatorX = "-";
                         break;
                    case 3:
                         operatorX = "X";
                         break;
                    case 4:
                         operatorX = "/";
                         break;
                    default: 
                         operatorX = "invalid";
                         break;
               }
               num1 = operatorX == "+" || operatorX == "-" ? random.Next(1, 100) : random.Next(1,10);
               num2 = operatorX == "+" || operatorX == "-" ? random.Next(1, 100) : random.Next(1,10);
               Console.WriteLine($"Question {question + 1}: What is {num1} {operatorX} {num2}");
               question++;
               ans = Console.ReadLine();
               if (ans == (num1 + num2).ToString() && operatorX == "+" || ans == (num1 - num2).ToString() && operatorX == "-") {
                    questionCorrect++;
               } else if (ans == (num1 * num2).ToString() && operatorX == "X" || ans == (num1 / num2).ToString() && operatorX == "/") {
                    questionCorrect++;
               }
          }

          Console.WriteLine($"You got {questionCorrect}/5!");
     }

     static void MediumWave() {
          Random randomNum = new Random();
          int num1;
          int num2;
          string sign;
          int tempAns = 0;
          for (int x = 0; x<9; x++) {
               switch(randomNum.Next(1,4)) {
                    case 1:
                         num1 = randomNum.Next(1, 400);
                         num2 = randomNum.Next(1,400);
                         Console.WriteLine($"Question {question + 1}: What best satisfies this condition: {num1} ___ {num2}");

                         sign = Console.ReadLine();

                         if (sign == ">") {
                              if (num1 > num2) {
                                   tempAns++;
                              }
                         } else if (sign == "<") {
                              if (num1 < num2) {
                                   tempAns++;
                              }
                         }

                         question++;
                         break;
                    case 2:
                         num1 = randomNum.Next(1,1000);
                         num2 = randomNum.Next(1,1000);
                         Console.WriteLine($"Question {question + 1}: What is the answer of: {num1} + {num2}? ");

                         if (Console.ReadLine() == (num1 + num2).ToString()) {
                              tempAns++;
                         }

                         question++;
                         break;
                    case 3:
                         num1 = randomNum.Next(1,100);
                         Console.WriteLine($"Question {question + 1}: What is the square root of {num1}? (you may need to round down)");

                         if (Console.ReadLine() == MathF.Floor(MathF.Sqrt(num1)).ToString()) {
                              tempAns++;
                         }
                         break;
               }
          }
          
          Console.WriteLine($"You got {tempAns}/10!");
          questionCorrect += tempAns;
     }

     static void HardWave() {
          Random randomNum = new Random();
          int num1;
          int num2;
          string sign;
          int tempAns = 0;
          for (int x = 0; x<15; x++) {
               switch(randomNum.Next(1,4)) {
                    case 1:
                         num1 = randomNum.Next(1, 634921);
                         num2 = randomNum.Next(1,53101);
                         Console.WriteLine($"Question {question + 1}: What best satisfies this condition: {num1} ___ {num2}");

                         sign = Console.ReadLine();

                         if (sign == ">") {
                              if (num1 > num2) {
                                   tempAns++;
                              }
                         } else if (sign == "<") {
                              if (num1 < num2) {
                                   tempAns++;
                              }
                         }

                         question++;
                         break;
                    case 2:
                         num1 = randomNum.Next(1,1000);
                         num2 = randomNum.Next(1,2000);
                         Console.WriteLine($"Question {question + 1}: What is the answer of: {num1} X {num2}? ");

                         if (Console.ReadLine() == (num1 * num2).ToString()) {
                              tempAns++;
                         }

                         question++;
                         break;
                    case 3:
                         num1 = randomNum.Next(100,10000);
                         Console.WriteLine($"Question {question + 1}: What is the square root of {num1}");

                         if (Console.ReadLine() == Math.Sqrt(num1).ToString()) {
                              tempAns++;
                              Console.WriteLine("correct!");
                         }
                         break;
                         
               }
          }
          
          Console.WriteLine($"You got {tempAns}/15!");
          questionCorrect += tempAns;
     }
     

     static void EndOff() {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("Congratulations! You have officialy completed this quiz, now it's time for the totally marks. If you win, I will give you my biggest DARKEST secret, if not, you'll be my");
          Thread.Sleep(1500);
          Console.ForegroundColor = ConsoleColor.DarkGray;
          Console.WriteLine("The total marks for this quiz is....");
          Thread.Sleep(3000);
          if (questionCorrect >= 25) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("uhhh");
               Thread.Sleep(1800);
               Console.WriteLine("ehm sorry about that uhh my program uh one mintue pls");
               Thread.Sleep(1500);
               Console.WriteLine("ok the total marks iiissss");
               Thread.Sleep(2500);
               Console.WriteLine($"{questionCorrect} marks!!!! Well done, you won!");
          } else {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine($"uhh. ehm ehm EHM ");
               Thread.Sleep(1500);
               Console.WriteLine($"it was ok uhm the marks are {questionCorrect}. Not well done");
          }
     }
     static void Main(string[] args) {
          Beginning();
          while(isReady) {
               Console.ForegroundColor = ConsoleColor.Green;
               EasyWave();
               Thread.Sleep(1500);
               Console.WriteLine("Congratulations! You got past the first stage of the quiz, but get ready to embrace the medium diffculty wave!");
               Console.ForegroundColor = ConsoleColor.DarkBlue;
               MediumWave();
               
               Thread.Sleep(1500);
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Well done! You're now in the last stage of the quiz. Do not fail this. Good luck.");
               HardWave();
               Thread.Sleep(1500);
               EndOff();
               Thread.Sleep(2500);
               Console.WriteLine("Would you like to try again? (y/n): ");

               if(Console.ReadLine().ToLower() == "n") {
                    Console.WriteLine("Thanks for playing! Have a nice day!");
                    isReady = false;
                    System.Environment.Exit(1);
                    break;
               } else {
                    isReady = true;
                    question = 0;
                    questionCorrect = 0;
               }  
          }
            
     }
}