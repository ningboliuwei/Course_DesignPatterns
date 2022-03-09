namespace 建造者模式_端口设备_建造者模式版 {
    internal class OutputEquipmentBuilder : EquipmentBuilder {
        public OutputEquipmentBuilder(string equipmentName)
            : base(equipmentName) {
        }

        public override void BuildMachine(string machineName) {
            base.BuildMachine(machineName);
            m_machine.PortType = "OutputPort";
        }

        public override void BuildPort() {
            Port outputPort = new OutputPort();

            m_equipment.AddPort(outputPort);
        }
    }
}