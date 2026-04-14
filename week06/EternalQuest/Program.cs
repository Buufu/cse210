using System;

// Eternal Quest Program
// CREATIVITY FEATURE: Level System
// The program includes a level system that increases based on user points.
// For every 500 points earned, the user advances to the next level.
// This adds gamification and long-term goals beyond individual goal completion.
// As users accumulate points, they progress through levels, which provides
// motivation and a sense of progression throughout their goal-setting journey.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}