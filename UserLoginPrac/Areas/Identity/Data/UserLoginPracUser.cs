using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserLoginPrac.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UserLoginPracUser class
public class UserLoginPracUser : IdentityUser
{
	[PersonalData]
	[Column(TypeName = "nvarchar(100)")]
	public string EmpName { get; set; }

	[PersonalData]
	[Column(TypeName = "nvarchar(100)")]
	public string EmpEmail { get; set; }
}

