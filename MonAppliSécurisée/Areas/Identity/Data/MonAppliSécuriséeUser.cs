using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MonAppliSécurisée.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MonAppliSécuriséeUser class
public class MonAppliSécuriséeUser : IdentityUser
{
    [PersonalData]
    public required string Prenom { get; set; }

    [PersonalData]
    public required string Nom { get; set; }
}

