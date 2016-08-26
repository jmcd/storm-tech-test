using System.Collections.Generic;
using System.Linq;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Features.Cards.Services
{
    public class HearthstoneCardCache : IHearthstoneCardCache
    {
        private readonly IEnumerable<ICard> _cards;

        public HearthstoneCardCache(IEnumerable<ICard> cards)
        {
            _cards = cards;
        }

        public TCard GetById<TCard>(string id) where TCard : ICard
        {
            return _cards.OfType<TCard>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TCard> FindAll<TCard>() where TCard : ICard
        {
            return _cards.OfType<TCard>();
        }
    }
}