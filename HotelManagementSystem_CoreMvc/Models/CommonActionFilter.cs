using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace HotelManagementSystem_CoreMvc.Models
{
    public class CommonActionFilter : IActionFilter
    {
        public IConfiguration _configuration;
        public CommonActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dbconOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbconOptions.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            ApplicationDbContext db = new ApplicationDbContext(dbconOptions.Options);
            var MenuPermiBasedOnRoll = from mm in db.MenuModel
                                       join mhm in db.MenuHelperModel on mm.MenuHelperModelId equals mhm.Id
                                       join ro in db.Roles.ToList() on mm.RollId equals ro.Id
                                       join mmm in db.MenuModelManage on mm.Id equals mmm.MenuModelId
                                       select new
                                       {
                                           ControllerName = mhm.ControllerName,
                                           ActionName = mhm.ActionName,
                                           RollName = ro.Name,
                                           Insert = mmm.Insert,
                                           Delete = mmm.Delete,
                                           Update = mmm.Update,
                                           Retrive = mmm.Retrive
                                       };
            var contName = context.RouteData.Values["controller"];
            var actName = context.RouteData.Values["action"];
            var metName = context.HttpContext.Request.Method;
            bool Retrive = false;
            bool Insert = false;
            bool Delete = false;
            bool Update = false;
            if (actName.ToString() == "Index" && metName.ToString() == "GET")
            {
                Retrive = true;
            }
            if (actName.ToString() == "Create" && metName.ToString() == "POST")
            {
                Insert = true;
            }
            if (actName.ToString() == "Edit" && metName.ToString() == "POST")
            {
                Update = true;
            }
            if (actName.ToString() == "Delete" && metName.ToString() == "POST")
            {
                Delete = true;
            }
            var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            bool permitted = false;
            foreach (var loopClaimRoll in allRollInClaims)
            {
                if (Retrive)
                {
                    permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.Retrive == Retrive).Any();
                    if (permitted)
                    {
                        break;
                    }
                }
                else if (Insert)
                {
                    permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.Insert == Insert).Any();
                    if (permitted)
                    {
                        break;
                    }
                }
                else if (Delete)
                {
                    permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.Delete == Delete).Any();
                    if (permitted)
                    {
                        break;
                    }
                }
                else
                {
                    permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.Update == Update).Any();
                    if (permitted)
                    {
                        break;
                    }
                }
            }
            if (!permitted)
            {
                Controller controller = context.Controller as Controller;

                context.Result = controller.RedirectToAction("AccessDenied", "Account");

            }
        }
    }


    public class SelectActionFilter : IActionFilter
    {
        public IConfiguration _configuration;
        public SelectActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dbconOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbconOptions.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            ApplicationDbContext db = new ApplicationDbContext(dbconOptions.Options);


               var MenuPermiBasedOnRoll = from me in db.AuthenticModel.ToList()
                                     join ro in db.Roles.ToList() on me.RoleId equals ro.Id
                                     select new
                                     {

                                         ConName = me.ControllerName,

                                         RollName = ro.Id,
                                         Retrieve = me.Retrive

                                     };


            string contName = context.RouteData.Values["controller"].ToString();

            // var aaa = context.HttpContext.User.Claims.Where(w => w.Value == ClaimTypes.Role).ToList();

            var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            //var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            bool permitted = false;
            foreach (var loopClaimRoll in allRollInClaims)
            {
               
                    permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value   && w.ConName.ToString() == contName && w.Retrieve == true ).Any();

                    if (permitted)
                    {
                        break;
                    }
               
            }


            if (!permitted)
            {
                Controller controller = context.Controller as Controller;

                context.Result = controller.RedirectToAction("AccessDenied", "Account");

            }




        }
    }

    public class InsertActionFilter : IActionFilter
    {
        public IConfiguration _configuration;
        public InsertActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dbconOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbconOptions.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            ApplicationDbContext db = new ApplicationDbContext(dbconOptions.Options);


            var MenuPermiBasedOnRoll = from me in db.AuthenticModel.ToList()
                                       join ro in db.Roles.ToList() on me.RoleId equals ro.Id
                                       select new
                                       {

                                           ConName = me.ControllerName,

                                           RollName = ro.Id,
                                           InsName = me.Insert

                                       };


            string contName = context.RouteData.Values["controller"].ToString();

            var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            bool permitted = false;
            foreach (var loopClaimRoll in allRollInClaims)
            {

                permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.ConName.ToString() == contName && w.InsName == true).Any();

                if (permitted)
                {
                    break;
                }

            }


            if (!permitted)
            {
                Controller controller = context.Controller as Controller;

                context.Result = controller.RedirectToAction("AccessDenied", "Account");

            }




        }
    }

    public class DeleteActionFilter : IActionFilter
    {
        public IConfiguration _configuration;
        public DeleteActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dbconOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbconOptions.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            ApplicationDbContext db = new ApplicationDbContext(dbconOptions.Options);


            var MenuPermiBasedOnRoll = from me in db.AuthenticModel.ToList()
                                       join ro in db.Roles.ToList() on me.RoleId equals ro.Id
                                       select new
                                       {

                                           ConName = me.ControllerName,

                                           RollName = ro.Id,
                                           deleteName = me.Delete

                                       };


            string contName = context.RouteData.Values["controller"].ToString();

            var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            bool permitted = false;
            foreach (var loopClaimRoll in allRollInClaims)
            {

                permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.ConName.ToString() == contName && w.deleteName == true).Any();

                if (permitted)
                {
                    break;
                }

            }


            if (!permitted)
            {
                Controller controller = context.Controller as Controller;

                context.Result = controller.RedirectToAction("AccessDenied", "Account");

            }




        }
    }

    public class EditActionFilter : IActionFilter
    {
        public IConfiguration _configuration;
        public EditActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dbconOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbconOptions.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            ApplicationDbContext db = new ApplicationDbContext(dbconOptions.Options);


            var MenuPermiBasedOnRoll = from me in db.AuthenticModel.ToList()
                                       join ro in db.Roles.ToList() on me.RoleId equals ro.Id
                                       select new
                                       {

                                           ConName = me.ControllerName,

                                           RollName = ro.Id,
                                           editName = me.Update

                                       };


            string contName = context.RouteData.Values["controller"].ToString();

            var allRollInClaims = context.HttpContext.User.Claims.Where(w => w.Type == ClaimTypes.Role).ToList();
            bool permitted = false;
            foreach (var loopClaimRoll in allRollInClaims)
            {

                permitted = MenuPermiBasedOnRoll.Where(w => w.RollName == loopClaimRoll.Value && w.ConName.ToString() == contName && w.editName == true).Any();

                if (permitted)
                {
                    break;
                }

            }


            if (!permitted)
            {
                Controller controller = context.Controller as Controller;

                context.Result = controller.RedirectToAction("AccessDenied", "Account");

            }




        }
    }
}


