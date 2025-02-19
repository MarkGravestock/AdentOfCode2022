﻿using FluentAssertions;

namespace DayOne;

public class DayOneTests
{
    private readonly CalorieCounter sut = new("test.txt");

    [Fact]
    public void the_elf_with_the_most_calories_is_number_four()
    {
       sut.ElfWithMaximumCalories().Number.Should().Be(4);
    }

    [Fact]
    public void the_elf_with_the_most_calorie_has_twenty_four_thousand_calories()
    {
        sut.ElfWithMaximumCalories().Calories.Should().Be(24_000);
    }

    [Fact]
    public void it_can_read_the_test_file()
    {
        sut.Lines().Count().Should().Be(15);
    }

    [Fact]
    public void it_can_create_total_per_elf()
    {
        sut.TotalPerElf().Should().HaveCount(5);
    }

    [Fact]
    public void it_can_total_per_elf()
    {
        sut.TotalPerElf().Should().Equal(6000, 4000, 11000, 24000, 10000);
    }
}