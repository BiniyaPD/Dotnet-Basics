using System;
using System.Collections.Generic;
using System.Text;

namespace TrainerTraineeApp
{
    public class Unit
    {
        public int UnitDuration { get; set; }
        public string UnitName { get; set; }
        private List<Topic> topics = new List<Topic>();
        public void AddTopic(Topic topic)
        {
            this.topics.Add(topic);
        }
        public IEnumerable<Topic> GetTopics()
        {
            return this.topics;
        }
    }
}
