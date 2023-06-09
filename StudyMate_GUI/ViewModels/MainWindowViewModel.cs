﻿using System;
using System.Reactive.Linq;
using ReactiveUI;
using StudyMate.Models;
using System.Reactive;
using StudyMate.Services;
using System.Collections.Generic;

namespace StudyMate.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _content;
        private Boolean _visibleNavigation;
        private User? LoggedInUser;
        StudyMateDbContext context = new StudyMateDbContext();
        public Boolean VisibleNavigation
        {
            get => _visibleNavigation;
            private set => this.RaiseAndSetIfChanged(ref _visibleNavigation, value);
        }

        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public ReactiveCommand<Unit, Unit> Profile { get; }
        public ReactiveCommand<Unit, Unit> NewEvent { get; }
        public ReactiveCommand<Unit, Unit> Search { get; }
        public ReactiveCommand<Unit, Unit> Message { get; }
        public ReactiveCommand<Unit, Unit> Logout { get; }

        public MainWindowViewModel()
        {
            Profile = ReactiveCommand.Create(() => {ShowPersonalProfile();});
            NewEvent =  ReactiveCommand.Create(() => {CreateEvent();});
            Search  = ReactiveCommand.Create(() => {OpenSearch();});
            Message = ReactiveCommand.Create(() => {OpenMessages();});
            Logout = ReactiveCommand.Create(() => {ShowLogin();});
            var u = new User("100","df","happy@lol.com","1");
            var p = new Profile(u, "John Doe", "Male", new School(), new List<Course>(), new List<Course>(), new List<Course>(), new List<Hobby>(), 20, "Computer Science", "I am a computer science student");

            var p2 = new Profile(u, "Amir", "Male", new School(), new List<Course>(), new List<Course>(), new List<Course>(), new List<Hobby>(), 20, "Computer Science", "I am a computer science student");
            var p3 = new Profile(u, "Jack", "Male", new School(), new List<Course>(), new List<Course>(), new List<Course>(), new List<Hobby>(), 20, "Computer Science", "I am a computer science student");
            var p4 = new Profile(u, "Frank", "Male", new School(), new List<Course>(), new List<Course>(), new List<Course>(), new List<Hobby>(), 20, "Computer Science", "I am a computer science student");
            var e = new Event(p,"this is a title",new DateTimeOffset(new DateTime(2023, 5, 15)), "this is a description","Montreal","All are subjects",new List<Course>(),new School("Jordan"));
            e.Participants=new List<Profile>(){p2,p3,p4};
            // DisplayEvent(e);
            ShowLogin();
        }

        private void ShowLogin(bool isLoginFailed = false){
            VisibleNavigation = false;
            LogInViewModel vm = new LogInViewModel(context);
            vm.IsLoginFailed = isLoginFailed;
            vm.Register = ReactiveCommand.Create(() => {ShowRegister();});
            vm.Login.Subscribe(x => {PrepareMainPage(vm.LoginUser());});
            Content = vm;
        }

        private void ShowRegister(){
            VisibleNavigation = false;
            var vm = new RegisterViewModel(context);
            vm.Register.Subscribe(x => {ShowLogin();});
            vm.Login = ReactiveCommand.Create(() => {ShowLogin();});
            Content = vm;
        }

        public void PrepareMainPage(User u){
            LoggedInUser = u;
            if (u == null)
            {
                ShowLogin(true);
                return;
            }
            VisibleNavigation = true;
            ShowPersonalProfile();
        }

        //Show profile of logged in user
        private void ShowPersonalProfile()
        {
            if (LoggedInUser == null)
            {   
                throw new Exception("User not logged in");
            }
            var search=new SearchServices(context);
            Profile? p = search.GetProfileByUserId(LoggedInUser.UserId);
            if (p == null)
            {
                CreatePersonalProfile(LoggedInUser);
            }else{
                DisplayProfile(p);
            }
        }

        private void CreatePersonalProfile(User u){
            CreateProfileViewModel cp = new CreateProfileViewModel(u);
            Content=cp;
        }

        //Show profile of a specified user
        private void DisplayProfile(Profile p)
        {
            Content = new ProfileDisplayViewModel(p);
        }

        //Navigate to edit profile view from profile display view
        public void EditProfile()
        {
            ProfileDisplayViewModel dispvm = (ProfileDisplayViewModel) Content;
            var vm = new ProfileEditViewModel(dispvm.Profile);
            
            vm.Ok.Subscribe(x => {Content = dispvm;});
            Content = vm;
        }

        public void ChangePassword(){
             using(var db = new StudyMateDbContext()){
                SearchServices s = new SearchServices(db);
                Profile? p = s.GetProfileByUserId(this.LoggedInUser.UserId);
                ChangePasswordViewModel cpvm = new ChangePasswordViewModel(p);
                Content=cpvm;
                cpvm.Change.Subscribe(x => {Content=new ProfileDisplayViewModel(p);});
            }
        }

        public void DeleteProfile(){
            using(var db = new StudyMateDbContext()){
                ProfileDisplayViewModel dispvm = (ProfileDisplayViewModel) Content;
                ProfileServices p = new ProfileServices(db);
                p.DeleteProfile(dispvm.Profile);
            }
            ShowLogin();
            return;
        }

        public void DeleteEvent(){
            using(var db = new StudyMateDbContext()){
                EventDisplayViewModel edvm = (EventDisplayViewModel) Content;
                EventServices eventServices = new EventServices(db);
                eventServices.DeleteEvent(edvm.Event);
                SearchServices s = new SearchServices(db);
                Profile? p = s.GetProfileByUserId(this.LoggedInUser.UserId);
                Content=new ProfileDisplayViewModel(p);
            }
        }

        //Create and display a new event
        private void CreateEvent()
        {
            VisibleNavigation = true;
           CreateEventViewModel cp = new CreateEventViewModel(this.LoggedInUser);
           Content=cp;
        }

        //Display an existing event
        private void DisplayEvent(Event e){
            VisibleNavigation=true;
            var edv= new EventDisplayViewModel(e);
            Content = edv;
        }

        //Navigate to edit event view from event display view
        public void EditEvent()
        {
            EventDisplayViewModel dispvm = (EventDisplayViewModel) Content;
            var vm = new EventEditViewModel(dispvm.Event,context,this.LoggedInUser);
            
            vm.Ok.Subscribe(x => {Content = dispvm;});
            Content = vm;
        }

        //Navigate to message view
        private void OpenMessages()
        {
            Content = new ChatViewModel(LoggedInUser);
        }

        //Navigate to search view
        private void OpenSearch()
        {
            Content = new SearchViewModel();
        }

    }
}