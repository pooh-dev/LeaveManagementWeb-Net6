namespace LeaveManagement.Web.Data
{
    public abstract class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
