﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Domain
{
  public  class Samurai
    {
        public Samurai()
        {
            SecretIdentity = new SecretIdentity();
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
    }
}
