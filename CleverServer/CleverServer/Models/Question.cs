using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverServer.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Query { get; set; }
        public string TryReply { get; set; }
        public string Reply2 { get; set; }
        public string Reply3 { get; set; }
        public string Reply4 { get; set; }
        public int SumTry { get; set; }
        public int Sum2 { get; set; }
        public int Sum3 { get; set; }
        public int Sum4 { get; set; }

        public int? CategoryID { get; set; }
        public Category Category { get; set; }

    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
