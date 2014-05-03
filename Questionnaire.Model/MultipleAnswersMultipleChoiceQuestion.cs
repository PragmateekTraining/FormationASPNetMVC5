using System.Collections.Generic;

namespace Questionnaire.Model
{
    public class MultipleAnswersMultipleChoiceQuestion : MultipleChoiceQuestion
    {
        public IList<Choice> Answers { get; set; }
    }
}
