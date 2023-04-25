using CRM.Application.Common.Interfaces;

namespace CRM.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
