﻿using Newtonsoft.Json;

namespace StrongGrid.Models
{
	/// <summary>
	/// Subscription tracking settings
	/// </summary>
	public class SubscriptionTrackingSettings
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="SubscriptionTrackingSettings"/> is enabled.
		/// </summary>
		/// <value>
		///   <c>true</c> if enabled; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
		public bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>
		/// The text.
		/// </value>
		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the HTML.
		/// </summary>
		/// <value>
		/// The HTML.
		/// </value>
		[JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
		public string Html { get; set; }

		/// <summary>
		/// Gets or sets the substitution tag.
		/// </summary>
		/// <value>
		/// The substitution tag.
		/// </value>
		[JsonProperty("substitution_tag", NullValueHandling = NullValueHandling.Ignore)]
		public string SubstitutionTag { get; set; }
	}
}
