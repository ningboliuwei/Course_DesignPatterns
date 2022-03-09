namespace 实验12_观察者模式_气象站 {
    internal class TrafficData : Data {
        public string Status;
        public string Street;

        public void SetStatus(string street, string status) {
            Street = street;
            Status = status;

            NotifyDevices();
        }
    }
}