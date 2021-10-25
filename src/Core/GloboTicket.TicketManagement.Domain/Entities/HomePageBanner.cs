﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class HomePageBanner
    {
        public Guid ID { get; set; }
        public string ImageSource { get; set; }
        public Guid ProductID { get; set; }
        public string IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
