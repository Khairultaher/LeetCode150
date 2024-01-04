using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode150.Configs;
public class AutoMoqDataAttribute : AutoDataAttribute
{
    public AutoMoqDataAttribute()
        : base(FixtureFactory)
    {
    }

    private static IFixture FixtureFactory()
    {
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization
        {
            ConfigureMembers = true
        });
        return fixture;
    }
}
