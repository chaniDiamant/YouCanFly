using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace YouCanFly.Migrations
{
    public partial class TheFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    ExtraPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Passport = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Passport);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyValue = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationsId);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlanesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NumberOfSeats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlanesId);
                });

            migrationBuilder.CreateTable(
                name: "Terminal",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminal", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerPassport = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerPassport",
                        column: x => x.CustomerPassport,
                        principalTable: "Customers",
                        principalColumn: "Passport",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaneUnit",
                columns: table => new
                {
                    PlanesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    ClassesId = table.Column<int>(nullable: false),
                    PlanesId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneUnit", x => x.PlanesId);
                    table.ForeignKey(
                        name: "FK_PlaneUnit_Classes_ClassName",
                        column: x => x.ClassName,
                        principalTable: "Classes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlaneUnit_Planes_PlanesId1",
                        column: x => x.PlanesId1,
                        principalTable: "Planes",
                        principalColumn: "PlanesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    FlightNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DestinationsId = table.Column<int>(nullable: true),
                    Landing = table.Column<DateTime>(nullable: false),
                    PlanesId = table.Column<int>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    TakeOff = table.Column<DateTime>(nullable: false),
                    TerminalName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightNumber);
                    table.ForeignKey(
                        name: "FK_Flight_Destinations_DestinationsId",
                        column: x => x.DestinationsId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "PlanesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Terminal_TerminalName",
                        column: x => x.TerminalName,
                        principalTable: "Terminal",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    CustomerPassport = table.Column<int>(nullable: true),
                    FlightNumber = table.Column<int>(nullable: true),
                    LandingDate = table.Column<DateTime>(nullable: false),
                    OrdersId = table.Column<int>(nullable: true),
                    TakeOffTime = table.Column<DateTime>(nullable: false),
                    TerminalName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketNumber);
                    table.ForeignKey(
                        name: "FK_Ticket_Classes_ClassName",
                        column: x => x.ClassName,
                        principalTable: "Classes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Customers_CustomerPassport",
                        column: x => x.CustomerPassport,
                        principalTable: "Customers",
                        principalColumn: "Passport",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Flight_FlightNumber",
                        column: x => x.FlightNumber,
                        principalTable: "Flight",
                        principalColumn: "FlightNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Terminal_TerminalName",
                        column: x => x.TerminalName,
                        principalTable: "Terminal",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: true),
                    PlanesId = table.Column<int>(nullable: true),
                    TicketNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatsId);
                    table.ForeignKey(
                        name: "FK_Seats_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "PlanesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seats_Ticket_TicketNumber",
                        column: x => x.TicketNumber,
                        principalTable: "Ticket",
                        principalColumn: "TicketNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flight_DestinationsId",
                table: "Flight",
                column: "DestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_PlanesId",
                table: "Flight",
                column: "PlanesId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_TerminalName",
                table: "Flight",
                column: "TerminalName");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerPassport",
                table: "Orders",
                column: "CustomerPassport");

            migrationBuilder.CreateIndex(
                name: "IX_PlaneUnit_ClassName",
                table: "PlaneUnit",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_PlaneUnit_PlanesId1",
                table: "PlaneUnit",
                column: "PlanesId1");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_PlanesId",
                table: "Seats",
                column: "PlanesId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TicketNumber",
                table: "Seats",
                column: "TicketNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClassName",
                table: "Ticket",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CustomerPassport",
                table: "Ticket",
                column: "CustomerPassport");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightNumber",
                table: "Ticket",
                column: "FlightNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_OrdersId",
                table: "Ticket",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TerminalName",
                table: "Ticket",
                column: "TerminalName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaneUnit");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Terminal");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
