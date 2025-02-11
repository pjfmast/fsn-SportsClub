using SportsClub.Api.Entities;
using SportsClub.Api.Extensions;

namespace SportsClub.Api.Data;

public static class SportClubSeedData
{
    // warning: The static field variable initializers of a class declaration correspond to a sequence of assignments that are executed in the textual order in which they appear in the class declaration. 
    private static readonly DateTime today = DateTime.Now;

    #region individual locations
    private static int locationId = 1;

    private static readonly Location bressSportcentrum = new()
    {
        Id = locationId++,
        Name = "BRESS Sportcentrum",
        Address = "Nieuwe Inslag 99",
        Capacity = 150,
        IsOutside = false
    };

    private static readonly Location apenkooiGym = new()
    {
        Id = locationId++,
        Name = "ApenkooiGym",
        Address = "Brouwmeesterstraat 10 Breda",
        Capacity = 25,
        IsOutside = false
    };

    private static readonly Location wilderen = new()
    {
        Id = locationId++,
        Name = "Wilderen 2 Breda",
        Address = "Wilderen 2, 4817 VG Breda",
        Capacity = 20,
        IsOutside = true
    };

    private static readonly Location boulderhalBruut = new()
    {
        Id = locationId++,
        Name = "Boulderhal Bruut",
        Address = "Spinveld 66 A1 Breda",
        Capacity = 60,
        IsOutside = false
    };

    private static readonly Location dansStudio1 = new()
    {
        Id = locationId++,
        Name = "BRESS Sportcentrum, Dance Studio 1",
        Address = "Nieuwe Inslag 99, 4817 GN Breda",
        Capacity = 30,
        IsOutside = true
    };

    private static readonly Location dansStudio2 = new()
    {
        Id = locationId++,
        Name = "BRESS Sportcentrum, Dance Studio 2",
        Address = "Nieuwe Inslag 99, 4817 GN Breda",
        Capacity = 20,
        IsOutside = true
    };

    private static readonly Location fitnessRoom = new()
    {
        Id = locationId++,
        Name = "BRESS Sportcentrum, Fitness",
        Address = "Nieuwe Inslag 99, 4817 GN Breda",
        Capacity = 25,
        IsOutside = false
    };

    private static readonly Location belcrumhuis = new()
    {
        Id = locationId++,
        Name = "Belcrumhuis",
        Address = "Pastoor Pottersplein 12, 4815 BC Breda",
        Capacity = 25,
        IsOutside = true
    };

    private static readonly Location tennisTVBN = new()
    {
        Id = locationId++,
        Name = "TVBN Tennisvereniging Breda Noord",
        Address = "Terheijdenseweg 508 Breda",
        Capacity = 16,
        IsOutside = true
    };

    private static readonly Location paaldansStudio = new()
    {
        Id = locationId++,
        Name = "Atletiekvereniging SPRINT",
        Address = "Dr. Schaepmanlaan 4 Breda",
        Capacity = 16,
        IsOutside = false
    };

    private static readonly Location teteringseDijk = new()
    {
        Id = locationId++,
        Name = "Ortega Diving",
        Address = "Teteringsedijk 145, 4817 MD Breda",
        Capacity = 12,
        IsOutside = false
    };

    private static readonly Location supAndFun = new()
    {
        Id = locationId++,
        Name = "Ortega Diving",
        Address = "Gasthuisvelden 11, 4811 VX Breda",
        Capacity = 8,
        IsOutside = true
    };

    #endregion
    public static readonly List<Location> Locations
        = [bressSportcentrum, apenkooiGym, boulderhalBruut, wilderen, dansStudio1, dansStudio2, belcrumhuis, fitnessRoom, tennisTVBN, paaldansStudio, teteringseDijk, supAndFun];



    #region individual workouts
    private static int workOutId = 1;
    private static readonly Workout atletiek = new()
    {
        Id = workOutId++,
        Title = "Atletiek",
        Description = "Atletiek is samen met de zwemsport de oudste sport ter wereld en wordt ook wel ‘de moeder der sporten’ genoemd omdat het de menselijke basisbewegingen (lopen, springen en werpen) omvat. Bij atletiek moeten sporters (de atleten) op individueel of in groepen (estafette) presteren en kan zowel op de weg als op de atletiekbaan worden beoefend.",
        Category = "buiten sporten",
        Image = "https://bress.nl/wp-content/uploads/2022/05/sports-family-training-summer-forest-min-1536x1024.jpg",
        Duration = 75,
    };

    private static readonly Workout bodyAndMind = new()
    {
        Id = workOutId++,
        Title = "Body and mind",
        Description = "Ben jij wel toe aan wat ontspanning maar wil je tegelijkertijd wel je lichaam trainen? Volg dan de Body & Mind les van Robert. Tijdens deze les leer je gecontroleerd te ademhalen en verbeter je je flexibiliteit en statische kracht. Dankzij de meditatie oefeningen verbeter je ook nog eens je concentratie. Alle oefeningen worden uitgevoerd met rustgevende muziek op de achtergrond maar vergis je niet; dit is absoluut geen suffe les!",
        Category = "binnen sporten",
        Image = "https://bress.nl/wp-content/uploads/2022/10/pexels-mikhail-nilov-6740754-1.jpg",
        Duration = 50,
    };

