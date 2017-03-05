using GenericMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Models
{
	public interface IHost : IModel<int>
	{
		string DisplayName { get; set; }

		string NameOrIpAddress { get; set; }
	}

	public class Host : IHost
	{
		public int Id { get; set; }

		public enum Types : byte { Server = 0, Client, Router, Camera };

		[Required]
		public Types Type { get; set; }

		[Required]
		public string DisplayName { get; set; }

		[Required]
		public string NameOrIpAddress { get; set; }

		public string Description { get; set; }
	}
}
