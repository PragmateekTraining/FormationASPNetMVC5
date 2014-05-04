using System.Collections.Generic;

namespace Questionnaire.Model
{
    public abstract class Question
    {
        public string ID { get; set; }

        public string Text { get; set; }

        public IList<Tag> Tags { get; set; }

        public Question()
        {
            Tags = new List<Tag>();
        }

        public Question(string text)
            : this()
        {
            Text = text;
        }
    }
}
