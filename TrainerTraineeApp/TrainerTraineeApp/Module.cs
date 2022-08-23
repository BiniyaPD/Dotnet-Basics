using System;
using System.Collections.Generic;
using System.Text;

namespace TrainerTraineeApp
{
    public class Module
    {
        public string ModuleName { get; set; }
        private List<Unit> units = new List<Unit>();
        /// <summary>
        /// Add Units
        /// </summary>
        /// <param name="unit"></param>
        public void AddUnit(Unit unit)
        {
            this.units.Add(unit);
        }
        /// <summary>
        /// method to get all the units
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Unit> GetUnits()
        {
            return this.units;
        }
        /// <summary>
        /// Method is to get moduule duration
        /// </summary>
        /// <returns>the sum of module duration</returns>
        public int GetModuleDuration()
        {
            int total = 0;
            foreach (var unit in units)//to loop through units
            {
                total += unit.UnitDuration;
            }
            return total;
        }
    }
}
