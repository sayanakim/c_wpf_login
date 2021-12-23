﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    class User
    {
        public int id { get; set; }

        private string login, email, pass;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public User() { } // конструктор по-умолчанию, он необходим
       
        public User(string login, string email, string pass)
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }

        // информация в кабинете пользователя о зарегистрированных (1 вариант)
        /* 
        public override string ToString()
        {
            return "Пользователь: " + Login + ". Email: " + Email;
        }
        */

    }
}
