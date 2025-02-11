﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.SharedModels.Dtos;

// beste practice: use C#9 records for DTO's.
// see: https://stackoverflow.com/questions/64816714/when-to-use-record-vs-class-vs-struct
// for working with record type: https://www.infoworld.com/article/3607372/how-to-work-with-record-types-in-csharp-9.html

// (But not for EF entity types: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records#value-equality)
public record LessonDto(
        int Id,
        string Title,
        string Description,
        string Category,
        string? Image,
        int Duration,
        decimal? Price,

        // A lesson is a scheduled and located workout with an instructor
        DateTime StartTime,
        string Location,
        string Instructor
        );
