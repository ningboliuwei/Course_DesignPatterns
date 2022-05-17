namespace 命令模式_遥控器;

public class GarageDoorCloseCommand : ICommand {
    private readonly GarageDoor _door;

    public GarageDoorCloseCommand(GarageDoor door) {
        _door = door;
    }

    public void Execute() {
        _door.Down();
    }
}