using System.Collections.Generic;

namespace windows.licenser
{
    public static class LicenseEditionProvider
    {
        public static IEnumerable<LicensePair> GetLicensePairs() 
            => new List<LicensePair>()
            {
                new LicensePair()
                {
                    Value = ("Home", "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"),
                },
                new LicensePair()
                {
                    Value = ("Home N", "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"),
                },
                new LicensePair()
                {
                    Value = ("Home Single Language", "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"),
                },
                new LicensePair()
                {
                    Value = ("Home Country Specific", "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR"),
                },
                new LicensePair()
                {
                    Value = ("Professional", "W269N-WFGWX-YVC9B-4J6C9-T83GX"),
                },
                new LicensePair()
                {
                    Value = ("Professional N", "MH37W-N47XK-V7XM9-C7227-GCQG9"),
                },
                new LicensePair()
                {
                    Value = ("Education", "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"),
                },
                new LicensePair()
                {
                    Value = ("Education N", "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"),
                },
                new LicensePair()
                {
                    Value = ("Enterprise", "NPPR9-FWDCX-D2C8J-H872K-2YT43"),
                },
                new LicensePair()
                {
                    Value = ("Enterprise N", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"),
                },
            };
    }
}