﻿// Copyright (c) Arjen Post. See LICENSE in the project root for license information.

using System.Data;
using System.Data.Common;
using Moq;

namespace Dapper.Mapper.Tests
{
    public partial class SqlMapperTests : BaseTests
    {
        public SqlMapperTests(string[] columnNames)
            : base(columnNames)
        {
        }
    }
}
