namespace 命令模式_遥控器;

public class SimpleRemoteControl {
    private ICommand _slot;

    public void ButtonPressed() {
        _slot.Execute();
    }

    public void SetCommand(ICommand command) {
        _slot = command;
    }
}