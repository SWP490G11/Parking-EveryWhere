using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Back_end.Helper
{
    using BCrypt = BCrypt.Net.BCrypt;
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected ParkingDbContext()
        {
        }

        

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }

        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Dashboard> Dashboards { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<Parking> Parkings { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<MembershipPackage> MembershipPackages { get; set; }
        public virtual DbSet<Request> Requests { get; set; }

        public virtual DbSet<ParkingDetail> ParkingDetails { get; set; }

        public virtual DbSet<Transaction> Transactions  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

            modelBuilder.Entity<User>()
        .HasKey(e => e.ID)
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Car>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Parking>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Request>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<ParkingDetail>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<CarModel>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Dashboard>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Image>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<MembershipPackage>()
        .HasKey(e => e.ID)
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Slot>()
 .HasKey(e => e.ID)
 .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity<User>(
                u=>u.HasData(
                    UserSeed.Seed
                    )
                );

            modelBuilder.Entity<MembershipPackage>(
               u => u.HasData(
                   MembershipPagekageSeed.Seed
                   )
               );

            modelBuilder.Entity<CarModel>(
              u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "Xe 2 khoang",  Model = "Mini"} })

              );
            modelBuilder.Entity<CarModel>(
             u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "Xe 4 chỗ du lịch", Model = "Sedan" } })

             );
            modelBuilder.Entity<CarModel>(
             u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "xe 5 chỗ", Model = "SUV5"} })

             );
            modelBuilder.Entity<CarModel>(
             u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "Xe van con",  Model = "Minivan" } })

             );
            modelBuilder.Entity<CarModel>(
             u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "Xe bán tải",  Model = "Pickup"} })

             );
            modelBuilder.Entity<CarModel>(
            u => u.HasData(new List<CarModel>() {
                    new CarModel { Discript = "Xe 7 chỗ",  Model = "SUV7" } })

            );
            /*modelBuilder.Entity<Parking>(
               u => u.HasData(ParkingSeed.Seed)

               );*/


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var fk in entityType.GetForeignKeys())
                {
                    fk.DeleteBehavior = DeleteBehavior.NoAction;
                }
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}
