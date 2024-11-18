namespace ConsoleApp1 {
    internal class Exam {
        public DateTime ExamDate { get; set; }
        public List<Questions> ExamQuestions { get; set; }

        public Exam(int exanMark = 0) {
            ExamQuestions = new();
            ExamDate = DateTime.Now;
        }
        public double CalcExamMark() {
            double examMark = 0;
            foreach (var Question in ExamQuestions) {
                examMark += Question.Mark;
            }
            return examMark;
        }
        //public int CalcExamTime() {
        //    int examTime = 3 * NumberOfQuestions;
        //    return examTime;
        //}
        public void AddQuestion(Questions questions) {
            ExamQuestions.Add(questions);
        }
    }
}

