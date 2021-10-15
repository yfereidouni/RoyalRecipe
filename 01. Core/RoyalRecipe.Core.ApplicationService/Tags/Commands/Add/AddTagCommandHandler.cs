

using MediatR;
using RoyalRecipe.Core.Domain.Tags;
using System;

namespace RoyalRecipe.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagCommandHandler : RequestHandler<AddTagCommand, Guid>
    {
        private readonly ITagRepository tagRepository;

        public AddTagCommandHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        protected override Guid Handle(AddTagCommand request)
        {
            var tag = new Tag { 
             Id = Guid.NewGuid(),
             Title = request.Title
            };

            tagRepository.Insert(tag);
            tagRepository.SaveChanges();

            return tag.Id;
        }
    }
}
