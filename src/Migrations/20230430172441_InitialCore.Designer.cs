﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using StudyMate;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(StudyMateDbContext))]
<<<<<<<< HEAD:src/Migrations/20230430174355_Tests.Designer.cs
    [Migration("20230430174355_Tests")]
    partial class Tests
========
    [Migration("20230430172441_InitialCore")]
    partial class InitialCore
>>>>>>>> 2360e5d3713a567ed22a4e083cf4a87423e57a69:src/Migrations/20230430172441_InitialCore.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseEventCalendar", b =>
                {
                    b.Property<string>("CoursesCourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("EventsEventId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("CoursesCourseId", "EventsEventId");

                    b.HasIndex("EventsEventId");

                    b.ToTable("CourseEventCalendar");
                });

            modelBuilder.Entity("EventProfile", b =>
                {
                    b.Property<string>("EventsId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfilesId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("EventsId", "ProfilesId");

                    b.HasIndex("ProfilesId");

                    b.ToTable("EventProfile");
                });

            modelBuilder.Entity("HobbyProfile", b =>
                {
                    b.Property<string>("HobbiesHobbyId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfilesProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("HobbiesHobbyId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("HobbyProfile");
                });

            modelBuilder.Entity("StudyMate.Conversation", b =>
                {
                    b.Property<string>("ConversationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConversationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ConversationId");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("StudyMate.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CourseId");

                    b.ToTable("StudyCourses");
                });

            modelBuilder.Entity("StudyMate.CourseCanHelpWith", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CourseId", "ProfileId");

                    b.HasIndex("ProfileId");

                    b.ToTable("CoursesCanHelpWith");
                });

            modelBuilder.Entity("StudyMate.CourseNeedHelpWith", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CourseId", "ProfileId");

                    b.HasIndex("ProfileId");

                    b.ToTable("CoursesNeedHelpWith");
                });

            modelBuilder.Entity("StudyMate.CourseTaken", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CourseId", "ProfileId");

                    b.HasIndex("ProfileId");

                    b.ToTable("CoursesTaken");
                });

            modelBuilder.Entity("StudyMate.EventCalendar", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CreatorId")
                        .IsRequired()
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

                    b.Property<string>("SchooId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EventId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("SchooId")
                        .IsUnique();

                    b.ToTable("Events");
                });

            modelBuilder.Entity("StudyMate.Hobby", b =>
                {
                    b.Property<string>("HobbyId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("HobbyId");

                    b.ToTable("Hobby");
                });

            modelBuilder.Entity("StudyMate.Message", b =>
                {
                    b.Property<string>("MessageID")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ConversationID")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SenderID")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Sent")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.Property<string>("ProfileId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PersonalDescription")
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
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("ProfileId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("StudyMate.School", b =>
                {
                    b.Property<string>("SchoolId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("StudyMate.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserConversation", b =>
                {
                    b.Property<string>("ConversationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("ConversationId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserConversation");
                });

            modelBuilder.Entity("CourseEventCalendar", b =>
                {
                    b.HasOne("StudyMate.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.EventCalendar", null)
                        .WithMany()
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventProfile", b =>
                {
                    b.HasOne("StudyMate.EventCalendar", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HobbyProfile", b =>
                {
                    b.HasOne("StudyMate.Hobby", null)
                        .WithMany()
                        .HasForeignKey("HobbiesHobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyMate.CourseCanHelpWith", b =>
                {
                    b.HasOne("StudyMate.Course", "Course")
                        .WithMany("CourseCanHelpWith")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", "Profile")
                        .WithMany("CourseCanHelpWith")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("StudyMate.CourseNeedHelpWith", b =>
                {
                    b.HasOne("StudyMate.Course", "Course")
                        .WithMany("CourseNeedHelpWith")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", "Profile")
                        .WithMany("CourseNeedHelpWith")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("StudyMate.CourseTaken", b =>
                {
                    b.HasOne("StudyMate.Course", "Course")
                        .WithMany("courseTaken")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Profile", "Profile")
                        .WithMany("CourseTaken")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("StudyMate.EventCalendar", b =>
                {
                    b.HasOne("StudyMate.Profile", "Creator")
                        .WithMany("CreatorEvents")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.School", "School")
                        .WithOne("Event")
                        .HasForeignKey("StudyMate.EventCalendar", "SchooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("School");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.HasOne("StudyMate.School", "School")
                        .WithMany("Profiles")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("StudyMate.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserConversation", b =>
                {
                    b.HasOne("StudyMate.Conversation", null)
                        .WithMany()
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyMate.Course", b =>
                {
                    b.Navigation("CourseCanHelpWith");

                    b.Navigation("CourseNeedHelpWith");

                    b.Navigation("courseTaken");
                });

            modelBuilder.Entity("StudyMate.Profile", b =>
                {
                    b.Navigation("CourseCanHelpWith");

                    b.Navigation("CourseNeedHelpWith");

                    b.Navigation("CourseTaken");

                    b.Navigation("CreatorEvents");
                });

            modelBuilder.Entity("StudyMate.School", b =>
                {
                    b.Navigation("Event");

                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("StudyMate.User", b =>
                {
                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
