using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Application.Features.Queries.GetAllSemester
{
    public class GetAllSemesterQueryHandler : IRequestHandler<GetAllSemesterQueryRequest, GetAllSemesterQueryResponse>
    {
        public Task<GetAllSemesterQueryResponse> Handle(GetAllSemesterQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
