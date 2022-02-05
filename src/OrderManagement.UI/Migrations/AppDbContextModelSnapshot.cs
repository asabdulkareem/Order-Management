﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.UI.Models;

namespace OrderManagement.UI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderManagement.UI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Beverages"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Bread/Bakery"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Canned/Jarred Goods"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Dairy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Dry/Baking Goods"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Frozen Foods"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Meat"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Produce"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Cleaners"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Paper Goods"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Personal Care"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("OrderManagement.UI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ImageUrl = "/Images/BNaturalsPomegranate.jpg",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "B Natural Pomegranate Juice is made with the choicest Pomegranate fruits to give you the most authentic product. It contains 100% natural fruit juice, and 0% Concentrate. This delicious fruit juice does not contain any added preservatives, no added flavour. Each sip of B Natural Pomegranate Juice is rich in Vitamin C, and contains the goodness of fiber.",
                            Name = "B Natural 100% Pomegranate Juice 1L",
                            Price = 159.20m,
                            ShortDescription = "Our famous apple Products!"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ImageUrl = "/Images/KarachiBisuits.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Italian Cheese Biscuits are absolutely delightful. These savory drop biscuits are filled with Italian herbs like basil, thyme, oregano and marjoram. They also include sharp cheddar cheese and garlic powder to amp up the flavors. Buy these tasty delicacy from KARACHI BAKERY (Hyderabad)",
                            Name = "Karachi Biscuit",
                            Price = 160m,
                            ShortDescription = "Karachi Bakery Italian Cheese Short Bread Biscuit"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            ImageUrl = "/Images/cheesecake.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Cheese Cake",
                            Price = 200m,
                            ShortDescription = "Plain cheese cake. Plain pleasure."
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            ImageUrl = "/Images/SunfeastBadamMilk.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Treat yourself with an exciting tasteful adventure and discover Wonderz of Milk in every sip. NutShakes Kesar Badam is a wonderful blend of the goodness of nuts and milk. Made with real Badam Bits and Kesar, it promises a delightful experience. This product contains no preservatives and is a source of protein and calcium.",
                            Name = "Sunfeast Badam Milk",
                            Price = 28m,
                            ShortDescription = "Sunfeast Wonderz Milk Badam Flavoured Milk 180ml"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            ImageUrl = "/Images/KnorrSweetCorn.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Knorr has hand-picked the best quality vegetables and mixed it with spices to make delicious Knorr Sweet Corn Chicken Soup. A perfect blend of corn, carrots, cabbage and chinese flavors with real chicken gives it its lip-smacking taste and perfect consistency. Made with 100% real vegetables and no added preservatives, this soup is ready in three simple steps and serves four. So now enjoy Restaurant like delicious Soup at home.Knorr Soups range comprises of 11 delicious flavours of 4 serve soups and 7 flavours of Cup-a-soup. Great taste is in our Nature! Knorr has gone to great lengths to ensure a perfect blend of ingredients and consistency that give you Restaurant like Soup at home.About Knorr:Just like you, we love everything about food, because no delicious meal is cooked without love. Love for carefully selected ingredients, flavours and spices, or the aroma of dinner wafting through your home. Love for the people you feed everyday; your family and friends, relatives and guests, the people that matter to you the most. With Knorr as your cooking partner, you can serve your loved ones nutritious and flavourful meals at home. Soup Fun Fact - The word 'soup' is of Sanskrit origin! It is derived from the su and po, which means good nutrition.",
                            Name = "Knorr Soup",
                            Price = 55m,
                            ShortDescription = "Knorr Sweet Corn Chicken Soup, 42g"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            ImageUrl = "/Images/BorgePepper.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Green manzanilla olives stuffed with spicy pepper paste",
                            Name = "Borges Green Olives",
                            Price = 179m,
                            ShortDescription = "Borges Hot Pepper Stuffed Green Olives, 450g"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            ImageUrl = "/Images/SunbeanCoffee.jpg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Sunbean Nicamalai Gourmet Coffee is an exotic blend of best coffees from Nicaragua and Anamalai. Blended to create an alchemy of great taste and aroma, Sunbean Nicamalai Gourmet Coffee is the culmination of ITC’s 30+ years of experience working with some of the finest coffee in India and across the world. This gourmet coffee blend is crafted by an expert master blender to give our consumers the most luxurious coffee experience.",
                            Name = "Sunbean Coffee",
                            Price = 250m,
                            ShortDescription = "Sunbean Gourmet Coffee Nicamalai 100g"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            ImageUrl = "/Images/Ching's Soup.jpg",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Ching's Instant Manchow Soup, 55g",
                            Name = "Ching's Soup",
                            Price = 40m,
                            ShortDescription = "Ching's Instant Manchow Soup, 55g"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            ImageUrl = "/Images/DiwaliFestiveGiftPacks.jpg",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "With Raksha Bandhan around the corner, shower your blessings to your siblings with special Rakhi Gifts. Give the Gift of Immunity this Season with B Natural Mixed Fruit and Orange which have clinically proven Green Coffee Extract which helps support immunity. It comes in an attractive reusable bag.",
                            Name = "B Natural Immunity Gift Pack",
                            Price = 208m,
                            ShortDescription = "B Natural Immunity Gift Pack"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 6,
                            ImageUrl = "/Images/BBQ Strips.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "The Field Grill brings to you BBQ Strips, these strips are plant-based. It is made with the finest quality ingredients. This is a delicious meat-free addition to any diet. A barbecue flavoured veggie strips with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These strips are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike.",
                            Name = "BBQ Strips - Spicy & Smoky",
                            Price = 399m,
                            ShortDescription = "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2,
                            ImageUrl = "/Images/Tandoori Seekh Kebab.jpg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "The Field Grill brings to you Tandoori Seekh Kebab are plant-based. We help you make your cooking life easy. This is a delicious meat-free addition to any diet. A spicy flavoured veggie kebab with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These kebabs are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike. It has fresh ingredients without any added preservatives and is hygienically packed.",
                            Name = "Tandoori Seekh Kebab",
                            Price = 399m,
                            ShortDescription = "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g"
                        });
                });

            modelBuilder.Entity("OrderManagement.UI.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.OrderDetail", b =>
                {
                    b.HasOne("OrderManagement.UI.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderManagement.UI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.Product", b =>
                {
                    b.HasOne("OrderManagement.UI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("OrderManagement.UI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OrderManagement.UI.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
