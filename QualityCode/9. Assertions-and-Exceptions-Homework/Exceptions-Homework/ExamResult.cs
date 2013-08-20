using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get 
        { 
            return grade; 
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be a positive number!");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get 
        { 
            return minGrade; 
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Minimal grade must be a positive number!");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get 
        { 
            return maxGrade; 
        }
        private set
        {
            if (value <= minGrade)
            {
                throw new ArgumentOutOfRangeException("Maximal grade must be bigger than minimal grade!");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get 
        { 
            return comments; 
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Commnent cannot be null or empty string!");
            }

            this.comments = value;
        }
    }
}
