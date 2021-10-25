﻿using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.UpdateStaticContent
{
    public class UpdateStaticContentCommand : IRequest<Response<Guid>>
    {
        public Guid ID { get; set; }
        public string AboutUs { get; set; }
        public string TermsAndCondition { get; set; }
        public string PartnerName { get; set; }
        public string PartnerLogo { get; set; }
        public string RedirectedURL { get; set; }
        public string Status { get; set; }
        public string NameOfTheCompany { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string SocialMediaIcon { get; set; }
        public string SocialMediaLink { get; set; }
        public string WebsiteLink { get; set; }
        public string GoogleLocation { get; set; }
    }
}
