using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Application.Features.Commands.Semester.CreateSemester
{
    public class CreateSemesterCommandRequest:IRequest<CreateSemesterCommandResponse>
    {
        public string name {  get; set; }
        public string description { get; set; }
        public string period { get; set; }
        public int year { get; set; }
        public bool active { get; set; } = false;   
    }
}
