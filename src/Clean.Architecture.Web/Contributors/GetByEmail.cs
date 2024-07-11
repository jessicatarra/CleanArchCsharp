using Ardalis.Result;
using Clean.Architecture.UseCases.Contributors.Get.Email;
using FastEndpoints;
using MediatR;

namespace Clean.Architecture.Web.Contributors;

/// <summary>
/// Get a Contributor by Email.
/// </summary>
/// <remarks>
/// This endpoint allows anonymous access and retrieves a contributor's
/// details based on their email address.
/// </remarks>
public class GetByEmail(IMediator _mediator) : Endpoint<GetContributorByEmailRequest, ContributorRecord>
{
  public override void Configure()
  {
    Get(GetContributorByEmailRequest.Route);
    AllowAnonymous();
  }
  
  public override async Task HandleAsync(GetContributorByEmailRequest request,
    CancellationToken cancellationToken)
  {
    var query = new GetContributorByEmailQuery(request.ContributorEmail);

    var result = await _mediator.Send(query, cancellationToken);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      Response = new ContributorRecord(result.Value.Id, result.Value.Name,result.Value.Email, result.Value.PhoneNumber);
    }
  }

}
