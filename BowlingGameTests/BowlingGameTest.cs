using NUnit.Framework;

namespace BowlingGameTests
{
    [TestFixture]
    public class BowlingGameTest
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void Should_the_score_equal_to_0_when_no_pins_knocked_down_for_the_10_frames()
        {
            RollMany(20, 0);
            Assert.That(_game.Score(), Is.EqualTo(0));
        }

        [TestCase(1, 20)]
        [TestCase(2, 40)]
        [TestCase(3, 60)]
        [TestCase(4, 80)]
        public void Should_the_score_equal_to_the_sum_of_pins_knocked_down_when_neither_strike_nor_spare(int pins, int score)
        {
            RollMany(20, pins);
            Assert.That(_game.Score(), Is.EqualTo(score));
        }

        [TestCase(0, 10)]
        [TestCase(1, 29)]
        public void Should_the_score_equal_to_the_sum_of_pins_knocked_down_plus_the_number_of_pins_knocked_down_by_the_next_roll_when_spare(int pins, int score)
        {
            RollSpare();
            RollMany(18, pins);
            Assert.That(_game.Score(), Is.EqualTo(score));
        }

        [TestCase(0, 10)]
        [TestCase(1, 30)]
        public void Should_the_score_equal_to_the_sum_of_pins_knocked_down_plus_the_number_of_pins_knocked_down_by_the_next_2_rolls_when_strike(int pins, int score)
        {
            RollStrike();
            RollMany(18, pins);
            Assert.That(_game.Score(), Is.EqualTo(score));
        }

        [Test]
        public void Should_the_score_equal_to_300_when_only_strikes()
        {
            for (int i = 1; i <= 12; i++)
            {
                RollStrike();
            }
            Assert.That(_game.Score(), Is.EqualTo(300));
        }

        [Test]
        public void Acceptance_test()
        {
            _game.Roll(1);
            _game.Roll(4);
            _game.Roll(4);
            _game.Roll(5);
            _game.Roll(6);
            _game.Roll(4);
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(10);
            _game.Roll(0);
            _game.Roll(1);
            _game.Roll(7);
            _game.Roll(3);
            _game.Roll(6);
            _game.Roll(4);
            _game.Roll(10);
            _game.Roll(2);
            _game.Roll(8);
            _game.Roll(6);
            Assert.That(_game.Score(), Is.EqualTo(133));
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 1; i <= rolls; i++)
            {
                _game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }
    }
}
