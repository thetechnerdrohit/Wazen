﻿using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class StaticContentRepository : BaseRepository<StaticContent>, IStaticContentRepository
    {
        private readonly ILogger _logger;
        public StaticContentRepository(GloboTicketDbContext dbContext, ILogger<StaticContent> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }
    }
}
