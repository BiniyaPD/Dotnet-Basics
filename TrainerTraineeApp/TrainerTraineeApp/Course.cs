using System;
using System.Collections.Generic;
using System.Text;

namespace TrainerTraineeApp
{
    public class Course
    {
        public string CourseName { get; set; }
        private List<Module> modules = new List<Module>();
        public Technology Technology { get; set; }
        private List<Training> trainings = new List<Training>(); 
        public void AddModules(Module module)
        {
            this.modules.Add(module);
        }
        public IEnumerable<Module>GetModules()
        {
            return this.modules;
        }
        public void AddTrainings(Training training)
        {
            this.trainings.Add(training);
        }
        public IEnumerable<Training> GetTrainings()
        {
            return this.trainings;
        }
        /// <summary>
        /// Method to get Course duration
        /// </summary>
        /// <returns></returns>
        public int GetCourseDuration()
        {
            int total = 0;
            foreach (var module in this.modules)
            {
                total += module.GetModuleDuration();
            }
            return total;

        }

    }
}
