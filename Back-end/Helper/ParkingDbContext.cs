using Back_end.Entities;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Helper
{
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

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<MembershipPackage> MembershipPackages { get; set; }
        public virtual DbSet<Request> Requests { get; set; }

        public virtual DbSet<ParkingPrice> ParkingPrices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

           

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
