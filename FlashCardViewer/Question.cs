using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FlashCardViewer
{
    [JsonObject]
    public class Question : IQuestion
    {
       
        [JsonProperty]
        public int QuestionId { get; private set; }
        [JsonProperty]
        public List<String> Images { get; set; }
        [JsonProperty]
        public String QuestionText { get; set; }
        [JsonProperty]
        public int Answer { get; set; }
        [JsonProperty]
        public String[] AnswerText { get; set;}
        [JsonIgnore]
        public int QuestionNumber { get; set; }
        [JsonIgnore]
        public bool Used { get; set; } = false;

        public Question()
        {
            //Empty Constructor
        }

        [JsonConstructor]
        public Question(List<String> images, int questionId, string answerText, string questionText, int answer)
        {
            Images = images;
            QuestionId = questionId;
            QuestionText = questionText;
            AnswerText = SplitAnswers(answerText);
            Answer = answer;
        }

        public static string[] SplitAnswers(string original)
        {
            return original.Split(';');
        }

    }

    public class Questions : IEnumerable
    {
        
        public List<IQuestion> QuestionsList{ get; set; }

        [JsonConstructor]
        public Questions(IQuestion[] qArray)
        {
            QuestionsList = new List<IQuestion>(qArray);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }

    public class QuestionEnum : IEnumerator
    {
        public IQuestion[] questions;
        int position = -1;

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public IQuestion Current
        {
            get
            {
                try
                {
                    return questions[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < questions.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public QuestionEnum(IQuestion[] list)
        {
            questions = list;
        }
    }
}
