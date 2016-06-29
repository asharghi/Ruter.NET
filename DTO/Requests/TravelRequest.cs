namespace RuterServices.DTO.Requests
{
    public class TravelRequest
    {
        /// <summary>
        /// Either: StopID ("3010011" for Jernbanetorget (t-bane)) or AreaID ("1000021097" for Haugerud #) or Coordinate ("(x=600000,y=6642000)" on UTM32 format)
        /// </summary>
        public string FromPlace { get; set; }

        /// <summary>
        /// Same as fromplace
        /// </summary>
        public string ToPlace { get; set; }

        /// <summary>
        /// True if journey is to take place after "time". False if journey is to end before "time".
        /// </summary>
        public bool IsAfter { get; set; }

        /// <summary>
        /// Format: ddMMYYYYhhmmss
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Additional minutes needed for interchange (default: 0, max: 99)
        /// </summary>
        public string Changemargin { get; set; }

        /// <summary>
        /// Minutes punishment for an interchange.Set to a high value (like 30) to prioritize journeys without interchange(default: 8, max: 199)
        /// </summary>
        public string Changepunish { get; set; }

        /// <summary>
        /// Walking speed in percent of default (which is 70 m/min). Default: 100, max: 999
        /// </summary>
        public string Walkingfactor { get; set; }

        /// <summary>
        /// How many different TravelProposals to return (should be between 1 and 10, max: 40)
        /// </summary>
        public string Proposals { get; set; }

        /// <summary>
        /// Filter results with only these transport types (default: "", max: "AirportBus,Bus,AirportTrain,Train,Boat,Metro,Tram")
        /// </summary>
        public string Transporttypes { get; set; }

        /// <summary>
        /// Maximum minutes a person should walk to a stop.
        /// </summary>
        public string Maxwalkingminutes { get; set; }

        /// <summary>
        /// Filter results to lines with only these names(like "T6,1,2,5") (default: "")
        /// </summary>
        public string Linenames { get; set; }

        /// <summary>
        /// Increase this value to have as little walking as possible in the travel proposals. Lower values give more direct connections, but longer walks. Default is 5.
        /// </summary>
        public string Walkreluctance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WaitAtBeginningFactor { get; set; }

    }
}
