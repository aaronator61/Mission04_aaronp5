var totalGrade;
var letterGrade;

//form where user inputs percentages for each section that goes into final grade
$("#grades").click(function () {

    //Calculating total grade with the individual weights
    totalGrade = $("#assignments").val() * .5 +
        $('#groupProject').val() * .1 + 
        $('#quizzes').val() * .1 +
        $('#midtermExam').val() * .1 +
        $('#finalExam').val() * .1 +
        $('#intex').val() * .1;

    //Determining what letter grade to display
    if (totalGrade >= 94) {
        letterGrade = 'A';
    }
    else if (totalGrade >= 90) {
        letterGrade = 'A-';
    }
    else if (totalGrade >= 87) {
        letterGrade = 'B+';
    }
    else if (totalGrade >= 84) {
        letterGrade = 'B';
    }
    else if (totalGrade >= 80) {
        letterGrade = 'B-';
    }
    else if (totalGrade >= 77) {
        letterGrade = 'C+';
    }
    else if (totalGrade >= 74) {
        letterGrade = 'C';
    }
    else if (totalGrade >= 70) {
        letterGrade = 'C-';
    }
    else if (totalGrade >= 90) {
        letterGrade = 'D+';
    }
    else if (totalGrade >= 90) {
        letterGrade = 'D';
    }
    else if (totalGrade >= 90) {
        letterGrade = 'D-';
    }
    else {
        letterGrade = 'E'
    }
    $('#calculatedGrade').text("Final Grade: " + totalGrade.toString() + "%  " + letterGrade);

})