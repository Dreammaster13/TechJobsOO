using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechJobs.Models

{
    public class Job
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }

        [Column("Skill")]
        public CoreCompetency CoreCompetency { get; set; }

        [Column("Position")]
        public PositionType PositionType { get; set; }

        public Job()
        {
            ID = nextId;
            nextId++;
        }

    }
}
