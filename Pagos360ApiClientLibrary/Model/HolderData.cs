using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class HolderData
    {

        [DataMember(Name = "holder_name", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        [DataMember(Name = "holder_email", EmitDefaultValue = false)]
        public string HolderEmail { get; set; }

        [DataMember(Name = "holder_id_number", EmitDefaultValue = false)]
        public string HolderIdNumber { get; set; }

        [DataMember(Name = "holder_phone_number", EmitDefaultValue = false)]
        public string HolderPhoneNumber { get; set; }

    }
}