﻿///////////////////////////////////////////////////////////////////
//
// NEXT-GEN demos
// Copyright (c) Youbiquitous srls 2018
//
// Author: Dino Esposito (http://youbiquitous.net)
//

namespace TaskZero.Server.Models.Account
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(LoginInputModel input)
        {
            Input = input;
        }

        public LoginInputModel Input { get; set; }
    }
}