using MediatR;
using mendes.Application.Models;
using mendes.Dal;
using mendes.Application.Postss.Queries;
using Microsoft.EntityFrameworkCore;
using mendes.Domain.Aggregates.PostAggregate;

namespace mendes.Application.Postss.QueryHandlers
{
    public class GetAllPostsHandler : IRequestHandler<GetAllPosts, OperationResult<List<Post>>>
    {
        private readonly DataContext _ctx;
        public GetAllPostsHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<OperationResult<List<Post>>> Handle(GetAllPosts request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<Post>>();
            try
            {
                var posts = await _ctx.Posts.ToListAsync();
                result.Payload = posts;
            }
            catch (Exception e)
            {
                result.AddUnknownError(e.Message);
            }

            return result;
        }
    }
}
    