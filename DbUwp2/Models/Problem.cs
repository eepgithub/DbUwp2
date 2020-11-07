using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace DbUwp2.Models
{
    public class Problem
    {



        public int ProblemId { get; set; }
        public string Customer { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public DateTime Created = DateTime.Now;





        public Problem(string customer, string title, string status, string description)
        {
           
            Customer = customer;
            Title = title;
            Status = status;
            Description = description;
        }
            

        public Problem(int problemid, string customer, string title, string status, DateTime created, string description)
        {
            ProblemId = problemid;
            Customer = customer;
            Title = title;
            Status = status;
            Created = created;
            Description = description;
        }


        public Problem()
        {

        }



    }


    






}
