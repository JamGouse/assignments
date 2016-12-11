/*
This is empty on purpose! Your code to build the resume will go here.
*/

 // var awesomeThoughts="I am fun!";
 // var funThoughts=awesomeThoughts.replace("awesome","fun");
 // if (funThoughts == "I am Gouse" || funThoughts=="I am fun!") {
 //    $("#main").append(funThoughts);
 // }
 // else{
 //    $("#main").append("Gouse Makandar");
 // }
// var name="Gouse Makandar";
// var role="Software Developer";
var skills=["c","c#","css","Asp.net MVC","Html","JS","jQuery"];
var bio={
    "name":"Gouse Makandar",
    "role":"Software Developer",
    "contacts":{
        "location":"dandeli, karnataka, india"
    },
    "mobile":"+91 8951576796",

    "skills":skills,
    "bioPic":"images/fry.jpg"
};

bio.gitHub="https://github.com/JamGouse";
bio["email"]="gouse@jamsons.in";
//$("#main").append(bio.skills.length);

//Header display name and role.
var myName= HTMLheaderName.replace("%data%", bio.name);
var myRole=HTMLheaderRole.replace("%data%", bio.role);
$("#header").prepend(myRole);
$("#header").prepend(myName);

var bioPic=HTMLbioPic.replace("%data%",bio.bioPic);
var email=HTMLemail.replace("%data%", bio.email);
var gitHub=HTMLgithub.replace("%data%", bio.gitHub);
var mobile=HTMLmobile.replace("%data%", bio.mobile);
var city=HTMLlocation.replace("%data%", bio.contacts.location);
var skillsStart=HTMLskillsStart.replace("%data%", skills);
var skills=HTMLskills.replace("%data%", skills);

$("#header").append(bioPic);
$("#topContacts").append(email);
$("#topContacts").append(gitHub);
$("#topContacts").append(mobile);
$("#topContacts").append(city);
//$("#skills-h3").prepend(skillsStart);

//create function displayWork()
function displayWork(){
if (bio.skills.length>0) {
    $("#header").append(HTMLskillsStart);
    for (var i = 0; i < bio.skills.length; i++) {

        var skillsList=HTMLskills.replace("%data%", bio.skills[i]);
        $("#skills").append(skillsList + ",");
    }
}
}

//innovke function displayWork()
displayWork();

//work object
var work={
    "jobs":[{
        "jobPosition":"Software Developer",
        "employer":"Jamsons",
        "yearsWorked":"2 years",
        "location":"Goa, india",
        "description": "Have 2 years of experience in Asp.net MVC 4 technology"
    }]
}
$("#workExperience").append(HTMLworkStart);
for (var i = 0; i < work.jobs.length; i++) {
    var employer=HTMLworkEmployer.replace("%data%", work.jobs[i].employer);
    var jobPosition=HTMLworkTitle.replace("%data%", work.jobs[i].jobPosition);
    var yearsWorked=HTMLworkDates.replace("%data%", work.jobs[i].yearsWorked);
    var city=HTMLworkLocation.replace("%data%", work.jobs[i].location);
    var description=HTMLworkDescription.replace("%data%", work.jobs[i].description);
    $(".work-entry").append(employer);
    $(".work-entry").append(jobPosition);
    $(".work-entry").append(yearsWorked);
    $(".work-entry").append(city);
    $(".work-entry").append(description);
}

//Education object
var education={
    "schools":[
    {
        "schoolName":"KLECET",
        "degree":"MCA",
        "major":["Computer Science","DBMS"],
        "yearOfPassing":"2013",
        "location":"Belgaum"
    }
    ]
};
$("#education").append(HTMLschoolStart);
for (var i = 0; i < education.schools.length; i++) {
    var schoolName=HTMLschoolName.replace("%data%", education.schools[i].schoolName);
    var degree=HTMLschoolDegree.replace("%data%", education.schools[i].degree);
    var yearOfPassing=HTMLschoolDates.replace("%data%", education.schools[i].yearOfPassing);
    var major=HTMLschoolMajor.replace("%data%", education.schools[i].major);
    var schoolCity=HTMLschoolLocation.replace("%data%", education.schools[i].location);
    var list=schoolName+degree+major+yearOfPassing+schoolCity;
    $(".education-entry:last").append(list);
    // $(".education-entry").append(degree);
    // $(".education-entry").append(major);
    // $(".education-entry").append(yearOfPassing);
    // $(".education-entry").append(schoolCity);
}

//Online Classes object
var onlineClasses={
    "onlineCourse":[
    {
        "title": "HTML and CSS",
        "school":"Udacity",
        "date":"10-11-2016",
        "url":"www.udacity.com"
    }]
};
$("#online").append(HTMLonlineClasses);
for (var i = 0; i < onlineClasses.onlineCourse.length; i++) {
    var title=HTMLonlineTitle.replace("%data%", onlineClasses.onlineCourse[i].title);
    var school=HTMLonlineSchool.replace("%data%", onlineClasses.onlineCourse[i].school);
    var date=HTMLonlineDates.replace("%data%", onlineClasses.onlineCourse[i].date);
    var url=HTMLonlineURL.replace("%data%", onlineClasses.onlineCourse[i].url);
    var onlineClassList=title+school+date+url;
    $(".onlineClass-entry:last").append(onlineClassList);
}

//project object
var project={
    "projects":[
    {
        "title": "HTML and CSS",
        "date":"10-11-2016",
        "description":"E-commerce project build for Jamsons which helps to get into online business",
        "url":"www.jamsons.in"
    }]
};

projects.display=function(){
$("#projects").append(HTMLprojectStart);
for (var i = 0; i < project.projects.length; i++) {
    var title=HTMLprojectTitle.replace("%data%", project.projects[i].title);
    var date=HTMLprojectDates.replace("%data%", project.projects[i].date);
    var description=HTMLprojectDescription.replace("%data%", project.projects[i].description);
    var url=HTMLprojectImage.replace("%data%", project.projects[i].url);
    var projectsList=title+date+description+url;
    $(".project-entry:last").append(projectsList);
}
}
//showing encapsulation example,calling project function projects.display()
projects.display();

//internationlization button
$("#header").append(internationalizeButton);
function inName(name){
    name=name.split(" ");
    console.log(name);
    name[1]=name[1].toUpperCase();
    name[0]=name[0].slice(0,1).toUpperCase() + name[0].slice(1).toLowerCase();
    return name[0] + " " + name[1];
}

//google map
$("#mapDiv").append(googleMap);