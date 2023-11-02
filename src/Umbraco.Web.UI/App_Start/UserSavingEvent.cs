using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Umbraco.Cms.Web.UI.App_Start
{
    public class UserSavingEvent : INotificationHandler<UserSavingNotification>
    {
        public void Handle(UserSavingNotification notification)
        {
            notification.Cancel = true;
        }
    }

    public class UserSavingEventComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.AddNotificationHandler<UserSavingNotification, UserSavingEvent>();
        }
    }
}
