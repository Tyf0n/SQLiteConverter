﻿#region

// -----------------------------------------------------
// MIT License
// Copyright (C) 2012 John M. Baughman (jbaughmanphoto.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial
// portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// -----------------------------------------------------

#endregion

using System;

namespace SQLiteConversionEngine.InformationSchema.SQLite {
	/// <summary>
	/// Description of Column.
	/// </summary>
	public class Column : InformationSchemaItemBase {

		public Column() { }

		public string TableCatalog { get; set; }

		public string TableSchema { get; set; }

		public string TableName { get; set; }

		public string ColumnName { get; set; }

		public Guid? ColumnGuid { get; set; }

		public long? ColumnPropId { get; set; }

		public int? OrdinalPosition { get; set; }

		public bool? ColumnHasDefault { get; set; }

		public string ColumnDefault { get; set; }

		public long? ColumnFlags { get; set; }

		public bool? IsNullable { get; set; }

		public string DataType { get; set; }

		public Guid? TypeGuid { get; set; }

		public int? CharacterMaximumLength { get; set; }

		public int? CharacterOctetLength { get; set; }

		public int? NumericPrecision { get; set; }

		public int? NumericScale { get; set; }

		public long? DateTimePrecision { get; set; }

		public string CharacterSetCatalog { get; set; }

		public string CharacterSetSchema { get; set; }

		public string CharacterSetName { get; set; }

		public string CollationCatalog { get; set; }

		public string CollationSchema { get; set; }

		public string CollationName { get; set; }

		public string DomainCatalog { get; set; }

		public string DomainName { get; set; }

		public string Description { get; set; }

		public bool? PrimaryKey { get; set; }

		public string EdmType { get; set; }

		public bool? AutoIncrement { get; set; }

		public bool? Unique { get; set; }
	}
}