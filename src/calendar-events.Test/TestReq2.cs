using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("Aniversário", "2022-05-05", "Um aniversário para ir", 0)]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("Festa de Casamento", "2022-05-05", "Uma festa de casamento para ir", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        throw new NotImplementedException();
    }
}