namespace CrudAPI.Contracts.Breakfast

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet,
);