﻿//Programmer: Brian Lee
//Date: 06/03/2024

//Title: CSI 120 Lecuture 12 Notes
//-------------------------------------------------------------------------------

using System.Text.RegularExpressions;

//----------------------------------------------------------------------------

namespace CSI_120_Lecture_12_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PreloadExercise();
            DisplayExercise();
        }

        static int sizeOfExerciseList = 5;
        static string[] nameOfExercise = new string[sizeOfExerciseList];
        static int[] numberOfRep = new int[sizeOfExerciseList];
        static double[] weights = new double[sizeOfExerciseList];
        static ExerciseList[] exercises = new ExerciseList[sizeOfExerciseList];

        public static void EnterValue(int index, string name, int rep, double weight)
        {
            nameOfExercise[index] = name;
            numberOfRep[index] = rep;
            weights[index] = weight;
        }

        public static void PreloadExercise()
        {
            EnterValue(0, "Bench Press", 10, 135);
            EnterValue(1, "Squats", 12, 185);
            EnterValue(2, "Dead Lift", 8, 225);
            EnterValue(3, "Overhead Press", 10, 95);
            EnterValue(4, "Bent Over Row", 12, 115);

            for (int i = 0; i < sizeOfExerciseList; i++)
            {
                exercises[i] = new ExerciseList(nameOfExercise[i], numberOfRep[i], weights[i]);
            }
        }

        public static void DisplayExercise()
        {
            Console.WriteLine("Name Of Exercises - Reps - Weight");
            for (int i = 0; i < exercises.Length; i++)
            {
                Console.WriteLine(exercises[i].ExerciseDisplayFormat());
            }
        }
    }

    public class ExerciseList
    {
        public string Name { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public ExerciseList(string name, int reps, double weight)
        {
            Name = name;
            Reps = reps;
            Weight = weight;
        }

        public ExerciseList()
        {
            Name = "No Exercise";
            Reps = -1;
            Weight = -1;
        }

        public string ExerciseDisplayFormat()
        {
            return $"{Name} - {Reps} - {Weight}";
        }
    }
}