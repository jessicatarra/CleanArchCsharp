using Ardalis.Specification;

namespace Clean.Architecture.Core.ContributorAggregate.Specifications;

public sealed class ContributorByEmailSpec : Specification<Contributor>
{
  public ContributorByEmailSpec(string contributorEmail)
  {
    Query
        .Where(contributor => contributor.Email == contributorEmail);
  }
}
