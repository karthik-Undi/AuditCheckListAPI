using AuditCheckListAPI.Models;
using AuditCheckListAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditCheckListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditCheckListController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuditCheckListController));
        private readonly IAuditChecklistRepos _context;

        public AuditCheckListController(IAuditChecklistRepos context) 
        {
            _context = context;
        } 
        [HttpGet("GetInternalQuestions")]
        public InternalQuestions GetInternalQuestions()
        {
            _log4net.Info("Get Internal Questions Was Called !!");
            return _context.GetInternalQuestions();
        }

        [HttpGet("GetSoxQuestions")]
        public SoxQuestions GetSoxQuestions()
        {
            _log4net.Info("Get Sox Questions Was Called !!");
            return _context.GetSoxQuestions();
        }

    }
}
