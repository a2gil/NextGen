﻿///////////////////////////////////////////////////////////////////
//
// Youbiquitous YBQ : app starter 
// Copyright (c) Youbiquitous srls 2017
//
// Author: Dino Esposito (http://youbiquitous.net)
//

using MfxDemo3.Common;
using MfxDemo3.Models.Account;
using MfxDemo3.Resources;

namespace MfxDemo3.Application
{
    public class AccountService
    {
        public CommandResponse TryAuthenticate(LoginInputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.Username) ||
               string.IsNullOrWhiteSpace(input.Password))
                return new CommandResponse().AddMessage(Strings_UI.Account_IncompleteCredentials);

            return ValidateCredentials(input.Username, input.Password);
        }


        private static CommandResponse ValidateCredentials(string name, string password)
        {
            return name == password
                ? new CommandResponse(true).AddKey(name)
                : new CommandResponse().AddMessage(Strings_UI.Account_InvalidCredentials);
        }
    }
}