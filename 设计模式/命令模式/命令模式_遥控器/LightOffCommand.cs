namespace 命令模式_遥控器;

public class LightOffCommand : ICommand {
    private readonly Light _light;

    public LightOffCommand(Light light) {
        _light = light;
    }

    public void Execute() {
        _light.Off();
    }

    public void Undo() {
        throw new NotImplementedException();
    }
}