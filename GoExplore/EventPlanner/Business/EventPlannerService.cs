using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventPlanner.Business
{
    public class EventPlannerService
    {
        //public ViewEvent GetEvent()
        //{
        //    ViewEvent eventList  = new ViewEvent();
        //    try
        //    {
        //        using (GoExplore db = new GoExplore())
        //        {
        //            List<EventCategory> eventCategories = new List<EventCategory>();
        //            List<Event_Details> event_Details = new List<Event_Details>();
        //            List<User> users = new List<User>();
        //            ///db.Event_Details.Select(i => new { i.CategoryId ,i.EventId});

        //            var eventLists = from ED in event_Details
        //                        join EC in eventCategories on ED.CategoryId equals EC.CategoryId into table1
        //                        from EC in table1.ToList()
        //                        join U in users on ED.Organiser_ID equals U.UserID into table2
        //                        from U in table2.ToList();

        //            eventList = eventLists;
        //            //                select new ViewEvent
        //            //                {
        //            //                    EC = EC,
        //            //                    ED = ED,
        //            //                    U = U
        //            //                };
        //            //eventList;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //return ex.Message;
        //    }

        //    return View();
        //}
    }
}