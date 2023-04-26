using StudyMate;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyMateTests;

[TestClass]
public class EventCalendarTest
{
    [TestMethod]
    public void TestEventCalendarConstructor(){//Test 1 
        //Arrange
        School sch1 = new School("Dawson College");
        School sch2 = new School("Henri-Bourassa");
        School sch3 = new School("Saint-Ex");
            //Users
        User user1 = new User("Alain", "alain@hotmail.com", "password");
        User user2 = new User("Sam", "sam@hotmail.com", "password1");
        User user3 = new User("Jack", "jack@hotmail.com", "password2");
            //userLis list
        List<User> userList = new List<User>();
        userList.Add(user2);
        userList.Add(user3);
        DateTimeOffset dTime = DateTimeOffset.Now.AddMonths(1);
        bool sent = false;
        string description = "Study with the homies";
            //Courses
        List<CourseEvent> eventCourses = new List<CourseEvent>();
        CourseEvent ce1 = new CourseEvent(Courses.Math);
        CourseEvent ce2 = new CourseEvent(Courses.Sciences);
        CourseEvent ce3 = new CourseEvent(Courses.Business);
        eventCourses.Add(ce1);
        eventCourses.Add(ce2);
        eventCourses.Add(ce3);
        School schoolList = sch1;
        string location = "Montreal";

        //Act
        EventCalendar eC = new EventCalendar("Title1", user1, userList, dTime, description, schoolList, eventCourses, location, sent);
        
        //Assert
        Assert.AreEqual("Title1", eC.Title);
        Assert.AreEqual(user1, eC.EventCreator);
        Assert.AreEqual(userList, eC.Participants);
        Assert.AreEqual(dTime, eC.Date);
        Assert.AreEqual(description, eC.Description);
        Assert.AreEqual(sent, eC.IsSent);
        Assert.AreEqual(eventCourses, eC.CourseEvents);
        Assert.AreEqual(schoolList, eC.School);
        Assert.IsInstanceOfType(eC, typeof(EventCalendar));
    }

    [TestMethod]
    public void TestEventCalendarAddParticipant(){//Test 2
        //Arrange
        School sch1 = new School("Dawson College");
        School sch2 = new School("Henri-Bourassa");
        School sch3 = new School("Saint-Ex");
            //Users
        User user1 = new User("Alain", "alain@hotmail.com", "password");
        User user2 = new User("Sam", "sam@hotmail.com", "password1");
        User user3 = new User("Jack", "jack@hotmail.com", "password2");
            //userLis list
        List<User> userList = new List<User>();
        userList.Add(user2);
        DateTimeOffset dTime = DateTimeOffset.Now.AddMonths(1);
        bool sent = false;
        string description = "Study with the homies";
            //Courses
        List<CourseEvent> eventCourses = new List<CourseEvent>();
        CourseEvent ce1 = new CourseEvent(Courses.Math);
        CourseEvent ce2 = new CourseEvent(Courses.Sciences);
        CourseEvent ce3 = new CourseEvent(Courses.Business);
        eventCourses.Add(ce1);
        eventCourses.Add(ce2);
        eventCourses.Add(ce3);
        School schoolList = sch1;
        string location = "Montreal";

        //Act
        EventCalendar eC = new EventCalendar("Title1", user1, userList, dTime, description, schoolList, eventCourses, location, sent);
            //Add user3 to Event
        eC.AddParticipant(user3); 
            //Add user3 to profileList
        userList.Add(user3);

        //Assert
        Assert.AreEqual(userList, eC.Participants);
    }

    [TestMethod]
    public void TestEventCalendarRemoveParticipant(){//Test 3
        //Arrange
        School sch1 = new School("Dawson College");
        School sch2 = new School("Henri-Bourassa");
        School sch3 = new School("Saint-Ex");
            //Users
        User user1 = new User("Alain", "alain@hotmail.com", "password");
        User user2 = new User("Sam", "sam@hotmail.com", "password1");
        User user3 = new User("Jack", "jack@hotmail.com", "password2");
            //userLis list
        List<User> userList = new List<User>();
        userList.Add(user2);
        userList.Add(user3);
        DateTimeOffset dTime = DateTimeOffset.Now.AddMonths(1);
        bool sent = false;
        string description = "Study with the homies";
            //Courses
        List<CourseEvent> eventCourses = new List<CourseEvent>();
        CourseEvent ce1 = new CourseEvent(Courses.Math);
        CourseEvent ce2 = new CourseEvent(Courses.Sciences);
        CourseEvent ce3 = new CourseEvent(Courses.Business);
        eventCourses.Add(ce1);
        eventCourses.Add(ce2);
        eventCourses.Add(ce3);
        School schoolList = sch1;
        string location = "Montreal";

        //Act
            //Contains user3
        EventCalendar eC = new EventCalendar("Title1", user1, userList, dTime, description, schoolList, eventCourses, location, sent);
            //Removed user3 to Event
        eC.RemoveParticipant(user3); 
            //Removed user3 to userList
        userList.Remove(user3);

        //Assert
        Assert.AreEqual(userList, eC.Participants);
    }

    // [TestMethod]
    // public void TestEventCalendarAttends(){//Test 4
    //     //Arrange
    //     School sch1 = new School("Dawson College");
    //     School sch2 = new School("Henri-Bourassa");
    //     School sch3 = new School("Saint-Ex");
    //         //Users
    //     UserDB user1 = new UserDB("Alain", "alain@hotmail.com", "password");
    //     UserDB user2 = new UserDB("Sam", "sam@hotmail.com", "password1");
    //     UserDB user3 = new UserDB("Jack", "jack@hotmail.com", "password2");
    //         //Profile
    //     Profile profile1 = new Profile("Alain", 15, sch1, new List<NeedHelpCourses>(){new NeedHelpCourses(Courses.History)}, user1);
    //     Profile profile2 = new Profile("Sam", 20, sch2, new List<NeedHelpCourses>(){new NeedHelpCourses(Courses.Art)}, user2);
    //     Profile profile3 = new Profile("Jack", 18, sch3, new List<NeedHelpCourses>(){new NeedHelpCourses(Courses.Calculus)}, user3); 
    //         //Profile list
    //     List<Profile> profileList = new List<Profile>();
    //     profileList.Add(profile2);
    //     profileList.Add(profile3);
    //     DateTimeOffset dTime = DateTimeOffset.Now.AddMonths(1);
    //     bool sent = false;
    //     string description = "Study with the homies";
    //         //Courses
    //     List<CourseEvent> eventCourses = new List<CourseEvent>();
    //     CourseEvent ce1 = new CourseEvent(Courses.Math);
    //     CourseEvent ce2 = new CourseEvent(Courses.Sciences);
    //     CourseEvent ce3 = new CourseEvent(Courses.Business);
    //     eventCourses.Add(ce1);
    //     eventCourses.Add(ce2);
    //     eventCourses.Add(ce3);
    //     School schoolList = sch1;
    //     string location = "Montreal";

    //     //Act
    //     EventCalendar eC = new EventCalendar("Title1", profile1, profileList, dTime, description, schoolList, eventCourses, location, sent); 

    //     //Assert
    //     Assert.IsTrue(eC.Attends(profile2));
    //     Assert.IsTrue(eC.Attends(profile3));
    // }
}

