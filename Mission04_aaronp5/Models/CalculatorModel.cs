using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_aaronp5.Models
{
    public class CalculatorModel
    {
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int assignments { get; set; }  //The code below does the same thing as this {get; set; }
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int project { get; set; }    //Based off of the name of the input in the form, asp-for
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int midterm { get; set; }
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int final { get; set; }
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int intex { get; set; }



        /*    setter
        public void setAssignments(int input)
        {
            this.assignments = input;
        }

        //   getter
        public int getAssignments()
        {
            return this.assignments;
        }*/
    }
}


