﻿using UC7.Models;

namespace UC7.Services
{
    public class PlayerAnalyzer
    {
        public double CalculateScore(List<Player> players)
        {
            double score = 0;

            foreach (var player in players)
            {
                double skillsAverage = player.Skills.Sum() / (double)player.Skills.Count;
                double contribution = player.Age * player.Experience * skillsAverage;

                if (player.Age < 18)
                {
                    contribution *= 0.5;
                }

                if (player.Experience > 10)
                {
                    contribution *= 1.2;
                }

                score += contribution;
            }

            return score;
        }
    }

}
