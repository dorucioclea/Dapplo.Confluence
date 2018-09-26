﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2016-2018 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Confluence
// 
//  Dapplo.Confluence is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Confluence is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Confluence. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Dapplo.Confluence.Entities
{
	/// <summary>
	///     LastUpdated information
	///     See: https://docs.atlassian.com/confluence/REST/latest
	/// </summary>
	[DataContract]
	public class LastUpdated
	{
		/// <summary>
		///     User who updated
		/// </summary>
		[DataMember(Name = "by", EmitDefaultValue = false)]
		public User By { get; set; }

		/// <summary>
		///     The values that are expandable
		/// </summary>
		[DataMember(Name = "_expandable", EmitDefaultValue = false)]
		public IDictionary<string, string> Expandables { get; set; }

		/// <summary>
		///     Friendly representation for When
		/// </summary>
		[DataMember(Name = "friendlyWhen", EmitDefaultValue = false)]
		public string FriendlyWhen { get; set; }

		/// <summary>
		///     Different links for this entity, depending on the entry
		/// </summary>
		[DataMember(Name = "_links", EmitDefaultValue = false)]
		public Links Links { get; set; }

		/// <summary>
		///     When the last update was
		/// </summary>
		[DataMember(Name = "when", EmitDefaultValue = false)]
		public DateTimeOffset When { get; set; }
	}
}