namespace 命令模式_遥控器;

public class ComplexRemoteControl {
    private readonly ICommand[,] _slots = new ICommand[7, 2];

    // 记录前一个命令
    private ICommand _undoCommand;

    public void OffButtonPressed(int slotIndex) {
        _undoCommand = _slots[slotIndex, 1];
        _slots[slotIndex, 1].Execute();
    }

    public void OnButtonPressed(int slotIndex) {
        _undoCommand = _slots[slotIndex, 0];
        _slots[slotIndex, 0].Execute();
    }

    public void SetCommand(int slotIndex, ICommand onCommand, ICommand offCommand) {
        _slots[slotIndex, 0] = onCommand;
        _slots[slotIndex, 1] = offCommand;
    }

    public void UndoButtonPressed() {
        _undoCommand.Undo();
    }
}