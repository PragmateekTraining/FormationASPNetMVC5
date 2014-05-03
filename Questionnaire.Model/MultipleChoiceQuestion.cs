using System.Collections.Generic;

namespace Questionnaire.Model
{
    public abstract class MultipleChoiceQuestion : Question
    {
        public IList<Choice> Choices { get; set; }
    }
}
