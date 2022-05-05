using System;

namespace DLL.Entities
{
    public class ActivationCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime AtActivated { get; set; }
        public string MacAddress { get; set; }
        public string Uuid { get; set; }
        public string Server { get; set; }
        public string HardwareId { get; set; }
        public string CodeType { get; set; }
        public string SentToEmail { get; set; }
        public int Days { get; set; }
        public DateTime AtEnd { get; set; }
        public bool IsActivated { get; set; }
        public bool IsSuspended { get; set; }
        public int Requests { get; set; }
    }
}
