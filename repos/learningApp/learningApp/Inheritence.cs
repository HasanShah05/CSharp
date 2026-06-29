using System;

namespace workItemTracker
{
    public class WorkItem
    {
        private static int CurrentID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Defult Ttiel";
            Description = "Defult Description";
            jobLength = new TimeSpan();
        }
        public WorkItem(string title, string desc, TimeSpan joblen)
        {
            ID = GetnextID();
            Title = title;
            Description = desc;
            jobLength = joblen;
        }
        static WorkItem() => CurrentID = 0;

        protected int GetnextID() => ++CurrentID;

        public void update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }

        public override string ToString() => $"{this.ID} - {this.Title}";
    }
    public class Changerequest : WorkItem
    {
        protected int originalItemID { get; set; }

        public Changerequest() { }

        public Changerequest(string title, string desc, TimeSpan joblen, int OriginalID)
        {
            this.ID = GetnextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;
            
            this.originalItemID = OriginalID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WorkItem item = new WorkItem("Fix Bugs","Fix all bugs in my code branch", new TimeSpan(3, 4, 0,0 ));

            Changerequest change = new Changerequest("chnage Base Class Desing", "Add members to the class", new TimeSpan(4,0,0),1);

            Console.WriteLine(item.ToString());
        }
    }
}