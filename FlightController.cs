using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp3.Models;
using System.Configuration;


namespace MVCApp3.Controllers
{
    public class FlightController : Controller
    {
      public static  List<FlightsModel> FM = new List<FlightsModel>();
      public static  List<CrewModel> CM = new List<CrewModel>();
       static FlightController()
        {
            CM.Add(new CrewModel { CrewId = 1, CrewName = "Priya", CrewDesig = "FlightAttendant" });
            CM.Add(new CrewModel { CrewId = 2, CrewName = "Renukha", CrewDesig = "FlightAttendant" });
            CM.Add(new CrewModel { CrewId = 3, CrewName = "Pragati", CrewDesig = "FlightAttendan" });
            CM.Add(new CrewModel { CrewId = 4, CrewName = "Prema", CrewDesig = "FlightAttendan" });
            CM.Add(new CrewModel { CrewId = 100, CrewName = "Priya", CrewDesig = "Captain" });
            CM.Add(new CrewModel { CrewId = 101, CrewName = "Nagesh", CrewDesig = "Captain" });
            CM.Add(new CrewModel { CrewId = 102, CrewName = "Subahsh", CrewDesig = "Captain" });

            CrewModel c1 = new CrewModel { CrewId = 1, CrewName = "Priya", CrewDesig = "FlightAttendant" };
            CrewModel c2 = new CrewModel { CrewId = 2, CrewName = "Renukha", CrewDesig = "FlightAttendant" };
            CrewModel c3 = new CrewModel { CrewId = 3, CrewName = "Pragati", CrewDesig = "FlightAttendan" };
            CrewModel c4 = new CrewModel { CrewId = 4, CrewName = "Prema", CrewDesig = "FlightAttendan" };
            CrewModel c5 = new CrewModel { CrewId = 100, CrewName = "Priya", CrewDesig = "Captain" };
            CrewModel c6 = new CrewModel { CrewId = 101, CrewName = "Nagesh", CrewDesig = "Captain" };
            CrewModel c7 = new CrewModel { CrewId = 102, CrewName = "Subahsh", CrewDesig = "Captain" };

            FlightCrewModel fc = new FlightCrewModel();
            fc.FlightId = 1;
            fc.crewmembers = new List<CrewModel> { c1, c3, c4 };


            FlightCrewModel fc1 = new FlightCrewModel();
            fc.FlightId = 2;
            fc.crewmembers = new List<CrewModel> { c2, c5, c6 };

            FlightCrewModel fc2 = new FlightCrewModel();
            fc.FlightId = 3;
            fc.crewmembers = new List<CrewModel> { c7, c2, c4 };

            FM.Add(new FlightsModel
            {
                FlightId = 1,
                FlightName = "AirLine",
                FlightArrival = new DateTime(2020, 12, 05, 03, 25, 34),
                FlightDeparture = new DateTime(2020, 12, 06, 05, 25, 34),
                NoOfPassengers
    = 20,
                CaptainId = 104,
                CrewDetails = fc.crewmembers
            });
            FM.Add(new FlightsModel
            {
                FlightId = 2,
                FlightName = "AirLine",
                FlightArrival = new DateTime(2020, 10, 05, 03, 25, 34),
                FlightDeparture = new DateTime(2020, 12, 06, 05, 25, 34),
                NoOfPassengers = 20,
                CaptainId = 100,
                CrewDetails = fc.crewmembers
            });
            FM.Add(new FlightsModel
            {
                FlightId = 3,
                FlightName = "AirIndia",
                FlightArrival = new DateTime(2019, 12, 05, 03, 25, 34),
                FlightDeparture = new DateTime(2019, 12, 06, 05, 25, 34),
                NoOfPassengers = 20,
                CaptainId = 101,
                CrewDetails = fc.crewmembers
            });
            FM.Add(new FlightsModel
            {
                FlightId = 4,
                FlightName = "AirUS",
                FlightArrival = new DateTime(2018, 12, 05, 03, 25, 34),
                FlightDeparture = new DateTime(2018, 12, 06, 05, 25, 34),
                NoOfPassengers = 20,
                CaptainId = 102,
                CrewDetails = fc.crewmembers
            });

    }

        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListFlights()
        {

            return View(FM);
        }
        public ActionResult AddFlight()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFlight(FlightsModel data)
        {
            FM.Add(new FlightsModel { FlightId = data.FlightId, FlightName = data.FlightName, FlightArrival = data.FlightArrival, FlightDeparture = data.FlightDeparture, NoOfPassengers =data.NoOfPassengers,CaptainId=data.CaptainId });
            return View();
        }
        public ActionResult UpdateFlight(int id)
        {
           var FlightToUpdate= FM.Find(f => f.FlightId == id);
            return View(FlightToUpdate);
        }
        [HttpPost]
        public ActionResult UpdateFlight(int id,FlightsModel data)
        {
            var FlightToUpdate = FM.Find(f => f.FlightId == id);
           // FlightToUpdate.FlightId = data.FlightId;
            FlightToUpdate.FlightName = data.FlightName;
            FlightToUpdate.FlightArrival = data.FlightArrival;
            FlightToUpdate.FlightDeparture = data.FlightDeparture;
            FlightToUpdate.CaptainId = data.CaptainId;
            FlightToUpdate.NoOfPassengers = data.NoOfPassengers;
            return RedirectToAction("ListFlights");
        }
        public ActionResult CancelFlight(int id)
        {
            var FlightToCancel = FM.Find(f => f.FlightId == id);
            return View(FlightToCancel);
            
        }
        [HttpPost]
        public ActionResult CancelFlight(int id,FlightsModel data)
        {
            var FlightToCancel = FM.Find(f => f.FlightId == id);
            FM.Remove(FlightToCancel);
            return RedirectToAction("ListFlights");
        }
        public ActionResult Details(int id)
        {
            var FlightDetails = FM.Find(f => f.FlightId == id);
            ViewBag.CrewDetails = FlightDetails.CrewDetails;
            return View(FlightDetails);
        }
    }
}