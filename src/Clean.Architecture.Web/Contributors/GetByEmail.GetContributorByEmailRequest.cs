namespace Clean.Architecture.Web.Contributors;

public class GetContributorByEmailRequest
{
  public const string Route = "/Contributors/email/{ContributorEmail}";

  public static string BuildRoute(string contributorEmail) 
    => Route.Replace("{ContributorEmail}", contributorEmail);

  public required string ContributorEmail { get; set; }
}
