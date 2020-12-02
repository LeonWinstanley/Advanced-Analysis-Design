﻿// <auto-generated />
using System;
using AdvancedAnalysisDesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedAnalysisDesign.Migrations
{
    [DbContext(typeof(AADContext))]
    partial class AADContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("BloodworkRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NhsNumber")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<byte[]>("VerificationImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientBloodwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset>("DateOfResults")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("PatientMedicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientMedicationId");

                    b.ToTable("PatientBloodworks");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientBloodworkTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int?>("PatientBloodworkId")
                        .HasColumnType("int");

                    b.Property<string>("Results")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientBloodworkId");

                    b.ToTable("PatientBloodworkTests");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientMedication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<TimeSpan>("DateIntervalOfBloodworkRenewal")
                        .HasColumnType("time");

                    b.Property<int?>("MedicationId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicationId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientMedications");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserDetailId")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.Patient", b =>
                {
                    b.HasOne("AdvancedAnalysisDesign.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientBloodwork", b =>
                {
                    b.HasOne("AdvancedAnalysisDesign.Models.PatientMedication", null)
                        .WithMany("PatientBloodworks")
                        .HasForeignKey("PatientMedicationId");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientBloodworkTest", b =>
                {
                    b.HasOne("AdvancedAnalysisDesign.Models.PatientBloodwork", null)
                        .WithMany("PatientBloodworkTests")
                        .HasForeignKey("PatientBloodworkId");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientMedication", b =>
                {
                    b.HasOne("AdvancedAnalysisDesign.Models.Medication", "Medication")
                        .WithMany()
                        .HasForeignKey("MedicationId");

                    b.HasOne("AdvancedAnalysisDesign.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Medication");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.User", b =>
                {
                    b.HasOne("AdvancedAnalysisDesign.Models.UserDetail", "UserDetail")
                        .WithMany()
                        .HasForeignKey("UserDetailId");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientBloodwork", b =>
                {
                    b.Navigation("PatientBloodworkTests");
                });

            modelBuilder.Entity("AdvancedAnalysisDesign.Models.PatientMedication", b =>
                {
                    b.Navigation("PatientBloodworks");
                });
#pragma warning restore 612, 618
        }
    }
}
