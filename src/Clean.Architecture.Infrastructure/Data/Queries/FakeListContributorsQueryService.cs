using Clean.Architecture.UseCases.Contributors;
using Clean.Architecture.UseCases.Contributors.List;

namespace Clean.Architecture.Infrastructure.Data.Queries;

public class FakeListContributorsQueryService : IListContributorsQueryService
{
  public Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    List<ContributorDTO> result =
        [new ContributorDTO(1, "Fake Contributor 1", "fake@contributor1.com",""),
        new ContributorDTO(2, "Fake Contributor 2", "fake@contributor2.com", "")];

    return Task.FromResult(result.AsEnumerable());
  }
}
