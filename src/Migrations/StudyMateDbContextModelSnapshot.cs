﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using StudyMate;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(StudyMateDbContext))]
    partial class StudyMateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CanHelpCoursesProfile", b =>
                {
                    b.Property<string>("CanHelpCoursesCourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfilesProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("CanHelpCoursesCourseId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("CanHelpCoursesProfile");
                });

            modelBuilder.Entity("CourseEventEventCalendar", b =>
                {
                    b.Property<string>("CourseEventsCourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("EventsEventId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("CourseEventsCourseId", "EventsEventId");

                    b.HasIndex("EventsEventId");

                    b.ToTable("CourseEventEventCalendar");
                });

            modelBuilder.Entity("EventCalendarProfile", b =>
                {
                    b.Property<string>("EventsEventId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ParticipantsProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("EventsEventId", "ParticipantsProfileId");

                    b.HasIndex("ParticipantsProfileId");

                    b.ToTable("EventCalendarProfile");
                });

            modelBuilder.Entity("InterestsProfileProfile", b =>
                {
                    b.Property<string>("HobbiesInterestId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfilesProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("HobbiesInterestId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("InterestsProfileProfile");
                });

            modelBuilder.Entity("NeedHelpCoursesProfile", b =>
                {
                    b.Property<string>("NeedHelpCoursesCourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("profilesProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("NeedHelpCoursesCourseId", "profilesProfileId");

                    b.HasIndex("profilesProfileId");

                    b.ToTable("NeedHelpCoursesProfile");
                });

            modelBuilder.Entity("ProfileTakenCourses", b =>
                {
                    b.Property<string>("ProfilesProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("TakenCoursesCourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("ProfilesProfileId", "TakenCoursesCourseId");

                    b.HasIndex("TakenCoursesCourseId");

                    b.ToTable("ProfileTakenCourses");
                });

            modelBuilder.Entity("StudyMate.CanHelpCourses", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("Course")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseId");

                    b.ToTable("CanHelpCourses");
                });

            modelBuilder.Entity("StudyMate.CourseEvent", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("Course")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseId");

                    b.ToTable("CourseEvent");
                });

            modelBuilder.Entity("StudyMate.EventCalendar", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsSent")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EventId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SchoolId");

                    b.ToTable("EventCalendar");
                });

            modelBuilder.Entity("StudyMate.InterestsProfile", b =>
                {
                    b.Property<string>("InterestId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("Interests")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("InterestId");

                    b.ToTable("InterestsProfile");
                });

            modelBuilder.Entity("StudyMate.NeedHelpCourses", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("Course")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseId");

                    b.ToTable("NeedHelpCourses");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Gender")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PersonalDescription")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ProfileId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("StudyMate.School", b =>
                {
                    b.Property<string>("SchoolId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("SchoolId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("StudyMate.TakenCourses", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("Course")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseId");

                    b.ToTable("TakenCourses");
                });

            modelBuilder.Entity("StudyMate.UserDB", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Salt")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CanHelpCoursesProfile", b =>
                {
                    b.HasOne("StudyMate.CanHelpCourses", null)
                        .WithMany()
                        .HasForeignKey("CanHelpCoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseEventEventCalendar", b =>
                {
                    b.HasOne("StudyMate.CourseEvent", null)
                        .WithMany()
                        .HasForeignKey("CourseEventsCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.EventCalendar", null)
                        .WithMany()
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventCalendarProfile", b =>
                {
                    b.HasOne("StudyMate.EventCalendar", null)
                        .WithMany()
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterestsProfileProfile", b =>
                {
                    b.HasOne("StudyMate.InterestsProfile", null)
                        .WithMany()
                        .HasForeignKey("HobbiesInterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NeedHelpCoursesProfile", b =>
                {
                    b.HasOne("StudyMate.NeedHelpCourses", null)
                        .WithMany()
                        .HasForeignKey("NeedHelpCoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("profilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProfileTakenCourses", b =>
                {
                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.TakenCourses", null)
                        .WithMany()
                        .HasForeignKey("TakenCoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyMate.EventCalendar", b =>
                {
                    b.HasOne("StudyMate.Profile", "EventCreator")
                        .WithMany("EventsCreated")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.School", "School")
                        .WithMany("Events")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventCreator");

                    b.Navigation("School");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.HasOne("StudyMate.School", "School")
                        .WithMany("Profiles")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.Navigation("EventsCreated");
                });

            modelBuilder.Entity("StudyMate.School", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
