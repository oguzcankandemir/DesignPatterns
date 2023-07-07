using DesignPattern.ChainOfResponsibilty.DAL;
using DesignPattern.ChainOfResponsibilty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "AreaDirector - Zeynep Baki";
                customerProcess.Description = "Withdrawal confirmed";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "AreaDirector - Zeynep Baki";
                customerProcess.Description = "Withdrawal not confirmed";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
              
            }
        }
    }
}
