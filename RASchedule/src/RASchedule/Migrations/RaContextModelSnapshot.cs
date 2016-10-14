using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RASchedule.Models;

namespace RASchedule.Migrations
{
    [DbContext(typeof(RaContext))]
    partial class RaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RASchedule.Models.Duty", b =>
                {
                    b.Property<int>("dutyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DutyDays");

                    b.Property<int>("userId");

                    b.HasKey("dutyId");

                    b.HasIndex("userId");

                    b.ToTable("Duties");
                });

            modelBuilder.Entity("RASchedule.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RASchedule.Models.Duty", b =>
                {
                    b.HasOne("RASchedule.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
