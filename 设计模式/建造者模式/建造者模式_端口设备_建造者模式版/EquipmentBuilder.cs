namespace 建造者模式_端口设备_建造者模式版 {
    public abstract class EquipmentBuilder {
        protected Equipment m_equipment;

        protected Machine m_machine;

        public EquipmentBuilder() {
            m_equipment = new Equipment();
        }

        public EquipmentBuilder(string equipmentName) {
            m_equipment = new Equipment();
            m_equipment.Name = equipmentName;
        }

        public virtual void BuildMachine(string machineName) {
            m_machine = new Machine(machineName);
            m_equipment.Machine = m_machine;
        }

        public abstract void BuildPort();

        public Equipment GetEquipment() {
            return m_equipment;
        }
    }
}