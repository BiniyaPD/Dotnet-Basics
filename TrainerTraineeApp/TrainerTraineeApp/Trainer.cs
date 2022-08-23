using System.Collections.Generic;

namespace TrainerTraineeApp
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public Training Training { get; set; }
        private List<Trainee> trainees = new List<Trainee>();
        public void AddTrainees(Trainee trainee)
        {
            this.trainees.Add(trainee);
        }
        public IEnumerable<Trainee> GetTrainees()
        {
            return this.trainees;
        }
    }
}