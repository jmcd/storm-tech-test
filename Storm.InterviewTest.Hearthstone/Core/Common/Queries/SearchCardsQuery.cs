using System.Collections.Generic;
using System.Linq;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Common.Queries
{
    public class SearchCardsQuery
    {
        private readonly IHearthstoneCardCache cache;

        public SearchCardsQuery(IHearthstoneCardCache cache)
        {
            this.cache = cache;
        }

        public IEnumerable<ICard> Execute(string queryText)
        {
            var qt = queryText ?? "";
            return cache.FindAll<ICard>().Where(x => x.Name.Contains(qt) || x.Type.ToString() == qt || x.PlayerClass == qt);
        }
    }
}