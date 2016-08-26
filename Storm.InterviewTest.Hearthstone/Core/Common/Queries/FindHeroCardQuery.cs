using System.Linq;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Common.Queries
{
    public class FindHeroCardQuery
    {
        private readonly IHearthstoneCardCache cache;

        public FindHeroCardQuery(IHearthstoneCardCache cache)
        {
            this.cache = cache;
        }

        public HeroCard Execute(string playerClass)
        {
            var heroCards = cache.FindAll<HeroCard>();
            var card = heroCards.FirstOrDefault(x => x.PlayerClass == playerClass && x.Id.StartsWith("HERO"));
            return card;
        }
    }
}