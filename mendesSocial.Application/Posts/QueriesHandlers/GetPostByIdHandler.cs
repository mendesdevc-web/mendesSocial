using MediatR;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendes.Application.Posts.Queries;
using mendes.Application.Posts.QueriesHandlers;
using mendes.Dal;
using mendes.Domain.Aggregates.PostAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                result.Errors.Add(new Error
                {
                    Code = ErrorCode.NotFound,
                    Message = string.Format(PostsErrorMessages.PostNotFound, request.PostId)
                });
                return result;
            }

            result.Payload = post;
            return result;
        }
    }
}
