﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Justin_palmer
{
     class FPS : Game
    {

        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        // prints, is a fps game rated!
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }





    }
}