using System.Collections.Generic;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Features.Cards
{
    public interface IHearthstoneCardCache
    {
        TCard GetById<TCard>(string id) where TCard : ICard;
        IEnumerable<TCard> FindAll<TCard>() where TCard : ICard;
    }
}