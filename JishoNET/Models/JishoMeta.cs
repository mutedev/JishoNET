using System;
using System.Text.Json.Serialization;

namespace JishoNET.Models
{
	public class JishoMeta
	{
		/// <summary>
		/// Http Response Code
		/// </summary>
		[JsonPropertyName("status")]
		public int Status { get; set; }
	}
}