using TreeCollection.TestModels.Enums;

namespace TreeCollection.TestModels.Models
{
    public class ExamResult : IComparable<ExamResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exams Exam { get; set; }
        public Score Score { get; set; }
        public DateTime Date { get; set; }

        public ExamResult(int id, string name, Exams exam, Score score, DateTime date)
        {
            Id = id;
            Name = name;
            Exam = exam;
            Score = score;
            Date = date;
        }

        public int CompareTo(ExamResult other)
        {
            /* variables to compare */
            int nameValue = this.Name.CompareTo(other.Name);
            int dateValue = this.Date.CompareTo(other.Date);
            int idValue = this.Id.CompareTo(other.Id);

            /* if names are equal, ask for date */
            if (nameValue == 0)
            {
                /* then, if dates values are equal, return id */
                if (dateValue == 0)
                {
                    return idValue;
                }
                /* if names are equal but dates are not, then return date value*/
                return dateValue;
            }
            /* if names are not equal, then return name value */
            return nameValue;
        }
    }
}
