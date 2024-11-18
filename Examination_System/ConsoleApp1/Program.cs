namespace ConsoleApp1 {
    internal class Program {
        static void Display() {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Enter Your Question Type");
            Console.WriteLine("1. True or False");
            Console.WriteLine("2. Multiple Choises");
            Console.WriteLine("3. Essay");
            char choise = char.Parse(Console.ReadLine());
            do {
                switch (choise) {
                    case '1':
                        TakeQuestions.ToF();
                        Mode();
                        choise = '0';
                        break;
                    case '2':
                        TakeQuestions.Choise();
                        Mode();
                        choise = '0';
                        break;
                    case '3':
                        TakeQuestions.Essey();
                        Mode();
                        choise = '0';
                        break;
                    case '0':
                        return;
                }

            } while (choise != 0);
        }
        static void DisplayExam() {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("------------------------Exam Starts------------------------");
            Console.WriteLine($"Exam Date: {TakeQuestions.exam.ExamDate} ");
            Console.WriteLine("------------------------Questions------------------------");
            foreach (var Question in TakeQuestions.exam.ExamQuestions) {
                Question.MakeQuestion();
                Console.WriteLine("Your Answer ?");
                string answer = Console.ReadLine();
                if (Question.CheckAnswer(answer)) {
                    Console.WriteLine("Your answer is correct");
                }
                else {
                    Console.WriteLine("Your answer is wrong");
                }

            }
        }
        static void Mode() {
            Console.WriteLine("Choose Mode");
            Console.WriteLine("t for teacher");
            Console.WriteLine("s for student");
            char choise = char.Parse(Console.ReadLine());
            switch (choise) {
                case 't':
                    Display();
                    break;
                case 's':
                    try {
                        DisplayExam();
                    }
                    catch (Exception ex) {
                        Console.WriteLine("No Exam");
                        Mode();
                    }
                    break;
            }
        }
        static void Main(string[] args) {
            Mode();
        }
    }
}
