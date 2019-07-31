using System;

namespace Interfaces
{
    public interface IElevatorStatus
    {
	    event Action<Floor, Direction> FloorChanged;
    }
}
