namespace Zero2UndubProcess.Constants
{
    public static class GameRegionConstants
    {
        public static class EuIsoConstants
        {
            public const int NumberFiles = 0x879;
            public const long FileTableStartAddress = 0xA63000;
            public const long FileTypeTableStartAddress = 0x2082D000;
            public const long FileArchiveStartAddress = 0x30D40000;
        }
        
        public static class UsIsoConstants
        {
            public const int NumberFiles = 0x106B;
            public const long FileTableStartAddress = 0x2F90B8;
            public const long FileTypeTableStartAddress = 0x3055C0;
            public const long FileArchiveStartAddress = 0x30D40000;
        }

        public static class JpIsoConstants
        {
            public const int NumberFiles = 0x106B;
            public const long FileTableStartAddress = 0x002F85F8;
            public const long FileTypeTableStartAddress = 0x304B00;
            public const long FileArchiveStartAddress = 0x30D40000;
        }
    }
}