﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Model
{
    internal class SnakeGameFileManager
    {
        #region Fields
        private string ScoreFileName { get; set; }
        #endregion

        #region Constructors
        public SnakeGameFileManager()
        {
            ScoreFileName = "ScoreCounterLog";
        }
        #endregion

        #region Methods
        public void SaveScoreToFile(ScoreCounter newScore)
        {
            using StreamWriter writer = new StreamWriter(File.Open(ScoreFileName, FileMode.OpenOrCreate));
            {
                writer.WriteLine(newScore.Score);
            }
        }

        public List<int> GetScoresFromFile()
        {
            List<int> scores = new List<int>();
            using (StreamReader reader = new StreamReader(File.Open(ScoreFileName, FileMode.Open)))
            {
                while (!reader.EndOfStream)
                {
                    scores.Add(int.Parse(reader.ReadLine()));
                }
            }
            return scores;
        }

        #endregion
    }
}