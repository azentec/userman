using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sampekey.Model.Core
{
    public class Catalog: Default
    {
        public string Name { get; set; }
        public string KeyName { get; set; }
        public string Description {get;set;}
    }
}