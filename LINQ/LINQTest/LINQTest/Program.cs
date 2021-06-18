using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rounds = new Round[]
            {
                new Round { RoundID = 1, RoundNumber = "Round-45"},
                new Round { RoundID = 2, RoundNumber = "Round-46"},
                new Round { RoundID = 3, RoundNumber = "Round-47"}
            };

            var Batchs = new Batch[]
            {
                new Batch { BatchID = 1, ProgramName = "Web Design"},
                new Batch { BatchID = 2, ProgramName = "Web Development"},
                new Batch { BatchID = 3, ProgramName = "Graphics Design"},
                new Batch { BatchID = 4, ProgramName = "Networking"}
            };

           var TSPs = new TSP[]
           {
             new TSP { TSPID = 1, TSPName = "JPIT", TSPLocation = "Farmgate", StudentID = 1263995, StudentName = "Rakhi", RoundID = 1, BatchID = 1},
             new TSP { TSPID = 2, TSPName = "Cogent", TSPLocation = "Khilkhet", StudentID = 1263991, StudentName = "Akhi", RoundID = 2, BatchID = 21},
             new TSP { TSPID = 3, TSPName = "Dot Com", TSPLocation = "Mirpur", StudentID = 1263992, StudentName = "Raju", RoundID = 3, BatchID = 3},
             new TSP { TSPID = 4, TSPName = "New Horizons", TSPLocation = "Mohakhali", StudentID = 1263993, StudentName = "Juwel", RoundID = 1, BatchID = 4},
             new TSP { TSPID = 5, TSPName = "New Vision", TSPLocation = "Mogbazar", StudentID = 1263994, StudentName = "Saju", RoundID = 3, BatchID = 3},
             new TSP { TSPID = 6, TSPName = "US Software", TSPLocation = "Uttara", StudentID = 1263996, StudentName = "Shammi", RoundID = 2, BatchID = 3},
             new TSP { TSPID = 7, TSPName = "PeopleNtech", TSPLocation = "Dhanmondi", StudentID = 1263997, StudentName = "Nitu", RoundID = 3, BatchID = 4},
             new TSP { TSPID = 8, TSPName = "The Computers", TSPLocation = "Kallanpur", StudentID = 1263998, StudentName = "Shuvo", RoundID = 2, BatchID = 2},
             new TSP { TSPID = 9, TSPName = "Genuity", TSPLocation = "Shahbag", StudentID = 1263999, StudentName = "Trisha", RoundID = 1, BatchID = 1},
             new TSP { TSPID = 10, TSPName = "Bhuiyan IT", TSPLocation = "Tejgaon", StudentID = 12639910, StudentName = "Sharmin", RoundID = 2, BatchID = 1},
           };


            /*=============================Joining==========================*/

            var info = from p in TSPs
                       join c in Rounds
                       on p.RoundID equals c.RoundID
                       join m in Batchs
                       on p.BatchID equals m.BatchID
                       select new { TSP = p.TSPName, Round = c.RoundName, Batch = m.BatchName, p.TSPLocation, p.StudentName  };

            foreach (var x in info)
            {
                Console.WriteLine($"{x.TSP}\t{x.Round}\t{x.Batch}\t{x.TSPLocation}");
            }
        }
    }
}


