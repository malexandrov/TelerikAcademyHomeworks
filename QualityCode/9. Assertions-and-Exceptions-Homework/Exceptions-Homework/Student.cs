using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string firstName;
    public string lastName;
    public IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.exams = exams;
    }

    public string FirstName
    {
        get 
        { 
            return this.firstName; 
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("First name cannot be null or empty string!");
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get 
        { 
            return this.lastName; 
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Last name cannot be null or empty string!");
            }
            lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get 
        { 
            return this.exams; 
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Exam list can't be null!");
            }
            if (value.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Exam list must have at least one exam!");
            }

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.exams.Count; i++)
        {
            results.Add(this.exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
