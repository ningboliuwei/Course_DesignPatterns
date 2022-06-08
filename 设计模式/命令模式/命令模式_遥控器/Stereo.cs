namespace 命令模式_遥控器;

public class Stereo {
    public void On() {
        Console.WriteLine("音响打开");
    }

    public void SetCD() {
        Console.WriteLine("设置播放源为 CD");
    }

    public void SetVolume(int volume) {
        Console.WriteLine($"设置音量为{volume}");
    }
}