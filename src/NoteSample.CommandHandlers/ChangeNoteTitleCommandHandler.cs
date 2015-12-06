﻿using ECommon.Components;
using ENode.Commanding;
using NoteSample.Commands;
using NoteSample.Domain;

namespace NoteSample.CommandHandlers
{
    [Component]
    public class ChangeNoteTitleCommandHandler : ICommandHandler<ChangeNoteTitleCommand>
    {
        public void Handle(ICommandContext context, ChangeNoteTitleCommand command)
        {
            context.SetResult(context.Get<Note>(command.AggregateRootId).ChangeTitle(command.Title));
        }
    }
}