    private static readonly Workout badminton = new()
    {
        Id = workOutId++,
        Title = "Badminton",
        Description = "Badminton is een Olympische sport die wordt gespeeld met een racket en een shuttle. De shuttle wordt over een net heen en weer geslagen met de rackets. Afhankelijk van met hoeveel personen je op de baan staat speel je een enkelspel of een dubbelspel. Bij een enkelspel speel je één tegen één en bij een dubbelspel twee tegen twee.",
        Category = "binnen sporten",
        Image = "https://bress.nl/wp-content/uploads/2022/05/BRESS_Badminton_30okt_excl_016-min-1536x1025.jpg",
        Duration = 60,
    };

    private static readonly Workout bootcamp = new()
    {
        Id = workOutId++,
        Title = "Bootcamp",
        Description = "Bootcamp is groepstraining die conditie- en krachtoefeningen combineert en buiten plaatsvindt. Tijdens veel oefeningen wordt er gebruik gemaakt van eigen lichaamsgewicht en obstakels die in de omgeving aanwezig zijn, denk bijvoorbeeld aan bankjes, stoepranden en hekken. Sommige oefeningen doe je in tweetallen of in kleine groepjes, zodat je elkaar kunt gebruiken om bepaalde oefeningen uit te voeren en elkaar aan te moedigen. Samen bereik je meer!",
        Category = "conditie en kracht",
        Image = "https://bresactiviteiten.nl/wp-content/uploads/2020/10/bootcamp-game-foto-1-bresactiviteiten.nl_.jpg",
        Duration = 75,
        Price = 2.5M,
    };

    private static readonly Workout boulderen = new()
    {
        Id = workOutId++,
        Title = "Boulderen",
        Description = "Boulderen is een spectaculaire vorm van klimmen en komt voort uit het beklimmen van rotsblokken. Anders dan bij klimmen heb je bij boulderen geen touw en klimgordels nodig. Dikke valmatten onder de routes zorgen voor veiligheid. De klimwanden in de boulderhal hebben een maximale hoogte van 4,5 meter en variëren van voorover neigend tot en met fors achterover hellend. Het is een sport voor vrijwel iedereen en kan zowel individueel als in groepsverband beoefend worden. Door de mix van de verschillende wanden en boulders kunnen zowel beginnende klimmers als gevorderden naast en met elkaar boulderen.",
        Category = "conditie en kracht",
        Image = "https://bress.nl/wp-content/uploads/2022/10/boulderen-2.jpeg",
        Duration = 120,
        Price = 6.5M
    };

    private static readonly Workout boxFit = new()
    {
        Id = workOutId++,
        Title = "BoxFit",
        Description = "Tijdens de high intensity training BoxFit krijg je te maken met een combinatie van bokstechnieken en oefeningen met eigen lichaamsgewicht, waarbij fun en samenwerking centraal staat.",
        Category = "kracht",
        Image = "https://bress.nl/wp-content/uploads/2022/10/nieuwjaarsactie-RAW_011-min-768x1159.jpg",
        Duration = 60
    };

    private static readonly Workout spikeball = new()
    {
        Id = workOutId++,
        Title = "Spikeball/Roundnet",
        Description = "Spikeball/Roundnet, een supersnelle maar zeker spectaculaire sport! Het spel wordt 2-op-2 gespeeld, met een rond net tussen de twee teams. Eén speler begint met het serveren van de bal op het net, waardoor deze opduikt naar zijn tegenstanders. Net als bij volleybal mag elk team de bal maximaal drie keer raken voordat deze weer in het net moet landen.",
        Category = "balsport",
        Image = "https://bress.nl/wp-content/uploads/2022/10/Spikeball-november-2020-2-1536x1024.jpg",
        Duration = 75,
    };


    private static readonly Workout sup
        = new()
        {
            Id = workOutId++,
            Title = "SUP",
            Description = "SUP staat voor Stand Up Paddling. Je staat op een plank met een peddel en kunt zelf varen, de omgeving vanaf de waterkant bekijken of bijvoorbeeld oefeningen doen op jouw plank. Suppen is heel toegankelijk; iedereen kan het op zijn/haar eigen niveau beoefenen.",
            Category = "outdoor",
            Image = "https://bress.nl/wp-content/uploads/2022/05/supping-2022-04-12-02-01-30-utc-1536x1024.jpg",
            Duration = 60
        };

    private static readonly Workout acroYoga = new()
    {
        Id = workOutId++,
        Title = "Acro Yoga",
        Description = "Combineer yoga, Thaise massage en acrobatiek met elkaar en je hebt AcroYoga.",
        Category = "groepsles",
        Image = "https://bress.nl/wp-content/uploads/2022/09/unnamed-3-1536x1024.jpg",
        Duration = 90
    };

