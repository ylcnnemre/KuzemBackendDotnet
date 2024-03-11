using KuzemBackendDotnet.Application.Exceptions;
using KuzemBackendDotnet.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = KuzemBackendDotnet.Domain.Entities;
namespace KuzemBackendDotnet.Application.Features.Commands.Semester.CreateSemester
{
    public class CreateSemesterCommandHandler : IRequestHandler<CreateSemesterCommandRequest, CreateSemesterCommandResponse>
    {
        public readonly ISemesterWriteRepository semesterWriteRepository;
        public readonly ISemesterReadRepository semesterReadRepository;

        public CreateSemesterCommandHandler(ISemesterWriteRepository writeRepository, ISemesterReadRepository semesterReadRepository)
        {
            this.semesterWriteRepository = writeRepository;
            this.semesterReadRepository = semesterReadRepository;

        }

        public async Task<CreateSemesterCommandResponse> Handle(CreateSemesterCommandRequest request, CancellationToken cancellationToken)
        {
            var semesterControl= await this.semesterReadRepository.GetSingleAsync(item => item.Period==request.period && item.Year == request.year );

            if(semesterControl!=null) {
                throw new ConflictException("Bu yıl ve dönem için bir kayıt mevcut",StatusCodes.Status409Conflict); 
            }

            F.Semester semester = new F.Semester()
            {
                Name = request.name,
                Active = request.active,
                Period = request.period,
                Description = request.description,
                Year = request.year,
            };
            await this.semesterWriteRepository.AddAsync(semester);
            await this.semesterWriteRepository.SaveAsync();
            return new()
            {
                 message ="Kayıt işlemi başarılı"
            };
        }
    }
}
