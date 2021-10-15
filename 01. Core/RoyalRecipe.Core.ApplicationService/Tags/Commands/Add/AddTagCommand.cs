using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagCommand : IRequest<Guid>
    {
        public string Title { get; set; }
    }
}
