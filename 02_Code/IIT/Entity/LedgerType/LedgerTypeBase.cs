
namespace Entity.LedgerType
{
    public abstract class LedgerTypeBase
    {
        public object DoorNumber { get; set; }
        public object Area { get; set; }
        public object City { get; set; }
        public object PinCode { get; set; }
        public object OpeningBalance { get; set; }
        public object BankID { get; set; }
        public object AccountNumber { get; set; }
        public object AccountHolderName { get; set; }
        public object IFSCCode { get; set; }
        public object BranchName { get; set; }
        public object IsTDSApplicable { get; set; }
        public object TDSRate { get; set; }
        public object IsTCSApplicable { get; set; }
        public object TCSRate { get; set; }
        public object EmployeeLocation { get; set; }
    }
}
