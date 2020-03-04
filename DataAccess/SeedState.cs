using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess
{
    public class SeedState
    {
        public List<State> AddSeedState()
        {
            List<State> States = new List<State>();
            States.Add(new State { Name = "Abia" });
            States.Add(new State { Name = "Adamawa" });
            States.Add(new State { Name = "Akwa Ibom" });
            States.Add(new State { Name = "Anambra" });
            States.Add(new State { Name = "Bauchi" });
            States.Add(new State { Name = "Bayelsa" });
            States.Add(new State { Name = "Benue" });
            States.Add(new State { Name = "Borno" });
            States.Add(new State { Name = "Cross River" });
            States.Add(new State { Name = "Delta" });
            States.Add(new State { Name = "Ebonyi" });
            States.Add(new State { Name = "Edo" });
            States.Add(new State { Name = "Ekiti" });
            States.Add(new State { Name = "Enugu" });
            States.Add(new State { Name = "FCT" });
            States.Add(new State { Name = "Gombe" });
            States.Add(new State { Name = "Imo" });
            States.Add(new State { Name = "Jigawa" });
            States.Add(new State { Name = "Kaduna" });
            States.Add(new State { Name = "Kano" });
            States.Add(new State { Name = "Katsina" });
            States.Add(new State { Name = "Kebbi" });
            States.Add(new State { Name = "Kogi" });
            States.Add(new State { Name = "Kwara" });
            States.Add(new State { Name = "Lagos" });
            States.Add(new State { Name = "Nasarawa" });
            States.Add(new State { Name = "Niger" });
            States.Add(new State { Name = "Ogun" });
            States.Add(new State { Name = "Ondo" });
            States.Add(new State { Name = "Osun" });
            States.Add(new State { Name = "Oyo" });
            States.Add(new State { Name = "Plateau" });
            States.Add(new State { Name = "Rivers" });
            States.Add(new State { Name = "Sokoto" });
            States.Add(new State { Name = "Taraba" });
            States.Add(new State { Name = "Yobe" });
            States.Add(new State { Name = "Zamfara" });

            return States;
        }
    }
}
