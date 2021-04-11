namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class F3Models : DbContext
    {
        public F3Models()
            : base("name=DBF3Connection")
        {
        }

        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<AnnouncementLocation> AnnouncementLocations { get; set; }
        public virtual DbSet<AnnouncementType> AnnouncementTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Consultant> Consultants { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<NewsContent> NewsContents { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PositionAd> PositionAds { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shop_Attributes> Shop_Attributes { get; set; }
        public virtual DbSet<Shop_Attributes_Vals> Shop_Attributes_Vals { get; set; }
        public virtual DbSet<Shop_Category> Shop_Category { get; set; }
        public virtual DbSet<Shop_Department> Shop_Department { get; set; }
        public virtual DbSet<Shop_Product> Shop_Product { get; set; }
        public virtual DbSet<Shop_Product_Has_Vals> Shop_Product_Has_Vals { get; set; }
        public virtual DbSet<Shop_ProductCategory> Shop_ProductCategory { get; set; }
        public virtual DbSet<Shop_ProductType> Shop_ProductType { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Videoclip> Videoclips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnnouncementLocation>()
                .HasMany(e => e.Announcements)
                .WithOptional(e => e.AnnouncementLocation)
                .WillCascadeOnDelete();

            modelBuilder.Entity<AnnouncementType>()
                .HasMany(e => e.Announcements)
                .WithOptional(e => e.AnnouncementType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionAd>()
                .HasMany(e => e.Ads)
                .WithOptional(e => e.PositionAd)
                .HasForeignKey(e => e.PositionId);

            modelBuilder.Entity<Shop_Attributes>()
                .HasMany(e => e.Shop_Attributes_Vals)
                .WithOptional(e => e.Shop_Attributes)
                .HasForeignKey(e => e.attr_id);

            modelBuilder.Entity<Shop_Attributes>()
                .HasMany(e => e.Shop_Product_Has_Vals)
                .WithOptional(e => e.Shop_Attributes)
                .HasForeignKey(e => e.attr_id);

            modelBuilder.Entity<Shop_Attributes_Vals>()
                .HasMany(e => e.Shop_Product_Has_Vals)
                .WithOptional(e => e.Shop_Attributes_Vals)
                .HasForeignKey(e => e.val_id);

            modelBuilder.Entity<Shop_Category>()
                .HasMany(e => e.Shop_ProductCategory)
                .WithRequired(e => e.Shop_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop_Department>()
                .HasMany(e => e.Shop_Category)
                .WithRequired(e => e.Shop_Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop_Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Shop_Product>()
                .Property(e => e.Image1FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Shop_Product>()
                .Property(e => e.Image2FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Shop_Product>()
                .Property(e => e.Image3FileName)
                .IsUnicode(false);

            modelBuilder.Entity<ShoppingCart>()
                .Property(e => e.CartID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Pages)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);
        }
    }
}
