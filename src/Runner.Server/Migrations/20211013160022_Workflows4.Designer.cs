﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Runner.Server.Models;

namespace Runner.Server.Migrations
{
    [DbContext(typeof(SqLiteDb))]
    [Migration("20211013160022_Workflows4")]
    partial class Workflows4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.AgentLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TaskAgentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskAgentId");

                    b.ToTable("AgentLabel");
                });

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.TaskAgentPool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgentCloudId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("AutoProvision")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("AutoSize")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHosted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsLegacy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PoolType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Scope")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TargetSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TaskAgentPool");
                });

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.TaskAgentReference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessPoint")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Ephemeral")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OSDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvisioningState")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TaskAgentReference");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TaskAgentReference");
                });

            modelBuilder.Entity("OwnerPool", b =>
                {
                    b.Property<long>("OwnersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PoolsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OwnersId", "PoolsId");

                    b.HasIndex("PoolsId");

                    b.ToTable("OwnerPool");
                });

            modelBuilder.Entity("Runner.Server.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Exponent")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Modulus")
                        .HasColumnType("BLOB");

                    b.Property<int?>("PoolId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TaskAgentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.HasIndex("TaskAgentId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AttemptId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AttemptId");

                    b.ToTable("ArtifactContainer");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactFileContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContainerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.ToTable("ArtifactFileContainer");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileContainerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("GZip")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileContainerId");

                    b.ToTable("ArtifactRecord");
                });

            modelBuilder.Entity("Runner.Server.Models.Job", b =>
                {
                    b.Property<Guid>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("CancelTimeoutMinutes")
                        .HasColumnType("REAL");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ContinueOnError")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RequestId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TimeLineId")
                        .HasColumnType("TEXT");

                    b.Property<double>("TimeoutMinutes")
                        .HasColumnType("REAL");

                    b.Property<int?>("WorkflowRunAttemptId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("repo")
                        .HasColumnType("TEXT");

                    b.Property<long>("runid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("workflowname")
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.HasIndex("WorkflowRunAttemptId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Runner.Server.Models.Owner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrivateKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("Runner.Server.Models.Pool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TaskAgentPoolId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskAgentPoolId");

                    b.ToTable("Pools");
                });

            modelBuilder.Entity("Runner.Server.Models.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WorkflowId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowRun");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRunAttempt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Attempt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EventName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventPayload")
                        .HasColumnType("TEXT");

                    b.Property<string>("Workflow")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkflowRunId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowRunId");

                    b.ToTable("WorkflowRunAttempt");
                });

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.TaskAgent", b =>
                {
                    b.HasBaseType("GitHub.DistributedTask.WebApi.TaskAgentReference");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MaxParallelism")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StatusChangedOn")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("TaskAgent");
                });

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.AgentLabel", b =>
                {
                    b.HasOne("GitHub.DistributedTask.WebApi.TaskAgent", null)
                        .WithMany("Labels")
                        .HasForeignKey("TaskAgentId");
                });

            modelBuilder.Entity("OwnerPool", b =>
                {
                    b.HasOne("Runner.Server.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Runner.Server.Models.Pool", null)
                        .WithMany()
                        .HasForeignKey("PoolsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Runner.Server.Models.Agent", b =>
                {
                    b.HasOne("Runner.Server.Models.Pool", "Pool")
                        .WithMany("Agents")
                        .HasForeignKey("PoolId");

                    b.HasOne("GitHub.DistributedTask.WebApi.TaskAgent", "TaskAgent")
                        .WithMany()
                        .HasForeignKey("TaskAgentId");

                    b.Navigation("Pool");

                    b.Navigation("TaskAgent");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactContainer", b =>
                {
                    b.HasOne("Runner.Server.Models.WorkflowRunAttempt", "Attempt")
                        .WithMany("Artifacts")
                        .HasForeignKey("AttemptId");

                    b.Navigation("Attempt");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactFileContainer", b =>
                {
                    b.HasOne("Runner.Server.Models.ArtifactContainer", "Container")
                        .WithMany("FileContainer")
                        .HasForeignKey("ContainerId");

                    b.Navigation("Container");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactRecord", b =>
                {
                    b.HasOne("Runner.Server.Models.ArtifactFileContainer", "FileContainer")
                        .WithMany("Files")
                        .HasForeignKey("FileContainerId");

                    b.Navigation("FileContainer");
                });

            modelBuilder.Entity("Runner.Server.Models.Job", b =>
                {
                    b.HasOne("Runner.Server.Models.WorkflowRunAttempt", "WorkflowRunAttempt")
                        .WithMany("Jobs")
                        .HasForeignKey("WorkflowRunAttemptId");

                    b.Navigation("WorkflowRunAttempt");
                });

            modelBuilder.Entity("Runner.Server.Models.Pool", b =>
                {
                    b.HasOne("GitHub.DistributedTask.WebApi.TaskAgentPool", "TaskAgentPool")
                        .WithMany()
                        .HasForeignKey("TaskAgentPoolId");

                    b.Navigation("TaskAgentPool");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRun", b =>
                {
                    b.HasOne("Runner.Server.Models.Workflow", "Workflow")
                        .WithMany("Runs")
                        .HasForeignKey("WorkflowId");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRunAttempt", b =>
                {
                    b.HasOne("Runner.Server.Models.WorkflowRun", "WorkflowRun")
                        .WithMany("Attempts")
                        .HasForeignKey("WorkflowRunId");

                    b.Navigation("WorkflowRun");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactContainer", b =>
                {
                    b.Navigation("FileContainer");
                });

            modelBuilder.Entity("Runner.Server.Models.ArtifactFileContainer", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("Runner.Server.Models.Pool", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("Runner.Server.Models.Workflow", b =>
                {
                    b.Navigation("Runs");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRun", b =>
                {
                    b.Navigation("Attempts");
                });

            modelBuilder.Entity("Runner.Server.Models.WorkflowRunAttempt", b =>
                {
                    b.Navigation("Artifacts");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("GitHub.DistributedTask.WebApi.TaskAgent", b =>
                {
                    b.Navigation("Labels");
                });
#pragma warning restore 612, 618
        }
    }
}
