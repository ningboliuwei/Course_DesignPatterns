#region

using 命令模式_遥控器;

#endregion

// var remote = new SimpleRemoteControl();
// var light = new Light();
// var lightOnCommand = new LightOnCommand(light);
// var garageDoor = new GarageDoor();
// var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
// var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
// remote.SetCommand(garageDoorCloseCommand);
// remote.ButtonPressed();

var remote = new ComplexRemoteControl();
var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);

var garageDoor = new GarageDoor();
var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

remote.SetCommand(0, lightOnCommand, lightOffCommand);
remote.SetCommand(1, garageDoorOpenCommand, garageDoorCloseCommand);

remote.OnButtonPressed(0);
remote.OffButtonPressed(0);
remote.OnButtonPressed(1);
remote.OffButtonPressed(1);
//
// var stereo = new Stereo();
// var stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
//
// remote.SetCommand(2, stereoOnWithCDCommand, null);
// remote.OnButtonPressed(2);
//

// var light = new Light();
// var lightOnCommand = new LightOnCommand(light);
// var lightOffCommand = new LightOffCommand(light);
//
// var garageDoor = new GarageDoor();
// var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
// var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
//
// var remote = new RemoteControlWithCommandQueue();
// remote.AddCommand(lightOnCommand);
// remote.AddCommand(garageDoorOpenCommand);
// remote.StartButtonPressed();
// remote.UndoButtonPressed();

Console.ReadKey();