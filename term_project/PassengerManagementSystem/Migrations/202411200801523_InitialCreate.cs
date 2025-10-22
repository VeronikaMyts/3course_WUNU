namespace PassengerManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        CarrierID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CarrierID);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourID = c.Int(nullable: false, identity: true),
                        DepartureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        RouteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourID)
                .ForeignKey("dbo.Routes", t => t.RouteID, cascadeDelete: true)
                .Index(t => t.RouteID);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        RouteID = c.Int(nullable: false, identity: true),
                        StartCity = c.String(),
                        EndCity = c.String(),
                    })
                .PrimaryKey(t => t.RouteID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        PassengerID = c.Int(nullable: false),
                        TourID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsBooked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Passengers", t => t.PassengerID, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.TourID, cascadeDelete: true)
                .Index(t => t.PassengerID)
                .Index(t => t.TourID);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        PassengerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PassportNumber = c.String(),
                        Email = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.PassengerID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.TourCarriers",
                c => new
                    {
                        Tour_TourID = c.Int(nullable: false),
                        Carrier_CarrierID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tour_TourID, t.Carrier_CarrierID })
                .ForeignKey("dbo.Tours", t => t.Tour_TourID, cascadeDelete: true)
                .ForeignKey("dbo.Carriers", t => t.Carrier_CarrierID, cascadeDelete: true)
                .Index(t => t.Tour_TourID)
                .Index(t => t.Carrier_CarrierID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "TourID", "dbo.Tours");
            DropForeignKey("dbo.Tickets", "PassengerID", "dbo.Passengers");
            DropForeignKey("dbo.Tours", "RouteID", "dbo.Routes");
            DropForeignKey("dbo.TourCarriers", "Carrier_CarrierID", "dbo.Carriers");
            DropForeignKey("dbo.TourCarriers", "Tour_TourID", "dbo.Tours");
            DropIndex("dbo.TourCarriers", new[] { "Carrier_CarrierID" });
            DropIndex("dbo.TourCarriers", new[] { "Tour_TourID" });
            DropIndex("dbo.Tickets", new[] { "TourID" });
            DropIndex("dbo.Tickets", new[] { "PassengerID" });
            DropIndex("dbo.Tours", new[] { "RouteID" });
            DropTable("dbo.TourCarriers");
            DropTable("dbo.Users");
            DropTable("dbo.Passengers");
            DropTable("dbo.Tickets");
            DropTable("dbo.Routes");
            DropTable("dbo.Tours");
            DropTable("dbo.Carriers");
        }
    }
}
