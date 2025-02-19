﻿using System.Text;
using Common;
using FluentAssertions;

namespace DayTen;

public class DayTenActualTests
{
    [Fact]
    public void it_can_calculate_total_interesting_signal_strengths()
    {
        FileReader fileReader = new("input.txt");

        var sut = new Cpu();

        fileReader.Lines().ForEach(cpuInstruction => sut.RunInstruction(cpuInstruction));

        sut.GetTotalInterestingSignalStrengths().Should().Be(14220);
    }

    [Fact]
    public void it_can_draw_pixel_state_for_part_two()
    {
        FileReader fileReader = new("input.txt");

        var sut = new Cpu();

        fileReader.Lines().ForEach(cpuInstruction => sut.RunInstruction(cpuInstruction));

        var expected = new StringBuilder();
        expected.AppendLine("####.###...##..###..#....####.####.#..#.");
        expected.AppendLine("...#.#..#.#..#.#..#.#....#.......#.#..#.");
        expected.AppendLine("..#..#..#.#..#.#..#.#....###....#..#..#.");
        expected.AppendLine(".#...###..####.###..#....#.....#...#..#.");
        expected.AppendLine("#....#.#..#..#.#.#..#....#....#....#..#.");
        expected.AppendLine("####.#..#.#..#.#..#.####.#....####..##..");

        sut.ShowCrtUptoCycle(240).Should().Be(expected.ToString());
    }

}