using MediatR;
using mendes.Application.Models;
using mendes.Application.Posts.Queries;
using mendes.Domain.Aggregates.PostAggregate;


namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetPostByIdHandler : IRequestHandler<GetPostById, OperationResult<Post>>
    {
        public Task<OperationResult<Post>> Handle(GetPostById request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new OperationResult<Post>() { Payload = null });
        }
    }
}
