﻿using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsDoneCommand()
        {
        }

        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public String User { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário Inválido!")
            );
        }
    }
}
