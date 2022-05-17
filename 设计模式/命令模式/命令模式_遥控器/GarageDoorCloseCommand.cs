namespace 命令模式_遥控器;

public class GarageDoorOpenCommand : ICommand {
    private readonly GarageDoor _door;

    public GarageDoorOpenCommand(GarageDoor door) {
        _door = door;
    }

    public void Execute() {
        _door.Up();
    }
}