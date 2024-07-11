using Ardalis.Result;
using Ardalis.SharedKernel;
using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Core.ContributorAggregate.Specifications;

namespace Clean.Architecture.UseCases.Contributors.Get.Email;


public class GetContributorByEmailHandler(IReadRepository<Contributor> _repository)
  : IQueryHandler<GetContributorByEmailQuery, Result<ContributorDTO>>
{
  public async Task<Result<ContributorDTO>> Handle(GetContributorByEmailQuery request, CancellationToken cancellationToken)
  {
    var spec = new ContributorByEmailSpec(request.ContributorEmail);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new ContributorDTO(entity.Id, entity.Name, entity.Email, entity.PhoneNumber?.Number ?? "");
  }
}
