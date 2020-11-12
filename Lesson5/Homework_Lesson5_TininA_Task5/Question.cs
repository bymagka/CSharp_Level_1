/*
 * Tinin A
 * 
 * 5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
 */
namespace Homework_Lesson5_TininA_Task5
{
    partial class Program
    {
        struct Question
        {
            //текст вопроса
            private string QuestionText { get; set; }

            //ответ на вопрос
            private string Answer { get; set; }


            public Question(string questionText, string answer)
            {
                QuestionText = questionText;
                Answer = answer;
            }

            //проверка ответа
            public bool CheckAnswer(string answer)
            {
                return this.Answer.ToLower().CompareTo(answer) == 0;
            }
            
            //метод для получения 
            public string GetQuestion()
            {
                return this.QuestionText;
            }

            public override string ToString()
            {
                return this.QuestionText;
            }
        }
    }
}
