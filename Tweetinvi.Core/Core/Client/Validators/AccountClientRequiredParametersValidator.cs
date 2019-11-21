using System;
using System.Linq;
using Tweetinvi.Core.QueryValidators;
using Tweetinvi.Parameters;

namespace Tweetinvi.Core.Client.Validators
{
    public interface IAccountClientRequiredParametersValidator : IAccountClientParametersValidator
    {
    }
    
    public class AccountClientRequiredParametersValidator : IAccountClientRequiredParametersValidator
    {
        private readonly IUserQueryValidator _userQueryValidator;

        public AccountClientRequiredParametersValidator(IUserQueryValidator userQueryValidator)
        {
            _userQueryValidator = userQueryValidator;
        }
        
        public void Validate(IGetAuthenticatedUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IBlockUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IUnblockUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IReportUserForSpamParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IGetBlockedUserIdsParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetBlockedUsersParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IFollowUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IUnFollowUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IGetUserIdsRequestingFriendshipParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetUsersRequestingFriendshipParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetUserIdsYouRequestedToFollowParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetUsersYouRequestedToFollowParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IUpdateRelationshipParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IGetRelationshipsWithParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            if (parameters.Users == null)
            {
                throw new ArgumentNullException($"{nameof(parameters)}.{nameof(parameters.Users)}");
            }
            
            if (parameters.Users.All(user => (user.Id == null || user.Id == TweetinviSettings.DEFAULT_ID) && string.IsNullOrEmpty(user.ScreenName)))
            {
                throw new ArgumentException("At least 1 valid user identifier is required.", $"{nameof(parameters)}.{nameof(parameters.Users)}");
            }
        }

        public void Validate(IGetUserIdsWhoseRetweetsAreMutedParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetMutedUserIdsParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IGetMutedUsersParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
        }

        public void Validate(IMuteUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }

        public void Validate(IUnMuteUserParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            _userQueryValidator.ThrowIfUserCannotBeIdentified(parameters.User, $"{nameof(parameters)}.{nameof(parameters.User)}");
        }
    }
}