namespace ConsoleApp1 {
    public enum TrueOrFalse {
        True,
        False
    };
    public abstract class Questions {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Answer { get; set; }
        public double Mark { get; set; }
        public string QuestionLevel { get; set; }


        public Questions(string header, string body, string answer, double mark, string questionLevel) {
            Header = header;
            Body = body;
            Answer = answer;
            Mark = mark;
            QuestionLevel = questionLevel;
        }

        public bool CheckAnswer(string answer) {
            return Answer == answer;
        }
        public virtual void MakeQuestion() {
            Console.WriteLine($"Question level : {QuestionLevel} ");
            Console.Write(Header);
            Console.WriteLine($"                  Mark:{Mark}");
            Console.WriteLine(Body);
        }
    }
    public class TrueOrFalseQuestion : Questions {
        public TrueOrFalse Tof { get; set; }
        public TrueOrFalseQuestion(string header, string body, string answer, double mark, string questionLevel) :
            base(header, body, answer, mark, questionLevel) { }
        public override void MakeQuestion() {
            base.MakeQuestion();
            Console.WriteLine($"1.{TrueOrFalse.True}");
            Console.WriteLine($"2.{TrueOrFalse.False}");
        }
    }

    public class ChoiseQuestion : Questions {
        public List<string> Choises { get; set; }
        public ChoiseQuestion(string header, string body, string answer, double mark, string questionLevel, List<string> choises) :
            base(header, body, answer, mark, questionLevel) {
            Choises = choises;
        }
        public override void MakeQuestion() {
            base.MakeQuestion();
            foreach (string item in Choises)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    public class EsseyQuestion : Questions {
        public EsseyQuestion(string header, string body, string answer, double mark, string questionLevel) :
            base(header, body, answer, mark, questionLevel) { }
        public new void MakeQuestion() { 
            base.MakeQuestion();
        }
    }
}