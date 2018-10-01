namespace Phone{
    public class Galaxy: Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone){
           
        }
            
            public string Ring(){
                return $" ... {_ringTone} ...";

            }

            public string Unlock()
            {
                return ($"Galaxy {_versionNumber} unlocked with fingerprint scanner");
            }

            public override void DisplayINfo()
            {
                System.Console.WriteLine("###############");
                System.Console.WriteLine("Galaxy" + _versionNumber) ;
                System.Console.WriteLine("Battery Percentage:" + _batterPercentage);
                System.Console.WriteLine("Carrier:" + _carrier);
                System.Console.WriteLine("Ring Tone" + _ringTone);
                System.Console.WriteLine("###############");
            }
        

    }
}