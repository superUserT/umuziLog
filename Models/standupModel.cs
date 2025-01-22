namespace umuziLog.Models;

public class Standup {
    public string? Name { get; set; }
    
    public string? Date {get; set;}
    public string? ProjectsProgressYesterday {get; set;}
    public string? PeerProjectsReviewed {get; set;}
    public string? MissedGoals {get; set;}
    public string? ProjectsProgressToday {get; set;}

    public string? PeerProjectsReviewedToday {get; set;}

    public string? Blockers { get; set;}

    public string? Email {get; set;}
}