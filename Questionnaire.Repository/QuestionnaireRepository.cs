using System.Collections.Generic;
using System.Linq;

using Questionnaire.Model;
using model = Questionnaire.Model;
using MongoDB.Driver;

namespace Questionnaire.Repository
{
    public class QuestionnaireRepository
    {
        private class RawQuestionnaire
        {
            public string Title { get; set; }

            public string[] QuestiondIDs { get; set; }
        }

        private readonly MongoDatabase database;

        public QuestionnaireRepository(MongoDatabase database)
        {
            this.database = database;
        }

        public IEnumerable<Question> GetQuestionsByTags(params Tag[] tags)
        {
            return Enumerable.Empty<Question>();
        }

        public Question GetQuestionById(string id)
        {
            return null;
        }

        public void Save(model.Questionnaire questionnaire)
        {
            MongoCollection rawQuestionnaires = database.GetCollection<RawQuestionnaire>("questionnaires");

            RawQuestionnaire rawQuestionnaire = new RawQuestionnaire
            {
                Title = questionnaire.Title,
                QuestiondIDs = questionnaire.Questions.Select(q => q.ID).ToArray()
            };

            rawQuestionnaires.Save(rawQuestionnaire);
        }
    }
}
