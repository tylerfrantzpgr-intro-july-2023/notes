﻿namespace EmployeeDirectoryApi.Model;

public record OnCallDeveloperResponseModel
{
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string PhoneNumber { get; init; } = string.Empty;
}

