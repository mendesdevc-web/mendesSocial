using MediatR;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendes.Application.Posts;
using mendes.Application.Posts.Queries;
using mendes.Dal;
using mendes.Domain.Aggregates.PostAggregate;
using Microsoft.EntityFrameworkCore;


namespace mendes.Application.Postss.QueriesHandlers
{
    public class GetPostByIdHandler : IRequestHandler<GetPostById, OperationResult<Post>>
    {
        private readonly DataContext _ctx;
        public GetPostByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<OperationResult<Post>> Handle(GetPostById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Post>();
            var post = await _ctx.Posts
                .FirstOrDefaultAsync(p => p.PostId == request.PostId);

            if (post is null)
            {
                result.AddError(ErrorCode.NotFound,
                    string.Format(PostsErrorMessages.PostNotFound, request.PostId));
                return result;
            }

            result.Payload = post;
            return result;
        }
    }
}
