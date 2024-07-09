using Ardalis.HttpClientTestExtensions;
using Clean.Architecture.Infrastructure.Data;
using Clean.Architecture.Web.Contributors;
using Xunit;

namespace Clean.Architecture.FunctionalTests.ApiEndpoints;

[Collection("Sequential")]
public class ContributorGetByEmail(CustomWebApplicationFactory<Program> factory) : IClassFixture<CustomWebApplicationFactory<Program>>
{
  private readonly HttpClient _client = factory.CreateClient();

  [Fact]
  public async Task ReturnsSeedContributorGivenEmail()
  {
    const string email = "fake@contributor1.com";
    var result = await _client.GetAndDeserializeAsync<ContributorRecord>(GetContributorByEmailRequest.BuildRoute(email));

    Assert.Equal(email, result.Email);
    Assert.Equal(SeedData.Contributor1.Name, result.Name);
  }

  [Fact]
  public async Task ReturnsNotFoundGivenEmailUnRegistered()
  {
    string route = GetContributorByEmailRequest.BuildRoute("not_found@test.com");
    _ = await _client.GetAndEnsureNotFoundAsync(route);
  }
}
