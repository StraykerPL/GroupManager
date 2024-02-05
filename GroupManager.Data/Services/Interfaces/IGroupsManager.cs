using GroupManager.Data.Models;

namespace GroupManager.Data.Services.Interfaces
{
    public interface IGroupsManager
    {
        void AddUserToGroup(User selectedUser, Group selectedGroup);

        void RemoveUserFromGroup(User selectedUser, Group selectedGroup);

        string LogAction(LogActionType type, User user, Group group);
    }
}