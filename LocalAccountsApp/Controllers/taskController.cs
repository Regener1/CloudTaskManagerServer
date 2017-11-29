using LocalAccountsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocalAccountsApp.Controllers
{
    [RoutePrefix("api/Task")]
    public class TaskController : ApiController
    {
        private TasksContext tasksContext = new TasksContext();
        //private UsersContext usersContext = new UsersContext();

        //GET api/Task/GetAll? userId = 1
        [Route("GetAll")]
        public IEnumerable<Tasks> GetAll()
        {
            return tasksContext.Tasks; //.Where(task => task.IdUser.Equals(userId));string userId
        }

        //// POST api/Task/Add
        //[Route("Add")]
        //public void AddTask([FromBody] Tasks task)
        //{
        //    tasksContext.Tasks.Add(task);
        //    tasksContext.SaveChanges();
        //}

        //// PUT api/Task/Edit
        //[Route("Edit")]
        //public void EditTask(int id, [FromBody] Tasks task)
        //{
        //    if (id == task.Id)
        //    {
        //        // varify
        //        tasksContext.Entry(task).State = EntityState.Modified;

        //        tasksContext.SaveChanges();
        //    }
        //}

        //// DELETE api/Task/Delete
        //[Route("Delete")]
        //public void DeleteTask(int id)
        //{
        //    Tasks task = tasksContext.Tasks.Find(id);
        //    if (task != null)
        //    {
        //        tasksContext.Tasks.Remove(task);
        //        tasksContext.SaveChanges();
        //    }
        //}

        //// api/Task/CheckComplete
        //[Route("CheckComplete")]
        //public void CheckComplete()
        //{

        //}

        //// GET api/Task/DeleteCompletedTasks
        //[Route("DeleteCompletedTasks")]
        //public void DeleteCompletedTasks([FromUri] int[] ids)
        //{
        //    Tasks task = null;

        //    for (int i = 0; i < ids.Length; i++)
        //    {
        //        task = tasksContext.Tasks.Find(ids[i]);
        //        if (task != null)
        //        {
        //            tasksContext.Tasks.Remove(task);
        //            tasksContext.SaveChanges();
        //        }
        //    }

        //}



        //

        [HttpGet]
        [Route("something")]
        public string something()
        {
            return "some string";
        }
    }
}