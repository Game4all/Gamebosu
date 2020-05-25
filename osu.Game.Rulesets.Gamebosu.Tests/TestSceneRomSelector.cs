﻿using NUnit.Framework;
using osu.Game.Rulesets.Gamebosu.UI.Screens.Selection;
using osu.Game.Tests.Visual;

namespace osu.Game.Rulesets.Gamebosu.Tests
{
    public class TestSceneRomSelector : OsuTestScene
    {
        private readonly RomSelector romSelector;

        public TestSceneRomSelector()
        {
            Child = romSelector = new RomSelector()
            {
                RelativeSizeAxes = Framework.Graphics.Axes.Both
            };
        }

        [Test]
        public void TestRomSelection()
        {
            AddStep("add roms", () =>
            {
                var roms = new string[]
                {
                    "rom.gb",
                    "rom.gba",
                    "yes.gba",
                };

                romSelector.AvalaibleRoms = roms;
            });

            AddStep("select next rom", () => romSelector.OnPressed(GamebosuAction.DPadRight));
            AddStep("go back to previous rom", () => romSelector.OnPressed(GamebosuAction.DPadLeft));
            AddStep("show rom as unavalaible", () => romSelector.MarkUnavalaible());
        }
    }
}
