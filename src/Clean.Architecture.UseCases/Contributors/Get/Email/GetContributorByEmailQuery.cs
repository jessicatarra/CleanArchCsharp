using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Contributors.Get.Email;

public record GetContributorByEmailQuery(string ContributorEmail) : IQuery<Result<ContributorDTO>>;
