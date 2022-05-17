namespace 命令模式_遥控器;

public interface ICommand {
    public void Execute();
    public void Undo();
}