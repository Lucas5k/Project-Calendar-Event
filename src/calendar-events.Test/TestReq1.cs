using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Aniversário", "30/08/1994", "Hoje é um dia feliz!")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
        Event instance = new(title, date, description);
        DateTime convertToDatetime = DateTime.Parse(date);

        instance.Title.Should().Be(title);
        instance.EventDate.Should().Be(convertToDatetime);
        instance.Description.Should().Be(description);
    }

    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Aniversário", "30/08/1994")]
    public void TestEventHalfConstructor(string title, string date)
    {
        Event instance = new(title, date);
        DateTime convertToDatetime = DateTime.Parse(date);

        instance.Title.Should().Be(title);
        instance.EventDate.Should().Be(convertToDatetime);
    }

    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Aniversário", "2022-05-05", 20, "2022-05-25")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        Event instance = new(title, date);
        instance.DelayDate(days);

        DateTime convertToDateTime = DateTime.Parse(expected);
        instance.EventDate.Should().Be(convertToDateTime);
    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData(
        "Aniversário",
        "2022-05-05",
        "Uma festa onde cada um leva seu pudim!",
        "normal",
        "Evento = Aniversário\nDate = 05/05/2022\n"
    )]
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        Event instance = new(title, date, description);

        instance.PrintEvent(format).Should().Be(expected);
    }
}