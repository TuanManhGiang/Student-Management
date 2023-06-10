using Student_manged.Application.Common.Interfaces;

namespace Student_manged.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
