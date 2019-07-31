using Interfaces;

namespace ElevatorRunner
{
	public class Person
	{
		public Floor StartingFloor { get; set; }
		public Floor Destination { get; set; }

		public Direction Direction => (int)StartingFloor < (int)Destination ? Direction.Up : Direction.Down;

		public int DelayInSeconds { get; set; }
		public Status Status { get; set; } = Status.Approaching;
	}
}