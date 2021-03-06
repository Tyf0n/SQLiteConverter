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

using SQLiteConversionEngine.Conversion;
using SQLiteConversionEngine.Transform;
using SqlServerConverter.Conversion;
using SQLite = SQLiteConversionEngine.InformationSchema.SQLite;
using SqlServer = SQLiteConversionEngine.InformationSchema.SqlServer;

namespace SqlServerConverter {

    public class Converter : ConverterBase<SqlServer.Database> {

        public Converter(string sqliteFileWithPath, string SqlServerConnectionString, SQLite.PragmaCollection pragmaParameters)
            : base(sqliteFileWithPath, SqlServerConnectionString, pragmaParameters) { }

        public override bool ConvertToSQLite() {
            ToSQLiteConversion toSQLiteConversion = new ToSQLiteConversion(SQLiteConnectionStringSettings, OtherConnectionStringSettings, SchemasToLoad, TablesToLoad);
            toSQLiteConversion.ConvertToDatabase();

            ToSQLiteTransform toSQLiteTransform = new ToSQLiteTransform(toSQLiteConversion.SourceSchema);
            toSQLiteTransform.Transform();

            return true;
        }

        public override bool ConvertFromSQLite() {
            FromSQLiteConversion fromSQLiteConversion = new FromSQLiteConversion(SQLiteConnectionStringSettings, OtherConnectionStringSettings, SchemasToLoad, TablesToLoad);
            fromSQLiteConversion.ConvertToDatabase();
            return true;
        }
    }
}