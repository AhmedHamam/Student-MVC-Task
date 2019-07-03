namespace StudentTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class course_questions
    {
        [Key]
        public int question_id { get; set; }

        [Required]
        public string question { get; set; }

        public string answer1 { get; set; }

        public string answer2 { get; set; }

        public string answer3 { get; set; }

        public string answer4 { get; set; }

        [Required]
        [StringLength(50)]
        public string Response { get; set; }

        public int crs_id { get; set; }

        public virtual courses courses { get; set; }
    }
}
