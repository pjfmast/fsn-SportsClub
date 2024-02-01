using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsClub.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsOutside = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOutId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Capacity", "IsOutside", "Name" },
                values: new object[,]
                {
                    { 1, "Nieuwe Inslag 99", 150, false, "BRESS Sportcentrum" },
                    { 2, "Brouwmeesterstraat 10 Breda", 25, false, "ApenkooiGym" },
                    { 3, "Wilderen 2, 4817 VG Breda", 20, true, "Wilderen 2 Breda" },
                    { 4, "Spinveld 66 A1 Breda", 60, false, "Boulderhal Bruut" },
                    { 5, "Nieuwe Inslag 99, 4817 GN Breda", 30, true, "BRESS Sportcentrum, Dance Studio 1" },
                    { 6, "Nieuwe Inslag 99, 4817 GN Breda", 20, true, "BRESS Sportcentrum, Dance Studio 2" },
                    { 7, "Nieuwe Inslag 99, 4817 GN Breda", 25, false, "BRESS Sportcentrum, Fitness" },
                    { 8, "Pastoor Pottersplein 12, 4815 BC Breda", 25, true, "Belcrumhuis" },
                    { 9, "Terheijdenseweg 508 Breda", 16, true, "TVBN Tennisvereniging Breda Noord" },
                    { 10, "Dr. Schaepmanlaan 4 Breda", 16, false, "Atletiekvereniging SPRINT" },
                    { 11, "Teteringsedijk 145, 4817 MD Breda", 12, false, "Ortega Diving" },
                    { 12, "Gasthuisvelden 11, 4811 VX Breda", 8, true, "Ortega Diving" }
                });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "Id", "Instructor", "LocationId", "StartDateTime", "WorkOutId" },
                values: new object[,]
                {
                    { 1, "Marcel", 3, new DateTime(2024, 2, 6, 19, 30, 0, 0, DateTimeKind.Local), 4 },
                    { 2, "Coen", 5, new DateTime(2024, 2, 5, 18, 0, 0, 0, DateTimeKind.Local), 5 },
                    { 3, "Freek", 2, new DateTime(2024, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 4, "Miriam", 12, new DateTime(2024, 2, 6, 15, 0, 0, 0, DateTimeKind.Local), 8 },
                    { 5, "Miriam", 12, new DateTime(2024, 2, 1, 15, 0, 0, 0, DateTimeKind.Local), 8 },
                    { 6, "Marcel", 8, new DateTime(2024, 2, 3, 10, 0, 0, 0, DateTimeKind.Local), 9 },
                    { 7, "Laura", 10, new DateTime(2024, 2, 2, 19, 30, 0, 0, DateTimeKind.Local), 12 },
                    { 8, "Emilio", 7, new DateTime(2024, 2, 4, 11, 0, 0, 0, DateTimeKind.Local), 10 },
                    { 9, "Judith", 9, new DateTime(2024, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 10, "Eva", 10, new DateTime(2024, 1, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 11, "Suzanne", 11, new DateTime(2024, 1, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 12, "zelf trainen", 1, new DateTime(2024, 1, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Robert", 5, new DateTime(2024, 1, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "", 4, new DateTime(2024, 2, 5, 17, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 15, "", 4, new DateTime(2024, 2, 6, 17, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 16, "", 4, new DateTime(2024, 1, 31, 14, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 17, "", 4, new DateTime(2024, 2, 1, 14, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 18, "", 4, new DateTime(2024, 2, 2, 14, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 19, "", 4, new DateTime(2024, 2, 3, 10, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 20, "", 4, new DateTime(2024, 2, 4, 10, 0, 0, 0, DateTimeKind.Local), 7 }
                });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "Id", "Category", "Description", "Duration", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "buiten sporten", "Atletiek is samen met de zwemsport de oudste sport ter wereld en wordt ook wel ‘de moeder der sporten’ genoemd omdat het de menselijke basisbewegingen (lopen, springen en werpen) omvat. Bij atletiek moeten sporters (de atleten) op individueel of in groepen (estafette) presteren en kan zowel op de weg als op de atletiekbaan worden beoefend.", 75, "https://bress.nl/wp-content/uploads/2022/05/sports-family-training-summer-forest-min-1536x1024.jpg", null, "Atletiek" },
                    { 2, "binnen sporten", "Ben jij wel toe aan wat ontspanning maar wil je tegelijkertijd wel je lichaam trainen? Volg dan de Body & Mind les van Robert. Tijdens deze les leer je gecontroleerd te ademhalen en verbeter je je flexibiliteit en statische kracht. Dankzij de meditatie oefeningen verbeter je ook nog eens je concentratie. Alle oefeningen worden uitgevoerd met rustgevende muziek op de achtergrond maar vergis je niet; dit is absoluut geen suffe les!", 50, "https://bress.nl/wp-content/uploads/2022/10/pexels-mikhail-nilov-6740754-1.jpg", null, "Body and mind" },
                    { 3, "binnen sporten", "Badminton is een Olympische sport die wordt gespeeld met een racket en een shuttle. De shuttle wordt over een net heen en weer geslagen met de rackets. Afhankelijk van met hoeveel personen je op de baan staat speel je een enkelspel of een dubbelspel. Bij een enkelspel speel je één tegen één en bij een dubbelspel twee tegen twee.", 60, "https://bress.nl/wp-content/uploads/2022/05/BRESS_Badminton_30okt_excl_016-min-1536x1025.jpg", null, "Badminton" },
                    { 4, "conditie en kracht", "Bootcamp is groepstraining die conditie- en krachtoefeningen combineert en buiten plaatsvindt. Tijdens veel oefeningen wordt er gebruik gemaakt van eigen lichaamsgewicht en obstakels die in de omgeving aanwezig zijn, denk bijvoorbeeld aan bankjes, stoepranden en hekken. Sommige oefeningen doe je in tweetallen of in kleine groepjes, zodat je elkaar kunt gebruiken om bepaalde oefeningen uit te voeren en elkaar aan te moedigen. Samen bereik je meer!", 75, "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-23-om-16.47.36-1024x959.png", 2.5m, "Bootcamp" },
                    { 5, "kracht", "Tijdens de high intensity training BoxFit krijg je te maken met een combinatie van bokstechnieken en oefeningen met eigen lichaamsgewicht, waarbij fun en samenwerking centraal staat.", 60, "https://bress.nl/wp-content/uploads/2022/10/nieuwjaarsactie-RAW_011-min-768x1159.jpg", null, "BoxFit" },
                    { 6, "balsport", "Spikeball/Roundnet, een supersnelle maar zeker spectaculaire sport! Het spel wordt 2-op-2 gespeeld, met een rond net tussen de twee teams. Eén speler begint met het serveren van de bal op het net, waardoor deze opduikt naar zijn tegenstanders. Net als bij volleybal mag elk team de bal maximaal drie keer raken voordat deze weer in het net moet landen.", 75, "https://bress.nl/wp-content/uploads/2022/10/Spikeball-november-2020-2-1536x1024.jpg", null, "Spikeball/Roundnet" },
                    { 7, "conditie en kracht", "Boulderen is een spectaculaire vorm van klimmen en komt voort uit het beklimmen van rotsblokken. Anders dan bij klimmen heb je bij boulderen geen touw en klimgordels nodig. Dikke valmatten onder de routes zorgen voor veiligheid. De klimwanden in de boulderhal hebben een maximale hoogte van 4,5 meter en variëren van voorover neigend tot en met fors achterover hellend. Het is een sport voor vrijwel iedereen en kan zowel individueel als in groepsverband beoefend worden. Door de mix van de verschillende wanden en boulders kunnen zowel beginnende klimmers als gevorderden naast en met elkaar boulderen.", 120, "https://bress.nl/wp-content/uploads/2022/10/boulderen-2.jpeg", 6.5m, "Boulderen" },
                    { 8, "outdoor", "SUP staat voor Stand Up Paddling. Je staat op een plank met een peddel en kunt zelf varen, de omgeving vanaf de waterkant bekijken of bijvoorbeeld oefeningen doen op jouw plank. Suppen is heel toegankelijk; iedereen kan het op zijn/haar eigen niveau beoefenen.", 60, "https://bress.nl/wp-content/uploads/2022/05/supping-2022-04-12-02-01-30-utc-1536x1024.jpg", null, "SUP" },
                    { 10, "kracht", "Onze fitness beschikt over de up-to-date cardio- en krachtapparatuur van Matrix Fitness en daarnaast ook over een free weight area waar je alle ruimte hebt om (grond)oefeningen te doen of te trainen met dumbbells, barbells en andere materialen.", 90, "https://bress.nl/wp-content/uploads/2023/09/BRESS_newgym1208_005-1536x1106.jpg", null, "Fitness" },
                    { 11, "balsport", "Beachtennis is een snelgroeiende beachsport die zijn oorsprong vindt in Amerika en Brazilië. Het grote verschil met reguliere tennis is dat er bij beachtennis geen ingewikkelde lijnen zijn; met de buitenlijnen en een net ben je al klaar!", 90, "https://bress.nl/wp-content/uploads/2022/09/BredaBeachGames-12-1024x684.jpg", null, "Beachtennis" },
                    { 12, "groepsles", "Aerial Silk is een unieke sport die zijn oorsprong kent in het circus. Tijdens het beoefenen van deze sport train je heel je lichaam en ontwikkel je evenwicht, kracht en flexibiliteit. Daarnaast krijg je echt een kick als je in de doeken hangt.", 90, "https://bress.nl/wp-content/uploads/2022/09/IMG_2558-23-1.jpg", null, "Aerial Silk" },
                    { 13, "groepsles", "Duiken is één van de snelst groeiende avontuurlijke sporten ter wereld en dat is niet zonder reden. Het ontspannen gevoel en het gevoel van gewichtloosheid (een gevoel dat verder alleen astronauten kunnen meemaken) maakt duiken tot een unieke sport. Duiken doe je altijd met minimaal 2 personen waardoor het ook nog eens een sociale sport is. Wist je trouwens dat het aardoppervlakte\r\nuit 70% water bestaat en dat er onder water meer verschillende soorten planten en dieren leven dan erboven? Er valt dus nog genoeg te ontdekken in de onderwaterwereld!", 90, "https://bress.nl/wp-content/uploads/2022/05/BRESS_Duiken_016-1024x684.jpg", null, "Duiken" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "lessons");

            migrationBuilder.DropTable(
                name: "workouts");
        }
    }
}
