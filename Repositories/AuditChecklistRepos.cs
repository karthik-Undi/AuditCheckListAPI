using AuditCheckListAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditCheckListAPI.Repositories
{
    public class AuditChecklistRepos : IAuditChecklistRepos
    {
        static InternalQuestions internalQuestions = new InternalQuestions()
        {
            QuestionOne = "Have all Change requests followed SDLC before PROD move?",
            QuestionTwo = "Have all Change requests been approved by the application owner?",
            QuestionThree = "Are all artifacts like CR document, Unit test cases available?",
            QuestionFour = "Is the SIT and UAT sign-off available?",
            QuestionFive = "Is data deletion from the system done with application owner approval?"
        };
        static SoxQuestions soxQuestions = new SoxQuestions()
        {
            QuestionOne = "Have all Change requests followed SDLC before PROD move?",
            QuestionTwo = "Have all Change requests been approved by the application owner?",
            QuestionThree = "For a major change, was there a database backup taken before and after PROD move?",
            QuestionFour = "Has the application owner approval obtained while adding a user to the system?",
            QuestionFive = "Is data deletion from the system done with application owner approval?"
        };

        public InternalQuestions GetInternalQuestions()
        {
            return internalQuestions;
        }

        public SoxQuestions GetSoxQuestions()
        {
            return soxQuestions;
        }

    }
}
