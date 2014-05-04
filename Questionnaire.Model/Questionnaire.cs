using System.Collections.Generic;

namespace Questionnaire.Model
{
    public class Questionnaire
    {
        public string Title { get; set; }

        public IList<Question> Questions { get; set; }
    }
}
