using GroupManager.Data.Models;
using GroupManager.Data.Services.Interfaces;

namespace GroupManager.Data.Services
{
    public sealed class DefaultGroupsManager : IGroupsManager
    {
        public void AddUserToGroup(User selectedUser, Group selectedGroup)
        {
            if (selectedGroup is not null && !selectedGroup.Users.Any(user => user.Id == selectedUser.Id))
            {
                selectedGroup.Users.Add(selectedUser);

                LogAction(LogActionType.Add, selectedUser, selectedGroup);
            }
        }

        public void RemoveUserFromGroup(User selectedUser, Group selectedGroup)
        {
            if (selectedGroup is not null)
            {
                var userToRemove = selectedGroup.Users.FirstOrDefault(user => user.Id == selectedUser.Id);
                selectedGroup.Users.Remove(userToRemove ?? throw new NullReferenceException());

                LogAction(LogActionType.Remove, selectedUser, selectedGroup);
            }
        }

        public string LogAction(LogActionType type, User user, Group group)
        {
            switch (type)
            {
                case LogActionType.Add:
                    return string.Format("Użytkownik {0} {1} został przeniesiony do Grupy {2}", user.Name, user.Surename, group.Id);

                case LogActionType.Remove:
                    return string.Format("Użytkownik {0} {1} został usunięty z Grupy {2}", user.Name, user.Surename, group.Id);

                default: throw new Exception();
            }
        }
    }
}