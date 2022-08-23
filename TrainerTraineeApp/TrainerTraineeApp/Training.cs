using System.Collections.Generic;

namespace TrainerTraineeApp
{
    public class Training
    {
        public string TrainingName { get; set; }
        public Course Course  { get; set; }
        public Trainer Trainer { get; set; }
        private List<Trainee> trainees = new List<Trainee>();
        public void AddTrainee(Trainee trainee)
        {
            this.trainees.Add(trainee);
        }
        public IEnumerable<Trainee>GetTrainees()
        {
            return this.trainees;
        }
        /// <summary>
        /// Get the Total Training Duration
        /// </summary>
        /// <returns></returns>
        public int GetTotalTrainingDuration()
        {
          

            return this.Course.GetCourseDuration();
            
        }

    }
}