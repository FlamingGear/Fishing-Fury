using System;
using System.IO;

public class HighScoreSystem
{
    string path = "";
    int scoreCount = 0;
    string[] names;
    int[] scores;
        
    public HighScoreSystem(string filePath, int scoreNo)
    {
        path = filePath;
        scoreCount = scoreNo;

        names = new string[scoreCount];
        scores = new int[scoreCount];
    }

    public string[] GetScores()
    {
        string[] output = new string[scoreCount];

        for (int i = 0; i < scoreCount; i++)
        {
            output[i] = names[i] + ": " + scores[i];
        }

        return output;
    }

    public string GetScore(int scoreNo)
    {
        return names[scoreNo] + ": " + scores[scoreNo];
    }

    private void ReadScores()
    {
        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < scoreCount; i ++)
        {
            names[i] = lines[i * 2];
            scores[i] = Convert.ToInt32(lines[(i * 2) + 1]);
        }
    }

    private void AddScore(string name, int score)
    {
        for (int i = 0; i < scoreCount; i++)
        {
            if (scores[i] < score)
            {
                for (int j = scoreCount; j > i; j--)
                {
                    scores[j] = scores[j - 1];
                    names[j] = names[j - 1];
                }

                scores[i] = score;
                names[i] = name;
                break;
            }
        }

        SaveFile();
    }

    private void SaveFile()
    {
        string lines = "";

        //Create one large string to write to the file
        for (int i = 0; i < scoreCount; i++)
        {
            lines += names[i] + "\r" + scores[i] + "\r";
        }

        //Write the string to the file
        StreamWriter scoreFile = new StreamWriter(path);

        scoreFile.WriteLine(lines);
        scoreFile.Close();
    }
}

