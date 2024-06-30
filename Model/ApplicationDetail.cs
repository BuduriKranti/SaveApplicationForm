using System;
using System.Collections.Generic;

namespace SaveApplicationForm.Model
{
    public partial class ApplicationDetail
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public long Adhar { get; set; }
        public string Email { get; set; } = null!;
        public string AddressName { get; set; } = null!;
        public string City { get; set; } = null!;
        public int Pincode { get; set; }
        public long PhoneNumber { get; set; }
    }
}
