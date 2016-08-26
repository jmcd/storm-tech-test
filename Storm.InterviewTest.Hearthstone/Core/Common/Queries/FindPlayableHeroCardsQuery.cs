using System.Collections.Generic;
using System.Linq;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Common.Queries
{
    public class FindPlayableHeroCardsQuery
    {
        private readonly IHearthstoneCardCache cache;

        public FindPlayableHeroCardsQuery(IHearthstoneCardCache cache)
        {
            this.cache = cache;
        }

        public IEnumerable<HeroCard> Execute()
        {
            return cache.FindAll<HeroCard>().Where(x => x.Id.StartsWith("HERO"));
        }
    }
}