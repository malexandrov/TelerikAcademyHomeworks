using System;

public class CSharpExam : Exam
{
    private int score;

    public int Score 
    {
        get { return this.score; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Exam score must be a positive number!");
            }
            this.score = value;
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (score < 0 || score > 100)
        {
            throw new ArgumentOutOfRangeException("Exam score must be between 0 and 100!");
        }
        else
        {
            return new ExamResult(this.score, 0, 100, "Exam results calculated by score.");
        }
    }
}
