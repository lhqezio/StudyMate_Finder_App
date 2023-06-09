﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using StudyMate.Services;

#nullable disable

namespace StudyMate.Migrations
{
    [DbContext(typeof(StudyMateDbContext))]
    [Migration("20230511191137_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseEvent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("EventsEventId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CoursesCourseId", "EventsEventId");

                    b.HasIndex("EventsEventId");

                    b.ToTable("CourseEvent");
                });

            modelBuilder.Entity("CourseProfile", b =>
                {
                    b.Property<int>("CourseNeedHelpWithCourseId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("StudentsNeedHelpCourseProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseNeedHelpWithCourseId", "StudentsNeedHelpCourseProfileId");

                    b.HasIndex("StudentsNeedHelpCourseProfileId");

                    b.ToTable("CourseProfile");
                });

            modelBuilder.Entity("CourseProfile1", b =>
                {
                    b.Property<int>("CourseTakenCourseId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("StudentsTakingCourseProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseTakenCourseId", "StudentsTakingCourseProfileId");

                    b.HasIndex("StudentsTakingCourseProfileId");

                    b.ToTable("CourseProfile1");
                });

            modelBuilder.Entity("CourseProfile2", b =>
                {
                    b.Property<int>("CourseCanHelpWithCourseId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("StudentsTutoringCourseProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CourseCanHelpWithCourseId", "StudentsTutoringCourseProfileId");

                    b.HasIndex("StudentsTutoringCourseProfileId");

                    b.ToTable("CourseProfile2");
                });

            modelBuilder.Entity("EventProfile", b =>
                {
                    b.Property<int>("ParticipantEventsEventId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ParticipantsProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ParticipantEventsEventId", "ParticipantsProfileId");

                    b.HasIndex("ParticipantsProfileId");

                    b.ToTable("EventProfile");
                });

            modelBuilder.Entity("HobbyProfile", b =>
                {
                    b.Property<int>("HobbiesHobbyId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProfilesProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("HobbiesHobbyId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("HobbyProfile");
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

                    b.ToTable("StudyMate_Messages");
                });

            modelBuilder.Entity("StudyMate.Models.Conversation", b =>
                {
                    b.Property<string>("ConversationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConversationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ConversationId");

                    b.ToTable("StudyMate_Conversations");
                });

            modelBuilder.Entity("StudyMate.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CourseId");

                    b.ToTable("StudyMate_Courses");
                });

            modelBuilder.Entity("StudyMate.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTimeOffset?>("Date")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsSent")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EventId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SchoolId");

                    b.ToTable("StudyMate_Events");
                });

            modelBuilder.Entity("StudyMate.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyId"));

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("HobbyId");

                    b.ToTable("StudyMate_Hobbies");
                });

            modelBuilder.Entity("StudyMate.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"));

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

                    b.Property<int?>("SchoolId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("ProfileId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("StudyMate_Profiles");
                });

            modelBuilder.Entity("StudyMate.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("SchoolId");

                    b.ToTable("StudyMate_Schools");
                });

            modelBuilder.Entity("StudyMate.Models.User", b =>
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

                    b.ToTable("StudyMate_Users");
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

            modelBuilder.Entity("CourseEvent", b =>
                {
                    b.HasOne("StudyMate.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseProfile", b =>
                {
                    b.HasOne("StudyMate.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseNeedHelpWithCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("StudentsNeedHelpCourseProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseProfile1", b =>
                {
                    b.HasOne("StudyMate.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseTakenCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("StudentsTakingCourseProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseProfile2", b =>
                {
                    b.HasOne("StudyMate.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseCanHelpWithCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("StudentsTutoringCourseProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventProfile", b =>
                {
                    b.HasOne("StudyMate.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("ParticipantEventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HobbyProfile", b =>
                {
                    b.HasOne("StudyMate.Models.Hobby", null)
                        .WithMany()
                        .HasForeignKey("HobbiesHobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyMate.Models.Event", b =>
                {
                    b.HasOne("StudyMate.Models.Profile", "Creator")
                        .WithMany("CreatorEvents")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.School", "School")
                        .WithMany("EventsForSchool")
                        .HasForeignKey("SchoolId");

                    b.Navigation("Creator");

                    b.Navigation("School");
                });

            modelBuilder.Entity("StudyMate.Models.Profile", b =>
                {
                    b.HasOne("StudyMate.Models.School", "School")
                        .WithMany("ProfilsForSchool")
                        .HasForeignKey("SchoolId");

                    b.HasOne("StudyMate.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("StudyMate.Models.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserConversation", b =>
                {
                    b.HasOne("StudyMate.Models.Conversation", null)
                        .WithMany()
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyMate.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyMate.Models.Profile", b =>
                {
                    b.Navigation("CreatorEvents");
                });

            modelBuilder.Entity("StudyMate.Models.School", b =>
                {
                    b.Navigation("EventsForSchool");

                    b.Navigation("ProfilsForSchool");
                });

            modelBuilder.Entity("StudyMate.Models.User", b =>
                {
                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
