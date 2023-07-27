﻿
using EmployeeDirectoryApi.Controllers;
using Moq;

namespace EmployeeDirectoryApi.UnitTests;

public class BusinessClockTests
{
    [Fact]
    public void ClosedBeforeNine()
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrrent()).Returns(new DateTime(1969, 4, 20,7, 59, 59));
        IProvideTheBusinessClock standardBusinessClock = new StandardBusinessClock(stubbedClock.Object);

        Assert.True(standardBusinessClock.AreWeOpen());
    }

    [Fact]
    public void OpenAtEight()
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrrent()).Returns(new DateTime(1969, 4, 20, 10, 00, 00));
        IProvideTheBusinessClock standardBusinessClock = new StandardBusinessClock(stubbedClock.Object);


        Assert.False(standardBusinessClock.AreWeOpen());
    }
}
