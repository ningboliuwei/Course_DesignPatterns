namespace 命令模式_遥控器;

public class RemoteControlWithCommandQueue {
    private readonly List<ICommand> _commands = new();

    public void AddCommand(ICommand command) {
        _commands.Add(command);
    }

    public void StartButtonPressed() {
        foreach (var command in _commands) {
            command.Execute();
        }
    }

    public void UndoButtonPressed() {
        foreach (var command in _commands) {
            command.Undo();
        }
    }
}