using Microsoft.EntityFrameworkCore;
using Validator.Application.IRepositories;
using Validator.Domain.Entities;
using Validator.Infrastructure.Data;

namespace Validator.Infrastructure.Repositories;

public class JoinEventRepository : IJoinEventRepository
{
    private readonly DBC _db;
    public JoinEventRepository(DBC db) => _db = db;




    public async Task<IEnumerable<JoinEvent>> GetAllRequests()
    {
        var requests = await _db.JoinEvents.ToListAsync();
        return requests;
    }

    public async Task<bool> RequestJoinEvent(JoinEvent joinEvent)
    {
        await _db.JoinEvents.AddAsync(joinEvent);
        await _db.SaveChangesAsync();
        return true;
    }
    public async Task<bool> ApproveRequest(int id, JoinEvent joinEvent)
    {
        var request = await _db.JoinEvents.FindAsync(id);
        request.ApproveRequest();
        await _db.SaveChangesAsync();
        return true;
    }

}