using CSharp_Challenge_ImaginaryCodingInterview.classes;
// See https://aka.ms/new-console-template for more information
/*
 * Based on the edabit coding challenge found here: https://edabit.com/challenge/dZeNE4BJhyNgA99Fq
 */

Interview interviewee = new Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120); //Expected Output true
Interview interviewee2 = new Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64); //Expected Output true
Interview interviewee3 = new Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120); //Expected Output false | Exceeded the time limit for a medium question
Interview interviewee4 = new Interview(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120); //Expected Output false | Did not complete all the questions
Interview interviewee5 = new Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130); //Expected Output false | Solved all the questions in their respected time limits but exceeded the total time limit of the interview
