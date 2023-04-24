using Microsoft.AspNetCore.Identity;

namespace backPart.Model
{
	public class UserDTO : IdentityUser
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }

	}
}
