﻿using CodeTur.Comum.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace CodeTur.Dominio.Commands.Usuario
{
    public class LogarCommand : Notifiable, ICommand
    {
        public LogarCommand(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
        public void Validar()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Email, "Email", "Informe um e-mail válido")
                .HasMinLen(Senha, 6, "Nome", "A senha deve ter pelo menos 6 caracteres")
                .HasMaxLen(Senha, 12, "Nome", "A senha deve ter no máximo 12 caracteres")
            );
        }
    }
}