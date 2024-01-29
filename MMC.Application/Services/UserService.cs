using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public UserService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<UserGetDTO> FindAsync(Guid id)
    {
        var user = await _uow.UserRepository.GetAsync(id);

        if (user is null) return null;

        return _map.Map<UserGetDTO>(user);
    }
    public async Task<IEnumerable<UserGetDTO>> FindAllAsync()
    {
        var users = await _uow.UserRepository.GetAllAsync();

        if (users is null) return null;

        return _map.Map<IEnumerable<UserGetDTO>>(users);
    }
    public async Task<UserGetDTO> CreateAsync(UserPostDTO userPostDTO)
    {
        var user = _map.Map<User>(userPostDTO);
        if (!await _uow.UserRepository.PostAsync(user))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<UserGetDTO>(user);
    }
    public async Task<UserGetDTO> UpdateAsync(UserPutDTO userPutDTO)
    {
        var user = _map.Map<User>(userPutDTO);
        var updatedUser = await _uow.UserRepository.PutAsync(user.Id, user);

        await _uow.CompleteAsync();
        return _map.Map<UserGetDTO>(updatedUser);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.UserRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}