using Tweetinvi.Client.Requesters;

namespace Tweetinvi.Client
{
    public interface IRawExecutors
    {
        IAccountActivityRequester AccountActivity { get; }
        IAccountSettingsRequester AccountSettings { get; }
        IAuthRequester Auth { get; }
        IExecuteRequester Execute { get; }
        IHelpRequester Help { get; }
        ISearchRequester Search { get; }
        ITimelinesRequester Timelines { get; }
        ITweetsRequester Tweets { get; }
        ITwitterListsRequester Lists { get; }
        IUploadRequester Upload { get; }
        IUsersRequester Users { get; }
    }
}