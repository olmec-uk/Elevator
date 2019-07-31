namespace Interfaces
{
	public interface IElevatorControls
	{
		void CallElevator(Floor floor, Direction direction);
		void SelectDestination(Floor floor);
	}
}
