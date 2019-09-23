using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Agca.ECommerce.CoreMvcWebUI.Entities
{
    public class CustomIdentityUser :IdentityUser
    {
        public int CustomerId { get; set; }
    }
}
