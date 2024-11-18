namespace ConsoleApp1 {
    internal class TakeQuestions {
        public static string Header { get; set; }
        public static string Body { get; set; }
        public static string Answer { get; set; }
        public static double Mark { get; set; }
        public static int ExamMark{ get; set; }
        public static string QuestionLevel { get; set; }
        public static Exam exam = new();   
        public static void ToF() {
            SetProps();
            TrueOrFalseQuestion trueOrFalseQuestion = new(Header, Body, Answer, Mark, QuestionLevel);
            exam.AddQuestion(trueOrFalseQuestion);
        }
        public static void Choise() {
            SetProps();
            List<string> choices = new();
            for (int i = 0; i < 4; i++) {
                Console.WriteLine($"Enter the {i + 1} choice");
                string choise = Console.ReadLine();
                choices.Add(choise);
            }
            ChoiseQuestion choiseQuestion = new(Header, Body, Answer, Mark, QuestionLevel, choices);
            exam.AddQuestion(choiseQuestion);
        }
        public static void Essey() {
            SetProps();
            EsseyQuestion esseyQuestion = new(Header, Body, Answer, Mark, QuestionLevel);
            exam.AddQuestion(esseyQuestion);
        }
        public static void SetProps() {
            Console.WriteLine("Header");
            Header = Console.ReadLine();
            Console.WriteLine("Body");
            Body = Console.ReadLine();
            Console.WriteLine("Answer");
            Answer = Console.ReadLine();
            Console.WriteLine("Mark");
            Mark = double.Parse(Console.ReadLine());
            Console.WriteLine("Level");
            QuestionLevel = Console.ReadLine();
        }
    }
}
