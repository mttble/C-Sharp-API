﻿using System.Text.RegularExpressions;

namespace Movies.Application.Models;

public partial class Movie
{
    public required Guid Id { get; set; }
    
    public required string Title { get; set; }
    
    public string Slug => GenerateSlug();
    
    public required int YearOfRelease { get; set; }
    
    public required List<string> Genres { get; init; } = new();
    
    private string GenerateSlug()
    {
       var sluggedTitle = SlugRegex().Replace(Title, string.Empty).ToLower().Replace(" ", "-");
       return $"{sluggedTitle}-{YearOfRelease}";
    }
    [GeneratedRegex("[^a-zA-Z0-9 _-]", RegexOptions.NonBacktracking, 5)]
    private static partial Regex SlugRegex();
    

}