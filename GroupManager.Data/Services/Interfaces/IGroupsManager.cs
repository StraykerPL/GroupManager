using GroupManager.Data.Models;

namespace GroupManager.Data.Services.Interfaces
{
    public interface IGroupsManager
    {
        string LogAction(LogActionType type, User user, string groupName);
    }
}