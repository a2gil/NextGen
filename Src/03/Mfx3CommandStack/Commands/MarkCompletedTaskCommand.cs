﻿//////////////////////////////////////////////////////////////////
//
// Youbiquitous YBQ : app starter 
// Copyright (c) Youbiquitous srls 2017
//
// Author: Dino Esposito (http://youbiquitous.net)
//

using System;

namespace Mfx3.CommandStack.Commands
{
    public class MarkCompletedTaskCommand : NotifyCommand
    {
        public MarkCompletedTaskCommand(Guid id,
            string connectionId) : base(connectionId)
        {
            TaskId = id;
        }

        public Guid TaskId { get; set; }
    }
}