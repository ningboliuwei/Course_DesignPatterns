namespace 建造者模式_端口设备_工厂版 {
    internal class SimpleLCDFactory {
        public static Equipment CreateInputEquipment(string equipmentName) {
            var machine = new Machine("InputMachine");
            machine.PortType = "Input";
            Port inputPort = new InputPort();
            var equipment = new Equipment();
            equipment.Machine = machine;
            equipment.Name = equipmentName;
            equipment.AddPort(inputPort);

            return equipment;
        }

        public static Equipment CreateInputOutputEquipment(string equipmentName) {
            var machine = new Machine("InputOutputMachine");
            machine.PortType = "InputOutput";
            Port inputPort = new InputPort();
            Port outputPort = new OutputPort();
            var equipment = new Equipment();
            equipment.Machine = machine;
            equipment.Name = equipmentName;
            equipment.AddPort(inputPort);
            equipment.AddPort(outputPort);

            return equipment;
        }

        public static Equipment CreateOutputEquipment(string equipmentName) {
            var machine = new Machine("OutputMachine");
            machine.PortType = "Output";
            Port outputPort = new OutputPort();
            var equipment = new Equipment();
            equipment.Machine = machine;
            equipment.Name = equipmentName;
            equipment.AddPort(outputPort);
            return equipment;
        }
    }
}