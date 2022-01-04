using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('PJ''s Coffee of New Orleans',                 '9-5 Mon-Sat',              '9079 West Locust St. Buffalo, NY 14221')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Victory Sweet Shop/Victory Garden Cafe',      '7AM-7PM Mon-Fri',          '51 W. Myers Avenue Brooklyn, NY 11201')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Kaffe Landskap NYC (South)',                  '24/7',                     '25 Whitemarsh Court Jamaica, NY 11435')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Culture Espresso',                            '9-5 Mon-Fri',              '8945 Newbridge Street New York, NY 10024')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Manon Cafe',                                  '6AM-4PM Mon-Sat',          '16 Woodsman Lane Jamaica, NY 11432')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Café-Flor',                                   '7:30AM-5:30PM Mon-Sat',    '21 Airport St. Brooklyn, NY 11221')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Bluestone Lane Times Square Coffee Shop',     '4:30AM-2:00PM Mon-Sun',    '9611 Bradford Dr. Flushing, NY 11354')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('In Common NYC Cafe',                          '24/7',                     '339 1st Ave. Brooklyn, NY 11228')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Bird & Branch',                               '6AM-7PM Mon-Fri',          '393 Pearl Street Buffalo, NY 14221')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) VALUES ('Coffee Project New York',                     '8-6 Mon-Sat',              '7998 Vermont Street Astoria, NY 11106')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