    private static readonly Workout fitness = new()
    {
        Id = workOutId++,
        Title = "Fitness",
        Description = "Onze fitness beschikt over de up-to-date cardio- en krachtapparatuur van Matrix Fitness en daarnaast ook over een free weight area waar je alle ruimte hebt om (grond)oefeningen te doen of te trainen met dumbbells, barbells en andere materialen.",
        Category = "kracht",
        Image = "https://bress.nl/wp-content/uploads/2023/09/BRESS_newgym1208_005-1536x1106.jpg",
        Duration = 90
    };

    private static readonly Workout tennis = new()
    {
        Id = workOutId++,
        Title = "Beachtennis",
        Description = "Beachtennis is een snelgroeiende beachsport die zijn oorsprong vindt in Amerika en Brazilië. Het grote verschil met reguliere tennis is dat er bij beachtennis geen ingewikkelde lijnen zijn; met de buitenlijnen en een net ben je al klaar!",
        Category = "balsport",
        Image = "https://bress.nl/wp-content/uploads/2022/09/BredaBeachGames-12-1024x684.jpg",
        Duration = 90
    };

    private static readonly Workout aerialSilk = new()
    {
        Id = workOutId++,
        Title = "Aerial Silk",
        Description = "Aerial Silk is een unieke sport die zijn oorsprong kent in het circus. Tijdens het beoefenen van deze sport train je heel je lichaam en ontwikkel je evenwicht, kracht en flexibiliteit. Daarnaast krijg je echt een kick als je in de doeken hangt.",
        Category = "groepsles",
        // https://bress.nl/wp-content/uploads/2022/09/IMG_2558-23-1.jpg
        Image = "https://bress.nl/wp-content/uploads/2022/09/IMG_2558-23-1.jpg",
        Duration = 90
    };

    private static readonly Workout duiken = new()
    {
        Id = workOutId++,
        Title = "Duiken",
        Description = "Duiken is één van de snelst groeiende avontuurlijke sporten ter wereld en dat is niet zonder reden. Het ontspannen gevoel en het gevoel van gewichtloosheid (een gevoel dat verder alleen astronauten kunnen meemaken) maakt duiken tot een unieke sport. Duiken doe je altijd met minimaal 2 personen waardoor het ook nog eens een sociale sport is. Wist je trouwens dat het aardoppervlakte\r\nuit 70% water bestaat en dat er onder water meer verschillende soorten planten en dieren leven dan erboven? Er valt dus nog genoeg te ontdekken in de onderwaterwereld!",
        Category = "groepsles",
        Image = "https://bress.nl/wp-content/uploads/2022/05/BRESS_Duiken_016-1024x684.jpg",
        Duration = 90
    };
    public static readonly List<Workout> Workouts
        = [atletiek, bodyAndMind, badminton, bootcamp, boulderen, boxFit, spikeball, sup, acroYoga, fitness, tennis, aerialSilk, duiken];

    #endregion

    #region all lessons (with startime and location)
    private static int lessonId = 1;

    public static readonly List<Lesson> Lessons
        =
    [
        new Lesson() {Id = lessonId++, WorkOutId = bootcamp.Id, Instructor = "Marcel", LocationId = wilderen.Id, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 19, 30)},
        new Lesson() {Id = lessonId++, WorkOutId = boxFit.Id, Instructor = "Coen", LocationId = dansStudio1.Id, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 18, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = spikeball.Id, Instructor = "Freek", LocationId = apenkooiGym.Id, StartDateTime = today.AtTime(18, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = sup.Id, Instructor = "Miriam", LocationId = supAndFun.Id, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 15, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = sup.Id, Instructor = "Miriam", LocationId = supAndFun.Id, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 15, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = acroYoga.Id, Instructor = "Marcel", LocationId = belcrumhuis.Id, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 10, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = aerialSilk.Id, Instructor = "Laura", LocationId = paaldansStudio.Id, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 19, 30)},
        new Lesson() {Id = lessonId++, WorkOutId = fitness.Id, Instructor = "Emilio", LocationId = fitnessRoom.Id, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 11, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = tennis.Id, Instructor = "Judith", LocationId = tennisTVBN.Id, StartDateTime = today.AtTime(16, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = aerialSilk.Id, Instructor = "Eva", LocationId = paaldansStudio.Id, StartDateTime = today.AtTime(19, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = duiken.Id, Instructor = "Suzanne", LocationId = teteringseDijk.Id, StartDateTime = today.AtTime(20, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = badminton.Id, Instructor = "zelf trainen", LocationId = bressSportcentrum.Id, StartDateTime = today.AtTime(17, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = bodyAndMind.Id, Instructor = "Robert", LocationId = dansStudio1.Id, StartDateTime = today.AtTime(19, 30)},

        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Monday ,17, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday ,17, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday ,14, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 14, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 14, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 10, 0)},
        new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 10, 0)},
    ];

    #endregion

}