using Mvc01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc01.Controllers
{
    public class MachinesController : Controller
    {
     //   private Boolean status = "";
        private static Machine machine = new Machine(); //ตัวแปร static จะเริ่มต้นตั้งแต่ Load และ ยังคงอยู่เรื่อยๆๆ ค่อนข้างทน
        // GET: Machines
        public ActionResult Index()
        {
            return View(machine);
        }
        public ActionResult InsertCoin(decimal amount)
        {
            machine.AcceptsCoin(amount);
            return RedirectToAction("Index"); //ส่งกลับไปยังหน้า Index
        }
        
        public ActionResult Cancel()
        {
            machine.CancelCoin();
            return RedirectToAction("Index");
        }

    


    }
}