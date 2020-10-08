using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Data;
using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Contracts
{ 
    public interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
    }
}
