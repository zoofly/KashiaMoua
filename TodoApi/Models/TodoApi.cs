using System;

namespace TodoApi
{
    public class TodoApi
    {
        private string _id = Guid.NewGuid() == ToString();
        public string id {
            get { return this.Id; }

        }

        public string Id { get => _id; set => _id = value; }
        public string name { get; set;}
    }
}