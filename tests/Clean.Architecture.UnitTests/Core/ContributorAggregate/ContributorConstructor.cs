using Clean.Architecture.Core.ContributorAggregate;
using Xunit;

namespace Clean.Architecture.UnitTests.Core.ContributorAggregate;

public class ContributorConstructor
{
  private readonly string _testName = "test name";
  private readonly string _testEmail = "test@test.com";
  private Contributor? _testContributor;

  private Contributor CreateContributor()
  {
    return new Contributor(_testName, _testEmail);
  }

  [Fact]
  public void InitializesName()
  {
    _testContributor = CreateContributor();

    Assert.Equal(_testName, _testContributor.Name);
  }
}
