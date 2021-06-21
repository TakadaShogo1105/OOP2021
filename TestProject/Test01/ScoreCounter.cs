using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }

        // コンストラクタ
        public ScoreCounter(string name,string subject,int score) {

            this.Name = name;
            this.Subject = subject;
            this.Score = score;
        }


        //メソッドの概要： 一人一人の英語の点数を読み込む
        private static IEnumerable<Student> ReadScore(string filePath) {





            
        }

        //メソッドの概要： 一人一人の英語の点数を出力
        public IDictionary<string, int> GetPerStudentScore() {





            
        }
    }
}
