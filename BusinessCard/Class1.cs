using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCard
{
    public class BusinessCard
    {
        public string name = "";
        public BusinessCard(string name)
        {
            this.name = name;
        }
        public string FindOutWhose()
        {
            return name + "'s business card";
        }
    }
}
