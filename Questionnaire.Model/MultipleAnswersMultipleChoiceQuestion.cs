using System.Collections.Generic;

namespace Questionnaire.Model
{
    public class MultipleAnswersMultipleChoiceQuestion : MultipleChoiceQuestion
    {
        public IList<int> Answers { get; set; }
    }
}
