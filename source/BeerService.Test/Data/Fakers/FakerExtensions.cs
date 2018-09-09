﻿using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Microsoft.EntityFrameworkCore;

namespace BeerService.Test.Data.Fakers
{
    internal static class FakerExtensions
    {
        public static class ListFaker<T> where T : class
        {
            public static DbSet<T> GetFake(List<T> data)
            {
                var dataAsQueryable = data.AsQueryable();
                var fakeDbSet = A.Fake<DbSet<T>>(b => b.Implements(typeof(IQueryable<T>)));
                A.CallTo(() => ((IQueryable<T>)fakeDbSet).GetEnumerator()).Returns(dataAsQueryable.GetEnumerator());
                A.CallTo(() => ((IQueryable<T>)fakeDbSet).Provider).Returns(dataAsQueryable.Provider);
                A.CallTo(() => ((IQueryable<T>)fakeDbSet).Expression).Returns(dataAsQueryable.Expression);
                A.CallTo(() => ((IQueryable<T>)fakeDbSet).ElementType).Returns(dataAsQueryable.ElementType);

                return fakeDbSet;
            }
        }
    }
}
