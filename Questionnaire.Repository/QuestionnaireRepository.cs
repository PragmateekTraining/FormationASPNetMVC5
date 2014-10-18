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

            public string[] QuestionsIDs { get; set; }
        }

        private readonly MongoDatabase database;

        private readonly MongoCollection rawQuestionnaires;

        public QuestionnaireRepository(MongoDatabase database)
        {
            this.database = database;
            this.rawQuestionnaires = database.GetCollection<RawQuestionnaire>("questionnaires");
            this.rawQuestionnaires = database.GetCollection<RawQuestionnaire>("questionnaires");
        }

        public IEnumerable<Question> GetQuestionsByTags(params Tag[] tags)
        {
            return Enumerable.Empty<Question>();
        }

        public Question GetQuestionById(string id)
        {
            return null;
        }

        public model.Questionnaire GetQuestionnaireByTitle(string title)
        {
            RawQuestionnaire rawQuestionnaire = rawQuestionnaires.FindOneByIdAs<RawQuestionnaire>(title);

            IList<Question> questions = new List<Question>();
            
            foreach (string id in rawQuestionnaire.QuestionsIDs)
            {
                questions.Add()
            }

            // model.Questionnaire questionnaire = new Questionnaire
        }

        public void Save(model.Questionnaire questionnaire)
        {
            RawQuestionnaire rawQuestionnaire = new RawQuestionnaire
            {
                Title = questionnaire.Title,
                QuestionsIDs = questionnaire.Questions.Select(q => q.ID).ToArray()
            };

            rawQuestionnaires.Save(rawQuestionnaire);
        }
    }
}
