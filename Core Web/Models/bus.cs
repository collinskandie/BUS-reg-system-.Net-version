namespace Bus_REG_system.Models
{
    //table bus
    public class bus
    {
        //table ptoperties.
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string BusName { get; set; }
        public int OwnersID { get; set; }
        public int DriversID { get; set; }
        public int SaccoId { get; set; }

        public bus()
        {

        }   
    }
}
