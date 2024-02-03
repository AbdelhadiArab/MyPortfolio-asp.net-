using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyPortfolio.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MyPortfolioUser class
public class MyPortfolioUser : IdentityUser
{
    public string FristName { get; set; }
    public string LastName { get; set; }
}

