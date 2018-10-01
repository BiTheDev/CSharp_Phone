namespace Phone{

    public abstract class Phone{
        public string _versionNumber;
        public int _batterPercentage;
        public string _carrier;
        public string _ringTone;

        public Phone(string versionNumber, int batteryPerentage, string carrier, string ringTone){
            _versionNumber = versionNumber;
            _batterPercentage = batteryPerentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }

        public abstract void DisplayINfo();
    }
}